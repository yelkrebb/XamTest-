using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.Content {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='ConfigManager']"
	[global::Android.Runtime.Register ("com/qcl/vh/content/ConfigManager", DoNotGenerateAcw=true)]
	public partial class ConfigManager : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qcl/vh/content/ConfigManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ConfigManager); }
		}

		protected ConfigManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='ConfigManager']/constructor[@name='ConfigManager' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe ConfigManager (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (ConfigManager)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static Delegate cb_getActivationEndDate;
#pragma warning disable 0169
		static Delegate GetGetActivationEndDateHandler ()
		{
			if (cb_getActivationEndDate == null)
				cb_getActivationEndDate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetActivationEndDate);
			return cb_getActivationEndDate;
		}

		static long n_GetActivationEndDate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Qcl.VH.Content.ConfigManager __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.ConfigManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ActivationEndDate;
		}
#pragma warning restore 0169

		static IntPtr id_getActivationEndDate;
		public virtual unsafe long ActivationEndDate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='ConfigManager']/method[@name='getActivationEndDate' and count(parameter)=0]"
			[Register ("getActivationEndDate", "()J", "GetGetActivationEndDateHandler")]
			get {
				if (id_getActivationEndDate == IntPtr.Zero)
					id_getActivationEndDate = JNIEnv.GetMethodID (class_ref, "getActivationEndDate", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod  (Handle, id_getActivationEndDate);
					else
						return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getActivationEndDate", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getActivationStartDate;
#pragma warning disable 0169
		static Delegate GetGetActivationStartDateHandler ()
		{
			if (cb_getActivationStartDate == null)
				cb_getActivationStartDate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetActivationStartDate);
			return cb_getActivationStartDate;
		}

		static long n_GetActivationStartDate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Qcl.VH.Content.ConfigManager __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.ConfigManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ActivationStartDate;
		}
#pragma warning restore 0169

		static IntPtr id_getActivationStartDate;
		public virtual unsafe long ActivationStartDate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='ConfigManager']/method[@name='getActivationStartDate' and count(parameter)=0]"
			[Register ("getActivationStartDate", "()J", "GetGetActivationStartDateHandler")]
			get {
				if (id_getActivationStartDate == IntPtr.Zero)
					id_getActivationStartDate = JNIEnv.GetMethodID (class_ref, "getActivationStartDate", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod  (Handle, id_getActivationStartDate);
					else
						return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getActivationStartDate", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_isHubActive;
#pragma warning disable 0169
		static Delegate GetIsHubActiveHandler ()
		{
			if (cb_isHubActive == null)
				cb_isHubActive = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsHubActive);
			return cb_isHubActive;
		}

		static bool n_IsHubActive (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Qcl.VH.Content.ConfigManager __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.ConfigManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsHubActive;
		}
#pragma warning restore 0169

		static IntPtr id_isHubActive;
		public virtual unsafe bool IsHubActive {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='ConfigManager']/method[@name='isHubActive' and count(parameter)=0]"
			[Register ("isHubActive", "()Z", "GetIsHubActiveHandler")]
			get {
				if (id_isHubActive == IntPtr.Zero)
					id_isHubActive = JNIEnv.GetMethodID (class_ref, "isHubActive", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isHubActive);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isHubActive", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isHubInitialized;
#pragma warning disable 0169
		static Delegate GetIsHubInitializedHandler ()
		{
			if (cb_isHubInitialized == null)
				cb_isHubInitialized = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsHubInitialized);
			return cb_isHubInitialized;
		}

		static bool n_IsHubInitialized (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Qcl.VH.Content.ConfigManager __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.ConfigManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsHubInitialized;
		}
#pragma warning restore 0169

		static IntPtr id_isHubInitialized;
		public virtual unsafe bool IsHubInitialized {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='ConfigManager']/method[@name='isHubInitialized' and count(parameter)=0]"
			[Register ("isHubInitialized", "()Z", "GetIsHubInitializedHandler")]
			get {
				if (id_isHubInitialized == IntPtr.Zero)
					id_isHubInitialized = JNIEnv.GetMethodID (class_ref, "isHubInitialized", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isHubInitialized);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isHubInitialized", "()Z"));
				} finally {
				}
			}
		}

		static IntPtr id_ȃ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='ConfigManager']/method[@name='ȃ' and count(parameter)=0]"
		[Register ("ȃ", "()J", "")]
		public unsafe long Ȃ ()
		{
			if (id_ȃ == IntPtr.Zero)
				id_ȃ = JNIEnv.GetMethodID (class_ref, "ȃ", "()J");
			try {
				return JNIEnv.CallLongMethod  (Handle, id_ȃ);
			} finally {
			}
		}

		static IntPtr id_ˮ͈;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='ConfigManager']/method[@name='ˮ͈' and count(parameter)=0]"
		[Register ("ˮ͈", "()J", "")]
		public unsafe long ˮ͈ ()
		{
			if (id_ˮ͈ == IntPtr.Zero)
				id_ˮ͈ = JNIEnv.GetMethodID (class_ref, "ˮ͈", "()J");
			try {
				return JNIEnv.CallLongMethod  (Handle, id_ˮ͈);
			} finally {
			}
		}

		static IntPtr id_櫯;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='ConfigManager']/method[@name='櫯' and count(parameter)=0]"
		[Register ("櫯", "()J", "")]
		public unsafe long 櫯 ()
		{
			if (id_櫯 == IntPtr.Zero)
				id_櫯 = JNIEnv.GetMethodID (class_ref, "櫯", "()J");
			try {
				return JNIEnv.CallLongMethod  (Handle, id_櫯);
			} finally {
			}
		}

		static IntPtr id_鷭;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='ConfigManager']/method[@name='鷭' and count(parameter)=0]"
		[Register ("鷭", "()J", "")]
		public unsafe long 鷭 ()
		{
			if (id_鷭 == IntPtr.Zero)
				id_鷭 = JNIEnv.GetMethodID (class_ref, "鷭", "()J");
			try {
				return JNIEnv.CallLongMethod  (Handle, id_鷭);
			} finally {
			}
		}

		static IntPtr id_鷭_Lcom_qcl_vh_a_c_AuX_Lcom_qcl_vh_content_DeviceManager_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='ConfigManager']/method[@name='鷭' and count(parameter)=2 and parameter[1][@type='com.qcl.vh.a.c.AuX'] and parameter[2][@type='com.qcl.vh.content.DeviceManager']]"
		[Register ("鷭", "(Lcom/qcl/vh/a/c/AuX;Lcom/qcl/vh/content/DeviceManager;)V", "")]
		public unsafe void 鷭 (global::Com.Qcl.VH.A.C.AuX p0, global::Com.Qcl.VH.Content.DeviceManager p1)
		{
			if (id_鷭_Lcom_qcl_vh_a_c_AuX_Lcom_qcl_vh_content_DeviceManager_ == IntPtr.Zero)
				id_鷭_Lcom_qcl_vh_a_c_AuX_Lcom_qcl_vh_content_DeviceManager_ = JNIEnv.GetMethodID (class_ref, "鷭", "(Lcom/qcl/vh/a/c/AuX;Lcom/qcl/vh/content/DeviceManager;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod  (Handle, id_鷭_Lcom_qcl_vh_a_c_AuX_Lcom_qcl_vh_content_DeviceManager_, __args);
			} finally {
			}
		}

		static IntPtr id_鷭_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='ConfigManager']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("鷭", "(J)V", "")]
		public unsafe void 鷭 (long p0)
		{
			if (id_鷭_J == IntPtr.Zero)
				id_鷭_J = JNIEnv.GetMethodID (class_ref, "鷭", "(J)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_鷭_J, __args);
			} finally {
			}
		}

	}
}
