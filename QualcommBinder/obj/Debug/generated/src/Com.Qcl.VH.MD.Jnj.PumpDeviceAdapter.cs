using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.MD.Jnj {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.md.jnj']/class[@name='PumpDeviceAdapter']"
	[global::Android.Runtime.Register ("com/qcl/vh/md/jnj/PumpDeviceAdapter", DoNotGenerateAcw=true)]
	public abstract partial class PumpDeviceAdapter : global::Java.Lang.Object, global::Com.Qcl.VH.Content.IContextAwareAdapter, global::Com.Qcl.VH.Usb.IIf, global::Com.Qcl.VH.Usb.I櫯 {


		static IntPtr Ć_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.md.jnj']/class[@name='PumpDeviceAdapter']/field[@name='Ć']"
		[Register ("Ć")]
		protected IList<byte> Ć {
			get {
				if (Ć_jfieldId == IntPtr.Zero)
					Ć_jfieldId = JNIEnv.GetFieldID (class_ref, "Ć", "[B");
				return JavaArray<byte>.FromJniHandle (JNIEnv.GetObjectField (Handle, Ć_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (Ć_jfieldId == IntPtr.Zero)
					Ć_jfieldId = JNIEnv.GetFieldID (class_ref, "Ć", "[B");
				IntPtr native_value = JavaArray<byte>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, Ć_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr ˮ͍_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.md.jnj']/class[@name='PumpDeviceAdapter']/field[@name='ˮ͍']"
		[Register ("ˮ͍")]
		protected global::Android.Hardware.Usb.UsbDevice ˮ͍ {
			get {
				if (ˮ͍_jfieldId == IntPtr.Zero)
					ˮ͍_jfieldId = JNIEnv.GetFieldID (class_ref, "ˮ͍", "Landroid/hardware/usb/UsbDevice;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, ˮ͍_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Hardware.Usb.UsbDevice> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (ˮ͍_jfieldId == IntPtr.Zero)
					ˮ͍_jfieldId = JNIEnv.GetFieldID (class_ref, "ˮ͍", "Landroid/hardware/usb/UsbDevice;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, ˮ͍_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.md.jnj']/class[@name='PumpDeviceAdapter.鷭']"
		[global::Android.Runtime.Register ("com/qcl/vh/md/jnj/PumpDeviceAdapter$鷭", DoNotGenerateAcw=true)]
		public partial class 鷭 : global::Java.Lang.Object {

			protected 鷭 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qcl/vh/md/jnj/PumpDeviceAdapter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PumpDeviceAdapter); }
		}

		protected PumpDeviceAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.md.jnj']/class[@name='PumpDeviceAdapter']/constructor[@name='PumpDeviceAdapter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PumpDeviceAdapter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (PumpDeviceAdapter)) {
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

		static IntPtr id_Ą;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.jnj']/class[@name='PumpDeviceAdapter']/method[@name='Ą' and count(parameter)=0]"
		[Register ("Ą", "()Ljava/util/List;", "")]
		public unsafe global::System.Collections.Generic.IList<global::Com.Qcl.VH.Content.ˮ͈> Ą ()
		{
			if (id_Ą == IntPtr.Zero)
				id_Ą = JNIEnv.GetMethodID (class_ref, "Ą", "()Ljava/util/List;");
			try {
				return global::Android.Runtime.JavaList<global::Com.Qcl.VH.Content.ˮ͈>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_Ą), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_ȃ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.jnj']/class[@name='PumpDeviceAdapter']/method[@name='ȃ' and count(parameter)=0]"
		[Register ("ȃ", "()V", "")]
		protected unsafe void Ȃ ()
		{
			if (id_ȃ == IntPtr.Zero)
				id_ȃ = JNIEnv.GetMethodID (class_ref, "ȃ", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_ȃ);
			} finally {
			}
		}

		static IntPtr id_ˮ͈;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.jnj']/class[@name='PumpDeviceAdapter']/method[@name='ˮ͈' and count(parameter)=0]"
		[Register ("ˮ͈", "()V", "")]
		public unsafe void ˮ͈ ()
		{
			if (id_ˮ͈ == IntPtr.Zero)
				id_ˮ͈ = JNIEnv.GetMethodID (class_ref, "ˮ͈", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_ˮ͈);
			} finally {
			}
		}

		static IntPtr id_櫯;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.jnj']/class[@name='PumpDeviceAdapter']/method[@name='櫯' and count(parameter)=0]"
		[Register ("櫯", "()V", "")]
		public unsafe void 櫯 ()
		{
			if (id_櫯 == IntPtr.Zero)
				id_櫯 = JNIEnv.GetMethodID (class_ref, "櫯", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_櫯);
			} finally {
			}
		}

		static IntPtr id_鷭;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.jnj']/class[@name='PumpDeviceAdapter']/method[@name='鷭' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.jnj']/class[@name='PumpDeviceAdapter']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
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

		static Delegate cb_鷭_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate Get鷭_Ljava_lang_String_Handler ()
		{
			if (cb_鷭_Ljava_lang_String_ == null)
				cb_鷭_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_鷭_Ljava_lang_String_);
			return cb_鷭_Ljava_lang_String_;
		}

		static void n_鷭_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Qcl.VH.MD.Jnj.PumpDeviceAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.MD.Jnj.PumpDeviceAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.鷭 (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.jnj']/class[@name='PumpDeviceAdapter']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("鷭", "(Ljava/lang/String;)V", "Get鷭_Ljava_lang_String_Handler")]
		public abstract void 鷭 (string p0);

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
			global::Com.Qcl.VH.MD.Jnj.PumpDeviceAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.MD.Jnj.PumpDeviceAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Hardware.Usb.UsbDeviceConnection p0 = global::Java.Lang.Object.GetObject<global::Android.Hardware.Usb.UsbDeviceConnection> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Hardware.Usb.UsbDevice p1 = global::Java.Lang.Object.GetObject<global::Android.Hardware.Usb.UsbDevice> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.鷭 (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.jnj']/class[@name='PumpDeviceAdapter']/method[@name='鷭' and count(parameter)=2 and parameter[1][@type='android.hardware.usb.UsbDeviceConnection'] and parameter[2][@type='android.hardware.usb.UsbDevice']]"
		[Register ("鷭", "(Landroid/hardware/usb/UsbDeviceConnection;Landroid/hardware/usb/UsbDevice;)Ljava/lang/String;", "Get鷭_Landroid_hardware_usb_UsbDeviceConnection_Landroid_hardware_usb_UsbDevice_Handler")]
		public abstract string 鷭 (global::Android.Hardware.Usb.UsbDeviceConnection p0, global::Android.Hardware.Usb.UsbDevice p1);

	}

	[global::Android.Runtime.Register ("com/qcl/vh/md/jnj/PumpDeviceAdapter", DoNotGenerateAcw=true)]
	internal partial class PumpDeviceAdapterInvoker : PumpDeviceAdapter {

		public PumpDeviceAdapterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (PumpDeviceAdapterInvoker); }
		}

		static IntPtr id_鷭_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.jnj']/class[@name='PumpDeviceAdapter']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("鷭", "(Ljava/lang/String;)V", "Get鷭_Ljava_lang_String_Handler")]
		public override unsafe void 鷭 (string p0)
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

		static IntPtr id_鷭_Landroid_hardware_usb_UsbDeviceConnection_Landroid_hardware_usb_UsbDevice_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.jnj']/class[@name='PumpDeviceAdapter']/method[@name='鷭' and count(parameter)=2 and parameter[1][@type='android.hardware.usb.UsbDeviceConnection'] and parameter[2][@type='android.hardware.usb.UsbDevice']]"
		[Register ("鷭", "(Landroid/hardware/usb/UsbDeviceConnection;Landroid/hardware/usb/UsbDevice;)Ljava/lang/String;", "Get鷭_Landroid_hardware_usb_UsbDeviceConnection_Landroid_hardware_usb_UsbDevice_Handler")]
		public override unsafe string 鷭 (global::Android.Hardware.Usb.UsbDeviceConnection p0, global::Android.Hardware.Usb.UsbDevice p1)
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

	}

}
