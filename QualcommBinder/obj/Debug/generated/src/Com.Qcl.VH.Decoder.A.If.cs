using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.Decoder.A {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.decoder.a']/class[@name='If']"
	[global::Android.Runtime.Register ("com/qcl/vh/decoder/a/If", DoNotGenerateAcw=true)]
	public sealed partial class If : global::Java.Lang.Enum {


		static IntPtr 鷭_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.decoder.a']/class[@name='If']/field[@name='鷭']"
		[Register ("鷭")]
		public static global::Com.Qcl.VH.Decoder.A.If 鷭 {
			get {
				if (鷭_jfieldId == IntPtr.Zero)
					鷭_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "鷭", "Lcom/qcl/vh/decoder/a/If;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, 鷭_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Decoder.A.If> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qcl/vh/decoder/a/If", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (If); }
		}

		internal If (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.decoder.a']/class[@name='If']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/qcl/vh/decoder/a/If;", "")]
		public static unsafe global::Com.Qcl.VH.Decoder.A.If ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/qcl/vh/decoder/a/If;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Qcl.VH.Decoder.A.If __ret = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Decoder.A.If> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.decoder.a']/class[@name='If']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/qcl/vh/decoder/a/If;", "")]
		public static unsafe global::Com.Qcl.VH.Decoder.A.If[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/qcl/vh/decoder/a/If;");
			try {
				return (global::Com.Qcl.VH.Decoder.A.If[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Qcl.VH.Decoder.A.If));
			} finally {
			}
		}

	}
}
