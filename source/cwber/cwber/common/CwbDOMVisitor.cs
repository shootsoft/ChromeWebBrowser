using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cef3;
using Sashulin.Core;

namespace Sashulin.common
{
    class CwbDOMVisitor : CefDomVisitor
    {
        private CwbBusinStyle _businID;
        private string _elementID;
        private string _elementValue;
        private CwbListenerItem _item;
        private CefBrowser browser;
        public CwbDOMVisitor(CefBrowser browser, CwbBusinStyle businID, string elementID)
        {
            _businID = businID;
            _elementID = elementID;
            this.browser = browser;
        }
        public CwbDOMVisitor(CefBrowser browser, CwbBusinStyle businID, string elementID, string elementValue)
        {
            _businID = businID;
            _elementID = elementID;
            _elementValue = elementValue;
            this.browser = browser;
        }
        public CwbDOMVisitor(CefBrowser browser, CwbBusinStyle businID, CwbListenerItem item)
        {
            this.browser = browser;
            _businID = businID;
            _item = item;
        }
        protected override void Visit(CefDomDocument document)
        {
            CefDomNode element;
            switch (_businID)
            {
                case CwbBusinStyle.bsGetElementValue:
                    
                    Global.Result = "";
                    element = document.GetElementById(_elementID);
                    if (element == null)
                    {
                        Global.flag = true;
                        return;
                    }
                    Global.Result = element.Value;
                    if (element.ElementTagName.ToLower() != "input")
                        Global.Result = element.InnerText;
                    Global.flag = true;
                    break;
                case CwbBusinStyle.bsSetElementValue:
                    element = document.GetElementById(_elementID);
                    if (element == null) return;
                    if (element.IsEditable)
                        element.SetAttribute("value", _elementValue);
                    else
                    {
                        string code = "document.getElementById('{0}').innerHTML = '{1}';";
                        code = string.Format(code,_elementID,_elementValue);
                        Global.instance.ExecuteScript(code);
                    }
                    break;
                case CwbBusinStyle.bsAddElementEvent:
                    element = document.GetElementById(_item.id);
                    if (element == null) return;
                    element.AddEventListener(_item.eventName,new RSEventListener(_item.elementListener),true);
                    break;
                case CwbBusinStyle.bsVisitDocument:
                    Global.flag = false;
                    CefDomNode root = document.Root;
                    CwbElement Root = CreateElement(root);
                    if (Global.RootList.ContainsKey(browser.Identifier))
                    {
                        Global.RootList[ browser.Identifier ] = Root;
                    }
                    else
                    {
                        Global.RootList.Add(browser.Identifier, Root);
                    }
                    string indexPath = "0";
                    Root.IndexPath = indexPath;
                    AppendAllChildElement(root, Root, indexPath);
                    Global.flag = true;
                    break;
                case CwbBusinStyle.bsAttachElementEvent:
                    CefDomNode root1 = document.Root;
                    string indexPath1 = "0";
                    AttachEventHandler(root1, indexPath1, new RSEventListener(_item.elementListener));
                    Global.flag = true;
                    break;
            }
            _businID = CwbBusinStyle.bsNone;
        }

        public void AttachEventHandler(CefDomNode parentNode, string indexPath, RSEventListener listener)
        {
            if (parentNode.HasChildren)
            {
                CefDomNode node = parentNode.FirstChild;
                if (node == null) return;

                int index = 0;
                string indexPath1 = indexPath + "." + index.ToString();
                if (indexPath1 == _item.id)
                {
                    node.AddEventListener(_item.eventName, listener, true);
                    return;
                }
                AttachEventHandler(node, indexPath1, listener);

                node = node.NextSibling;
                while (node != null)
                {
                    index++;
                    indexPath1 = indexPath + "." + index.ToString();
                    if (indexPath1 == _item.id)
                    {
                        node.AddEventListener(_item.eventName, listener, true);
                        return;
                    }
                    AttachEventHandler(node, indexPath1, listener);
                    node = node.NextSibling;
                    System.Windows.Forms.Application.DoEvents();
                }
            }
        }

        public void AppendAllChildElement(CefDomNode parentNode,CwbElement parentElement, string indePath)
        {
            if (parentNode.HasChildren)
            {
                CefDomNode node = parentNode.FirstChild;
                if (node == null) return;

                int index = 0;
                CwbElement childElement = CreateElement(node);
                childElement.IndexPath = indePath + "."+index.ToString();
                parentElement.ChildElements.Add(childElement);
                AppendAllChildElement(node, childElement, childElement.IndexPath);

                node = node.NextSibling;
                while (node != null)
                {
                    childElement = CreateElement(node);
                    index++;
                    childElement.IndexPath = indePath + "." + index.ToString();
                    parentElement.ChildElements.Add(childElement);
                    AppendAllChildElement(node, childElement, childElement.IndexPath);
                    node = node.NextSibling;
                    System.Windows.Forms.Application.DoEvents();
                }
            }
        }

        private CwbElement CreateElement(CefDomNode node)
        {
            string id = string.Empty;
            if (node.HasAttribute("id"))
            {
                id = node.GetAttribute("id");
            }
            CwbElement retValue = new CwbElement(browser,id, node.ElementTagName,node.GetAttribute("value"),
                node.IsElement,node.IsEditable,
                node.HasChildren,node.InnerText,
                node.HasAttributes
                );
            foreach (KeyValuePair<string, string> item in node.GetAttributes())
            {
                retValue.Attributes.Add(item);
            }
            return retValue;
        }
    }

    class RSEventListener : CefDomEventListener
    {
        private ChromeWebBrowser.TCallBackElementEventListener _listener;
        public RSEventListener(ChromeWebBrowser.TCallBackElementEventListener listener)
        {
            _listener = listener;
        }
        protected override void HandleEvent(CefDomEvent @event)
        {
            _listener();
        }
    }
}
