using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.Utility {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.utility']/class[@name='if']"
	[global::Android.Runtime.Register ("com/qcl/vh/utility/if", DoNotGenerateAcw=true)]
	public sealed partial class If : global::Java.Lang.Object, global::Com.Qcl.VH.A.D.Ą.I鷭 {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qcl/vh/utility/if", ref java_class_handle);
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.utility']/class[@name='if']/constructor[@name='if' and count(parameter)=0]"
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

		static IntPtr id_ctor_Lcom_qcl_vh_a_b_纫_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.utility']/class[@name='if']/constructor[@name='if' and count(parameter)=1 and parameter[1][@type='com.qcl.vh.a.b.纫']]"
		[Register (".ctor", "(Lcom/qcl/vh/a/b/纫;)V", "")]
		public unsafe If (global::Com.Qcl.VH.A.B.纫 p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (If)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/qcl/vh/a/b/纫;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/qcl/vh/a/b/纫;)V", __args);
					return;
				}

				if (id_ctor_Lcom_qcl_vh_a_b_纫_ == IntPtr.Zero)
					id_ctor_Lcom_qcl_vh_a_b_纫_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/qcl/vh/a/b/纫;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_qcl_vh_a_b_纫_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_qcl_vh_a_b_纫_, __args);
			} finally {
			}
		}

		static IntPtr id_櫯_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.utility']/class[@name='if']/method[@name='櫯' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("櫯", "([B)[Ljava/lang/String;", "")]
		public static unsafe string[] 櫯 (byte[] p0)
		{
			if (id_櫯_arrayB == IntPtr.Zero)
				id_櫯_arrayB = JNIEnv.GetStaticMethodID (class_ref, "櫯", "([B)[Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string[] __ret = (string[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_櫯_arrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (string));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_鷭_Landroid_database_Cursor_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.utility']/class[@name='if']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='android.database.Cursor']]"
		[Register ("鷭", "(Landroid/database/Cursor;)Lcom/qcl/vh/a/c/廅;", "")]
		public static unsafe global::Com.Qcl.VH.A.C.廅 鷭 (global::Android.Database.ICursor p0)
		{
			if (id_鷭_Landroid_database_Cursor_ == IntPtr.Zero)
				id_鷭_Landroid_database_Cursor_ = JNIEnv.GetStaticMethodID (class_ref, "鷭", "(Landroid/database/Cursor;)Lcom/qcl/vh/a/c/廅;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Qcl.VH.A.C.廅 __ret = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.A.C.廅> (JNIEnv.CallStaticObjectMethod  (class_ref, id_鷭_Landroid_database_Cursor_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_鷭_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.utility']/class[@name='if']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='byte[]']]"
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

		static IntPtr id_鷭_arrayBI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.utility']/class[@name='if']/method[@name='鷭' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("鷭", "([BI)I", "")]
		public static unsafe int 鷭 (byte[] p0, int p1)
		{
			if (id_鷭_arrayBI == IntPtr.Zero)
				id_鷭_arrayBI = JNIEnv.GetStaticMethodID (class_ref, "鷭", "([BI)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_鷭_arrayBI, __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_鷭_arrayBIIZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.utility']/class[@name='if']/method[@name='鷭' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='boolean']]"
		[Register ("鷭", "([BIIZ)I", "")]
		public static unsafe int 鷭 (byte[] p0, int p1, int p2, bool p3)
		{
			if (id_鷭_arrayBIIZ == IntPtr.Zero)
				id_鷭_arrayBIIZ = JNIEnv.GetStaticMethodID (class_ref, "鷭", "([BIIZ)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_鷭_arrayBIIZ, __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_鷭_arrayBLjava_nio_ByteOrder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.utility']/class[@name='if']/method[@name='鷭' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='java.nio.ByteOrder']]"
		[Register ("鷭", "([BLjava/nio/ByteOrder;)I", "")]
		public static unsafe int 鷭 (byte[] p0, global::Java.Nio.ByteOrder p1)
		{
			if (id_鷭_arrayBLjava_nio_ByteOrder_ == IntPtr.Zero)
				id_鷭_arrayBLjava_nio_ByteOrder_ = JNIEnv.GetStaticMethodID (class_ref, "鷭", "([BLjava/nio/ByteOrder;)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_鷭_arrayBLjava_nio_ByteOrder_, __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_鷭_Lcom_qcl_vh_a_c_廅_Landroid_content_ContentValues_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.utility']/class[@name='if']/method[@name='鷭' and count(parameter)=2 and parameter[1][@type='com.qcl.vh.a.c.廅'] and parameter[2][@type='android.content.ContentValues']]"
		[Register ("鷭", "(Lcom/qcl/vh/a/c/廅;Landroid/content/ContentValues;)V", "")]
		public static unsafe void 鷭 (global::Com.Qcl.VH.A.C.廅 p0, global::Android.Content.ContentValues p1)
		{
			if (id_鷭_Lcom_qcl_vh_a_c_廅_Landroid_content_ContentValues_ == IntPtr.Zero)
				id_鷭_Lcom_qcl_vh_a_c_廅_Landroid_content_ContentValues_ = JNIEnv.GetStaticMethodID (class_ref, "鷭", "(Lcom/qcl/vh/a/c/廅;Landroid/content/ContentValues;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_鷭_Lcom_qcl_vh_a_c_廅_Landroid_content_ContentValues_, __args);
			} finally {
			}
		}

		static IntPtr id_鷭_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.utility']/class[@name='if']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("鷭", "(Ljava/lang/String;)[B", "")]
		public static unsafe byte[] 鷭 (string p0)
		{
			if (id_鷭_Ljava_lang_String_ == IntPtr.Zero)
				id_鷭_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "鷭", "(Ljava/lang/String;)[B");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_鷭_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// This method is explicitly implemented as a member of an instantiated Com.Qcl.VH.A.D.Ą.I鷭
		global::Java.Lang.Object global::Com.Qcl.VH.A.D.Ą.I鷭.鷭 (global::System.IO.Stream p0)
		{
			return global::Java.Interop.JavaObjectExtensions.JavaCast<Java.Lang.Object>(鷭 (p0));
		}

	}
}
