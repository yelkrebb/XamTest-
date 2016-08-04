using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.A.B {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.a.b']/class[@name='鷭']"
	[global::Android.Runtime.Register ("com/qcl/vh/a/b/鷭", DoNotGenerateAcw=true)]
	public sealed partial class 鷭 : global::Com.Qcl.VH.A.D.鷭, global::Com.Qcl.VH.A.D.IIF {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.a.b']/class[@name='鷭.if']"
		[global::Android.Runtime.Register ("com/qcl/vh/a/b/鷭$if", DoNotGenerateAcw=true)]
		public partial class If : global::Java.Lang.Object, global::Com.Qcl.VH.A.D.Ą.I鷭 {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/qcl/vh/a/b/鷭$if", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (If); }
			}

			protected If (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_qcl_vh_a_b_鷭_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.a.b']/class[@name='鷭.if']/constructor[@name='鷭.if' and count(parameter)=1 and parameter[1][@type='com.qcl.vh.a.b.鷭']]"
			[Register (".ctor", "(Lcom/qcl/vh/a/b/鷭;)V", "")]
			public unsafe If (global::Com.Qcl.VH.A.B.鷭 __self)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (__self);
					if (GetType () != typeof (If)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args);
						return;
					}

					if (id_ctor_Lcom_qcl_vh_a_b_鷭_ == IntPtr.Zero)
						id_ctor_Lcom_qcl_vh_a_b_鷭_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/qcl/vh/a/b/鷭;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_qcl_vh_a_b_鷭_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_qcl_vh_a_b_鷭_, __args);
				} finally {
				}
			}

			static IntPtr id_ctor_Lcom_qcl_vh_a_b_鷭_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.a.b']/class[@name='鷭.if']/constructor[@name='鷭.if' and count(parameter)=1 and parameter[1][@type='com.qcl.vh.a.b.鷭']]"
			[Register (".ctor", "(Lcom/qcl/vh/a/b/鷭;)V", "")]
			public unsafe If (global::Com.Qcl.VH.A.B.鷭 __self)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (__self);
					if (GetType () != typeof (If)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args);
						return;
					}

					if (id_ctor_Lcom_qcl_vh_a_b_鷭_ == IntPtr.Zero)
						id_ctor_Lcom_qcl_vh_a_b_鷭_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/qcl/vh/a/b/鷭;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_qcl_vh_a_b_鷭_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_qcl_vh_a_b_鷭_, __args);
				} finally {
				}
			}

			static IntPtr id_鷭;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.b']/class[@name='鷭.if']/method[@name='鷭' and count(parameter)=0]"
			[Register ("鷭", "()Ljavax/crypto/spec/SecretKeySpec;", "")]
			public static unsafe global::Javax.Crypto.Spec.SecretKeySpec 鷭 ()
			{
				if (id_鷭 == IntPtr.Zero)
					id_鷭 = JNIEnv.GetStaticMethodID (class_ref, "鷭", "()Ljavax/crypto/spec/SecretKeySpec;");
				try {
					return global::Java.Lang.Object.GetObject<global::Javax.Crypto.Spec.SecretKeySpec> (JNIEnv.CallStaticObjectMethod  (class_ref, id_鷭), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_鷭_Ljava_security_PublicKey_Ljavax_crypto_spec_SecretKeySpec_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.b']/class[@name='鷭.if']/method[@name='鷭' and count(parameter)=2 and parameter[1][@type='java.security.PublicKey'] and parameter[2][@type='javax.crypto.spec.SecretKeySpec']]"
			[Register ("鷭", "(Ljava/security/PublicKey;Ljavax/crypto/spec/SecretKeySpec;)[B", "")]
			public static unsafe byte[] 鷭 (global::Java.Security.IPublicKey p0, global::Javax.Crypto.Spec.SecretKeySpec p1)
			{
				if (id_鷭_Ljava_security_PublicKey_Ljavax_crypto_spec_SecretKeySpec_ == IntPtr.Zero)
					id_鷭_Ljava_security_PublicKey_Ljavax_crypto_spec_SecretKeySpec_ = JNIEnv.GetStaticMethodID (class_ref, "鷭", "(Ljava/security/PublicKey;Ljavax/crypto/spec/SecretKeySpec;)[B");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_鷭_Ljava_security_PublicKey_Ljavax_crypto_spec_SecretKeySpec_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
					return __ret;
				} finally {
				}
			}

			static IntPtr id_鷭_Ljavax_crypto_spec_SecretKeySpec_arrayB;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.b']/class[@name='鷭.if']/method[@name='鷭' and count(parameter)=2 and parameter[1][@type='javax.crypto.spec.SecretKeySpec'] and parameter[2][@type='byte[]']]"
			[Register ("鷭", "(Ljavax/crypto/spec/SecretKeySpec;[B)[[B", "")]
			public static unsafe byte[][] 鷭 (global::Javax.Crypto.Spec.SecretKeySpec p0, byte[] p1)
			{
				if (id_鷭_Ljavax_crypto_spec_SecretKeySpec_arrayB == IntPtr.Zero)
					id_鷭_Ljavax_crypto_spec_SecretKeySpec_arrayB = JNIEnv.GetStaticMethodID (class_ref, "鷭", "(Ljavax/crypto/spec/SecretKeySpec;[B)[[B");
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (native_p1);
					byte[][] __ret = (byte[][]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_鷭_Ljavax_crypto_spec_SecretKeySpec_arrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte[]));
					return __ret;
				} finally {
					if (p1 != null) {
						JNIEnv.CopyArray (native_p1, p1);
						JNIEnv.DeleteLocalRef (native_p1);
					}
				}
			}

			// This method is explicitly implemented as a member of an instantiated Com.Qcl.VH.A.D.Ą.I鷭
			global::Java.Lang.Object global::Com.Qcl.VH.A.D.Ą.I鷭.鷭 (global::System.IO.Stream p0)
			{
				return global::Java.Interop.JavaObjectExtensions.JavaCast<Java.Lang.Object>(鷭 (p0));
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.a.b']/class[@name='鷭.鷭']"
		[global::Android.Runtime.Register ("com/qcl/vh/a/b/鷭$鷭", DoNotGenerateAcw=true)]
		public partial class 鷭 : global::Java.Lang.Object, global::Com.Qcl.VH.A.D.Ą.I鷭 {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/qcl/vh/a/b/鷭$鷭", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (鷭); }
			}

			protected 鷭 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_鷭_Ljava_io_ByteArrayOutputStream_Ljava_lang_Object_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.b']/class[@name='鷭.鷭']/method[@name='鷭' and count(parameter)=2 and parameter[1][@type='java.io.ByteArrayOutputStream'] and parameter[2][@type='java.lang.Object']]"
			[Register ("鷭", "(Ljava/io/ByteArrayOutputStream;Ljava/lang/Object;)V", "")]
			public unsafe void Invoke鷭 (global::Java.IO.ByteArrayOutputStream p0, global::Java.Lang.Object p1)
			{
				if (id_鷭_Ljava_io_ByteArrayOutputStream_Ljava_lang_Object_ == IntPtr.Zero)
					id_鷭_Ljava_io_ByteArrayOutputStream_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "鷭", "(Ljava/io/ByteArrayOutputStream;Ljava/lang/Object;)V");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					JNIEnv.CallVoidMethod  (Handle, id_鷭_Ljava_io_ByteArrayOutputStream_Ljava_lang_Object_, __args);
				} finally {
				}
			}

			// This method is explicitly implemented as a member of an instantiated Com.Qcl.VH.A.D.Ą.I鷭
			void global::Com.Qcl.VH.A.D.Ą.I鷭.鷭 (global::System.IO.Stream p0, global::Java.Lang.Object p1)
			{
				鷭 (p0, global::Java.Interop.JavaObjectExtensions.JavaCast<global::Com.Qcl.VH.A.C.鷭>(p1));
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qcl/vh/a/b/鷭", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (鷭); }
		}

		internal 鷭 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.a.b']/class[@name='鷭']/constructor[@name='鷭' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe 鷭 ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (鷭)) {
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

		// This method is explicitly implemented as a member of an instantiated Com.Qcl.VH.A.D.IIF
		global::Com.Qcl.VH.A.D.Ą.I鷭 global::Com.Qcl.VH.A.D.IIF.櫯 ()
		{
			return global::Java.Interop.JavaObjectExtensions.JavaCast<Com.Qcl.VH.A.D.Ą.I鷭>(櫯 ());
		}

		// This method is explicitly implemented as a member of an instantiated Com.Qcl.VH.A.D.IIF
		global::Com.Qcl.VH.A.D.Ą.I鷭 global::Com.Qcl.VH.A.D.IIF.鷭 ()
		{
			return global::Java.Interop.JavaObjectExtensions.JavaCast<Com.Qcl.VH.A.D.Ą.I鷭>(鷭 ());
		}

	}
}
