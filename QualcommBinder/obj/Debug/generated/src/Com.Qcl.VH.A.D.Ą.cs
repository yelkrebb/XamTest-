using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.A.D {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.a.d']/class[@name='ą']"
	[global::Android.Runtime.Register ("com/qcl/vh/a/d/ą", DoNotGenerateAcw=true)]
	public sealed partial class Ą : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.qcl.vh.a.d']/interface[@name='ą.鷭']"
		[Register ("com/qcl/vh/a/d/ą$鷭", "", "Com.Qcl.VH.A.D.Ą/I鷭Invoker")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"Type"})]
		public partial interface I鷭 : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.d']/interface[@name='ą.鷭']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
			[Register ("鷭", "(Ljava/io/InputStream;)Ljava/lang/Object;", "Get鷭_Ljava_io_InputStream_Handler:Com.Qcl.VH.A.D.Ą/I鷭Invoker, QualcommBinder")]
			global::Java.Lang.Object 鷭 (global::System.IO.Stream p0);

		}

		[global::Android.Runtime.Register ("com/qcl/vh/a/d/ą$鷭", DoNotGenerateAcw=true)]
		internal class I鷭Invoker : global::Java.Lang.Object, I鷭 {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/qcl/vh/a/d/ą$鷭");

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
								JNIEnv.GetClassNameFromInstance (handle), "com.qcl.vh.a.d.ą.鷭"));
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
				global::Com.Qcl.VH.A.D.Ą.I鷭 __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.A.D.Ą.I鷭> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				System.IO.Stream p0 = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.鷭 (p0));
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_鷭_Ljava_io_InputStream_;
			public unsafe global::Java.Lang.Object 鷭 (global::System.IO.Stream p0)
			{
				if (id_鷭_Ljava_io_InputStream_ == IntPtr.Zero)
					id_鷭_Ljava_io_InputStream_ = JNIEnv.GetMethodID (class_ref, "鷭", "(Ljava/io/InputStream;)Ljava/lang/Object;");
				IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (Handle, id_鷭_Ljava_io_InputStream_, __args), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qcl/vh/a/d/ą", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Ą); }
		}

		internal Ą (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.a.d']/class[@name='ą']/constructor[@name='ą' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Ą ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Ą)) {
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

		static IntPtr id_Ą_Ljava_io_ByteArrayInputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.d']/class[@name='ą']/method[@name='Ą' and count(parameter)=1 and parameter[1][@type='java.io.ByteArrayInputStream']]"
		[Register ("Ą", "(Ljava/io/ByteArrayInputStream;)Z", "")]
		public static unsafe bool InvokeĄ (global::Java.IO.ByteArrayInputStream p0)
		{
			if (id_Ą_Ljava_io_ByteArrayInputStream_ == IntPtr.Zero)
				id_Ą_Ljava_io_ByteArrayInputStream_ = JNIEnv.GetStaticMethodID (class_ref, "Ą", "(Ljava/io/ByteArrayInputStream;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_Ą_Ljava_io_ByteArrayInputStream_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_ȃ_Ljava_io_ByteArrayInputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.d']/class[@name='ą']/method[@name='ȃ' and count(parameter)=1 and parameter[1][@type='java.io.ByteArrayInputStream']]"
		[Register ("ȃ", "(Ljava/io/ByteArrayInputStream;)[B", "")]
		public static unsafe byte[] Ȃ (global::Java.IO.ByteArrayInputStream p0)
		{
			if (id_ȃ_Ljava_io_ByteArrayInputStream_ == IntPtr.Zero)
				id_ȃ_Ljava_io_ByteArrayInputStream_ = JNIEnv.GetStaticMethodID (class_ref, "ȃ", "(Ljava/io/ByteArrayInputStream;)[B");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_ȃ_Ljava_io_ByteArrayInputStream_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
			}
		}

		static IntPtr id_ˮ͈_Ljava_io_ByteArrayInputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.d']/class[@name='ą']/method[@name='ˮ͈' and count(parameter)=1 and parameter[1][@type='java.io.ByteArrayInputStream']]"
		[Register ("ˮ͈", "(Ljava/io/ByteArrayInputStream;)Ljava/lang/String;", "")]
		public static unsafe string ˮ͈ (global::Java.IO.ByteArrayInputStream p0)
		{
			if (id_ˮ͈_Ljava_io_ByteArrayInputStream_ == IntPtr.Zero)
				id_ˮ͈_Ljava_io_ByteArrayInputStream_ = JNIEnv.GetStaticMethodID (class_ref, "ˮ͈", "(Ljava/io/ByteArrayInputStream;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_ˮ͈_Ljava_io_ByteArrayInputStream_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_櫯_Ljava_io_ByteArrayInputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.d']/class[@name='ą']/method[@name='櫯' and count(parameter)=1 and parameter[1][@type='java.io.ByteArrayInputStream']]"
		[Register ("櫯", "(Ljava/io/ByteArrayInputStream;)Lcom/qcl/vh/a/d/If;", "")]
		public static unsafe global::Com.Qcl.VH.A.D.If 櫯 (global::Java.IO.ByteArrayInputStream p0)
		{
			if (id_櫯_Ljava_io_ByteArrayInputStream_ == IntPtr.Zero)
				id_櫯_Ljava_io_ByteArrayInputStream_ = JNIEnv.GetStaticMethodID (class_ref, "櫯", "(Ljava/io/ByteArrayInputStream;)Lcom/qcl/vh/a/d/If;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Qcl.VH.A.D.If __ret = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.A.D.If> (JNIEnv.CallStaticObjectMethod  (class_ref, id_櫯_Ljava_io_ByteArrayInputStream_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_鷭_Ljava_io_ByteArrayInputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.d']/class[@name='ą']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='java.io.ByteArrayInputStream']]"
		[Register ("鷭", "(Ljava/io/ByteArrayInputStream;)J", "")]
		public static unsafe long 鷭 (global::Java.IO.ByteArrayInputStream p0)
		{
			if (id_鷭_Ljava_io_ByteArrayInputStream_ == IntPtr.Zero)
				id_鷭_Ljava_io_ByteArrayInputStream_ = JNIEnv.GetStaticMethodID (class_ref, "鷭", "(Ljava/io/ByteArrayInputStream;)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_鷭_Ljava_io_ByteArrayInputStream_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_鷭_Ljava_io_ByteArrayInputStream_Lcom_qcl_vh_a_d_If_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.d']/class[@name='ą']/method[@name='鷭' and count(parameter)=2 and parameter[1][@type='java.io.ByteArrayInputStream'] and parameter[2][@type='com.qcl.vh.a.d.If']]"
		[Register ("鷭", "(Ljava/io/ByteArrayInputStream;Lcom/qcl/vh/a/d/If;)V", "")]
		public static unsafe void 鷭 (global::Java.IO.ByteArrayInputStream p0, global::Com.Qcl.VH.A.D.If p1)
		{
			if (id_鷭_Ljava_io_ByteArrayInputStream_Lcom_qcl_vh_a_d_If_ == IntPtr.Zero)
				id_鷭_Ljava_io_ByteArrayInputStream_Lcom_qcl_vh_a_d_If_ = JNIEnv.GetStaticMethodID (class_ref, "鷭", "(Ljava/io/ByteArrayInputStream;Lcom/qcl/vh/a/d/If;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_鷭_Ljava_io_ByteArrayInputStream_Lcom_qcl_vh_a_d_If_, __args);
			} finally {
			}
		}

		static IntPtr id_鷭_Ljava_io_ByteArrayInputStream_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.d']/class[@name='ą']/method[@name='鷭' and count(parameter)=2 and parameter[1][@type='java.io.ByteArrayInputStream'] and parameter[2][@type='int']]"
		[Register ("鷭", "(Ljava/io/ByteArrayInputStream;I)Ljava/io/ByteArrayInputStream;", "")]
		public static unsafe global::Java.IO.ByteArrayInputStream 鷭 (global::Java.IO.ByteArrayInputStream p0, int p1)
		{
			if (id_鷭_Ljava_io_ByteArrayInputStream_I == IntPtr.Zero)
				id_鷭_Ljava_io_ByteArrayInputStream_I = JNIEnv.GetStaticMethodID (class_ref, "鷭", "(Ljava/io/ByteArrayInputStream;I)Ljava/io/ByteArrayInputStream;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Java.IO.ByteArrayInputStream __ret = global::Java.Lang.Object.GetObject<global::Java.IO.ByteArrayInputStream> (JNIEnv.CallStaticObjectMethod  (class_ref, id_鷭_Ljava_io_ByteArrayInputStream_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
