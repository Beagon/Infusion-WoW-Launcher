using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace Hiromath_Game_Launcher
{
    public partial class WoWLauncher : Form
    {
        #region Move the window dlls
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion

        public WoWLauncher()
        {
            InitializeComponent();
        }

        private void WoWLauncher_Load(object sender, EventArgs e)
        {

        }




        #region Play Button

        private void PlayButton_MouseEnter(object sender, EventArgs e)
        {
            PlayButton.Image = Hiromath_Game_Launcher.Properties.Resources.play_button_hover;
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            if (File.Exists("wow.exe"))
            {
                System.Diagnostics.Process.Start("wow.exe");
            }
            else
            {
                MessageBox.Show("Please be sure to put this program in your WoW directory");
            }
        } 
        
        private void PlayButton_MouseLeave(object sender, EventArgs e)
        {
            PlayButton.Image = Hiromath_Game_Launcher.Properties.Resources.play_button;
        }
        #endregion




        #region Close Button
        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.Image = Hiromath_Game_Launcher.Properties.Resources.close_button_hover;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.Image = Hiromath_Game_Launcher.Properties.Resources.close_button;
        }
        
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Minimize Button
        private void MinimizeButton_MouseEnter(object sender, EventArgs e)
        {
            MinimizeButton.Image = Hiromath_Game_Launcher.Properties.Resources.minimze_button_hover;
        }

        private void MinimizeButton_MouseLeave(object sender, EventArgs e)
        {
            MinimizeButton.Image = Hiromath_Game_Launcher.Properties.Resources.minimze_button;
        } 
        
        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



        #endregion




        #region Moveable Bar
        private void MoveBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        private void NewsLauncher_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            NewsLauncher.Document.Body.Style = "overflow:hidden";
        }










    }
}
