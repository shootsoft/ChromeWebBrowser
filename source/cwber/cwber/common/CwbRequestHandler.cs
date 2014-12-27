using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cef3;
namespace Sashulin.common
{
    class CwbRequestHandler : CefRequestHandler
    {
        private ChromeWebBrowser webBrowser;
        public CwbRequestHandler(ChromeWebBrowser browser)
        {
            webBrowser = browser;
        }
        protected override bool OnBeforeBrowse(CefBrowser browser, CefFrame frame, CefRequest request, bool isRedirect)
        {
            webBrowser.selfRequest = request;
            return base.OnBeforeBrowse(browser, frame, request, isRedirect);
        }

        protected override bool OnBeforeResourceLoad(CefBrowser browser, CefFrame frame, CefRequest request)
        {
            return base.OnBeforeResourceLoad(browser, frame, request);
        }
    }
}
