using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Sashulin;
using Sashulin.common;

namespace WinFormDemo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
            this.Load += new EventHandler(Form2Load);
        }

        public string ShowMessage(string msg)
        {
            MessageBox.Show("form2 msg"+msg);
            return "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenUrl(textBox1.Text);
        }


        private void Form2Load(object sender, EventArgs e)
        {

        }
        delegate void NewPageListener(string url, object request);
        public void OpenUrl(string url)
        {
            NewPageListener a = new NewPageListener(NewPage);
            this.Invoke(a, new object[] { url, null });
        }

        public void NewPage(string newUrl, object req)
        {
            TabPage newPage = new TabPage(newUrl);
            tabControl1.TabPages.Add(newPage);
            tabControl1.SelectTab(newPage);
            CSharpBrowserSettings settings = new CSharpBrowserSettings();
            //settings.UserAgent = "Mozilla/5.0 (Linux; Android 4.2.1; en-us; Nexus 4 Build/JOP40D) AppleWebKit/535.19 (KHTML, like Gecko) Chrome/18.0.1025.166 Mobile Safari/535.19";
            settings.CachePath = @"C:\temp\caches";
            ChromeWebBrowser browser = new ChromeWebBrowser();
            //browser.BrowserNewWindow += new NewWindowEventHandler(chromeWebBrowser1_BrowserNewWindow);
            //browser.BrowserTitleChange += new TitleChangeEventHandler(chromeWebBrowser1_BrowserTitleChange);
            browser.Initialize(settings);
            newPage.Controls.Add(browser);
            browser.Validate();
            browser.Dock = DockStyle.Fill;
            if (!newUrl.Contains("&"))
                browser.OpenUrl(newUrl);
            else
                browser.OpenUrl(req);
        }

    }
}
