using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace kPhone
{
    public partial class Form1 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        int index = 0;
        public int column;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // homeBtn.SendToBack();
            MessageBox.Show("This product is incomplete!\nMany things are missing. I do not plan on improving this software.\nAnother Atomic-Dev member may do it, or not.\n\nThe Apple name, the Apple logo, the iTunes, the iPhone, the iPhone 3G, the iPod Touch names are trademarks of Apple Inc."
                , "iEMW", MessageBoxButtons.OK, MessageBoxIcon.Warning, 0, 0);
            clock.Start();
            this.calendarApp.Text = DateTime.Now.Day.ToString();
        }

        private void kTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 100);
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void statusBar_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void clock_Tick(object sender, EventArgs e)
        {
            DateTime dt = new DateTime();
            statusTime.Text = "   " + DateTime.Now.ToShortTimeString();
        }

        private void flowLayoutPanel1_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void flowLayoutPanel1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            (new RamGec_About_Box1()).ShowDialog();
        }

        private void homescreen_Paint(object sender, PaintEventArgs e)
        {

        }

        private void calcApp_Click(object sender, EventArgs e)
        {
            calcInterface ci = new calcInterface();
            this.Controls.Add(ci);
            ci.Dock = DockStyle.Fill;
            ci.BringToFront();
        }


        private void calendarApp_Click(object sender, EventArgs e)
        {
            xcalendar ci = new xcalendar();
            this.Controls.Add(ci);
            ci.Dock = DockStyle.Fill;
            ci.BringToFront();
        }

        private void safariApp_Click(object sender, EventArgs e)
        {
            browser br = new browser();
            br.ShowDialog(this);
        }

        private void messagesApp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is an image that represents nothing.\nI obviously can't add this to an emulator!",
                "iEMW", MessageBoxButtons.OK, MessageBoxIcon.Warning, 0, MessageBoxOptions.ServiceNotification);
        }

        private void phoneApp_Click(object sender, EventArgs e)
        {

            MessageBox.Show("This is an image that represents nothing.\nI obviously can't add this to an emulator!",
                "iEMW", MessageBoxButtons.OK, MessageBoxIcon.Warning, 0, MessageBoxOptions.ServiceNotification);
        }

        private void cameraApp_Click(object sender, EventArgs e)
        {

            MessageBox.Show( Environment.MachineName.ToString() + " is a computer! Not a camera!",
                "iEMW", MessageBoxButtons.OK, MessageBoxIcon.Warning, 0, MessageBoxOptions.ServiceNotification);
        }

        private void youtubeApp_Click(object sender, EventArgs e)
        {
            browser.loadPage("http://m.youtube.com");
        }

        private void mailApp_Click(object sender, EventArgs e)
        {
            browser.loadPage("http://m.gmail.com");
        }

        private void stocksApp_Click(object sender, EventArgs e)
        {
            browser.loadPage("http://google.com/finance");
        }
    }
}
