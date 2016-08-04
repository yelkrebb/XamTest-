using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.A.E {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.a.e']/class[@name='if']"
	[global::Android.Runtime.Register ("com/qcl/vh/a/e/if", DoNotGenerateAcw=true)]
	public sealed partial class If : global::Java.Lang.Object, global::Com.Qcl.VH.A.D.Ą.I鷭 {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qcl/vh/a/e/if", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (If); }
		}

		internal If (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.a.e']/class[@name='if']/constructor[@name='if' and count(parameter)=0]"
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

		static IntPtr id_ctor_Lcom_qcl_vh_a_b_Ȋ_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.a.e']/class[@name='if']/constructor[@name='if' and count(parameter)=1 and parameter[1][@type='com.qcl.vh.a.b.Ȋ']]"
		[Register (".ctor", "(Lcom/qcl/vh/a/b/Ȋ;)V", "")]
		public unsafe If (global::Com.Qcl.VH.A.B.Ȋ p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (If)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/qcl/vh/a/b/Ȋ;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/qcl/vh/a/b/Ȋ;)V", __args);
					return;
				}

				if (id_ctor_Lcom_qcl_vh_a_b_Ȋ_ == IntPtr.Zero)
					id_ctor_Lcom_qcl_vh_a_b_Ȋ_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/qcl/vh/a/b/Ȋ;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_qcl_vh_a_b_Ȋ_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_qcl_vh_a_b_Ȋ_, __args);
			} finally {
			}
		}

		static IntPtr id_Ą_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.e']/class[@name='if']/method[@name='Ą' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("Ą", "(Ljava/lang/String;Ljava/lang/String;)I", "")]
		public static unsafe int Ą (string p0, string p1)
		{
			if (id_Ą_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_Ą_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "Ą", "(Ljava/lang/String;Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_Ą_Ljava_lang_String_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_ą_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.e']/class[@name='if']/method[@name='ą' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("ą", "(Ljava/lang/String;Ljava/lang/String;)I", "")]
		public static unsafe int Ą (string p0, string p1)
		{
			if (id_ą_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_ą_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "ą", "(Ljava/lang/String;Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_ą_Ljava_lang_String_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_Ć_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.e']/class[@name='if']/method[@name='Ć' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("Ć", "(Ljava/lang/String;Ljava/lang/String;)I", "")]
		public static unsafe int Ć (string p0, string p1)
		{
			if (id_Ć_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_Ć_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "Ć", "(Ljava/lang/String;Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_Ć_Ljava_lang_String_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_ȃ_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.e']/class[@name='if']/method[@name='ȃ' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("ȃ", "(Ljava/lang/String;Ljava/lang/String;)I", "")]
		public static unsafe int Ȃ (string p0, string p1)
		{
			if (id_ȃ_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_ȃ_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "ȃ", "(Ljava/lang/String;Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_ȃ_Ljava_lang_String_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_ˮ͈_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.e']/class[@name='if']/method[@name='ˮ͈' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("ˮ͈", "(Ljava/lang/String;Ljava/lang/String;)I", "")]
		public static unsafe int ˮ͈ (string p0, string p1)
		{
			if (id_ˮ͈_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_ˮ͈_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "ˮ͈", "(Ljava/lang/String;Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_ˮ͈_Ljava_lang_String_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_櫯_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.e']/class[@name='if']/method[@name='櫯' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("櫯", "(Ljava/lang/String;Ljava/lang/String;)I", "")]
		public static unsafe int 櫯 (string p0, string p1)
		{
			if (id_櫯_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_櫯_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "櫯", "(Ljava/lang/String;Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_櫯_Ljava_lang_String_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_鷭_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.e']/class[@name='if']/method[@name='鷭' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("鷭", "(Ljava/lang/String;Ljava/lang/String;)I", "")]
		public static unsafe int 鷭 (string p0, string p1)
		{
			if (id_鷭_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_鷭_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "鷭", "(Ljava/lang/String;Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_鷭_Ljava_lang_String_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// This method is explicitly implemented as a member of an instantiated Com.Qcl.VH.A.D.Ą.I鷭
		global::Java.Lang.Object global::Com.Qcl.VH.A.D.Ą.I鷭.鷭 (global::System.IO.Stream p0)
		{
			return global::Java.Interop.JavaObjectExtensions.JavaCast<Java.Lang.Object>(鷭 (p0));
		}

	}
}
