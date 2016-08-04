using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.A.C {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.a.c']/class[@name='㵼']"
	[global::Android.Runtime.Register ("com/qcl/vh/a/c/㵼", DoNotGenerateAcw=true)]
	public sealed partial class 㵼 : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qcl/vh/a/c/㵼", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (㵼); }
		}

		internal 㵼 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.a.c']/class[@name='㵼']/constructor[@name='㵼' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe 㵼 ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (㵼)) {
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

		static IntPtr id_toString;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.c']/class[@name='㵼']/method[@name='toString' and count(parameter)=0]"
		[Register ("toString", "()Ljava/lang/String;", "")]
		public override sealed unsafe string ToString ()
		{
			if (id_toString == IntPtr.Zero)
				id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_toString), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_ˮ͈;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.c']/class[@name='㵼']/method[@name='ˮ͈' and count(parameter)=0]"
		[Register ("ˮ͈", "()Ljava/security/KeyStore;", "")]
		public unsafe global::Java.Security.KeyStore ˮ͈ ()
		{
			if (id_ˮ͈ == IntPtr.Zero)
				id_ˮ͈ = JNIEnv.GetMethodID (class_ref, "ˮ͈", "()Ljava/security/KeyStore;");
			try {
				return global::Java.Lang.Object.GetObject<global::Java.Security.KeyStore> (JNIEnv.CallObjectMethod  (Handle, id_ˮ͈), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_櫯;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.c']/class[@name='㵼']/method[@name='櫯' and count(parameter)=0]"
		[Register ("櫯", "()Ljava/lang/String;", "")]
		public unsafe string 櫯 ()
		{
			if (id_櫯 == IntPtr.Zero)
				id_櫯 = JNIEnv.GetMethodID (class_ref, "櫯", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_櫯), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_鷭;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.c']/class[@name='㵼']/method[@name='鷭' and count(parameter)=0]"
		[Register ("鷭", "()Ljava/security/cert/X509Certificate;", "")]
		public unsafe global::Java.Security.Cert.X509Certificate 鷭 ()
		{
			if (id_鷭 == IntPtr.Zero)
				id_鷭 = JNIEnv.GetMethodID (class_ref, "鷭", "()Ljava/security/cert/X509Certificate;");
			try {
				return global::Java.Lang.Object.GetObject<global::Java.Security.Cert.X509Certificate> (JNIEnv.CallObjectMethod  (Handle, id_鷭), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_鷭_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.c']/class[@name='㵼']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
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

		static IntPtr id_鷭_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.c']/class[@name='㵼']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static IntPtr id_鷭_Ljava_security_KeyStore_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.c']/class[@name='㵼']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='java.security.KeyStore']]"
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

		static IntPtr id_鷭_Ljava_security_cert_X509Certificate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.c']/class[@name='㵼']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='java.security.cert.X509Certificate']]"
		[Register ("鷭", "(Ljava/security/cert/X509Certificate;)V", "")]
		public unsafe void 鷭 (global::Java.Security.Cert.X509Certificate p0)
		{
			if (id_鷭_Ljava_security_cert_X509Certificate_ == IntPtr.Zero)
				id_鷭_Ljava_security_cert_X509Certificate_ = JNIEnv.GetMethodID (class_ref, "鷭", "(Ljava/security/cert/X509Certificate;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_鷭_Ljava_security_cert_X509Certificate_, __args);
			} finally {
			}
		}

	}
}
