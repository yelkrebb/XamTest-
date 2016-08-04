using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.Content {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.qcl.vh.content']/interface[@name='ContextAwareAdapter']"
	[Register ("com/qcl/vh/content/ContextAwareAdapter", "", "Com.Qcl.VH.Content.IContextAwareAdapterInvoker")]
	public partial interface IContextAwareAdapter : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/interface[@name='ContextAwareAdapter']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("鷭", "(Landroid/content/Context;)V", "Get鷭_Landroid_content_Context_Handler:Com.Qcl.VH.Content.IContextAwareAdapterInvoker, QualcommBinder")]
		void 鷭 (global::Android.Content.Context p0);

	}

	[global::Android.Runtime.Register ("com/qcl/vh/content/ContextAwareAdapter", DoNotGenerateAcw=true)]
	internal class IContextAwareAdapterInvoker : global::Java.Lang.Object, IContextAwareAdapter {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/qcl/vh/content/ContextAwareAdapter");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IContextAwareAdapterInvoker); }
		}

		IntPtr class_ref;

		public static IContextAwareAdapter GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IContextAwareAdapter> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.qcl.vh.content.ContextAwareAdapter"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IContextAwareAdapterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_鷭_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate Get鷭_Landroid_content_Context_Handler ()
		{
			if (cb_鷭_Landroid_content_Context_ == null)
				cb_鷭_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_鷭_Landroid_content_Context_);
			return cb_鷭_Landroid_content_Context_;
		}

		static void n_鷭_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Qcl.VH.Content.IContextAwareAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.IContextAwareAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.鷭 (p0);
		}
#pragma warning restore 0169

		IntPtr id_鷭_Landroid_content_Context_;
		public unsafe void 鷭 (global::Android.Content.Context p0)
		{
			if (id_鷭_Landroid_content_Context_ == IntPtr.Zero)
				id_鷭_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "鷭", "(Landroid/content/Context;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_鷭_Landroid_content_Context_, __args);
		}

	}

}
