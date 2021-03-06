using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.MD.Vitalograph {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.md.vitalograph']/class[@name='VitalographDiscreteReadingAdapter']"
	[global::Android.Runtime.Register ("com/qcl/vh/md/vitalograph/VitalographDiscreteReadingAdapter", DoNotGenerateAcw=true)]
	public partial class VitalographDiscreteReadingAdapter : global::Java.Lang.Object, global::Com.Qcl.VH.Content.IContextAwareAdapter, global::Com.Qcl.VH.Content.IDeviceAdapter {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qcl/vh/md/vitalograph/VitalographDiscreteReadingAdapter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VitalographDiscreteReadingAdapter); }
		}

		protected VitalographDiscreteReadingAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.md.vitalograph']/class[@name='VitalographDiscreteReadingAdapter']/constructor[@name='VitalographDiscreteReadingAdapter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe VitalographDiscreteReadingAdapter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (VitalographDiscreteReadingAdapter)) {
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

		static IntPtr id_ˮ͈_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.vitalograph']/class[@name='VitalographDiscreteReadingAdapter']/method[@name='ˮ͈' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("ˮ͈", "(Ljava/lang/String;)V", "")]
		public unsafe void ˮ͈ (string p0)
		{
			if (id_ˮ͈_Ljava_lang_String_ == IntPtr.Zero)
				id_ˮ͈_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "ˮ͈", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod  (Handle, id_ˮ͈_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_櫯_Landroid_bluetooth_BluetoothSocket_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.vitalograph']/class[@name='VitalographDiscreteReadingAdapter']/method[@name='櫯' and count(parameter)=1 and parameter[1][@type='android.bluetooth.BluetoothSocket']]"
		[Register ("櫯", "(Landroid/bluetooth/BluetoothSocket;)V", "")]
		public unsafe void 櫯 (global::Android.Bluetooth.BluetoothSocket p0)
		{
			if (id_櫯_Landroid_bluetooth_BluetoothSocket_ == IntPtr.Zero)
				id_櫯_Landroid_bluetooth_BluetoothSocket_ = JNIEnv.GetMethodID (class_ref, "櫯", "(Landroid/bluetooth/BluetoothSocket;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_櫯_Landroid_bluetooth_BluetoothSocket_, __args);
			} finally {
			}
		}

		static IntPtr id_鷭_Landroid_bluetooth_BluetoothSocket_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.vitalograph']/class[@name='VitalographDiscreteReadingAdapter']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='android.bluetooth.BluetoothSocket']]"
		[Register ("鷭", "(Landroid/bluetooth/BluetoothSocket;)Z", "")]
		public unsafe bool 鷭 (global::Android.Bluetooth.BluetoothSocket p0)
		{
			if (id_鷭_Landroid_bluetooth_BluetoothSocket_ == IntPtr.Zero)
				id_鷭_Landroid_bluetooth_BluetoothSocket_ = JNIEnv.GetMethodID (class_ref, "鷭", "(Landroid/bluetooth/BluetoothSocket;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_鷭_Landroid_bluetooth_BluetoothSocket_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_鷭_Landroid_bluetooth_BluetoothSocket_ZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.vitalograph']/class[@name='VitalographDiscreteReadingAdapter']/method[@name='鷭' and count(parameter)=3 and parameter[1][@type='android.bluetooth.BluetoothSocket'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean']]"
		[Register ("鷭", "(Landroid/bluetooth/BluetoothSocket;ZZ)Ljava/util/List;", "")]
		public unsafe global::System.Collections.Generic.IList<global::Com.Qcl.VH.Content.ˮ͈> 鷭 (global::Android.Bluetooth.BluetoothSocket p0, bool p1, bool p2)
		{
			if (id_鷭_Landroid_bluetooth_BluetoothSocket_ZZ == IntPtr.Zero)
				id_鷭_Landroid_bluetooth_BluetoothSocket_ZZ = JNIEnv.GetMethodID (class_ref, "鷭", "(Landroid/bluetooth/BluetoothSocket;ZZ)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::System.Collections.Generic.IList<global::Com.Qcl.VH.Content.ˮ͈> __ret = global::Android.Runtime.JavaList<global::Com.Qcl.VH.Content.ˮ͈>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_鷭_Landroid_bluetooth_BluetoothSocket_ZZ, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_鷭_Landroid_bluetooth_BluetoothSocket_arrayBLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.vitalograph']/class[@name='VitalographDiscreteReadingAdapter']/method[@name='鷭' and count(parameter)=3 and parameter[1][@type='android.bluetooth.BluetoothSocket'] and parameter[2][@type='byte[]'] and parameter[3][@type='java.lang.String']]"
		[Register ("鷭", "(Landroid/bluetooth/BluetoothSocket;[BLjava/lang/String;)Lcom/qcl/vh/a/c/ˮ͍;", "")]
		public unsafe global::Com.Qcl.VH.A.C.ˮ͍ 鷭 (global::Android.Bluetooth.BluetoothSocket p0, byte[] p1, string p2)
		{
			if (id_鷭_Landroid_bluetooth_BluetoothSocket_arrayBLjava_lang_String_ == IntPtr.Zero)
				id_鷭_Landroid_bluetooth_BluetoothSocket_arrayBLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "鷭", "(Landroid/bluetooth/BluetoothSocket;[BLjava/lang/String;)Lcom/qcl/vh/a/c/ˮ͍;");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				global::Com.Qcl.VH.A.C.ˮ͍ __ret = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.A.C.ˮ͍> (JNIEnv.CallObjectMethod  (Handle, id_鷭_Landroid_bluetooth_BluetoothSocket_arrayBLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_鷭_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.vitalograph']/class[@name='VitalographDiscreteReadingAdapter']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("鷭", "(Landroid/content/Context;)V", "")]
		public unsafe void 鷭 (global::Android.Content.Context p0)
		{
			if (id_鷭_Landroid_content_Context_ == IntPtr.Zero)
				id_鷭_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "鷭", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_鷭_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_鷭_arrayBLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.vitalograph']/class[@name='VitalographDiscreteReadingAdapter']/method[@name='鷭' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='java.lang.String']]"
		[Register ("鷭", "([BLjava/lang/String;)Lcom/qcl/vh/a/c/ˮ͍;", "")]
		public unsafe global::Com.Qcl.VH.A.C.ˮ͍ 鷭 (byte[] p0, string p1)
		{
			if (id_鷭_arrayBLjava_lang_String_ == IntPtr.Zero)
				id_鷭_arrayBLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "鷭", "([BLjava/lang/String;)Lcom/qcl/vh/a/c/ˮ͍;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				global::Com.Qcl.VH.A.C.ˮ͍ __ret = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.A.C.ˮ͍> (JNIEnv.CallObjectMethod  (Handle, id_鷭_arrayBLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
