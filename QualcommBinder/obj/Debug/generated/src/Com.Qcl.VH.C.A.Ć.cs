using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.C.A {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.c.a']/class[@name='ć']"
	[global::Android.Runtime.Register ("com/qcl/vh/c/a/ć", DoNotGenerateAcw=true)]
	public abstract partial class Ć : global::Java.Lang.Object {


		static IntPtr Ą_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.c.a']/class[@name='ć']/field[@name='Ą']"
		[Register ("Ą")]
		protected global::Android.Content.Context Ą {
			get {
				if (Ą_jfieldId == IntPtr.Zero)
					Ą_jfieldId = JNIEnv.GetFieldID (class_ref, "Ą", "Landroid/content/Context;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, Ą_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (Ą_jfieldId == IntPtr.Zero)
					Ą_jfieldId = JNIEnv.GetFieldID (class_ref, "Ą", "Landroid/content/Context;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, Ą_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr ˮ͈_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.c.a']/class[@name='ć']/field[@name='ˮ͈']"
		[Register ("ˮ͈")]
		protected global::Com.Qcl.VH.A.C.CON ˮ͈ {
			get {
				if (ˮ͈_jfieldId == IntPtr.Zero)
					ˮ͈_jfieldId = JNIEnv.GetFieldID (class_ref, "ˮ͈", "Lcom/qcl/vh/a/c/CON;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, ˮ͈_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.A.C.CON> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (ˮ͈_jfieldId == IntPtr.Zero)
					ˮ͈_jfieldId = JNIEnv.GetFieldID (class_ref, "ˮ͈", "Lcom/qcl/vh/a/c/CON;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, ˮ͈_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr 櫯_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.c.a']/class[@name='ć']/field[@name='櫯']"
		[Register ("櫯")]
		protected int 櫯 {
			get {
				if (櫯_jfieldId == IntPtr.Zero)
					櫯_jfieldId = JNIEnv.GetFieldID (class_ref, "櫯", "I");
				return JNIEnv.GetIntField (Handle, 櫯_jfieldId);
			}
			set {
				if (櫯_jfieldId == IntPtr.Zero)
					櫯_jfieldId = JNIEnv.GetFieldID (class_ref, "櫯", "I");
				try {
					JNIEnv.SetField (Handle, 櫯_jfieldId, value);
				} finally {
				}
			}
		}
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.qcl.vh.c.a']/interface[@name='ć.鷭']"
		[Register ("com/qcl/vh/c/a/ć$鷭", "", "Com.Qcl.VH.C.A.Ć/I鷭Invoker")]
		public partial interface I鷭 : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.c.a']/interface[@name='ć.鷭']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='com.qcl.vh.c.a.ć']]"
			[Register ("鷭", "(Lcom/qcl/vh/c/a/ć;)V", "Get鷭_Lcom_qcl_vh_c_a_ć_Handler:Com.Qcl.VH.C.A.Ć/I鷭Invoker, QualcommBinder")]
			void 鷭 (global::Com.Qcl.VH.C.A.Ć p0);

		}

		[global::Android.Runtime.Register ("com/qcl/vh/c/a/ć$鷭", DoNotGenerateAcw=true)]
		internal class I鷭Invoker : global::Java.Lang.Object, I鷭 {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/qcl/vh/c/a/ć$鷭");

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
								JNIEnv.GetClassNameFromInstance (handle), "com.qcl.vh.c.a.ć.鷭"));
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

			static Delegate cb_鷭_Lcom_qcl_vh_c_a_ć_;
#pragma warning disable 0169
			static Delegate Get鷭_Lcom_qcl_vh_c_a_ć_Handler ()
			{
				if (cb_鷭_Lcom_qcl_vh_c_a_ć_ == null)
					cb_鷭_Lcom_qcl_vh_c_a_ć_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_鷭_Lcom_qcl_vh_c_a_ć_);
				return cb_鷭_Lcom_qcl_vh_c_a_ć_;
			}

			static void n_鷭_Lcom_qcl_vh_c_a_ć_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Qcl.VH.C.A.Ć.I鷭 __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.C.A.Ć.I鷭> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Qcl.VH.C.A.Ć p0 = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.C.A.Ć> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.鷭 (p0);
			}
#pragma warning restore 0169

			IntPtr id_鷭_Lcom_qcl_vh_c_a_ć_;
			public unsafe void 鷭 (global::Com.Qcl.VH.C.A.Ć p0)
			{
				if (id_鷭_Lcom_qcl_vh_c_a_ć_ == IntPtr.Zero)
					id_鷭_Lcom_qcl_vh_c_a_ć_ = JNIEnv.GetMethodID (class_ref, "鷭", "(Lcom/qcl/vh/c/a/ć;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (Handle, id_鷭_Lcom_qcl_vh_c_a_ć_, __args);
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qcl/vh/c/a/ć", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Ć); }
		}

		protected Ć (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Lcom_qcl_vh_service_NetworkService_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.c.a']/class[@name='ć']/constructor[@name='ć' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.qcl.vh.service.NetworkService']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/qcl/vh/service/NetworkService;)V", "")]
		public unsafe Ć (global::Android.Content.Context p0, global::Com.Qcl.VH.Service.NetworkService p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (Ć)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Lcom/qcl/vh/service/NetworkService;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Lcom/qcl/vh/service/NetworkService;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Lcom_qcl_vh_service_NetworkService_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Lcom_qcl_vh_service_NetworkService_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lcom/qcl/vh/service/NetworkService;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Lcom_qcl_vh_service_NetworkService_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Lcom_qcl_vh_service_NetworkService_, __args);
			} finally {
			}
		}

		static Delegate cb_a_;
#pragma warning disable 0169
		static Delegate GetA_Handler ()
		{
			if (cb_a_ == null)
				cb_a_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_A_);
			return cb_a_;
		}

		static void n_A_ (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Qcl.VH.C.A.Ć __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.C.A.Ć> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.A_ ();
		}
#pragma warning restore 0169

		static IntPtr id_a_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.c.a']/class[@name='ć']/method[@name='a_' and count(parameter)=0]"
		[Register ("a_", "()V", "GetA_Handler")]
		protected virtual unsafe void A_ ()
		{
			if (id_a_ == IntPtr.Zero)
				id_a_ = JNIEnv.GetMethodID (class_ref, "a_", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_a_);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "a_", "()V"));
			} finally {
			}
		}

		static IntPtr id_ȃ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.c.a']/class[@name='ć']/method[@name='ȃ' and count(parameter)=0]"
		[Register ("ȃ", "()V", "")]
		public unsafe void Ȃ ()
		{
			if (id_ȃ == IntPtr.Zero)
				id_ȃ = JNIEnv.GetMethodID (class_ref, "ȃ", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_ȃ);
			} finally {
			}
		}

		static Delegate cb_鷭_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate Get鷭_Landroid_content_Context_Handler ()
		{
			if (cb_鷭_Landroid_content_Context_ == null)
				cb_鷭_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_鷭_Landroid_content_Context_);
			return cb_鷭_Landroid_content_Context_;
		}

		static IntPtr n_鷭_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Qcl.VH.C.A.Ć __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.C.A.Ć> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.鷭 (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.c.a']/class[@name='ć']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("鷭", "(Landroid/content/Context;)Lcom/qcl/vh/a/c/CON;", "Get鷭_Landroid_content_Context_Handler")]
		public abstract global::Com.Qcl.VH.A.C.CON 鷭 (global::Android.Content.Context p0);

		static IntPtr id_鷭_Lcom_qcl_vh_c_a_ć_鷭_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.c.a']/class[@name='ć']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='com.qcl.vh.c.a.ć.鷭']]"
		[Register ("鷭", "(Lcom/qcl/vh/c/a/ć$鷭;)V", "")]
		public unsafe void 鷭 (global::Com.Qcl.VH.C.A.Ć.I鷭 p0)
		{
			if (id_鷭_Lcom_qcl_vh_c_a_ć_鷭_ == IntPtr.Zero)
				id_鷭_Lcom_qcl_vh_c_a_ć_鷭_ = JNIEnv.GetMethodID (class_ref, "鷭", "(Lcom/qcl/vh/c/a/ć$鷭;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_鷭_Lcom_qcl_vh_c_a_ć_鷭_, __args);
			} finally {
			}
		}

		static Delegate cb_鷭_I;
#pragma warning disable 0169
		static Delegate Get鷭_IHandler ()
		{
			if (cb_鷭_I == null)
				cb_鷭_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_鷭_I);
			return cb_鷭_I;
		}

		static bool n_鷭_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Qcl.VH.C.A.Ć __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.C.A.Ć> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.鷭 (p0);
		}
#pragma warning restore 0169

		static IntPtr id_鷭_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.c.a']/class[@name='ć']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("鷭", "(I)Z", "Get鷭_IHandler")]
		protected virtual unsafe bool 鷭 (int p0)
		{
			if (id_鷭_I == IntPtr.Zero)
				id_鷭_I = JNIEnv.GetMethodID (class_ref, "鷭", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_鷭_I, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "鷭", "(I)Z"), __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/qcl/vh/c/a/ć", DoNotGenerateAcw=true)]
	internal partial class ĆInvoker : Ć {

		public ĆInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (ĆInvoker); }
		}

		static IntPtr id_鷭_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.c.a']/class[@name='ć']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("鷭", "(Landroid/content/Context;)Lcom/qcl/vh/a/c/CON;", "Get鷭_Landroid_content_Context_Handler")]
		public override unsafe global::Com.Qcl.VH.A.C.CON 鷭 (global::Android.Content.Context p0)
		{
			if (id_鷭_Landroid_content_Context_ == IntPtr.Zero)
				id_鷭_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "鷭", "(Landroid/content/Context;)Lcom/qcl/vh/a/c/CON;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Qcl.VH.A.C.CON __ret = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.A.C.CON> (JNIEnv.CallObjectMethod  (Handle, id_鷭_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}

}
