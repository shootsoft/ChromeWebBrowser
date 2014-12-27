using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cef3;
namespace Sashulin.common
{
    class FileDownloadHandler : CefDownloadHandler
    {
        private ChromeWebBrowser webBrowser;
        public FileDownloadHandler(ChromeWebBrowser browser)
        {
            webBrowser = browser;
        }

        protected override void OnBeforeDownload(CefBrowser browser, CefDownloadItem downloadItem, string suggestedName, CefBeforeDownloadCallback callback)
        {
            callback.Continue(suggestedName, true);
            base.OnBeforeDownload(browser, downloadItem, suggestedName, callback);
            webBrowser.OnBeforeDownload();
        }

        protected override void OnDownloadUpdated(CefBrowser browser, CefDownloadItem downloadItem, CefDownloadItemCallback callback)
        {
            base.OnDownloadUpdated(browser, downloadItem, callback);
            webBrowser.OnDownloading(downloadItem.TotalBytes,
                                     downloadItem.ReceivedBytes,
                                     downloadItem.CurrentSpeed,
                                     downloadItem.PercentComplete,
                                     downloadItem.Url,
                                     downloadItem.SuggestedFileName,
                                     downloadItem.MimeType,
                                     downloadItem.IsComplete,
                                     downloadItem.IsInProgress);
            
        }
    }
}
