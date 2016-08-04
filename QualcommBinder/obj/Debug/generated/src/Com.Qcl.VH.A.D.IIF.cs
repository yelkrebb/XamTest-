using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.A.D {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.qcl.vh.a.d']/interface[@name='IF']"
	[Register ("com/qcl/vh/a/d/IF", "", "Com.Qcl.VH.A.D.IIFInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"Type"})]
	public partial interface IIF : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.d']/interface[@name='IF']/method[@name='櫯' and count(parameter)=0]"
		[Register ("櫯", "()Lcom/qcl/vh/a/d/ą$鷭;", "Get櫯Handler:Com.Qcl.VH.A.D.IIFInvoker, QualcommBinder")]
		global::Com.Qcl.VH.A.D.Ą.I鷭 櫯 ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.d']/interface[@name='IF']/method[@name='鷭' and count(parameter)=0]"
		[Register ("鷭", "()Lcom/qcl/vh/a/d/Ą$鷭;", "Get鷭Handler:Com.Qcl.VH.A.D.IIFInvoker, QualcommBinder")]
		global::Com.Qcl.VH.A.D.Ą.I鷭 鷭 ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.d']/interface[@name='IF']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='com.qcl.vh.a.d.aux']]"
		[Register ("鷭", "(Lcom/qcl/vh/a/d/aux;)V", "Get鷭_Lcom_qcl_vh_a_d_aux_Handler:Com.Qcl.VH.A.D.IIFInvoker, QualcommBinder")]
		void 鷭 (global::Com.Qcl.VH.A.D.Aux p0);

	}

	[global::Android.Runtime.Register ("com/qcl/vh/a/d/IF", DoNotGenerateAcw=true)]
	internal class IIFInvoker : global::Java.Lang.Object, IIF {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/qcl/vh/a/d/IF");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IIFInvoker); }
		}

		IntPtr class_ref;

		public static IIF GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IIF> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.qcl.vh.a.d.IF"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IIFInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_櫯;
#pragma warning disable 0169
		static Delegate Get櫯Handler ()
		{
			if (cb_櫯 == null)
				cb_櫯 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_櫯);
			return cb_櫯;
		}

		static IntPtr n_櫯 (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Qcl.VH.A.D.IIF __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.A.D.IIF> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.櫯 ());
		}
#pragma warning restore 0169

		IntPtr id_櫯;
		public unsafe global::Com.Qcl.VH.A.D.Ą.I鷭 櫯 ()
		{
			if (id_櫯 == IntPtr.Zero)
				id_櫯 = JNIEnv.GetMethodID (class_ref, "櫯", "()Lcom/qcl/vh/a/d/ą$鷭;");
			return global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.A.D.Ą.I鷭> (JNIEnv.CallObjectMethod (Handle, id_櫯), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Qcl.VH.A.D.IIF __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.A.D.IIF> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.鷭 ());
		}
#pragma warning restore 0169

		IntPtr id_鷭;
		public unsafe global::Com.Qcl.VH.A.D.Ą.I鷭 鷭 ()
		{
			if (id_鷭 == IntPtr.Zero)
				id_鷭 = JNIEnv.GetMethodID (class_ref, "鷭", "()Lcom/qcl/vh/a/d/Ą$鷭;");
			return global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.A.D.Ą.I鷭> (JNIEnv.CallObjectMethod (Handle, id_鷭), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_鷭_Lcom_qcl_vh_a_d_aux_;
#pragma warning disable 0169
		static Delegate Get鷭_Lcom_qcl_vh_a_d_aux_Handler ()
		{
			if (cb_鷭_Lcom_qcl_vh_a_d_aux_ == null)
				cb_鷭_Lcom_qcl_vh_a_d_aux_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_鷭_Lcom_qcl_vh_a_d_aux_);
			return cb_鷭_Lcom_qcl_vh_a_d_aux_;
		}

		static void n_鷭_Lcom_qcl_vh_a_d_aux_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Qcl.VH.A.D.IIF __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.A.D.IIF> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Qcl.VH.A.D.Aux p0 = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.A.D.Aux> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.鷭 (p0);
		}
#pragma warning restore 0169

		IntPtr id_鷭_Lcom_qcl_vh_a_d_aux_;
		public unsafe void 鷭 (global::Com.Qcl.VH.A.D.Aux p0)
		{
			if (id_鷭_Lcom_qcl_vh_a_d_aux_ == IntPtr.Zero)
				id_鷭_Lcom_qcl_vh_a_d_aux_ = JNIEnv.GetMethodID (class_ref, "鷭", "(Lcom/qcl/vh/a/d/aux;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_鷭_Lcom_qcl_vh_a_d_aux_, __args);
		}

	}

}
