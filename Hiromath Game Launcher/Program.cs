using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Hiromath_Game_Launcher
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool StartMain = false;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (!StartMain)
            {
                Application.Run(new WoWLauncher());
            }
            else
            {
                Application.Run(new Main());
            }
        }
    }
}
