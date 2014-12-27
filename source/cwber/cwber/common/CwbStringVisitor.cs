using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cef3;
namespace Sashulin.common
{
    class CwbStringVisitor : CefStringVisitor
    {
        internal string source = string.Empty;
        protected override void Visit(string value)
        {
            source = value;       
        }

    }
}
