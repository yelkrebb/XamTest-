using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.MD.Propellerhealth {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.md.propellerhealth']/class[@name='PropellerGenericGattClient']"
	[global::Android.Runtime.Register ("com/qcl/vh/md/propellerhealth/PropellerGenericGattClient", DoNotGenerateAcw=true)]
	public abstract partial class PropellerGenericGattClient : global::Com.Qcl.VH.Ble.BaseGattClient, global::Com.Qcl.VH.Content.ICommandsAdapter {


		static IntPtr ģ_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.md.propellerhealth']/class[@name='PropellerGenericGattClient']/field[@name='ģ']"
		[Register ("ģ")]
		protected static global::Java.Util.UUID Ģ {
			get {
				if (ģ_jfieldId == IntPtr.Zero)
					ģ_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ģ", "Ljava/util/UUID;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ģ_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Ĥ_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.md.propellerhealth']/class[@name='PropellerGenericGattClient']/field[@name='Ĥ']"
		[Register ("Ĥ")]
		protected static global::Java.Util.UUID Ĥ {
			get {
				if (Ĥ_jfieldId == IntPtr.Zero)
					Ĥ_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Ĥ", "Ljava/util/UUID;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Ĥ_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Ħ_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.md.propellerhealth']/class[@name='PropellerGenericGattClient']/field[@name='Ħ']"
		[Register ("Ħ")]
		protected global::Java.Util.LinkedList Ħ {
			get {
				if (Ħ_jfieldId == IntPtr.Zero)
					Ħ_jfieldId = JNIEnv.GetFieldID (class_ref, "Ħ", "Ljava/util/LinkedList;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, Ħ_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Util.LinkedList> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (Ħ_jfieldId == IntPtr.Zero)
					Ħ_jfieldId = JNIEnv.GetFieldID (class_ref, "Ħ", "Ljava/util/LinkedList;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, Ħ_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qcl/vh/md/propellerhealth/PropellerGenericGattClient", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PropellerGenericGattClient); }
		}

		protected PropellerGenericGattClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.md.propellerhealth']/class[@name='PropellerGenericGattClient']/constructor[@name='PropellerGenericGattClient' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PropellerGenericGattClient ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (PropellerGenericGattClient)) {
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.propellerhealth']/class[@name='PropellerGenericGattClient']/method[@name='ˮ͈' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static IntPtr id_櫯_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.propellerhealth']/class[@name='PropellerGenericGattClient']/method[@name='櫯' and count(parameter)=1 and parameter[1][@type='byte[]']]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.propellerhealth']/class[@name='PropellerGenericGattClient']/method[@name='鷭' and count(parameter)=0]"
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

		static IntPtr id_鷭_Landroid_bluetooth_BluetoothGatt_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.propellerhealth']/class[@name='PropellerGenericGattClient']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='android.bluetooth.BluetoothGatt']]"
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

		static Delegate cb_鷭_Landroid_bluetooth_BluetoothSocket_arrayBLjava_lang_String_;
#pragma warning disable 0169
		static Delegate Get鷭_Landroid_bluetooth_BluetoothSocket_arrayBLjava_lang_String_Handler ()
		{
			if (cb_鷭_Landroid_bluetooth_BluetoothSocket_arrayBLjava_lang_String_ == null)
				cb_鷭_Landroid_bluetooth_BluetoothSocket_arrayBLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_鷭_Landroid_bluetooth_BluetoothSocket_arrayBLjava_lang_String_);
			return cb_鷭_Landroid_bluetooth_BluetoothSocket_arrayBLjava_lang_String_;
		}

		static IntPtr n_鷭_Landroid_bluetooth_BluetoothSocket_arrayBLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Qcl.VH.MD.Propellerhealth.PropellerGenericGattClient __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.MD.Propellerhealth.PropellerGenericGattClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Bluetooth.BluetoothSocket p0 = global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothSocket> (native_p0, JniHandleOwnership.DoNotTransfer);
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.鷭 (p0, p1, p2));
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_鷭_Landroid_bluetooth_BluetoothSocket_arrayBLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.propellerhealth']/class[@name='PropellerGenericGattClient']/method[@name='鷭' and count(parameter)=3 and parameter[1][@type='android.bluetooth.BluetoothSocket'] and parameter[2][@type='byte[]'] and parameter[3][@type='java.lang.String']]"
		[Register ("鷭", "(Landroid/bluetooth/BluetoothSocket;[BLjava/lang/String;)Lcom/qcl/vh/a/c/ˮ͍;", "Get鷭_Landroid_bluetooth_BluetoothSocket_arrayBLjava_lang_String_Handler")]
		public virtual unsafe global::Com.Qcl.VH.A.C.ˮ͍ 鷭 (global::Android.Bluetooth.BluetoothSocket p0, byte[] p1, string p2)
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

				global::Com.Qcl.VH.A.C.ˮ͍ __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.A.C.ˮ͍> (JNIEnv.CallObjectMethod  (Handle, id_鷭_Landroid_bluetooth_BluetoothSocket_arrayBLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.A.C.ˮ͍> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "鷭", "(Landroid/bluetooth/BluetoothSocket;[BLjava/lang/String;)Lcom/qcl/vh/a/c/ˮ͍;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_鷭_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.propellerhealth']/class[@name='PropellerGenericGattClient']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='byte[]']]"
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

		static IntPtr id_鷭_arrayBLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.propellerhealth']/class[@name='PropellerGenericGattClient']/method[@name='鷭' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='java.lang.String']]"
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

	[global::Android.Runtime.Register ("com/qcl/vh/md/propellerhealth/PropellerGenericGattClient", DoNotGenerateAcw=true)]
	internal partial class PropellerGenericGattClientInvoker : PropellerGenericGattClient {

		public PropellerGenericGattClientInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (PropellerGenericGattClientInvoker); }
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
