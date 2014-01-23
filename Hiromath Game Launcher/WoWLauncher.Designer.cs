namespace Hiromath_Game_Launcher
{
    partial class WoWLauncher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WoWLauncher));
            this.PlayButton = new System.Windows.Forms.PictureBox();
            this.CloseButton = new System.Windows.Forms.PictureBox();
            this.MinimizeButton = new System.Windows.Forms.PictureBox();
            this.MoveBar = new System.Windows.Forms.PictureBox();
            this.NewsLauncher = new System.Windows.Forms.WebBrowser();
            this.StatusLauncher = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.PlayButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MoveBar)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayButton
            // 
            this.PlayButton.BackColor = System.Drawing.Color.Transparent;
            this.PlayButton.Image = global::Hiromath_Game_Launcher.Properties.Resources.play_button;
            this.PlayButton.Location = new System.Drawing.Point(694, 447);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(130, 74);
            this.PlayButton.TabIndex = 0;
            this.PlayButton.TabStop = false;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            this.PlayButton.MouseEnter += new System.EventHandler(this.PlayButton_MouseEnter);
            this.PlayButton.MouseLeave += new System.EventHandler(this.PlayButton_MouseLeave);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.Image = global::Hiromath_Game_Launcher.Properties.Resources.close_button;
            this.CloseButton.Location = new System.Drawing.Point(815, 5);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(20, 19);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.TabStop = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseEnter += new System.EventHandler(this.CloseButton_MouseEnter);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.MinimizeButton.Image = global::Hiromath_Game_Launcher.Properties.Resources.minimze_button;
            this.MinimizeButton.Location = new System.Drawing.Point(792, 5);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(20, 19);
            this.MinimizeButton.TabIndex = 2;
            this.MinimizeButton.TabStop = false;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            this.MinimizeButton.MouseEnter += new System.EventHandler(this.MinimizeButton_MouseEnter);
            this.MinimizeButton.MouseLeave += new System.EventHandler(this.MinimizeButton_MouseLeave);
            // 
            // MoveBar
            // 
            this.MoveBar.BackColor = System.Drawing.Color.Transparent;
            this.MoveBar.Location = new System.Drawing.Point(2, 1);
            this.MoveBar.Name = "MoveBar";
            this.MoveBar.Size = new System.Drawing.Size(839, 24);
            this.MoveBar.TabIndex = 3;
            this.MoveBar.TabStop = false;
            this.MoveBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveBar_MouseDown);
            // 
            // NewsLauncher
            // 
            this.NewsLauncher.AllowNavigation = false;
            this.NewsLauncher.AllowWebBrowserDrop = false;
            this.NewsLauncher.IsWebBrowserContextMenuEnabled = false;
            this.NewsLauncher.Location = new System.Drawing.Point(243, 144);
            this.NewsLauncher.MinimumSize = new System.Drawing.Size(20, 20);
            this.NewsLauncher.Name = "NewsLauncher";
            this.NewsLauncher.ScriptErrorsSuppressed = true;
            this.NewsLauncher.ScrollBarsEnabled = false;
            this.NewsLauncher.Size = new System.Drawing.Size(587, 273);
            this.NewsLauncher.TabIndex = 4;
            this.NewsLauncher.TabStop = false;
            this.NewsLauncher.Url = new System.Uri("http://localhost/launcher/wow/news/", System.UriKind.Absolute);
            this.NewsLauncher.WebBrowserShortcutsEnabled = false;
            this.NewsLauncher.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.NewsLauncher_DocumentCompleted);
            // 
            // StatusLauncher
            // 
            this.StatusLauncher.AllowNavigation = false;
            this.StatusLauncher.AllowWebBrowserDrop = false;
            this.StatusLauncher.IsWebBrowserContextMenuEnabled = false;
            this.StatusLauncher.Location = new System.Drawing.Point(10, 145);
            this.StatusLauncher.MinimumSize = new System.Drawing.Size(20, 20);
            this.StatusLauncher.Name = "StatusLauncher";
            this.StatusLauncher.ScriptErrorsSuppressed = true;
            this.StatusLauncher.ScrollBarsEnabled = false;
            this.StatusLauncher.Size = new System.Drawing.Size(221, 272);
            this.StatusLauncher.TabIndex = 5;
            this.StatusLauncher.Url = new System.Uri("http://localhost/launcher/wow/status/", System.UriKind.Absolute);
            this.StatusLauncher.WebBrowserShortcutsEnabled = false;
            // 
            // WoWLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.BackgroundImage = global::Hiromath_Game_Launcher.Properties.Resources.main;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(840, 539);
            this.Controls.Add(this.StatusLauncher);
            this.Controls.Add(this.NewsLauncher);
            this.Controls.Add(this.MinimizeButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.MoveBar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WoWLauncher";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.WoWLauncher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PlayButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MoveBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PlayButton;
        private System.Windows.Forms.PictureBox CloseButton;
        private System.Windows.Forms.PictureBox MinimizeButton;
        private System.Windows.Forms.PictureBox MoveBar;
        private System.Windows.Forms.WebBrowser NewsLauncher;
        private System.Windows.Forms.WebBrowser StatusLauncher;
    }
}

