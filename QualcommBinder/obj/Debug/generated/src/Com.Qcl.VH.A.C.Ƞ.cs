using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.A.C {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.a.c']/class[@name='Ƞ']"
	[global::Android.Runtime.Register ("com/qcl/vh/a/c/Ƞ", DoNotGenerateAcw=true)]
	public partial class Ƞ : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qcl/vh/a/c/Ƞ", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Ƞ); }
		}

		protected Ƞ (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.a.c']/class[@name='Ƞ']/constructor[@name='Ƞ' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Ƞ ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Ƞ)) {
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

		static IntPtr id_櫯;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.c']/class[@name='Ƞ']/method[@name='櫯' and count(parameter)=0]"
		[Register ("櫯", "()Ljava/lang/Boolean;", "")]
		public unsafe global::Java.Lang.Boolean 櫯 ()
		{
			if (id_櫯 == IntPtr.Zero)
				id_櫯 = JNIEnv.GetMethodID (class_ref, "櫯", "()Ljava/lang/Boolean;");
			try {
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallObjectMethod  (Handle, id_櫯), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_鷭;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.c']/class[@name='Ƞ']/method[@name='鷭' and count(parameter)=0]"
		[Register ("鷭", "()Ljava/lang/Long;", "")]
		public unsafe global::Java.Lang.Long 鷭 ()
		{
			if (id_鷭 == IntPtr.Zero)
				id_鷭 = JNIEnv.GetMethodID (class_ref, "鷭", "()Ljava/lang/Long;");
			try {
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallObjectMethod  (Handle, id_鷭), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_鷭_Ljava_lang_Boolean_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.c']/class[@name='Ƞ']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
		[Register ("鷭", "(Ljava/lang/Boolean;)V", "")]
		public unsafe void 鷭 (global::Java.Lang.Boolean p0)
		{
			if (id_鷭_Ljava_lang_Boolean_ == IntPtr.Zero)
				id_鷭_Ljava_lang_Boolean_ = JNIEnv.GetMethodID (class_ref, "鷭", "(Ljava/lang/Boolean;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_鷭_Ljava_lang_Boolean_, __args);
			} finally {
			}
		}

		static IntPtr id_鷭_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.c']/class[@name='Ƞ']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
		[Register ("鷭", "(Ljava/lang/Long;)V", "")]
		public unsafe void 鷭 (global::Java.Lang.Long p0)
		{
			if (id_鷭_Ljava_lang_Long_ == IntPtr.Zero)
				id_鷭_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "鷭", "(Ljava/lang/Long;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_鷭_Ljava_lang_Long_, __args);
			} finally {
			}
		}

	}
}
