using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cef3;

namespace Sashulin.common
{
    class CwbRenderHandler : CefRenderHandler
    {
        private ChromeWebBrowser webBrowser;
        public CwbRenderHandler(ChromeWebBrowser browser)
        {
            webBrowser = browser;
        }

        protected override bool GetRootScreenRect(CefBrowser browser, ref CefRectangle rect)
        {
            return base.GetRootScreenRect(browser, ref rect);
        }

        protected override void OnScrollOffsetChanged(CefBrowser browser)
        {
            throw new NotImplementedException();
        }

        protected override void OnCursorChange(CefBrowser browser, IntPtr cursorHandle)
        {
            throw new NotImplementedException();
        }

        protected override void OnPaint(CefBrowser browser, CefPaintElementType type, CefRectangle[] dirtyRects, IntPtr buffer, int width, int height)
        {
            throw new NotImplementedException();
        }

        protected override void OnPopupSize(CefBrowser browser, CefRectangle rect)
        {
            throw new NotImplementedException();
        }

        protected override bool GetScreenInfo(CefBrowser browser, CefScreenInfo screenInfo)
        {
            return true;
        }
    }
}
