using System;
using System.Collections.Generic;
using System.Text;

namespace Sashulin
{
    public class JsMethodCall
    {
        /// <summary>
        /// 调整页面滚动条
        /// </summary>
        /// <param name="chrome"></param>
        /// <param name="ratioX">x坐标</param>
        /// <param name="ratioY">y坐标</param>
        public static void ScrollTo(ChromeWebBrowser chrome,float ratioX,float ratioY)
        {
            string jsCode = "var w=document.body.scrollWidth;" +
                            "var h=document.body.scrollHeight;" +
                            "window.scrollTo(w*{0},h*{1});";
            jsCode = string.Format(jsCode, ratioX, ratioY);
            chrome.ExecuteScript(jsCode);
        }
        public static void DoElementClick(ChromeWebBrowser chrome,string id)
        {
            string jsCode = "document.getElementById('{0}').click();";
            jsCode = string.Format(jsCode,id);
            chrome.ExecuteScript(jsCode);
        }
        /// <summary>
        /// 过滤元素，并触发点击
        /// </summary>
        /// <param name="chrome"></param>
        /// <param name="elementName">html元素名称，如input,a,div</param>
        /// <param name="attribute">元素属性名,如name,href,src</param>
        /// <param name="value">元素值</param>
        /// <param name="isFilter">true:模糊匹配,false:全量匹配</param>
        public static void DoElementClick(ChromeWebBrowser chrome,string elementName, string attribute, string value, bool isFilter)
        {
            string condStr = "  if(attr == '" + value + "') {";
            if (!isFilter)
            {
                condStr = "  if(attr.indexOf('"+value+"')>=0) {";
            }
            string jsCode = " var controls = document.getElementsByTagName('" + elementName + "'); " +
                            "for(var i=0;i<controls.length;i++){" +
                            " var attr = controls[i].getAttribute('" + attribute + "')+'';" +
                            condStr +
                            " controls[i].click(); " +
                            "  }}";
            chrome.ExecuteScript(jsCode);
        }
    }
}
