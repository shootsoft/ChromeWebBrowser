using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using Cef3;
using Sashulin.common;
using Sashulin.Core;

namespace Sashulin
{
    public partial class ChromeWebBrowser: UserControl
    {
        private const string DumpRequestDomain = "dump-request.app.cefglue.sashulin.local";//"dump-request.clientapp.cefglue.sashulin.local";
        private CefClient client;
        private bool created = false;
        private static bool initialized = false;
        private string  _homeUrl = "about:blank";
        private IntPtr browserHandle;
        private string cookiePath = "/";
        private string _title = string.Empty;
        private string _url = string.Empty;
        private CSharpBrowserSettings browserSettings = new CSharpBrowserSettings();
        private CwbDocument _document = null;

        internal CefBrowser browser;
        internal CefRequest selfRequest;
        internal int screenWidth = 0;
        internal int screenHeight = 0;
        internal bool menuVisible = true;

        public ChromeWebBrowser()
        {
            InitializeComponent();
            Global.instance = this;
            
        }

        public ChromeWebBrowser(CSharpBrowserSettings settings) : this()
        {
            browserSettings = settings;
            Initialize();
        }
        
        private void CreateBrowser()
        {
            CefWindowInfo windowInfo = CefWindowInfo.Create();
            windowInfo.SetAsChild(Handle, new CefRectangle { X = 0, Y = 0, Width = Width, Height = Height });
            if (client == null)
            {
                client = new ClientBrowser(this);
            }
            var settings = new CefBrowserSettings() { };
            settings.AcceleratedCompositing = CefState.Enabled;
            settings.ApplicationCache = CefState.Enabled;
            settings.AuthorAndUserStyles = CefState.Enabled;
            settings.CaretBrowsing = CefState.Enabled;
            settings.Databases = CefState.Enabled;
            settings.FileAccessFromFileUrls = CefState.Enabled;
            settings.ImageLoading = CefState.Enabled;
            settings.ImageShrinkStandaloneToFit = CefState.Enabled;
            settings.Java = CefState.Enabled;
            settings.JavaScript = CefState.Enabled; ;
            settings.JavaScriptAccessClipboard = CefState.Enabled;
            settings.JavaScriptCloseWindows = CefState.Enabled;
            settings.JavaScriptDomPaste = CefState.Enabled; ;
            settings.JavaScriptOpenWindows = CefState.Enabled;
            settings.LocalStorage = CefState.Enabled; ;
            settings.Plugins = CefState.Enabled; ;
            settings.RemoteFonts = CefState.Enabled;
            settings.TabToLinks = CefState.Enabled; ;
            settings.TextAreaResize = CefState.Enabled;
            settings.UniversalAccessFromFileUrls = CefState.Enabled;
            settings.WebGL = CefState.Enabled;
            settings.WebSecurity = CefState.Enabled;

            CefBrowserHost.CreateBrowser(windowInfo, client, settings, browserSettings.DefaultUrl);
            
        }


        public int Initialize(CSharpBrowserSettings settings)
        {
            browserSettings = settings;
            return Initialize();
        }

        public int Initialize()
        {
            if (initialized)
            {
                if (!created)
                {
                    CreateBrowser();
                }
                return 0;
            } 
            CefRuntime.Load();
            var settings = new CefSettings();
            settings.MultiThreadedMessageLoop = CefRuntime.Platform == CefRuntimePlatform.Windows;
            settings.ReleaseDCheckEnabled = true;
            settings.SingleProcess = true;
            settings.PersistSessionCookies = true;
            settings.CommandLineArgsDisabled = false;
            settings.ContextSafetyImplementation = CefContextSafetyImplementation.SafeDefault;
            settings.IgnoreCertificateErrors = true;
            settings.ResourcesDirPath = "/res";
            settings.PackLoadingDisabled = false;
            settings.LogSeverity = CefLogSeverity.Default;
            settings.LogFile = "cef.log";
            settings.ResourcesDirPath = System.IO.Path.GetDirectoryName(new Uri(System.Reflection.Assembly.GetEntryAssembly().CodeBase).LocalPath);
            settings.RemoteDebuggingPort = 9000;
            settings.UserAgent = browserSettings.UserAgent;
            settings.Locale = browserSettings.Locale;
            settings.LocalesDirPath = browserSettings.LocaleDirPath;
            settings.CachePath = browserSettings.CachePath;

            var args = new string[] { };
            var argv = args;
            if (CefRuntime.Platform != CefRuntimePlatform.Windows)
            {
                argv = new string[args.Length + 1];
                Array.Copy(args, 0, argv, 1, args.Length);
                argv[0] = "-";
            }

            var mainArgs = new CefMainArgs(argv);
            Global.app = new ClientApp();
            Global.app.SetBrowserControl(Global.instance);
            var exitCode = CefRuntime.ExecuteProcess(mainArgs, Global.app);
            Console.WriteLine("CefRuntime.ExecuteProcess() returns {0}", exitCode);
            if (exitCode != -1)
                return exitCode;

            foreach (var arg in args) { if (arg.StartsWith("--type=")) { return -2; } }
            CefRuntime.Initialize(mainArgs, settings, Global.app);
            CefRuntime.RegisterSchemeHandlerFactory("http", DumpRequestDomain, new AppSchemeHandlerFactory());
            bool b = CefRuntime.AddCrossOriginWhitelistEntry("http://localhost", "http", "", true);
            CreateBrowser();
            initialized = true;
            return 0;
        }

        public void Free()
        {
            CefRuntime.Shutdown();
        }

        private void ResizeWindow(IntPtr handle, int width, int height)
        {
            if (handle != IntPtr.Zero)
            {
                WinApi.SetWindowPos(handle, IntPtr.Zero,
                    0, 0, width, height,
                     SetWindowPosFlags.NoZOrder
                    );
            }
        }

        #region chromewebbrowser methods
        public void OpenUrl(string Url)
        {
            while (true)
            {
                if (created) break;
                Application.DoEvents();
            }
            if (browser != null)
            {
                OnNavigating();
                
                CefCookie cookie = new CefCookie();
                cookie.Name = "cwberCookieName";
                cookie.Value = "cwberCookie";
                cookie.Domain = "cwberCookieDomain";
                cookie.Path = cookiePath;
                cookie.Secure = false;
                cookie.HttpOnly = false;
                cookie.Expires = DateTime.Now;
                cookie.Creation = DateTime.Now;
                CefRuntime.PostTask(CefThreadId.IO, new CwbCookieTask(Url, cookie));
                browser.GetMainFrame().LoadUrl(Url);
                OnNavigated();
            }
        }

        public void OpenUrl(object request)
        {
            while (true)
            {
                if (created) break;
                Application.DoEvents();
            }
            if (browser != null)
            {
                OnNavigating();

                
                //browser.GetMainFrame().LoadUrl(((CefRequest)request).Url);
                browser.GetMainFrame().LoadRequest((CefRequest)request);
                //browser.Reload();
                //browser.SendProcessMessage(CefProcessId.Renderer, CefProcessMessage.Create("LoadRequest"));
                OnNavigated();
            }
        }

        public void SetCookiePath(string path)
        {
            cookiePath = path;
            CefCookieManager.Global.SetStoragePath(path, true);
        }

        public void DeleteAllCookies()
        {
            CwbCookieVisitor visitor = new CwbCookieVisitor(CwbCookieStyle.csDeleteAllCookie, _document);
            CefCookieManager.Global.VisitAllCookies(visitor);
        }

        public void DeleteCookie(string url, string cookieName)
        {
            CefCookieManager.Global.DeleteCookies(url, cookieName);
        }

        public void DeleteCookie(string cookieName)
        {
            CefCookieManager.Global.DeleteCookies(browser.GetMainFrame().Url, cookieName);
        }

        public string GetElementValueById(string id)
        {
            Global.flag = false;
            browser.SendProcessMessage(CefProcessId.Renderer, CefProcessMessage.Create("GetElementValue|" + id));
            while (!Global.flag)
            {

            }
            return Global.Result;
        }

        public void SetElementValueByid(string id, string value)
        {
            browser.SendProcessMessage(CefProcessId.Renderer, CefProcessMessage.Create("SetElementValue|" + id + "|" + value));
        }

        public void SelectAll()
        {
            if (browser != null)
            {
                browser.GetMainFrame().SelectAll();
            }
        }

        public void Copy()
        {
            if (browser != null)
            {
                browser.GetMainFrame().Copy();
            }
        }

        public void Paste()
        {
            if (browser != null)
            {
                browser.GetMainFrame().Paste();
            }
        }

        public void Reload(bool ignoreCache)
        {
            if (browser != null)
            {
                if (ignoreCache)
                    browser.ReloadIgnoreCache();
                else
                    browser.Reload();
            }
        }

        public void Reload()
        {
            if (browser != null)
            {
                browser.Reload();
            }
        }

        public void Stop()
        {
            if (browser != null)
            {
                browser.StopLoad();
            }
        }

        public void Back()
        {
            if (browser != null)
            {
                browser.GoBack();
            }
        }

        public void Forward()
        {
            if (browser != null)
            {
                browser.GoForward();
            }
        }

        public void Undo()
        {
            if (browser != null)
            {
                browser.GetMainFrame().Undo();
            }
        }

        public void Redo()
        {
            if (browser != null)
            {
                browser.GetMainFrame().Redo();
            }
        }

        public void Cut()
        {
            if (browser != null)
            {
                browser.GetMainFrame().Cut();
            }
        }

        public void Delete()
        {
            if (browser != null)
            {
                browser.GetMainFrame().Delete();
            }
        }

        public void ViewSource()
        {
            browser.GetMainFrame().ViewSource();
        }

        public string GetSource()
        {
            var pageVisitor = new CwbStringVisitor();
            browser.GetMainFrame().GetSource(pageVisitor);
            while (true)
            {
                if (!string.IsNullOrEmpty(pageVisitor.source)) break;
            }
            return pageVisitor.source;
        }

        public void ShowDevTool()
        {
            string devUrl = browser.GetHost().GetDevToolsUrl(true);
            browser.GetMainFrame().ExecuteJavaScript(
                    "window.open('" + devUrl + "');", "about:blank", 0);
            
        }

        public void CloseDevTool()
        {
            if (browser.GetMainFrame().Url.Contains("devtools.html"))
                browser.GetHost().CloseBrowser();
        }

        public void SetScreenSize(int w, int h)
        {
            screenWidth = w;
            screenHeight = h;
            if (browserHandle != IntPtr.Zero)
            {
                WinApi.SetWindowPos(browserHandle, IntPtr.Zero,
                    (Width-w)/2, (Height-h)/2, w, h,
                     SetWindowPosFlags.NoZOrder
                    );
            }
        }

        public void ResetScreen()
        {
            screenWidth = Screen.PrimaryScreen.Bounds.Width;
            screenWidth = Screen.PrimaryScreen.Bounds.Height;
            ResizeWindow(browserHandle, Width, Height);
        }

        public void LoadHtml(string htmlText)
        {
            if (browser != null)
            {
                browser.GetMainFrame().LoadString(htmlText, "about:blank");
            }
        }
        public delegate void TCallBackElementEventListener();
        internal List<CwbListenerItem> elementListenerList = new List<CwbListenerItem>();
        public void AppendElementEventListener(string id,string eventName,TCallBackElementEventListener callFunc)
        {
            string elementID = id.Replace("|0", "");
            foreach (CwbListenerItem t in elementListenerList)
            {
                if (t.id == elementID)
                {
                    return;
                }
            }
            CwbListenerItem item = new CwbListenerItem();
            item.id = elementID;
            item.eventName = eventName;
            item.elementListener = callFunc;
            elementListenerList.Add(item);
            browser.SendProcessMessage(CefProcessId.Renderer, CefProcessMessage.Create("AppendListener|" + id));
        }

        internal CwbListenerItem getEventListener(string id)
        {
            foreach (CwbListenerItem item in elementListenerList)
            {
                if (item.id == id)
                {
                    return item;
                }
            }
            return null;
        }

        internal void AppendAllElementEventListener()
        {
            foreach (CwbListenerItem item in elementListenerList)
            {
                browser.SendProcessMessage(CefProcessId.Renderer, CefProcessMessage.Create("AppendListener|" + item.id));
            }
        }

        public void ExecuteScript(string script)
        {
            browser.GetMainFrame().ExecuteJavaScript(script, browser.GetMainFrame().Url, 0);
        }

        public object EvaluateScript(string script)
        {
            Global.flag = false;
            browser.SendProcessMessage(CefProcessId.Renderer, CefProcessMessage.Create("EvaluateScript|" + script));
            while (!Global.flag)
            {
                Application.DoEvents();
            }
            return Global.JsEvaResult;
        }

        public void AddPluginPath(string PluginPath)
        {
            CefRuntime.AddWebPluginPath(PluginPath);
            CefRuntime.RefreshWebPlugins();
        }

        public void AddPluginDir(string PluginDir)
        {
            CefRuntime.AddWebPluginDirectory(PluginDir);
            CefRuntime.RefreshWebPlugins();
        }

        public void RemovePlugin(string path)
        {
            CefRuntime.RemoveWebPluginPath(path);
            CefRuntime.RefreshWebPlugins();
        }

        public void GoForward()
        {
            this.Forward();
        }

        public void GoBack()
        {
            this.Back();
        }

        public bool canGoForward()
        {
            return browser.CanGoForward;
        }

        public bool canGoBack()
        {
            return browser.CanGoBack;
        }

        

        public void SetPopupMenuVisible(bool visibled)
        {
            menuVisible = visibled;
        }

        public void SetPopupMenu(ContextMenu popupMenu)
        {
            menuVisible = false;
            this.ContextMenu = popupMenu;
        }
        
        #endregion


        #region chromewebbrowser properties

        public CwbDocument Document
        {
            get { return _document; }
        }

        public string HomeUrl
        {
            get
            {
                return _homeUrl;
            }
        }

        public string Url
        {
            get { return browser.GetMainFrame().Url; }
            set { _url = value; }
        }

        public string Title
        {
            get { return _title; }
        }

        public string Version
        {
            get { return "1.0.4.0"; }
        }

        #endregion

        #region chromewebbrowser events
        public event EventHandler BrowserCreated;
        internal void OnCreated(CefBrowser mainBrowser)
        {
            created = true;
            if (this.browser == null)
                this.browser = mainBrowser;
            browserHandle = browser.GetHost().GetWindowHandle();
            ResizeWindow(browserHandle, Width, Height);

            

            var handler = BrowserCreated;
            if (handler != null)
            {
                handler(this, EventArgs.Empty);
            }
        }
        public event EventHandler BrowserNavigated;
        internal void OnNavigated()
        {
            var handler = BrowserNavigated;
            if (handler != null)
            {
                handler(this, EventArgs.Empty);
            }
        }
        public event EventHandler BrowserNavigating;
        internal void OnNavigating()
        {
            var handler = BrowserNavigating;
            if (handler != null)
            {
                handler(this, EventArgs.Empty);
            }
        }
        public event EventHandler BrowserDocumentCompleted;
        internal void OnDocumentCompleted()
        {
            AppendAllElementEventListener();
            var handler = BrowserDocumentCompleted;
            if (handler != null)
            {
                handler(this, EventArgs.Empty);
            }
            _document = new CwbDocument(this.browser);
            _document.Load();
        }
        public event EventHandler BrowserFrameLoadStart;
        public event EventHandler PageLoadStartEventHandler;
        internal void OnLoadStart()
        {
            var handler = BrowserFrameLoadStart;
            if (handler != null)
            {
                handler(this, EventArgs.Empty);
                return;
            }
            handler = PageLoadStartEventHandler;
            if (handler != null)
            {
                handler(this, EventArgs.Empty);
            }
        }
        public event EventHandler BrowserFrameLoadEnd;
        public event EventHandler PageLoadFinishEventhandler;
        internal void OnLoadEnd()
        {
            var handler = BrowserFrameLoadEnd;
            if (handler != null)
            {
                handler(this, EventArgs.Empty);
                return;
            }
            handler = PageLoadFinishEventhandler;
            if (handler != null)
            {
                handler(this, EventArgs.Empty);
            }
        }
        public event FrameLoadErrorHandler BrowserFrameLoadError;
        internal void OnLoadError(CefErrorCode errorCode, string errorText, string url)
        {
            var handler = BrowserFrameLoadError;
            if (handler != null)
            {
                handler(this, new LoadErrorEventArgs(errorCode, errorText, url));
            }
            string htmlErrText =
                    "<html><body><h2>Failed to load URL " + url +
                    " with error " + errorText + " (" + errorCode +
                    ").</h2></body></html>";
            browser.GetMainFrame().LoadString(htmlErrText, url);
        }
        public event TitleChangeEventHandler BrowserTitleChange;
        internal void OnTitleChange(string title)
        {
            _title = title;
            var handler = BrowserTitleChange;
            if (handler != null)
            {
                handler(this, new TitleEventArgs(title));
            }
        }
        public event UrlChangeEventHandler BrowserUrlChange;
        internal void OnUrlChange(string url)
        {
            var handler = BrowserUrlChange;
            if (handler != null)
            {
                handler(this, new UrlChangeEventArgs(url));
            }
        }
        public event PreviewKeyDownEventHandler BrowserPreviewKeyDown;
        internal void OnPreviewKeyDown(bool bAlt, bool bCtrl, bool bShift, bool OnEditor,
                                       int keyCode, char key)
        {
            var handler = BrowserPreviewKeyDown;
            if (handler != null)
            {
                handler(this, new BrowserKeyDownEventArgs(bAlt, bCtrl, bShift, OnEditor,
                                        keyCode, key));
            }
        }
        public event EventHandler BrowserBeforeDownload;
        internal void OnBeforeDownload()
        {
            var handler = BrowserBeforeDownload;
            if (handler != null)
            {
                handler(this, EventArgs.Empty);
            }
        }

        public event DownloadingEventHandler BrowserDownloading;
        private Form downloadForm = null;
        internal void OnDownloading(long totalSize,
                                     long loadSize,
                                     long speedSize,
                                     int percent,
                                     string fileUrl,
                                     string fileName,
                                     string mimeType,
                                     bool isComplete,
                                     bool isInProgress)
        {
            var handler = BrowserDownloading;
            if (handler != null)
            {
                handler(this, new FileDownloadEventArgs(totalSize,
                                     loadSize,speedSize,
                                     percent,
                                     fileUrl,
                                     fileName,
                                     mimeType,
                                     isComplete,
                                     isInProgress));
            }
            else
            {
                string strTotalSize = CompareFileSize(totalSize);
                string strLoadedSize = CompareFileSize(loadSize);

                if (downloadForm == null)
                {
                    downloadForm = new Form();
                    downloadForm.Text = "下载中";
                    downloadForm.Width = 280;
                    downloadForm.Height = 150;
                    downloadForm.MaximizeBox = false;
                    downloadForm.MinimizeBox = false;
                    downloadForm.ControlBox = false;
                    downloadForm.StartPosition = FormStartPosition.CenterScreen;


                    Label label = new Label();
                    label.Left = 20;
                    label.Top = 50;
                    label.Width = 250;
                    label.Text = "已下载：" + strLoadedSize + "/" + strTotalSize;
                    downloadForm.Controls.Add(label);
                }
                downloadForm.Show();
                downloadForm.BringToFront();
                foreach (Control c in downloadForm.Controls)
                {
                    if (c is Label)
                    {
                        Label label = (Label)c;
                        label.Text = "已下载：" + strLoadedSize + "/" + strTotalSize;
                        label.Update();
                    }
                }
                downloadForm.Update();
                if (isComplete)
                {
                    downloadForm.Dispose();
                    downloadForm = null;
                }
            }
        }

        private string CompareFileSize(Int64 size)
        {
            //计算K,M单位
            string strTotalSize = string.Empty;
            if (size < 1024)
            {
                strTotalSize = size.ToString() + " B";
            }
            else if (size >= 1024 && size < 1024 * 1024)
            {
                strTotalSize = (size / 1024).ToString() + " KB";
            }
            else
            {
                strTotalSize = (size / 1024 / 1024).ToString() + " MB";
            }
            return strTotalSize;
        }


        public event NewWindowEventHandler BrowserNewWindow;
        internal bool OnNewWindow(string targetUrl)
        {
            bool res = false;
            var handler = BrowserNewWindow;
            if (handler != null)
            {
                handler(this, new NewWindowEventArgs(targetUrl, selfRequest));
                res = true;
            }
            return res;
        }

        #endregion

        #region 
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            Global.BrowserList.Add(this);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            var form = TopLevelControl as Form;
            if (form != null && form.WindowState != FormWindowState.Minimized)
            {
                ResizeWindow(browserHandle, Width, Height);
            }
        }
        #endregion
    }
}
