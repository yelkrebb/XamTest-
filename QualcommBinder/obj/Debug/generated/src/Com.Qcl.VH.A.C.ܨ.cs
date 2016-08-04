using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.A.C {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.a.c']/class[@name='ܨ']"
	[global::Android.Runtime.Register ("com/qcl/vh/a/c/ܨ", DoNotGenerateAcw=true)]
	public partial class ܨ : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qcl/vh/a/c/ܨ", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ܨ); }
		}

		protected ܨ (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.a.c']/class[@name='ܨ']/constructor[@name='ܨ' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ܨ ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ܨ)) {
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

		static IntPtr id_鷭;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.c']/class[@name='ܨ']/method[@name='鷭' and count(parameter)=0]"
		[Register ("鷭", "()Lcom/qcl/vh/a/c/ģ;", "")]
		public unsafe global::Com.Qcl.VH.A.C.Ģ 鷭 ()
		{
			if (id_鷭 == IntPtr.Zero)
				id_鷭 = JNIEnv.GetMethodID (class_ref, "鷭", "()Lcom/qcl/vh/a/c/ģ;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.A.C.Ģ> (JNIEnv.CallObjectMethod  (Handle, id_鷭), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_鷭_Lcom_qcl_vh_a_c_ģ_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.c']/class[@name='ܨ']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='com.qcl.vh.a.c.ģ']]"
		[Register ("鷭", "(Lcom/qcl/vh/a/c/ģ;)V", "")]
		public unsafe void 鷭 (global::Com.Qcl.VH.A.C.Ģ p0)
		{
			if (id_鷭_Lcom_qcl_vh_a_c_ģ_ == IntPtr.Zero)
				id_鷭_Lcom_qcl_vh_a_c_ģ_ = JNIEnv.GetMethodID (class_ref, "鷭", "(Lcom/qcl/vh/a/c/ģ;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_鷭_Lcom_qcl_vh_a_c_ģ_, __args);
			} finally {
			}
		}

	}
}
