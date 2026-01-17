namespace indirlistbox
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.listBox = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.formatComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.goButton = new System.Windows.Forms.Button();
            this.BTGERİ = new System.Windows.Forms.Button();
            this.btİLERİ = new System.Windows.Forms.Button();
            this.BTyenile = new System.Windows.Forms.Button();
            this.addressBar = new System.Windows.Forms.TextBox();
            this.BTanasayfa = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.Btnvideobilgi = new System.Windows.Forms.Button();
            this.Txtbinfo = new System.Windows.Forms.TextBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.playlistBox = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Btnindir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.selectFolderButton = new System.Windows.Forms.Button();
            this.downloadPathTextBox = new System.Windows.Forms.TextBox();
            this.subtitlesCheckBox = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.proseslabel = new System.Windows.Forms.Label();
            this.Btytdlpversi = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Btnffmpegindir = new System.Windows.Forms.Button();
            this.Btnvlcindir = new System.Windows.Forms.Button();
            this.Btytdlppath = new System.Windows.Forms.Button();
            this.Btlistyenile = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.BackColor = System.Drawing.Color.Black;
            this.listBox.ContextMenuStrip = this.contextMenuStrip1;
            this.listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox.ForeColor = System.Drawing.Color.White;
            this.listBox.FormattingEnabled = true;
            this.listBox.HorizontalScrollbar = true;
            this.listBox.ItemHeight = 20;
            this.listBox.Location = new System.Drawing.Point(0, 0);
            this.listBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(526, 124);
            this.listBox.TabIndex = 0;
            this.toolTip1.SetToolTip(this.listBox, "Bu alandaki youtube linkine çift tıklayarak indirmeyi başlatınız.");
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.Black;
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.copyToolStripMenuItem,
            this.toolStripSeparator2,
            this.pasteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(146, 68);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.Color.White;
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.White;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(142, 6);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.copyToolStripMenuItem.Text = "KOPYALA";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.BackColor = System.Drawing.Color.White;
            this.toolStripSeparator2.ForeColor = System.Drawing.Color.White;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(142, 6);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.pasteToolStripMenuItem.Text = "YAPIŞTIR";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // outputTextBox
            // 
            this.outputTextBox.BackColor = System.Drawing.Color.Black;
            this.outputTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.outputTextBox.ForeColor = System.Drawing.Color.White;
            this.outputTextBox.Location = new System.Drawing.Point(0, 0);
            this.outputTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(532, 115);
            this.outputTextBox.TabIndex = 1;
            this.toolTip1.SetToolTip(this.outputTextBox, "Bu alanda indirme sürecini izlerseniz.");
            // 
            // formatComboBox
            // 
            this.formatComboBox.BackColor = System.Drawing.Color.Black;
            this.formatComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.formatComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.formatComboBox.ForeColor = System.Drawing.Color.White;
            this.formatComboBox.FormattingEnabled = true;
            this.formatComboBox.Location = new System.Drawing.Point(222, 37);
            this.formatComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.formatComboBox.Name = "formatComboBox";
            this.formatComboBox.Size = new System.Drawing.Size(156, 28);
            this.formatComboBox.TabIndex = 2;
            this.toolTip1.SetToolTip(this.formatComboBox, "Video veya mp3 indirmek için secim penceresi.");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Location = new System.Drawing.Point(4, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(789, 609);
            this.panel1.TabIndex = 3;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.webView);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 125);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(785, 480);
            this.panel8.TabIndex = 22;
            // 
            // webView
            // 
            this.webView.AllowExternalDrop = true;
            this.webView.BackColor = System.Drawing.Color.Black;
            this.webView.CreationProperties = null;
            this.webView.DefaultBackgroundColor = System.Drawing.Color.Black;
            this.webView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView.Location = new System.Drawing.Point(0, 0);
            this.webView.Name = "webView";
            this.webView.Size = new System.Drawing.Size(785, 480);
            this.webView.Source = new System.Uri("https://www.youtube.com", System.UriKind.Absolute);
            this.webView.TabIndex = 16;
            this.webView.ZoomFactor = 1D;
            this.webView.NavigationCompleted += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs>(this.webView_NavigationCompleted);
            this.webView.WebMessageReceived += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2WebMessageReceivedEventArgs>(this.webView_WebMessageReceived);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel10);
            this.panel7.Controls.Add(this.panel9);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(785, 125);
            this.panel7.TabIndex = 21;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.goButton);
            this.panel10.Controls.Add(this.BTGERİ);
            this.panel10.Controls.Add(this.btİLERİ);
            this.panel10.Controls.Add(this.BTyenile);
            this.panel10.Controls.Add(this.addressBar);
            this.panel10.Controls.Add(this.BTanasayfa);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(785, 36);
            this.panel10.TabIndex = 24;
            // 
            // goButton
            // 
            this.goButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.goButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.goButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.goButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.goButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.goButton.Location = new System.Drawing.Point(700, 6);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(75, 27);
            this.goButton.TabIndex = 15;
            this.goButton.Text = "GİT";
            this.goButton.UseVisualStyleBackColor = false;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // BTGERİ
            // 
            this.BTGERİ.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BTGERİ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BTGERİ.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BTGERİ.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.BTGERİ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTGERİ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTGERİ.Location = new System.Drawing.Point(3, 4);
            this.BTGERİ.Name = "BTGERİ";
            this.BTGERİ.Size = new System.Drawing.Size(54, 26);
            this.BTGERİ.TabIndex = 14;
            this.BTGERİ.Text = "GERİ";
            this.BTGERİ.UseVisualStyleBackColor = false;
            this.BTGERİ.Click += new System.EventHandler(this.BTGERİ_Click);
            // 
            // btİLERİ
            // 
            this.btİLERİ.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btİLERİ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btİLERİ.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btİLERİ.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btİLERİ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btİLERİ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btİLERİ.Location = new System.Drawing.Point(63, 5);
            this.btİLERİ.Name = "btİLERİ";
            this.btİLERİ.Size = new System.Drawing.Size(54, 26);
            this.btİLERİ.TabIndex = 18;
            this.btİLERİ.Text = "İLERİ";
            this.btİLERİ.UseVisualStyleBackColor = false;
            this.btİLERİ.Click += new System.EventHandler(this.btİLERİ_Click);
            // 
            // BTyenile
            // 
            this.BTyenile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BTyenile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BTyenile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BTyenile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.BTyenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTyenile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTyenile.Location = new System.Drawing.Point(123, 5);
            this.BTyenile.Name = "BTyenile";
            this.BTyenile.Size = new System.Drawing.Size(66, 26);
            this.BTyenile.TabIndex = 19;
            this.BTyenile.Text = "YENİLE";
            this.BTyenile.UseVisualStyleBackColor = false;
            this.BTyenile.Click += new System.EventHandler(this.BTyenile_Click);
            // 
            // addressBar
            // 
            this.addressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addressBar.ForeColor = System.Drawing.Color.White;
            this.addressBar.Location = new System.Drawing.Point(296, 7);
            this.addressBar.Name = "addressBar";
            this.addressBar.Size = new System.Drawing.Size(398, 26);
            this.addressBar.TabIndex = 17;
            this.addressBar.Text = "https://www.google.com.tr";
            this.toolTip1.SetToolTip(this.addressBar, "URL giriniz.");
            // 
            // BTanasayfa
            // 
            this.BTanasayfa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BTanasayfa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BTanasayfa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BTanasayfa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.BTanasayfa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTanasayfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTanasayfa.Location = new System.Drawing.Point(195, 6);
            this.BTanasayfa.Name = "BTanasayfa";
            this.BTanasayfa.Size = new System.Drawing.Size(95, 26);
            this.BTanasayfa.TabIndex = 20;
            this.BTanasayfa.Text = "ANA SAYFA";
            this.BTanasayfa.UseVisualStyleBackColor = false;
            this.BTanasayfa.Click += new System.EventHandler(this.BTanasayfa_Click);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.Btnvideobilgi);
            this.panel9.Controls.Add(this.Txtbinfo);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(0, 40);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(785, 85);
            this.panel9.TabIndex = 23;
            // 
            // Btnvideobilgi
            // 
            this.Btnvideobilgi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btnvideobilgi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Btnvideobilgi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Btnvideobilgi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.Btnvideobilgi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnvideobilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btnvideobilgi.Location = new System.Drawing.Point(701, 11);
            this.Btnvideobilgi.Name = "Btnvideobilgi";
            this.Btnvideobilgi.Size = new System.Drawing.Size(74, 68);
            this.Btnvideobilgi.TabIndex = 21;
            this.Btnvideobilgi.Text = "Video Bilgi";
            this.Btnvideobilgi.UseVisualStyleBackColor = false;
            this.Btnvideobilgi.Click += new System.EventHandler(this.Btnvideobilgi_Click);
            // 
            // Txtbinfo
            // 
            this.Txtbinfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txtbinfo.BackColor = System.Drawing.Color.Black;
            this.Txtbinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txtbinfo.ForeColor = System.Drawing.Color.White;
            this.Txtbinfo.Location = new System.Drawing.Point(5, 7);
            this.Txtbinfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Txtbinfo.Multiline = true;
            this.Txtbinfo.Name = "Txtbinfo";
            this.Txtbinfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Txtbinfo.Size = new System.Drawing.Size(689, 73);
            this.Txtbinfo.TabIndex = 22;
            this.toolTip1.SetToolTip(this.Txtbinfo, "Bu alanda indirme sürecini izlerseniz.");
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.removeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.removeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.removeButton.Location = new System.Drawing.Point(858, 400);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(51, 32);
            this.removeButton.TabIndex = 13;
            this.removeButton.Text = "SİL";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.playButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.playButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.playButton.Location = new System.Drawing.Point(794, 400);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(59, 32);
            this.playButton.TabIndex = 4;
            this.playButton.Text = "OYNAT";
            this.playButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(3, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "FERUDUN FAZIL KÜÇÜK";
            // 
            // playlistBox
            // 
            this.playlistBox.BackColor = System.Drawing.Color.Black;
            this.playlistBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.playlistBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playlistBox.ForeColor = System.Drawing.Color.White;
            this.playlistBox.FormattingEnabled = true;
            this.playlistBox.HorizontalScrollbar = true;
            this.playlistBox.ItemHeight = 20;
            this.playlistBox.Location = new System.Drawing.Point(0, 0);
            this.playlistBox.Name = "playlistBox";
            this.playlistBox.ScrollAlwaysVisible = true;
            this.playlistBox.Size = new System.Drawing.Size(534, 181);
            this.playlistBox.TabIndex = 11;
            this.toolTip1.SetToolTip(this.playlistBox, "İndirilen mp4 videoların listesi. bu listedeki video üzerine çift tıklama ile pc " +
        "deki vlc player ile oynatma sağlanır.");
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.listBox);
            this.panel2.Location = new System.Drawing.Point(797, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(534, 129);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.outputTextBox);
            this.panel3.Location = new System.Drawing.Point(797, 275);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(536, 119);
            this.panel3.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.Btnindir);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.formatComboBox);
            this.panel4.Controls.Add(this.selectFolderButton);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.downloadPathTextBox);
            this.panel4.Controls.Add(this.subtitlesCheckBox);
            this.panel4.Location = new System.Drawing.Point(797, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(534, 72);
            this.panel4.TabIndex = 6;
            // 
            // Btnindir
            // 
            this.Btnindir.BackColor = System.Drawing.Color.Green;
            this.Btnindir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Btnindir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.Btnindir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnindir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btnindir.Location = new System.Drawing.Point(130, 38);
            this.Btnindir.Name = "Btnindir";
            this.Btnindir.Size = new System.Drawing.Size(87, 32);
            this.Btnindir.TabIndex = 15;
            this.Btnindir.Text = "İNDİR";
            this.Btnindir.UseVisualStyleBackColor = false;
            this.Btnindir.Click += new System.EventHandler(this.Btnindir_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(388, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 29);
            this.button1.TabIndex = 9;
            this.button1.Text = "Ekranı Temizle";
            this.toolTip1.SetToolTip(this.button1, "Tüm pencereleri temizler.");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // selectFolderButton
            // 
            this.selectFolderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.selectFolderButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.selectFolderButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.selectFolderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectFolderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.selectFolderButton.ForeColor = System.Drawing.Color.White;
            this.selectFolderButton.Location = new System.Drawing.Point(388, 0);
            this.selectFolderButton.Name = "selectFolderButton";
            this.selectFolderButton.Size = new System.Drawing.Size(138, 35);
            this.selectFolderButton.TabIndex = 5;
            this.selectFolderButton.Text = "İndirme Dizini Seç";
            this.toolTip1.SetToolTip(this.selectFolderButton, "Dosya indirme yolunun seciminin yapıldıgı buton.");
            this.selectFolderButton.UseVisualStyleBackColor = false;
            this.selectFolderButton.Click += new System.EventHandler(this.selectFolderButton_Click);
            // 
            // downloadPathTextBox
            // 
            this.downloadPathTextBox.BackColor = System.Drawing.Color.Black;
            this.downloadPathTextBox.ForeColor = System.Drawing.Color.White;
            this.downloadPathTextBox.Location = new System.Drawing.Point(2, 6);
            this.downloadPathTextBox.Name = "downloadPathTextBox";
            this.downloadPathTextBox.Size = new System.Drawing.Size(380, 26);
            this.downloadPathTextBox.TabIndex = 4;
            this.toolTip1.SetToolTip(this.downloadPathTextBox, "İndirilen dosyanın yolu");
            // 
            // subtitlesCheckBox
            // 
            this.subtitlesCheckBox.AutoSize = true;
            this.subtitlesCheckBox.Location = new System.Drawing.Point(6, 34);
            this.subtitlesCheckBox.Name = "subtitlesCheckBox";
            this.subtitlesCheckBox.Size = new System.Drawing.Size(129, 24);
            this.subtitlesCheckBox.TabIndex = 8;
            this.subtitlesCheckBox.Text = "Altyazıları İndir";
            this.toolTip1.SetToolTip(this.subtitlesCheckBox, "Alt yazı indirmek isterseniz bu secimi tikleyiniz.");
            this.subtitlesCheckBox.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(6, 225);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 32);
            this.button2.TabIndex = 9;
            this.button2.Text = "yt-dlp Güncelle";
            this.toolTip1.SetToolTip(this.button2, "Yt-dlp exe nin yeni versiyonunu çalışma dizinine indirir.");
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.downloadYtDlpButton_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(248, 219);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(282, 23);
            this.progressBar.TabIndex = 10;
            this.toolTip1.SetToolTip(this.progressBar, "Yt-dlp exe inerken ilerleme gösterimi.");
            this.progressBar.Visible = false;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.playlistBox);
            this.panel5.Location = new System.Drawing.Point(797, 438);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(536, 183);
            this.panel5.TabIndex = 12;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.proseslabel);
            this.panel6.Controls.Add(this.Btytdlpversi);
            this.panel6.Controls.Add(this.button2);
            this.panel6.Controls.Add(this.progressBar);
            this.panel6.Location = new System.Drawing.Point(799, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(538, 392);
            this.panel6.TabIndex = 13;
            // 
            // proseslabel
            // 
            this.proseslabel.AutoSize = true;
            this.proseslabel.Location = new System.Drawing.Point(255, 246);
            this.proseslabel.Name = "proseslabel";
            this.proseslabel.Size = new System.Drawing.Size(13, 20);
            this.proseslabel.TabIndex = 11;
            this.proseslabel.Text = "/";
            // 
            // Btytdlpversi
            // 
            this.Btytdlpversi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Btytdlpversi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Btytdlpversi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.Btytdlpversi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btytdlpversi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btytdlpversi.Location = new System.Drawing.Point(128, 227);
            this.Btytdlpversi.Name = "Btytdlpversi";
            this.Btytdlpversi.Size = new System.Drawing.Size(112, 32);
            this.Btytdlpversi.TabIndex = 10;
            this.Btytdlpversi.Text = "yt-dlp Versiyon";
            this.toolTip1.SetToolTip(this.Btytdlpversi, "Yt-dlp exe nin versiyon gösterir.");
            this.Btytdlpversi.UseVisualStyleBackColor = false;
            this.Btytdlpversi.Click += new System.EventHandler(this.Btytdlpversi_Click);
            // 
            // Btnffmpegindir
            // 
            this.Btnffmpegindir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Btnffmpegindir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Btnffmpegindir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.Btnffmpegindir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnffmpegindir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btnffmpegindir.Location = new System.Drawing.Point(1127, 400);
            this.Btnffmpegindir.Name = "Btnffmpegindir";
            this.Btnffmpegindir.Size = new System.Drawing.Size(117, 32);
            this.Btnffmpegindir.TabIndex = 14;
            this.Btnffmpegindir.Text = "FFMPEG İNDİR";
            this.Btnffmpegindir.UseVisualStyleBackColor = false;
            this.Btnffmpegindir.Click += new System.EventHandler(this.Btnffmpegindir_Click);
            // 
            // Btnvlcindir
            // 
            this.Btnvlcindir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Btnvlcindir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Btnvlcindir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.Btnvlcindir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnvlcindir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btnvlcindir.Location = new System.Drawing.Point(1248, 401);
            this.Btnvlcindir.Name = "Btnvlcindir";
            this.Btnvlcindir.Size = new System.Drawing.Size(87, 32);
            this.Btnvlcindir.TabIndex = 15;
            this.Btnvlcindir.Text = "VLC İNDİR";
            this.Btnvlcindir.UseVisualStyleBackColor = false;
            this.Btnvlcindir.Click += new System.EventHandler(this.Btnvlcindir_Click);
            // 
            // Btytdlppath
            // 
            this.Btytdlppath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Btytdlppath.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Btytdlppath.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.Btytdlppath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btytdlppath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btytdlppath.Location = new System.Drawing.Point(984, 401);
            this.Btytdlppath.Name = "Btytdlppath";
            this.Btytdlppath.Size = new System.Drawing.Size(141, 32);
            this.Btytdlppath.TabIndex = 16;
            this.Btytdlppath.Text = "YT-DLP  YOL SEÇ";
            this.Btytdlppath.UseVisualStyleBackColor = false;
            this.Btytdlppath.Click += new System.EventHandler(this.Btytdlppath_Click);
            // 
            // Btlistyenile
            // 
            this.Btlistyenile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Btlistyenile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Btlistyenile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.Btlistyenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btlistyenile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btlistyenile.Location = new System.Drawing.Point(915, 400);
            this.Btlistyenile.Name = "Btlistyenile";
            this.Btlistyenile.Size = new System.Drawing.Size(66, 32);
            this.Btlistyenile.TabIndex = 17;
            this.Btlistyenile.Text = "YENİLE";
            this.Btlistyenile.UseVisualStyleBackColor = false;
            this.Btlistyenile.Click += new System.EventHandler(this.Btlistyenile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1345, 632);
            this.Controls.Add(this.Btlistyenile);
            this.Controls.Add(this.Btytdlppath);
            this.Controls.Add(this.Btnvlcindir);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Btnffmpegindir);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.playButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1361, 672);
            this.MinimumSize = new System.Drawing.Size(1361, 672);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YT-DLP GUI Küçüksoft";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webView)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.ComboBox formatComboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button selectFolderButton;
        private System.Windows.Forms.TextBox downloadPathTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.CheckBox subtitlesCheckBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.ListBox playlistBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.Button BTGERİ;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button Btytdlpversi;
        private System.Windows.Forms.ToolTip toolTip1;  
        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
        private System.Windows.Forms.TextBox addressBar;
        private System.Windows.Forms.Button BTyenile;
        private System.Windows.Forms.Button btİLERİ;
        private System.Windows.Forms.Button BTanasayfa;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button Btnffmpegindir;
        private System.Windows.Forms.Button Btnindir;
        private System.Windows.Forms.Button Btnvlcindir;
        private System.Windows.Forms.Button Btytdlppath;
        private System.Windows.Forms.Button Btlistyenile;
        private System.Windows.Forms.Label proseslabel;
        private System.Windows.Forms.Button Btnvideobilgi;
        private System.Windows.Forms.TextBox Txtbinfo;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
    }
}

