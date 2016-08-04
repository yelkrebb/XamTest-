using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.Decoder.A {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.qcl.vh.decoder.a']/interface[@name='if']"
	[Register ("com/qcl/vh/decoder/a/if", "", "Com.Qcl.VH.Decoder.A.IIfInvoker")]
	public partial interface IIf : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.decoder.a']/interface[@name='if']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("鷭", "([B)Lorg/json/JSONObject;", "Get鷭_arrayBHandler:Com.Qcl.VH.Decoder.A.IIfInvoker, QualcommBinder")]
		global::Org.Json.JSONObject 鷭 (byte[] p0);

	}

	[global::Android.Runtime.Register ("com/qcl/vh/decoder/a/if", DoNotGenerateAcw=true)]
	internal class IIfInvoker : global::Java.Lang.Object, IIf {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/qcl/vh/decoder/a/if");

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
							JNIEnv.GetClassNameFromInstance (handle), "com.qcl.vh.decoder.a.if"));
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

		static Delegate cb_鷭_arrayB;
#pragma warning disable 0169
		static Delegate Get鷭_arrayBHandler ()
		{
			if (cb_鷭_arrayB == null)
				cb_鷭_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_鷭_arrayB);
			return cb_鷭_arrayB;
		}

		static IntPtr n_鷭_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Qcl.VH.Decoder.A.IIf __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Decoder.A.IIf> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.鷭 (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_鷭_arrayB;
		public unsafe global::Org.Json.JSONObject 鷭 (byte[] p0)
		{
			if (id_鷭_arrayB == IntPtr.Zero)
				id_鷭_arrayB = JNIEnv.GetMethodID (class_ref, "鷭", "([B)Lorg/json/JSONObject;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			global::Org.Json.JSONObject __ret = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod (Handle, id_鷭_arrayB, __args), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

	}

}
