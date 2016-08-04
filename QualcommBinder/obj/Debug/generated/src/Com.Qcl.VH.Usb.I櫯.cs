using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.Usb {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.qcl.vh.usb']/interface[@name='櫯']"
	[Register ("com/qcl/vh/usb/櫯", "", "Com.Qcl.VH.Usb.I櫯Invoker")]
	public partial interface I櫯 : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.usb']/interface[@name='櫯']/method[@name='鷭' and count(parameter)=0]"
		[Register ("鷭", "()V", "Get鷭Handler:Com.Qcl.VH.Usb.I櫯Invoker, QualcommBinder")]
		void 鷭 ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.usb']/interface[@name='櫯']/method[@name='鷭' and count(parameter)=2 and parameter[1][@type='android.hardware.usb.UsbDeviceConnection'] and parameter[2][@type='android.hardware.usb.UsbDevice']]"
		[Register ("鷭", "(Landroid/hardware/usb/UsbDeviceConnection;Landroid/hardware/usb/UsbDevice;)Ljava/lang/String;", "Get鷭_Landroid_hardware_usb_UsbDeviceConnection_Landroid_hardware_usb_UsbDevice_Handler:Com.Qcl.VH.Usb.I櫯Invoker, QualcommBinder")]
		string 鷭 (global::Android.Hardware.Usb.UsbDeviceConnection p0, global::Android.Hardware.Usb.UsbDevice p1);

	}

	[global::Android.Runtime.Register ("com/qcl/vh/usb/櫯", DoNotGenerateAcw=true)]
	internal class I櫯Invoker : global::Java.Lang.Object, I櫯 {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/qcl/vh/usb/櫯");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (I櫯Invoker); }
		}

		IntPtr class_ref;

		public static I櫯 GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<I櫯> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.qcl.vh.usb.櫯"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public I櫯Invoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_鷭;
#pragma warning disable 0169
		static Delegate Get鷭Handler ()
		{
			if (cb_鷭 == null)
				cb_鷭 = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_鷭);
			return cb_鷭;
		}

		static void n_鷭 (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Qcl.VH.Usb.I櫯 __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Usb.I櫯> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.鷭 ();
		}
#pragma warning restore 0169

		IntPtr id_鷭;
		public unsafe void 鷭 ()
		{
			if (id_鷭 == IntPtr.Zero)
				id_鷭 = JNIEnv.GetMethodID (class_ref, "鷭", "()V");
			JNIEnv.CallVoidMethod (Handle, id_鷭);
		}

		static Delegate cb_鷭_Landroid_hardware_usb_UsbDeviceConnection_Landroid_hardware_usb_UsbDevice_;
#pragma warning disable 0169
		static Delegate Get鷭_Landroid_hardware_usb_UsbDeviceConnection_Landroid_hardware_usb_UsbDevice_Handler ()
		{
			if (cb_鷭_Landroid_hardware_usb_UsbDeviceConnection_Landroid_hardware_usb_UsbDevice_ == null)
				cb_鷭_Landroid_hardware_usb_UsbDeviceConnection_Landroid_hardware_usb_UsbDevice_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_鷭_Landroid_hardware_usb_UsbDeviceConnection_Landroid_hardware_usb_UsbDevice_);
			return cb_鷭_Landroid_hardware_usb_UsbDeviceConnection_Landroid_hardware_usb_UsbDevice_;
		}

		static IntPtr n_鷭_Landroid_hardware_usb_UsbDeviceConnection_Landroid_hardware_usb_UsbDevice_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Qcl.VH.Usb.I櫯 __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Usb.I櫯> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Hardware.Usb.UsbDeviceConnection p0 = global::Java.Lang.Object.GetObject<global::Android.Hardware.Usb.UsbDeviceConnection> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Hardware.Usb.UsbDevice p1 = global::Java.Lang.Object.GetObject<global::Android.Hardware.Usb.UsbDevice> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.鷭 (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_鷭_Landroid_hardware_usb_UsbDeviceConnection_Landroid_hardware_usb_UsbDevice_;
		public unsafe string 鷭 (global::Android.Hardware.Usb.UsbDeviceConnection p0, global::Android.Hardware.Usb.UsbDevice p1)
		{
			if (id_鷭_Landroid_hardware_usb_UsbDeviceConnection_Landroid_hardware_usb_UsbDevice_ == IntPtr.Zero)
				id_鷭_Landroid_hardware_usb_UsbDeviceConnection_Landroid_hardware_usb_UsbDevice_ = JNIEnv.GetMethodID (class_ref, "鷭", "(Landroid/hardware/usb/UsbDeviceConnection;Landroid/hardware/usb/UsbDevice;)Ljava/lang/String;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_鷭_Landroid_hardware_usb_UsbDeviceConnection_Landroid_hardware_usb_UsbDevice_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
