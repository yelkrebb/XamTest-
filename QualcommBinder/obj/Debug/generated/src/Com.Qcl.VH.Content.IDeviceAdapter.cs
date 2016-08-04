using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.Content {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.qcl.vh.content']/interface[@name='DeviceAdapter']"
	[Register ("com/qcl/vh/content/DeviceAdapter", "", "Com.Qcl.VH.Content.IDeviceAdapterInvoker")]
	public partial interface IDeviceAdapter : global::Com.Qcl.VH.Content.ICommandsAdapter {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/interface[@name='DeviceAdapter']/method[@name='櫯' and count(parameter)=1 and parameter[1][@type='android.bluetooth.BluetoothSocket']]"
		[Register ("櫯", "(Landroid/bluetooth/BluetoothSocket;)V", "Get櫯_Landroid_bluetooth_BluetoothSocket_Handler:Com.Qcl.VH.Content.IDeviceAdapterInvoker, QualcommBinder")]
		void 櫯 (global::Android.Bluetooth.BluetoothSocket p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/interface[@name='DeviceAdapter']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='android.bluetooth.BluetoothSocket']]"
		[Register ("鷭", "(Landroid/bluetooth/BluetoothSocket;)Z", "Get鷭_Landroid_bluetooth_BluetoothSocket_Handler:Com.Qcl.VH.Content.IDeviceAdapterInvoker, QualcommBinder")]
		bool 鷭 (global::Android.Bluetooth.BluetoothSocket p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/interface[@name='DeviceAdapter']/method[@name='鷭' and count(parameter)=3 and parameter[1][@type='android.bluetooth.BluetoothSocket'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean']]"
		[Register ("鷭", "(Landroid/bluetooth/BluetoothSocket;ZZ)Ljava/util/List;", "Get鷭_Landroid_bluetooth_BluetoothSocket_ZZHandler:Com.Qcl.VH.Content.IDeviceAdapterInvoker, QualcommBinder")]
		global::System.Collections.Generic.IList<global::Com.Qcl.VH.Content.ˮ͈> 鷭 (global::Android.Bluetooth.BluetoothSocket p0, bool p1, bool p2);

	}

	[global::Android.Runtime.Register ("com/qcl/vh/content/DeviceAdapter", DoNotGenerateAcw=true)]
	internal class IDeviceAdapterInvoker : global::Java.Lang.Object, IDeviceAdapter {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/qcl/vh/content/DeviceAdapter");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IDeviceAdapterInvoker); }
		}

		IntPtr class_ref;

		public static IDeviceAdapter GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDeviceAdapter> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.qcl.vh.content.DeviceAdapter"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDeviceAdapterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_櫯_Landroid_bluetooth_BluetoothSocket_;
#pragma warning disable 0169
		static Delegate Get櫯_Landroid_bluetooth_BluetoothSocket_Handler ()
		{
			if (cb_櫯_Landroid_bluetooth_BluetoothSocket_ == null)
				cb_櫯_Landroid_bluetooth_BluetoothSocket_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_櫯_Landroid_bluetooth_BluetoothSocket_);
			return cb_櫯_Landroid_bluetooth_BluetoothSocket_;
		}

		static void n_櫯_Landroid_bluetooth_BluetoothSocket_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Qcl.VH.Content.IDeviceAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.IDeviceAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Bluetooth.BluetoothSocket p0 = global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothSocket> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.櫯 (p0);
		}
#pragma warning restore 0169

		IntPtr id_櫯_Landroid_bluetooth_BluetoothSocket_;
		public unsafe void 櫯 (global::Android.Bluetooth.BluetoothSocket p0)
		{
			if (id_櫯_Landroid_bluetooth_BluetoothSocket_ == IntPtr.Zero)
				id_櫯_Landroid_bluetooth_BluetoothSocket_ = JNIEnv.GetMethodID (class_ref, "櫯", "(Landroid/bluetooth/BluetoothSocket;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_櫯_Landroid_bluetooth_BluetoothSocket_, __args);
		}

		static Delegate cb_鷭_Landroid_bluetooth_BluetoothSocket_;
#pragma warning disable 0169
		static Delegate Get鷭_Landroid_bluetooth_BluetoothSocket_Handler ()
		{
			if (cb_鷭_Landroid_bluetooth_BluetoothSocket_ == null)
				cb_鷭_Landroid_bluetooth_BluetoothSocket_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_鷭_Landroid_bluetooth_BluetoothSocket_);
			return cb_鷭_Landroid_bluetooth_BluetoothSocket_;
		}

		static bool n_鷭_Landroid_bluetooth_BluetoothSocket_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Qcl.VH.Content.IDeviceAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.IDeviceAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Bluetooth.BluetoothSocket p0 = global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothSocket> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.鷭 (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_鷭_Landroid_bluetooth_BluetoothSocket_;
		public unsafe bool 鷭 (global::Android.Bluetooth.BluetoothSocket p0)
		{
			if (id_鷭_Landroid_bluetooth_BluetoothSocket_ == IntPtr.Zero)
				id_鷭_Landroid_bluetooth_BluetoothSocket_ = JNIEnv.GetMethodID (class_ref, "鷭", "(Landroid/bluetooth/BluetoothSocket;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_鷭_Landroid_bluetooth_BluetoothSocket_, __args);
			return __ret;
		}

		static Delegate cb_鷭_Landroid_bluetooth_BluetoothSocket_ZZ;
#pragma warning disable 0169
		static Delegate Get鷭_Landroid_bluetooth_BluetoothSocket_ZZHandler ()
		{
			if (cb_鷭_Landroid_bluetooth_BluetoothSocket_ZZ == null)
				cb_鷭_Landroid_bluetooth_BluetoothSocket_ZZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool, bool, IntPtr>) n_鷭_Landroid_bluetooth_BluetoothSocket_ZZ);
			return cb_鷭_Landroid_bluetooth_BluetoothSocket_ZZ;
		}

		static IntPtr n_鷭_Landroid_bluetooth_BluetoothSocket_ZZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1, bool p2)
		{
			global::Com.Qcl.VH.Content.IDeviceAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.IDeviceAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Bluetooth.BluetoothSocket p0 = global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothSocket> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Qcl.VH.Content.ˮ͈>.ToLocalJniHandle (__this.鷭 (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_鷭_Landroid_bluetooth_BluetoothSocket_ZZ;
		public unsafe global::System.Collections.Generic.IList<global::Com.Qcl.VH.Content.ˮ͈> 鷭 (global::Android.Bluetooth.BluetoothSocket p0, bool p1, bool p2)
		{
			if (id_鷭_Landroid_bluetooth_BluetoothSocket_ZZ == IntPtr.Zero)
				id_鷭_Landroid_bluetooth_BluetoothSocket_ZZ = JNIEnv.GetMethodID (class_ref, "鷭", "(Landroid/bluetooth/BluetoothSocket;ZZ)Ljava/util/List;");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			global::System.Collections.Generic.IList<global::Com.Qcl.VH.Content.ˮ͈> __ret = global::Android.Runtime.JavaList<global::Com.Qcl.VH.Content.ˮ͈>.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_鷭_Landroid_bluetooth_BluetoothSocket_ZZ, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_ˮ͈_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate Getˮ͈_Ljava_lang_String_Handler ()
		{
			if (cb_ˮ͈_Ljava_lang_String_ == null)
				cb_ˮ͈_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ˮ͈_Ljava_lang_String_);
			return cb_ˮ͈_Ljava_lang_String_;
		}

		static void n_ˮ͈_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Qcl.VH.Content.IDeviceAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.IDeviceAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ˮ͈ (p0);
		}
#pragma warning restore 0169

		IntPtr id_ˮ͈_Ljava_lang_String_;
		public unsafe void ˮ͈ (string p0)
		{
			if (id_ˮ͈_Ljava_lang_String_ == IntPtr.Zero)
				id_ˮ͈_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "ˮ͈", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (Handle, id_ˮ͈_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
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
			global::Com.Qcl.VH.Content.IDeviceAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.IDeviceAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Bluetooth.BluetoothSocket p0 = global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothSocket> (native_p0, JniHandleOwnership.DoNotTransfer);
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.鷭 (p0, p1, p2));
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_鷭_Landroid_bluetooth_BluetoothSocket_arrayBLjava_lang_String_;
		public unsafe global::Com.Qcl.VH.A.C.ˮ͍ 鷭 (global::Android.Bluetooth.BluetoothSocket p0, byte[] p1, string p2)
		{
			if (id_鷭_Landroid_bluetooth_BluetoothSocket_arrayBLjava_lang_String_ == IntPtr.Zero)
				id_鷭_Landroid_bluetooth_BluetoothSocket_arrayBLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "鷭", "(Landroid/bluetooth/BluetoothSocket;[BLjava/lang/String;)Lcom/qcl/vh/a/c/ˮ͍;");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			global::Com.Qcl.VH.A.C.ˮ͍ __ret = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.A.C.ˮ͍> (JNIEnv.CallObjectMethod (Handle, id_鷭_Landroid_bluetooth_BluetoothSocket_arrayBLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			JNIEnv.DeleteLocalRef (native_p2);
			return __ret;
		}

		static Delegate cb_鷭_arrayBLjava_lang_String_;
#pragma warning disable 0169
		static Delegate Get鷭_arrayBLjava_lang_String_Handler ()
		{
			if (cb_鷭_arrayBLjava_lang_String_ == null)
				cb_鷭_arrayBLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_鷭_arrayBLjava_lang_String_);
			return cb_鷭_arrayBLjava_lang_String_;
		}

		static IntPtr n_鷭_arrayBLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Qcl.VH.Content.IDeviceAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.IDeviceAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.鷭 (p0, p1));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_鷭_arrayBLjava_lang_String_;
		public unsafe global::Com.Qcl.VH.A.C.ˮ͍ 鷭 (byte[] p0, string p1)
		{
			if (id_鷭_arrayBLjava_lang_String_ == IntPtr.Zero)
				id_鷭_arrayBLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "鷭", "([BLjava/lang/String;)Lcom/qcl/vh/a/c/ˮ͍;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			global::Com.Qcl.VH.A.C.ˮ͍ __ret = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.A.C.ˮ͍> (JNIEnv.CallObjectMethod (Handle, id_鷭_arrayBLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

	}

}
