using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.A.D {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.a.d']/class[@name='aux']"
	[global::Android.Runtime.Register ("com/qcl/vh/a/d/aux", DoNotGenerateAcw=true)]
	public sealed partial class Aux : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qcl/vh/a/d/aux", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Aux); }
		}

		internal Aux (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.a.d']/class[@name='aux']/constructor[@name='aux' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Aux ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Aux)) {
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

		static IntPtr id_櫯_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.d']/class[@name='aux']/method[@name='櫯' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("櫯", "(Ljava/lang/Class;)Lcom/qcl/vh/a/d/Ą$鷭;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public unsafe global::Com.Qcl.VH.A.D.Ą.I鷭 櫯 (global::Java.Lang.Class p0)
		{
			if (id_櫯_Ljava_lang_Class_ == IntPtr.Zero)
				id_櫯_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "櫯", "(Ljava/lang/Class;)Lcom/qcl/vh/a/d/Ą$鷭;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Qcl.VH.A.D.Ą.I鷭 __ret = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.A.D.Ą.I鷭> (JNIEnv.CallObjectMethod  (Handle, id_櫯_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_鷭_Ljava_io_ByteArrayOutputStream_ILjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.d']/class[@name='aux']/method[@name='鷭' and count(parameter)=3 and parameter[1][@type='java.io.ByteArrayOutputStream'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.Object']]"
		[Register ("鷭", "(Ljava/io/ByteArrayOutputStream;ILjava/lang/Object;)V", "")]
		public unsafe void 鷭 (global::Java.IO.ByteArrayOutputStream p0, int p1, global::Java.Lang.Object p2)
		{
			if (id_鷭_Ljava_io_ByteArrayOutputStream_ILjava_lang_Object_ == IntPtr.Zero)
				id_鷭_Ljava_io_ByteArrayOutputStream_ILjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "鷭", "(Ljava/io/ByteArrayOutputStream;ILjava/lang/Object;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod  (Handle, id_鷭_Ljava_io_ByteArrayOutputStream_ILjava_lang_Object_, __args);
			} finally {
			}
		}

		static IntPtr id_鷭_Ljava_io_InputStream_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.d']/class[@name='aux']/method[@name='鷭' and count(parameter)=2 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("鷭", "(Ljava/io/InputStream;Ljava/lang/Class;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public unsafe global::Java.Lang.Object 鷭 (global::System.IO.Stream p0, global::Java.Lang.Class p1)
		{
			if (id_鷭_Ljava_io_InputStream_Ljava_lang_Class_ == IntPtr.Zero)
				id_鷭_Ljava_io_InputStream_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "鷭", "(Ljava/io/InputStream;Ljava/lang/Class;)Ljava/lang/Object;");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_鷭_Ljava_io_InputStream_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_鷭_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.d']/class[@name='aux']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;?&gt;']]"
		[Register ("鷭", "(Ljava/lang/Class;)Lcom/qcl/vh/a/d/ą$鷭;", "")]
		public unsafe global::Com.Qcl.VH.A.D.Ą.I鷭 鷭 (global::Java.Lang.Class p0)
		{
			if (id_鷭_Ljava_lang_Class_ == IntPtr.Zero)
				id_鷭_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "鷭", "(Ljava/lang/Class;)Lcom/qcl/vh/a/d/ą$鷭;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Qcl.VH.A.D.Ą.I鷭 __ret = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.A.D.Ą.I鷭> (JNIEnv.CallObjectMethod  (Handle, id_鷭_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_鷭_Ljava_lang_Class_Lcom_qcl_vh_a_d_IF_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.d']/class[@name='aux']/method[@name='鷭' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='com.qcl.vh.a.d.IF&lt;?&gt;']]"
		[Register ("鷭", "(Ljava/lang/Class;Lcom/qcl/vh/a/d/IF;)V", "")]
		public unsafe void 鷭 (global::Java.Lang.Class p0, global::Com.Qcl.VH.A.D.IIF p1)
		{
			if (id_鷭_Ljava_lang_Class_Lcom_qcl_vh_a_d_IF_ == IntPtr.Zero)
				id_鷭_Ljava_lang_Class_Lcom_qcl_vh_a_d_IF_ = JNIEnv.GetMethodID (class_ref, "鷭", "(Ljava/lang/Class;Lcom/qcl/vh/a/d/IF;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod  (Handle, id_鷭_Ljava_lang_Class_Lcom_qcl_vh_a_d_IF_, __args);
			} finally {
			}
		}

	}
}
