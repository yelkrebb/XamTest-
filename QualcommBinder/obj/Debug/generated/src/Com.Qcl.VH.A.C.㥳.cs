using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.A.C {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.a.c']/class[@name='㥳']"
	[global::Android.Runtime.Register ("com/qcl/vh/a/c/㥳", DoNotGenerateAcw=true)]
	public partial class 㥳 : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qcl/vh/a/c/㥳", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (㥳); }
		}

		protected 㥳 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.a.c']/class[@name='㥳']/constructor[@name='㥳' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe 㥳 ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (㥳)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static IntPtr id_櫯;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.c']/class[@name='㥳']/method[@name='櫯' and count(parameter)=0]"
		[Register ("櫯", "()Ljava/lang/String;", "")]
		public unsafe string 櫯 ()
		{
			if (id_櫯 == IntPtr.Zero)
				id_櫯 = JNIEnv.GetMethodID (class_ref, "櫯", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_櫯), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_鷭;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.c']/class[@name='㥳']/method[@name='鷭' and count(parameter)=0]"
		[Register ("鷭", "()Lcom/qcl/vh/a/c/Ė;", "")]
		public unsafe global::Com.Qcl.VH.A.C.Ė 鷭 ()
		{
			if (id_鷭 == IntPtr.Zero)
				id_鷭 = JNIEnv.GetMethodID (class_ref, "鷭", "()Lcom/qcl/vh/a/c/Ė;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.A.C.Ė> (JNIEnv.CallObjectMethod  (Handle, id_鷭), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_鷭_Lcom_qcl_vh_a_c_Ė_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.c']/class[@name='㥳']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='com.qcl.vh.a.c.Ė']]"
		[Register ("鷭", "(Lcom/qcl/vh/a/c/Ė;)V", "")]
		public unsafe void 鷭 (global::Com.Qcl.VH.A.C.Ė p0)
		{
			if (id_鷭_Lcom_qcl_vh_a_c_Ė_ == IntPtr.Zero)
				id_鷭_Lcom_qcl_vh_a_c_Ė_ = JNIEnv.GetMethodID (class_ref, "鷭", "(Lcom/qcl/vh/a/c/Ė;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_鷭_Lcom_qcl_vh_a_c_Ė_, __args);
			} finally {
			}
		}

		static IntPtr id_鷭_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.c']/class[@name='㥳']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("鷭", "(Ljava/lang/String;)V", "")]
		public unsafe void 鷭 (string p0)
		{
			if (id_鷭_Ljava_lang_String_ == IntPtr.Zero)
				id_鷭_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "鷭", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod  (Handle, id_鷭_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
