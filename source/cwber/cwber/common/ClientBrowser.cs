using System;
using System.Collections.Generic;
using System.Text;
using Cef3;

namespace Sashulin.common
{
    public sealed class ClientBrowser : CefClient
    {
        private readonly CwbLifeSpanHandler _lifeSpanHandler;
        private readonly CwbDisplayHandler _displayHandler;
        private readonly CwbLoadHandler _loadHandler;
        private readonly CwbKeyboardHandler _keyboardHandler;
        private readonly FileDownloadHandler _fileDownloadHandler;
        private readonly CwbRequestHandler _requestHandler;
        private readonly CwbRenderHandler _renderHandler;
        private readonly CwbMenuHandler _menuHandler;

        private ChromeWebBrowser webBrowser;
        public ClientBrowser(ChromeWebBrowser browser)
        {
            webBrowser = browser;
            _lifeSpanHandler = new CwbLifeSpanHandler(browser);
            _displayHandler = new CwbDisplayHandler(browser);
            _loadHandler = new CwbLoadHandler(browser);
            _keyboardHandler = new CwbKeyboardHandler(browser);
            _fileDownloadHandler = new FileDownloadHandler(browser);
            _requestHandler = new CwbRequestHandler(browser);
            _renderHandler = new CwbRenderHandler(browser);
            _menuHandler = new CwbMenuHandler(browser);
        }

        protected override CefLifeSpanHandler GetLifeSpanHandler()
        {
            return _lifeSpanHandler;
        }

        protected override CefDisplayHandler GetDisplayHandler()
        {
            return _displayHandler;
        }

        protected override CefLoadHandler GetLoadHandler()
        {
            return _loadHandler;
        }

        protected override CefKeyboardHandler GetKeyboardHandler()
        {
            return _keyboardHandler;
        }

        protected override bool OnProcessMessageReceived(CefBrowser browser, CefProcessId sourceProcess, CefProcessMessage message)
        {
            Console.WriteLine("Client::OnProcessMessageReceived: SourceProcess={0}", sourceProcess);
            Console.WriteLine("Message Name={0} IsValid={1} IsReadOnly={2}", message.Name, message.IsValid, message.IsReadOnly);
            var arguments = message.Arguments;
            for (var i = 0; i < arguments.Count; i++)
            {
                var type = arguments.GetValueType(i);
                object value;
                switch (type)
                {
                    case CefValueType.Null: value = null; break;
                    case CefValueType.String: value = arguments.GetString(i); break;
                    case CefValueType.Int: value = arguments.GetInt(i); break;
                    case CefValueType.Double: value = arguments.GetDouble(i); break;
                    case CefValueType.Bool: value = arguments.GetBool(i); break;
                    default: value = null; break;
                }

                Console.WriteLine("  [{0}] ({1}) = {2}", i, type, value);
            }

            if (message.Name == "myMessage2" || message.Name == "myMessage3") return true;

            return false;
        }

        protected override CefDownloadHandler GetDownloadHandler()
        {
            return _fileDownloadHandler;
        }
        protected override CefRenderHandler GetRenderHandler()
        {
            return _renderHandler;
        }

        protected override CefRequestHandler GetRequestHandler()
        {
            return _requestHandler;
        }

        protected override CefJSDialogHandler GetJSDialogHandler()
        {
            return base.GetJSDialogHandler();
        }
        protected override CefContextMenuHandler GetContextMenuHandler()
        {
            return _menuHandler;
        }
        
    }
}
