using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.A.C {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.a.c']/class[@name='櫯']"
	[global::Android.Runtime.Register ("com/qcl/vh/a/c/櫯", DoNotGenerateAcw=true)]
	public partial class 櫯 : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qcl/vh/a/c/櫯", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (櫯); }
		}

		protected 櫯 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.a.c']/class[@name='櫯']/constructor[@name='櫯' and count(parameter)=0]"
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

		static IntPtr id_Ą;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.c']/class[@name='櫯']/method[@name='Ą' and count(parameter)=0]"
		[Register ("Ą", "()Lcom/qcl/vh/a/c/cON;", "")]
		public unsafe global::Com.Qcl.VH.A.C.CON Ą ()
		{
			if (id_Ą == IntPtr.Zero)
				id_Ą = JNIEnv.GetMethodID (class_ref, "Ą", "()Lcom/qcl/vh/a/c/cON;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.A.C.CON> (JNIEnv.CallObjectMethod  (Handle, id_Ą), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_ȃ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.c']/class[@name='櫯']/method[@name='ȃ' and count(parameter)=0]"
		[Register ("ȃ", "()Lcom/qcl/vh/a/e/If;", "")]
		public unsafe global::Com.Qcl.VH.A.E.If Ȃ ()
		{
			if (id_ȃ == IntPtr.Zero)
				id_ȃ = JNIEnv.GetMethodID (class_ref, "ȃ", "()Lcom/qcl/vh/a/e/If;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.A.E.If> (JNIEnv.CallObjectMethod  (Handle, id_ȃ), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_ˮ͈;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.c']/class[@name='櫯']/method[@name='ˮ͈' and count(parameter)=0]"
		[Register ("ˮ͈", "()Ljava/lang/Integer;", "")]
		public unsafe global::Java.Lang.Integer ˮ͈ ()
		{
			if (id_ˮ͈ == IntPtr.Zero)
				id_ˮ͈ = JNIEnv.GetMethodID (class_ref, "ˮ͈", "()Ljava/lang/Integer;");
			try {
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod  (Handle, id_ˮ͈), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_櫯;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.c']/class[@name='櫯']/method[@name='櫯' and count(parameter)=0]"
		[Register ("櫯", "()Lcom/qcl/vh/a/c/if;", "")]
		public unsafe global::Com.Qcl.VH.A.C.If Invoke櫯 ()
		{
			if (id_櫯 == IntPtr.Zero)
				id_櫯 = JNIEnv.GetMethodID (class_ref, "櫯", "()Lcom/qcl/vh/a/c/if;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.A.C.If> (JNIEnv.CallObjectMethod  (Handle, id_櫯), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_鷭;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.c']/class[@name='櫯']/method[@name='鷭' and count(parameter)=0]"
		[Register ("鷭", "()Lcom/qcl/vh/a/c/If;", "")]
		public unsafe global::Com.Qcl.VH.A.C.If 鷭 ()
		{
			if (id_鷭 == IntPtr.Zero)
				id_鷭 = JNIEnv.GetMethodID (class_ref, "鷭", "()Lcom/qcl/vh/a/c/If;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.A.C.If> (JNIEnv.CallObjectMethod  (Handle, id_鷭), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_鷭_Lcom_qcl_vh_a_c_If_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.c']/class[@name='櫯']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='com.qcl.vh.a.c.If']]"
		[Register ("鷭", "(Lcom/qcl/vh/a/c/If;)V", "")]
		public unsafe void 鷭 (global::Com.Qcl.VH.A.C.If p0)
		{
			if (id_鷭_Lcom_qcl_vh_a_c_If_ == IntPtr.Zero)
				id_鷭_Lcom_qcl_vh_a_c_If_ = JNIEnv.GetMethodID (class_ref, "鷭", "(Lcom/qcl/vh/a/c/If;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_鷭_Lcom_qcl_vh_a_c_If_, __args);
			} finally {
			}
		}

		static IntPtr id_鷭_Lcom_qcl_vh_a_c_cON_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.c']/class[@name='櫯']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='com.qcl.vh.a.c.cON']]"
		[Register ("鷭", "(Lcom/qcl/vh/a/c/cON;)V", "")]
		public unsafe void 鷭 (global::Com.Qcl.VH.A.C.CON p0)
		{
			if (id_鷭_Lcom_qcl_vh_a_c_cON_ == IntPtr.Zero)
				id_鷭_Lcom_qcl_vh_a_c_cON_ = JNIEnv.GetMethodID (class_ref, "鷭", "(Lcom/qcl/vh/a/c/cON;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_鷭_Lcom_qcl_vh_a_c_cON_, __args);
			} finally {
			}
		}

		static IntPtr id_鷭_Lcom_qcl_vh_a_c_if_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.c']/class[@name='櫯']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='com.qcl.vh.a.c.if']]"
		[Register ("鷭", "(Lcom/qcl/vh/a/c/if;)V", "")]
		public unsafe void 鷭 (global::Com.Qcl.VH.A.C.If p0)
		{
			if (id_鷭_Lcom_qcl_vh_a_c_if_ == IntPtr.Zero)
				id_鷭_Lcom_qcl_vh_a_c_if_ = JNIEnv.GetMethodID (class_ref, "鷭", "(Lcom/qcl/vh/a/c/if;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_鷭_Lcom_qcl_vh_a_c_if_, __args);
			} finally {
			}
		}

		static IntPtr id_鷭_Lcom_qcl_vh_a_e_If_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.c']/class[@name='櫯']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='com.qcl.vh.a.e.If']]"
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

		static IntPtr id_鷭_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.c']/class[@name='櫯']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
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

	}
}
