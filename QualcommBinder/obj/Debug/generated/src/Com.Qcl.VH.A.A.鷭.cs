using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.A.A {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.a.a']/class[@name='鷭']"
	[global::Android.Runtime.Register ("com/qcl/vh/a/a/鷭", DoNotGenerateAcw=true)]
	public sealed partial class 鷭 : global::Java.Lang.Exception {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qcl/vh/a/a/鷭", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (鷭); }
		}

		internal 鷭 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_qcl_vh_a_c_纫_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.a.a']/class[@name='鷭']/constructor[@name='鷭' and count(parameter)=1 and parameter[1][@type='com.qcl.vh.a.c.纫']]"
		[Register (".ctor", "(Lcom/qcl/vh/a/c/纫;)V", "")]
		public unsafe 鷭 (global::Com.Qcl.VH.A.C.纫 p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (鷭)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/qcl/vh/a/c/纫;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/qcl/vh/a/c/纫;)V", __args);
					return;
				}

				if (id_ctor_Lcom_qcl_vh_a_c_纫_ == IntPtr.Zero)
					id_ctor_Lcom_qcl_vh_a_c_纫_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/qcl/vh/a/c/纫;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_qcl_vh_a_c_纫_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_qcl_vh_a_c_纫_, __args);
			} finally {
			}
		}

		static IntPtr id_toString;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.a']/class[@name='鷭']/method[@name='toString' and count(parameter)=0]"
		[Register ("toString", "()Ljava/lang/String;", "")]
		public override sealed unsafe string ToString ()
		{
			if (id_toString == IntPtr.Zero)
				id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_toString), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
