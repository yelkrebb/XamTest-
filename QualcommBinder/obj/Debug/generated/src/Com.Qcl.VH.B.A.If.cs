using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.B.A {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.b.a']/class[@name='if']"
	[global::Android.Runtime.Register ("com/qcl/vh/b/a/if", DoNotGenerateAcw=true)]
	public sealed partial class If : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qcl/vh/b/a/if", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (If); }
		}

		internal If (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_ILcom_qcl_vh_content_a_櫯_IJ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.b.a']/class[@name='if']/constructor[@name='if' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='com.qcl.vh.content.a.櫯'] and parameter[3][@type='int'] and parameter[4][@type='long']]"
		[Register (".ctor", "(ILcom/qcl/vh/content/a/櫯;IJ)V", "")]
		public unsafe If (int p0, global::Com.Qcl.VH.Content.A.櫯 p1, int p2, long p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				if (GetType () != typeof (If)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(ILcom/qcl/vh/content/a/櫯;IJ)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(ILcom/qcl/vh/content/a/櫯;IJ)V", __args);
					return;
				}

				if (id_ctor_ILcom_qcl_vh_content_a_櫯_IJ == IntPtr.Zero)
					id_ctor_ILcom_qcl_vh_content_a_櫯_IJ = JNIEnv.GetMethodID (class_ref, "<init>", "(ILcom/qcl/vh/content/a/櫯;IJ)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_ILcom_qcl_vh_content_a_櫯_IJ, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_ILcom_qcl_vh_content_a_櫯_IJ, __args);
			} finally {
			}
		}

		static IntPtr id_Ą;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.b.a']/class[@name='if']/method[@name='Ą' and count(parameter)=0]"
		[Register ("Ą", "()I", "")]
		public unsafe int Ą ()
		{
			if (id_Ą == IntPtr.Zero)
				id_Ą = JNIEnv.GetMethodID (class_ref, "Ą", "()I");
			try {
				return JNIEnv.CallIntMethod  (Handle, id_Ą);
			} finally {
			}
		}

		static IntPtr id_ą;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.b.a']/class[@name='if']/method[@name='ą' and count(parameter)=0]"
		[Register ("ą", "()Lcom/qcl/vh/content/a/If;", "")]
		public unsafe global::Com.Qcl.VH.Content.A.If Ą ()
		{
			if (id_ą == IntPtr.Zero)
				id_ą = JNIEnv.GetMethodID (class_ref, "ą", "()Lcom/qcl/vh/content/a/If;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.A.If> (JNIEnv.CallObjectMethod  (Handle, id_ą), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_Ć;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.b.a']/class[@name='if']/method[@name='Ć' and count(parameter)=0]"
		[Register ("Ć", "()Ljava/lang/String;", "")]
		public unsafe string Ć ()
		{
			if (id_Ć == IntPtr.Zero)
				id_Ć = JNIEnv.GetMethodID (class_ref, "Ć", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_Ć), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_ć;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.b.a']/class[@name='if']/method[@name='ć' and count(parameter)=0]"
		[Register ("ć", "()Ljava/lang/String;", "")]
		public unsafe string Ć ()
		{
			if (id_ć == IntPtr.Zero)
				id_ć = JNIEnv.GetMethodID (class_ref, "ć", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_ć), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_ȃ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.b.a']/class[@name='if']/method[@name='ȃ' and count(parameter)=0]"
		[Register ("ȃ", "()[B", "")]
		public unsafe byte[] Ȃ ()
		{
			if (id_ȃ == IntPtr.Zero)
				id_ȃ = JNIEnv.GetMethodID (class_ref, "ȃ", "()[B");
			try {
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_ȃ), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static IntPtr id_ˮ͈;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.b.a']/class[@name='if']/method[@name='ˮ͈' and count(parameter)=0]"
		[Register ("ˮ͈", "()Lcom/qcl/vh/content/a/櫯;", "")]
		public unsafe global::Com.Qcl.VH.Content.A.櫯 ˮ͈ ()
		{
			if (id_ˮ͈ == IntPtr.Zero)
				id_ˮ͈ = JNIEnv.GetMethodID (class_ref, "ˮ͈", "()Lcom/qcl/vh/content/a/櫯;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.A.櫯> (JNIEnv.CallObjectMethod  (Handle, id_ˮ͈), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_ˮ͈_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.b.a']/class[@name='if']/method[@name='ˮ͈' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("ˮ͈", "(J)V", "")]
		public unsafe void ˮ͈ (long p0)
		{
			if (id_ˮ͈_J == IntPtr.Zero)
				id_ˮ͈_J = JNIEnv.GetMethodID (class_ref, "ˮ͈", "(J)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_ˮ͈_J, __args);
			} finally {
			}
		}

		static IntPtr id_櫯;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.b.a']/class[@name='if']/method[@name='櫯' and count(parameter)=0]"
		[Register ("櫯", "()J", "")]
		public unsafe long 櫯 ()
		{
			if (id_櫯 == IntPtr.Zero)
				id_櫯 = JNIEnv.GetMethodID (class_ref, "櫯", "()J");
			try {
				return JNIEnv.CallLongMethod  (Handle, id_櫯);
			} finally {
			}
		}

		static IntPtr id_櫯_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.b.a']/class[@name='if']/method[@name='櫯' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("櫯", "(I)V", "")]
		public unsafe void 櫯 (int p0)
		{
			if (id_櫯_I == IntPtr.Zero)
				id_櫯_I = JNIEnv.GetMethodID (class_ref, "櫯", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_櫯_I, __args);
			} finally {
			}
		}

		static IntPtr id_櫯_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.b.a']/class[@name='if']/method[@name='櫯' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("櫯", "(Ljava/lang/String;)V", "")]
		public unsafe void 櫯 (string p0)
		{
			if (id_櫯_Ljava_lang_String_ == IntPtr.Zero)
				id_櫯_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "櫯", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod  (Handle, id_櫯_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_櫯_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.b.a']/class[@name='if']/method[@name='櫯' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("櫯", "(J)V", "")]
		public unsafe void 櫯 (long p0)
		{
			if (id_櫯_J == IntPtr.Zero)
				id_櫯_J = JNIEnv.GetMethodID (class_ref, "櫯", "(J)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_櫯_J, __args);
			} finally {
			}
		}

		static IntPtr id_鷭;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.b.a']/class[@name='if']/method[@name='鷭' and count(parameter)=0]"
		[Register ("鷭", "()I", "")]
		public unsafe int 鷭 ()
		{
			if (id_鷭 == IntPtr.Zero)
				id_鷭 = JNIEnv.GetMethodID (class_ref, "鷭", "()I");
			try {
				return JNIEnv.CallIntMethod  (Handle, id_鷭);
			} finally {
			}
		}

		static IntPtr id_鷭_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.b.a']/class[@name='if']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("鷭", "([B)V", "")]
		public unsafe void 鷭 (byte[] p0)
		{
			if (id_鷭_arrayB == IntPtr.Zero)
				id_鷭_arrayB = JNIEnv.GetMethodID (class_ref, "鷭", "([B)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod  (Handle, id_鷭_arrayB, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_鷭_Lcom_qcl_vh_content_a_If_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.b.a']/class[@name='if']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='com.qcl.vh.content.a.If']]"
		[Register ("鷭", "(Lcom/qcl/vh/content/a/If;)V", "")]
		public unsafe void 鷭 (global::Com.Qcl.VH.Content.A.If p0)
		{
			if (id_鷭_Lcom_qcl_vh_content_a_If_ == IntPtr.Zero)
				id_鷭_Lcom_qcl_vh_content_a_If_ = JNIEnv.GetMethodID (class_ref, "鷭", "(Lcom/qcl/vh/content/a/If;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_鷭_Lcom_qcl_vh_content_a_If_, __args);
			} finally {
			}
		}

		static IntPtr id_鷭_Lcom_qcl_vh_content_a_櫯_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.b.a']/class[@name='if']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='com.qcl.vh.content.a.櫯']]"
		[Register ("鷭", "(Lcom/qcl/vh/content/a/櫯;)V", "")]
		public unsafe void 鷭 (global::Com.Qcl.VH.Content.A.櫯 p0)
		{
			if (id_鷭_Lcom_qcl_vh_content_a_櫯_ == IntPtr.Zero)
				id_鷭_Lcom_qcl_vh_content_a_櫯_ = JNIEnv.GetMethodID (class_ref, "鷭", "(Lcom/qcl/vh/content/a/櫯;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_鷭_Lcom_qcl_vh_content_a_櫯_, __args);
			} finally {
			}
		}

		static IntPtr id_鷭_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.b.a']/class[@name='if']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("鷭", "(I)V", "")]
		public unsafe void 鷭 (int p0)
		{
			if (id_鷭_I == IntPtr.Zero)
				id_鷭_I = JNIEnv.GetMethodID (class_ref, "鷭", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_鷭_I, __args);
			} finally {
			}
		}

		static IntPtr id_鷭_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.b.a']/class[@name='if']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static IntPtr id_鷭_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.b.a']/class[@name='if']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("鷭", "(J)V", "")]
		public unsafe void 鷭 (long p0)
		{
			if (id_鷭_J == IntPtr.Zero)
				id_鷭_J = JNIEnv.GetMethodID (class_ref, "鷭", "(J)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_鷭_J, __args);
			} finally {
			}
		}

	}
}
