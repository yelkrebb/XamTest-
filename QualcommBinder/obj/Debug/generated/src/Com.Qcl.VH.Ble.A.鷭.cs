using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.Ble.A {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.ble.a']/class[@name='鷭']"
	[global::Android.Runtime.Register ("com/qcl/vh/ble/a/鷭", DoNotGenerateAcw=true)]
	public partial class 鷭 : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qcl/vh/ble/a/鷭", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (鷭); }
		}

		protected 鷭 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_鷭;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble.a']/class[@name='鷭']/method[@name='鷭' and count(parameter)=0]"
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

		static IntPtr id_鷭_Landroid_bluetooth_BluetoothManager_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble.a']/class[@name='鷭']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='android.bluetooth.BluetoothManager']]"
		[Register ("鷭", "(Landroid/bluetooth/BluetoothManager;)Z", "")]
		public unsafe bool Invoke鷭 (global::Android.Bluetooth.BluetoothManager p0)
		{
			if (id_鷭_Landroid_bluetooth_BluetoothManager_ == IntPtr.Zero)
				id_鷭_Landroid_bluetooth_BluetoothManager_ = JNIEnv.GetMethodID (class_ref, "鷭", "(Landroid/bluetooth/BluetoothManager;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_鷭_Landroid_bluetooth_BluetoothManager_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_鷭_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble.a']/class[@name='鷭']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("鷭", "(Landroid/content/Context;)Lcom/qcl/vh/ble/a/鷭;", "")]
		public static unsafe global::Com.Qcl.VH.Ble.A.鷭 Invoke鷭 (global::Android.Content.Context p0)
		{
			if (id_鷭_Landroid_content_Context_ == IntPtr.Zero)
				id_鷭_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "鷭", "(Landroid/content/Context;)Lcom/qcl/vh/ble/a/鷭;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Qcl.VH.Ble.A.鷭 __ret = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Ble.A.鷭> (JNIEnv.CallStaticObjectMethod  (class_ref, id_鷭_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
