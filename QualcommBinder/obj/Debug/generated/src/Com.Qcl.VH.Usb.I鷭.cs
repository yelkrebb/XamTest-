using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.Usb {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.qcl.vh.usb']/interface[@name='鷭']"
	[Register ("com/qcl/vh/usb/鷭", "", "Com.Qcl.VH.Usb.I鷭Invoker")]
	public partial interface I鷭 : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.usb']/interface[@name='鷭']/method[@name='鷭' and count(parameter)=0]"
		[Register ("鷭", "()V", "Get鷭Handler:Com.Qcl.VH.Usb.I鷭Invoker, QualcommBinder")]
		void 鷭 ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.usb']/interface[@name='鷭']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register ("鷭", "(Landroid/net/Uri;)Ljava/lang/String;", "Get鷭_Landroid_net_Uri_Handler:Com.Qcl.VH.Usb.I鷭Invoker, QualcommBinder")]
		string 鷭 (global::Android.Net.Uri p0);

	}

	[global::Android.Runtime.Register ("com/qcl/vh/usb/鷭", DoNotGenerateAcw=true)]
	internal class I鷭Invoker : global::Java.Lang.Object, I鷭 {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/qcl/vh/usb/鷭");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (I鷭Invoker); }
		}

		IntPtr class_ref;

		public static I鷭 GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<I鷭> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.qcl.vh.usb.鷭"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public I鷭Invoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
			global::Com.Qcl.VH.Usb.I鷭 __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Usb.I鷭> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_鷭_Landroid_net_Uri_;
#pragma warning disable 0169
		static Delegate Get鷭_Landroid_net_Uri_Handler ()
		{
			if (cb_鷭_Landroid_net_Uri_ == null)
				cb_鷭_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_鷭_Landroid_net_Uri_);
			return cb_鷭_Landroid_net_Uri_;
		}

		static IntPtr n_鷭_Landroid_net_Uri_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Qcl.VH.Usb.I鷭 __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Usb.I鷭> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.鷭 (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_鷭_Landroid_net_Uri_;
		public unsafe string 鷭 (global::Android.Net.Uri p0)
		{
			if (id_鷭_Landroid_net_Uri_ == IntPtr.Zero)
				id_鷭_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "鷭", "(Landroid/net/Uri;)Ljava/lang/String;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_鷭_Landroid_net_Uri_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
