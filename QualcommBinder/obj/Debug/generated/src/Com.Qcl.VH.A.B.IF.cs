using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.A.B {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.a.b']/class[@name='if']"
	[global::Android.Runtime.Register ("com/qcl/vh/a/b/if", DoNotGenerateAcw=true)]
	public sealed partial class If : global::Com.Qcl.VH.A.D.鷭, global::Com.Qcl.VH.A.D.IIF {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.a.b']/class[@name='if.if']"
		[global::Android.Runtime.Register ("com/qcl/vh/a/b/if$if", DoNotGenerateAcw=true)]
		public partial class If : global::Java.Lang.Object, global::Com.Qcl.VH.A.D.Ą.I鷭 {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/qcl/vh/a/b/if$if", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (If); }
			}

			protected If (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_qcl_vh_a_b_if_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.a.b']/class[@name='if.if']/constructor[@name='if.if' and count(parameter)=1 and parameter[1][@type='com.qcl.vh.a.b.if']]"
			[Register (".ctor", "(Lcom/qcl/vh/a/b/if;)V", "")]
			public unsafe If (global::Com.Qcl.VH.A.B.If __self)
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

					if (id_ctor_Lcom_qcl_vh_a_b_if_ == IntPtr.Zero)
						id_ctor_Lcom_qcl_vh_a_b_if_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/qcl/vh/a/b/if;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_qcl_vh_a_b_if_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_qcl_vh_a_b_if_, __args);
				} finally {
				}
			}

			static IntPtr id_ctor_Lcom_qcl_vh_a_b_if_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.a.b']/class[@name='if.if']/constructor[@name='if.if' and count(parameter)=1 and parameter[1][@type='com.qcl.vh.a.b.if']]"
			[Register (".ctor", "(Lcom/qcl/vh/a/b/if;)V", "")]
			public unsafe If (global::Com.Qcl.VH.A.B.If __self)
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

					if (id_ctor_Lcom_qcl_vh_a_b_if_ == IntPtr.Zero)
						id_ctor_Lcom_qcl_vh_a_b_if_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/qcl/vh/a/b/if;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_qcl_vh_a_b_if_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_qcl_vh_a_b_if_, __args);
				} finally {
				}
			}

			static IntPtr id_鷭_arrayB;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.b']/class[@name='if.if']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("鷭", "([B)Ljava/lang/String;", "")]
			public static unsafe string 鷭 (byte[] p0)
			{
				if (id_鷭_arrayB == IntPtr.Zero)
					id_鷭_arrayB = JNIEnv.GetStaticMethodID (class_ref, "鷭", "([B)Ljava/lang/String;");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_鷭_arrayB, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
				}
			}

			// This method is explicitly implemented as a member of an instantiated Com.Qcl.VH.A.D.Ą.I鷭
			global::Java.Lang.Object global::Com.Qcl.VH.A.D.Ą.I鷭.鷭 (global::System.IO.Stream p0)
			{
				return global::Java.Interop.JavaObjectExtensions.JavaCast<Java.Lang.Object>(鷭 (p0));
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.a.b']/class[@name='if.鷭']"
		[global::Android.Runtime.Register ("com/qcl/vh/a/b/if$鷭", DoNotGenerateAcw=true)]
		public partial class 鷭 : global::Java.Lang.Object, global::Com.Qcl.VH.A.D.Ą.I鷭 {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/qcl/vh/a/b/if$鷭", ref java_class_handle);
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.b']/class[@name='if.鷭']/method[@name='鷭' and count(parameter)=2 and parameter[1][@type='java.io.ByteArrayOutputStream'] and parameter[2][@type='java.lang.Object']]"
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
				鷭 (p0, global::Java.Interop.JavaObjectExtensions.JavaCast<global::Com.Qcl.VH.A.C.櫯>(p1));
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qcl/vh/a/b/if", ref java_class_handle);
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.a.b']/class[@name='if']/constructor[@name='if' and count(parameter)=0]"
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
