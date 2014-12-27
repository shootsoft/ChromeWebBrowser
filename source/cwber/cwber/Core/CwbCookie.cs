using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sashulin.Core
{
    public class CwbCookie
    {
        private DateTime _creation;
        public DateTime Creation
        {
            get
            {
                return _creation;
            }
            set
            {
                _creation = value;
            }
        }

        private string _domain;
        public string Domain
        {
            get { return _domain; }
            set { _domain = value; }
        }

        private DateTime? _expires;
        public DateTime? Expires
        {
            get { return _expires;  }
            set { _expires = value; }
        }

        private bool _httpOnly;
        public bool HttpOnly
        {
            get { return _httpOnly; }
            set { _httpOnly = value; }
        }

        private DateTime _lastAccess;
        public DateTime LastAccess
        {
            get { return _lastAccess; }
            set { _lastAccess = value; }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _value;
        public string Value
        {
            get { return _value; }
            set { _value = value; }
        }

        private string _path;
        public string Path
        {
            get { return _path; }
            set { _path = value; }
        }

        private bool _secure;
        public bool Secure
        {
            get { return _secure; }
            set { _secure = value; }
        }
    }
}
