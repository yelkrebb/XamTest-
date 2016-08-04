using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.MD.Omron {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.md.omron']/class[@name='OmronBPMGattClient']"
	[global::Android.Runtime.Register ("com/qcl/vh/md/omron/OmronBPMGattClient", DoNotGenerateAcw=true)]
	public partial class OmronBPMGattClient : global::Com.Qcl.VH.Ble.BloodPressureGattClient {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qcl/vh/md/omron/OmronBPMGattClient", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OmronBPMGattClient); }
		}

		protected OmronBPMGattClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.md.omron']/class[@name='OmronBPMGattClient']/constructor[@name='OmronBPMGattClient' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe OmronBPMGattClient ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (OmronBPMGattClient)) {
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

		static IntPtr id_ć;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.omron']/class[@name='OmronBPMGattClient']/method[@name='ć' and count(parameter)=0]"
		[Register ("ć", "()V", "")]
		protected override sealed unsafe void Ć ()
		{
			if (id_ć == IntPtr.Zero)
				id_ć = JNIEnv.GetMethodID (class_ref, "ć", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_ć);
			} finally {
			}
		}

		static IntPtr id_Ȋ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.omron']/class[@name='OmronBPMGattClient']/method[@name='Ȋ' and count(parameter)=0]"
		[Register ("Ȋ", "()V", "")]
		protected override sealed unsafe void Ȋ ()
		{
			if (id_Ȋ == IntPtr.Zero)
				id_Ȋ = JNIEnv.GetMethodID (class_ref, "Ȋ", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_Ȋ);
			} finally {
			}
		}

		static IntPtr id_ˮ͍;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.omron']/class[@name='OmronBPMGattClient']/method[@name='ˮ͍' and count(parameter)=0]"
		[Register ("ˮ͍", "()V", "")]
		protected override sealed unsafe void ˮ͍ ()
		{
			if (id_ˮ͍ == IntPtr.Zero)
				id_ˮ͍ = JNIEnv.GetMethodID (class_ref, "ˮ͍", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_ˮ͍);
			} finally {
			}
		}

		static IntPtr id_岱;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.omron']/class[@name='OmronBPMGattClient']/method[@name='岱' and count(parameter)=0]"
		[Register ("岱", "()V", "")]
		protected override sealed unsafe void 岱 ()
		{
			if (id_岱 == IntPtr.Zero)
				id_岱 = JNIEnv.GetMethodID (class_ref, "岱", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_岱);
			} finally {
			}
		}

		static IntPtr id_櫯_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.omron']/class[@name='OmronBPMGattClient']/method[@name='櫯' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("櫯", "([B)Z", "")]
		protected override sealed unsafe bool 櫯 (byte[] p0)
		{
			if (id_櫯_arrayB == IntPtr.Zero)
				id_櫯_arrayB = JNIEnv.GetMethodID (class_ref, "櫯", "([B)Z");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_櫯_arrayB, __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_鷭_Landroid_bluetooth_BluetoothGatt_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.omron']/class[@name='OmronBPMGattClient']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='android.bluetooth.BluetoothGatt']]"
		[Register ("鷭", "(Landroid/bluetooth/BluetoothGatt;)V", "")]
		protected override sealed unsafe void 鷭 (global::Android.Bluetooth.BluetoothGatt p0)
		{
			if (id_鷭_Landroid_bluetooth_BluetoothGatt_ == IntPtr.Zero)
				id_鷭_Landroid_bluetooth_BluetoothGatt_ = JNIEnv.GetMethodID (class_ref, "鷭", "(Landroid/bluetooth/BluetoothGatt;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_鷭_Landroid_bluetooth_BluetoothGatt_, __args);
			} finally {
			}
		}

		static IntPtr id_鷭_Landroid_bluetooth_BluetoothGatt_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.omron']/class[@name='OmronBPMGattClient']/method[@name='鷭' and count(parameter)=3 and parameter[1][@type='android.bluetooth.BluetoothGatt'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("鷭", "(Landroid/bluetooth/BluetoothGatt;II)V", "")]
		public override sealed unsafe void 鷭 (global::Android.Bluetooth.BluetoothGatt p0, int p1, int p2)
		{
			if (id_鷭_Landroid_bluetooth_BluetoothGatt_II == IntPtr.Zero)
				id_鷭_Landroid_bluetooth_BluetoothGatt_II = JNIEnv.GetMethodID (class_ref, "鷭", "(Landroid/bluetooth/BluetoothGatt;II)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod  (Handle, id_鷭_Landroid_bluetooth_BluetoothGatt_II, __args);
			} finally {
			}
		}

		static IntPtr id_鷭_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.omron']/class[@name='OmronBPMGattClient']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("鷭", "([B)Z", "")]
		protected override sealed unsafe bool 鷭 (byte[] p0)
		{
			if (id_鷭_arrayB == IntPtr.Zero)
				id_鷭_arrayB = JNIEnv.GetMethodID (class_ref, "鷭", "([B)Z");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_鷭_arrayB, __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_鷭_Ljava_util_UUID_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.omron']/class[@name='OmronBPMGattClient']/method[@name='鷭' and count(parameter)=2 and parameter[1][@type='java.util.UUID'] and parameter[2][@type='byte[]']]"
		[Register ("鷭", "(Ljava/util/UUID;[B)V", "")]
		protected override sealed unsafe void 鷭 (global::Java.Util.UUID p0, byte[] p1)
		{
			if (id_鷭_Ljava_util_UUID_arrayB == IntPtr.Zero)
				id_鷭_Ljava_util_UUID_arrayB = JNIEnv.GetMethodID (class_ref, "鷭", "(Ljava/util/UUID;[B)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallVoidMethod  (Handle, id_鷭_Ljava_util_UUID_arrayB, __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

	}
}
