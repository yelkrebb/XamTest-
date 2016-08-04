using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.MD.Vitalograph {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.md.vitalograph']/class[@name='櫯']"
	[global::Android.Runtime.Register ("com/qcl/vh/md/vitalograph/櫯", DoNotGenerateAcw=true)]
	public sealed partial class 櫯 : global::Java.Lang.Enum {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qcl/vh/md/vitalograph/櫯", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (櫯); }
		}

		internal 櫯 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.vitalograph']/class[@name='櫯']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/qcl/vh/md/vitalograph/櫯;", "")]
		public static unsafe global::Com.Qcl.VH.MD.Vitalograph.櫯 ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/qcl/vh/md/vitalograph/櫯;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Qcl.VH.MD.Vitalograph.櫯 __ret = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.MD.Vitalograph.櫯> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.vitalograph']/class[@name='櫯']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/qcl/vh/md/vitalograph/櫯;", "")]
		public static unsafe global::Com.Qcl.VH.MD.Vitalograph.櫯[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/qcl/vh/md/vitalograph/櫯;");
			try {
				return (global::Com.Qcl.VH.MD.Vitalograph.櫯[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Qcl.VH.MD.Vitalograph.櫯));
			} finally {
			}
		}

		static IntPtr id_ȃ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.vitalograph']/class[@name='櫯']/method[@name='ȃ' and count(parameter)=0]"
		[Register ("ȃ", "()[Lcom/qcl/vh/md/vitalograph/Ą$if;", "")]
		public unsafe global::Com.Qcl.VH.MD.Vitalograph.Ą.If[] Ȃ ()
		{
			if (id_ȃ == IntPtr.Zero)
				id_ȃ = JNIEnv.GetMethodID (class_ref, "ȃ", "()[Lcom/qcl/vh/md/vitalograph/Ą$if;");
			try {
				return (global::Com.Qcl.VH.MD.Vitalograph.Ą.If[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_ȃ), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Qcl.VH.MD.Vitalograph.Ą.If));
			} finally {
			}
		}

		static IntPtr id_ˮ͈;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.vitalograph']/class[@name='櫯']/method[@name='ˮ͈' and count(parameter)=0]"
		[Register ("ˮ͈", "()Z", "")]
		public unsafe bool ˮ͈ ()
		{
			if (id_ˮ͈ == IntPtr.Zero)
				id_ˮ͈ = JNIEnv.GetMethodID (class_ref, "ˮ͈", "()Z");
			try {
				return JNIEnv.CallBooleanMethod  (Handle, id_ˮ͈);
			} finally {
			}
		}

		static IntPtr id_櫯;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.vitalograph']/class[@name='櫯']/method[@name='櫯' and count(parameter)=0]"
		[Register ("櫯", "()B", "")]
		public unsafe sbyte Invoke櫯 ()
		{
			if (id_櫯 == IntPtr.Zero)
				id_櫯 = JNIEnv.GetMethodID (class_ref, "櫯", "()B");
			try {
				return JNIEnv.CallByteMethod  (Handle, id_櫯);
			} finally {
			}
		}

		static IntPtr id_鷭;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.vitalograph']/class[@name='櫯']/method[@name='鷭' and count(parameter)=0]"
		[Register ("鷭", "()Ljava/lang/String;", "")]
		public unsafe string 鷭 ()
		{
			if (id_鷭 == IntPtr.Zero)
				id_鷭 = JNIEnv.GetMethodID (class_ref, "鷭", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_鷭), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_鷭_Ljava_lang_Byte_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.vitalograph']/class[@name='櫯']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='java.lang.Byte']]"
		[Register ("鷭", "(Ljava/lang/Byte;)Lcom/qcl/vh/md/vitalograph/櫯;", "")]
		public static unsafe global::Com.Qcl.VH.MD.Vitalograph.櫯 鷭 (global::Java.Lang.Byte p0)
		{
			if (id_鷭_Ljava_lang_Byte_ == IntPtr.Zero)
				id_鷭_Ljava_lang_Byte_ = JNIEnv.GetStaticMethodID (class_ref, "鷭", "(Ljava/lang/Byte;)Lcom/qcl/vh/md/vitalograph/櫯;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Qcl.VH.MD.Vitalograph.櫯 __ret = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.MD.Vitalograph.櫯> (JNIEnv.CallStaticObjectMethod  (class_ref, id_鷭_Ljava_lang_Byte_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
