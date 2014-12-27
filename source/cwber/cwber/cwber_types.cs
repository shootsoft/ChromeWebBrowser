using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cef3;
namespace Sashulin
{
    public class CSharpBrowserSettings
    {
        public string CachePath;
        public string Locale;
        public string LocaleDirPath;
        public string UserAgent;
        public string DefaultUrl = "about:blank";
    }
    public class TitleEventArgs : EventArgs
    {
        private string _title = string.Empty;
        public TitleEventArgs(string title)
        {
            this._title = title;
        }
        public string Title
        {
            set
            {
                _title = value;
            }
            get
            {
                return _title;
            }
        }
    }
    public class UrlChangeEventArgs : EventArgs
    {
        private string _url = string.Empty;
        public UrlChangeEventArgs(string url)
        {
            this._url = url;
        }
        public string Url
        {
            set
            {
                _url = value;
            }
            get
            {
                return _url;
            }
        }
    }
    public class NewWindowEventArgs : EventArgs
    {
        private string _newurl = string.Empty;
        private string _title = string.Empty;
        private object _request = null;
        public NewWindowEventArgs(string url,object request)
        {
            _newurl = url;
            _request = request;
        }
        public string NewUrl
        {
            set
            {
                _newurl = value;
            }
            get
            {
                return _newurl;
            }
        }
        public object Request
        {
            set
            {
                _request = value;
            }
            get
            {
                return _request;
            }
        }
    }

    public class LoadErrorEventArgs : EventArgs
    {
        private CefErrorCode _errorCode;
        private string _errorText;
        private string _failedUrl;

        public LoadErrorEventArgs(CefErrorCode code,string text,string url)
        {
            _errorCode = code;
            _errorText = text;
            _failedUrl = url;
        }

        public CefErrorCode ErrorCode
        {
            get { return _errorCode; }
            set { _errorCode = value;}
        }
        public string ErrorText
        {
            get { return _errorText; }
            set { _errorText = value;}
        }

        public string FailedUrl
        {
            get { return _failedUrl; }
            set { _failedUrl = value;}
        }

    }

    public class BrowserKeyDownEventArgs
    {
        private bool _alt;
        private bool _ctrl;
        private bool _shift;
        private bool _FocusOnEditableField;
        private System.Windows.Forms.Keys _keyCode;
        private char _key;

        public BrowserKeyDownEventArgs(bool bAlt,bool bCtrl,bool bShift,bool OnEditor,
                                       int keyCode,char key)
        {
            _alt = bAlt;
            _ctrl = bCtrl;
            _shift = bShift;
            _FocusOnEditableField = OnEditor;
            _keyCode = (System.Windows.Forms.Keys)keyCode;
            _key = key;
        }

        public bool Alt
        {
            get { return _alt; }
            set { _alt = value; }
        }

        public bool Ctrl
        {
            get { return _ctrl; }
            set { _ctrl = value; }
        }

        public bool Shift
        {
            get { return _shift; }
            set { _shift = value; }
        }

        public bool FocusOnEditableField
        {
            get { return _FocusOnEditableField; }
            set { _FocusOnEditableField = value; }
        }

        public System.Windows.Forms.Keys KeyCode
        {
            get { return _keyCode; }
            set { _keyCode = value; }
        }

        public char Key
        {
            get { return _key; }
            set { _key = value; }
        }

    }
    public class FileDownloadEventArgs
    {
        private long _totalSize;
        private long _loadSize;
        private long _speedSize;
        private int _percentComplete;
        private string _fileUrl;
        private string _fileName;
        private string _mimeType;
        private bool _IsComplete;
        private bool _IsInProgress;
        public FileDownloadEventArgs(long totalSize,
                                     long loadSize,
                                     long speedSize,
                                     int percent,
                                     string fileUrl,
                                     string fileName,
                                     string mimeType,
                                     bool isComplete,
                                     bool isInProgress)
        {
            _totalSize = totalSize;
            _loadSize = loadSize;
            _speedSize = speedSize;
            _percentComplete = percent;
            _fileUrl = fileUrl;
            _fileName = fileName;
            _mimeType = mimeType;
            _IsComplete = isComplete;
            _IsInProgress = isInProgress;
        }

        public long TotalSize
        {
            get { return _totalSize; }
        }

        public long LoadSize
        {
            get { return _loadSize; }
        }

        public long SpeedSize
        {
            get { return _speedSize; }
        }

        public int PercentComplete
        {
            get { return _percentComplete; }
        }

        public string FileUrl
        {
            get { return _fileUrl; }
        }

        public string FileName
        {
            get { return _fileName; }
        }

        public string MimeType
        {
            get { return _mimeType; }
        }

        public bool IsComplete
        {
            get { return _IsComplete; }
        }

        public bool IsInProgress
        {
            get { return _IsInProgress; }
        }
    }

    public delegate void FrameLoadErrorHandler(object sender, LoadErrorEventArgs e);
    public delegate void NewWindowEventHandler(object sender, NewWindowEventArgs e);
    public delegate void TitleChangeEventHandler(object sender, TitleEventArgs e);
    public delegate void UrlChangeEventHandler(object sender, UrlChangeEventArgs e);
    public delegate void PreviewKeyDownEventHandler(object sender, BrowserKeyDownEventArgs e);
    public delegate void DownloadingEventHandler(object sender, FileDownloadEventArgs e);
}
