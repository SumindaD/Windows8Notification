using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows8Notification
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonShowNotification_Click(object sender, EventArgs e)
        {
            notifyIcon1.Icon = new System.Drawing.Icon(Path.GetFullPath(@"Tatice-Cristal-Intense-Exclamation.ico"));
            notifyIcon1.Text = "Export Datatable Utlity";
            notifyIcon1.Visible = true;
            notifyIcon1.BalloonTipTitle = "Welcome Devesh omar to Datatable Export Utlity";
            notifyIcon1.BalloonTipText = "Click Here to see details";
            notifyIcon1.ShowBalloonTip(100);
        }
    }
}
