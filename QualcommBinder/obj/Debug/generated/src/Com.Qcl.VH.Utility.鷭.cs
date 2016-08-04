using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.Utility {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.utility']/class[@name='鷭']"
	[global::Android.Runtime.Register ("com/qcl/vh/utility/鷭", DoNotGenerateAcw=true)]
	public sealed partial class 鷭 : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.utility']/class[@name='鷭.鷭']"
		[global::Android.Runtime.Register ("com/qcl/vh/utility/鷭$鷭", DoNotGenerateAcw=true)]
		public partial class 鷭 : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/qcl/vh/utility/鷭$鷭", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (鷭); }
			}

			protected 鷭 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.utility']/class[@name='鷭.鷭']/constructor[@name='鷭.鷭' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe 鷭 ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (鷭)) {
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

			static IntPtr id_toString;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.utility']/class[@name='鷭.鷭']/method[@name='toString' and count(parameter)=0]"
			[Register ("toString", "()Ljava/lang/String;", "")]
			public override sealed unsafe string ToString ()
			{
				if (id_toString == IntPtr.Zero)
					id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_toString), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_櫯;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.utility']/class[@name='鷭.鷭']/method[@name='櫯' and count(parameter)=0]"
			[Register ("櫯", "()V", "")]
			public unsafe void 櫯 ()
			{
				if (id_櫯 == IntPtr.Zero)
					id_櫯 = JNIEnv.GetMethodID (class_ref, "櫯", "()V");
				try {
					JNIEnv.CallVoidMethod  (Handle, id_櫯);
				} finally {
				}
			}

			static IntPtr id_鷭;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.utility']/class[@name='鷭.鷭']/method[@name='鷭' and count(parameter)=0]"
			[Register ("鷭", "()V", "")]
			public unsafe void Invoke鷭 ()
			{
				if (id_鷭 == IntPtr.Zero)
					id_鷭 = JNIEnv.GetMethodID (class_ref, "鷭", "()V");
				try {
					JNIEnv.CallVoidMethod  (Handle, id_鷭);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qcl/vh/utility/鷭", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (鷭); }
		}

		internal 鷭 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.utility']/class[@name='鷭']/constructor[@name='鷭' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe 鷭 ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (鷭)) {
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

		static IntPtr id_鷭_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.utility']/class[@name='鷭']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("鷭", "(Ljava/lang/String;)Lcom/qcl/vh/utility/鷭$鷭;", "")]
		public static unsafe global::Com.Qcl.VH.Utility.鷭.鷭 Invoke鷭 (string p0)
		{
			if (id_鷭_Ljava_lang_String_ == IntPtr.Zero)
				id_鷭_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "鷭", "(Ljava/lang/String;)Lcom/qcl/vh/utility/鷭$鷭;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Qcl.VH.Utility.鷭.鷭 __ret = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Utility.鷭.鷭> (JNIEnv.CallStaticObjectMethod  (class_ref, id_鷭_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_鷭_Ljava_lang_String_Lcom_qcl_vh_utility_鷭_鷭_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.utility']/class[@name='鷭']/method[@name='鷭' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.qcl.vh.utility.鷭.鷭']]"
		[Register ("鷭", "(Ljava/lang/String;Lcom/qcl/vh/utility/鷭$鷭;)V", "")]
		public static unsafe void Invoke鷭 (string p0, global::Com.Qcl.VH.Utility.鷭.鷭 p1)
		{
			if (id_鷭_Ljava_lang_String_Lcom_qcl_vh_utility_鷭_鷭_ == IntPtr.Zero)
				id_鷭_Ljava_lang_String_Lcom_qcl_vh_utility_鷭_鷭_ = JNIEnv.GetStaticMethodID (class_ref, "鷭", "(Ljava/lang/String;Lcom/qcl/vh/utility/鷭$鷭;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_鷭_Ljava_lang_String_Lcom_qcl_vh_utility_鷭_鷭_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
