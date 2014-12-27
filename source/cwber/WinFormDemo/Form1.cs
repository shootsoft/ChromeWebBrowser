using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Sashulin;
using Sashulin.Core;
using Sashulin.common;

namespace WinFormDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void setCookiePathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chromeWebBrowser1.SetCookiePath("c:\\temp");
        }

        private void getElementValueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string s = chromeWebBrowser1.GetElementValueById("kw1");
            MessageBox.Show(s);
        }

        private void deleteAllCookieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chromeWebBrowser1.DeleteAllCookies();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chromeWebBrowser1.OpenUrl(textBox1.Text);
        }

        private void setElementValueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chromeWebBrowser1.SetElementValueByid("kw1", "input some data...");
        }

        private void showDevToolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chromeWebBrowser1.ShowDevTool();
        }

        private void setScreenSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chromeWebBrowser1.SetScreenSize(480, 680);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CSharpBrowserSettings settings = new CSharpBrowserSettings();
            settings.DefaultUrl = System.IO.Directory.GetCurrentDirectory() + "\\cachedbTest.html";
            //settings.UserAgent = "Mozilla/5.0 (Linux; Android 4.2.1; en-us; Nexus 4 Build/JOP40D) AppleWebKit/535.19 (KHTML, like Gecko) Chrome/18.0.1025.166 Mobile Safari/535.19";
            settings.CachePath = @"C:\temp\caches";
            chromeWebBrowser1.Initialize(settings);
        }

        private void resetScreenSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chromeWebBrowser1.ResetScreen();
        }

        private void getSourceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string source = chromeWebBrowser1.GetSource();
            MessageBox.Show(source);
        }

        private void callCSharpMethodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chromeWebBrowser1.OpenUrl("file:///D:/temp/ChromeWebBrowser.net_1.0.311/ChromeWebBrowser.net_1.0.3/example/cachedbTest.html");
        }

        public string ShowMessage(string msg)
        {
            //MessageBox.Show(msg);
            Form2 f = new Form2();
            
            f.Show();
            return "return : Js call";
        }

        private void evalScriptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //object o = chromeWebBrowser1.EvaluateScript("getAgent();"); // be ok.
            object o = chromeWebBrowser1.EvaluateScript("document.childNodes[0].childNodes[1].innerHTML;");
            MessageBox.Show(o.ToString());

        }

        private void executeScriptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chromeWebBrowser1.ExecuteScript("alert('executeJavaScript')");
        }

        private void appendElementEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chromeWebBrowser1.AppendElementEventListener("su", "click", new ChromeWebBrowser.TCallBackElementEventListener(showmsg));
        }
        private void showmsg()
        {
            MessageBox.Show("element listener");
        }

        private void chromeWebBrowser1_BrowserUrlChange(object sender, UrlChangeEventArgs e)
        {
            textBox1.Text = e.Url;
        }

        private void setPopupMenuVisibleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chromeWebBrowser1.SetPopupMenuVisible(false);
        }

        private void setPopupMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContextMenu p = new System.Windows.Forms.ContextMenu();
            MenuItem item = new MenuItem("menuItem1");
            item.Click += new EventHandler(ItemClick);
            p.MenuItems.Add(item);
            chromeWebBrowser1.SetPopupMenu(p);
            
        }

        private void ItemClick(object sender, EventArgs e)
        {
            textBox1.Text = "http://www.163.com";
        }

        private void chromeWebBrowser1_BrowserTitleChange(object sender, TitleEventArgs e)
        {
            TabPage page = ((ChromeWebBrowser)sender).Parent as TabPage;
            page.Text = e.Title;
        }

        delegate void NewPageListener(string url, object request);

        private void chromeWebBrowser1_BrowserNewWindow(object sender, NewWindowEventArgs e)
        {
            if (this.InvokeRequired)
            {
                NewPageListener a = new NewPageListener(NewPage);
                this.Invoke(a, new object[] { e.NewUrl, e.Request });
            }
            else
            {
                NewPage(e.NewUrl, e.Request);
            }
        }
        object aaa;
        ChromeWebBrowser browser1;
        private void NewPage(string newUrl,object req)
        {
            TabPage newPage = new TabPage(newUrl);
            tabControl1.TabPages.Add(newPage);
            tabControl1.SelectTab(newPage);
            CSharpBrowserSettings settings = new CSharpBrowserSettings();
            //settings.UserAgent = "Mozilla/5.0 (Linux; Android 4.2.1; en-us; Nexus 4 Build/JOP40D) AppleWebKit/535.19 (KHTML, like Gecko) Chrome/18.0.1025.166 Mobile Safari/535.19";
            settings.CachePath = @"C:\temp\caches";
            ChromeWebBrowser browser = new ChromeWebBrowser();
            browser.BrowserNewWindow += new NewWindowEventHandler(chromeWebBrowser1_BrowserNewWindow);
            browser.BrowserTitleChange += new TitleChangeEventHandler(chromeWebBrowser1_BrowserTitleChange);
            browser.Initialize(settings);
            newPage.Controls.Add(browser);
            browser.Validate();
            browser.Dock = DockStyle.Fill;
            if (!newUrl.Contains("&"))
                browser.OpenUrl(newUrl);
            else
                browser.OpenUrl(req);
            aaa = req;
            browser1 = browser;
        }

        private void loadRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chromeWebBrowser1.OpenUrl(aaa);
        }

        private void addPluginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chromeWebBrowser1.AddPluginPath("np-mswmp.dll");
        }

        private void documentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CwbElement root = chromeWebBrowser1.Document.Root;
            string value = root.ChildElements[0].ChildElements[1].ChildElements[3].Value;
            MessageBox.Show(value);
        }

        private void setElementValueToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CwbElement root = chromeWebBrowser1.Document.Root;
            root.ChildElements[0].ChildElements[1].ChildElements[3].Value = "test value";
        }

        private void elementListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<CwbElement> buttons = chromeWebBrowser1.Document.GetElementsByTagName("input");
            MessageBox.Show(buttons.Count.ToString());
        }

        private void getElementByIdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CwbElement buttons = chromeWebBrowser1.Document.GetElementById("kw1");
            MessageBox.Show(buttons.Value);
        }

        private void setInnerHtmlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<CwbElement> buttons = chromeWebBrowser1.Document.GetElementsByTagName("ul");
            buttons[0].InnerHtml = "aaaaaaaa";
        }

        private void getInnerHtmlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<CwbElement> buttons = chromeWebBrowser1.Document.GetElementsByTagName("ul");
            MessageBox.Show(buttons[0].InnerHtml);
        }

        private void visitAttrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string value = string.Empty;
            CwbElement buttons = chromeWebBrowser1.Document.GetElementById("kw1");
            foreach (KeyValuePair<string, string> item in buttons.Attributes)
            {
                value += item.Key + ":" + item.Value + ",";
            }
            MessageBox.Show(value);
        }

        private void getAttributeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string value = string.Empty;
            CwbElement buttons = chromeWebBrowser1.Document.GetElementById("kw1");
            value = buttons.GetAttribute("value");
            MessageBox.Show(value);
        }

        private void cookieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(chromeWebBrowser1.Document.Cookie);
        }

        private void setAttributeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CwbElement buttons = chromeWebBrowser1.Document.GetElementById("kw1");
            buttons.SetAttribute("value","test value");
        }

        private void clickToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CwbElement buttons = chromeWebBrowser1.Document.GetElementById("su");
            buttons.Click();
        }

        private void appElementListenerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CwbElement buttons = chromeWebBrowser1.Document.GetElementById("su");
            buttons.AttachEventListener("click", new ChromeWebBrowser.TCallBackElementEventListener(showmsg));
        }

    }
}
