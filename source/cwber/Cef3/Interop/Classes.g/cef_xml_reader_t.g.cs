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
    internal unsafe struct cef_xml_reader_t
    {
        internal cef_base_t _base;
        internal IntPtr _move_to_next_node;
        internal IntPtr _close;
        internal IntPtr _has_error;
        internal IntPtr _get_error;
        internal IntPtr _get_type;
        internal IntPtr _get_depth;
        internal IntPtr _get_local_name;
        internal IntPtr _get_prefix;
        internal IntPtr _get_qualified_name;
        internal IntPtr _get_namespace_uri;
        internal IntPtr _get_base_uri;
        internal IntPtr _get_xml_lang;
        internal IntPtr _is_empty_element;
        internal IntPtr _has_value;
        internal IntPtr _get_value;
        internal IntPtr _has_attributes;
        internal IntPtr _get_attribute_count;
        internal IntPtr _get_attribute_byindex;
        internal IntPtr _get_attribute_byqname;
        internal IntPtr _get_attribute_bylname;
        internal IntPtr _get_inner_xml;
        internal IntPtr _get_outer_xml;
        internal IntPtr _get_line_number;
        internal IntPtr _move_to_attribute_byindex;
        internal IntPtr _move_to_attribute_byqname;
        internal IntPtr _move_to_attribute_bylname;
        internal IntPtr _move_to_first_attribute;
        internal IntPtr _move_to_next_attribute;
        internal IntPtr _move_to_carrying_element;
        
        // Create
        [DllImport(libcef.DllName, EntryPoint = "cef_xml_reader_create", CallingConvention = libcef.CEF_CALL)]
        public static extern cef_xml_reader_t* create(cef_stream_reader_t* stream, CefXmlEncoding encodingType, cef_string_t* URI);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int add_ref_delegate(cef_xml_reader_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int release_delegate(cef_xml_reader_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int get_refct_delegate(cef_xml_reader_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int move_to_next_node_delegate(cef_xml_reader_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int close_delegate(cef_xml_reader_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int has_error_delegate(cef_xml_reader_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate cef_string_userfree* get_error_delegate(cef_xml_reader_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate CefXmlNodeType get_type_delegate(cef_xml_reader_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int get_depth_delegate(cef_xml_reader_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate cef_string_userfree* get_local_name_delegate(cef_xml_reader_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate cef_string_userfree* get_prefix_delegate(cef_xml_reader_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate cef_string_userfree* get_qualified_name_delegate(cef_xml_reader_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate cef_string_userfree* get_namespace_uri_delegate(cef_xml_reader_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate cef_string_userfree* get_base_uri_delegate(cef_xml_reader_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate cef_string_userfree* get_xml_lang_delegate(cef_xml_reader_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int is_empty_element_delegate(cef_xml_reader_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int has_value_delegate(cef_xml_reader_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate cef_string_userfree* get_value_delegate(cef_xml_reader_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int has_attributes_delegate(cef_xml_reader_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate UIntPtr get_attribute_count_delegate(cef_xml_reader_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate cef_string_userfree* get_attribute_byindex_delegate(cef_xml_reader_t* self, int index);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate cef_string_userfree* get_attribute_byqname_delegate(cef_xml_reader_t* self, cef_string_t* qualifiedName);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate cef_string_userfree* get_attribute_bylname_delegate(cef_xml_reader_t* self, cef_string_t* localName, cef_string_t* namespaceURI);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate cef_string_userfree* get_inner_xml_delegate(cef_xml_reader_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate cef_string_userfree* get_outer_xml_delegate(cef_xml_reader_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int get_line_number_delegate(cef_xml_reader_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int move_to_attribute_byindex_delegate(cef_xml_reader_t* self, int index);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int move_to_attribute_byqname_delegate(cef_xml_reader_t* self, cef_string_t* qualifiedName);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int move_to_attribute_bylname_delegate(cef_xml_reader_t* self, cef_string_t* localName, cef_string_t* namespaceURI);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int move_to_first_attribute_delegate(cef_xml_reader_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int move_to_next_attribute_delegate(cef_xml_reader_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int move_to_carrying_element_delegate(cef_xml_reader_t* self);
        
        // AddRef
        private static IntPtr _p0;
        private static add_ref_delegate _d0;
        
        public static int add_ref(cef_xml_reader_t* self)
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
        
        public static int release(cef_xml_reader_t* self)
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
        
        public static int get_refct(cef_xml_reader_t* self)
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
        
        // MoveToNextNode
        private static IntPtr _p3;
        private static move_to_next_node_delegate _d3;
        
        public static int move_to_next_node(cef_xml_reader_t* self)
        {
            move_to_next_node_delegate d;
            var p = self->_move_to_next_node;
            if (p == _p3) { d = _d3; }
            else
            {
                d = (move_to_next_node_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(move_to_next_node_delegate));
                if (_p3 == IntPtr.Zero) { _d3 = d; _p3 = p; }
            }
            return d(self);
        }
        
        // Close
        private static IntPtr _p4;
        private static close_delegate _d4;
        
        public static int close(cef_xml_reader_t* self)
        {
            close_delegate d;
            var p = self->_close;
            if (p == _p4) { d = _d4; }
            else
            {
                d = (close_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(close_delegate));
                if (_p4 == IntPtr.Zero) { _d4 = d; _p4 = p; }
            }
            return d(self);
        }
        
        // HasError
        private static IntPtr _p5;
        private static has_error_delegate _d5;
        
        public static int has_error(cef_xml_reader_t* self)
        {
            has_error_delegate d;
            var p = self->_has_error;
            if (p == _p5) { d = _d5; }
            else
            {
                d = (has_error_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(has_error_delegate));
                if (_p5 == IntPtr.Zero) { _d5 = d; _p5 = p; }
            }
            return d(self);
        }
        
        // GetError
        private static IntPtr _p6;
        private static get_error_delegate _d6;
        
        public static cef_string_userfree* get_error(cef_xml_reader_t* self)
        {
            get_error_delegate d;
            var p = self->_get_error;
            if (p == _p6) { d = _d6; }
            else
            {
                d = (get_error_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_error_delegate));
                if (_p6 == IntPtr.Zero) { _d6 = d; _p6 = p; }
            }
            return d(self);
        }
        
        // GetType
        private static IntPtr _p7;
        private static get_type_delegate _d7;
        
        public static CefXmlNodeType get_type(cef_xml_reader_t* self)
        {
            get_type_delegate d;
            var p = self->_get_type;
            if (p == _p7) { d = _d7; }
            else
            {
                d = (get_type_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_type_delegate));
                if (_p7 == IntPtr.Zero) { _d7 = d; _p7 = p; }
            }
            return d(self);
        }
        
        // GetDepth
        private static IntPtr _p8;
        private static get_depth_delegate _d8;
        
        public static int get_depth(cef_xml_reader_t* self)
        {
            get_depth_delegate d;
            var p = self->_get_depth;
            if (p == _p8) { d = _d8; }
            else
            {
                d = (get_depth_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_depth_delegate));
                if (_p8 == IntPtr.Zero) { _d8 = d; _p8 = p; }
            }
            return d(self);
        }
        
        // GetLocalName
        private static IntPtr _p9;
        private static get_local_name_delegate _d9;
        
        public static cef_string_userfree* get_local_name(cef_xml_reader_t* self)
        {
            get_local_name_delegate d;
            var p = self->_get_local_name;
            if (p == _p9) { d = _d9; }
            else
            {
                d = (get_local_name_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_local_name_delegate));
                if (_p9 == IntPtr.Zero) { _d9 = d; _p9 = p; }
            }
            return d(self);
        }
        
        // GetPrefix
        private static IntPtr _pa;
        private static get_prefix_delegate _da;
        
        public static cef_string_userfree* get_prefix(cef_xml_reader_t* self)
        {
            get_prefix_delegate d;
            var p = self->_get_prefix;
            if (p == _pa) { d = _da; }
            else
            {
                d = (get_prefix_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_prefix_delegate));
                if (_pa == IntPtr.Zero) { _da = d; _pa = p; }
            }
            return d(self);
        }
        
        // GetQualifiedName
        private static IntPtr _pb;
        private static get_qualified_name_delegate _db;
        
        public static cef_string_userfree* get_qualified_name(cef_xml_reader_t* self)
        {
            get_qualified_name_delegate d;
            var p = self->_get_qualified_name;
            if (p == _pb) { d = _db; }
            else
            {
                d = (get_qualified_name_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_qualified_name_delegate));
                if (_pb == IntPtr.Zero) { _db = d; _pb = p; }
            }
            return d(self);
        }
        
        // GetNamespaceURI
        private static IntPtr _pc;
        private static get_namespace_uri_delegate _dc;
        
        public static cef_string_userfree* get_namespace_uri(cef_xml_reader_t* self)
        {
            get_namespace_uri_delegate d;
            var p = self->_get_namespace_uri;
            if (p == _pc) { d = _dc; }
            else
            {
                d = (get_namespace_uri_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_namespace_uri_delegate));
                if (_pc == IntPtr.Zero) { _dc = d; _pc = p; }
            }
            return d(self);
        }
        
        // GetBaseURI
        private static IntPtr _pd;
        private static get_base_uri_delegate _dd;
        
        public static cef_string_userfree* get_base_uri(cef_xml_reader_t* self)
        {
            get_base_uri_delegate d;
            var p = self->_get_base_uri;
            if (p == _pd) { d = _dd; }
            else
            {
                d = (get_base_uri_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_base_uri_delegate));
                if (_pd == IntPtr.Zero) { _dd = d; _pd = p; }
            }
            return d(self);
        }
        
        // GetXmlLang
        private static IntPtr _pe;
        private static get_xml_lang_delegate _de;
        
        public static cef_string_userfree* get_xml_lang(cef_xml_reader_t* self)
        {
            get_xml_lang_delegate d;
            var p = self->_get_xml_lang;
            if (p == _pe) { d = _de; }
            else
            {
                d = (get_xml_lang_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_xml_lang_delegate));
                if (_pe == IntPtr.Zero) { _de = d; _pe = p; }
            }
            return d(self);
        }
        
        // IsEmptyElement
        private static IntPtr _pf;
        private static is_empty_element_delegate _df;
        
        public static int is_empty_element(cef_xml_reader_t* self)
        {
            is_empty_element_delegate d;
            var p = self->_is_empty_element;
            if (p == _pf) { d = _df; }
            else
            {
                d = (is_empty_element_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(is_empty_element_delegate));
                if (_pf == IntPtr.Zero) { _df = d; _pf = p; }
            }
            return d(self);
        }
        
        // HasValue
        private static IntPtr _p10;
        private static has_value_delegate _d10;
        
        public static int has_value(cef_xml_reader_t* self)
        {
            has_value_delegate d;
            var p = self->_has_value;
            if (p == _p10) { d = _d10; }
            else
            {
                d = (has_value_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(has_value_delegate));
                if (_p10 == IntPtr.Zero) { _d10 = d; _p10 = p; }
            }
            return d(self);
        }
        
        // GetValue
        private static IntPtr _p11;
        private static get_value_delegate _d11;
        
        public static cef_string_userfree* get_value(cef_xml_reader_t* self)
        {
            get_value_delegate d;
            var p = self->_get_value;
            if (p == _p11) { d = _d11; }
            else
            {
                d = (get_value_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_value_delegate));
                if (_p11 == IntPtr.Zero) { _d11 = d; _p11 = p; }
            }
            return d(self);
        }
        
        // HasAttributes
        private static IntPtr _p12;
        private static has_attributes_delegate _d12;
        
        public static int has_attributes(cef_xml_reader_t* self)
        {
            has_attributes_delegate d;
            var p = self->_has_attributes;
            if (p == _p12) { d = _d12; }
            else
            {
                d = (has_attributes_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(has_attributes_delegate));
                if (_p12 == IntPtr.Zero) { _d12 = d; _p12 = p; }
            }
            return d(self);
        }
        
        // GetAttributeCount
        private static IntPtr _p13;
        private static get_attribute_count_delegate _d13;
        
        public static UIntPtr get_attribute_count(cef_xml_reader_t* self)
        {
            get_attribute_count_delegate d;
            var p = self->_get_attribute_count;
            if (p == _p13) { d = _d13; }
            else
            {
                d = (get_attribute_count_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_attribute_count_delegate));
                if (_p13 == IntPtr.Zero) { _d13 = d; _p13 = p; }
            }
            return d(self);
        }
        
        // GetAttribute
        private static IntPtr _p14;
        private static get_attribute_byindex_delegate _d14;
        
        public static cef_string_userfree* get_attribute_byindex(cef_xml_reader_t* self, int index)
        {
            get_attribute_byindex_delegate d;
            var p = self->_get_attribute_byindex;
            if (p == _p14) { d = _d14; }
            else
            {
                d = (get_attribute_byindex_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_attribute_byindex_delegate));
                if (_p14 == IntPtr.Zero) { _d14 = d; _p14 = p; }
            }
            return d(self, index);
        }
        
        // GetAttribute
        private static IntPtr _p15;
        private static get_attribute_byqname_delegate _d15;
        
        public static cef_string_userfree* get_attribute_byqname(cef_xml_reader_t* self, cef_string_t* qualifiedName)
        {
            get_attribute_byqname_delegate d;
            var p = self->_get_attribute_byqname;
            if (p == _p15) { d = _d15; }
            else
            {
                d = (get_attribute_byqname_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_attribute_byqname_delegate));
                if (_p15 == IntPtr.Zero) { _d15 = d; _p15 = p; }
            }
            return d(self, qualifiedName);
        }
        
        // GetAttribute
        private static IntPtr _p16;
        private static get_attribute_bylname_delegate _d16;
        
        public static cef_string_userfree* get_attribute_bylname(cef_xml_reader_t* self, cef_string_t* localName, cef_string_t* namespaceURI)
        {
            get_attribute_bylname_delegate d;
            var p = self->_get_attribute_bylname;
            if (p == _p16) { d = _d16; }
            else
            {
                d = (get_attribute_bylname_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_attribute_bylname_delegate));
                if (_p16 == IntPtr.Zero) { _d16 = d; _p16 = p; }
            }
            return d(self, localName, namespaceURI);
        }
        
        // GetInnerXml
        private static IntPtr _p17;
        private static get_inner_xml_delegate _d17;
        
        public static cef_string_userfree* get_inner_xml(cef_xml_reader_t* self)
        {
            get_inner_xml_delegate d;
            var p = self->_get_inner_xml;
            if (p == _p17) { d = _d17; }
            else
            {
                d = (get_inner_xml_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_inner_xml_delegate));
                if (_p17 == IntPtr.Zero) { _d17 = d; _p17 = p; }
            }
            return d(self);
        }
        
        // GetOuterXml
        private static IntPtr _p18;
        private static get_outer_xml_delegate _d18;
        
        public static cef_string_userfree* get_outer_xml(cef_xml_reader_t* self)
        {
            get_outer_xml_delegate d;
            var p = self->_get_outer_xml;
            if (p == _p18) { d = _d18; }
            else
            {
                d = (get_outer_xml_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_outer_xml_delegate));
                if (_p18 == IntPtr.Zero) { _d18 = d; _p18 = p; }
            }
            return d(self);
        }
        
        // GetLineNumber
        private static IntPtr _p19;
        private static get_line_number_delegate _d19;
        
        public static int get_line_number(cef_xml_reader_t* self)
        {
            get_line_number_delegate d;
            var p = self->_get_line_number;
            if (p == _p19) { d = _d19; }
            else
            {
                d = (get_line_number_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_line_number_delegate));
                if (_p19 == IntPtr.Zero) { _d19 = d; _p19 = p; }
            }
            return d(self);
        }
        
        // MoveToAttribute
        private static IntPtr _p1a;
        private static move_to_attribute_byindex_delegate _d1a;
        
        public static int move_to_attribute_byindex(cef_xml_reader_t* self, int index)
        {
            move_to_attribute_byindex_delegate d;
            var p = self->_move_to_attribute_byindex;
            if (p == _p1a) { d = _d1a; }
            else
            {
                d = (move_to_attribute_byindex_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(move_to_attribute_byindex_delegate));
                if (_p1a == IntPtr.Zero) { _d1a = d; _p1a = p; }
            }
            return d(self, index);
        }
        
        // MoveToAttribute
        private static IntPtr _p1b;
        private static move_to_attribute_byqname_delegate _d1b;
        
        public static int move_to_attribute_byqname(cef_xml_reader_t* self, cef_string_t* qualifiedName)
        {
            move_to_attribute_byqname_delegate d;
            var p = self->_move_to_attribute_byqname;
            if (p == _p1b) { d = _d1b; }
            else
            {
                d = (move_to_attribute_byqname_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(move_to_attribute_byqname_delegate));
                if (_p1b == IntPtr.Zero) { _d1b = d; _p1b = p; }
            }
            return d(self, qualifiedName);
        }
        
        // MoveToAttribute
        private static IntPtr _p1c;
        private static move_to_attribute_bylname_delegate _d1c;
        
        public static int move_to_attribute_bylname(cef_xml_reader_t* self, cef_string_t* localName, cef_string_t* namespaceURI)
        {
            move_to_attribute_bylname_delegate d;
            var p = self->_move_to_attribute_bylname;
            if (p == _p1c) { d = _d1c; }
            else
            {
                d = (move_to_attribute_bylname_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(move_to_attribute_bylname_delegate));
                if (_p1c == IntPtr.Zero) { _d1c = d; _p1c = p; }
            }
            return d(self, localName, namespaceURI);
        }
        
        // MoveToFirstAttribute
        private static IntPtr _p1d;
        private static move_to_first_attribute_delegate _d1d;
        
        public static int move_to_first_attribute(cef_xml_reader_t* self)
        {
            move_to_first_attribute_delegate d;
            var p = self->_move_to_first_attribute;
            if (p == _p1d) { d = _d1d; }
            else
            {
                d = (move_to_first_attribute_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(move_to_first_attribute_delegate));
                if (_p1d == IntPtr.Zero) { _d1d = d; _p1d = p; }
            }
            return d(self);
        }
        
        // MoveToNextAttribute
        private static IntPtr _p1e;
        private static move_to_next_attribute_delegate _d1e;
        
        public static int move_to_next_attribute(cef_xml_reader_t* self)
        {
            move_to_next_attribute_delegate d;
            var p = self->_move_to_next_attribute;
            if (p == _p1e) { d = _d1e; }
            else
            {
                d = (move_to_next_attribute_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(move_to_next_attribute_delegate));
                if (_p1e == IntPtr.Zero) { _d1e = d; _p1e = p; }
            }
            return d(self);
        }
        
        // MoveToCarryingElement
        private static IntPtr _p1f;
        private static move_to_carrying_element_delegate _d1f;
        
        public static int move_to_carrying_element(cef_xml_reader_t* self)
        {
            move_to_carrying_element_delegate d;
            var p = self->_move_to_carrying_element;
            if (p == _p1f) { d = _d1f; }
            else
            {
                d = (move_to_carrying_element_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(move_to_carrying_element_delegate));
                if (_p1f == IntPtr.Zero) { _d1f = d; _p1f = p; }
            }
            return d(self);
        }
        
    }
}
