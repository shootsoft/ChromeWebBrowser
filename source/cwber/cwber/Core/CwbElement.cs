using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cef3;

namespace Sashulin.Core
{
    public class CwbElement
    {
        private string _id;
        private string _tagName;
        private string _indexPath;
        private string _value;
        private string _text;
        private Boolean _isElement;
        private Boolean _isEditable;
        private Boolean _hasChildren;
        private Boolean _hasAttributes;
        private List<CwbElement> _elements = new List<CwbElement>();
        private int browserIdentifier;
        private IDictionary<string, string> _attributes = new Dictionary<string, string>();

        public CwbElement() { }
        public CwbElement(CefBrowser browser, string id, string tagName,
                          string value,
                          Boolean isElement,Boolean isEditable,
                          Boolean hasChildren,
                          string text, Boolean hasAttributes)
        {
            this.browserIdentifier = browser.Identifier;
            _id = id;
            _tagName = tagName;
            _value = value;
            _isElement = isElement;
            _isEditable = isEditable;
            _hasChildren = hasChildren;
            _text = text;
            _hasAttributes = hasAttributes;
        }

        public string Id
        {
            get { return _id; }
        }

        public string TagName
        {
            get { return _tagName; }
        }

        public string IndexPath
        {
            get { return _indexPath; }
            set { _indexPath = value; }
        }

        public List<CwbElement> ChildElements
        {
            get { return _elements; }
            set { _elements = value; }
        }

        public Boolean IsElement
        {
            get { return _isElement; }
        }

        public Boolean IsEditable
        {
            get { return _isEditable; }
        }

        public Boolean HasChildren
        {
            get { return _hasChildren; }
        }

        public Boolean HasAttributes
        {
            get { return _hasAttributes; }
        }

        public IDictionary<string, string> Attributes
        {
            get { return _attributes; }
        }

        public string InnerText
        {
            get { return _text; }
        }

        public string InnerHtml
        {
            get
            {
                string retValue = string.Empty;
                string script = string.Empty;
                Boolean has = GetNodeScript(ref script);
                if (has)
                {
                    script += ".innerHTML;";
                    object o = GetCurrentBrowser().EvaluateScript(script);
                    if (o != null)
                        retValue = o.ToString();
                }
                return retValue;
            }
            set
            {
                string script = string.Empty;
                Boolean has = GetNodeScript(ref script);
                if (has)
                {
                    script += ".innerHTML = '" + value + "'";
                    GetCurrentBrowser().ExecuteScript(script);
                }
            }
        }

        public string Value
        {
            get {
                _value = string.Empty;
                string script = string.Empty;
                Boolean has = GetNodeScript(ref script);
                if (has)
                {
                    script += ".value;";
                    object o = GetCurrentBrowser().EvaluateScript(script);
                    _value = o.ToString();
                }
                return _value; 
            }
            set {
                _value = value;
                string script = string.Empty;
                Boolean has = GetNodeScript(ref script);
                if (has)
                {
                    script += ".value = '" + value + "'";
                    GetCurrentBrowser().ExecuteScript(script);
                }
            }
        }

        public bool HasAttribute(string attrName)
        {
            return _attributes.ContainsKey(attrName);
        }

        public string GetAttribute(string attrName)
        {
            string retValue = string.Empty;
            if (HasAttribute(attrName))
                retValue = _attributes[attrName];
            return retValue;
        }

        public void SetAttribute(string attrName,string value)
        {
            string script = string.Empty;
            Boolean has = GetNodeScript(ref script);
            if (has)
            {
                script += ".setAttribute('" + attrName + "','" + value + "');";
                GetCurrentBrowser().ExecuteScript(script);
            }
        }

        public void Click()
        {
            string script = string.Empty;
            Boolean has = GetNodeScript(ref script);
            if (has)
            {
                script += ".click();";
                GetCurrentBrowser().ExecuteScript(script);
            }
        }

        public void AttachEventListener(string eventName, ChromeWebBrowser.TCallBackElementEventListener eventListener)
        {
            GetCurrentBrowser().AppendElementEventListener(IndexPath + "|0", eventName, eventListener);
        }

        private bool GetNodeScript(ref string script)
        {
            Boolean retValue = false;
            script = "document";
            string[] indexArray = IndexPath.Split(new char[] { '.' });
            for (int i = 1; i < indexArray.Length; i++)
            {
                retValue = true;
                script += ".childNodes[" + indexArray[i] + "]";
            }
            return retValue;
        }

        private ChromeWebBrowser GetCurrentBrowser()
        {
            ChromeWebBrowser b = null;
            foreach (ChromeWebBrowser c in Global.BrowserList)
            {
                if (c == null) continue;
                if (c.browser.Identifier == browserIdentifier)
                {
                    b = c;
                    break;
                }
            }
            return b;
        }

    }
}
