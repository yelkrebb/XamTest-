using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.A.C {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.a.c']/class[@name='ġ']"
	[global::Android.Runtime.Register ("com/qcl/vh/a/c/ġ", DoNotGenerateAcw=true)]
	public partial class Ġ : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qcl/vh/a/c/ġ", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Ġ); }
		}

		protected Ġ (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.a.c']/class[@name='ġ']/constructor[@name='ġ' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Ġ ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Ġ)) {
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

		static IntPtr id_鷭;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.c']/class[@name='ġ']/method[@name='鷭' and count(parameter)=0]"
		[Register ("鷭", "()Ljava/lang/Integer;", "")]
		public unsafe global::Java.Lang.Integer 鷭 ()
		{
			if (id_鷭 == IntPtr.Zero)
				id_鷭 = JNIEnv.GetMethodID (class_ref, "鷭", "()Ljava/lang/Integer;");
			try {
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod  (Handle, id_鷭), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_鷭_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.c']/class[@name='ġ']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
		[Register ("鷭", "(Ljava/lang/Integer;)V", "")]
		public unsafe void 鷭 (global::Java.Lang.Integer p0)
		{
			if (id_鷭_Ljava_lang_Integer_ == IntPtr.Zero)
				id_鷭_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "鷭", "(Ljava/lang/Integer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_鷭_Ljava_lang_Integer_, __args);
			} finally {
			}
		}

	}
}
