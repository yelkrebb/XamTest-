using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.A.C {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.a.c']/class[@name='ć']"
	[global::Android.Runtime.Register ("com/qcl/vh/a/c/ć", DoNotGenerateAcw=true)]
	public sealed partial class Ć : global::Java.Lang.Enum {


		static IntPtr 櫯_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.a.c']/class[@name='ć']/field[@name='櫯']"
		[Register ("櫯")]
		public static global::Com.Qcl.VH.A.C.Ć 櫯 {
			get {
				if (櫯_jfieldId == IntPtr.Zero)
					櫯_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "櫯", "Lcom/qcl/vh/a/c/ć;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, 櫯_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.A.C.Ć> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qcl/vh/a/c/ć", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Ć); }
		}

		internal Ć (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.c']/class[@name='ć']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/qcl/vh/a/c/ć;", "")]
		public static unsafe global::Com.Qcl.VH.A.C.Ć ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/qcl/vh/a/c/ć;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Qcl.VH.A.C.Ć __ret = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.A.C.Ć> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.c']/class[@name='ć']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/qcl/vh/a/c/ć;", "")]
		public static unsafe global::Com.Qcl.VH.A.C.Ć[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/qcl/vh/a/c/ć;");
			try {
				return (global::Com.Qcl.VH.A.C.Ć[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Qcl.VH.A.C.Ć));
			} finally {
			}
		}

		static IntPtr id_鷭;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.c']/class[@name='ć']/method[@name='鷭' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.c']/class[@name='ć']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("鷭", "(I)Lcom/qcl/vh/a/c/ć;", "")]
		public static unsafe global::Com.Qcl.VH.A.C.Ć 鷭 (int p0)
		{
			if (id_鷭_I == IntPtr.Zero)
				id_鷭_I = JNIEnv.GetStaticMethodID (class_ref, "鷭", "(I)Lcom/qcl/vh/a/c/ć;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.A.C.Ć> (JNIEnv.CallStaticObjectMethod  (class_ref, id_鷭_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
