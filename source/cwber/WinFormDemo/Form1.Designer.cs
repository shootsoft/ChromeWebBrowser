namespace WinFormDemo
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getElementValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAllCookieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setCookiePathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setElementValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showDevToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setScreenSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetScreenSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getSourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.callCSharpMethodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evalScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.executeScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appendElementEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setPopupMenuVisibleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setPopupMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadRequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPluginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.function2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setElementValueToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.elementListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getElementByIdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setInnerHtmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getInnerHtmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visitAttrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getAttributeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cookieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setAttributeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clickToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appElementListenerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.chromeWebBrowser1 = new Sashulin.ChromeWebBrowser();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.visitToolStripMenuItem,
            this.function2ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(605, 25);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // visitToolStripMenuItem
            // 
            this.visitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getElementValueToolStripMenuItem,
            this.deleteAllCookieToolStripMenuItem,
            this.setCookiePathToolStripMenuItem,
            this.setElementValueToolStripMenuItem,
            this.showDevToolsToolStripMenuItem,
            this.setScreenSizeToolStripMenuItem,
            this.resetScreenSizeToolStripMenuItem,
            this.getSourceToolStripMenuItem,
            this.callCSharpMethodToolStripMenuItem,
            this.evalScriptToolStripMenuItem,
            this.executeScriptToolStripMenuItem,
            this.appendElementEventToolStripMenuItem,
            this.setPopupMenuVisibleToolStripMenuItem,
            this.setPopupMenuToolStripMenuItem,
            this.loadRequestToolStripMenuItem,
            this.addPluginToolStripMenuItem});
            this.visitToolStripMenuItem.Name = "visitToolStripMenuItem";
            this.visitToolStripMenuItem.Size = new System.Drawing.Size(66, 21);
            this.visitToolStripMenuItem.Text = "function";
            // 
            // getElementValueToolStripMenuItem
            // 
            this.getElementValueToolStripMenuItem.Name = "getElementValueToolStripMenuItem";
            this.getElementValueToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.getElementValueToolStripMenuItem.Text = "GetElementValue";
            this.getElementValueToolStripMenuItem.Click += new System.EventHandler(this.getElementValueToolStripMenuItem_Click);
            // 
            // deleteAllCookieToolStripMenuItem
            // 
            this.deleteAllCookieToolStripMenuItem.Name = "deleteAllCookieToolStripMenuItem";
            this.deleteAllCookieToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.deleteAllCookieToolStripMenuItem.Text = "DeleteAllCookie";
            this.deleteAllCookieToolStripMenuItem.Click += new System.EventHandler(this.deleteAllCookieToolStripMenuItem_Click);
            // 
            // setCookiePathToolStripMenuItem
            // 
            this.setCookiePathToolStripMenuItem.Name = "setCookiePathToolStripMenuItem";
            this.setCookiePathToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.setCookiePathToolStripMenuItem.Text = "SetCookiePath";
            this.setCookiePathToolStripMenuItem.Click += new System.EventHandler(this.setCookiePathToolStripMenuItem_Click);
            // 
            // setElementValueToolStripMenuItem
            // 
            this.setElementValueToolStripMenuItem.Name = "setElementValueToolStripMenuItem";
            this.setElementValueToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.setElementValueToolStripMenuItem.Text = "SetElementValue";
            this.setElementValueToolStripMenuItem.Click += new System.EventHandler(this.setElementValueToolStripMenuItem_Click);
            // 
            // showDevToolsToolStripMenuItem
            // 
            this.showDevToolsToolStripMenuItem.Name = "showDevToolsToolStripMenuItem";
            this.showDevToolsToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.showDevToolsToolStripMenuItem.Text = "ShowDevTools";
            this.showDevToolsToolStripMenuItem.Click += new System.EventHandler(this.showDevToolsToolStripMenuItem_Click);
            // 
            // setScreenSizeToolStripMenuItem
            // 
            this.setScreenSizeToolStripMenuItem.Name = "setScreenSizeToolStripMenuItem";
            this.setScreenSizeToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.setScreenSizeToolStripMenuItem.Text = "SetScreenSize";
            this.setScreenSizeToolStripMenuItem.Click += new System.EventHandler(this.setScreenSizeToolStripMenuItem_Click);
            // 
            // resetScreenSizeToolStripMenuItem
            // 
            this.resetScreenSizeToolStripMenuItem.Name = "resetScreenSizeToolStripMenuItem";
            this.resetScreenSizeToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.resetScreenSizeToolStripMenuItem.Text = "ResetScreenSize";
            this.resetScreenSizeToolStripMenuItem.Click += new System.EventHandler(this.resetScreenSizeToolStripMenuItem_Click);
            // 
            // getSourceToolStripMenuItem
            // 
            this.getSourceToolStripMenuItem.Name = "getSourceToolStripMenuItem";
            this.getSourceToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.getSourceToolStripMenuItem.Text = "GetSource";
            this.getSourceToolStripMenuItem.Click += new System.EventHandler(this.getSourceToolStripMenuItem_Click);
            // 
            // callCSharpMethodToolStripMenuItem
            // 
            this.callCSharpMethodToolStripMenuItem.Name = "callCSharpMethodToolStripMenuItem";
            this.callCSharpMethodToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.callCSharpMethodToolStripMenuItem.Text = "CallCSharpMethod";
            this.callCSharpMethodToolStripMenuItem.Click += new System.EventHandler(this.callCSharpMethodToolStripMenuItem_Click);
            // 
            // evalScriptToolStripMenuItem
            // 
            this.evalScriptToolStripMenuItem.Name = "evalScriptToolStripMenuItem";
            this.evalScriptToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.evalScriptToolStripMenuItem.Text = "Eval Script";
            this.evalScriptToolStripMenuItem.Click += new System.EventHandler(this.evalScriptToolStripMenuItem_Click);
            // 
            // executeScriptToolStripMenuItem
            // 
            this.executeScriptToolStripMenuItem.Name = "executeScriptToolStripMenuItem";
            this.executeScriptToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.executeScriptToolStripMenuItem.Text = "Execute Script";
            this.executeScriptToolStripMenuItem.Click += new System.EventHandler(this.executeScriptToolStripMenuItem_Click);
            // 
            // appendElementEventToolStripMenuItem
            // 
            this.appendElementEventToolStripMenuItem.Name = "appendElementEventToolStripMenuItem";
            this.appendElementEventToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.appendElementEventToolStripMenuItem.Text = "AppendElementEvent";
            this.appendElementEventToolStripMenuItem.Click += new System.EventHandler(this.appendElementEventToolStripMenuItem_Click);
            // 
            // setPopupMenuVisibleToolStripMenuItem
            // 
            this.setPopupMenuVisibleToolStripMenuItem.Name = "setPopupMenuVisibleToolStripMenuItem";
            this.setPopupMenuVisibleToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.setPopupMenuVisibleToolStripMenuItem.Text = "SetPopupMenuVisible";
            this.setPopupMenuVisibleToolStripMenuItem.Click += new System.EventHandler(this.setPopupMenuVisibleToolStripMenuItem_Click);
            // 
            // setPopupMenuToolStripMenuItem
            // 
            this.setPopupMenuToolStripMenuItem.Name = "setPopupMenuToolStripMenuItem";
            this.setPopupMenuToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.setPopupMenuToolStripMenuItem.Text = "SetPopupMenu";
            this.setPopupMenuToolStripMenuItem.Click += new System.EventHandler(this.setPopupMenuToolStripMenuItem_Click);
            // 
            // loadRequestToolStripMenuItem
            // 
            this.loadRequestToolStripMenuItem.Name = "loadRequestToolStripMenuItem";
            this.loadRequestToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.loadRequestToolStripMenuItem.Text = "LoadRequest";
            this.loadRequestToolStripMenuItem.Click += new System.EventHandler(this.loadRequestToolStripMenuItem_Click);
            // 
            // addPluginToolStripMenuItem
            // 
            this.addPluginToolStripMenuItem.Name = "addPluginToolStripMenuItem";
            this.addPluginToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.addPluginToolStripMenuItem.Text = "AddPlugin";
            this.addPluginToolStripMenuItem.Click += new System.EventHandler(this.addPluginToolStripMenuItem_Click);
            // 
            // function2ToolStripMenuItem
            // 
            this.function2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.documentToolStripMenuItem,
            this.setElementValueToolStripMenuItem1,
            this.elementListToolStripMenuItem,
            this.getElementByIdToolStripMenuItem,
            this.setInnerHtmlToolStripMenuItem,
            this.getInnerHtmlToolStripMenuItem,
            this.visitAttrToolStripMenuItem,
            this.getAttributeToolStripMenuItem,
            this.cookieToolStripMenuItem,
            this.setAttributeToolStripMenuItem,
            this.clickToolStripMenuItem,
            this.appElementListenerToolStripMenuItem});
            this.function2ToolStripMenuItem.Name = "function2ToolStripMenuItem";
            this.function2ToolStripMenuItem.Size = new System.Drawing.Size(79, 21);
            this.function2ToolStripMenuItem.Text = "Document";
            // 
            // documentToolStripMenuItem
            // 
            this.documentToolStripMenuItem.Name = "documentToolStripMenuItem";
            this.documentToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.documentToolStripMenuItem.Text = "Get Element Value";
            this.documentToolStripMenuItem.Click += new System.EventHandler(this.documentToolStripMenuItem_Click);
            // 
            // setElementValueToolStripMenuItem1
            // 
            this.setElementValueToolStripMenuItem1.Name = "setElementValueToolStripMenuItem1";
            this.setElementValueToolStripMenuItem1.Size = new System.Drawing.Size(219, 22);
            this.setElementValueToolStripMenuItem1.Text = "Set Element Value";
            this.setElementValueToolStripMenuItem1.Click += new System.EventHandler(this.setElementValueToolStripMenuItem1_Click);
            // 
            // elementListToolStripMenuItem
            // 
            this.elementListToolStripMenuItem.Name = "elementListToolStripMenuItem";
            this.elementListToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.elementListToolStripMenuItem.Text = "GetElementsByTagName";
            this.elementListToolStripMenuItem.Click += new System.EventHandler(this.elementListToolStripMenuItem_Click);
            // 
            // getElementByIdToolStripMenuItem
            // 
            this.getElementByIdToolStripMenuItem.Name = "getElementByIdToolStripMenuItem";
            this.getElementByIdToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.getElementByIdToolStripMenuItem.Text = "GetElementById";
            this.getElementByIdToolStripMenuItem.Click += new System.EventHandler(this.getElementByIdToolStripMenuItem_Click);
            // 
            // setInnerHtmlToolStripMenuItem
            // 
            this.setInnerHtmlToolStripMenuItem.Name = "setInnerHtmlToolStripMenuItem";
            this.setInnerHtmlToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.setInnerHtmlToolStripMenuItem.Text = "Set InnerHtml";
            this.setInnerHtmlToolStripMenuItem.Click += new System.EventHandler(this.setInnerHtmlToolStripMenuItem_Click);
            // 
            // getInnerHtmlToolStripMenuItem
            // 
            this.getInnerHtmlToolStripMenuItem.Name = "getInnerHtmlToolStripMenuItem";
            this.getInnerHtmlToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.getInnerHtmlToolStripMenuItem.Text = "Get InnerHtml";
            this.getInnerHtmlToolStripMenuItem.Click += new System.EventHandler(this.getInnerHtmlToolStripMenuItem_Click);
            // 
            // visitAttrToolStripMenuItem
            // 
            this.visitAttrToolStripMenuItem.Name = "visitAttrToolStripMenuItem";
            this.visitAttrToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.visitAttrToolStripMenuItem.Text = "Attributes";
            this.visitAttrToolStripMenuItem.Click += new System.EventHandler(this.visitAttrToolStripMenuItem_Click);
            // 
            // getAttributeToolStripMenuItem
            // 
            this.getAttributeToolStripMenuItem.Name = "getAttributeToolStripMenuItem";
            this.getAttributeToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.getAttributeToolStripMenuItem.Text = "GetAttribute";
            this.getAttributeToolStripMenuItem.Click += new System.EventHandler(this.getAttributeToolStripMenuItem_Click);
            // 
            // cookieToolStripMenuItem
            // 
            this.cookieToolStripMenuItem.Name = "cookieToolStripMenuItem";
            this.cookieToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.cookieToolStripMenuItem.Text = "Cookie";
            this.cookieToolStripMenuItem.Click += new System.EventHandler(this.cookieToolStripMenuItem_Click);
            // 
            // setAttributeToolStripMenuItem
            // 
            this.setAttributeToolStripMenuItem.Name = "setAttributeToolStripMenuItem";
            this.setAttributeToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.setAttributeToolStripMenuItem.Text = "SetAttribute";
            this.setAttributeToolStripMenuItem.Click += new System.EventHandler(this.setAttributeToolStripMenuItem_Click);
            // 
            // clickToolStripMenuItem
            // 
            this.clickToolStripMenuItem.Name = "clickToolStripMenuItem";
            this.clickToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.clickToolStripMenuItem.Text = "Click";
            this.clickToolStripMenuItem.Click += new System.EventHandler(this.clickToolStripMenuItem_Click);
            // 
            // appElementListenerToolStripMenuItem
            // 
            this.appElementListenerToolStripMenuItem.Name = "appElementListenerToolStripMenuItem";
            this.appElementListenerToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.appElementListenerToolStripMenuItem.Text = "AppElementListener";
            this.appElementListenerToolStripMenuItem.Click += new System.EventHandler(this.appElementListenerToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(0, 55);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(605, 317);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chromeWebBrowser1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(597, 291);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(541, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "GO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(13, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(522, 21);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "http://www.baidu.com";
            // 
            // chromeWebBrowser1
            // 
            this.chromeWebBrowser1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.chromeWebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chromeWebBrowser1.Location = new System.Drawing.Point(3, 3);
            this.chromeWebBrowser1.Name = "chromeWebBrowser1";
            this.chromeWebBrowser1.Size = new System.Drawing.Size(591, 285);
            this.chromeWebBrowser1.TabIndex = 0;
            this.chromeWebBrowser1.BrowserTitleChange += new Sashulin.TitleChangeEventHandler(this.chromeWebBrowser1_BrowserTitleChange);
            this.chromeWebBrowser1.BrowserUrlChange += new Sashulin.UrlChangeEventHandler(this.chromeWebBrowser1_BrowserUrlChange);
            this.chromeWebBrowser1.BrowserNewWindow += new Sashulin.NewWindowEventHandler(this.chromeWebBrowser1_BrowserNewWindow);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 372);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Cwber 1.1.0.0 Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getElementValueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAllCookieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setCookiePathToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem setElementValueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showDevToolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setScreenSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetScreenSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getSourceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem callCSharpMethodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evalScriptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem executeScriptToolStripMenuItem;
        private Sashulin.ChromeWebBrowser chromeWebBrowser1;
        private System.Windows.Forms.ToolStripMenuItem appendElementEventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setPopupMenuVisibleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setPopupMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadRequestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPluginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem function2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setElementValueToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem elementListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getElementByIdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setInnerHtmlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getInnerHtmlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visitAttrToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getAttributeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cookieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setAttributeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clickToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appElementListenerToolStripMenuItem;

    }
}

