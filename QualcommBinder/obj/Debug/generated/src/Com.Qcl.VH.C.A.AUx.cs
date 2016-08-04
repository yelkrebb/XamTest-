using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.C.A {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.c.a']/class[@name='aux']"
	[global::Android.Runtime.Register ("com/qcl/vh/c/a/aux", DoNotGenerateAcw=true)]
	public sealed partial class Aux : global::Com.Qcl.VH.C.A.Ć {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qcl/vh/c/a/aux", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Aux); }
		}

		internal Aux (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Lcom_qcl_vh_service_NetworkService_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.c.a']/class[@name='aux']/constructor[@name='aux' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.qcl.vh.service.NetworkService']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/qcl/vh/service/NetworkService;)V", "")]
		public unsafe Aux (global::Android.Content.Context p0, global::Com.Qcl.VH.Service.NetworkService p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (Aux)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Lcom/qcl/vh/service/NetworkService;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Lcom/qcl/vh/service/NetworkService;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Lcom_qcl_vh_service_NetworkService_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Lcom_qcl_vh_service_NetworkService_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lcom/qcl/vh/service/NetworkService;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Lcom_qcl_vh_service_NetworkService_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Lcom_qcl_vh_service_NetworkService_, __args);
			} finally {
			}
		}

		static IntPtr id_鷭_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.c.a']/class[@name='aux']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("鷭", "(Landroid/content/Context;)Lcom/qcl/vh/a/c/CON;", "")]
		public override sealed unsafe global::Com.Qcl.VH.A.C.CON 鷭 (global::Android.Content.Context p0)
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
