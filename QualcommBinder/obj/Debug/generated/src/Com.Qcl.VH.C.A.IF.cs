using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.C.A {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.c.a']/class[@name='if']"
	[global::Android.Runtime.Register ("com/qcl/vh/c/a/if", DoNotGenerateAcw=true)]
	public sealed partial class If : global::Com.Qcl.VH.C.A.Ć {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qcl/vh/c/a/if", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (If); }
		}

		internal If (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Lcom_qcl_vh_service_NetworkService_Lcom_qcl_vh_a_c_鷭_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.c.a']/class[@name='if']/constructor[@name='if' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.qcl.vh.service.NetworkService'] and parameter[3][@type='com.qcl.vh.a.c.鷭'] and parameter[4][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/qcl/vh/service/NetworkService;Lcom/qcl/vh/a/c/鷭;I)V", "")]
		public unsafe If (global::Android.Content.Context p0, global::Com.Qcl.VH.Service.NetworkService p1, global::Com.Qcl.VH.A.C.鷭 p2, int p3)
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
				if (GetType () != typeof (If)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Lcom/qcl/vh/service/NetworkService;Lcom/qcl/vh/a/c/鷭;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Lcom/qcl/vh/service/NetworkService;Lcom/qcl/vh/a/c/鷭;I)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Lcom_qcl_vh_service_NetworkService_Lcom_qcl_vh_a_c_鷭_I == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Lcom_qcl_vh_service_NetworkService_Lcom_qcl_vh_a_c_鷭_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lcom/qcl/vh/service/NetworkService;Lcom/qcl/vh/a/c/鷭;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Lcom_qcl_vh_service_NetworkService_Lcom_qcl_vh_a_c_鷭_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Lcom_qcl_vh_service_NetworkService_Lcom_qcl_vh_a_c_鷭_I, __args);
			} finally {
			}
		}

		static IntPtr id_櫯;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.c.a']/class[@name='if']/method[@name='櫯' and count(parameter)=0]"
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

		static IntPtr id_鷭;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.c.a']/class[@name='if']/method[@name='鷭' and count(parameter)=0]"
		[Register ("鷭", "()I", "")]
		public unsafe int 鷭 ()
		{
			if (id_鷭 == IntPtr.Zero)
				id_鷭 = JNIEnv.GetMethodID (class_ref, "鷭", "()I");
			try {
				return JNIEnv.CallIntMethod  (Handle, id_鷭);
			} finally {
			}
		}

		static IntPtr id_鷭_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.c.a']/class[@name='if']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.c.a']/class[@name='if']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='boolean']]"
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
