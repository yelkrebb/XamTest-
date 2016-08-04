using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.A.C {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.a.c']/class[@name='廅']"
	[global::Android.Runtime.Register ("com/qcl/vh/a/c/廅", DoNotGenerateAcw=true)]
	public partial class 廅 : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qcl/vh/a/c/廅", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (廅); }
		}

		protected 廅 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.a.c']/class[@name='廅']/constructor[@name='廅' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe 廅 ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (廅)) {
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.c']/class[@name='廅']/method[@name='櫯' and count(parameter)=0]"
		[Register ("櫯", "()Ljava/util/List;", "")]
		public unsafe global::System.Collections.Generic.IList<global::Com.Qcl.VH.A.C.CoN> 櫯 ()
		{
			if (id_櫯 == IntPtr.Zero)
				id_櫯 = JNIEnv.GetMethodID (class_ref, "櫯", "()Ljava/util/List;");
			try {
				return global::Android.Runtime.JavaList<global::Com.Qcl.VH.A.C.CoN>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_櫯), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_鷭;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.c']/class[@name='廅']/method[@name='鷭' and count(parameter)=0]"
		[Register ("鷭", "()Ljava/lang/Long;", "")]
		public unsafe global::Java.Lang.Long 鷭 ()
		{
			if (id_鷭 == IntPtr.Zero)
				id_鷭 = JNIEnv.GetMethodID (class_ref, "鷭", "()Ljava/lang/Long;");
			try {
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallObjectMethod  (Handle, id_鷭), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_鷭_Lcom_qcl_vh_a_c_CoN_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.c']/class[@name='廅']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='com.qcl.vh.a.c.CoN']]"
		[Register ("鷭", "(Lcom/qcl/vh/a/c/CoN;)V", "")]
		public unsafe void 鷭 (global::Com.Qcl.VH.A.C.CoN p0)
		{
			if (id_鷭_Lcom_qcl_vh_a_c_CoN_ == IntPtr.Zero)
				id_鷭_Lcom_qcl_vh_a_c_CoN_ = JNIEnv.GetMethodID (class_ref, "鷭", "(Lcom/qcl/vh/a/c/CoN;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_鷭_Lcom_qcl_vh_a_c_CoN_, __args);
			} finally {
			}
		}

		static IntPtr id_鷭_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.c']/class[@name='廅']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
		[Register ("鷭", "(Ljava/lang/Long;)V", "")]
		public unsafe void 鷭 (global::Java.Lang.Long p0)
		{
			if (id_鷭_Ljava_lang_Long_ == IntPtr.Zero)
				id_鷭_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "鷭", "(Ljava/lang/Long;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_鷭_Ljava_lang_Long_, __args);
			} finally {
			}
		}

		static IntPtr id_鷭_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.c']/class[@name='廅']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.qcl.vh.a.c.CoN&gt;']]"
		[Register ("鷭", "(Ljava/util/List;)V", "")]
		public unsafe void 鷭 (global::System.Collections.Generic.IList<global::Com.Qcl.VH.A.C.CoN> p0)
		{
			if (id_鷭_Ljava_util_List_ == IntPtr.Zero)
				id_鷭_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "鷭", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Qcl.VH.A.C.CoN>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod  (Handle, id_鷭_Ljava_util_List_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
