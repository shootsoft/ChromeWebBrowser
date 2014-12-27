using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cef3;
namespace Sashulin.common
{
    internal sealed class CwbLoadHandler : CefLoadHandler
    {
        private ChromeWebBrowser webBrowser;

        public CwbLoadHandler(ChromeWebBrowser browser)
        {
            webBrowser = browser;
        }

        protected override void OnLoadingStateChange(CefBrowser browser, bool isLoading, bool canGoBack, bool canGoForward)
        {
            //_core.OnLoadingStateChanged(isLoading, canGoBack, canGoForward);
        }

        protected override void OnLoadStart(CefBrowser browser, CefFrame frame)
        {
            base.OnLoadStart(browser, frame);
            webBrowser.OnLoadStart();
        }

        protected override void OnLoadEnd(CefBrowser browser, CefFrame frame, int httpStatusCode)
        {
            base.OnLoadEnd(browser, frame, httpStatusCode);
            webBrowser.OnLoadEnd();
            if (frame.IsMain)
            {
                //browser.SendProcessMessage(CefProcessId.Renderer, CefProcessMessage.Create("VisitorDocument"));
                webBrowser.OnDocumentCompleted();
            }

        }

        protected override void OnLoadError(CefBrowser browser, CefFrame frame, CefErrorCode errorCode, string errorText, string failedUrl)
        {
            base.OnLoadError(browser, frame, errorCode, errorText, failedUrl);
            if (errorCode == CefErrorCode.Aborted) return;
            webBrowser.OnLoadError(errorCode, errorText, failedUrl);
        }
    }
}
