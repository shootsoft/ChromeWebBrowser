using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cef3;
using Sashulin.common;
using Sashulin.Core;

namespace Sashulin.Core
{
    public class CwbDocument
    {
        internal List<CwbCookie> _cookies = new List<CwbCookie>();
        private CwbElement _root;
        private CefBrowser browser;
        internal string _cookie;
        

        public CwbDocument(CefBrowser browser)
        {
            this.browser = browser;
        }

        public List<CwbCookie> Cookies
        {
            get { return _cookies; }
            set { _cookies = value; }
        }

        public string Cookie
        {
            get
            {
                return _cookie;
            }
            set
            {
                _cookie = value;
            }
        }

        public CwbElement Root
        {
            get { return _root; }
            set { _root = value; }
        }

        public void Load()
        {
            Global.flag = false;
            if (Root != null)
            {
                Root.ChildElements.Clear();
            }
            browser.SendProcessMessage(CefProcessId.Renderer, CefProcessMessage.Create("GetDocument"));
            while (!Global.flag)
            {

            }
            _root = Global.RootList[ browser.Identifier ];
            CefCookieManager.Global.VisitUrlCookies(browser.GetMainFrame().Url, true, new CwbCookieVisitor(CwbCookieStyle.csVisitUrlCookie, this));
        }


        public List<CwbElement> GetElementsByTagName(string tagName)
        {
            List<CwbElement> list = GetElementsByTagName(tagName,Root);
            return list;
        }

        private List<CwbElement> GetElementsByTagName(string tagName, CwbElement parent)
        {
            List<CwbElement> list = new List<CwbElement>();
            foreach (CwbElement e in parent.ChildElements)
            {
                if (string.IsNullOrEmpty(e.TagName)) continue;
                List<CwbElement> items = GetElementsByTagName(tagName, e);
                if (e.TagName.ToUpper() == tagName.ToUpper())
                {
                    list.Add(e);
                }
                list.AddRange(items);
            }
            return list;
        }

        public CwbElement GetElementById(string id)
        {
            return GetElementById(id,Root);
        }

        private CwbElement GetElementById(string id, CwbElement parent)
        {
            foreach (CwbElement e in parent.ChildElements)
            {
                if (e.Id.ToUpper() == id.ToUpper())
                {
                    return e;
                }
                CwbElement element = GetElementById(id, e);
                if (element != null)
                {
                    if (element.Id.ToUpper() == id.ToUpper())
                    {
                        return element;
                    }
                }
            }
            return null;
        }
    }
}
