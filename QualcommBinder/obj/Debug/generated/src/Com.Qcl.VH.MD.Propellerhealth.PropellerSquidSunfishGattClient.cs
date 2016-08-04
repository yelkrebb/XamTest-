using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.MD.Propellerhealth {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.md.propellerhealth']/class[@name='PropellerSquidSunfishGattClient']"
	[global::Android.Runtime.Register ("com/qcl/vh/md/propellerhealth/PropellerSquidSunfishGattClient", DoNotGenerateAcw=true)]
	public abstract partial class PropellerSquidSunfishGattClient : global::Com.Qcl.VH.MD.Propellerhealth.PropellerGenericGattClient {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.md.propellerhealth']/class[@name='PropellerSquidSunfishGattClient.鷭']"
		[global::Android.Runtime.Register ("com/qcl/vh/md/propellerhealth/PropellerSquidSunfishGattClient$鷭", DoNotGenerateAcw=true)]
		public new partial class 鷭 : global::Java.Lang.Object, global::Java.Lang.IRunnable {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/qcl/vh/md/propellerhealth/PropellerSquidSunfishGattClient$鷭", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (鷭); }
			}

			protected 鷭 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_qcl_vh_md_propellerhealth_PropellerSquidSunfishGattClient_Landroid_bluetooth_BluetoothGatt_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.md.propellerhealth']/class[@name='PropellerSquidSunfishGattClient.鷭']/constructor[@name='PropellerSquidSunfishGattClient.鷭' and count(parameter)=2 and parameter[1][@type='com.qcl.vh.md.propellerhealth.PropellerSquidSunfishGattClient'] and parameter[2][@type='android.bluetooth.BluetoothGatt']]"
			[Register (".ctor", "(Lcom/qcl/vh/md/propellerhealth/PropellerSquidSunfishGattClient;Landroid/bluetooth/BluetoothGatt;)V", "")]
			public unsafe 鷭 (global::Com.Qcl.VH.MD.Propellerhealth.PropellerSquidSunfishGattClient __self, global::Android.Bluetooth.BluetoothGatt p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (p1);
					if (GetType () != typeof (鷭)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/bluetooth/BluetoothGatt;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/bluetooth/BluetoothGatt;)V", __args);
						return;
					}

					if (id_ctor_Lcom_qcl_vh_md_propellerhealth_PropellerSquidSunfishGattClient_Landroid_bluetooth_BluetoothGatt_ == IntPtr.Zero)
						id_ctor_Lcom_qcl_vh_md_propellerhealth_PropellerSquidSunfishGattClient_Landroid_bluetooth_BluetoothGatt_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/qcl/vh/md/propellerhealth/PropellerSquidSunfishGattClient;Landroid/bluetooth/BluetoothGatt;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_qcl_vh_md_propellerhealth_PropellerSquidSunfishGattClient_Landroid_bluetooth_BluetoothGatt_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_qcl_vh_md_propellerhealth_PropellerSquidSunfishGattClient_Landroid_bluetooth_BluetoothGatt_, __args);
				} finally {
				}
			}

			static IntPtr id_run;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.propellerhealth']/class[@name='PropellerSquidSunfishGattClient.鷭']/method[@name='run' and count(parameter)=0]"
			[Register ("run", "()V", "")]
			public unsafe void Run ()
			{
				if (id_run == IntPtr.Zero)
					id_run = JNIEnv.GetMethodID (class_ref, "run", "()V");
				try {
					JNIEnv.CallVoidMethod  (Handle, id_run);
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qcl/vh/md/propellerhealth/PropellerSquidSunfishGattClient", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PropellerSquidSunfishGattClient); }
		}

		protected PropellerSquidSunfishGattClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.md.propellerhealth']/class[@name='PropellerSquidSunfishGattClient']/constructor[@name='PropellerSquidSunfishGattClient' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PropellerSquidSunfishGattClient ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (PropellerSquidSunfishGattClient)) {
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

		static IntPtr id_櫯_Landroid_bluetooth_BluetoothGatt_Ljava_util_UUID_arrayBIILjava_util_List_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.propellerhealth']/class[@name='PropellerSquidSunfishGattClient']/method[@name='櫯' and count(parameter)=7 and parameter[1][@type='android.bluetooth.BluetoothGatt'] and parameter[2][@type='java.util.UUID'] and parameter[3][@type='byte[]'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='java.util.List&lt;android.bluetooth.BluetoothGattDescriptor&gt;'] and parameter[7][@type='int']]"
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

		static IntPtr id_鷭_Landroid_bluetooth_BluetoothGatt_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.propellerhealth']/class[@name='PropellerSquidSunfishGattClient']/method[@name='鷭' and count(parameter)=3 and parameter[1][@type='android.bluetooth.BluetoothGatt'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.propellerhealth']/class[@name='PropellerSquidSunfishGattClient']/method[@name='鷭' and count(parameter)=6 and parameter[1][@type='android.bluetooth.BluetoothGatt'] and parameter[2][@type='java.util.UUID'] and parameter[3][@type='byte[]'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='java.util.List&lt;android.bluetooth.BluetoothGattDescriptor&gt;']]"
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

		static IntPtr id_鷭_Landroid_bluetooth_BluetoothGatt_Ljava_util_UUID_arrayBIILjava_util_List_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.propellerhealth']/class[@name='PropellerSquidSunfishGattClient']/method[@name='鷭' and count(parameter)=7 and parameter[1][@type='android.bluetooth.BluetoothGatt'] and parameter[2][@type='java.util.UUID'] and parameter[3][@type='byte[]'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='java.util.List&lt;android.bluetooth.BluetoothGattDescriptor&gt;'] and parameter[7][@type='int']]"
		[Register ("鷭", "(Landroid/bluetooth/BluetoothGatt;Ljava/util/UUID;[BIILjava/util/List;I)V", "")]
		public override sealed unsafe void Invoke鷭 (global::Android.Bluetooth.BluetoothGatt p0, global::Java.Util.UUID p1, byte[] p2, int p3, int p4, global::System.Collections.Generic.IList<global::Android.Bluetooth.BluetoothGattDescriptor> p5, int p6)
		{
			if (id_鷭_Landroid_bluetooth_BluetoothGatt_Ljava_util_UUID_arrayBIILjava_util_List_I == IntPtr.Zero)
				id_鷭_Landroid_bluetooth_BluetoothGatt_Ljava_util_UUID_arrayBIILjava_util_List_I = JNIEnv.GetMethodID (class_ref, "鷭", "(Landroid/bluetooth/BluetoothGatt;Ljava/util/UUID;[BIILjava/util/List;I)V");
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
				JNIEnv.CallVoidMethod  (Handle, id_鷭_Landroid_bluetooth_BluetoothGatt_Ljava_util_UUID_arrayBIILjava_util_List_I, __args);
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				JNIEnv.DeleteLocalRef (native_p5);
			}
		}

		static IntPtr id_鷭_Landroid_bluetooth_BluetoothSocket_arrayBLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.propellerhealth']/class[@name='PropellerSquidSunfishGattClient']/method[@name='鷭' and count(parameter)=3 and parameter[1][@type='android.bluetooth.BluetoothSocket'] and parameter[2][@type='byte[]'] and parameter[3][@type='java.lang.String']]"
		[Register ("鷭", "(Landroid/bluetooth/BluetoothSocket;[BLjava/lang/String;)Lcom/qcl/vh/a/c/ˮ͍;", "")]
		public override sealed unsafe global::Com.Qcl.VH.A.C.ˮ͍ Invoke鷭 (global::Android.Bluetooth.BluetoothSocket p0, byte[] p1, string p2)
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

	}

	[global::Android.Runtime.Register ("com/qcl/vh/md/propellerhealth/PropellerSquidSunfishGattClient", DoNotGenerateAcw=true)]
	internal partial class PropellerSquidSunfishGattClientInvoker : PropellerSquidSunfishGattClient {

		public PropellerSquidSunfishGattClientInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (PropellerSquidSunfishGattClientInvoker); }
		}

		static IntPtr id_鷭;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BaseGattClient']/method[@name='鷭' and count(parameter)=0]"
		[Register ("鷭", "()Landroid/bluetooth/le/ScanFilter;", "GetInvoke鷭Handler")]
		protected override unsafe global::Android.Bluetooth.LE.ScanFilter Invoke鷭 ()
		{
			if (id_鷭 == IntPtr.Zero)
				id_鷭 = JNIEnv.GetMethodID (class_ref, "鷭", "()Landroid/bluetooth/le/ScanFilter;");
			try {
				return global::Java.Lang.Object.GetObject<global::Android.Bluetooth.LE.ScanFilter> (JNIEnv.CallObjectMethod  (Handle, id_鷭), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_鷭_Landroid_bluetooth_BluetoothGatt_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BaseGattClient']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='android.bluetooth.BluetoothGatt']]"
		[Register ("鷭", "(Landroid/bluetooth/BluetoothGatt;)V", "GetInvoke鷭_Landroid_bluetooth_BluetoothGatt_Handler")]
		protected override unsafe void Invoke鷭 (global::Android.Bluetooth.BluetoothGatt p0)
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

		static IntPtr id_鷭_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BaseGattClient']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("鷭", "([B)Z", "GetInvoke鷭_arrayBHandler")]
		protected override unsafe bool Invoke鷭 (byte[] p0)
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
