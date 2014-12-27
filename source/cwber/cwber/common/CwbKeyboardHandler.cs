using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cef3;

namespace Sashulin.common
{
    internal sealed class CwbKeyboardHandler : CefKeyboardHandler
    {
        private ChromeWebBrowser webBrowser;

        public CwbKeyboardHandler(ChromeWebBrowser browser)
        {
            webBrowser = browser;
        }

        protected override bool OnPreKeyEvent(CefBrowser browser, CefKeyEvent keyEvent, IntPtr os_event, out bool isKeyboardShortcut)
        {
            if (keyEvent.EventType == CefKeyEventType.RawKeyDown)
                webBrowser.OnPreviewKeyDown(keyEvent.Modifiers == CefEventFlags.AltDown,
                                            keyEvent.Modifiers == CefEventFlags.ControlDown,
                                            keyEvent.Modifiers == CefEventFlags.ShiftDown,
                                            keyEvent.FocusOnEditableField, 
                                            keyEvent.WindowsKeyCode, 
                                            keyEvent.Character);

            return base.OnPreKeyEvent(browser, keyEvent, os_event, out isKeyboardShortcut);
        }
    }
}
