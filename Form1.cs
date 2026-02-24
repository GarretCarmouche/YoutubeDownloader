using System.Diagnostics;
using System.IO.Compression;
using System.Net;
using static System.Net.Mime.MediaTypeNames;

namespace YoutubeDownloader
{
    public partial class Form1 : Form
    {

        private string youtubeDlPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) +
            "\\Downloads\\YoutubeDownloader\\yt-dlp.exe";
        private string ffmpegPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) +
            "\\Downloads\\YoutubeDownloader\\ffmpeg.exe";
        private string ffPlayPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) +
            "\\Downloads\\YoutubeDownloader\\ffplay.exe";
        private string ffprobePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) +
            "\\Downloads\\YoutubeDownloader\\ffprobe.exe";
        private string ffmpegDownloadPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) +
            "\\Downloads\\YoutubeDownloader\\ffmpeg.zip";
        private string ffmpegExtractPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) +
            "\\Downloads\\YoutubeDownloader\\ffmpegExtract";
        private string ffmpegDownload = "https://github.com/yt-dlp/FFmpeg-Builds/releases/download/latest/ffmpeg-master-latest-win64-gpl.zip";
        private string youtubeDlDownload = "https://github.com/yt-dlp/yt-dlp/releases/latest/download/yt-dlp.exe";
        private string defaultSavePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads";
        private bool downloading = false;
        private bool installing = false;

        public Form1()
        {

            InitializeComponent();

            mp4Format.Checked = true;
            directoryBox.Text = defaultSavePath;

            CheckForYoutubeDlAsync();

            downloadButton.Click += (s, e) => InitiateDownload();
            reinstallButton.Click += (s, e) => ReinstallDependenciesAsync();

            urlTextBox.KeyDown += BoxKeyDown;
            directoryBox.KeyDown += BoxKeyDown;
        }

        private void BoxKeyDown(object? sender, KeyEventArgs e)
        {
            if(urlTextBox.Focused && e.KeyCode == Keys.Enter)
            {
                InitiateDownload();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }else if(directoryBox.Focused && e.KeyCode == Keys.Enter)
            {
                InitiateDownload();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private string? FindFileInDirectory(string directory, string fileName)
        {
            if(File.Exists(directory + $"\\{fileName}"))
            {
                return directory + $"\\{fileName}";
            }

            foreach(string subdirectory in Directory.GetDirectories(directory.ToString() + ""))
            {
                return FindFileInDirectory(subdirectory, fileName);
            }

            return null;
        }

        private async void ReinstallDependenciesAsync()
        {
            if (downloading)
                return;

            installing = true;
            WriteOutput("Reinstalling dependencies...");

            DirectoryInfo? parentDirectory = Directory.GetParent(youtubeDlPath);
            if(parentDirectory != null)
            {
                if (Directory.Exists(parentDirectory.FullName))
                {
                    Directory.Delete(parentDirectory.FullName, true);
                }
            }

            CheckForYoutubeDlAsync();
        }

        private async void CheckForYoutubeDlAsync()
        {
            installing = true;
            await Task.Run(() =>
            {
                DirectoryInfo? parentDirectory = Directory.GetParent(youtubeDlPath);
                if (parentDirectory != null)
                {
                    if (!Directory.Exists(parentDirectory.FullName))
                    {
                        WriteOutput("Programs directory not found. Creating...");
                        Directory.CreateDirectory(parentDirectory.FullName);
                    }
                }
                else
                {
                    Environment.Exit(1);
                }

                if (!File.Exists(youtubeDlPath))
                {
                    WriteOutput("yt-dlp not found. Installing...");
                    using (var client = new HttpClient())
                    {
                        using (var s = client.GetStreamAsync(youtubeDlDownload))
                        {
                            using (var fs = new FileStream(youtubeDlPath, FileMode.Create))
                            {
                                s.Result.CopyTo(fs);
                            }
                        }
                    }
                }

                if (!File.Exists(ffmpegPath) || !File.Exists(ffPlayPath) || !File.Exists(ffprobePath))
                {
                    WriteOutput("FFMPEG not found. Installing...");
                    using (var client = new HttpClient())
                    {
                        using (var s = client.GetStreamAsync(ffmpegDownload))
                        {
                            using (var fs = new FileStream(ffmpegDownloadPath, FileMode.Create))
                            {
                                s.Result.CopyTo(fs);
                            }
                        }
                    }

                    ZipFile.ExtractToDirectory(ffmpegDownloadPath, ffmpegExtractPath);
                    File.Delete(ffmpegDownloadPath);
                    
                    string? ffmpegFile = FindFileInDirectory(ffmpegExtractPath, "ffmpeg.exe");
                    if(ffmpegFile != null && !File.Exists(ffmpegPath))
                    {
                        File.Move(ffmpegFile, ffmpegPath);
                    }

                    string? ffplayFile = FindFileInDirectory(ffmpegExtractPath, "ffplay.exe");
                    if (ffplayFile != null && !File.Exists(ffPlayPath))
                    {
                        File.Move(ffplayFile, ffPlayPath);
                    }

                    string? ffprobeFile = FindFileInDirectory(ffmpegExtractPath, "ffprobe.exe");
                    if (ffprobeFile != null && !File.Exists(ffprobePath))
                    {
                        File.Move(ffprobeFile, ffprobePath);
                    }

                    WriteOutput("Cleaning up...");
                    foreach(string file in Directory.GetFiles(ffmpegExtractPath))
                    {
                        File.Delete($"{file}");
                    }

                    DirectoryInfo ffmpegExtractDirectory = new DirectoryInfo(ffmpegExtractPath);
                    foreach(DirectoryInfo directory in ffmpegExtractDirectory.GetDirectories())
                    {
                        directory.Delete(true);
                    }

                    Directory.Delete(ffmpegExtractPath);
                }

                WriteOutput("Ready!");
                downloading = false;
                installing = false;
            });
            
        }

        private void InitiateDownload()
        {
            if (downloading || installing)
                return;

            downloading = true;

            downloadButton.Text = "Downloading";
            OutputLabel.Text = "Starting Download...";

            string format = "mp4";
            if (mp4Format.Checked) format = "mp4";
            if (mkvFormat.Checked) format = "mkv";
            if (mp3Format.Checked) format = "mp3";
            if (aacFormat.Checked) format = "aac";

            string path = directoryBox.Text;
            string downloadUrl = urlTextBox.Text;
            Process downloadProcess = new Process();
            downloadProcess.StartInfo.WorkingDirectory = Directory.GetParent(youtubeDlPath).FullName;
            downloadProcess.StartInfo.CreateNoWindow = true;
            downloadProcess.StartInfo.RedirectStandardOutput = true;
            downloadProcess.StartInfo.RedirectStandardError = true;
            downloadProcess.StartInfo.FileName = youtubeDlPath;
            downloadProcess.StartInfo.Arguments = $"-t {format} -P {path} {downloadUrl}";

            List<string> errors = new List<String>();
            downloadProcess.ErrorDataReceived += (s, e) =>
            {
                if (e.Data == null)
                    return;

                errors.Add(e.Data);
                string outputError = "";
                for(int i = 0; i < errors.Count; i++)
                {
                    outputError += errors[i];
                    if(i < errors.Count - 1)
                    {
                        outputError += "\n\n";
                    }
                }

                WriteError(outputError);
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
                downloadButton.Invoke((Action)(() => downloadButton.Text = "Download"));
                downloading = false;
            };

            downloadProcess.Exited += (s, e) =>
            {
                DownloadComplete();
            };
            
            WriteError("");
            downloadProcess.Start();
            downloadProcess.BeginOutputReadLine();
            downloadProcess.BeginErrorReadLine();
        }

        private void DownloadComplete()
        {
            WriteOutput("Download Complete!");
            Thread.Sleep(2250);
            WriteOutput("Ready");
            downloadButton.Invoke((Action)(() => downloadButton.Text = "Download"));
            downloading = false;
        }

        private void WriteError(string? text)
        {
            if (text == null) return;
            if (ErrorBox.InvokeRequired)
                ErrorBox.Invoke((Action)(() => ErrorBox.Text = text));
            else
                ErrorBox.Text = text;
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
