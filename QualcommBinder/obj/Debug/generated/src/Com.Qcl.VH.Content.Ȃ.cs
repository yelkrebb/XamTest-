using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.Content {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='ȃ']"
	[global::Android.Runtime.Register ("com/qcl/vh/content/ȃ", DoNotGenerateAcw=true)]
	public sealed partial class Ȃ : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qcl/vh/content/ȃ", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Ȃ); }
		}

		internal Ȃ (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_qcl_vh_a_c_ˮ͍_IJ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='ȃ']/constructor[@name='ȃ' and count(parameter)=3 and parameter[1][@type='com.qcl.vh.a.c.ˮ͍'] and parameter[2][@type='int'] and parameter[3][@type='long']]"
		[Register (".ctor", "(Lcom/qcl/vh/a/c/ˮ͍;IJ)V", "")]
		public unsafe Ȃ (global::Com.Qcl.VH.A.C.ˮ͍ p0, int p1, long p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (Ȃ)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/qcl/vh/a/c/ˮ͍;IJ)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/qcl/vh/a/c/ˮ͍;IJ)V", __args);
					return;
				}

				if (id_ctor_Lcom_qcl_vh_a_c_ˮ͍_IJ == IntPtr.Zero)
					id_ctor_Lcom_qcl_vh_a_c_ˮ͍_IJ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/qcl/vh/a/c/ˮ͍;IJ)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_qcl_vh_a_c_ˮ͍_IJ, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_qcl_vh_a_c_ˮ͍_IJ, __args);
			} finally {
			}
		}

		static IntPtr id_toString;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='ȃ']/method[@name='toString' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='ȃ']/method[@name='ˮ͈' and count(parameter)=0]"
		[Register ("ˮ͈", "()J", "")]
		public unsafe long ˮ͈ ()
		{
			if (id_ˮ͈ == IntPtr.Zero)
				id_ˮ͈ = JNIEnv.GetMethodID (class_ref, "ˮ͈", "()J");
			try {
				return JNIEnv.CallLongMethod  (Handle, id_ˮ͈);
			} finally {
			}
		}

		static IntPtr id_櫯;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='ȃ']/method[@name='櫯' and count(parameter)=0]"
		[Register ("櫯", "()I", "")]
		public unsafe int 櫯 ()
		{
			if (id_櫯 == IntPtr.Zero)
				id_櫯 = JNIEnv.GetMethodID (class_ref, "櫯", "()I");
			try {
				return JNIEnv.CallIntMethod  (Handle, id_櫯);
			} finally {
			}
		}

		static IntPtr id_鷭;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='ȃ']/method[@name='鷭' and count(parameter)=0]"
		[Register ("鷭", "()Lcom/qcl/vh/a/c/ˮ͍;", "")]
		public unsafe global::Com.Qcl.VH.A.C.ˮ͍ 鷭 ()
		{
			if (id_鷭 == IntPtr.Zero)
				id_鷭 = JNIEnv.GetMethodID (class_ref, "鷭", "()Lcom/qcl/vh/a/c/ˮ͍;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.A.C.ˮ͍> (JNIEnv.CallObjectMethod  (Handle, id_鷭), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
