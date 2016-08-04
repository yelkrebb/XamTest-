using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.Ble {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='EnhancedBleService']"
	[global::Android.Runtime.Register ("com/qcl/vh/ble/EnhancedBleService", DoNotGenerateAcw=true)]
	public partial class EnhancedBleService : global::Com.Qcl.VH.Ble.BleService {


		static IntPtr mScanCallback_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='EnhancedBleService']/field[@name='mScanCallback']"
		[Register ("mScanCallback")]
		protected global::Com.Qcl.VH.Ble.EnhancedBleService.If MScanCallback {
			get {
				if (mScanCallback_jfieldId == IntPtr.Zero)
					mScanCallback_jfieldId = JNIEnv.GetFieldID (class_ref, "mScanCallback", "Lcom/qcl/vh/ble/EnhancedBleService$if;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mScanCallback_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Ble.EnhancedBleService.If> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mScanCallback_jfieldId == IntPtr.Zero)
					mScanCallback_jfieldId = JNIEnv.GetFieldID (class_ref, "mScanCallback", "Lcom/qcl/vh/ble/EnhancedBleService$if;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, mScanCallback_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr sReconnectTable_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='EnhancedBleService']/field[@name='sReconnectTable']"
		[Register ("sReconnectTable")]
		protected static global::System.Collections.IDictionary SReconnectTable {
			get {
				if (sReconnectTable_jfieldId == IntPtr.Zero)
					sReconnectTable_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "sReconnectTable", "Ljava/util/HashMap;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, sReconnectTable_jfieldId);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (sReconnectTable_jfieldId == IntPtr.Zero)
					sReconnectTable_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "sReconnectTable", "Ljava/util/HashMap;");
				IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, sReconnectTable_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='EnhancedBleService.if']"
		[global::Android.Runtime.Register ("com/qcl/vh/ble/EnhancedBleService$if", DoNotGenerateAcw=true)]
		public new partial class If : global::Android.Bluetooth.LE.ScanCallback {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/qcl/vh/ble/EnhancedBleService$if", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (If); }
			}

			protected If (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_qcl_vh_ble_EnhancedBleService_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='EnhancedBleService.if']/constructor[@name='EnhancedBleService.if' and count(parameter)=1 and parameter[1][@type='com.qcl.vh.ble.EnhancedBleService']]"
			[Register (".ctor", "(Lcom/qcl/vh/ble/EnhancedBleService;)V", "")]
			public unsafe If (global::Com.Qcl.VH.Ble.EnhancedBleService p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (GetType () != typeof (If)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/qcl/vh/ble/EnhancedBleService;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/qcl/vh/ble/EnhancedBleService;)V", __args);
						return;
					}

					if (id_ctor_Lcom_qcl_vh_ble_EnhancedBleService_ == IntPtr.Zero)
						id_ctor_Lcom_qcl_vh_ble_EnhancedBleService_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/qcl/vh/ble/EnhancedBleService;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_qcl_vh_ble_EnhancedBleService_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_qcl_vh_ble_EnhancedBleService_, __args);
				} finally {
				}
			}

			static IntPtr id_onBatchScanResults_Ljava_util_List_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='EnhancedBleService.if']/method[@name='onBatchScanResults' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;android.bluetooth.le.ScanResult&gt;']]"
			[Register ("onBatchScanResults", "(Ljava/util/List;)V", "")]
			public unsafe void OnBatchScanResults (global::System.Collections.Generic.IList<global::Android.Bluetooth.LE.ScanResult> p0)
			{
				if (id_onBatchScanResults_Ljava_util_List_ == IntPtr.Zero)
					id_onBatchScanResults_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "onBatchScanResults", "(Ljava/util/List;)V");
				IntPtr native_p0 = global::Android.Runtime.JavaList<global::Android.Bluetooth.LE.ScanResult>.ToLocalJniHandle (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					JNIEnv.CallVoidMethod  (Handle, id_onBatchScanResults_Ljava_util_List_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_onScanFailed_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='EnhancedBleService.if']/method[@name='onScanFailed' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("onScanFailed", "(I)V", "")]
			public override sealed unsafe void OnScanFailed ([global::Android.Runtime.GeneratedEnum] global::Android.Bluetooth.LE.ScanFailure p0)
			{
				if (id_onScanFailed_I == IntPtr.Zero)
					id_onScanFailed_I = JNIEnv.GetMethodID (class_ref, "onScanFailed", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue ((int) p0);
					JNIEnv.CallVoidMethod  (Handle, id_onScanFailed_I, __args);
				} finally {
				}
			}

			static IntPtr id_onScanResult_ILandroid_bluetooth_le_ScanResult_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='EnhancedBleService.if']/method[@name='onScanResult' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.bluetooth.le.ScanResult']]"
			[Register ("onScanResult", "(ILandroid/bluetooth/le/ScanResult;)V", "")]
			public override sealed unsafe void OnScanResult ([global::Android.Runtime.GeneratedEnum] global::Android.Bluetooth.LE.ScanCallbackType p0, global::Android.Bluetooth.LE.ScanResult p1)
			{
				if (id_onScanResult_ILandroid_bluetooth_le_ScanResult_ == IntPtr.Zero)
					id_onScanResult_ILandroid_bluetooth_le_ScanResult_ = JNIEnv.GetMethodID (class_ref, "onScanResult", "(ILandroid/bluetooth/le/ScanResult;)V");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue ((int) p0);
					__args [1] = new JValue (p1);
					JNIEnv.CallVoidMethod  (Handle, id_onScanResult_ILandroid_bluetooth_le_ScanResult_, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='EnhancedBleService.櫯']"
		[global::Android.Runtime.Register ("com/qcl/vh/ble/EnhancedBleService$櫯", DoNotGenerateAcw=true)]
		public new partial class 櫯 : global::Java.Lang.Object, global::Java.Lang.IRunnable {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/qcl/vh/ble/EnhancedBleService$櫯", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (櫯); }
			}

			protected 櫯 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_run;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='EnhancedBleService.櫯']/method[@name='run' and count(parameter)=0]"
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

			static IntPtr id_鷭;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='EnhancedBleService.櫯']/method[@name='鷭' and count(parameter)=0]"
			[Register ("鷭", "()J", "")]
			public unsafe long 鷭 ()
			{
				if (id_鷭 == IntPtr.Zero)
					id_鷭 = JNIEnv.GetMethodID (class_ref, "鷭", "()J");
				try {
					return JNIEnv.CallLongMethod  (Handle, id_鷭);
				} finally {
				}
			}

			static IntPtr id_鷭_J;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='EnhancedBleService.櫯']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("鷭", "(J)V", "")]
			public unsafe void 鷭 (long p0)
			{
				if (id_鷭_J == IntPtr.Zero)
					id_鷭_J = JNIEnv.GetMethodID (class_ref, "鷭", "(J)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					JNIEnv.CallVoidMethod  (Handle, id_鷭_J, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='EnhancedBleService.鷭']"
		[global::Android.Runtime.Register ("com/qcl/vh/ble/EnhancedBleService$鷭", DoNotGenerateAcw=true)]
		public new partial class 鷭 : global::Com.Qcl.VH.Ble.BleService.ˮ͈ {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/qcl/vh/ble/EnhancedBleService$鷭", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (鷭); }
			}

			protected 鷭 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_qcl_vh_ble_EnhancedBleService_Landroid_content_Context_Lcom_qcl_vh_content_MedicalDevice_Lcom_qcl_vh_ble_BleService_櫯_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='EnhancedBleService.鷭']/constructor[@name='EnhancedBleService.鷭' and count(parameter)=4 and parameter[1][@type='com.qcl.vh.ble.EnhancedBleService'] and parameter[2][@type='android.content.Context'] and parameter[3][@type='com.qcl.vh.content.MedicalDevice'] and parameter[4][@type='com.qcl.vh.ble.BleService.櫯']]"
			[Register (".ctor", "(Lcom/qcl/vh/ble/EnhancedBleService;Landroid/content/Context;Lcom/qcl/vh/content/MedicalDevice;Lcom/qcl/vh/ble/BleService$櫯;)V", "")]
			public unsafe 鷭 (global::Com.Qcl.VH.Ble.EnhancedBleService __self, global::Android.Content.Context p1, global::Com.Qcl.VH.Content.MedicalDevice p2, global::Com.Qcl.VH.Ble.BleService.櫯 p3)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [4];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					__args [3] = new JValue (p3);
					if (GetType () != typeof (鷭)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/content/Context;Lcom/qcl/vh/content/MedicalDevice;Lcom/qcl/vh/ble/BleService$櫯;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/content/Context;Lcom/qcl/vh/content/MedicalDevice;Lcom/qcl/vh/ble/BleService$櫯;)V", __args);
						return;
					}

					if (id_ctor_Lcom_qcl_vh_ble_EnhancedBleService_Landroid_content_Context_Lcom_qcl_vh_content_MedicalDevice_Lcom_qcl_vh_ble_BleService_櫯_ == IntPtr.Zero)
						id_ctor_Lcom_qcl_vh_ble_EnhancedBleService_Landroid_content_Context_Lcom_qcl_vh_content_MedicalDevice_Lcom_qcl_vh_ble_BleService_櫯_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/qcl/vh/ble/EnhancedBleService;Landroid/content/Context;Lcom/qcl/vh/content/MedicalDevice;Lcom/qcl/vh/ble/BleService$櫯;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_qcl_vh_ble_EnhancedBleService_Landroid_content_Context_Lcom_qcl_vh_content_MedicalDevice_Lcom_qcl_vh_ble_BleService_櫯_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_qcl_vh_ble_EnhancedBleService_Landroid_content_Context_Lcom_qcl_vh_content_MedicalDevice_Lcom_qcl_vh_ble_BleService_櫯_, __args);
				} finally {
				}
			}

			static Delegate cb_onCharacteristicChanged_Landroid_bluetooth_BluetoothGatt_Landroid_bluetooth_BluetoothGattCharacteristic_;
#pragma warning disable 0169
			static Delegate GetOnCharacteristicChanged_Landroid_bluetooth_BluetoothGatt_Landroid_bluetooth_BluetoothGattCharacteristic_Handler ()
			{
				if (cb_onCharacteristicChanged_Landroid_bluetooth_BluetoothGatt_Landroid_bluetooth_BluetoothGattCharacteristic_ == null)
					cb_onCharacteristicChanged_Landroid_bluetooth_BluetoothGatt_Landroid_bluetooth_BluetoothGattCharacteristic_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnCharacteristicChanged_Landroid_bluetooth_BluetoothGatt_Landroid_bluetooth_BluetoothGattCharacteristic_);
				return cb_onCharacteristicChanged_Landroid_bluetooth_BluetoothGatt_Landroid_bluetooth_BluetoothGattCharacteristic_;
			}

			static void n_OnCharacteristicChanged_Landroid_bluetooth_BluetoothGatt_Landroid_bluetooth_BluetoothGattCharacteristic_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Qcl.VH.Ble.EnhancedBleService.鷭 __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Ble.EnhancedBleService.鷭> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Bluetooth.BluetoothGatt p0 = global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothGatt> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Bluetooth.BluetoothGattCharacteristic p1 = global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothGattCharacteristic> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnCharacteristicChanged (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_onCharacteristicChanged_Landroid_bluetooth_BluetoothGatt_Landroid_bluetooth_BluetoothGattCharacteristic_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='EnhancedBleService.鷭']/method[@name='onCharacteristicChanged' and count(parameter)=2 and parameter[1][@type='android.bluetooth.BluetoothGatt'] and parameter[2][@type='android.bluetooth.BluetoothGattCharacteristic']]"
			[Register ("onCharacteristicChanged", "(Landroid/bluetooth/BluetoothGatt;Landroid/bluetooth/BluetoothGattCharacteristic;)V", "GetOnCharacteristicChanged_Landroid_bluetooth_BluetoothGatt_Landroid_bluetooth_BluetoothGattCharacteristic_Handler")]
			public override unsafe void OnCharacteristicChanged (global::Android.Bluetooth.BluetoothGatt p0, global::Android.Bluetooth.BluetoothGattCharacteristic p1)
			{
				if (id_onCharacteristicChanged_Landroid_bluetooth_BluetoothGatt_Landroid_bluetooth_BluetoothGattCharacteristic_ == IntPtr.Zero)
					id_onCharacteristicChanged_Landroid_bluetooth_BluetoothGatt_Landroid_bluetooth_BluetoothGattCharacteristic_ = JNIEnv.GetMethodID (class_ref, "onCharacteristicChanged", "(Landroid/bluetooth/BluetoothGatt;Landroid/bluetooth/BluetoothGattCharacteristic;)V");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onCharacteristicChanged_Landroid_bluetooth_BluetoothGatt_Landroid_bluetooth_BluetoothGattCharacteristic_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCharacteristicChanged", "(Landroid/bluetooth/BluetoothGatt;Landroid/bluetooth/BluetoothGattCharacteristic;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_onCharacteristicRead_Landroid_bluetooth_BluetoothGatt_Landroid_bluetooth_BluetoothGattCharacteristic_I;
#pragma warning disable 0169
			static Delegate GetOnCharacteristicRead_Landroid_bluetooth_BluetoothGatt_Landroid_bluetooth_BluetoothGattCharacteristic_IHandler ()
			{
				if (cb_onCharacteristicRead_Landroid_bluetooth_BluetoothGatt_Landroid_bluetooth_BluetoothGattCharacteristic_I == null)
					cb_onCharacteristicRead_Landroid_bluetooth_BluetoothGatt_Landroid_bluetooth_BluetoothGattCharacteristic_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_OnCharacteristicRead_Landroid_bluetooth_BluetoothGatt_Landroid_bluetooth_BluetoothGattCharacteristic_I);
				return cb_onCharacteristicRead_Landroid_bluetooth_BluetoothGatt_Landroid_bluetooth_BluetoothGattCharacteristic_I;
			}

			static void n_OnCharacteristicRead_Landroid_bluetooth_BluetoothGatt_Landroid_bluetooth_BluetoothGattCharacteristic_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int native_p2)
			{
				global::Com.Qcl.VH.Ble.EnhancedBleService.鷭 __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Ble.EnhancedBleService.鷭> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Bluetooth.BluetoothGatt p0 = global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothGatt> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Bluetooth.BluetoothGattCharacteristic p1 = global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothGattCharacteristic> (native_p1, JniHandleOwnership.DoNotTransfer);
				global::Android.Bluetooth.GattStatus p2 = (global::Android.Bluetooth.GattStatus) native_p2;
				__this.OnCharacteristicRead (p0, p1, p2);
			}
#pragma warning restore 0169

			static IntPtr id_onCharacteristicRead_Landroid_bluetooth_BluetoothGatt_Landroid_bluetooth_BluetoothGattCharacteristic_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='EnhancedBleService.鷭']/method[@name='onCharacteristicRead' and count(parameter)=3 and parameter[1][@type='android.bluetooth.BluetoothGatt'] and parameter[2][@type='android.bluetooth.BluetoothGattCharacteristic'] and parameter[3][@type='int']]"
			[Register ("onCharacteristicRead", "(Landroid/bluetooth/BluetoothGatt;Landroid/bluetooth/BluetoothGattCharacteristic;I)V", "GetOnCharacteristicRead_Landroid_bluetooth_BluetoothGatt_Landroid_bluetooth_BluetoothGattCharacteristic_IHandler")]
			public override unsafe void OnCharacteristicRead (global::Android.Bluetooth.BluetoothGatt p0, global::Android.Bluetooth.BluetoothGattCharacteristic p1, [global::Android.Runtime.GeneratedEnum] global::Android.Bluetooth.GattStatus p2)
			{
				if (id_onCharacteristicRead_Landroid_bluetooth_BluetoothGatt_Landroid_bluetooth_BluetoothGattCharacteristic_I == IntPtr.Zero)
					id_onCharacteristicRead_Landroid_bluetooth_BluetoothGatt_Landroid_bluetooth_BluetoothGattCharacteristic_I = JNIEnv.GetMethodID (class_ref, "onCharacteristicRead", "(Landroid/bluetooth/BluetoothGatt;Landroid/bluetooth/BluetoothGattCharacteristic;I)V");
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue ((int) p2);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onCharacteristicRead_Landroid_bluetooth_BluetoothGatt_Landroid_bluetooth_BluetoothGattCharacteristic_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCharacteristicRead", "(Landroid/bluetooth/BluetoothGatt;Landroid/bluetooth/BluetoothGattCharacteristic;I)V"), __args);
				} finally {
				}
			}

			static Delegate cb_onCharacteristicWrite_Landroid_bluetooth_BluetoothGatt_Landroid_bluetooth_BluetoothGattCharacteristic_I;
#pragma warning disable 0169
			static Delegate GetOnCharacteristicWrite_Landroid_bluetooth_BluetoothGatt_Landroid_bluetooth_BluetoothGattCharacteristic_IHandler ()
			{
				if (cb_onCharacteristicWrite_Landroid_bluetooth_BluetoothGatt_Landroid_bluetooth_BluetoothGattCharacteristic_I == null)
					cb_onCharacteristicWrite_Landroid_bluetooth_BluetoothGatt_Landroid_bluetooth_BluetoothGattCharacteristic_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_OnCharacteristicWrite_Landroid_bluetooth_BluetoothGatt_Landroid_bluetooth_BluetoothGattCharacteristic_I);
				return cb_onCharacteristicWrite_Landroid_bluetooth_BluetoothGatt_Landroid_bluetooth_BluetoothGattCharacteristic_I;
			}

			static void n_OnCharacteristicWrite_Landroid_bluetooth_BluetoothGatt_Landroid_bluetooth_BluetoothGattCharacteristic_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int native_p2)
			{
				global::Com.Qcl.VH.Ble.EnhancedBleService.鷭 __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Ble.EnhancedBleService.鷭> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Bluetooth.BluetoothGatt p0 = global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothGatt> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Bluetooth.BluetoothGattCharacteristic p1 = global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothGattCharacteristic> (native_p1, JniHandleOwnership.DoNotTransfer);
				global::Android.Bluetooth.GattStatus p2 = (global::Android.Bluetooth.GattStatus) native_p2;
				__this.OnCharacteristicWrite (p0, p1, p2);
			}
#pragma warning restore 0169

			static IntPtr id_onCharacteristicWrite_Landroid_bluetooth_BluetoothGatt_Landroid_bluetooth_BluetoothGattCharacteristic_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='EnhancedBleService.鷭']/method[@name='onCharacteristicWrite' and count(parameter)=3 and parameter[1][@type='android.bluetooth.BluetoothGatt'] and parameter[2][@type='android.bluetooth.BluetoothGattCharacteristic'] and parameter[3][@type='int']]"
			[Register ("onCharacteristicWrite", "(Landroid/bluetooth/BluetoothGatt;Landroid/bluetooth/BluetoothGattCharacteristic;I)V", "GetOnCharacteristicWrite_Landroid_bluetooth_BluetoothGatt_Landroid_bluetooth_BluetoothGattCharacteristic_IHandler")]
			public override unsafe void OnCharacteristicWrite (global::Android.Bluetooth.BluetoothGatt p0, global::Android.Bluetooth.BluetoothGattCharacteristic p1, [global::Android.Runtime.GeneratedEnum] global::Android.Bluetooth.GattStatus p2)
			{
				if (id_onCharacteristicWrite_Landroid_bluetooth_BluetoothGatt_Landroid_bluetooth_BluetoothGattCharacteristic_I == IntPtr.Zero)
					id_onCharacteristicWrite_Landroid_bluetooth_BluetoothGatt_Landroid_bluetooth_BluetoothGattCharacteristic_I = JNIEnv.GetMethodID (class_ref, "onCharacteristicWrite", "(Landroid/bluetooth/BluetoothGatt;Landroid/bluetooth/BluetoothGattCharacteristic;I)V");
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue ((int) p2);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onCharacteristicWrite_Landroid_bluetooth_BluetoothGatt_Landroid_bluetooth_BluetoothGattCharacteristic_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCharacteristicWrite", "(Landroid/bluetooth/BluetoothGatt;Landroid/bluetooth/BluetoothGattCharacteristic;I)V"), __args);
				} finally {
				}
			}

			static Delegate cb_onConnectionStateChange_Landroid_bluetooth_BluetoothGatt_II;
#pragma warning disable 0169
			static Delegate GetOnConnectionStateChange_Landroid_bluetooth_BluetoothGatt_IIHandler ()
			{
				if (cb_onConnectionStateChange_Landroid_bluetooth_BluetoothGatt_II == null)
					cb_onConnectionStateChange_Landroid_bluetooth_BluetoothGatt_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_OnConnectionStateChange_Landroid_bluetooth_BluetoothGatt_II);
				return cb_onConnectionStateChange_Landroid_bluetooth_BluetoothGatt_II;
			}

			static void n_OnConnectionStateChange_Landroid_bluetooth_BluetoothGatt_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int native_p1, int native_p2)
			{
				global::Com.Qcl.VH.Ble.EnhancedBleService.鷭 __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Ble.EnhancedBleService.鷭> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Bluetooth.BluetoothGatt p0 = global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothGatt> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Bluetooth.GattStatus p1 = (global::Android.Bluetooth.GattStatus) native_p1;
				global::Android.Bluetooth.ProfileState p2 = (global::Android.Bluetooth.ProfileState) native_p2;
				__this.OnConnectionStateChange (p0, p1, p2);
			}
#pragma warning restore 0169

			static IntPtr id_onConnectionStateChange_Landroid_bluetooth_BluetoothGatt_II;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='EnhancedBleService.鷭']/method[@name='onConnectionStateChange' and count(parameter)=3 and parameter[1][@type='android.bluetooth.BluetoothGatt'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("onConnectionStateChange", "(Landroid/bluetooth/BluetoothGatt;II)V", "GetOnConnectionStateChange_Landroid_bluetooth_BluetoothGatt_IIHandler")]
			public override unsafe void OnConnectionStateChange (global::Android.Bluetooth.BluetoothGatt p0, [global::Android.Runtime.GeneratedEnum] global::Android.Bluetooth.GattStatus p1, [global::Android.Runtime.GeneratedEnum] global::Android.Bluetooth.ProfileState p2)
			{
				if (id_onConnectionStateChange_Landroid_bluetooth_BluetoothGatt_II == IntPtr.Zero)
					id_onConnectionStateChange_Landroid_bluetooth_BluetoothGatt_II = JNIEnv.GetMethodID (class_ref, "onConnectionStateChange", "(Landroid/bluetooth/BluetoothGatt;II)V");
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (p0);
					__args [1] = new JValue ((int) p1);
					__args [2] = new JValue ((int) p2);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onConnectionStateChange_Landroid_bluetooth_BluetoothGatt_II, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onConnectionStateChange", "(Landroid/bluetooth/BluetoothGatt;II)V"), __args);
				} finally {
				}
			}

			static Delegate cb_onDescriptorRead_Landroid_bluetooth_BluetoothGatt_Landroid_bluetooth_BluetoothGattDescriptor_I;
#pragma warning disable 0169
			static Delegate GetOnDescriptorRead_Landroid_bluetooth_BluetoothGatt_Landroid_bluetooth_BluetoothGattDescriptor_IHandler ()
			{
				if (cb_onDescriptorRead_Landroid_bluetooth_BluetoothGatt_Landroid_bluetooth_BluetoothGattDescriptor_I == null)
					cb_onDescriptorRead_Landroid_bluetooth_BluetoothGatt_Landroid_bluetooth_BluetoothGattDescriptor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_OnDescriptorRead_Landroid_bluetooth_BluetoothGatt_Landroid_bluetooth_BluetoothGattDescriptor_I);
				return cb_onDescriptorRead_Landroid_bluetooth_BluetoothGatt_Landroid_bluetooth_BluetoothGattDescriptor_I;
			}

			static void n_OnDescriptorRead_Landroid_bluetooth_BluetoothGatt_Landroid_bluetooth_BluetoothGattDescriptor_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int native_p2)
			{
				global::Com.Qcl.VH.Ble.EnhancedBleService.鷭 __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Ble.EnhancedBleService.鷭> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Bluetooth.BluetoothGatt p0 = global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothGatt> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Bluetooth.BluetoothGattDescriptor p1 = global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothGattDescriptor> (native_p1, JniHandleOwnership.DoNotTransfer);
				global::Android.Bluetooth.GattStatus p2 = (global::Android.Bluetooth.GattStatus) native_p2;
				__this.OnDescriptorRead (p0, p1, p2);
			}
#pragma warning restore 0169

			static IntPtr id_onDescriptorRead_Landroid_bluetooth_BluetoothGatt_Landroid_bluetooth_BluetoothGattDescriptor_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='EnhancedBleService.鷭']/method[@name='onDescriptorRead' and count(parameter)=3 and parameter[1][@type='android.bluetooth.BluetoothGatt'] and parameter[2][@type='android.bluetooth.BluetoothGattDescriptor'] and parameter[3][@type='int']]"
			[Register ("onDescriptorRead", "(Landroid/bluetooth/BluetoothGatt;Landroid/bluetooth/BluetoothGattDescriptor;I)V", "GetOnDescriptorRead_Landroid_bluetooth_BluetoothGatt_Landroid_bluetooth_BluetoothGattDescriptor_IHandler")]
			public override unsafe void OnDescriptorRead (global::Android.Bluetooth.BluetoothGatt p0, global::Android.Bluetooth.BluetoothGattDescriptor p1, [global::Android.Runtime.GeneratedEnum] global::Android.Bluetooth.GattStatus p2)
			{
				if (id_onDescriptorRead_Landroid_bluetooth_BluetoothGatt_Landroid_bluetooth_BluetoothGattDescriptor_I == IntPtr.Zero)
					id_onDescriptorRead_Landroid_bluetooth_BluetoothGatt_Landroid_bluetooth_BluetoothGattDescriptor_I = JNIEnv.GetMethodID (class_ref, "onDescriptorRead", "(Landroid/bluetooth/BluetoothGatt;Landroid/bluetooth/BluetoothGattDescriptor;I)V");
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue ((int) p2);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onDescriptorRead_Landroid_bluetooth_BluetoothGatt_Landroid_bluetooth_BluetoothGattDescriptor_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDescriptorRead", "(Landroid/bluetooth/BluetoothGatt;Landroid/bluetooth/BluetoothGattDescriptor;I)V"), __args);
				} finally {
				}
			}

			static Delegate cb_onDescriptorWrite_Landroid_bluetooth_BluetoothGatt_Landroid_bluetooth_BluetoothGattDescriptor_I;
#pragma warning disable 0169
			static Delegate GetOnDescriptorWrite_Landroid_bluetooth_BluetoothGatt_Landroid_bluetooth_BluetoothGattDescriptor_IHandler ()
			{
				if (cb_onDescriptorWrite_Landroid_bluetooth_BluetoothGatt_Landroid_bluetooth_BluetoothGattDescriptor_I == null)
					cb_onDescriptorWrite_Landroid_bluetooth_BluetoothGatt_Landroid_bluetooth_BluetoothGattDescriptor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_OnDescriptorWrite_Landroid_bluetooth_BluetoothGatt_Landroid_bluetooth_BluetoothGattDescriptor_I);
				return cb_onDescriptorWrite_Landroid_bluetooth_BluetoothGatt_Landroid_bluetooth_BluetoothGattDescriptor_I;
			}

			static void n_OnDescriptorWrite_Landroid_bluetooth_BluetoothGatt_Landroid_bluetooth_BluetoothGattDescriptor_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int native_p2)
			{
				global::Com.Qcl.VH.Ble.EnhancedBleService.鷭 __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Ble.EnhancedBleService.鷭> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Bluetooth.BluetoothGatt p0 = global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothGatt> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Bluetooth.BluetoothGattDescriptor p1 = global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothGattDescriptor> (native_p1, JniHandleOwnership.DoNotTransfer);
				global::Android.Bluetooth.GattStatus p2 = (global::Android.Bluetooth.GattStatus) native_p2;
				__this.OnDescriptorWrite (p0, p1, p2);
			}
#pragma warning restore 0169

			static IntPtr id_onDescriptorWrite_Landroid_bluetooth_BluetoothGatt_Landroid_bluetooth_BluetoothGattDescriptor_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='EnhancedBleService.鷭']/method[@name='onDescriptorWrite' and count(parameter)=3 and parameter[1][@type='android.bluetooth.BluetoothGatt'] and parameter[2][@type='android.bluetooth.BluetoothGattDescriptor'] and parameter[3][@type='int']]"
			[Register ("onDescriptorWrite", "(Landroid/bluetooth/BluetoothGatt;Landroid/bluetooth/BluetoothGattDescriptor;I)V", "GetOnDescriptorWrite_Landroid_bluetooth_BluetoothGatt_Landroid_bluetooth_BluetoothGattDescriptor_IHandler")]
			public override unsafe void OnDescriptorWrite (global::Android.Bluetooth.BluetoothGatt p0, global::Android.Bluetooth.BluetoothGattDescriptor p1, [global::Android.Runtime.GeneratedEnum] global::Android.Bluetooth.GattStatus p2)
			{
				if (id_onDescriptorWrite_Landroid_bluetooth_BluetoothGatt_Landroid_bluetooth_BluetoothGattDescriptor_I == IntPtr.Zero)
					id_onDescriptorWrite_Landroid_bluetooth_BluetoothGatt_Landroid_bluetooth_BluetoothGattDescriptor_I = JNIEnv.GetMethodID (class_ref, "onDescriptorWrite", "(Landroid/bluetooth/BluetoothGatt;Landroid/bluetooth/BluetoothGattDescriptor;I)V");
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue ((int) p2);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onDescriptorWrite_Landroid_bluetooth_BluetoothGatt_Landroid_bluetooth_BluetoothGattDescriptor_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDescriptorWrite", "(Landroid/bluetooth/BluetoothGatt;Landroid/bluetooth/BluetoothGattDescriptor;I)V"), __args);
				} finally {
				}
			}

			static Delegate cb_onReadRemoteRssi_Landroid_bluetooth_BluetoothGatt_II;
#pragma warning disable 0169
			static Delegate GetOnReadRemoteRssi_Landroid_bluetooth_BluetoothGatt_IIHandler ()
			{
				if (cb_onReadRemoteRssi_Landroid_bluetooth_BluetoothGatt_II == null)
					cb_onReadRemoteRssi_Landroid_bluetooth_BluetoothGatt_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_OnReadRemoteRssi_Landroid_bluetooth_BluetoothGatt_II);
				return cb_onReadRemoteRssi_Landroid_bluetooth_BluetoothGatt_II;
			}

			static void n_OnReadRemoteRssi_Landroid_bluetooth_BluetoothGatt_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int native_p2)
			{
				global::Com.Qcl.VH.Ble.EnhancedBleService.鷭 __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Ble.EnhancedBleService.鷭> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Bluetooth.BluetoothGatt p0 = global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothGatt> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Bluetooth.GattStatus p2 = (global::Android.Bluetooth.GattStatus) native_p2;
				__this.OnReadRemoteRssi (p0, p1, p2);
			}
#pragma warning restore 0169

			static IntPtr id_onReadRemoteRssi_Landroid_bluetooth_BluetoothGatt_II;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='EnhancedBleService.鷭']/method[@name='onReadRemoteRssi' and count(parameter)=3 and parameter[1][@type='android.bluetooth.BluetoothGatt'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("onReadRemoteRssi", "(Landroid/bluetooth/BluetoothGatt;II)V", "GetOnReadRemoteRssi_Landroid_bluetooth_BluetoothGatt_IIHandler")]
			public override unsafe void OnReadRemoteRssi (global::Android.Bluetooth.BluetoothGatt p0, int p1, [global::Android.Runtime.GeneratedEnum] global::Android.Bluetooth.GattStatus p2)
			{
				if (id_onReadRemoteRssi_Landroid_bluetooth_BluetoothGatt_II == IntPtr.Zero)
					id_onReadRemoteRssi_Landroid_bluetooth_BluetoothGatt_II = JNIEnv.GetMethodID (class_ref, "onReadRemoteRssi", "(Landroid/bluetooth/BluetoothGatt;II)V");
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue ((int) p2);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onReadRemoteRssi_Landroid_bluetooth_BluetoothGatt_II, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onReadRemoteRssi", "(Landroid/bluetooth/BluetoothGatt;II)V"), __args);
				} finally {
				}
			}

			static Delegate cb_onReliableWriteCompleted_Landroid_bluetooth_BluetoothGatt_I;
#pragma warning disable 0169
			static Delegate GetOnReliableWriteCompleted_Landroid_bluetooth_BluetoothGatt_IHandler ()
			{
				if (cb_onReliableWriteCompleted_Landroid_bluetooth_BluetoothGatt_I == null)
					cb_onReliableWriteCompleted_Landroid_bluetooth_BluetoothGatt_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_OnReliableWriteCompleted_Landroid_bluetooth_BluetoothGatt_I);
				return cb_onReliableWriteCompleted_Landroid_bluetooth_BluetoothGatt_I;
			}

			static void n_OnReliableWriteCompleted_Landroid_bluetooth_BluetoothGatt_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int native_p1)
			{
				global::Com.Qcl.VH.Ble.EnhancedBleService.鷭 __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Ble.EnhancedBleService.鷭> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Bluetooth.BluetoothGatt p0 = global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothGatt> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Bluetooth.GattStatus p1 = (global::Android.Bluetooth.GattStatus) native_p1;
				__this.OnReliableWriteCompleted (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_onReliableWriteCompleted_Landroid_bluetooth_BluetoothGatt_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='EnhancedBleService.鷭']/method[@name='onReliableWriteCompleted' and count(parameter)=2 and parameter[1][@type='android.bluetooth.BluetoothGatt'] and parameter[2][@type='int']]"
			[Register ("onReliableWriteCompleted", "(Landroid/bluetooth/BluetoothGatt;I)V", "GetOnReliableWriteCompleted_Landroid_bluetooth_BluetoothGatt_IHandler")]
			public override unsafe void OnReliableWriteCompleted (global::Android.Bluetooth.BluetoothGatt p0, [global::Android.Runtime.GeneratedEnum] global::Android.Bluetooth.GattStatus p1)
			{
				if (id_onReliableWriteCompleted_Landroid_bluetooth_BluetoothGatt_I == IntPtr.Zero)
					id_onReliableWriteCompleted_Landroid_bluetooth_BluetoothGatt_I = JNIEnv.GetMethodID (class_ref, "onReliableWriteCompleted", "(Landroid/bluetooth/BluetoothGatt;I)V");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue ((int) p1);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onReliableWriteCompleted_Landroid_bluetooth_BluetoothGatt_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onReliableWriteCompleted", "(Landroid/bluetooth/BluetoothGatt;I)V"), __args);
				} finally {
				}
			}

			static Delegate cb_onServicesDiscovered_Landroid_bluetooth_BluetoothGatt_I;
#pragma warning disable 0169
			static Delegate GetOnServicesDiscovered_Landroid_bluetooth_BluetoothGatt_IHandler ()
			{
				if (cb_onServicesDiscovered_Landroid_bluetooth_BluetoothGatt_I == null)
					cb_onServicesDiscovered_Landroid_bluetooth_BluetoothGatt_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_OnServicesDiscovered_Landroid_bluetooth_BluetoothGatt_I);
				return cb_onServicesDiscovered_Landroid_bluetooth_BluetoothGatt_I;
			}

			static void n_OnServicesDiscovered_Landroid_bluetooth_BluetoothGatt_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int native_p1)
			{
				global::Com.Qcl.VH.Ble.EnhancedBleService.鷭 __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Ble.EnhancedBleService.鷭> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Bluetooth.BluetoothGatt p0 = global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothGatt> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Bluetooth.GattStatus p1 = (global::Android.Bluetooth.GattStatus) native_p1;
				__this.OnServicesDiscovered (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_onServicesDiscovered_Landroid_bluetooth_BluetoothGatt_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='EnhancedBleService.鷭']/method[@name='onServicesDiscovered' and count(parameter)=2 and parameter[1][@type='android.bluetooth.BluetoothGatt'] and parameter[2][@type='int']]"
			[Register ("onServicesDiscovered", "(Landroid/bluetooth/BluetoothGatt;I)V", "GetOnServicesDiscovered_Landroid_bluetooth_BluetoothGatt_IHandler")]
			public override unsafe void OnServicesDiscovered (global::Android.Bluetooth.BluetoothGatt p0, [global::Android.Runtime.GeneratedEnum] global::Android.Bluetooth.GattStatus p1)
			{
				if (id_onServicesDiscovered_Landroid_bluetooth_BluetoothGatt_I == IntPtr.Zero)
					id_onServicesDiscovered_Landroid_bluetooth_BluetoothGatt_I = JNIEnv.GetMethodID (class_ref, "onServicesDiscovered", "(Landroid/bluetooth/BluetoothGatt;I)V");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue ((int) p1);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onServicesDiscovered_Landroid_bluetooth_BluetoothGatt_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onServicesDiscovered", "(Landroid/bluetooth/BluetoothGatt;I)V"), __args);
				} finally {
				}
			}

			static IntPtr id_鷭_Landroid_bluetooth_BluetoothGatt_II;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='EnhancedBleService.鷭']/method[@name='鷭' and count(parameter)=3 and parameter[1][@type='android.bluetooth.BluetoothGatt'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("鷭", "(Landroid/bluetooth/BluetoothGatt;II)V", "")]
			protected override sealed unsafe void Invoke鷭 (global::Android.Bluetooth.BluetoothGatt p0, int p1, int p2)
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

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qcl/vh/ble/EnhancedBleService", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (EnhancedBleService); }
		}

		protected EnhancedBleService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='EnhancedBleService']/constructor[@name='EnhancedBleService' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe EnhancedBleService ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (EnhancedBleService)) {
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

		static Delegate cb_isDeviceIgnoredDueToCooloff;
#pragma warning disable 0169
		static Delegate GetIsDeviceIgnoredDueToCooloffHandler ()
		{
			if (cb_isDeviceIgnoredDueToCooloff == null)
				cb_isDeviceIgnoredDueToCooloff = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDeviceIgnoredDueToCooloff);
			return cb_isDeviceIgnoredDueToCooloff;
		}

		static bool n_IsDeviceIgnoredDueToCooloff (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Qcl.VH.Ble.EnhancedBleService __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Ble.EnhancedBleService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DeviceIgnoredDueToCooloff;
		}
#pragma warning restore 0169

		static Delegate cb_setDeviceIgnoredDueToCooloff_Z;
#pragma warning disable 0169
		static Delegate GetSetDeviceIgnoredDueToCooloff_ZHandler ()
		{
			if (cb_setDeviceIgnoredDueToCooloff_Z == null)
				cb_setDeviceIgnoredDueToCooloff_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDeviceIgnoredDueToCooloff_Z);
			return cb_setDeviceIgnoredDueToCooloff_Z;
		}

		static void n_SetDeviceIgnoredDueToCooloff_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Qcl.VH.Ble.EnhancedBleService __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Ble.EnhancedBleService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DeviceIgnoredDueToCooloff = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isDeviceIgnoredDueToCooloff;
		static IntPtr id_setDeviceIgnoredDueToCooloff_Z;
		public virtual unsafe bool DeviceIgnoredDueToCooloff {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='EnhancedBleService']/method[@name='isDeviceIgnoredDueToCooloff' and count(parameter)=0]"
			[Register ("isDeviceIgnoredDueToCooloff", "()Z", "GetIsDeviceIgnoredDueToCooloffHandler")]
			get {
				if (id_isDeviceIgnoredDueToCooloff == IntPtr.Zero)
					id_isDeviceIgnoredDueToCooloff = JNIEnv.GetMethodID (class_ref, "isDeviceIgnoredDueToCooloff", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isDeviceIgnoredDueToCooloff);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isDeviceIgnoredDueToCooloff", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='EnhancedBleService']/method[@name='setDeviceIgnoredDueToCooloff' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setDeviceIgnoredDueToCooloff", "(Z)V", "GetSetDeviceIgnoredDueToCooloff_ZHandler")]
			set {
				if (id_setDeviceIgnoredDueToCooloff_Z == IntPtr.Zero)
					id_setDeviceIgnoredDueToCooloff_Z = JNIEnv.GetMethodID (class_ref, "setDeviceIgnoredDueToCooloff", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setDeviceIgnoredDueToCooloff_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDeviceIgnoredDueToCooloff", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getScanFiltersFromAdapters;
#pragma warning disable 0169
		static Delegate GetGetScanFiltersFromAdaptersHandler ()
		{
			if (cb_getScanFiltersFromAdapters == null)
				cb_getScanFiltersFromAdapters = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetScanFiltersFromAdapters);
			return cb_getScanFiltersFromAdapters;
		}

		static IntPtr n_GetScanFiltersFromAdapters (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Qcl.VH.Ble.EnhancedBleService __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Ble.EnhancedBleService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Android.Bluetooth.LE.ScanFilter>.ToLocalJniHandle (__this.ScanFiltersFromAdapters);
		}
#pragma warning restore 0169

		static IntPtr id_getScanFiltersFromAdapters;
		protected virtual unsafe global::System.Collections.Generic.IList<global::Android.Bluetooth.LE.ScanFilter> ScanFiltersFromAdapters {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='EnhancedBleService']/method[@name='getScanFiltersFromAdapters' and count(parameter)=0]"
			[Register ("getScanFiltersFromAdapters", "()Ljava/util/ArrayList;", "GetGetScanFiltersFromAdaptersHandler")]
			get {
				if (id_getScanFiltersFromAdapters == IntPtr.Zero)
					id_getScanFiltersFromAdapters = JNIEnv.GetMethodID (class_ref, "getScanFiltersFromAdapters", "()Ljava/util/ArrayList;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Android.Bluetooth.LE.ScanFilter>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getScanFiltersFromAdapters), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Android.Bluetooth.LE.ScanFilter>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getScanFiltersFromAdapters", "()Ljava/util/ArrayList;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getBLEDevices_Lcom_qcl_vh_content_DeviceManager_;
#pragma warning disable 0169
		static Delegate GetGetBLEDevices_Lcom_qcl_vh_content_DeviceManager_Handler ()
		{
			if (cb_getBLEDevices_Lcom_qcl_vh_content_DeviceManager_ == null)
				cb_getBLEDevices_Lcom_qcl_vh_content_DeviceManager_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetBLEDevices_Lcom_qcl_vh_content_DeviceManager_);
			return cb_getBLEDevices_Lcom_qcl_vh_content_DeviceManager_;
		}

		static IntPtr n_GetBLEDevices_Lcom_qcl_vh_content_DeviceManager_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Qcl.VH.Ble.EnhancedBleService __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Ble.EnhancedBleService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Qcl.VH.Content.DeviceManager p0 = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.DeviceManager> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetBLEDevices (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getBLEDevices_Lcom_qcl_vh_content_DeviceManager_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='EnhancedBleService']/method[@name='getBLEDevices' and count(parameter)=1 and parameter[1][@type='com.qcl.vh.content.DeviceManager']]"
		[Register ("getBLEDevices", "(Lcom/qcl/vh/content/DeviceManager;)Ljava/util/HashSet;", "GetGetBLEDevices_Lcom_qcl_vh_content_DeviceManager_Handler")]
		protected virtual unsafe global::Java.Util.HashSet GetBLEDevices (global::Com.Qcl.VH.Content.DeviceManager p0)
		{
			if (id_getBLEDevices_Lcom_qcl_vh_content_DeviceManager_ == IntPtr.Zero)
				id_getBLEDevices_Lcom_qcl_vh_content_DeviceManager_ = JNIEnv.GetMethodID (class_ref, "getBLEDevices", "(Lcom/qcl/vh/content/DeviceManager;)Ljava/util/HashSet;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Java.Util.HashSet __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Util.HashSet> (JNIEnv.CallObjectMethod  (Handle, id_getBLEDevices_Lcom_qcl_vh_content_DeviceManager_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Util.HashSet> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBLEDevices", "(Lcom/qcl/vh/content/DeviceManager;)Ljava/util/HashSet;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getmScanCallback;
#pragma warning disable 0169
		static Delegate GetGetmScanCallbackHandler ()
		{
			if (cb_getmScanCallback == null)
				cb_getmScanCallback = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetmScanCallback);
			return cb_getmScanCallback;
		}

		static IntPtr n_GetmScanCallback (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Qcl.VH.Ble.EnhancedBleService __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Ble.EnhancedBleService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetmScanCallback ());
		}
#pragma warning restore 0169

		static IntPtr id_getmScanCallback;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='EnhancedBleService']/method[@name='getmScanCallback' and count(parameter)=0]"
		[Register ("getmScanCallback", "()Lcom/qcl/vh/ble/EnhancedBleService$if;", "GetGetmScanCallbackHandler")]
		public virtual unsafe global::Com.Qcl.VH.Ble.EnhancedBleService.If GetmScanCallback ()
		{
			if (id_getmScanCallback == IntPtr.Zero)
				id_getmScanCallback = JNIEnv.GetMethodID (class_ref, "getmScanCallback", "()Lcom/qcl/vh/ble/EnhancedBleService$if;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Ble.EnhancedBleService.If> (JNIEnv.CallObjectMethod  (Handle, id_getmScanCallback), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Ble.EnhancedBleService.If> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getmScanCallback", "()Lcom/qcl/vh/ble/EnhancedBleService$if;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_processScanResult_Lcom_qcl_vh_content_MedicalDevice_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetProcessScanResult_Lcom_qcl_vh_content_MedicalDevice_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_processScanResult_Lcom_qcl_vh_content_MedicalDevice_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_processScanResult_Lcom_qcl_vh_content_MedicalDevice_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_ProcessScanResult_Lcom_qcl_vh_content_MedicalDevice_Ljava_lang_String_Ljava_lang_String_);
			return cb_processScanResult_Lcom_qcl_vh_content_MedicalDevice_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_ProcessScanResult_Lcom_qcl_vh_content_MedicalDevice_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Qcl.VH.Ble.EnhancedBleService __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Ble.EnhancedBleService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Qcl.VH.Content.MedicalDevice p0 = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.MedicalDevice> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.ProcessScanResult (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_processScanResult_Lcom_qcl_vh_content_MedicalDevice_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='EnhancedBleService']/method[@name='processScanResult' and count(parameter)=3 and parameter[1][@type='com.qcl.vh.content.MedicalDevice'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("processScanResult", "(Lcom/qcl/vh/content/MedicalDevice;Ljava/lang/String;Ljava/lang/String;)V", "GetProcessScanResult_Lcom_qcl_vh_content_MedicalDevice_Ljava_lang_String_Ljava_lang_String_Handler")]
		protected virtual unsafe void ProcessScanResult (global::Com.Qcl.VH.Content.MedicalDevice p0, string p1, string p2)
		{
			if (id_processScanResult_Lcom_qcl_vh_content_MedicalDevice_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_processScanResult_Lcom_qcl_vh_content_MedicalDevice_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "processScanResult", "(Lcom/qcl/vh/content/MedicalDevice;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_processScanResult_Lcom_qcl_vh_content_MedicalDevice_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "processScanResult", "(Lcom/qcl/vh/content/MedicalDevice;Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_recordMetadata_Ljava_lang_String_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='EnhancedBleService']/method[@name='recordMetadata' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]']]"
		[Register ("recordMetadata", "(Ljava/lang/String;[B)V", "")]
		protected static unsafe void RecordMetadata (string p0, byte[] p1)
		{
			if (id_recordMetadata_Ljava_lang_String_arrayB == IntPtr.Zero)
				id_recordMetadata_Ljava_lang_String_arrayB = JNIEnv.GetStaticMethodID (class_ref, "recordMetadata", "(Ljava/lang/String;[B)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_recordMetadata_Ljava_lang_String_arrayB, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static Delegate cb_scheduleScanRestart_Landroid_content_Context_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetScheduleScanRestart_Landroid_content_Context_Ljava_lang_String_Handler ()
		{
			if (cb_scheduleScanRestart_Landroid_content_Context_Ljava_lang_String_ == null)
				cb_scheduleScanRestart_Landroid_content_Context_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_ScheduleScanRestart_Landroid_content_Context_Ljava_lang_String_);
			return cb_scheduleScanRestart_Landroid_content_Context_Ljava_lang_String_;
		}

		static void n_ScheduleScanRestart_Landroid_content_Context_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Qcl.VH.Ble.EnhancedBleService __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Ble.EnhancedBleService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.ScheduleScanRestart (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_scheduleScanRestart_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='EnhancedBleService']/method[@name='scheduleScanRestart' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("scheduleScanRestart", "(Landroid/content/Context;Ljava/lang/String;)V", "GetScheduleScanRestart_Landroid_content_Context_Ljava_lang_String_Handler")]
		public virtual unsafe void ScheduleScanRestart (global::Android.Content.Context p0, string p1)
		{
			if (id_scheduleScanRestart_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_scheduleScanRestart_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "scheduleScanRestart", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_scheduleScanRestart_Landroid_content_Context_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "scheduleScanRestart", "(Landroid/content/Context;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_startEnhancedDiscovery_Z;
#pragma warning disable 0169
		static Delegate GetStartEnhancedDiscovery_ZHandler ()
		{
			if (cb_startEnhancedDiscovery_Z == null)
				cb_startEnhancedDiscovery_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_StartEnhancedDiscovery_Z);
			return cb_startEnhancedDiscovery_Z;
		}

		static void n_StartEnhancedDiscovery_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Qcl.VH.Ble.EnhancedBleService __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Ble.EnhancedBleService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartEnhancedDiscovery (p0);
		}
#pragma warning restore 0169

		static IntPtr id_startEnhancedDiscovery_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='EnhancedBleService']/method[@name='startEnhancedDiscovery' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("startEnhancedDiscovery", "(Z)V", "GetStartEnhancedDiscovery_ZHandler")]
		public virtual unsafe void StartEnhancedDiscovery (bool p0)
		{
			if (id_startEnhancedDiscovery_Z == IntPtr.Zero)
				id_startEnhancedDiscovery_Z = JNIEnv.GetMethodID (class_ref, "startEnhancedDiscovery", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_startEnhancedDiscovery_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startEnhancedDiscovery", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_stopAndScheduleIfRequired_J;
#pragma warning disable 0169
		static Delegate GetStopAndScheduleIfRequired_JHandler ()
		{
			if (cb_stopAndScheduleIfRequired_J == null)
				cb_stopAndScheduleIfRequired_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_StopAndScheduleIfRequired_J);
			return cb_stopAndScheduleIfRequired_J;
		}

		static void n_StopAndScheduleIfRequired_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Qcl.VH.Ble.EnhancedBleService __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Ble.EnhancedBleService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopAndScheduleIfRequired (p0);
		}
#pragma warning restore 0169

		static IntPtr id_stopAndScheduleIfRequired_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='EnhancedBleService']/method[@name='stopAndScheduleIfRequired' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("stopAndScheduleIfRequired", "(J)V", "GetStopAndScheduleIfRequired_JHandler")]
		protected virtual unsafe void StopAndScheduleIfRequired (long p0)
		{
			if (id_stopAndScheduleIfRequired_J == IntPtr.Zero)
				id_stopAndScheduleIfRequired_J = JNIEnv.GetMethodID (class_ref, "stopAndScheduleIfRequired", "(J)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_stopAndScheduleIfRequired_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stopAndScheduleIfRequired", "(J)V"), __args);
			} finally {
			}
		}

		static Delegate cb_updateLastUnsuccessfullDisconnectTime_Landroid_content_Context_Ljava_lang_String_Lcom_qcl_vh_content_MedicalDevice_;
#pragma warning disable 0169
		static Delegate GetUpdateLastUnsuccessfullDisconnectTime_Landroid_content_Context_Ljava_lang_String_Lcom_qcl_vh_content_MedicalDevice_Handler ()
		{
			if (cb_updateLastUnsuccessfullDisconnectTime_Landroid_content_Context_Ljava_lang_String_Lcom_qcl_vh_content_MedicalDevice_ == null)
				cb_updateLastUnsuccessfullDisconnectTime_Landroid_content_Context_Ljava_lang_String_Lcom_qcl_vh_content_MedicalDevice_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_UpdateLastUnsuccessfullDisconnectTime_Landroid_content_Context_Ljava_lang_String_Lcom_qcl_vh_content_MedicalDevice_);
			return cb_updateLastUnsuccessfullDisconnectTime_Landroid_content_Context_Ljava_lang_String_Lcom_qcl_vh_content_MedicalDevice_;
		}

		static void n_UpdateLastUnsuccessfullDisconnectTime_Landroid_content_Context_Ljava_lang_String_Lcom_qcl_vh_content_MedicalDevice_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Qcl.VH.Ble.EnhancedBleService __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Ble.EnhancedBleService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Qcl.VH.Content.MedicalDevice p2 = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.MedicalDevice> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.UpdateLastUnsuccessfullDisconnectTime (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_updateLastUnsuccessfullDisconnectTime_Landroid_content_Context_Ljava_lang_String_Lcom_qcl_vh_content_MedicalDevice_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='EnhancedBleService']/method[@name='updateLastUnsuccessfullDisconnectTime' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.qcl.vh.content.MedicalDevice']]"
		[Register ("updateLastUnsuccessfullDisconnectTime", "(Landroid/content/Context;Ljava/lang/String;Lcom/qcl/vh/content/MedicalDevice;)V", "GetUpdateLastUnsuccessfullDisconnectTime_Landroid_content_Context_Ljava_lang_String_Lcom_qcl_vh_content_MedicalDevice_Handler")]
		protected virtual unsafe void UpdateLastUnsuccessfullDisconnectTime (global::Android.Content.Context p0, string p1, global::Com.Qcl.VH.Content.MedicalDevice p2)
		{
			if (id_updateLastUnsuccessfullDisconnectTime_Landroid_content_Context_Ljava_lang_String_Lcom_qcl_vh_content_MedicalDevice_ == IntPtr.Zero)
				id_updateLastUnsuccessfullDisconnectTime_Landroid_content_Context_Ljava_lang_String_Lcom_qcl_vh_content_MedicalDevice_ = JNIEnv.GetMethodID (class_ref, "updateLastUnsuccessfullDisconnectTime", "(Landroid/content/Context;Ljava/lang/String;Lcom/qcl/vh/content/MedicalDevice;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_updateLastUnsuccessfullDisconnectTime_Landroid_content_Context_Ljava_lang_String_Lcom_qcl_vh_content_MedicalDevice_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateLastUnsuccessfullDisconnectTime", "(Landroid/content/Context;Ljava/lang/String;Lcom/qcl/vh/content/MedicalDevice;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_updateMetadata_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='EnhancedBleService']/method[@name='updateMetadata' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("updateMetadata", "(Ljava/lang/String;)V", "")]
		protected static unsafe void UpdateMetadata (string p0)
		{
			if (id_updateMetadata_Ljava_lang_String_ == IntPtr.Zero)
				id_updateMetadata_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "updateMetadata", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_updateMetadata_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
