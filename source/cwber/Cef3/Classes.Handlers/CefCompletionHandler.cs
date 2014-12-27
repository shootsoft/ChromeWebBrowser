namespace Cef3
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Runtime.InteropServices;
    using Cef3.Interop;
    
    /// <summary>
    /// Generic callback interface used for asynchronous completion.
    /// </summary>
    public abstract unsafe partial class CefCompletionHandler
    {
        private void on_complete(cef_completion_handler_t* self)
        {
            CheckSelf(self);

            OnComplete();
        }
        
        /// <summary>
        /// Method that will be called once the task is complete.
        /// </summary>
        protected abstract void OnComplete();
    }
}
