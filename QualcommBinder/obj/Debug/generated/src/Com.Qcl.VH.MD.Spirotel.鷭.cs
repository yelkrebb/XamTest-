using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.MD.Spirotel {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.md.spirotel']/class[@name='鷭']"
	[global::Android.Runtime.Register ("com/qcl/vh/md/spirotel/鷭", DoNotGenerateAcw=true)]
	public sealed partial class 鷭 : global::Java.Lang.Object, global::Com.Qcl.VH.A.D.Ą.I鷭 {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qcl/vh/md/spirotel/鷭", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (鷭); }
		}

		internal 鷭 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_qcl_vh_a_b_AUX_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.md.spirotel']/class[@name='鷭']/constructor[@name='鷭' and count(parameter)=1 and parameter[1][@type='com.qcl.vh.a.b.AUX']]"
		[Register (".ctor", "(Lcom/qcl/vh/a/b/AUX;)V", "")]
		public unsafe 鷭 (global::Com.Qcl.VH.A.B.AUX p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (鷭)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/qcl/vh/a/b/AUX;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/qcl/vh/a/b/AUX;)V", __args);
					return;
				}

				if (id_ctor_Lcom_qcl_vh_a_b_AUX_ == IntPtr.Zero)
					id_ctor_Lcom_qcl_vh_a_b_AUX_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/qcl/vh/a/b/AUX;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_qcl_vh_a_b_AUX_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_qcl_vh_a_b_AUX_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.md.spirotel']/class[@name='鷭']/constructor[@name='鷭' and count(parameter)=0]"
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

		static IntPtr id_鷭_arrayBIarrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.spirotel']/class[@name='鷭']/method[@name='鷭' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='byte......']]"
		[Register ("鷭", "([BI[B)I", "")]
		public static unsafe int Invoke鷭 (byte[] p0, int p1, params  byte[] p2)
		{
			if (id_鷭_arrayBIarrayB == IntPtr.Zero)
				id_鷭_arrayBIarrayB = JNIEnv.GetStaticMethodID (class_ref, "鷭", "([BI[B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_鷭_arrayBIarrayB, __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static IntPtr id_鷭_Ljava_io_InputStream_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.spirotel']/class[@name='鷭']/method[@name='鷭' and count(parameter)=2 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='byte[]']]"
		[Register ("鷭", "(Ljava/io/InputStream;[B)V", "")]
		public static unsafe void Invoke鷭 (global::System.IO.Stream p0, byte[] p1)
		{
			if (id_鷭_Ljava_io_InputStream_arrayB == IntPtr.Zero)
				id_鷭_Ljava_io_InputStream_arrayB = JNIEnv.GetStaticMethodID (class_ref, "鷭", "(Ljava/io/InputStream;[B)V");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_鷭_Ljava_io_InputStream_arrayB, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_鷭_Ljava_io_InputStream_arrayBII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.spirotel']/class[@name='鷭']/method[@name='鷭' and count(parameter)=4 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("鷭", "(Ljava/io/InputStream;[BII)[B", "")]
		public static unsafe byte[] Invoke鷭 (global::System.IO.Stream p0, byte[] p1, int p2, int p3)
		{
			if (id_鷭_Ljava_io_InputStream_arrayBII == IntPtr.Zero)
				id_鷭_Ljava_io_InputStream_arrayBII = JNIEnv.GetStaticMethodID (class_ref, "鷭", "(Ljava/io/InputStream;[BII)[B");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_鷭_Ljava_io_InputStream_arrayBII, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
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
}
