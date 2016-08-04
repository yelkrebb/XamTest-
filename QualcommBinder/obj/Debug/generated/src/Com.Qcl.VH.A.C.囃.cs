using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.A.C {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.a.c']/class[@name='囃']"
	[global::Android.Runtime.Register ("com/qcl/vh/a/c/囃", DoNotGenerateAcw=true)]
	public partial class 囃 : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qcl/vh/a/c/囃", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (囃); }
		}

		protected 囃 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.a.c']/class[@name='囃']/constructor[@name='囃' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe 囃 ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (囃)) {
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.c']/class[@name='囃']/method[@name='Ą' and count(parameter)=0]"
		[Register ("Ą", "()Ljava/lang/Integer;", "")]
		public unsafe global::Java.Lang.Integer Ą ()
		{
			if (id_Ą == IntPtr.Zero)
				id_Ą = JNIEnv.GetMethodID (class_ref, "Ą", "()Ljava/lang/Integer;");
			try {
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod  (Handle, id_Ą), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_Ą_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.c']/class[@name='囃']/method[@name='Ą' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
		[Register ("Ą", "(Ljava/lang/Integer;)V", "")]
		public unsafe void Ą (global::Java.Lang.Integer p0)
		{
			if (id_Ą_Ljava_lang_Integer_ == IntPtr.Zero)
				id_Ą_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "Ą", "(Ljava/lang/Integer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_Ą_Ljava_lang_Integer_, __args);
			} finally {
			}
		}

		static IntPtr id_ą;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.c']/class[@name='囃']/method[@name='ą' and count(parameter)=0]"
		[Register ("ą", "()Ljava/lang/Integer;", "")]
		public unsafe global::Java.Lang.Integer Ą ()
		{
			if (id_ą == IntPtr.Zero)
				id_ą = JNIEnv.GetMethodID (class_ref, "ą", "()Ljava/lang/Integer;");
			try {
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod  (Handle, id_ą), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_Ć;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.c']/class[@name='囃']/method[@name='Ć' and count(parameter)=0]"
		[Register ("Ć", "()Ljava/lang/Boolean;", "")]
		public unsafe global::Java.Lang.Boolean Ć ()
		{
			if (id_Ć == IntPtr.Zero)
				id_Ć = JNIEnv.GetMethodID (class_ref, "Ć", "()Ljava/lang/Boolean;");
			try {
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallObjectMethod  (Handle, id_Ć), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_ć;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.c']/class[@name='囃']/method[@name='ć' and count(parameter)=0]"
		[Register ("ć", "()Ljava/lang/Integer;", "")]
		public unsafe global::Java.Lang.Integer Ć ()
		{
			if (id_ć == IntPtr.Zero)
				id_ć = JNIEnv.GetMethodID (class_ref, "ć", "()Ljava/lang/Integer;");
			try {
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod  (Handle, id_ć), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_ȃ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.c']/class[@name='囃']/method[@name='ȃ' and count(parameter)=0]"
		[Register ("ȃ", "()Ljava/lang/Integer;", "")]
		public unsafe global::Java.Lang.Integer Ȃ ()
		{
			if (id_ȃ == IntPtr.Zero)
				id_ȃ = JNIEnv.GetMethodID (class_ref, "ȃ", "()Ljava/lang/Integer;");
			try {
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod  (Handle, id_ȃ), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_ȃ_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.c']/class[@name='囃']/method[@name='ȃ' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
		[Register ("ȃ", "(Ljava/lang/Integer;)V", "")]
		public unsafe void Ȃ (global::Java.Lang.Integer p0)
		{
			if (id_ȃ_Ljava_lang_Integer_ == IntPtr.Zero)
				id_ȃ_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "ȃ", "(Ljava/lang/Integer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_ȃ_Ljava_lang_Integer_, __args);
			} finally {
			}
		}

		static IntPtr id_ˮ͈;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.c']/class[@name='囃']/method[@name='ˮ͈' and count(parameter)=0]"
		[Register ("ˮ͈", "()Lcom/qcl/vh/a/e/If;", "")]
		public unsafe global::Com.Qcl.VH.A.E.If ˮ͈ ()
		{
			if (id_ˮ͈ == IntPtr.Zero)
				id_ˮ͈ = JNIEnv.GetMethodID (class_ref, "ˮ͈", "()Lcom/qcl/vh/a/e/If;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.A.E.If> (JNIEnv.CallObjectMethod  (Handle, id_ˮ͈), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_ˮ͈_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.c']/class[@name='囃']/method[@name='ˮ͈' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
		[Register ("ˮ͈", "(Ljava/lang/Integer;)V", "")]
		public unsafe void ˮ͈ (global::Java.Lang.Integer p0)
		{
			if (id_ˮ͈_Ljava_lang_Integer_ == IntPtr.Zero)
				id_ˮ͈_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "ˮ͈", "(Ljava/lang/Integer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_ˮ͈_Ljava_lang_Integer_, __args);
			} finally {
			}
		}

		static IntPtr id_櫯;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.c']/class[@name='囃']/method[@name='櫯' and count(parameter)=0]"
		[Register ("櫯", "()Lcom/qcl/vh/a/e/If;", "")]
		public unsafe global::Com.Qcl.VH.A.E.If 櫯 ()
		{
			if (id_櫯 == IntPtr.Zero)
				id_櫯 = JNIEnv.GetMethodID (class_ref, "櫯", "()Lcom/qcl/vh/a/e/If;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.A.E.If> (JNIEnv.CallObjectMethod  (Handle, id_櫯), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_櫯_Lcom_qcl_vh_a_e_If_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.c']/class[@name='囃']/method[@name='櫯' and count(parameter)=1 and parameter[1][@type='com.qcl.vh.a.e.If']]"
		[Register ("櫯", "(Lcom/qcl/vh/a/e/If;)V", "")]
		public unsafe void 櫯 (global::Com.Qcl.VH.A.E.If p0)
		{
			if (id_櫯_Lcom_qcl_vh_a_e_If_ == IntPtr.Zero)
				id_櫯_Lcom_qcl_vh_a_e_If_ = JNIEnv.GetMethodID (class_ref, "櫯", "(Lcom/qcl/vh/a/e/If;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_櫯_Lcom_qcl_vh_a_e_If_, __args);
			} finally {
			}
		}

		static IntPtr id_櫯_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.c']/class[@name='囃']/method[@name='櫯' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
		[Register ("櫯", "(Ljava/lang/Integer;)V", "")]
		public unsafe void 櫯 (global::Java.Lang.Integer p0)
		{
			if (id_櫯_Ljava_lang_Integer_ == IntPtr.Zero)
				id_櫯_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "櫯", "(Ljava/lang/Integer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_櫯_Ljava_lang_Integer_, __args);
			} finally {
			}
		}

		static IntPtr id_鷭;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.c']/class[@name='囃']/method[@name='鷭' and count(parameter)=0]"
		[Register ("鷭", "()Ljava/lang/Integer;", "")]
		public unsafe global::Java.Lang.Integer 鷭 ()
		{
			if (id_鷭 == IntPtr.Zero)
				id_鷭 = JNIEnv.GetMethodID (class_ref, "鷭", "()Ljava/lang/Integer;");
			try {
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod  (Handle, id_鷭), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_鷭_Lcom_qcl_vh_a_e_If_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.c']/class[@name='囃']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='com.qcl.vh.a.e.If']]"
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

		static IntPtr id_鷭_Ljava_lang_Boolean_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.c']/class[@name='囃']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
		[Register ("鷭", "(Ljava/lang/Boolean;)V", "")]
		public unsafe void 鷭 (global::Java.Lang.Boolean p0)
		{
			if (id_鷭_Ljava_lang_Boolean_ == IntPtr.Zero)
				id_鷭_Ljava_lang_Boolean_ = JNIEnv.GetMethodID (class_ref, "鷭", "(Ljava/lang/Boolean;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_鷭_Ljava_lang_Boolean_, __args);
			} finally {
			}
		}

		static IntPtr id_鷭_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.c']/class[@name='囃']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
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
