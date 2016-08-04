using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.A.C {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.a.c']/class[@name='con']"
	[global::Android.Runtime.Register ("com/qcl/vh/a/c/con", DoNotGenerateAcw=true)]
	public sealed partial class Con : global::Java.Lang.Enum {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qcl/vh/a/c/con", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Con); }
		}

		internal Con (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.c']/class[@name='con']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/qcl/vh/a/c/con;", "")]
		public static unsafe global::Com.Qcl.VH.A.C.Con ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/qcl/vh/a/c/con;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Qcl.VH.A.C.Con __ret = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.A.C.Con> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.c']/class[@name='con']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/qcl/vh/a/c/con;", "")]
		public static unsafe global::Com.Qcl.VH.A.C.Con[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/qcl/vh/a/c/con;");
			try {
				return (global::Com.Qcl.VH.A.C.Con[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Qcl.VH.A.C.Con));
			} finally {
			}
		}

		static IntPtr id_鷭;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.c']/class[@name='con']/method[@name='鷭' and count(parameter)=0]"
		[Register ("鷭", "()I", "")]
		public unsafe int 鷭 ()
		{
			if (id_鷭 == IntPtr.Zero)
				id_鷭 = JNIEnv.GetMethodID (class_ref, "鷭", "()I");
			try {
				return JNIEnv.CallIntMethod  (Handle, id_鷭);
			} finally {
			}
		}

		static IntPtr id_鷭_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.c']/class[@name='con']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("鷭", "(I)Lcom/qcl/vh/a/c/con;", "")]
		public static unsafe global::Com.Qcl.VH.A.C.Con 鷭 (int p0)
		{
			if (id_鷭_I == IntPtr.Zero)
				id_鷭_I = JNIEnv.GetStaticMethodID (class_ref, "鷭", "(I)Lcom/qcl/vh/a/c/con;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.A.C.Con> (JNIEnv.CallStaticObjectMethod  (class_ref, id_鷭_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}