using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.MD.Resmed {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.md.resmed']/class[@name='if']"
	[global::Android.Runtime.Register ("com/qcl/vh/md/resmed/if", DoNotGenerateAcw=true)]
	public partial class If : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qcl/vh/md/resmed/if", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (If); }
		}

		protected If (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.md.resmed']/class[@name='if']/constructor[@name='if' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe If ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (If)) {
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

		static IntPtr id_鷭_Ljava_lang_String_Lcom_qcl_vh_md_resmed_櫯_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.resmed']/class[@name='if']/method[@name='鷭' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.qcl.vh.md.resmed.櫯']]"
		[Register ("鷭", "(Ljava/lang/String;Lcom/qcl/vh/md/resmed/櫯;)Ljava/util/List;", "")]
		public unsafe global::System.Collections.Generic.IList<global::Java.Lang.Integer> 鷭 (string p0, global::Com.Qcl.VH.MD.Resmed.櫯 p1)
		{
			if (id_鷭_Ljava_lang_String_Lcom_qcl_vh_md_resmed_櫯_ == IntPtr.Zero)
				id_鷭_Ljava_lang_String_Lcom_qcl_vh_md_resmed_櫯_ = JNIEnv.GetMethodID (class_ref, "鷭", "(Ljava/lang/String;Lcom/qcl/vh/md/resmed/櫯;)Ljava/util/List;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				global::System.Collections.Generic.IList<global::Java.Lang.Integer> __ret = global::Android.Runtime.JavaList<global::Java.Lang.Integer>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_鷭_Ljava_lang_String_Lcom_qcl_vh_md_resmed_櫯_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
