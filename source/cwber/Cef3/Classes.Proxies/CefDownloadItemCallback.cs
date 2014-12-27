namespace Cef3
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Runtime.InteropServices;
    using Cef3.Interop;

    /// <summary>
    /// Callback interface used to asynchronously cancel a download.
    /// </summary>
    public sealed unsafe partial class CefDownloadItemCallback
    {
        /// <summary>
        /// Call to cancel the download.
        /// </summary>
        public void Cancel()
        {
            cef_download_item_callback_t.cancel(_self);
        }
    }
}
