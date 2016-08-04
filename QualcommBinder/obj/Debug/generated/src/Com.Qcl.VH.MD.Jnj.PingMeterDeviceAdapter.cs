using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.MD.Jnj {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.md.jnj']/class[@name='PingMeterDeviceAdapter']"
	[global::Android.Runtime.Register ("com/qcl/vh/md/jnj/PingMeterDeviceAdapter", DoNotGenerateAcw=true)]
	public partial class PingMeterDeviceAdapter : global::Java.Lang.Object, global::Com.Qcl.VH.Content.IContextAwareAdapter, global::Com.Qcl.VH.Usb.IIf, global::Com.Qcl.VH.Usb.I櫯 {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.md.jnj']/class[@name='PingMeterDeviceAdapter.鷭']"
		[global::Android.Runtime.Register ("com/qcl/vh/md/jnj/PingMeterDeviceAdapter$鷭", DoNotGenerateAcw=true)]
		public partial class 鷭 : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/qcl/vh/md/jnj/PingMeterDeviceAdapter$鷭", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (鷭); }
			}

			protected 鷭 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_qcl_vh_md_jnj_PingMeterDeviceAdapter_Ljava_lang_String_arrayBZZ;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.md.jnj']/class[@name='PingMeterDeviceAdapter.鷭']/constructor[@name='PingMeterDeviceAdapter.鷭' and count(parameter)=5 and parameter[1][@type='com.qcl.vh.md.jnj.PingMeterDeviceAdapter'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='byte[]'] and parameter[4][@type='boolean'] and parameter[5][@type='boolean']]"
			[Register (".ctor", "(Lcom/qcl/vh/md/jnj/PingMeterDeviceAdapter;Ljava/lang/String;[BZZ)V", "")]
			public unsafe 鷭 (global::Com.Qcl.VH.MD.Jnj.PingMeterDeviceAdapter __self, string p1, byte[] p2, bool p3, bool p4)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p1 = JNIEnv.NewString (p1);
				IntPtr native_p2 = JNIEnv.NewArray (p2);
				try {
					JValue* __args = stackalloc JValue [5];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (native_p1);
					__args [2] = new JValue (native_p2);
					__args [3] = new JValue (p3);
					__args [4] = new JValue (p4);
					if (GetType () != typeof (鷭)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Ljava/lang/String;[BZZ)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Ljava/lang/String;[BZZ)V", __args);
						return;
					}

					if (id_ctor_Lcom_qcl_vh_md_jnj_PingMeterDeviceAdapter_Ljava_lang_String_arrayBZZ == IntPtr.Zero)
						id_ctor_Lcom_qcl_vh_md_jnj_PingMeterDeviceAdapter_Ljava_lang_String_arrayBZZ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/qcl/vh/md/jnj/PingMeterDeviceAdapter;Ljava/lang/String;[BZZ)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_qcl_vh_md_jnj_PingMeterDeviceAdapter_Ljava_lang_String_arrayBZZ, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_qcl_vh_md_jnj_PingMeterDeviceAdapter_Ljava_lang_String_arrayBZZ, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
					if (p2 != null) {
						JNIEnv.CopyArray (native_p2, p2);
						JNIEnv.DeleteLocalRef (native_p2);
					}
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qcl/vh/md/jnj/PingMeterDeviceAdapter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PingMeterDeviceAdapter); }
		}

		protected PingMeterDeviceAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.md.jnj']/class[@name='PingMeterDeviceAdapter']/constructor[@name='PingMeterDeviceAdapter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PingMeterDeviceAdapter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (PingMeterDeviceAdapter)) {
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

		static IntPtr id_鷭;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.jnj']/class[@name='PingMeterDeviceAdapter']/method[@name='鷭' and count(parameter)=0]"
		[Register ("鷭", "()V", "")]
		public unsafe void Invoke鷭 ()
		{
			if (id_鷭 == IntPtr.Zero)
				id_鷭 = JNIEnv.GetMethodID (class_ref, "鷭", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_鷭);
			} finally {
			}
		}

		static IntPtr id_鷭_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.jnj']/class[@name='PingMeterDeviceAdapter']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("鷭", "(Landroid/content/Context;)V", "")]
		public unsafe void Invoke鷭 (global::Android.Content.Context p0)
		{
			if (id_鷭_Landroid_content_Context_ == IntPtr.Zero)
				id_鷭_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "鷭", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_鷭_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_鷭_Landroid_hardware_usb_UsbDeviceConnection_Landroid_hardware_usb_UsbDevice_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.jnj']/class[@name='PingMeterDeviceAdapter']/method[@name='鷭' and count(parameter)=2 and parameter[1][@type='android.hardware.usb.UsbDeviceConnection'] and parameter[2][@type='android.hardware.usb.UsbDevice']]"
		[Register ("鷭", "(Landroid/hardware/usb/UsbDeviceConnection;Landroid/hardware/usb/UsbDevice;)Ljava/lang/String;", "")]
		public unsafe string Invoke鷭 (global::Android.Hardware.Usb.UsbDeviceConnection p0, global::Android.Hardware.Usb.UsbDevice p1)
		{
			if (id_鷭_Landroid_hardware_usb_UsbDeviceConnection_Landroid_hardware_usb_UsbDevice_ == IntPtr.Zero)
				id_鷭_Landroid_hardware_usb_UsbDeviceConnection_Landroid_hardware_usb_UsbDevice_ = JNIEnv.GetMethodID (class_ref, "鷭", "(Landroid/hardware/usb/UsbDeviceConnection;Landroid/hardware/usb/UsbDevice;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_鷭_Landroid_hardware_usb_UsbDeviceConnection_Landroid_hardware_usb_UsbDevice_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_鷭_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.jnj']/class[@name='PingMeterDeviceAdapter']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("鷭", "(Ljava/lang/String;)V", "")]
		public unsafe void Invoke鷭 (string p0)
		{
			if (id_鷭_Ljava_lang_String_ == IntPtr.Zero)
				id_鷭_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "鷭", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod  (Handle, id_鷭_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
