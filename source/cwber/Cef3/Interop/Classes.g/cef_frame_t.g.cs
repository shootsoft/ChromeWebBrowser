//
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
//
namespace Cef3.Interop
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.InteropServices;
    using System.Security;
    
    [StructLayout(LayoutKind.Sequential, Pack = libcef.ALIGN)]
    [SuppressMessage("Microsoft.Design", "CA1049:TypesThatOwnNativeResourcesShouldBeDisposable")]
    internal unsafe struct cef_frame_t
    {
        internal cef_base_t _base;
        internal IntPtr _is_valid;
        internal IntPtr _undo;
        internal IntPtr _redo;
        internal IntPtr _cut;
        internal IntPtr _copy;
        internal IntPtr _paste;
        internal IntPtr _del;
        internal IntPtr _select_all;
        internal IntPtr _view_source;
        internal IntPtr _get_source;
        internal IntPtr _get_text;
        internal IntPtr _load_request;
        internal IntPtr _load_url;
        internal IntPtr _load_string;
        internal IntPtr _execute_java_script;
        internal IntPtr _is_main;
        internal IntPtr _is_focused;
        internal IntPtr _get_name;
        internal IntPtr _get_identifier;
        internal IntPtr _get_parent;
        internal IntPtr _get_url;
        internal IntPtr _get_browser;
        internal IntPtr _get_v8context;
        internal IntPtr _visit_dom;
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int add_ref_delegate(cef_frame_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int release_delegate(cef_frame_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int get_refct_delegate(cef_frame_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int is_valid_delegate(cef_frame_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void undo_delegate(cef_frame_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void redo_delegate(cef_frame_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void cut_delegate(cef_frame_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void copy_delegate(cef_frame_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void paste_delegate(cef_frame_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void del_delegate(cef_frame_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void select_all_delegate(cef_frame_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void view_source_delegate(cef_frame_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void get_source_delegate(cef_frame_t* self, cef_string_visitor_t* visitor);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void get_text_delegate(cef_frame_t* self, cef_string_visitor_t* visitor);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void load_request_delegate(cef_frame_t* self, cef_request_t* request);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void load_url_delegate(cef_frame_t* self, cef_string_t* url);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void load_string_delegate(cef_frame_t* self, cef_string_t* string_val, cef_string_t* url);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void execute_java_script_delegate(cef_frame_t* self, cef_string_t* code, cef_string_t* script_url, int start_line);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int is_main_delegate(cef_frame_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int is_focused_delegate(cef_frame_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate cef_string_userfree* get_name_delegate(cef_frame_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate long get_identifier_delegate(cef_frame_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate cef_frame_t* get_parent_delegate(cef_frame_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate cef_string_userfree* get_url_delegate(cef_frame_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate cef_browser_t* get_browser_delegate(cef_frame_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate cef_v8context_t* get_v8context_delegate(cef_frame_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void visit_dom_delegate(cef_frame_t* self, cef_domvisitor_t* visitor);
        
        // AddRef
        private static IntPtr _p0;
        private static add_ref_delegate _d0;
        
        public static int add_ref(cef_frame_t* self)
        {
            add_ref_delegate d;
            var p = self->_base._add_ref;
            if (p == _p0) { d = _d0; }
            else
            {
                d = (add_ref_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(add_ref_delegate));
                if (_p0 == IntPtr.Zero) { _d0 = d; _p0 = p; }
            }
            return d(self);
        }
        
        // Release
        private static IntPtr _p1;
        private static release_delegate _d1;
        
        public static int release(cef_frame_t* self)
        {
            release_delegate d;
            var p = self->_base._release;
            if (p == _p1) { d = _d1; }
            else
            {
                d = (release_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(release_delegate));
                if (_p1 == IntPtr.Zero) { _d1 = d; _p1 = p; }
            }
            return d(self);
        }
        
        // GetRefCt
        private static IntPtr _p2;
        private static get_refct_delegate _d2;
        
        public static int get_refct(cef_frame_t* self)
        {
            get_refct_delegate d;
            var p = self->_base._get_refct;
            if (p == _p2) { d = _d2; }
            else
            {
                d = (get_refct_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_refct_delegate));
                if (_p2 == IntPtr.Zero) { _d2 = d; _p2 = p; }
            }
            return d(self);
        }
        
        // IsValid
        private static IntPtr _p3;
        private static is_valid_delegate _d3;
        
        public static int is_valid(cef_frame_t* self)
        {
            is_valid_delegate d;
            var p = self->_is_valid;
            if (p == _p3) { d = _d3; }
            else
            {
                d = (is_valid_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(is_valid_delegate));
                if (_p3 == IntPtr.Zero) { _d3 = d; _p3 = p; }
            }
            return d(self);
        }
        
        // Undo
        private static IntPtr _p4;
        private static undo_delegate _d4;
        
        public static void undo(cef_frame_t* self)
        {
            undo_delegate d;
            var p = self->_undo;
            if (p == _p4) { d = _d4; }
            else
            {
                d = (undo_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(undo_delegate));
                if (_p4 == IntPtr.Zero) { _d4 = d; _p4 = p; }
            }
            d(self);
        }
        
        // Redo
        private static IntPtr _p5;
        private static redo_delegate _d5;
        
        public static void redo(cef_frame_t* self)
        {
            redo_delegate d;
            var p = self->_redo;
            if (p == _p5) { d = _d5; }
            else
            {
                d = (redo_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(redo_delegate));
                if (_p5 == IntPtr.Zero) { _d5 = d; _p5 = p; }
            }
            d(self);
        }
        
        // Cut
        private static IntPtr _p6;
        private static cut_delegate _d6;
        
        public static void cut(cef_frame_t* self)
        {
            cut_delegate d;
            var p = self->_cut;
            if (p == _p6) { d = _d6; }
            else
            {
                d = (cut_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(cut_delegate));
                if (_p6 == IntPtr.Zero) { _d6 = d; _p6 = p; }
            }
            d(self);
        }
        
        // Copy
        private static IntPtr _p7;
        private static copy_delegate _d7;
        
        public static void copy(cef_frame_t* self)
        {
            copy_delegate d;
            var p = self->_copy;
            if (p == _p7) { d = _d7; }
            else
            {
                d = (copy_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(copy_delegate));
                if (_p7 == IntPtr.Zero) { _d7 = d; _p7 = p; }
            }
            d(self);
        }
        
        // Paste
        private static IntPtr _p8;
        private static paste_delegate _d8;
        
        public static void paste(cef_frame_t* self)
        {
            paste_delegate d;
            var p = self->_paste;
            if (p == _p8) { d = _d8; }
            else
            {
                d = (paste_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(paste_delegate));
                if (_p8 == IntPtr.Zero) { _d8 = d; _p8 = p; }
            }
            d(self);
        }
        
        // Delete
        private static IntPtr _p9;
        private static del_delegate _d9;
        
        public static void del(cef_frame_t* self)
        {
            del_delegate d;
            var p = self->_del;
            if (p == _p9) { d = _d9; }
            else
            {
                d = (del_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(del_delegate));
                if (_p9 == IntPtr.Zero) { _d9 = d; _p9 = p; }
            }
            d(self);
        }
        
        // SelectAll
        private static IntPtr _pa;
        private static select_all_delegate _da;
        
        public static void select_all(cef_frame_t* self)
        {
            select_all_delegate d;
            var p = self->_select_all;
            if (p == _pa) { d = _da; }
            else
            {
                d = (select_all_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(select_all_delegate));
                if (_pa == IntPtr.Zero) { _da = d; _pa = p; }
            }
            d(self);
        }
        
        // ViewSource
        private static IntPtr _pb;
        private static view_source_delegate _db;
        
        public static void view_source(cef_frame_t* self)
        {
            view_source_delegate d;
            var p = self->_view_source;
            if (p == _pb) { d = _db; }
            else
            {
                d = (view_source_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(view_source_delegate));
                if (_pb == IntPtr.Zero) { _db = d; _pb = p; }
            }
            d(self);
        }
        
        // GetSource
        private static IntPtr _pc;
        private static get_source_delegate _dc;
        
        public static void get_source(cef_frame_t* self, cef_string_visitor_t* visitor)
        {
            get_source_delegate d;
            var p = self->_get_source;
            if (p == _pc) { d = _dc; }
            else
            {
                d = (get_source_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_source_delegate));
                if (_pc == IntPtr.Zero) { _dc = d; _pc = p; }
            }
            d(self, visitor);
        }
        
        // GetText
        private static IntPtr _pd;
        private static get_text_delegate _dd;
        
        public static void get_text(cef_frame_t* self, cef_string_visitor_t* visitor)
        {
            get_text_delegate d;
            var p = self->_get_text;
            if (p == _pd) { d = _dd; }
            else
            {
                d = (get_text_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_text_delegate));
                if (_pd == IntPtr.Zero) { _dd = d; _pd = p; }
            }
            d(self, visitor);
        }
        
        // LoadRequest
        private static IntPtr _pe;
        private static load_request_delegate _de;
        
        public static void load_request(cef_frame_t* self, cef_request_t* request)
        {
            load_request_delegate d;
            var p = self->_load_request;
            if (p == _pe) { d = _de; }
            else
            {
                d = (load_request_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(load_request_delegate));
                if (_pe == IntPtr.Zero) { _de = d; _pe = p; }
            }
            d(self, request);
        }
        
        // LoadURL
        private static IntPtr _pf;
        private static load_url_delegate _df;
        
        public static void load_url(cef_frame_t* self, cef_string_t* url)
        {
            load_url_delegate d;
            var p = self->_load_url;
            if (p == _pf) { d = _df; }
            else
            {
                d = (load_url_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(load_url_delegate));
                if (_pf == IntPtr.Zero) { _df = d; _pf = p; }
            }
            d(self, url);
        }
        
        // LoadString
        private static IntPtr _p10;
        private static load_string_delegate _d10;
        
        public static void load_string(cef_frame_t* self, cef_string_t* string_val, cef_string_t* url)
        {
            load_string_delegate d;
            var p = self->_load_string;
            if (p == _p10) { d = _d10; }
            else
            {
                d = (load_string_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(load_string_delegate));
                if (_p10 == IntPtr.Zero) { _d10 = d; _p10 = p; }
            }
            d(self, string_val, url);
        }
        
        // ExecuteJavaScript
        private static IntPtr _p11;
        private static execute_java_script_delegate _d11;
        
        public static void execute_java_script(cef_frame_t* self, cef_string_t* code, cef_string_t* script_url, int start_line)
        {
            execute_java_script_delegate d;
            var p = self->_execute_java_script;
            if (p == _p11) { d = _d11; }
            else
            {
                d = (execute_java_script_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(execute_java_script_delegate));
                if (_p11 == IntPtr.Zero) { _d11 = d; _p11 = p; }
            }
            d(self, code, script_url, start_line);
        }
        
        // IsMain
        private static IntPtr _p12;
        private static is_main_delegate _d12;
        
        public static int is_main(cef_frame_t* self)
        {
            is_main_delegate d;
            var p = self->_is_main;
            if (p == _p12) { d = _d12; }
            else
            {
                d = (is_main_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(is_main_delegate));
                if (_p12 == IntPtr.Zero) { _d12 = d; _p12 = p; }
            }
            return d(self);
        }
        
        // IsFocused
        private static IntPtr _p13;
        private static is_focused_delegate _d13;
        
        public static int is_focused(cef_frame_t* self)
        {
            is_focused_delegate d;
            var p = self->_is_focused;
            if (p == _p13) { d = _d13; }
            else
            {
                d = (is_focused_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(is_focused_delegate));
                if (_p13 == IntPtr.Zero) { _d13 = d; _p13 = p; }
            }
            return d(self);
        }
        
        // GetName
        private static IntPtr _p14;
        private static get_name_delegate _d14;
        
        public static cef_string_userfree* get_name(cef_frame_t* self)
        {
            get_name_delegate d;
            var p = self->_get_name;
            if (p == _p14) { d = _d14; }
            else
            {
                d = (get_name_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_name_delegate));
                if (_p14 == IntPtr.Zero) { _d14 = d; _p14 = p; }
            }
            return d(self);
        }
        
        // GetIdentifier
        private static IntPtr _p15;
        private static get_identifier_delegate _d15;
        
        public static long get_identifier(cef_frame_t* self)
        {
            get_identifier_delegate d;
            var p = self->_get_identifier;
            if (p == _p15) { d = _d15; }
            else
            {
                d = (get_identifier_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_identifier_delegate));
                if (_p15 == IntPtr.Zero) { _d15 = d; _p15 = p; }
            }
            return d(self);
        }
        
        // GetParent
        private static IntPtr _p16;
        private static get_parent_delegate _d16;
        
        public static cef_frame_t* get_parent(cef_frame_t* self)
        {
            get_parent_delegate d;
            var p = self->_get_parent;
            if (p == _p16) { d = _d16; }
            else
            {
                d = (get_parent_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_parent_delegate));
                if (_p16 == IntPtr.Zero) { _d16 = d; _p16 = p; }
            }
            return d(self);
        }
        
        // GetURL
        private static IntPtr _p17;
        private static get_url_delegate _d17;
        
        public static cef_string_userfree* get_url(cef_frame_t* self)
        {
            get_url_delegate d;
            var p = self->_get_url;
            if (p == _p17) { d = _d17; }
            else
            {
                d = (get_url_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_url_delegate));
                if (_p17 == IntPtr.Zero) { _d17 = d; _p17 = p; }
            }
            return d(self);
        }
        
        // GetBrowser
        private static IntPtr _p18;
        private static get_browser_delegate _d18;
        
        public static cef_browser_t* get_browser(cef_frame_t* self)
        {
            get_browser_delegate d;
            var p = self->_get_browser;
            if (p == _p18) { d = _d18; }
            else
            {
                d = (get_browser_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_browser_delegate));
                if (_p18 == IntPtr.Zero) { _d18 = d; _p18 = p; }
            }
            return d(self);
        }
        
        // GetV8Context
        private static IntPtr _p19;
        private static get_v8context_delegate _d19;
        
        public static cef_v8context_t* get_v8context(cef_frame_t* self)
        {
            get_v8context_delegate d;
            var p = self->_get_v8context;
            if (p == _p19) { d = _d19; }
            else
            {
                d = (get_v8context_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_v8context_delegate));
                if (_p19 == IntPtr.Zero) { _d19 = d; _p19 = p; }
            }
            return d(self);
        }
        
        // VisitDOM
        private static IntPtr _p1a;
        private static visit_dom_delegate _d1a;
        
        public static void visit_dom(cef_frame_t* self, cef_domvisitor_t* visitor)
        {
            visit_dom_delegate d;
            var p = self->_visit_dom;
            if (p == _p1a) { d = _d1a; }
            else
            {
                d = (visit_dom_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(visit_dom_delegate));
                if (_p1a == IntPtr.Zero) { _d1a = d; _p1a = p; }
            }
            try
            {
                d(self, visitor);
            }
            catch
            {
            }
        }
        
    }
}
