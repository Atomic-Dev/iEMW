using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace kPhone
{
    public partial class browser : Form
    {
        public string data = null;
        public string safe_directory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/iEMW/";
        public browser()
        {
            InitializeComponent();
            search.SendToBack();            
            this.AcceptButton = search;          
            if (!Directory.Exists(safe_directory))
                Directory.CreateDirectory(safe_directory);
            if (File.Exists(safe_directory + "history.log") == false)
            {
                using (StreamWriter sw = new StreamWriter(safe_directory + "history.log"))
                {
                   sw.Dispose();           /* I don't want it no more... (as in Six Blade Knife by Dire Straits! KILLER BASS LINE!) */
                }
            }
        }

        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoBack)
                webBrowser1.GoBack();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoForward)
                webBrowser1.GoForward();
        }

        private void toolStripStatusLabel3_Click(object sender, EventArgs e)
        {
            webBrowser1.ShowSaveAsDialog();
        }

        private void toolStripStatusLabel4_Click(object sender, EventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {
            string url = urlBox.Text; 
            int sysd = 0;
            if (url != null && url != "")
                sysd = url.Length;
            if (sysd < 0)
                ;
            else
            {
                webBrowser1.Navigate(url);
            }

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            string url = urlBox.Text;
            int sysd = 0;
            if (url != null && url != "")
                sysd = url.Length;
            
                using (StreamReader sr = new StreamReader(safe_directory + "history.log"))
                {
                    string file = sr.ReadToEnd();
                    string[] filelines = file.Split('\n');
                    int i = 0;
                    var ex = from s in filelines
		                     select s;
                    sr.Dispose();
                    int c = ex.Count();
                    for (i = 0; i < c; i++)
                    {
                        string ltext = filelines[i];
                        if (urlBox.Text == ltext)
                            break;
                        else
                        {
                            break;
                        }
                    }
                    
                }

                data += "\n";
                data += webBrowser1.Url;
        }

        private void browser_Load(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader(safe_directory + "history.log"))
            {
                string file = sr.ReadToEnd();
                string[] filelines = file.Split('\n');
                int i = 0;
                var ex = from s in filelines
                         select s;
                sr.Dispose();
                int c = ex.Count();
                
                i = 0;

                for (; i < c; i++)
                {
                    this.urlBox.Items.Add(filelines[i]);
                }
            }
        }

        private void browser_FormClosing(object sender, FormClosingEventArgs e)
        {           
            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(safe_directory + "history.log"))
            {
                sw.Write(data);
                sw.Dispose();
            }
        }

        public static void loadPage(string href)
        {
            // Static so the home screen can access this function

            browser _browser = new browser();
            _browser.webBrowser1.Navigate(href);
            _browser.ShowDialog();
        }

        private void toolStripStatusLabel5_Click(object sender, EventArgs e)
        {
            Form browserForm = new Form();
            WebBrowser mainBrowser = new WebBrowser();
            browserForm.Controls.Add(mainBrowser);
            mainBrowser.Dock = DockStyle.Fill;
            mainBrowser.Navigate(webBrowser1.Url);            
            browserForm.Text = "Out of Form";
            browserForm.ShowIcon = false;
            browserForm.ShowInTaskbar = false;
            browserForm.Width = 650;
            browserForm.Height = 450;
            browserForm.Show(this);
        }
    }
}
