using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cef3;
using Sashulin.Core;

namespace Sashulin.common
{
    class CwbCookieVisitor : CefCookieVisitor
    {
        private CwbCookieStyle _style;
        private CwbDocument _document;
        public CwbCookieVisitor(CwbCookieStyle style,CwbDocument document)
        {
            _style = style;
            _document = document;
        }

        protected override bool Visit(CefCookie cookie, int count, int total, out bool delete)
        {
            delete = false;
            switch (_style)
            {
                case CwbCookieStyle.csDeleteAllCookie:
                    delete = true;
                    break;
                case CwbCookieStyle.csVisitUrlCookie:
                    string cookieValue = cookie.Name + "=" + cookie.Value + ";";
                    _document._cookie += cookieValue;
                    CwbCookie cookieItem = new CwbCookie();
                    cookieItem.Creation = cookie.Creation;
                    cookieItem.Domain = cookie.Domain;
                    cookieItem.Expires = cookie.Expires;
                    cookieItem.HttpOnly = cookie.HttpOnly;
                    cookieItem.LastAccess = cookie.LastAccess;
                    cookieItem.Name = cookie.Name;
                    cookieItem.Path = cookie.Path;
                    cookieItem.Secure = cookie.Secure;
                    cookieItem.Value = cookie.Value;
                    _document._cookies.Add(cookieItem);
                    break;

            }
            return true;
        }

    }
}
