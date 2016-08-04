using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.A.A {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.a.a']/class[@name='櫯']"
	[global::Android.Runtime.Register ("com/qcl/vh/a/a/櫯", DoNotGenerateAcw=true)]
	public sealed partial class 櫯 : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qcl/vh/a/a/櫯", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (櫯); }
		}

		internal 櫯 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.a.a']/class[@name='櫯']/constructor[@name='櫯' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe 櫯 ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (櫯)) {
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

		static IntPtr id_ȃ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.a']/class[@name='櫯']/method[@name='ȃ' and count(parameter)=0]"
		[Register ("ȃ", "()V", "")]
		public unsafe void Ȃ ()
		{
			if (id_ȃ == IntPtr.Zero)
				id_ȃ = JNIEnv.GetMethodID (class_ref, "ȃ", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_ȃ);
			} finally {
			}
		}

		static IntPtr id_ˮ͈;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.a']/class[@name='櫯']/method[@name='ˮ͈' and count(parameter)=0]"
		[Register ("ˮ͈", "()Lcom/qcl/vh/a/c/CON;", "")]
		public unsafe global::Com.Qcl.VH.A.C.CON ˮ͈ ()
		{
			if (id_ˮ͈ == IntPtr.Zero)
				id_ˮ͈ = JNIEnv.GetMethodID (class_ref, "ˮ͈", "()Lcom/qcl/vh/a/c/CON;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.A.C.CON> (JNIEnv.CallObjectMethod  (Handle, id_ˮ͈), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_櫯;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.a']/class[@name='櫯']/method[@name='櫯' and count(parameter)=0]"
		[Register ("櫯", "()Lcom/qcl/vh/a/c/㵼;", "")]
		public unsafe global::Com.Qcl.VH.A.C.㵼 Invoke櫯 ()
		{
			if (id_櫯 == IntPtr.Zero)
				id_櫯 = JNIEnv.GetMethodID (class_ref, "櫯", "()Lcom/qcl/vh/a/c/㵼;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.A.C.㵼> (JNIEnv.CallObjectMethod  (Handle, id_櫯), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_櫯_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.a']/class[@name='櫯']/method[@name='櫯' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("櫯", "(Ljava/lang/String;)V", "")]
		public unsafe void Invoke櫯 (string p0)
		{
			if (id_櫯_Ljava_lang_String_ == IntPtr.Zero)
				id_櫯_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "櫯", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod  (Handle, id_櫯_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_鷭;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.a']/class[@name='櫯']/method[@name='鷭' and count(parameter)=0]"
		[Register ("鷭", "()J", "")]
		public unsafe long 鷭 ()
		{
			if (id_鷭 == IntPtr.Zero)
				id_鷭 = JNIEnv.GetMethodID (class_ref, "鷭", "()J");
			try {
				return JNIEnv.CallLongMethod  (Handle, id_鷭);
			} finally {
			}
		}

		static IntPtr id_鷭_Lcom_qcl_vh_a_c_CON_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.a']/class[@name='櫯']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='com.qcl.vh.a.c.CON']]"
		[Register ("鷭", "(Lcom/qcl/vh/a/c/CON;)Lcom/qcl/vh/a/c/CON;", "")]
		public unsafe global::Com.Qcl.VH.A.C.CON 鷭 (global::Com.Qcl.VH.A.C.CON p0)
		{
			if (id_鷭_Lcom_qcl_vh_a_c_CON_ == IntPtr.Zero)
				id_鷭_Lcom_qcl_vh_a_c_CON_ = JNIEnv.GetMethodID (class_ref, "鷭", "(Lcom/qcl/vh/a/c/CON;)Lcom/qcl/vh/a/c/CON;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Qcl.VH.A.C.CON __ret = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.A.C.CON> (JNIEnv.CallObjectMethod  (Handle, id_鷭_Lcom_qcl_vh_a_c_CON_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_鷭_Lcom_qcl_vh_a_c_iF_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.a']/class[@name='櫯']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='com.qcl.vh.a.c.iF']]"
		[Register ("鷭", "(Lcom/qcl/vh/a/c/iF;)Lcom/qcl/vh/a/c/㵼;", "")]
		public unsafe global::Com.Qcl.VH.A.C.㵼 鷭 (global::Com.Qcl.VH.A.C.IF p0)
		{
			if (id_鷭_Lcom_qcl_vh_a_c_iF_ == IntPtr.Zero)
				id_鷭_Lcom_qcl_vh_a_c_iF_ = JNIEnv.GetMethodID (class_ref, "鷭", "(Lcom/qcl/vh/a/c/iF;)Lcom/qcl/vh/a/c/㵼;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Qcl.VH.A.C.㵼 __ret = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.A.C.㵼> (JNIEnv.CallObjectMethod  (Handle, id_鷭_Lcom_qcl_vh_a_c_iF_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_鷭_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.a']/class[@name='櫯']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("鷭", "(Ljava/lang/String;)V", "")]
		public unsafe void 鷭 (string p0)
		{
			if (id_鷭_Ljava_lang_String_ == IntPtr.Zero)
				id_鷭_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "鷭", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod  (Handle, id_鷭_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_鷭_Ljava_lang_String_arrayC;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.a']/class[@name='櫯']/method[@name='鷭' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='char[]']]"
		[Register ("鷭", "(Ljava/lang/String;[C)V", "")]
		public unsafe void 鷭 (string p0, char[] p1)
		{
			if (id_鷭_Ljava_lang_String_arrayC == IntPtr.Zero)
				id_鷭_Ljava_lang_String_arrayC = JNIEnv.GetMethodID (class_ref, "鷭", "(Ljava/lang/String;[C)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallVoidMethod  (Handle, id_鷭_Ljava_lang_String_arrayC, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_鷭_Ljava_security_KeyStore_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.a']/class[@name='櫯']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='java.security.KeyStore']]"
		[Register ("鷭", "(Ljava/security/KeyStore;)V", "")]
		public unsafe void 鷭 (global::Java.Security.KeyStore p0)
		{
			if (id_鷭_Ljava_security_KeyStore_ == IntPtr.Zero)
				id_鷭_Ljava_security_KeyStore_ = JNIEnv.GetMethodID (class_ref, "鷭", "(Ljava/security/KeyStore;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_鷭_Ljava_security_KeyStore_, __args);
			} finally {
			}
		}

		static IntPtr id_鷭_Ljava_security_KeyStore_Ljava_lang_String_Lcom_qcl_vh_a_c_Ć_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.a']/class[@name='櫯']/method[@name='鷭' and count(parameter)=3 and parameter[1][@type='java.security.KeyStore'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.qcl.vh.a.c.Ć']]"
		[Register ("鷭", "(Ljava/security/KeyStore;Ljava/lang/String;Lcom/qcl/vh/a/c/Ć;)V", "")]
		public static unsafe void 鷭 (global::Java.Security.KeyStore p0, string p1, global::Com.Qcl.VH.A.C.Ć p2)
		{
			if (id_鷭_Ljava_security_KeyStore_Ljava_lang_String_Lcom_qcl_vh_a_c_Ć_ == IntPtr.Zero)
				id_鷭_Ljava_security_KeyStore_Ljava_lang_String_Lcom_qcl_vh_a_c_Ć_ = JNIEnv.GetStaticMethodID (class_ref, "鷭", "(Ljava/security/KeyStore;Ljava/lang/String;Lcom/qcl/vh/a/c/Ć;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_鷭_Ljava_security_KeyStore_Ljava_lang_String_Lcom_qcl_vh_a_c_Ć_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
