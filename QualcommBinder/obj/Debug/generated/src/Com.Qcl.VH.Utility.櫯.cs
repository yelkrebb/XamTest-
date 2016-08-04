using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.Utility {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.utility']/class[@name='櫯']"
	[global::Android.Runtime.Register ("com/qcl/vh/utility/櫯", DoNotGenerateAcw=true)]
	public sealed partial class 櫯 : global::Java.Lang.Object, global::Com.Qcl.VH.A.D.Ą.I鷭 {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qcl/vh/utility/櫯", ref java_class_handle);
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.utility']/class[@name='櫯']/constructor[@name='櫯' and count(parameter)=0]"
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

		static IntPtr id_ctor_Lcom_qcl_vh_a_b_con_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.utility']/class[@name='櫯']/constructor[@name='櫯' and count(parameter)=1 and parameter[1][@type='com.qcl.vh.a.b.con']]"
		[Register (".ctor", "(Lcom/qcl/vh/a/b/con;)V", "")]
		public unsafe 櫯 (global::Com.Qcl.VH.A.B.Con p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (櫯)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/qcl/vh/a/b/con;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/qcl/vh/a/b/con;)V", __args);
					return;
				}

				if (id_ctor_Lcom_qcl_vh_a_b_con_ == IntPtr.Zero)
					id_ctor_Lcom_qcl_vh_a_b_con_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/qcl/vh/a/b/con;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_qcl_vh_a_b_con_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_qcl_vh_a_b_con_, __args);
			} finally {
			}
		}

		static IntPtr id_鷭_Lcom_qcl_vh_a_c_띥_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.utility']/class[@name='櫯']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='com.qcl.vh.a.c.띥']]"
		[Register ("鷭", "(Lcom/qcl/vh/a/c/띥;)Lcom/qcl/vh/a/c/CON;", "")]
		public static unsafe global::Com.Qcl.VH.A.C.CON 鷭 (global::Com.Qcl.VH.A.C.띥 p0)
		{
			if (id_鷭_Lcom_qcl_vh_a_c_띥_ == IntPtr.Zero)
				id_鷭_Lcom_qcl_vh_a_c_띥_ = JNIEnv.GetStaticMethodID (class_ref, "鷭", "(Lcom/qcl/vh/a/c/띥;)Lcom/qcl/vh/a/c/CON;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Qcl.VH.A.C.CON __ret = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.A.C.CON> (JNIEnv.CallStaticObjectMethod  (class_ref, id_鷭_Lcom_qcl_vh_a_c_띥_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_鷭_Lcom_qcl_vh_a_c_띥_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.utility']/class[@name='櫯']/method[@name='鷭' and count(parameter)=2 and parameter[1][@type='com.qcl.vh.a.c.띥'] and parameter[2][@type='int']]"
		[Register ("鷭", "(Lcom/qcl/vh/a/c/띥;I)Lcom/qcl/vh/a/c/CON;", "")]
		public static unsafe global::Com.Qcl.VH.A.C.CON 鷭 (global::Com.Qcl.VH.A.C.띥 p0, int p1)
		{
			if (id_鷭_Lcom_qcl_vh_a_c_띥_I == IntPtr.Zero)
				id_鷭_Lcom_qcl_vh_a_c_띥_I = JNIEnv.GetStaticMethodID (class_ref, "鷭", "(Lcom/qcl/vh/a/c/띥;I)Lcom/qcl/vh/a/c/CON;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Com.Qcl.VH.A.C.CON __ret = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.A.C.CON> (JNIEnv.CallStaticObjectMethod  (class_ref, id_鷭_Lcom_qcl_vh_a_c_띥_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		// This method is explicitly implemented as a member of an instantiated Com.Qcl.VH.A.D.Ą.I鷭
		global::Java.Lang.Object global::Com.Qcl.VH.A.D.Ą.I鷭.鷭 (global::System.IO.Stream p0)
		{
			return global::Java.Interop.JavaObjectExtensions.JavaCast<Java.Lang.Object>(鷭 (p0));
		}

	}
}
