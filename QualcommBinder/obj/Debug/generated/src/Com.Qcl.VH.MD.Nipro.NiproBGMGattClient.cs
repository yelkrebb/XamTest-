using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.MD.Nipro {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.md.nipro']/class[@name='NiproBGMGattClient']"
	[global::Android.Runtime.Register ("com/qcl/vh/md/nipro/NiproBGMGattClient", DoNotGenerateAcw=true)]
	public partial class NiproBGMGattClient : global::Com.Qcl.VH.Ble.BloodGlucoseGattClient {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qcl/vh/md/nipro/NiproBGMGattClient", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NiproBGMGattClient); }
		}

		protected NiproBGMGattClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.md.nipro']/class[@name='NiproBGMGattClient']/constructor[@name='NiproBGMGattClient' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe NiproBGMGattClient ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (NiproBGMGattClient)) {
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

		static IntPtr id_ˮ͈_Landroid_bluetooth_BluetoothGatt_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.nipro']/class[@name='NiproBGMGattClient']/method[@name='ˮ͈' and count(parameter)=1 and parameter[1][@type='android.bluetooth.BluetoothGatt']]"
		[Register ("ˮ͈", "(Landroid/bluetooth/BluetoothGatt;)V", "")]
		protected override sealed unsafe void ˮ͈ (global::Android.Bluetooth.BluetoothGatt p0)
		{
			if (id_ˮ͈_Landroid_bluetooth_BluetoothGatt_ == IntPtr.Zero)
				id_ˮ͈_Landroid_bluetooth_BluetoothGatt_ = JNIEnv.GetMethodID (class_ref, "ˮ͈", "(Landroid/bluetooth/BluetoothGatt;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_ˮ͈_Landroid_bluetooth_BluetoothGatt_, __args);
			} finally {
			}
		}

		static IntPtr id_ˮ͈_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.nipro']/class[@name='NiproBGMGattClient']/method[@name='ˮ͈' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("ˮ͈", "([B)Ljava/lang/String;", "")]
		protected override sealed unsafe string ˮ͈ (byte[] p0)
		{
			if (id_ˮ͈_arrayB == IntPtr.Zero)
				id_ˮ͈_arrayB = JNIEnv.GetMethodID (class_ref, "ˮ͈", "([B)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_ˮ͈_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_櫯_Landroid_bluetooth_BluetoothGatt_Ljava_util_UUID_arrayBIILjava_util_List_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.nipro']/class[@name='NiproBGMGattClient']/method[@name='櫯' and count(parameter)=7 and parameter[1][@type='android.bluetooth.BluetoothGatt'] and parameter[2][@type='java.util.UUID'] and parameter[3][@type='byte[]'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='java.util.List&lt;android.bluetooth.BluetoothGattDescriptor&gt;'] and parameter[7][@type='int']]"
		[Register ("櫯", "(Landroid/bluetooth/BluetoothGatt;Ljava/util/UUID;[BIILjava/util/List;I)V", "")]
		public override sealed unsafe void 櫯 (global::Android.Bluetooth.BluetoothGatt p0, global::Java.Util.UUID p1, byte[] p2, int p3, int p4, global::System.Collections.Generic.IList<global::Android.Bluetooth.BluetoothGattDescriptor> p5, int p6)
		{
			if (id_櫯_Landroid_bluetooth_BluetoothGatt_Ljava_util_UUID_arrayBIILjava_util_List_I == IntPtr.Zero)
				id_櫯_Landroid_bluetooth_BluetoothGatt_Ljava_util_UUID_arrayBIILjava_util_List_I = JNIEnv.GetMethodID (class_ref, "櫯", "(Landroid/bluetooth/BluetoothGatt;Ljava/util/UUID;[BIILjava/util/List;I)V");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p5 = global::Android.Runtime.JavaList<global::Android.Bluetooth.BluetoothGattDescriptor>.ToLocalJniHandle (p5);
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (native_p5);
				__args [6] = new JValue (p6);
				JNIEnv.CallVoidMethod  (Handle, id_櫯_Landroid_bluetooth_BluetoothGatt_Ljava_util_UUID_arrayBIILjava_util_List_I, __args);
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				JNIEnv.DeleteLocalRef (native_p5);
			}
		}

		static IntPtr id_鷭_Landroid_bluetooth_BluetoothGatt_Ljava_util_UUID_arrayBIILjava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.nipro']/class[@name='NiproBGMGattClient']/method[@name='鷭' and count(parameter)=6 and parameter[1][@type='android.bluetooth.BluetoothGatt'] and parameter[2][@type='java.util.UUID'] and parameter[3][@type='byte[]'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='java.util.List&lt;android.bluetooth.BluetoothGattDescriptor&gt;']]"
		[Register ("鷭", "(Landroid/bluetooth/BluetoothGatt;Ljava/util/UUID;[BIILjava/util/List;)V", "")]
		public override sealed unsafe void 鷭 (global::Android.Bluetooth.BluetoothGatt p0, global::Java.Util.UUID p1, byte[] p2, int p3, int p4, global::System.Collections.Generic.IList<global::Android.Bluetooth.BluetoothGattDescriptor> p5)
		{
			if (id_鷭_Landroid_bluetooth_BluetoothGatt_Ljava_util_UUID_arrayBIILjava_util_List_ == IntPtr.Zero)
				id_鷭_Landroid_bluetooth_BluetoothGatt_Ljava_util_UUID_arrayBIILjava_util_List_ = JNIEnv.GetMethodID (class_ref, "鷭", "(Landroid/bluetooth/BluetoothGatt;Ljava/util/UUID;[BIILjava/util/List;)V");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p5 = global::Android.Runtime.JavaList<global::Android.Bluetooth.BluetoothGattDescriptor>.ToLocalJniHandle (p5);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (native_p5);
				JNIEnv.CallVoidMethod  (Handle, id_鷭_Landroid_bluetooth_BluetoothGatt_Ljava_util_UUID_arrayBIILjava_util_List_, __args);
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				JNIEnv.DeleteLocalRef (native_p5);
			}
		}

		static IntPtr id_鷭_Landroid_bluetooth_BluetoothGatt_Ljava_util_UUID_arrayBILjava_util_UUID_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.nipro']/class[@name='NiproBGMGattClient']/method[@name='鷭' and count(parameter)=6 and parameter[1][@type='android.bluetooth.BluetoothGatt'] and parameter[2][@type='java.util.UUID'] and parameter[3][@type='byte[]'] and parameter[4][@type='int'] and parameter[5][@type='java.util.UUID'] and parameter[6][@type='int']]"
		[Register ("鷭", "(Landroid/bluetooth/BluetoothGatt;Ljava/util/UUID;[BILjava/util/UUID;I)V", "")]
		public override sealed unsafe void 鷭 (global::Android.Bluetooth.BluetoothGatt p0, global::Java.Util.UUID p1, byte[] p2, int p3, global::Java.Util.UUID p4, int p5)
		{
			if (id_鷭_Landroid_bluetooth_BluetoothGatt_Ljava_util_UUID_arrayBILjava_util_UUID_I == IntPtr.Zero)
				id_鷭_Landroid_bluetooth_BluetoothGatt_Ljava_util_UUID_arrayBILjava_util_UUID_I = JNIEnv.GetMethodID (class_ref, "鷭", "(Landroid/bluetooth/BluetoothGatt;Ljava/util/UUID;[BILjava/util/UUID;I)V");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				JNIEnv.CallVoidMethod  (Handle, id_鷭_Landroid_bluetooth_BluetoothGatt_Ljava_util_UUID_arrayBILjava_util_UUID_I, __args);
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

	}
}
