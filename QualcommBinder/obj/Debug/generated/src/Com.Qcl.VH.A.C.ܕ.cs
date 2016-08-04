using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.A.C {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.a.c']/class[@name='ܕ']"
	[global::Android.Runtime.Register ("com/qcl/vh/a/c/ܕ", DoNotGenerateAcw=true)]
	public partial class ܕ : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qcl/vh/a/c/ܕ", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ܕ); }
		}

		protected ܕ (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.a.c']/class[@name='ܕ']/constructor[@name='ܕ' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ܕ ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ܕ)) {
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

		static IntPtr id_ˮ͈;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.c']/class[@name='ܕ']/method[@name='ˮ͈' and count(parameter)=0]"
		[Register ("ˮ͈", "()Lcom/qcl/vh/a/c/cOn;", "")]
		public unsafe global::Com.Qcl.VH.A.C.COn ˮ͈ ()
		{
			if (id_ˮ͈ == IntPtr.Zero)
				id_ˮ͈ = JNIEnv.GetMethodID (class_ref, "ˮ͈", "()Lcom/qcl/vh/a/c/cOn;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.A.C.COn> (JNIEnv.CallObjectMethod  (Handle, id_ˮ͈), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_櫯;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.c']/class[@name='ܕ']/method[@name='櫯' and count(parameter)=0]"
		[Register ("櫯", "()Lcom/qcl/vh/a/c/COn;", "")]
		public unsafe global::Com.Qcl.VH.A.C.COn 櫯 ()
		{
			if (id_櫯 == IntPtr.Zero)
				id_櫯 = JNIEnv.GetMethodID (class_ref, "櫯", "()Lcom/qcl/vh/a/c/COn;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.A.C.COn> (JNIEnv.CallObjectMethod  (Handle, id_櫯), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_鷭;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.c']/class[@name='ܕ']/method[@name='鷭' and count(parameter)=0]"
		[Register ("鷭", "()Lcom/qcl/vh/a/e/If;", "")]
		public unsafe global::Com.Qcl.VH.A.E.If 鷭 ()
		{
			if (id_鷭 == IntPtr.Zero)
				id_鷭 = JNIEnv.GetMethodID (class_ref, "鷭", "()Lcom/qcl/vh/a/e/If;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.A.E.If> (JNIEnv.CallObjectMethod  (Handle, id_鷭), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_鷭_Lcom_qcl_vh_a_c_COn_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.c']/class[@name='ܕ']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='com.qcl.vh.a.c.COn']]"
		[Register ("鷭", "(Lcom/qcl/vh/a/c/COn;)V", "")]
		public unsafe void 鷭 (global::Com.Qcl.VH.A.C.COn p0)
		{
			if (id_鷭_Lcom_qcl_vh_a_c_COn_ == IntPtr.Zero)
				id_鷭_Lcom_qcl_vh_a_c_COn_ = JNIEnv.GetMethodID (class_ref, "鷭", "(Lcom/qcl/vh/a/c/COn;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_鷭_Lcom_qcl_vh_a_c_COn_, __args);
			} finally {
			}
		}

		static IntPtr id_鷭_Lcom_qcl_vh_a_c_cOn_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.c']/class[@name='ܕ']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='com.qcl.vh.a.c.cOn']]"
		[Register ("鷭", "(Lcom/qcl/vh/a/c/cOn;)V", "")]
		public unsafe void 鷭 (global::Com.Qcl.VH.A.C.COn p0)
		{
			if (id_鷭_Lcom_qcl_vh_a_c_cOn_ == IntPtr.Zero)
				id_鷭_Lcom_qcl_vh_a_c_cOn_ = JNIEnv.GetMethodID (class_ref, "鷭", "(Lcom/qcl/vh/a/c/cOn;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_鷭_Lcom_qcl_vh_a_c_cOn_, __args);
			} finally {
			}
		}

		static IntPtr id_鷭_Lcom_qcl_vh_a_e_If_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.c']/class[@name='ܕ']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='com.qcl.vh.a.e.If']]"
		[Register ("鷭", "(Lcom/qcl/vh/a/e/If;)V", "")]
		public unsafe void 鷭 (global::Com.Qcl.VH.A.E.If p0)
		{
			if (id_鷭_Lcom_qcl_vh_a_e_If_ == IntPtr.Zero)
				id_鷭_Lcom_qcl_vh_a_e_If_ = JNIEnv.GetMethodID (class_ref, "鷭", "(Lcom/qcl/vh/a/e/If;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_鷭_Lcom_qcl_vh_a_e_If_, __args);
			} finally {
			}
		}

	}
}
