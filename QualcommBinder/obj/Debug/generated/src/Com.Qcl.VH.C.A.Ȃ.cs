using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.C.A {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.c.a']/class[@name='ȃ']"
	[global::Android.Runtime.Register ("com/qcl/vh/c/a/ȃ", DoNotGenerateAcw=true)]
	public sealed partial class Ȃ : global::Com.Qcl.VH.C.A.Ć {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qcl/vh/c/a/ȃ", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Ȃ); }
		}

		internal Ȃ (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Lcom_qcl_vh_service_NetworkService_Lcom_qcl_vh_a_c_Ȋ_Ljava_util_Set_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.c.a']/class[@name='ȃ']/constructor[@name='ȃ' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.qcl.vh.service.NetworkService'] and parameter[3][@type='com.qcl.vh.a.c.Ȋ'] and parameter[4][@type='java.util.Set&lt;java.lang.String&gt;']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/qcl/vh/service/NetworkService;Lcom/qcl/vh/a/c/Ȋ;Ljava/util/Set;)V", "")]
		public unsafe Ȃ (global::Android.Content.Context p0, global::Com.Qcl.VH.Service.NetworkService p1, global::Com.Qcl.VH.A.C.Ȋ p2, global::System.Collections.Generic.ICollection<string> p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p3 = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				if (GetType () != typeof (Ȃ)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Lcom/qcl/vh/service/NetworkService;Lcom/qcl/vh/a/c/Ȋ;Ljava/util/Set;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Lcom/qcl/vh/service/NetworkService;Lcom/qcl/vh/a/c/Ȋ;Ljava/util/Set;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Lcom_qcl_vh_service_NetworkService_Lcom_qcl_vh_a_c_Ȋ_Ljava_util_Set_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Lcom_qcl_vh_service_NetworkService_Lcom_qcl_vh_a_c_Ȋ_Ljava_util_Set_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lcom/qcl/vh/service/NetworkService;Lcom/qcl/vh/a/c/Ȋ;Ljava/util/Set;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Lcom_qcl_vh_service_NetworkService_Lcom_qcl_vh_a_c_Ȋ_Ljava_util_Set_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Lcom_qcl_vh_service_NetworkService_Lcom_qcl_vh_a_c_Ȋ_Ljava_util_Set_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_a_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.c.a']/class[@name='ȃ']/method[@name='a_' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.c.a']/class[@name='ȃ']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
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

		static IntPtr id_鷭_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.c.a']/class[@name='ȃ']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("鷭", "(I)Z", "")]
		protected override sealed unsafe bool 鷭 (int p0)
		{
			if (id_鷭_I == IntPtr.Zero)
				id_鷭_I = JNIEnv.GetMethodID (class_ref, "鷭", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallBooleanMethod  (Handle, id_鷭_I, __args);
			} finally {
			}
		}

	}
}
