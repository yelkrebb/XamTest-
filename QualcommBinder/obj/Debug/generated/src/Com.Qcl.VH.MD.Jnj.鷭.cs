using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.MD.Jnj {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.md.jnj']/class[@name='鷭']"
	[global::Android.Runtime.Register ("com/qcl/vh/md/jnj/鷭", DoNotGenerateAcw=true)]
	public abstract partial class 鷭 : global::Java.Lang.Object {


		static IntPtr ˮ͈_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.md.jnj']/class[@name='鷭']/field[@name='ˮ͈']"
		[Register ("ˮ͈")]
		protected global::Android.Hardware.Usb.UsbDeviceConnection ˮ͈ {
			get {
				if (ˮ͈_jfieldId == IntPtr.Zero)
					ˮ͈_jfieldId = JNIEnv.GetFieldID (class_ref, "ˮ͈", "Landroid/hardware/usb/UsbDeviceConnection;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, ˮ͈_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Hardware.Usb.UsbDeviceConnection> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (ˮ͈_jfieldId == IntPtr.Zero)
					ˮ͈_jfieldId = JNIEnv.GetFieldID (class_ref, "ˮ͈", "Landroid/hardware/usb/UsbDeviceConnection;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, ˮ͈_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qcl/vh/md/jnj/鷭", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (鷭); }
		}

		protected 鷭 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_hardware_usb_UsbDeviceConnection_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.md.jnj']/class[@name='鷭']/constructor[@name='鷭' and count(parameter)=1 and parameter[1][@type='android.hardware.usb.UsbDeviceConnection']]"
		[Register (".ctor", "(Landroid/hardware/usb/UsbDeviceConnection;)V", "")]
		protected unsafe 鷭 (global::Android.Hardware.Usb.UsbDeviceConnection p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (鷭)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/hardware/usb/UsbDeviceConnection;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/hardware/usb/UsbDeviceConnection;)V", __args);
					return;
				}

				if (id_ctor_Landroid_hardware_usb_UsbDeviceConnection_ == IntPtr.Zero)
					id_ctor_Landroid_hardware_usb_UsbDeviceConnection_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/hardware/usb/UsbDeviceConnection;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_hardware_usb_UsbDeviceConnection_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_hardware_usb_UsbDeviceConnection_, __args);
			} finally {
			}
		}

		static IntPtr id_櫯;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.jnj']/class[@name='鷭']/method[@name='櫯' and count(parameter)=0]"
		[Register ("櫯", "()[B", "")]
		protected unsafe byte[] 櫯 ()
		{
			if (id_櫯 == IntPtr.Zero)
				id_櫯 = JNIEnv.GetMethodID (class_ref, "櫯", "()[B");
			try {
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_櫯), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static IntPtr id_鷭;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.jnj']/class[@name='鷭']/method[@name='鷭' and count(parameter)=0]"
		[Register ("鷭", "()[B", "")]
		protected unsafe byte[] Invoke鷭 ()
		{
			if (id_鷭 == IntPtr.Zero)
				id_鷭 = JNIEnv.GetMethodID (class_ref, "鷭", "()[B");
			try {
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_鷭), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static IntPtr id_鷭_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.jnj']/class[@name='鷭']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("鷭", "([B)I", "")]
		protected unsafe int Invoke鷭 (byte[] p0)
		{
			if (id_鷭_arrayB == IntPtr.Zero)
				id_鷭_arrayB = JNIEnv.GetMethodID (class_ref, "鷭", "([B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				int __ret = JNIEnv.CallIntMethod  (Handle, id_鷭_arrayB, __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_鷭_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.jnj']/class[@name='鷭']/method[@name='鷭' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("鷭", "(II)[B", "")]
		protected unsafe byte[] Invoke鷭 (int p0, int p1)
		{
			if (id_鷭_II == IntPtr.Zero)
				id_鷭_II = JNIEnv.GetMethodID (class_ref, "鷭", "(II)[B");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_鷭_II, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/qcl/vh/md/jnj/鷭", DoNotGenerateAcw=true)]
	internal partial class 鷭Invoker : 鷭 {

		public 鷭Invoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (鷭Invoker); }
		}

	}

}
