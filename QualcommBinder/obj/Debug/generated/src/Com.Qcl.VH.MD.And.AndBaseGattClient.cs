using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.MD.And {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.md.and']/class[@name='AndBaseGattClient']"
	[global::Android.Runtime.Register ("com/qcl/vh/md/and/AndBaseGattClient", DoNotGenerateAcw=true)]
	public abstract partial class AndBaseGattClient : global::Com.Qcl.VH.Ble.BaseGattClient {


		static IntPtr ģ_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.md.and']/class[@name='AndBaseGattClient']/field[@name='ģ']"
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

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.md.and']/class[@name='AndBaseGattClient']/field[@name='Ĥ']"
		[Register ("Ĥ")]
		protected global::Java.Util.UUID Ĥ {
			get {
				if (Ĥ_jfieldId == IntPtr.Zero)
					Ĥ_jfieldId = JNIEnv.GetFieldID (class_ref, "Ĥ", "Ljava/util/UUID;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, Ĥ_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (Ĥ_jfieldId == IntPtr.Zero)
					Ĥ_jfieldId = JNIEnv.GetFieldID (class_ref, "Ĥ", "Ljava/util/UUID;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, Ĥ_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr Ħ_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.md.and']/class[@name='AndBaseGattClient']/field[@name='Ħ']"
		[Register ("Ħ")]
		protected int Ħ {
			get {
				if (Ħ_jfieldId == IntPtr.Zero)
					Ħ_jfieldId = JNIEnv.GetFieldID (class_ref, "Ħ", "I");
				return JNIEnv.GetIntField (Handle, Ħ_jfieldId);
			}
			set {
				if (Ħ_jfieldId == IntPtr.Zero)
					Ħ_jfieldId = JNIEnv.GetFieldID (class_ref, "Ħ", "I");
				try {
					JNIEnv.SetField (Handle, Ħ_jfieldId, value);
				} finally {
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.md.and']/class[@name='AndBaseGattClient.鷭']"
		[global::Android.Runtime.Register ("com/qcl/vh/md/and/AndBaseGattClient$鷭", DoNotGenerateAcw=true)]
		public new partial class 鷭 : global::Android.Content.BroadcastReceiver {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/qcl/vh/md/and/AndBaseGattClient$鷭", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (鷭); }
			}

			protected 鷭 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_onReceive_Landroid_content_Context_Landroid_content_Intent_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.and']/class[@name='AndBaseGattClient.鷭']/method[@name='onReceive' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.Intent']]"
			[Register ("onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V", "")]
			public override sealed unsafe void OnReceive (global::Android.Content.Context p0, global::Android.Content.Intent p1)
			{
				if (id_onReceive_Landroid_content_Context_Landroid_content_Intent_ == IntPtr.Zero)
					id_onReceive_Landroid_content_Context_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					JNIEnv.CallVoidMethod  (Handle, id_onReceive_Landroid_content_Context_Landroid_content_Intent_, __args);
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qcl/vh/md/and/AndBaseGattClient", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AndBaseGattClient); }
		}

		protected AndBaseGattClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.md.and']/class[@name='AndBaseGattClient']/constructor[@name='AndBaseGattClient' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AndBaseGattClient ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (AndBaseGattClient)) {
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
			global::Com.Qcl.VH.MD.And.AndBaseGattClient __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.MD.And.AndBaseGattClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Ć ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.and']/class[@name='AndBaseGattClient']/method[@name='ć' and count(parameter)=0]"
		[Register ("ć", "()V", "GetĆHandler")]
		protected abstract void Ć ();

		static Delegate cb_ˮ͈_arrayB;
#pragma warning disable 0169
		static Delegate Getˮ͈_arrayBHandler ()
		{
			if (cb_ˮ͈_arrayB == null)
				cb_ˮ͈_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ˮ͈_arrayB);
			return cb_ˮ͈_arrayB;
		}

		static IntPtr n_ˮ͈_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Qcl.VH.MD.And.AndBaseGattClient __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.MD.And.AndBaseGattClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Integer>.ToLocalJniHandle (__this.ˮ͈ (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.and']/class[@name='AndBaseGattClient']/method[@name='ˮ͈' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("ˮ͈", "([B)Ljava/util/HashMap;", "Getˮ͈_arrayBHandler")]
		protected abstract global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Integer> ˮ͈ (byte[] p0);

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
			global::Com.Qcl.VH.MD.And.AndBaseGattClient __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.MD.And.AndBaseGattClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ˮ͍ ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.and']/class[@name='AndBaseGattClient']/method[@name='ˮ͍' and count(parameter)=0]"
		[Register ("ˮ͍", "()V", "Getˮ͍Handler")]
		protected abstract void ˮ͍ ();

		static IntPtr id_櫯_Landroid_bluetooth_BluetoothGatt_Ljava_util_UUID_arrayBIILjava_util_List_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.and']/class[@name='AndBaseGattClient']/method[@name='櫯' and count(parameter)=7 and parameter[1][@type='android.bluetooth.BluetoothGatt'] and parameter[2][@type='java.util.UUID'] and parameter[3][@type='byte[]'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='java.util.List&lt;android.bluetooth.BluetoothGattDescriptor&gt;'] and parameter[7][@type='int']]"
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

		static Delegate cb_櫯_arrayB;
#pragma warning disable 0169
		static Delegate Get櫯_arrayBHandler ()
		{
			if (cb_櫯_arrayB == null)
				cb_櫯_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_櫯_arrayB);
			return cb_櫯_arrayB;
		}

		static bool n_櫯_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Qcl.VH.MD.And.AndBaseGattClient __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.MD.And.AndBaseGattClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			bool __ret = __this.櫯 (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.and']/class[@name='AndBaseGattClient']/method[@name='櫯' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("櫯", "([B)Z", "Get櫯_arrayBHandler")]
		protected abstract bool 櫯 (byte[] p0);

		static IntPtr id_鷭_Landroid_bluetooth_BluetoothGatt_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.and']/class[@name='AndBaseGattClient']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='android.bluetooth.BluetoothGatt']]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.and']/class[@name='AndBaseGattClient']/method[@name='鷭' and count(parameter)=3 and parameter[1][@type='android.bluetooth.BluetoothGatt'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.and']/class[@name='AndBaseGattClient']/method[@name='鷭' and count(parameter)=6 and parameter[1][@type='android.bluetooth.BluetoothGatt'] and parameter[2][@type='java.util.UUID'] and parameter[3][@type='byte[]'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='java.util.List&lt;android.bluetooth.BluetoothGattDescriptor&gt;']]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.and']/class[@name='AndBaseGattClient']/method[@name='鷭' and count(parameter)=7 and parameter[1][@type='android.bluetooth.BluetoothGatt'] and parameter[2][@type='java.util.UUID'] and parameter[3][@type='byte[]'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='java.util.List&lt;android.bluetooth.BluetoothGattDescriptor&gt;'] and parameter[7][@type='int']]"
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

		static IntPtr id_鷭_Landroid_bluetooth_BluetoothGatt_Ljava_util_UUID_arrayBILjava_util_UUID_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.and']/class[@name='AndBaseGattClient']/method[@name='鷭' and count(parameter)=6 and parameter[1][@type='android.bluetooth.BluetoothGatt'] and parameter[2][@type='java.util.UUID'] and parameter[3][@type='byte[]'] and parameter[4][@type='int'] and parameter[5][@type='java.util.UUID'] and parameter[6][@type='int']]"
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

		static Delegate cb_鷭_arrayB;
#pragma warning disable 0169
		static Delegate GetInvoke鷭_arrayBHandler ()
		{
			if (cb_鷭_arrayB == null)
				cb_鷭_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Invoke鷭_arrayB);
			return cb_鷭_arrayB;
		}

		static bool n_Invoke鷭_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Qcl.VH.MD.And.AndBaseGattClient __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.MD.And.AndBaseGattClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			bool __ret = __this.Invoke鷭 (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_鷭_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.and']/class[@name='AndBaseGattClient']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("鷭", "([B)Z", "GetInvoke鷭_arrayBHandler")]
		protected override unsafe bool Invoke鷭 (byte[] p0)
		{
			if (id_鷭_arrayB == IntPtr.Zero)
				id_鷭_arrayB = JNIEnv.GetMethodID (class_ref, "鷭", "([B)Z");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_鷭_arrayB, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "鷭", "([B)Z"), __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_鷭_Ljava_util_UUID_arrayB;
#pragma warning disable 0169
		static Delegate GetInvoke鷭_Ljava_util_UUID_arrayBHandler ()
		{
			if (cb_鷭_Ljava_util_UUID_arrayB == null)
				cb_鷭_Ljava_util_UUID_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Invoke鷭_Ljava_util_UUID_arrayB);
			return cb_鷭_Ljava_util_UUID_arrayB;
		}

		static void n_Invoke鷭_Ljava_util_UUID_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Qcl.VH.MD.And.AndBaseGattClient __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.MD.And.AndBaseGattClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.UUID p0 = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_p0, JniHandleOwnership.DoNotTransfer);
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.Invoke鷭 (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.and']/class[@name='AndBaseGattClient']/method[@name='鷭' and count(parameter)=2 and parameter[1][@type='java.util.UUID'] and parameter[2][@type='byte[]']]"
		[Register ("鷭", "(Ljava/util/UUID;[B)V", "GetInvoke鷭_Ljava_util_UUID_arrayBHandler")]
		protected abstract void Invoke鷭 (global::Java.Util.UUID p0, byte[] p1);

	}

	[global::Android.Runtime.Register ("com/qcl/vh/md/and/AndBaseGattClient", DoNotGenerateAcw=true)]
	internal partial class AndBaseGattClientInvoker : AndBaseGattClient {

		public AndBaseGattClientInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (AndBaseGattClientInvoker); }
		}

		static IntPtr id_ć;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.and']/class[@name='AndBaseGattClient']/method[@name='ć' and count(parameter)=0]"
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

		static IntPtr id_ˮ͈_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.and']/class[@name='AndBaseGattClient']/method[@name='ˮ͈' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("ˮ͈", "([B)Ljava/util/HashMap;", "Getˮ͈_arrayBHandler")]
		protected override unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Integer> ˮ͈ (byte[] p0)
		{
			if (id_ˮ͈_arrayB == IntPtr.Zero)
				id_ˮ͈_arrayB = JNIEnv.GetMethodID (class_ref, "ˮ͈", "([B)Ljava/util/HashMap;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Integer> __ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Integer>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_ˮ͈_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_ˮ͍;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.and']/class[@name='AndBaseGattClient']/method[@name='ˮ͍' and count(parameter)=0]"
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

		static IntPtr id_櫯_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.and']/class[@name='AndBaseGattClient']/method[@name='櫯' and count(parameter)=1 and parameter[1][@type='byte[]']]"
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

		static IntPtr id_鷭_Ljava_util_UUID_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.and']/class[@name='AndBaseGattClient']/method[@name='鷭' and count(parameter)=2 and parameter[1][@type='java.util.UUID'] and parameter[2][@type='byte[]']]"
		[Register ("鷭", "(Ljava/util/UUID;[B)V", "GetInvoke鷭_Ljava_util_UUID_arrayBHandler")]
		protected override unsafe void Invoke鷭 (global::Java.Util.UUID p0, byte[] p1)
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

	}

}
