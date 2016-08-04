using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.C.A {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.c.a']/class[@name='鷭']"
	[global::Android.Runtime.Register ("com/qcl/vh/c/a/鷭", DoNotGenerateAcw=true)]
	public sealed partial class 鷭 : global::Com.Qcl.VH.C.A.Ć {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qcl/vh/c/a/鷭", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (鷭); }
		}

		internal 鷭 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_qcl_vh_a_c_CON_Landroid_content_Context_Lcom_qcl_vh_service_NetworkService_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.c.a']/class[@name='鷭']/constructor[@name='鷭' and count(parameter)=3 and parameter[1][@type='com.qcl.vh.a.c.CON'] and parameter[2][@type='android.content.Context'] and parameter[3][@type='com.qcl.vh.service.NetworkService']]"
		[Register (".ctor", "(Lcom/qcl/vh/a/c/CON;Landroid/content/Context;Lcom/qcl/vh/service/NetworkService;)V", "")]
		public unsafe 鷭 (global::Com.Qcl.VH.A.C.CON p0, global::Android.Content.Context p1, global::Com.Qcl.VH.Service.NetworkService p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (鷭)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/qcl/vh/a/c/CON;Landroid/content/Context;Lcom/qcl/vh/service/NetworkService;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/qcl/vh/a/c/CON;Landroid/content/Context;Lcom/qcl/vh/service/NetworkService;)V", __args);
					return;
				}

				if (id_ctor_Lcom_qcl_vh_a_c_CON_Landroid_content_Context_Lcom_qcl_vh_service_NetworkService_ == IntPtr.Zero)
					id_ctor_Lcom_qcl_vh_a_c_CON_Landroid_content_Context_Lcom_qcl_vh_service_NetworkService_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/qcl/vh/a/c/CON;Landroid/content/Context;Lcom/qcl/vh/service/NetworkService;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_qcl_vh_a_c_CON_Landroid_content_Context_Lcom_qcl_vh_service_NetworkService_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_qcl_vh_a_c_CON_Landroid_content_Context_Lcom_qcl_vh_service_NetworkService_, __args);
			} finally {
			}
		}

		static IntPtr id_鷭_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.c.a']/class[@name='鷭']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("鷭", "(Landroid/content/Context;)Lcom/qcl/vh/a/c/CON;", "")]
		public override sealed unsafe global::Com.Qcl.VH.A.C.CON Invoke鷭 (global::Android.Content.Context p0)
		{
			if (id_鷭_Landroid_content_Context_ == IntPtr.Zero)
				id_鷭_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "鷭", "(Landroid/content/Context;)Lcom/qcl/vh/a/c/CON;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Qcl.VH.A.C.CON __ret = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.A.C.CON> (JNIEnv.CallObjectMethod  (Handle, id_鷭_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
