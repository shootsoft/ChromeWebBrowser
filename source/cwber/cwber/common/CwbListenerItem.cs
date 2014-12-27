using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sashulin.common
{
    class CwbListenerItem
    {
        private string _id;
        private string _eventName;
        private ChromeWebBrowser.TCallBackElementEventListener _listener;

        public string id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string eventName
        {
            get { return _eventName; }
            set { _eventName = value; }
        }

        public ChromeWebBrowser.TCallBackElementEventListener elementListener
        {
            get { return _listener; }
            set { _listener = value; }
        }
    }
}
