using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

namespace YoutubeDownloader
{
    public partial class Form1 : Form
    {

        private string youtubeDlPath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) +
            "\\YoutubeDownloader\\yt-dlp.exe";
        private string defaultSavePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads";
        private bool downloading = false;

        public Form1()
        {

            InitializeComponent();

            mp4Format.Checked = true;
            directoryBox.Text = defaultSavePath;
            downloadButton.Click += (s, e) => InitiateDownload();
        }

        private void InitiateDownload()
        {
            if (downloading) return;
            downloading = true;

            OutputLabel.Text = "Starting Download...";

            string format = "mp4";
            if (mp4Format.Checked) format = "mp4";
            if (mkvFormat.Checked) format = "mkv";
            if (mp3Format.Checked) format = "mp3";
            if (aacFormat.Checked) format = "aac";

            string path = directoryBox.Text;
            string downloadUrl = urlTextBox.Text;
            Process downloadProcess = new Process();
            downloadProcess.StartInfo.FileName = youtubeDlPath;
            downloadProcess.StartInfo.WorkingDirectory = Directory.GetParent(youtubeDlPath).FullName;
            downloadProcess.StartInfo.Arguments = $"-t {format} -P {path} {downloadUrl}";
            downloadProcess.StartInfo.CreateNoWindow = true;
            downloadProcess.StartInfo.RedirectStandardOutput = true;
            downloadProcess.StartInfo.RedirectStandardError = true;
            downloadProcess.ErrorDataReceived += (s, e) =>
            {
                WriteOutput(e.Data);
            };
            downloadProcess.OutputDataReceived += (s, e) =>
            {
                if (e.Data == null)
                {
                    DownloadComplete();
                    return;
                }

                WriteOutput(e.Data);
            };

            downloadProcess.Disposed += (s, e) =>
            {
                WriteOutput("Process Disposed");
                downloading = false;
            };

            downloadProcess.Exited += (s, e) =>
            {
                DownloadComplete();
            };

            downloadProcess.Start();
            downloadProcess.BeginOutputReadLine();
        }

        private void DownloadComplete()
        {
            WriteOutput("Download Complete!");
            Thread.Sleep(3000);
            WriteOutput("");
            downloading = false;
        }

        private void WriteOutput(string? text)
        {
            if (text == null) return;

            if (OutputLabel.InvokeRequired)
                OutputLabel.Invoke((Action)(() => OutputLabel.Text = text));
            else
                OutputLabel.Text = text;
        }
    }
}
