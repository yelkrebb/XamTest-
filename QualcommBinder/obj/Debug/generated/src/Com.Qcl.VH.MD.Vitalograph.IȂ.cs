using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.MD.Vitalograph {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.qcl.vh.md.vitalograph']/interface[@name='ȃ']"
	[Register ("com/qcl/vh/md/vitalograph/ȃ", "", "Com.Qcl.VH.MD.Vitalograph.IȂInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T extends java.lang.Exception"})]
	public partial interface IȂ : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.vitalograph']/interface[@name='ȃ']/method[@name='鷭' and count(parameter)=0]"
		[Register ("鷭", "()Z", "Get鷭Handler:Com.Qcl.VH.MD.Vitalograph.IȂInvoker, QualcommBinder")]
		bool 鷭 ();

	}

	[global::Android.Runtime.Register ("com/qcl/vh/md/vitalograph/ȃ", DoNotGenerateAcw=true)]
	internal class IȂInvoker : global::Java.Lang.Object, IȂ {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/qcl/vh/md/vitalograph/ȃ");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IȂInvoker); }
		}

		IntPtr class_ref;

		public static IȂ GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IȂ> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.qcl.vh.md.vitalograph.ȃ"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IȂInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
				cb_鷭 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_鷭);
			return cb_鷭;
		}

		static bool n_鷭 (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Qcl.VH.MD.Vitalograph.IȂ __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.MD.Vitalograph.IȂ> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.鷭 ();
		}
#pragma warning restore 0169

		IntPtr id_鷭;
		public unsafe bool 鷭 ()
		{
			if (id_鷭 == IntPtr.Zero)
				id_鷭 = JNIEnv.GetMethodID (class_ref, "鷭", "()Z");
			return JNIEnv.CallBooleanMethod (Handle, id_鷭);
		}

	}

}
