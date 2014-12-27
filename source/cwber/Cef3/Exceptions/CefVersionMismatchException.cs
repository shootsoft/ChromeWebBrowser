namespace Cef3
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public sealed class CefVersionMismatchException : CefRuntimeException
    {
        public CefVersionMismatchException(string message)
            : base(message)
        {
        }
    }
}
