using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.B {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.b']/class[@name='if']"
	[global::Android.Runtime.Register ("com/qcl/vh/b/if", DoNotGenerateAcw=true)]
	public partial class If : global::Android.OS.AsyncTask {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qcl/vh/b/if", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (If); }
		}

		protected If (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_qcl_vh_service_DiagnosticService_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.b']/class[@name='if']/constructor[@name='if' and count(parameter)=1 and parameter[1][@type='com.qcl.vh.service.DiagnosticService']]"
		[Register (".ctor", "(Lcom/qcl/vh/service/DiagnosticService;)V", "")]
		public unsafe If (global::Com.Qcl.VH.Service.DiagnosticService p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (If)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/qcl/vh/service/DiagnosticService;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/qcl/vh/service/DiagnosticService;)V", __args);
					return;
				}

				if (id_ctor_Lcom_qcl_vh_service_DiagnosticService_ == IntPtr.Zero)
					id_ctor_Lcom_qcl_vh_service_DiagnosticService_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/qcl/vh/service/DiagnosticService;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_qcl_vh_service_DiagnosticService_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_qcl_vh_service_DiagnosticService_, __args);
			} finally {
			}
		}

	}
}
