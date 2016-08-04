using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.Content {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.qcl.vh.content']/interface[@name='CommandsAdapter']"
	[Register ("com/qcl/vh/content/CommandsAdapter", "", "Com.Qcl.VH.Content.ICommandsAdapterInvoker")]
	public partial interface ICommandsAdapter : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/interface[@name='CommandsAdapter']/method[@name='ˮ͈' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("ˮ͈", "(Ljava/lang/String;)V", "Getˮ͈_Ljava_lang_String_Handler:Com.Qcl.VH.Content.ICommandsAdapterInvoker, QualcommBinder")]
		void ˮ͈ (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/interface[@name='CommandsAdapter']/method[@name='鷭' and count(parameter)=3 and parameter[1][@type='android.bluetooth.BluetoothSocket'] and parameter[2][@type='byte[]'] and parameter[3][@type='java.lang.String']]"
		[Register ("鷭", "(Landroid/bluetooth/BluetoothSocket;[BLjava/lang/String;)Lcom/qcl/vh/a/c/ˮ͍;", "Get鷭_Landroid_bluetooth_BluetoothSocket_arrayBLjava_lang_String_Handler:Com.Qcl.VH.Content.ICommandsAdapterInvoker, QualcommBinder")]
		global::Com.Qcl.VH.A.C.ˮ͍ 鷭 (global::Android.Bluetooth.BluetoothSocket p0, byte[] p1, string p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/interface[@name='CommandsAdapter']/method[@name='鷭' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='java.lang.String']]"
		[Register ("鷭", "([BLjava/lang/String;)Lcom/qcl/vh/a/c/ˮ͍;", "Get鷭_arrayBLjava_lang_String_Handler:Com.Qcl.VH.Content.ICommandsAdapterInvoker, QualcommBinder")]
		global::Com.Qcl.VH.A.C.ˮ͍ 鷭 (byte[] p0, string p1);

	}

	[global::Android.Runtime.Register ("com/qcl/vh/content/CommandsAdapter", DoNotGenerateAcw=true)]
	internal class ICommandsAdapterInvoker : global::Java.Lang.Object, ICommandsAdapter {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/qcl/vh/content/CommandsAdapter");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ICommandsAdapterInvoker); }
		}

		IntPtr class_ref;

		public static ICommandsAdapter GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICommandsAdapter> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.qcl.vh.content.CommandsAdapter"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICommandsAdapterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Com.Qcl.VH.Content.ICommandsAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.ICommandsAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Qcl.VH.Content.ICommandsAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.ICommandsAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Qcl.VH.Content.ICommandsAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.ICommandsAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
