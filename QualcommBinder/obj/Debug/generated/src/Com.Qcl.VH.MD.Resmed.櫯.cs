using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.MD.Resmed {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.md.resmed']/class[@name='櫯']"
	[global::Android.Runtime.Register ("com/qcl/vh/md/resmed/櫯", DoNotGenerateAcw=true)]
	public sealed partial class 櫯 : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qcl/vh/md/resmed/櫯", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (櫯); }
		}

		internal 櫯 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.md.resmed']/class[@name='櫯']/constructor[@name='櫯' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe 櫯 (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (櫯)) {
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

		static IntPtr id_櫯_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.resmed']/class[@name='櫯']/method[@name='櫯' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("櫯", "(Ljava/lang/String;)V", "")]
		public static unsafe void Invoke櫯 (string p0)
		{
			if (id_櫯_Ljava_lang_String_ == IntPtr.Zero)
				id_櫯_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "櫯", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_櫯_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_鷭_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.resmed']/class[@name='櫯']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("鷭", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string 鷭 (string p0)
		{
			if (id_鷭_Ljava_lang_String_ == IntPtr.Zero)
				id_鷭_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "鷭", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_鷭_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_鷭_Ljava_lang_String_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.resmed']/class[@name='櫯']/method[@name='鷭' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.List&lt;java.lang.Integer&gt;']]"
		[Register ("鷭", "(Ljava/lang/String;Ljava/util/List;)V", "")]
		public static unsafe void 鷭 (string p0, global::System.Collections.Generic.IList<global::Java.Lang.Integer> p1)
		{
			if (id_鷭_Ljava_lang_String_Ljava_util_List_ == IntPtr.Zero)
				id_鷭_Ljava_lang_String_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "鷭", "(Ljava/lang/String;Ljava/util/List;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::Java.Lang.Integer>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_鷭_Ljava_lang_String_Ljava_util_List_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
