using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.Content {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='if']"
	[global::Android.Runtime.Register ("com/qcl/vh/content/if", DoNotGenerateAcw=true)]
	public sealed partial class If : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qcl/vh/content/if", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (If); }
		}

		internal If (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='if']/constructor[@name='if' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe If (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (If)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_ˮ͈_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='if']/method[@name='ˮ͈' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("ˮ͈", "(J)Ljava/util/Set;", "")]
		public unsafe global::System.Collections.Generic.ICollection<global::Com.Qcl.VH.Content.Ȃ> ˮ͈ (long p0)
		{
			if (id_ˮ͈_J == IntPtr.Zero)
				id_ˮ͈_J = JNIEnv.GetMethodID (class_ref, "ˮ͈", "(J)Ljava/util/Set;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Android.Runtime.JavaSet<global::Com.Qcl.VH.Content.Ȃ>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_ˮ͈_J, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_櫯;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='if']/method[@name='櫯' and count(parameter)=0]"
		[Register ("櫯", "()Ljava/util/Set;", "")]
		public unsafe global::System.Collections.Generic.ICollection<global::Com.Qcl.VH.Content.Ȃ> 櫯 ()
		{
			if (id_櫯 == IntPtr.Zero)
				id_櫯 = JNIEnv.GetMethodID (class_ref, "櫯", "()Ljava/util/Set;");
			try {
				return global::Android.Runtime.JavaSet<global::Com.Qcl.VH.Content.Ȃ>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_櫯), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_櫯_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='if']/method[@name='櫯' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("櫯", "(J)Ljava/util/Set;", "")]
		public unsafe global::System.Collections.Generic.ICollection<global::Com.Qcl.VH.Content.IF> 櫯 (long p0)
		{
			if (id_櫯_J == IntPtr.Zero)
				id_櫯_J = JNIEnv.GetMethodID (class_ref, "櫯", "(J)Ljava/util/Set;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Android.Runtime.JavaSet<global::Com.Qcl.VH.Content.IF>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_櫯_J, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_鷭;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='if']/method[@name='鷭' and count(parameter)=0]"
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

		static IntPtr id_鷭_arrayBII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='if']/method[@name='鷭' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("鷭", "([BII)Landroid/net/Uri;", "")]
		public unsafe global::Android.Net.Uri 鷭 (byte[] p0, int p1, int p2)
		{
			if (id_鷭_arrayBII == IntPtr.Zero)
				id_鷭_arrayBII = JNIEnv.GetMethodID (class_ref, "鷭", "([BII)Landroid/net/Uri;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::Android.Net.Uri __ret = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallObjectMethod  (Handle, id_鷭_arrayBII, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_鷭_Lcom_qcl_vh_a_c_auX_arrayBLjava_lang_String_JI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='if']/method[@name='鷭' and count(parameter)=5 and parameter[1][@type='com.qcl.vh.a.c.auX'] and parameter[2][@type='byte[]'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='long'] and parameter[5][@type='int']]"
		[Register ("鷭", "(Lcom/qcl/vh/a/c/auX;[BLjava/lang/String;JI)Landroid/net/Uri;", "")]
		public unsafe global::Android.Net.Uri 鷭 (global::Com.Qcl.VH.A.C.AuX p0, byte[] p1, string p2, long p3, int p4)
		{
			if (id_鷭_Lcom_qcl_vh_a_c_auX_arrayBLjava_lang_String_JI == IntPtr.Zero)
				id_鷭_Lcom_qcl_vh_a_c_auX_arrayBLjava_lang_String_JI = JNIEnv.GetMethodID (class_ref, "鷭", "(Lcom/qcl/vh/a/c/auX;[BLjava/lang/String;JI)Landroid/net/Uri;");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				global::Android.Net.Uri __ret = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallObjectMethod  (Handle, id_鷭_Lcom_qcl_vh_a_c_auX_arrayBLjava_lang_String_JI, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_鷭_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='if']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("鷭", "(J)I", "")]
		public unsafe int 鷭 (long p0)
		{
			if (id_鷭_J == IntPtr.Zero)
				id_鷭_J = JNIEnv.GetMethodID (class_ref, "鷭", "(J)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallIntMethod  (Handle, id_鷭_J, __args);
			} finally {
			}
		}

	}
}
