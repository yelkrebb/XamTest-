using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.C.A {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.c.a']/class[@name='ą']"
	[global::Android.Runtime.Register ("com/qcl/vh/c/a/ą", DoNotGenerateAcw=true)]
	public sealed partial class Ą : global::Com.Qcl.VH.C.A.Ć {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qcl/vh/c/a/ą", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Ą); }
		}

		internal Ą (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_qcl_vh_c_a_Aux_Landroid_content_Context_Lcom_qcl_vh_service_NetworkService_Lcom_qcl_vh_a_c_COn_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.c.a']/class[@name='ą']/constructor[@name='ą' and count(parameter)=4 and parameter[1][@type='com.qcl.vh.c.a.Aux'] and parameter[2][@type='android.content.Context'] and parameter[3][@type='com.qcl.vh.service.NetworkService'] and parameter[4][@type='com.qcl.vh.a.c.COn']]"
		[Register (".ctor", "(Lcom/qcl/vh/c/a/Aux;Landroid/content/Context;Lcom/qcl/vh/service/NetworkService;Lcom/qcl/vh/a/c/COn;)V", "")]
		public unsafe Ą (global::Com.Qcl.VH.C.A.Aux p0, global::Android.Content.Context p1, global::Com.Qcl.VH.Service.NetworkService p2, global::Com.Qcl.VH.A.C.COn p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				if (GetType () != typeof (Ą)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/qcl/vh/c/a/Aux;Landroid/content/Context;Lcom/qcl/vh/service/NetworkService;Lcom/qcl/vh/a/c/COn;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/qcl/vh/c/a/Aux;Landroid/content/Context;Lcom/qcl/vh/service/NetworkService;Lcom/qcl/vh/a/c/COn;)V", __args);
					return;
				}

				if (id_ctor_Lcom_qcl_vh_c_a_Aux_Landroid_content_Context_Lcom_qcl_vh_service_NetworkService_Lcom_qcl_vh_a_c_COn_ == IntPtr.Zero)
					id_ctor_Lcom_qcl_vh_c_a_Aux_Landroid_content_Context_Lcom_qcl_vh_service_NetworkService_Lcom_qcl_vh_a_c_COn_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/qcl/vh/c/a/Aux;Landroid/content/Context;Lcom/qcl/vh/service/NetworkService;Lcom/qcl/vh/a/c/COn;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_qcl_vh_c_a_Aux_Landroid_content_Context_Lcom_qcl_vh_service_NetworkService_Lcom_qcl_vh_a_c_COn_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_qcl_vh_c_a_Aux_Landroid_content_Context_Lcom_qcl_vh_service_NetworkService_Lcom_qcl_vh_a_c_COn_, __args);
			} finally {
			}
		}

		static IntPtr id_櫯;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.c.a']/class[@name='ą']/method[@name='櫯' and count(parameter)=0]"
		[Register ("櫯", "()Z", "")]
		public unsafe bool 櫯 ()
		{
			if (id_櫯 == IntPtr.Zero)
				id_櫯 = JNIEnv.GetMethodID (class_ref, "櫯", "()Z");
			try {
				return JNIEnv.CallBooleanMethod  (Handle, id_櫯);
			} finally {
			}
		}

		static IntPtr id_櫯_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.c.a']/class[@name='ą']/method[@name='櫯' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("櫯", "(Landroid/content/Context;)Lcom/qcl/vh/a/c/ܕ;", "")]
		public unsafe global::Com.Qcl.VH.A.C.ܕ 櫯 (global::Android.Content.Context p0)
		{
			if (id_櫯_Landroid_content_Context_ == IntPtr.Zero)
				id_櫯_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "櫯", "(Landroid/content/Context;)Lcom/qcl/vh/a/c/ܕ;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Qcl.VH.A.C.ܕ __ret = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.A.C.ܕ> (JNIEnv.CallObjectMethod  (Handle, id_櫯_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_鷭_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.c.a']/class[@name='ą']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
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

		static IntPtr id_鷭_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.c.a']/class[@name='ą']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("鷭", "(Z)V", "")]
		public unsafe void 鷭 (bool p0)
		{
			if (id_鷭_Z == IntPtr.Zero)
				id_鷭_Z = JNIEnv.GetMethodID (class_ref, "鷭", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_鷭_Z, __args);
			} finally {
			}
		}

	}
}
