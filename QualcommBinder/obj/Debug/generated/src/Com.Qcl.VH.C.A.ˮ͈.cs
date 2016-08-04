using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.C.A {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.c.a']/class[@name='ˮ͈']"
	[global::Android.Runtime.Register ("com/qcl/vh/c/a/ˮ͈", DoNotGenerateAcw=true)]
	public sealed partial class ˮ͈ : global::Com.Qcl.VH.C.A.Ć {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qcl/vh/c/a/ˮ͈", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ˮ͈); }
		}

		internal ˮ͈ (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Lcom_qcl_vh_a_c_ˮ͍_ILandroid_net_Uri_Lcom_qcl_vh_service_NetworkService_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.c.a']/class[@name='ˮ͈']/constructor[@name='ˮ͈' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.qcl.vh.a.c.ˮ͍'] and parameter[3][@type='int'] and parameter[4][@type='android.net.Uri'] and parameter[5][@type='com.qcl.vh.service.NetworkService']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/qcl/vh/a/c/ˮ͍;ILandroid/net/Uri;Lcom/qcl/vh/service/NetworkService;)V", "")]
		public unsafe ˮ͈ (global::Android.Content.Context p0, global::Com.Qcl.VH.A.C.ˮ͍ p1, int p2, global::Android.Net.Uri p3, global::Com.Qcl.VH.Service.NetworkService p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				if (GetType () != typeof (ˮ͈)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Lcom/qcl/vh/a/c/ˮ͍;ILandroid/net/Uri;Lcom/qcl/vh/service/NetworkService;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Lcom/qcl/vh/a/c/ˮ͍;ILandroid/net/Uri;Lcom/qcl/vh/service/NetworkService;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Lcom_qcl_vh_a_c_ˮ͍_ILandroid_net_Uri_Lcom_qcl_vh_service_NetworkService_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Lcom_qcl_vh_a_c_ˮ͍_ILandroid_net_Uri_Lcom_qcl_vh_service_NetworkService_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lcom/qcl/vh/a/c/ˮ͍;ILandroid/net/Uri;Lcom/qcl/vh/service/NetworkService;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Lcom_qcl_vh_a_c_ˮ͍_ILandroid_net_Uri_Lcom_qcl_vh_service_NetworkService_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Lcom_qcl_vh_a_c_ˮ͍_ILandroid_net_Uri_Lcom_qcl_vh_service_NetworkService_, __args);
			} finally {
			}
		}

		static IntPtr id_a_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.c.a']/class[@name='ˮ͈']/method[@name='a_' and count(parameter)=0]"
		[Register ("a_", "()V", "")]
		protected override sealed unsafe void A_ ()
		{
			if (id_a_ == IntPtr.Zero)
				id_a_ = JNIEnv.GetMethodID (class_ref, "a_", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_a_);
			} finally {
			}
		}

		static IntPtr id_鷭_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.c.a']/class[@name='ˮ͈']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
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
