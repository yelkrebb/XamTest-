using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.A.D {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.a.d']/class[@name='ć']"
	[global::Android.Runtime.Register ("com/qcl/vh/a/d/ć", DoNotGenerateAcw=true)]
	public partial class Ć : global::Java.Lang.Object, global::Com.Qcl.VH.A.D.Ą.I鷭 {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qcl/vh/a/d/ć", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Ć); }
		}

		protected Ć (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.a.d']/class[@name='ć']/constructor[@name='ć' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Ć ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Ć)) {
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

		static Delegate cb_鷭_Ljava_io_InputStream_;
#pragma warning disable 0169
		static Delegate Get鷭_Ljava_io_InputStream_Handler ()
		{
			if (cb_鷭_Ljava_io_InputStream_ == null)
				cb_鷭_Ljava_io_InputStream_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_鷭_Ljava_io_InputStream_);
			return cb_鷭_Ljava_io_InputStream_;
		}

		static IntPtr n_鷭_Ljava_io_InputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Qcl.VH.A.D.Ć __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.A.D.Ć> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p0 = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.鷭 (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_鷭_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.d']/class[@name='ć']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("鷭", "(Ljava/io/InputStream;)Ljava/lang/Long;", "Get鷭_Ljava_io_InputStream_Handler")]
		public virtual unsafe global::Java.Lang.Long 鷭 (global::System.IO.Stream p0)
		{
			if (id_鷭_Ljava_io_InputStream_ == IntPtr.Zero)
				id_鷭_Ljava_io_InputStream_ = JNIEnv.GetMethodID (class_ref, "鷭", "(Ljava/io/InputStream;)Ljava/lang/Long;");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Java.Lang.Long __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallObjectMethod  (Handle, id_鷭_Ljava_io_InputStream_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "鷭", "(Ljava/io/InputStream;)Ljava/lang/Long;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// This method is explicitly implemented as a member of an instantiated Com.Qcl.VH.A.D.Ą.I鷭
		global::Java.Lang.Object global::Com.Qcl.VH.A.D.Ą.I鷭.鷭 (global::System.IO.Stream p0)
		{
			return global::Java.Interop.JavaObjectExtensions.JavaCast<Java.Lang.Object>(鷭 (p0));
		}

	}
}
