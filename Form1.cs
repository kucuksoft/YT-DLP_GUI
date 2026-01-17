using Microsoft.Web.WebView2.Core;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace indirlistbox
{
    public partial class Form1 : Form
    {
        private FolderBrowserDialog folderBrowserDialog;
        private object installerPath = "C:\\Users\\FERUDUN\\AppData\\Local\\Microsoft\\Edge\\User Data\\Default\\Extensions";
        // public System.Threading.Tasks.Task<Microsoft.Web.WebView2.Core.CoreWebView2BrowserExtension> AddBrowserExtensionAsync(string extensionFolderPath);
        CoreWebView2DownloadOperation downloadOperation;
        private delegate void InvokeWithString(string text);
        // string exePath = @"C:\ffmpeg\bin\yt-dlp.exe";
        public Form1()
        {
            InitializeComponent();
            InitializeControls();
            CheckYtDlp(); // Uygulama başlatıldığında yt-dlp.exe kontrolü
            StartHttpServer(); // HTTP sunucusunu başlat
                               // Oynatma listesi çift tıklama olayına oynatma metodunu bağla
            playlistBox.DoubleClick += playButton_Click;
            // InstallEdgeExtension(); // Edge uzantısını yükle
            this.Resize += new System.EventHandler(this.Form_Resize);
            webView.NavigationStarting += EnsureHttps;
            Control.CheckForIllegalCrossThreadCalls = false;

        }
        #region Edge Extension
        private void WebView_CoreWebView2InitializationCompleted(object sender, CoreWebView2InitializationCompletedEventArgs e)
        {
            webView.CoreWebView2.DownloadStarting += CoreWebView2_DownloadStarting;
        }

        private void CoreWebView2_DownloadStarting(object sender, CoreWebView2DownloadStartingEventArgs e)
        {
            downloadOperation = e.DownloadOperation; // Store the 'DownloadOperation' for later use in events
            downloadOperation.BytesReceivedChanged += DownloadOperation_BytesReceivedChanged; // Subscribe to BytesReceivedChanged event
            downloadOperation.EstimatedEndTimeChanged += DownloadOperation_EstimatedEndTimeChanged; // Subsribe to EstimatedEndTimeChanged event
        }

        private void DownloadOperation_EstimatedEndTimeChanged(object sender, object e)
        {
            outputTextBox.Text = downloadOperation.EstimatedEndTime.ToString(); // Show the progress
        }
        private void DownloadOperation_BytesReceivedChanged(object sender, object e)
        {
            label1.Text = downloadOperation.BytesReceived.ToString(); // Show the progress
        }
        private async void InitializeWebView2()
        {
            await webView.EnsureCoreWebView2Async(null);
            webView.CoreWebView2InitializationCompleted += webViewCoreWebView2InitializationCompleted;
        }
        private void webViewCoreWebView2InitializationCompleted(object sender, CoreWebView2InitializationCompletedEventArgs e)
        {
            CoreWebView2Settings Settings;
            Settings = webView.CoreWebView2.Settings;
            Settings.IsPasswordAutosaveEnabled = true;
            Settings.IsGeneralAutofillEnabled = true;
        }

        void EnsureHttps(object sender, CoreWebView2NavigationStartingEventArgs args)
        {
            String uri = args.Uri;
            if (!uri.StartsWith("https://"))
            {
                args.Cancel = true;
            }
        }

        private async void StartHttpServer()
        {
            try
            {
                HttpListener listener = new HttpListener();
                listener.Prefixes.Add("http://127.0.0.1:5000/");
                listener.Start();

                while (true)
                {
                    HttpListenerContext context = await listener.GetContextAsync();
                    HttpListenerRequest request = context.Request;
                    string url = request.QueryString["url"];
                    if (!string.IsNullOrEmpty(url) && !listBox.Items.Contains(url))
                    {
                        listBox.Invoke(new Action(() => listBox.Items.Add(url)));
                    }

                    HttpListenerResponse response = context.Response;
                    response.StatusCode = 200;
                    response.Close();
                }
            }
            catch (HttpListenerException ex)
            {
                MessageBox.Show("HTTP Listener başlatılamadı: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void goButton_Click(object sender, EventArgs e)
        {
            if (webView != null && webView.CoreWebView2 != null)
            {
                webView.CoreWebView2.Navigate(addressBar.Text);
            }
        }

        private void BTGERİ_Click(object sender, EventArgs e)
        {
            if (webView != null && webView.CoreWebView2 != null)
            {
                webView.CoreWebView2.GoBack();
            }
        }

        private void btİLERİ_Click(object sender, EventArgs e)
        {
            if (webView != null && webView.CoreWebView2 != null)
            {
                webView.CoreWebView2.GoForward();
            }
        }

        private void BTyenile_Click(object sender, EventArgs e)
        {
            if (webView != null && webView.CoreWebView2 != null)
            {
                webView.CoreWebView2.Reload();
            }
        }

        private void BTanasayfa_Click(object sender, EventArgs e)
        {
            if (webView != null && webView.CoreWebView2 != null)
            {
                webView.CoreWebView2.Navigate("https://www.youtube.com");
            }
        }


        private void webView_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            InjectJavaScript();
        }

        private async void InjectJavaScript()
        {
            string script = @"
                let videoLinks = [];
                document.querySelectorAll('a').forEach(a => {
                    if (a.href.includes('youtube.com/watch')) {
                        videoLinks.push(a.href);
                    }
                });
                window.chrome.webview.postMessage(videoLinks);
            ";
            await webView.CoreWebView2.ExecuteScriptAsync(script);
        }

        private void webView_WebMessageReceived(object sender, CoreWebView2WebMessageReceivedEventArgs e)
        {
            var videoLinks = Newtonsoft.Json.JsonConvert.DeserializeObject<List<string>>(e.WebMessageAsJson);
            foreach (var link in videoLinks)
            {
                listBox.Items.Add(link);
            }
        }

        #endregion

        private void Form_Resize(object sender, EventArgs e)
        {
            //webView.Size = this.ClientSize - new System.Drawing.Size(webView.Location);
            // goButton.Left = this.ClientSize.Width - goButton.Width;
            // addressBar.Width = goButton.Left - addressBar.Left;
        }

        private void InitializeControls()
        {
            listBox.DoubleClick += ListBox_DoubleClick; // ListBox çift tıklama olayına metod atanır.

            outputTextBox.Multiline = true;
            outputTextBox.ScrollBars = ScrollBars.Both;
            outputTextBox.BackColor = Color.Black;
            outputTextBox.ForeColor = Color.White;
            outputTextBox.WordWrap = false;
            outputTextBox.MaxLength = 0;
            outputTextBox.TextChanged += (s, ev) =>
            {
                outputTextBox.SelectionStart = outputTextBox.Text.Length;
                outputTextBox.ScrollToCaret();
            };

            folderBrowserDialog = new FolderBrowserDialog();

            formatComboBox.Items.Add("mp4 720p video");
            formatComboBox.Items.Add("mp3");
            formatComboBox.SelectedIndex = 0; // Varsayılan olarak ilk seçeneği seçer
        }

        #region plallist olayı
        private async void Form1_Load(object sender, EventArgs e)
        {
            string playlistFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyVideos), "KARAOKE", "playlist.txt");
            LoadPlaylist(playlistFilePath);
            // CheckAndDownloadExecutables  yt-dlp ve ffmepg indirme ve klasörde varmı                                        
            await CheckAndDownloadExecutables(); // Gerekli dosyaları kontrol et ve indir
            LoadPlaylistFromFolders(); // Klasörlerin içeriğini oynatma listesine yükle
        }
        // playlistBox'a çift tıklanarak oynatma işlemi yapılacak
        private void playlistBox_DoubleClick(object sender, EventArgs e)
        {
            if (playlistBox.SelectedItem != null)
            {
                string filePath = playlistBox.SelectedItem.ToString();
                // VLC ile oynatmaya başla
                PlayMedia(filePath);
            }
        }
        // VLC ile medya oynatma
        private void PlayMedia(string filePath)
        {
            try
            {
                // Dosya yolu geçerli mi?
                if (File.Exists(filePath))
                {
                    string vlcPath = @"C:\Program Files\VideoLAN\VLC\vlc.exe"; // VLC'nin yeri
                    if (!File.Exists(vlcPath))
                    {
                        MessageBox.Show("VLC Media Player bulunamadı. Lütfen kurduğunuzdan emin olun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // VLC ile dosyayı başlat
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = vlcPath,
                        Arguments = $"\"{filePath}\"", // Dosya yolunu argument olarak gönderiyoruz
                        UseShellExecute = true
                    });
                }
                else
                {
                    MessageBox.Show("Dosya bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oynatma sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ListBox_DoubleClick(object sender, EventArgs e)
        {
            if (listBox.SelectedItem != null)
            {
                string videoUrl = listBox.SelectedItem.ToString();
                addressBar.Text = videoUrl;
                webView.CoreWebView2.Navigate(addressBar.Text);
                // Kullanıcının seçtiği yol
                string selectedPath = downloadPathTextBox.Text;

                // Format seçimine göre varsayılan klasör ayarı
                if (string.IsNullOrEmpty(selectedPath))
                {
                    string basePath;
                    if (formatComboBox.SelectedItem.ToString() == "mp3")
                    {
                        basePath = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic); // Müzikler klasörü
                    }
                    else
                    {
                        basePath = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos); // Videolar klasörü
                    }

                    selectedPath = Path.Combine(basePath, "KARAOKE");

                    // KARAOKE klasörünü oluştur
                    if (!Directory.Exists(selectedPath))
                    {
                        Directory.CreateDirectory(selectedPath);
                    }

                    // Varsayılan yolu textBox'a yaz
                    downloadPathTextBox.Text = selectedPath;

                }

                // İndirme işlemini başlat
                Task.Run(() => DownloadVideo(videoUrl, selectedPath));
            }
        }

        private void AddToPlaylist(string filePath)
        {
            if (!string.IsNullOrEmpty(filePath) && File.Exists(filePath))
            {
                playlistBox.Items.Add(filePath); // Dosyayı oynatma listesine ekle
            }
        }
        private void playButton_Click(object sender, EventArgs e)
        {
            if (playlistBox.SelectedItem != null)
            {
                // Seçili dosyanın tam yolunu al
                string filePath = playlistBox.SelectedItem.ToString();

                // VLC Player'ı çalıştır
                string vlcPath = @"C:\Program Files\VideoLAN\VLC\vlc.exe"; // VLC'nin yüklü olduğu yol
                if (File.Exists(vlcPath))
                {
                    var process = new System.Diagnostics.Process();
                    process.StartInfo.FileName = vlcPath;
                    process.StartInfo.Arguments = $"\"{filePath}\""; // Dosya yolunu argüman olarak ekle
                    process.Start();
                }
                else
                {
                    MessageBox.Show("VLC Player yüklü değil veya yolu hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir dosya seçin!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //playlisten dosya silmek için
        private void removeButton_Click(object sender, EventArgs e)
        {
            if (playlistBox.SelectedItem != null)
            {
                playlistBox.Items.Remove(playlistBox.SelectedItem); // Seçili dosyayı oynatma listesinden kaldır
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir dosya seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void SavePlaylist(string filePath)
        {
            File.WriteAllLines(filePath, playlistBox.Items.Cast<string>());
        }
        private void LoadPlaylist(string filePath)
        {
            if (File.Exists(filePath))
            {
                foreach (string line in File.ReadAllLines(filePath))
                {
                    AddToPlaylist(line);
                }
            }
        }

        private void LoadPlaylistFromFolders()
        {
            // Videolar\KARAOKE klasörü yolu
            string videosPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyVideos), "KARAOKE");

            // Videolar\KARAOKE klasörünün içeriğini al
            if (Directory.Exists(videosPath))
            {
                foreach (var file in Directory.GetFiles(videosPath))
                {
                    string fileName = Path.GetFileName(file); // Sadece dosya adını al
                    if (!playlistBox.Items.Contains(fileName)) // Dosya zaten ekli değilse ekle
                    {
                        playlistBox.Items.Add(file);
                        playlistBox.DisplayMember = "Name"; // Görüntülenecek kısmı ayarla (sadece ad).
                    }
                }
            }
        }


        #endregion

        private void selectFolderButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedPath = folderBrowserDialog.SelectedPath;
                downloadPathTextBox.Text = selectedPath;
            }
        }

        #region video indirme


        private void downloadButton_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedItem != null)
            {
                string videoUrl = listBox.SelectedItem.ToString();
                string selectedPath = downloadPathTextBox.Text;
                if (string.IsNullOrEmpty(selectedPath))
                {
                    MessageBox.Show("Lütfen bir klasör seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!IsDirectoryWritable(selectedPath))
                {
                    MessageBox.Show("Klasör yazılabilir değil. Lütfen başka bir klasör seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!IsSafePath(selectedPath))
                {
                    MessageBox.Show("Güvenli olmayan bir klasör seçtiniz. Lütfen başka bir klasör seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Task.Run(() => DownloadVideo(videoUrl, selectedPath));
            }
            else
            {
                MessageBox.Show("Lütfen bir video seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void DownloadVideo(string videoUrl, string downloadPath)
        {
            try
            {
                outputTextBox.Clear();
                string formatOption = formatComboBox.SelectedItem?.ToString();
                string formatArgument = "";

                if (formatOption == "mp4 720p video")
                {
                    formatArgument = "-f bestvideo[height<=720]+bestaudio --merge-output-format mp4";
                    if (subtitlesCheckBox.Checked)
                    {
                        formatArgument += " --sub-lang tr --write-auto-sub";
                    }
                    downloadPath = Path.Combine(downloadPath, "%(title)s.%(ext)s");
                }
                else if (formatOption == "mp3")
                {
                    formatArgument = "-x --audio-format mp3";
                    downloadPath = Path.Combine(downloadPath, "%(title)s.%(ext)s");
                }

                // string exePath = Path.Combine(Application.StartupPath, "yt-dlp.exe");
                string exePath = @"C:\ffmpeg\bin\yt-dlp.exe";
                var process = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = exePath,
                        Arguments = $"{formatArgument} {videoUrl} -o \"{downloadPath}\"",
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        UseShellExecute = false,
                        CreateNoWindow = true,
                    }
                };

                process.OutputDataReceived += (sender, e) =>
                {
                    if (!string.IsNullOrEmpty(e.Data))
                    {
                        outputTextBox.Invoke(new Action(() => outputTextBox.AppendText(e.Data + Environment.NewLine)));
                    }
                };

                process.ErrorDataReceived += (sender, e) =>
                {
                    if (!string.IsNullOrEmpty(e.Data))
                    {
                        outputTextBox.Invoke(new Action(() => outputTextBox.AppendText("Hata: " + e.Data + Environment.NewLine)));
                    }
                };

                process.Start();
                process.BeginOutputReadLine();
                process.BeginErrorReadLine();
                process.WaitForExit();
                string downloadedFilePath = Path.Combine(downloadPath, "indirilen_dosya_adı.mp4"); // Dinamik olarak değiştirin
                AddToPlaylist(downloadedFilePath); // Dosyayı oynatma listesine ekle
            }
            catch (Exception ex)
            {
                outputTextBox.Invoke(new Action(() => outputTextBox.AppendText("Exception: " + ex.Message + Environment.NewLine)));
                // outputTextBox.AppendText("Exception: " + ex.Message + Environment.NewLine);
            }
        }


        #endregion

        #region ytdlp indir

        private async void downloadYtDlpButton_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/yt-dlp/yt-dlp/releases/latest/download/yt-dlp.exe"; // En son sürüm URL'si
                                                                                                 //string exePath = Path.Combine(Application.StartupPath, "yt-dlp.exe");
            string exePath = @"C:\ffmpeg\bin\yt-dlp.exe";
            progressBar.Value = 0; // ProgressBar başlangıç değerini sıfırla
            progressBar.Visible = true; // ProgressBar'ı görünür yap

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    outputTextBox.Clear(); // Output TextBox'u temizle
                    outputTextBox.AppendText("yt-dlp.exe indiriliyor...\n");

                    HttpResponseMessage response = await client.GetAsync(url, HttpCompletionOption.ResponseHeadersRead);
                    response.EnsureSuccessStatusCode();

                    long? totalBytes = response.Content.Headers.ContentLength;
                    if (totalBytes.HasValue)
                    {
                        progressBar.Maximum = 100; // ProgressBar için yüzde değerleri kullan
                    }

                    using (var inputStream = await response.Content.ReadAsStreamAsync())
                    using (var outputStream = new FileStream(exePath, FileMode.Create, FileAccess.Write, FileShare.None))
                    {
                        byte[] buffer = new byte[65536];
                        long totalRead = 0;
                        int bytesRead;

                        while ((bytesRead = await inputStream.ReadAsync(buffer, 0, buffer.Length)) > 0)
                        {
                            await outputStream.WriteAsync(buffer, 0, bytesRead);
                            totalRead += bytesRead;

                            if (totalBytes.HasValue)
                            {
                                // Yüzde hesaplayarak ProgressBar'ı güncelle
                                int percent = (int)((double)totalRead / totalBytes.Value * 100);
                                progressBar.Invoke(new Action(() =>
                                {
                                    progressBar.Value = percent;
                                    proseslabel.Text = $"İndiriliyor: {percent}%";
                                    outputTextBox.Text = $"İndiriliyor: {percent}%\n";
                                }));
                            }
                        }
                    }

                    outputTextBox.Clear();// Textbox temizledik
                    proseslabel.Text = "yt-dlp.exe başarıyla indirildi.";
                    outputTextBox.AppendText("yt-dlp.exe başarıyla indirildi.\n");
                    // MessageBox.Show("yt-dlp.exe başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    outputTextBox.AppendText($"Güncelleme sırasında bir hata oluştu: {ex.Message}\n");
                    MessageBox.Show("Güncelleme sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    progressBar.Visible = false; // İndirme tamamlandığında ProgressBar'ı gizle
                }
            }
        }
        private void CheckYtDlp()
        {
            //string exePath = Path.Combine(Application.StartupPath, "yt-dlp.exe");
            string exePath = @"C:\ffmpeg\bin\yt-dlp.exe";
            if (!File.Exists(exePath))
            {
                DialogResult result = MessageBox.Show("yt-dlp.exe bulunamadı. İndirmek ister misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    downloadYtDlpButton_Click(null, null);
                }
            }
        }

        private void Btytdlpversi_Click(object sender, EventArgs e)
        {
            try
            {
                outputTextBox.Clear();

                string exePath = @"C:\ffmpeg\bin\yt-dlp.exe";
                string arguments = "--version";

                var startInfo = new ProcessStartInfo
                {
                    FileName = exePath,
                    Arguments = "yt-dlp.exe versiyonu= " + arguments,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                var process = new Process
                {
                    StartInfo = startInfo,
                    EnableRaisingEvents = true
                };

                process.OutputDataReceived += new DataReceivedEventHandler(Async_Data_Received);
                process.ErrorDataReceived += new DataReceivedEventHandler(Async_Data_Received);

                process.Start();
                process.BeginOutputReadLine();
                process.BeginErrorReadLine();
            }
            catch (Exception ex)
            {
                outputTextBox.Invoke(new Action(() => outputTextBox.AppendText("Exception: " + ex.Message + Environment.NewLine)));
            }
        }
        //yt dlp exe yolunu secmek için
        private void SelectYtDlpPath()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\";
                openFileDialog.Filter = "Executable files (*.exe)|*.exe";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string exePath = openFileDialog.FileName;
                    // Seçilen yolu kullanarak işlemi başlat
                    // GetYtDlpVersion(exePath);
                }
            }
        }
        //yt dlp exe yolunu secme
        private void Btytdlppath_Click(object sender, EventArgs e)
        {
            SelectYtDlpPath();
        }
        private async Task CheckAndDownloadExecutables()
        {
            string ffmpegPath = @"C:\ffmpeg\bin\ffmpeg.exe";
            string ytdlpPath = @"C:\ffmpeg\bin\yt-dlp.exe";

            if (!File.Exists(ffmpegPath) || !File.Exists(ytdlpPath))
            {
                DialogResult result = MessageBox.Show("Gerekli dosyalar bulunamadı. İndirmek ister misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    string ffmpegUrl = "https://www.gyan.dev/ffmpeg/builds/ffmpeg-release-essentials.zip"; // FFmpeg download URL
                    string ytdlpUrl = "https://github.com/yt-dlp/yt-dlp/releases/latest/download/yt-dlp.exe"; // yt-dlp download URL

                    // Dosyaları indir
                    await DownloadFile(ytdlpUrl, ytdlpPath);
                    await DownloadFile(ffmpegUrl, @"C:\ffmpeg\bin\ffmpeg.zip");

                    // FFmpeg'i zip'ten çıkart
                    ExtractZipFile(@"C:\ffmpeg\bin\ffmpeg.zip", @"C:\ffmpeg\bin");
                }
            }
        }

        #endregion

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedItem != null)
            {
                Clipboard.SetText(listBox.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Kopyalanacak bir öğe seçin.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                listBox.Items.Add(Clipboard.GetText());
            }
            else
            {
                MessageBox.Show("Panoda metin bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private bool IsDirectoryWritable(string directoryPath)
        {
            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo(directoryPath);
                if (!dirInfo.Exists) return false;
                dirInfo.GetAccessControl();
                return true;
            }
            catch (UnauthorizedAccessException)
            {
                return false;
            }
            catch
            {
                return false;
            }
        }
        private bool IsSafePath(string path)
        {
            try
            {
                string fullPath = Path.GetFullPath(path);
                string systemDrive = Path.GetPathRoot(Environment.SystemDirectory);
                string systemFolder = Environment.GetFolderPath(Environment.SpecialFolder.Windows);
                string startupPath = System.Windows.Forms.Application.StartupPath;

                if (fullPath.StartsWith(systemDrive, StringComparison.OrdinalIgnoreCase) ||
                    fullPath.StartsWith(systemFolder, StringComparison.OrdinalIgnoreCase) ||
                    fullPath.StartsWith(startupPath, StringComparison.OrdinalIgnoreCase))
                {
                    return false;
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        #region ekran temizle
        private void button1_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            playlistBox.Items.Clear();
            outputTextBox.Text = string.Empty;
        }
        #endregion

        #region çıkış bilgisi outputtext

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string playlistFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyVideos), "KARAOKE", "playlist.txt");
            SavePlaylist(playlistFilePath);
        }
        private void Async_Data_Received(object sender, DataReceivedEventArgs e)
        {
            if (e.Data != null)
            {
                Invoke(new Action(() => Sync_Output(e.Data)));
            }
        }

        private void Sync_Output(string text)
        {
            outputTextBox.AppendText(text + Environment.NewLine);
            outputTextBox.ScrollToCaret();
        }
        #endregion         

        private async Task DownloadFile(string url, string outputPath)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url, HttpCompletionOption.ResponseHeadersRead);
                    response.EnsureSuccessStatusCode();

                    using (var inputStream = await response.Content.ReadAsStreamAsync())
                    using (var outputStream = new FileStream(outputPath, FileMode.Create, FileAccess.Write, FileShare.None))
                    {
                        byte[] buffer = new byte[8192];
                        int bytesRead;
                        while ((bytesRead = await inputStream.ReadAsync(buffer, 0, buffer.Length)) > 0)
                        {
                            await outputStream.WriteAsync(buffer, 0, bytesRead);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Dosya indirme sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ExtractZipFile(string zipPath, string extractPath)
        {
            try
            {
                System.IO.Compression.ZipFile.ExtractToDirectory(zipPath, extractPath);
                File.Delete(zipPath); // Zip dosyasını sil
            }
            catch (Exception ex)
            {
                MessageBox.Show("Zip dosyası çıkarma sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btlistyenile_Click(object sender, EventArgs e)
        {
            this.LoadPlaylistFromFolders();
        }

        private void Btnindir_Click(object sender, EventArgs e)
        {
            if (this.listBox.SelectedItem == null)
                return;
            string videoUrl = this.listBox.SelectedItem.ToString();
            this.addressBar.Text = videoUrl;
            this.webView.CoreWebView2.Navigate(this.addressBar.Text);
            string selectedPath = this.downloadPathTextBox.Text;
            if (string.IsNullOrEmpty(selectedPath))
            {
                selectedPath = Path.Combine(!(this.formatComboBox.SelectedItem.ToString() == "mp3") ? Environment.GetFolderPath(Environment.SpecialFolder.MyVideos) : Environment.GetFolderPath(Environment.SpecialFolder.MyMusic), "KARAOKE");
                if (!Directory.Exists(selectedPath))
                    Directory.CreateDirectory(selectedPath);
                this.downloadPathTextBox.Text = selectedPath;
            }
            Task.Run((Action)(() => this.DownloadVideo(videoUrl, selectedPath)));
        }

        private void Btnffmpegindir_Click(object sender, EventArgs e)
        {
            this.webView.CoreWebView2.Navigate("https://www.gyan.dev/ffmpeg/builds/");
        }

        private async void Btnvlcindir_Click(object sender, EventArgs e)
        {
            this.Btnvlcindir_ClickAsync(sender, e);
        }

        private async void Btnvlcindir_ClickAsync(object sender, EventArgs e)
        {
            // this.webView.CoreWebView2.Navigate("https://www.videolan.org/vlc/download-windows.html");
            string url = "https://www.videolan.org/vlc/download-windows.html";
            this.webView.CoreWebView2.Navigate(url);
        }

        private void Btnvideobilgi_Click(object sender, EventArgs e)
        {
            this.Txtbinfo.Text = string.Empty;
            if (this.listBox.SelectedItem == null)
                return;
            string str1 = "C:\\ffmpeg\\bin\\yt-dlp.exe" + " " + this.listBox.SelectedItem.ToString() + " --skip-download --dump-single-json --no-check-certificate --restrict-filenames";
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = "/c " + str1;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.Start();
            object obj = JsonConvert.DeserializeObject(process.StandardOutput.ReadToEnd());
            TextBox txtbinfo = this.Txtbinfo;

            string str2 = string.Format("Başlık: {0}\n");

            string str3 = string.Format("Açıklama: {0}\n");
            string str4 = str2 + str3;
            txtbinfo.Text = str4;
            process.WaitForExit();
        }
    }
}


