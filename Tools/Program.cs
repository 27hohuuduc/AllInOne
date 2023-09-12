using System;
using System.Windows.Forms;
using Bluegrams.Application;
using Microsoft.Win32;
using Tools.Properties;

namespace Tools
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            
            rk.SetValue(Application.ProductName, Application.ExecutablePath);

            //PinWin
            //AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            if (AppInfo.IsPortable.GetValueOrDefault())
                PortableSettingsProvider.ApplyProvider(Settings.Default);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainApplicationContext());
        }

        // PinWin
        //private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        //{
        //    Logger.Default.Log("An unhandled exception caused the application to terminate unexpectedly.",
        //        (Exception)e.ExceptionObject);
        //}
    }
}
