using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.A.D {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.a.d']/class[@name='鷭']"
	[global::Android.Runtime.Register ("com/qcl/vh/a/d/鷭", DoNotGenerateAcw=true)]
	public abstract partial class 鷭 : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qcl/vh/a/d/鷭", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (鷭); }
		}

		protected 鷭 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.a.d']/class[@name='鷭']/constructor[@name='鷭' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe 鷭 ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (鷭)) {
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

		static IntPtr id_ˮ͈;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.d']/class[@name='鷭']/method[@name='ˮ͈' and count(parameter)=0]"
		[Register ("ˮ͈", "()Lcom/qcl/vh/a/d/aux;", "")]
		public unsafe global::Com.Qcl.VH.A.D.Aux ˮ͈ ()
		{
			if (id_ˮ͈ == IntPtr.Zero)
				id_ˮ͈ = JNIEnv.GetMethodID (class_ref, "ˮ͈", "()Lcom/qcl/vh/a/d/aux;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.A.D.Aux> (JNIEnv.CallObjectMethod  (Handle, id_ˮ͈), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_鷭_Lcom_qcl_vh_a_d_aux_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.d']/class[@name='鷭']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='com.qcl.vh.a.d.aux']]"
		[Register ("鷭", "(Lcom/qcl/vh/a/d/aux;)V", "")]
		public unsafe void Invoke鷭 (global::Com.Qcl.VH.A.D.Aux p0)
		{
			if (id_鷭_Lcom_qcl_vh_a_d_aux_ == IntPtr.Zero)
				id_鷭_Lcom_qcl_vh_a_d_aux_ = JNIEnv.GetMethodID (class_ref, "鷭", "(Lcom/qcl/vh/a/d/aux;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_鷭_Lcom_qcl_vh_a_d_aux_, __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/qcl/vh/a/d/鷭", DoNotGenerateAcw=true)]
	internal partial class 鷭Invoker : 鷭 {

		public 鷭Invoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (鷭Invoker); }
		}

	}

}
