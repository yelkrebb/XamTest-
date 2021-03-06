using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.Usb {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.qcl.vh.usb']/interface[@name='if']"
	[Register ("com/qcl/vh/usb/if", "", "Com.Qcl.VH.Usb.IIfInvoker")]
	public partial interface IIf : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.usb']/interface[@name='if']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("鷭", "(Ljava/lang/String;)V", "Get鷭_Ljava_lang_String_Handler:Com.Qcl.VH.Usb.IIfInvoker, QualcommBinder")]
		void 鷭 (string p0);

	}

	[global::Android.Runtime.Register ("com/qcl/vh/usb/if", DoNotGenerateAcw=true)]
	internal class IIfInvoker : global::Java.Lang.Object, IIf {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/qcl/vh/usb/if");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IIfInvoker); }
		}

		IntPtr class_ref;

		public static IIf GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IIf> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.qcl.vh.usb.if"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IIfInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Com.Qcl.VH.Usb.IIf __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Usb.IIf> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.鷭 (p0);
		}
#pragma warning restore 0169

		IntPtr id_鷭_Ljava_lang_String_;
		public unsafe void 鷭 (string p0)
		{
			if (id_鷭_Ljava_lang_String_ == IntPtr.Zero)
				id_鷭_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "鷭", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (Handle, id_鷭_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

}
