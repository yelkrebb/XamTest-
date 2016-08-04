using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.MD.Asthmapolis {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.md.asthmapolis']/class[@name='櫯']"
	[global::Android.Runtime.Register ("com/qcl/vh/md/asthmapolis/櫯", DoNotGenerateAcw=true)]
	public abstract partial class 櫯 : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qcl/vh/md/asthmapolis/櫯", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (櫯); }
		}

		protected 櫯 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_鷭_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate Get鷭_Ljava_lang_String_Handler ()
		{
			if (cb_鷭_Ljava_lang_String_ == null)
				cb_鷭_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_鷭_Ljava_lang_String_);
			return cb_鷭_Ljava_lang_String_;
		}

		static IntPtr n_鷭_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Qcl.VH.MD.Asthmapolis.櫯 __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.MD.Asthmapolis.櫯> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.鷭 (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.asthmapolis']/class[@name='櫯']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("鷭", "(Ljava/lang/String;)Ljava/lang/String;", "Get鷭_Ljava_lang_String_Handler")]
		public abstract string 鷭 (string p0);

	}

	[global::Android.Runtime.Register ("com/qcl/vh/md/asthmapolis/櫯", DoNotGenerateAcw=true)]
	internal partial class 櫯Invoker : 櫯 {

		public 櫯Invoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (櫯Invoker); }
		}

		static IntPtr id_鷭_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.asthmapolis']/class[@name='櫯']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("鷭", "(Ljava/lang/String;)Ljava/lang/String;", "Get鷭_Ljava_lang_String_Handler")]
		public override unsafe string 鷭 (string p0)
		{
			if (id_鷭_Ljava_lang_String_ == IntPtr.Zero)
				id_鷭_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "鷭", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_鷭_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}

}
