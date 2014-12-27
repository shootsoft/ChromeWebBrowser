using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cef3;
namespace Sashulin.common
{
    internal sealed class CwbLifeSpanHandler : CefLifeSpanHandler
    {
        private ChromeWebBrowser webBrowser;
        public CwbLifeSpanHandler(ChromeWebBrowser browser)
        {
            webBrowser = browser;
        }

        protected override void OnAfterCreated(CefBrowser browser)
        {
            base.OnAfterCreated(browser);
            webBrowser.OnCreated(browser);
        }

        protected override bool DoClose(CefBrowser browser)
        {
            return false;
        }

        protected override bool OnBeforePopup(CefBrowser browser, CefFrame frame, string targetUrl, string targetFrameName, CefPopupFeatures popupFeatures, CefWindowInfo windowInfo, ref CefClient client, CefBrowserSettings settings, ref bool noJavascriptAccess)
        {
            bool res = false;
            if (!string.IsNullOrEmpty(targetUrl))
            {
                if (webBrowser.selfRequest != null)
                {
                    CefRequest req = CefRequest.Create();
                    req.FirstPartyForCookies = webBrowser.selfRequest.FirstPartyForCookies;
                    req.Options = webBrowser.selfRequest.Options;
                    /*CefPostData postData = CefPostData.Create();
                    CefPostDataElement element = CefPostDataElement.Create();
                    int index = targetUrl.IndexOf("?");
                    string url = targetUrl.Substring(0, index);
                    string data = targetUrl.Substring(index + 1);
                    byte[] bytes = Encoding.UTF8.GetBytes(data);
                    element.SetToBytes(bytes);
                    postData.Add(element);
                    */
                    System.Collections.Specialized.NameValueCollection h = new System.Collections.Specialized.NameValueCollection();
                    h.Add("Content-Type", "application/x-www-form-urlencoded");
                    req.Set(targetUrl, webBrowser.selfRequest.Method, null, webBrowser.selfRequest.GetHeaderMap());
                    webBrowser.selfRequest = req;
                }
                //webBrowser.selfRequest.Set(targetUrl, webBrowser.selfRequest.Method, webBrowser.selfRequest.PostData, webBrowser.selfRequest.GetHeaderMap());
                res = webBrowser.OnNewWindow(targetUrl);
                if (res)
                    return res;
            }
            res = base.OnBeforePopup(browser, frame, targetUrl, targetFrameName, popupFeatures, windowInfo, ref client, settings, ref noJavascriptAccess);
            return res;
        }
    }
}
