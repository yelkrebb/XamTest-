using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.A.A {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.qcl.vh.a.a']/interface[@name='ˮ͈']"
	[Register ("com/qcl/vh/a/a/ˮ͈", "", "Com.Qcl.VH.A.A.Iˮ͈Invoker")]
	public partial interface Iˮ͈ : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.a']/interface[@name='ˮ͈']/method[@name='鷭' and count(parameter)=0]"
		[Register ("鷭", "()Ljava/net/Socket;", "Get鷭Handler:Com.Qcl.VH.A.A.Iˮ͈Invoker, QualcommBinder")]
		global::Java.Net.Socket 鷭 ();

	}

	[global::Android.Runtime.Register ("com/qcl/vh/a/a/ˮ͈", DoNotGenerateAcw=true)]
	internal class Iˮ͈Invoker : global::Java.Lang.Object, Iˮ͈ {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/qcl/vh/a/a/ˮ͈");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Iˮ͈Invoker); }
		}

		IntPtr class_ref;

		public static Iˮ͈ GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<Iˮ͈> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.qcl.vh.a.a.ˮ͈"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public Iˮ͈Invoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
				cb_鷭 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_鷭);
			return cb_鷭;
		}

		static IntPtr n_鷭 (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Qcl.VH.A.A.Iˮ͈ __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.A.A.Iˮ͈> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.鷭 ());
		}
#pragma warning restore 0169

		IntPtr id_鷭;
		public unsafe global::Java.Net.Socket 鷭 ()
		{
			if (id_鷭 == IntPtr.Zero)
				id_鷭 = JNIEnv.GetMethodID (class_ref, "鷭", "()Ljava/net/Socket;");
			return global::Java.Lang.Object.GetObject<global::Java.Net.Socket> (JNIEnv.CallObjectMethod (Handle, id_鷭), JniHandleOwnership.TransferLocalRef);
		}

	}

}
