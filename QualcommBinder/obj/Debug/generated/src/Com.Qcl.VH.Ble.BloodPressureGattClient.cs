using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.Ble {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BloodPressureGattClient']"
	[global::Android.Runtime.Register ("com/qcl/vh/ble/BloodPressureGattClient", DoNotGenerateAcw=true)]
	public abstract partial class BloodPressureGattClient : global::Com.Qcl.VH.Ble.BaseGattClient {


		static IntPtr ģ_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BloodPressureGattClient']/field[@name='ģ']"
		[Register ("ģ")]
		protected global::Java.Util.LinkedList Ģ {
			get {
				if (ģ_jfieldId == IntPtr.Zero)
					ģ_jfieldId = JNIEnv.GetFieldID (class_ref, "ģ", "Ljava/util/LinkedList;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, ģ_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Util.LinkedList> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (ģ_jfieldId == IntPtr.Zero)
					ģ_jfieldId = JNIEnv.GetFieldID (class_ref, "ģ", "Ljava/util/LinkedList;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, ģ_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr Ĥ_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BloodPressureGattClient']/field[@name='Ĥ']"
		[Register ("Ĥ")]
		protected int Ĥ {
			get {
				if (Ĥ_jfieldId == IntPtr.Zero)
					Ĥ_jfieldId = JNIEnv.GetFieldID (class_ref, "Ĥ", "I");
				return JNIEnv.GetIntField (Handle, Ĥ_jfieldId);
			}
			set {
				if (Ĥ_jfieldId == IntPtr.Zero)
					Ĥ_jfieldId = JNIEnv.GetFieldID (class_ref, "Ĥ", "I");
				try {
					JNIEnv.SetField (Handle, Ĥ_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr Ħ_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BloodPressureGattClient']/field[@name='Ħ']"
		[Register ("Ħ")]
		protected global::Java.Util.UUID Ħ {
			get {
				if (Ħ_jfieldId == IntPtr.Zero)
					Ħ_jfieldId = JNIEnv.GetFieldID (class_ref, "Ħ", "Ljava/util/UUID;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, Ħ_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (Ħ_jfieldId == IntPtr.Zero)
					Ħ_jfieldId = JNIEnv.GetFieldID (class_ref, "Ħ", "Ljava/util/UUID;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, Ħ_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr Ĩ_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BloodPressureGattClient']/field[@name='Ĩ']"
		[Register ("Ĩ")]
		protected string Ĩ {
			get {
				if (Ĩ_jfieldId == IntPtr.Zero)
					Ĩ_jfieldId = JNIEnv.GetFieldID (class_ref, "Ĩ", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, Ĩ_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (Ĩ_jfieldId == IntPtr.Zero)
					Ĩ_jfieldId = JNIEnv.GetFieldID (class_ref, "Ĩ", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, Ĩ_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr 廑_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BloodPressureGattClient']/field[@name='廑']"
		[Register ("廑")]
		protected global::Com.Qcl.VH.Decoder.鷭 廑 {
			get {
				if (廑_jfieldId == IntPtr.Zero)
					廑_jfieldId = JNIEnv.GetFieldID (class_ref, "廑", "Lcom/qcl/vh/decoder/鷭;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, 廑_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Decoder.鷭> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (廑_jfieldId == IntPtr.Zero)
					廑_jfieldId = JNIEnv.GetFieldID (class_ref, "廑", "Lcom/qcl/vh/decoder/鷭;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, 廑_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qcl/vh/ble/BloodPressureGattClient", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BloodPressureGattClient); }
		}

		protected BloodPressureGattClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BloodPressureGattClient']/constructor[@name='BloodPressureGattClient' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BloodPressureGattClient ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (BloodPressureGattClient)) {
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

		static Delegate cb_ć;
#pragma warning disable 0169
		static Delegate GetĆHandler ()
		{
			if (cb_ć == null)
				cb_ć = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Ć);
			return cb_ć;
		}

		static void n_Ć (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Qcl.VH.Ble.BloodPressureGattClient __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Ble.BloodPressureGattClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Ć ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BloodPressureGattClient']/method[@name='ć' and count(parameter)=0]"
		[Register ("ć", "()V", "GetĆHandler")]
		protected abstract void Ć ();

		static Delegate cb_Ȋ;
#pragma warning disable 0169
		static Delegate GetȊHandler ()
		{
			if (cb_Ȋ == null)
				cb_Ȋ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Ȋ);
			return cb_Ȋ;
		}

		static void n_Ȋ (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Qcl.VH.Ble.BloodPressureGattClient __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Ble.BloodPressureGattClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Ȋ ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BloodPressureGattClient']/method[@name='Ȋ' and count(parameter)=0]"
		[Register ("Ȋ", "()V", "GetȊHandler")]
		protected abstract void Ȋ ();

		static Delegate cb_ˮ͍;
#pragma warning disable 0169
		static Delegate Getˮ͍Handler ()
		{
			if (cb_ˮ͍ == null)
				cb_ˮ͍ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ˮ͍);
			return cb_ˮ͍;
		}

		static void n_ˮ͍ (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Qcl.VH.Ble.BloodPressureGattClient __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Ble.BloodPressureGattClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ˮ͍ ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BloodPressureGattClient']/method[@name='ˮ͍' and count(parameter)=0]"
		[Register ("ˮ͍", "()V", "Getˮ͍Handler")]
		protected abstract void ˮ͍ ();

		static Delegate cb_岱;
#pragma warning disable 0169
		static Delegate Get岱Handler ()
		{
			if (cb_岱 == null)
				cb_岱 = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_岱);
			return cb_岱;
		}

		static void n_岱 (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Qcl.VH.Ble.BloodPressureGattClient __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Ble.BloodPressureGattClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.岱 ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BloodPressureGattClient']/method[@name='岱' and count(parameter)=0]"
		[Register ("岱", "()V", "Get岱Handler")]
		protected abstract void 岱 ();

		static IntPtr id_鷭;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BloodPressureGattClient']/method[@name='鷭' and count(parameter)=0]"
		[Register ("鷭", "()Landroid/bluetooth/le/ScanFilter;", "")]
		protected override sealed unsafe global::Android.Bluetooth.LE.ScanFilter 鷭 ()
		{
			if (id_鷭 == IntPtr.Zero)
				id_鷭 = JNIEnv.GetMethodID (class_ref, "鷭", "()Landroid/bluetooth/le/ScanFilter;");
			try {
				return global::Java.Lang.Object.GetObject<global::Android.Bluetooth.LE.ScanFilter> (JNIEnv.CallObjectMethod  (Handle, id_鷭), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_鷭_Landroid_bluetooth_BluetoothGatt_;
#pragma warning disable 0169
		static Delegate Get鷭_Landroid_bluetooth_BluetoothGatt_Handler ()
		{
			if (cb_鷭_Landroid_bluetooth_BluetoothGatt_ == null)
				cb_鷭_Landroid_bluetooth_BluetoothGatt_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_鷭_Landroid_bluetooth_BluetoothGatt_);
			return cb_鷭_Landroid_bluetooth_BluetoothGatt_;
		}

		static void n_鷭_Landroid_bluetooth_BluetoothGatt_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Qcl.VH.Ble.BloodPressureGattClient __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Ble.BloodPressureGattClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Bluetooth.BluetoothGatt p0 = global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothGatt> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.鷭 (p0);
		}
#pragma warning restore 0169

		static IntPtr id_鷭_Landroid_bluetooth_BluetoothGatt_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BloodPressureGattClient']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='android.bluetooth.BluetoothGatt']]"
		[Register ("鷭", "(Landroid/bluetooth/BluetoothGatt;)V", "Get鷭_Landroid_bluetooth_BluetoothGatt_Handler")]
		protected override unsafe void 鷭 (global::Android.Bluetooth.BluetoothGatt p0)
		{
			if (id_鷭_Landroid_bluetooth_BluetoothGatt_ == IntPtr.Zero)
				id_鷭_Landroid_bluetooth_BluetoothGatt_ = JNIEnv.GetMethodID (class_ref, "鷭", "(Landroid/bluetooth/BluetoothGatt;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_鷭_Landroid_bluetooth_BluetoothGatt_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "鷭", "(Landroid/bluetooth/BluetoothGatt;)V"), __args);
			} finally {
			}
		}

		static IntPtr id_鷭_Landroid_bluetooth_BluetoothGatt_Ljava_util_UUID_arrayBIILjava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BloodPressureGattClient']/method[@name='鷭' and count(parameter)=6 and parameter[1][@type='android.bluetooth.BluetoothGatt'] and parameter[2][@type='java.util.UUID'] and parameter[3][@type='byte[]'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='java.util.List&lt;android.bluetooth.BluetoothGattDescriptor&gt;']]"
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

		static IntPtr id_鷭_Landroid_bluetooth_BluetoothGatt_Ljava_util_UUID_arrayBIILjava_util_List_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BloodPressureGattClient']/method[@name='鷭' and count(parameter)=7 and parameter[1][@type='android.bluetooth.BluetoothGatt'] and parameter[2][@type='java.util.UUID'] and parameter[3][@type='byte[]'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='java.util.List&lt;android.bluetooth.BluetoothGattDescriptor&gt;'] and parameter[7][@type='int']]"
		[Register ("鷭", "(Landroid/bluetooth/BluetoothGatt;Ljava/util/UUID;[BIILjava/util/List;I)V", "")]
		public override sealed unsafe void 鷭 (global::Android.Bluetooth.BluetoothGatt p0, global::Java.Util.UUID p1, byte[] p2, int p3, int p4, global::System.Collections.Generic.IList<global::Android.Bluetooth.BluetoothGattDescriptor> p5, int p6)
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

		static IntPtr id_鷭_Landroid_bluetooth_BluetoothGatt_Ljava_util_UUID_arrayBILjava_util_UUID_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BloodPressureGattClient']/method[@name='鷭' and count(parameter)=6 and parameter[1][@type='android.bluetooth.BluetoothGatt'] and parameter[2][@type='java.util.UUID'] and parameter[3][@type='byte[]'] and parameter[4][@type='int'] and parameter[5][@type='java.util.UUID'] and parameter[6][@type='int']]"
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

		static Delegate cb_鷭_Ljava_util_UUID_arrayB;
#pragma warning disable 0169
		static Delegate Get鷭_Ljava_util_UUID_arrayBHandler ()
		{
			if (cb_鷭_Ljava_util_UUID_arrayB == null)
				cb_鷭_Ljava_util_UUID_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_鷭_Ljava_util_UUID_arrayB);
			return cb_鷭_Ljava_util_UUID_arrayB;
		}

		static void n_鷭_Ljava_util_UUID_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Qcl.VH.Ble.BloodPressureGattClient __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Ble.BloodPressureGattClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.UUID p0 = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_p0, JniHandleOwnership.DoNotTransfer);
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.鷭 (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BloodPressureGattClient']/method[@name='鷭' and count(parameter)=2 and parameter[1][@type='java.util.UUID'] and parameter[2][@type='byte[]']]"
		[Register ("鷭", "(Ljava/util/UUID;[B)V", "Get鷭_Ljava_util_UUID_arrayBHandler")]
		protected abstract void 鷭 (global::Java.Util.UUID p0, byte[] p1);

	}

	[global::Android.Runtime.Register ("com/qcl/vh/ble/BloodPressureGattClient", DoNotGenerateAcw=true)]
	internal partial class BloodPressureGattClientInvoker : BloodPressureGattClient {

		public BloodPressureGattClientInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (BloodPressureGattClientInvoker); }
		}

		static IntPtr id_ć;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BloodPressureGattClient']/method[@name='ć' and count(parameter)=0]"
		[Register ("ć", "()V", "GetĆHandler")]
		protected override unsafe void Ć ()
		{
			if (id_ć == IntPtr.Zero)
				id_ć = JNIEnv.GetMethodID (class_ref, "ć", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_ć);
			} finally {
			}
		}

		static IntPtr id_Ȋ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BloodPressureGattClient']/method[@name='Ȋ' and count(parameter)=0]"
		[Register ("Ȋ", "()V", "GetȊHandler")]
		protected override unsafe void Ȋ ()
		{
			if (id_Ȋ == IntPtr.Zero)
				id_Ȋ = JNIEnv.GetMethodID (class_ref, "Ȋ", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_Ȋ);
			} finally {
			}
		}

		static IntPtr id_ˮ͍;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BloodPressureGattClient']/method[@name='ˮ͍' and count(parameter)=0]"
		[Register ("ˮ͍", "()V", "Getˮ͍Handler")]
		protected override unsafe void ˮ͍ ()
		{
			if (id_ˮ͍ == IntPtr.Zero)
				id_ˮ͍ = JNIEnv.GetMethodID (class_ref, "ˮ͍", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_ˮ͍);
			} finally {
			}
		}

		static IntPtr id_岱;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BloodPressureGattClient']/method[@name='岱' and count(parameter)=0]"
		[Register ("岱", "()V", "Get岱Handler")]
		protected override unsafe void 岱 ()
		{
			if (id_岱 == IntPtr.Zero)
				id_岱 = JNIEnv.GetMethodID (class_ref, "岱", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_岱);
			} finally {
			}
		}

		static IntPtr id_鷭_Ljava_util_UUID_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BloodPressureGattClient']/method[@name='鷭' and count(parameter)=2 and parameter[1][@type='java.util.UUID'] and parameter[2][@type='byte[]']]"
		[Register ("鷭", "(Ljava/util/UUID;[B)V", "Get鷭_Ljava_util_UUID_arrayBHandler")]
		protected override unsafe void 鷭 (global::Java.Util.UUID p0, byte[] p1)
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

		static IntPtr id_櫯_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BaseGattClient']/method[@name='櫯' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("櫯", "([B)Z", "Get櫯_arrayBHandler")]
		protected override unsafe bool 櫯 (byte[] p0)
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

		static IntPtr id_鷭_Landroid_bluetooth_BluetoothGatt_Ljava_util_UUID_arrayBIILjava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BaseGattClient']/method[@name='鷭' and count(parameter)=6 and parameter[1][@type='android.bluetooth.BluetoothGatt'] and parameter[2][@type='java.util.UUID'] and parameter[3][@type='byte[]'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='java.util.List&lt;android.bluetooth.BluetoothGattDescriptor&gt;']]"
		[Register ("鷭", "(Landroid/bluetooth/BluetoothGatt;Ljava/util/UUID;[BIILjava/util/List;)V", "GetInvoke鷭_Landroid_bluetooth_BluetoothGatt_Ljava_util_UUID_arrayBIILjava_util_List_Handler")]
		public override unsafe void Invoke鷭 (global::Android.Bluetooth.BluetoothGatt p0, global::Java.Util.UUID p1, byte[] p2, int p3, int p4, global::System.Collections.Generic.IList<global::Android.Bluetooth.BluetoothGattDescriptor> p5)
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
