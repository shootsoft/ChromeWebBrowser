namespace Cef3
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class CefRuntimeException : Exception
    {
        public CefRuntimeException(string message)
            : base(message)
        {
        }
    }
}
