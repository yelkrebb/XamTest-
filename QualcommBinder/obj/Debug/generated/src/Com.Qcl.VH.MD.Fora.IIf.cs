using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.MD.Fora {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.qcl.vh.md.fora']/interface[@name='if']"
	[Register ("com/qcl/vh/md/fora/if", "", "Com.Qcl.VH.MD.Fora.IIfInvoker")]
	public partial interface IIf : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.fora']/interface[@name='if']/method[@name='鷭' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='java.io.OutputStream'] and parameter[3][@type='java.io.InputStream'] and parameter[4][@type='int']]"
		[Register ("鷭", "(ILjava/io/OutputStream;Ljava/io/InputStream;I)[B", "Get鷭_ILjava_io_OutputStream_Ljava_io_InputStream_IHandler:Com.Qcl.VH.MD.Fora.IIfInvoker, QualcommBinder")]
		byte[] 鷭 (int p0, global::System.IO.Stream p1, global::System.IO.Stream p2, int p3);

	}

	[global::Android.Runtime.Register ("com/qcl/vh/md/fora/if", DoNotGenerateAcw=true)]
	internal class IIfInvoker : global::Java.Lang.Object, IIf {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/qcl/vh/md/fora/if");

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
							JNIEnv.GetClassNameFromInstance (handle), "com.qcl.vh.md.fora.if"));
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

		static Delegate cb_鷭_ILjava_io_OutputStream_Ljava_io_InputStream_I;
#pragma warning disable 0169
		static Delegate Get鷭_ILjava_io_OutputStream_Ljava_io_InputStream_IHandler ()
		{
			if (cb_鷭_ILjava_io_OutputStream_Ljava_io_InputStream_I == null)
				cb_鷭_ILjava_io_OutputStream_Ljava_io_InputStream_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, int, IntPtr>) n_鷭_ILjava_io_OutputStream_Ljava_io_InputStream_I);
			return cb_鷭_ILjava_io_OutputStream_Ljava_io_InputStream_I;
		}

		static IntPtr n_鷭_ILjava_io_OutputStream_Ljava_io_InputStream_I (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, int p3)
		{
			global::Com.Qcl.VH.MD.Fora.IIf __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.MD.Fora.IIf> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p1 = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p2 = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.鷭 (p0, p1, p2, p3));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_鷭_ILjava_io_OutputStream_Ljava_io_InputStream_I;
		public unsafe byte[] 鷭 (int p0, global::System.IO.Stream p1, global::System.IO.Stream p2, int p3)
		{
			if (id_鷭_ILjava_io_OutputStream_Ljava_io_InputStream_I == IntPtr.Zero)
				id_鷭_ILjava_io_OutputStream_Ljava_io_InputStream_I = JNIEnv.GetMethodID (class_ref, "鷭", "(ILjava/io/OutputStream;Ljava/io/InputStream;I)[B");
			IntPtr native_p1 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p1);
			IntPtr native_p2 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p2);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (p3);
			byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (Handle, id_鷭_ILjava_io_OutputStream_Ljava_io_InputStream_I, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			return __ret;
		}

	}

}
