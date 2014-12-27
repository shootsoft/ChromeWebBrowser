using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cef3;

namespace Sashulin.common
{
    class RenderProcessHandler : CefRenderProcessHandler
    {
        private ChromeWebBrowser webBrowser;
        protected override bool OnProcessMessageReceived(CefBrowser browser, CefProcessId sourceProcess, CefProcessMessage message)
        {
            string[] items = message.Name.Split(new char[] {'|'} );
            if (items.Length == 0) return false;

            switch (items[0])
            {
                case "GetElementValue":
                {
                    string elementID = items[1];
                    long[] frameIDs = browser.GetFrameIdentifiers();
                    foreach (long frameID in frameIDs)
                    {
                        CefFrame frame = browser.GetFrame(frameID);
                        if (frame == null) continue;
                        frame.VisitDom(new CwbDOMVisitor(browser, CwbBusinStyle.bsGetElementValue, elementID));
                    }
                    browser.GetMainFrame().VisitDom(new CwbDOMVisitor(browser, CwbBusinStyle.bsGetElementValue, elementID));
                    return true;
                }
                case "SetElementValue":
                {
                    string elementID = items[1];
                    string elementValue = items[2];
                    long[] frameIDs = browser.GetFrameIdentifiers();
                    foreach (long frameID in frameIDs)
                    {
                        CefFrame frame = browser.GetFrame(frameID);
                        if (frame == null) continue;
                        frame.VisitDom(new CwbDOMVisitor(browser, CwbBusinStyle.bsGetElementValue, elementID, elementValue));
                    }
                    browser.GetMainFrame().VisitDom(new CwbDOMVisitor(browser, CwbBusinStyle.bsSetElementValue, elementID, elementValue));
                    return true;
                }
                case "EvaluateScript":
                {
                    CefV8Value value = CefV8Value.CreateString("t");
                    CefV8Exception exp;
                    browser.GetMainFrame().V8Context.TryEval(items[1], out value, out exp);
                    Global.JsEvaResult = null;
                    if (value.IsString)
                    {
                        Global.JsEvaResult = value.GetStringValue();
                    }
                    if (value.IsInt)
                    {
                        Global.JsEvaResult = value.GetIntValue();
                    }
                    if (value.IsDouble)
                    {
                        Global.JsEvaResult = value.GetDoubleValue();
                    }
                    if (value.IsBool)
                    {
                        Global.JsEvaResult = value.GetBoolValue();
                    }
                    if (value.IsDate)
                    {
                        Global.JsEvaResult = value.GetDateValue();
                    }
                    Global.flag = true;
                    return true;
                }
                case "AppendListener":
                {
                    CwbBusinStyle cbStyle = CwbBusinStyle.bsAddElementEvent;
                    if (items.Length > 2)
                        cbStyle = CwbBusinStyle.bsAttachElementEvent;
                    string elementID = items[1];
                    long[] frameIDs = browser.GetFrameIdentifiers();
                    foreach (long frameID in frameIDs)
                    {
                        CefFrame frame = browser.GetFrame(frameID);
                        if (frame == null) continue;
                        frame.VisitDom(new CwbDOMVisitor(browser, cbStyle, webBrowser.getEventListener(elementID)));
                    }
                    browser.GetMainFrame().VisitDom(new CwbDOMVisitor(browser, cbStyle, webBrowser.getEventListener(elementID)));
                    return true;
                }
                case "GetDocument":
                {
                    browser.GetMainFrame().VisitDom(new CwbDOMVisitor(browser, CwbBusinStyle.bsVisitDocument, ""));
                    return true;
                }
            }
            return false;
        }

        protected override void OnContextCreated(CefBrowser browser, CefFrame frame, CefV8Context context)
        {
            /*缓存数据库*/
            string extensionCode =
                    "var cachedb;" +
                    "if(!cachedb)" +
                    "	cachedb={};" +
                    "(function() {" +
                    " cachedb.Connect = function(dbName) {" +
                    "	native function Connect(dbName);" +
                    "	return Connect(dbName);" +
                    " };" +

                    " cachedb.Execute = function(commandText) {" +
                    "	native function Execute(commandText);" +
                    "	return Execute(commandText);" +
                    " };" +

                    " cachedb.Query = function(commandText) {" +
                    "	native function Query(commandText);" +
                    "	return Query(commandText);" +
                    " };" +

                    " cachedb.Close = function() {" +
                    "	native function Close();" +
                    "	return Close();" +
                    " };"+

					"})();";
            CefV8Handler ExtendsionHandler = new CwbJsExtendHandler(browser);
            CefRuntime.RegisterExtension("v8/cachedb", extensionCode, ExtendsionHandler);

            /*屏幕分辨率设置*/
            int w = webBrowser.screenWidth;
            int h = webBrowser.screenHeight;
            if (w > 0 && h > 0)
		    {
			    string jscode =
				     "Object.defineProperty(window.screen, 'height', {" +
				     "    get: function() {"+
				      "        return "+h+";"+
				      "    }"+
				      "});"+
				     "Object.defineProperty(window.screen, 'width', {"+
				     "    get: function() {"+
				     "        return "+w+";"+
				     "    }"+
				     "});";
			    frame.ExecuteJavaScript(jscode,frame.Url,0);
		    }
            /*注册执行C#方法*/
            CefV8Value globalValue = context.GetGlobal();
            CefV8Handler callHandler = new CwbJsExtendHandler(browser);
            CefV8Value callMethod = CefV8Value.CreateFunction("CallCSharpMethod", callHandler);
            globalValue.SetValue("CallCSharpMethod", callMethod, CefV8PropertyAttribute.None);
            base.OnContextCreated(browser, frame, context);
            
        }

        protected override CefLoadHandler GetLoadHandler()
        {

            return base.GetLoadHandler();
        }

        protected override void OnWebKitInitialized()
        {
            base.OnWebKitInitialized();
        }

        protected override void OnBrowserCreated(CefBrowser browser)
        {
            base.OnBrowserCreated(browser);
        }

        protected override bool OnBeforeNavigation(CefBrowser browser, CefFrame frame, CefRequest request, CefNavigationType navigation_type, bool isRedirect)
        {
            return base.OnBeforeNavigation(browser, frame, request, navigation_type, isRedirect);
        }

        public void SetBrowserControl(ChromeWebBrowser browser)
        {
            webBrowser = browser;
        }
    }
}
