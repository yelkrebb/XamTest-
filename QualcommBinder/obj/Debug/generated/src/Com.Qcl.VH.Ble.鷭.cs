using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.Ble {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='鷭']"
	[global::Android.Runtime.Register ("com/qcl/vh/ble/鷭", DoNotGenerateAcw=true)]
	public sealed partial class 鷭 : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='鷭.鷭']"
		[global::Android.Runtime.Register ("com/qcl/vh/ble/鷭$鷭", DoNotGenerateAcw=true)]
		public sealed partial class 鷭 : global::Java.Lang.Enum {


			static IntPtr 櫯_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='鷭.鷭']/field[@name='櫯']"
			[Register ("櫯")]
			public static global::Com.Qcl.VH.Ble.鷭.鷭 櫯 {
				get {
					if (櫯_jfieldId == IntPtr.Zero)
						櫯_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "櫯", "Lcom/qcl/vh/ble/鷭$鷭;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, 櫯_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Ble.鷭.鷭> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr 鷭_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='鷭.鷭']/field[@name='鷭']"
			[Register ("鷭")]
			public static global::Com.Qcl.VH.Ble.鷭.鷭 鷭 {
				get {
					if (鷭_jfieldId == IntPtr.Zero)
						鷭_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "鷭", "Lcom/qcl/vh/ble/鷭$鷭;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, 鷭_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Ble.鷭.鷭> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/qcl/vh/ble/鷭$鷭", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (鷭); }
			}

			internal 鷭 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qcl/vh/ble/鷭", ref java_class_handle);
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='鷭']/constructor[@name='鷭' and count(parameter)=0]"
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

	}
}
