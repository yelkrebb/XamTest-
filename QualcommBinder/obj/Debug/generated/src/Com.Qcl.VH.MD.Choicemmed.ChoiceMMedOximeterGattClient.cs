using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.MD.Choicemmed {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.md.choicemmed']/class[@name='ChoiceMMedOximeterGattClient']"
	[global::Android.Runtime.Register ("com/qcl/vh/md/choicemmed/ChoiceMMedOximeterGattClient", DoNotGenerateAcw=true)]
	public partial class ChoiceMMedOximeterGattClient : global::Com.Qcl.VH.Ble.BaseGattClient {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.md.choicemmed']/class[@name='ChoiceMMedOximeterGattClient.鷭']"
		[global::Android.Runtime.Register ("com/qcl/vh/md/choicemmed/ChoiceMMedOximeterGattClient$鷭", DoNotGenerateAcw=true)]
		public new sealed partial class 鷭 : global::Java.Lang.Enum {


			static IntPtr 鷭_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.md.choicemmed']/class[@name='ChoiceMMedOximeterGattClient.鷭']/field[@name='鷭']"
			[Register ("鷭")]
			public static global::Com.Qcl.VH.MD.Choicemmed.ChoiceMMedOximeterGattClient.鷭 鷭 {
				get {
					if (鷭_jfieldId == IntPtr.Zero)
						鷭_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "鷭", "Lcom/qcl/vh/md/choicemmed/ChoiceMMedOximeterGattClient$鷭;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, 鷭_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.MD.Choicemmed.ChoiceMMedOximeterGattClient.鷭> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/qcl/vh/md/choicemmed/ChoiceMMedOximeterGattClient$鷭", ref java_class_handle);
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

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qcl/vh/md/choicemmed/ChoiceMMedOximeterGattClient", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ChoiceMMedOximeterGattClient); }
		}

		protected ChoiceMMedOximeterGattClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.md.choicemmed']/class[@name='ChoiceMMedOximeterGattClient']/constructor[@name='ChoiceMMedOximeterGattClient' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ChoiceMMedOximeterGattClient ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ChoiceMMedOximeterGattClient)) {
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

		static IntPtr id_櫯_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.choicemmed']/class[@name='ChoiceMMedOximeterGattClient']/method[@name='櫯' and count(parameter)=1 and parameter[1][@type='byte[]']]"
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

		static IntPtr id_鷭;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.choicemmed']/class[@name='ChoiceMMedOximeterGattClient']/method[@name='鷭' and count(parameter)=0]"
		[Register ("鷭", "()Landroid/bluetooth/le/ScanFilter;", "")]
		protected override sealed unsafe global::Android.Bluetooth.LE.ScanFilter Invoke鷭 ()
		{
			if (id_鷭 == IntPtr.Zero)
				id_鷭 = JNIEnv.GetMethodID (class_ref, "鷭", "()Landroid/bluetooth/le/ScanFilter;");
			try {
				return global::Java.Lang.Object.GetObject<global::Android.Bluetooth.LE.ScanFilter> (JNIEnv.CallObjectMethod  (Handle, id_鷭), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_鷭_Landroid_bluetooth_BluetoothGatt_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.choicemmed']/class[@name='ChoiceMMedOximeterGattClient']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='android.bluetooth.BluetoothGatt']]"
		[Register ("鷭", "(Landroid/bluetooth/BluetoothGatt;)V", "")]
		protected override sealed unsafe void Invoke鷭 (global::Android.Bluetooth.BluetoothGatt p0)
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.choicemmed']/class[@name='ChoiceMMedOximeterGattClient']/method[@name='鷭' and count(parameter)=3 and parameter[1][@type='android.bluetooth.BluetoothGatt'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("鷭", "(Landroid/bluetooth/BluetoothGatt;II)V", "")]
		public override sealed unsafe void Invoke鷭 (global::Android.Bluetooth.BluetoothGatt p0, int p1, int p2)
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

		static IntPtr id_鷭_Landroid_bluetooth_BluetoothGatt_Ljava_util_UUID_arrayBIILjava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.choicemmed']/class[@name='ChoiceMMedOximeterGattClient']/method[@name='鷭' and count(parameter)=6 and parameter[1][@type='android.bluetooth.BluetoothGatt'] and parameter[2][@type='java.util.UUID'] and parameter[3][@type='byte[]'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='java.util.List&lt;android.bluetooth.BluetoothGattDescriptor&gt;']]"
		[Register ("鷭", "(Landroid/bluetooth/BluetoothGatt;Ljava/util/UUID;[BIILjava/util/List;)V", "")]
		public override sealed unsafe void Invoke鷭 (global::Android.Bluetooth.BluetoothGatt p0, global::Java.Util.UUID p1, byte[] p2, int p3, int p4, global::System.Collections.Generic.IList<global::Android.Bluetooth.BluetoothGattDescriptor> p5)
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.choicemmed']/class[@name='ChoiceMMedOximeterGattClient']/method[@name='鷭' and count(parameter)=6 and parameter[1][@type='android.bluetooth.BluetoothGatt'] and parameter[2][@type='java.util.UUID'] and parameter[3][@type='byte[]'] and parameter[4][@type='int'] and parameter[5][@type='java.util.UUID'] and parameter[6][@type='int']]"
		[Register ("鷭", "(Landroid/bluetooth/BluetoothGatt;Ljava/util/UUID;[BILjava/util/UUID;I)V", "")]
		public override sealed unsafe void Invoke鷭 (global::Android.Bluetooth.BluetoothGatt p0, global::Java.Util.UUID p1, byte[] p2, int p3, global::Java.Util.UUID p4, int p5)
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

		static IntPtr id_鷭_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.choicemmed']/class[@name='ChoiceMMedOximeterGattClient']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("鷭", "([B)Z", "")]
		protected override sealed unsafe bool Invoke鷭 (byte[] p0)
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

	}
}
