using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows8NotificationConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var notifyIcon1 = new NotifyIcon();
            notifyIcon1.BalloonTipClosed += delegate { notifyIcon1.Visible = false; notifyIcon1.Icon = null; notifyIcon1.Dispose(); };
            notifyIcon1.BalloonTipClicked += delegate { notifyIcon1.Visible = false; notifyIcon1.Icon = null; notifyIcon1.Dispose(); };
            notifyIcon1.Icon = new System.Drawing.Icon(Path.GetFullPath(@"Tatice-Cristal-Intense-Exclamation.ico"));
            notifyIcon1.Text = "Export Datatable Utlity";
            notifyIcon1.Visible = true;
            notifyIcon1.BalloonTipTitle = "Welcome Devesh omar to Datatable Export Utlity";
            notifyIcon1.BalloonTipText = "Click Here to see details Click Here to see details Click Here to see details Click Here to see details Click Here to see details Click Here to see details Click Here to see details Click Here to see details Click Here to see details Click Here to see details Click Here to see details Click Here to see details Click Here to see details Click Here to see details Click Here to see details Click Here to see details Click Here to see details Click Here to see details Click Here to see details Click Here to see details Click Here to see details Click Here to see details Click Here to see details Click Here to see details Click Here to see details Click Here to see details Click Here to see details Click Here to see details Click Here to see details Click Here to see details Click Here to see details Click Here to see details Click Here to see details Click Here to see details Click Here to see details Click Here to see details Click Here to see details Click Here to see details Click Here to see details Click Here to see details Click Here to see details Click Here to see details Click Here to see details Click Here to see details Click Here to see details Click Here to see details Click Here to see details Click Here to see details Click Here to see details Click Here to see details Click Here to see details Click Here to see details Click Here to see details Click Here to see details Click Here to see details Click Here to see details Click Here to see details Click Here to see details Click Here to see details Click Here to see details Click Here to see details Click Here to see details Click Here to see details Click Here to see details Click Here to see details Click Here to see details Click Here to see details Click Here to see details Click Here to see details Click Here to see details Click Here to see details Click Here to see details Click Here to see details Click Here to see details Click Here to see details Click Here to see details Click Here to see details Click Here to see details";
            notifyIcon1.ShowBalloonTip(1000);
            //Thread.Sleep(1000);
            notifyIcon1.Dispose();
            Console.ReadLine();
        }
    }
}
