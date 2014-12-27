using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cef3;
namespace Sashulin.common
{
    internal sealed class AppSchemeHandlerFactory : CefSchemeHandlerFactory
    {
        protected override CefResourceHandler Create(CefBrowser browser, CefFrame frame, string schemeName, CefRequest request)
        {
            return new RequestResourceHandler();
        }
    }
}
