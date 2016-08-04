using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.Utility {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.utility']/class[@name='ˮ͈']"
	[global::Android.Runtime.Register ("com/qcl/vh/utility/ˮ͈", DoNotGenerateAcw=true)]
	public partial class ˮ͈ : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.utility']/class[@name='ˮ͈.if']"
		[global::Android.Runtime.Register ("com/qcl/vh/utility/ˮ͈$if", DoNotGenerateAcw=true)]
		public sealed partial class If : global::Java.Lang.Enum {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/qcl/vh/utility/ˮ͈$if", ref java_class_handle);
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.utility']/class[@name='ˮ͈.if']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/qcl/vh/utility/ˮ͈$if;", "")]
			public static unsafe global::Com.Qcl.VH.Utility.ˮ͈.If ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/qcl/vh/utility/ˮ͈$if;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Qcl.VH.Utility.ˮ͈.If __ret = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Utility.ˮ͈.If> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.utility']/class[@name='ˮ͈.if']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/qcl/vh/utility/ˮ͈$if;", "")]
			public static unsafe global::Com.Qcl.VH.Utility.ˮ͈.If[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/qcl/vh/utility/ˮ͈$if;");
				try {
					return (global::Com.Qcl.VH.Utility.ˮ͈.If[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Qcl.VH.Utility.ˮ͈.If));
				} finally {
				}
			}

			static IntPtr id_櫯_Landroid_content_Context_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.utility']/class[@name='ˮ͈.if']/method[@name='櫯' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
			[Register ("櫯", "(Landroid/content/Context;)Ljava/lang/String;", "")]
			public unsafe string 櫯 (global::Android.Content.Context p0)
			{
				if (id_櫯_Landroid_content_Context_ == IntPtr.Zero)
					id_櫯_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "櫯", "(Landroid/content/Context;)Ljava/lang/String;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_櫯_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static IntPtr id_鷭_Landroid_content_Context_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.utility']/class[@name='ˮ͈.if']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
			[Register ("鷭", "(Landroid/content/Context;)Ljava/lang/String;", "")]
			public unsafe string 鷭 (global::Android.Content.Context p0)
			{
				if (id_鷭_Landroid_content_Context_ == IntPtr.Zero)
					id_鷭_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "鷭", "(Landroid/content/Context;)Ljava/lang/String;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_鷭_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.utility']/class[@name='ˮ͈.鷭']"
		[global::Android.Runtime.Register ("com/qcl/vh/utility/ˮ͈$鷭", DoNotGenerateAcw=true)]
		public sealed partial class 鷭 : global::Java.Lang.Enum {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/qcl/vh/utility/ˮ͈$鷭", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (鷭); }
			}

			internal 鷭 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.utility']/class[@name='ˮ͈.鷭']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/qcl/vh/utility/ˮ͈$鷭;", "")]
			public static unsafe global::Com.Qcl.VH.Utility.ˮ͈.鷭 ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/qcl/vh/utility/ˮ͈$鷭;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Qcl.VH.Utility.ˮ͈.鷭 __ret = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Utility.ˮ͈.鷭> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.utility']/class[@name='ˮ͈.鷭']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/qcl/vh/utility/ˮ͈$鷭;", "")]
			public static unsafe global::Com.Qcl.VH.Utility.ˮ͈.鷭[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/qcl/vh/utility/ˮ͈$鷭;");
				try {
					return (global::Com.Qcl.VH.Utility.ˮ͈.鷭[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Qcl.VH.Utility.ˮ͈.鷭));
				} finally {
				}
			}

			static IntPtr id_櫯;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.utility']/class[@name='ˮ͈.鷭']/method[@name='櫯' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.utility']/class[@name='ˮ͈.鷭']/method[@name='鷭' and count(parameter)=0]"
			[Register ("鷭", "()I", "")]
			public unsafe int Invoke鷭 ()
			{
				if (id_鷭 == IntPtr.Zero)
					id_鷭 = JNIEnv.GetMethodID (class_ref, "鷭", "()I");
				try {
					return JNIEnv.CallIntMethod  (Handle, id_鷭);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qcl/vh/utility/ˮ͈", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ˮ͈); }
		}

		protected ˮ͈ (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.utility']/class[@name='ˮ͈']/constructor[@name='ˮ͈' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ˮ͈ ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ˮ͈)) {
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

		static IntPtr id_鷭_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.utility']/class[@name='ˮ͈']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("鷭", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string Invoke鷭 (global::Android.Content.Context p0)
		{
			if (id_鷭_Landroid_content_Context_ == IntPtr.Zero)
				id_鷭_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "鷭", "(Landroid/content/Context;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_鷭_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
