using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.C.A {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.c.a']/class[@name='櫯']"
	[global::Android.Runtime.Register ("com/qcl/vh/c/a/櫯", DoNotGenerateAcw=true)]
	public sealed partial class 櫯 : global::Com.Qcl.VH.C.A.Ć {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qcl/vh/c/a/櫯", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (櫯); }
		}

		internal 櫯 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Lcom_qcl_vh_service_NetworkService_IZLjava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.c.a']/class[@name='櫯']/constructor[@name='櫯' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.qcl.vh.service.NetworkService'] and parameter[3][@type='int'] and parameter[4][@type='boolean'] and parameter[5][@type='java.lang.String']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/qcl/vh/service/NetworkService;IZLjava/lang/String;)V", "")]
		public unsafe 櫯 (global::Android.Content.Context p0, global::Com.Qcl.VH.Service.NetworkService p1, int p2, bool p3, string p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (native_p4);
				if (GetType () != typeof (櫯)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Lcom/qcl/vh/service/NetworkService;IZLjava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Lcom/qcl/vh/service/NetworkService;IZLjava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Lcom_qcl_vh_service_NetworkService_IZLjava_lang_String_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Lcom_qcl_vh_service_NetworkService_IZLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lcom/qcl/vh/service/NetworkService;IZLjava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Lcom_qcl_vh_service_NetworkService_IZLjava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Lcom_qcl_vh_service_NetworkService_IZLjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static IntPtr id_鷭_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.c.a']/class[@name='櫯']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
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
