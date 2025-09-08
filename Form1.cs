using System.Diagnostics;

namespace YoutubeDownloader
{
    public partial class Form1 : Form
    {

        private string youtubeDlPath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + 
            "\\YoutubeDownloader\\yt-dlp.exe";
        private bool downloading = false;

        public Form1()
        {
            InitializeComponent();

            downloadButton.Click += (s, e) => InitiateDownload();
        }

        private void InitiateDownload()
        {
            if(downloading) return;
            downloading = true;

            OutputLabel.Text = "Starting Download...";

            string path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads";
            string downloadUrl = urlTextBox.Text;
            Process downloadProcess = new Process();
            downloadProcess.StartInfo.FileName = youtubeDlPath;
            downloadProcess.StartInfo.WorkingDirectory = Directory.GetParent(youtubeDlPath).FullName;
            downloadProcess.StartInfo.Arguments = $"-t mp4 -P {path} {downloadUrl}";
            downloadProcess.StartInfo.CreateNoWindow = true;
            downloadProcess.StartInfo.RedirectStandardOutput = true;
            downloadProcess.StartInfo.RedirectStandardError = true;
            downloadProcess.ErrorDataReceived += (s, e) =>
            {
                WriteOutput(e.Data);
            };
            downloadProcess.OutputDataReceived += (s, e) =>
            {
                WriteOutput(e.Data);
            };

            downloadProcess.Exited += (s, e) =>
            {
                WriteOutput("Download Complete!");
                downloading = false;
            };

            downloadProcess.Start();
            downloadProcess.BeginOutputReadLine();
        }

        private void WriteOutput(string? text)
        {
            Console.WriteLine(text);
            if (OutputLabel.InvokeRequired)
                OutputLabel.Invoke((Action)(() => OutputLabel.Text = text));
            else
                OutputLabel.Text = text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
