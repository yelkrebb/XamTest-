using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.Service {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='WifiService']"
	[global::Android.Runtime.Register ("com/qcl/vh/service/WifiService", DoNotGenerateAcw=true)]
	public partial class WifiService : global::Android.App.Service {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='WifiService']/field[@name='ACTION_PROCESS_WIFI_CONFIG']"
		[Register ("ACTION_PROCESS_WIFI_CONFIG")]
		public const string ActionProcessWifiConfig = (string) "com.qcl.vh.action.PROCESS_WIFI_CONFIG";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='WifiService']/field[@name='ACTION_WIFI_OPERATION_COMPLETE']"
		[Register ("ACTION_WIFI_OPERATION_COMPLETE")]
		public const string ActionWifiOperationComplete = (string) "com.qcl.vh.action.WIFI_OP_COMPLETE";

		static IntPtr TAG_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='WifiService']/field[@name='TAG']"
		[Register ("TAG")]
		public static string Tag {
			get {
				if (TAG_jfieldId == IntPtr.Zero)
					TAG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TAG", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TAG_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='WifiService.鷭']"
		[global::Android.Runtime.Register ("com/qcl/vh/service/WifiService$鷭", DoNotGenerateAcw=true)]
		public partial class 鷭 : global::Android.OS.Handler {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/qcl/vh/service/WifiService$鷭", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (鷭); }
			}

			protected 鷭 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_handleMessage_Landroid_os_Message_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='WifiService.鷭']/method[@name='handleMessage' and count(parameter)=1 and parameter[1][@type='android.os.Message']]"
			[Register ("handleMessage", "(Landroid/os/Message;)V", "")]
			public override sealed unsafe void HandleMessage (global::Android.OS.Message p0)
			{
				if (id_handleMessage_Landroid_os_Message_ == IntPtr.Zero)
					id_handleMessage_Landroid_os_Message_ = JNIEnv.GetMethodID (class_ref, "handleMessage", "(Landroid/os/Message;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					JNIEnv.CallVoidMethod  (Handle, id_handleMessage_Landroid_os_Message_, __args);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qcl/vh/service/WifiService", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (WifiService); }
		}

		protected WifiService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='WifiService']/constructor[@name='WifiService' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe WifiService ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (WifiService)) {
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

		static Delegate cb_getWifiConfigs;
#pragma warning disable 0169
		static Delegate GetGetWifiConfigsHandler ()
		{
			if (cb_getWifiConfigs == null)
				cb_getWifiConfigs = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetWifiConfigs);
			return cb_getWifiConfigs;
		}

		static IntPtr n_GetWifiConfigs (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Qcl.VH.Service.WifiService __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Service.WifiService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Qcl.VH.D.鷭.If>.ToLocalJniHandle (__this.WifiConfigs);
		}
#pragma warning restore 0169

		static IntPtr id_getWifiConfigs;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Qcl.VH.D.鷭.If> WifiConfigs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='WifiService']/method[@name='getWifiConfigs' and count(parameter)=0]"
			[Register ("getWifiConfigs", "()Ljava/util/List;", "GetGetWifiConfigsHandler")]
			get {
				if (id_getWifiConfigs == IntPtr.Zero)
					id_getWifiConfigs = JNIEnv.GetMethodID (class_ref, "getWifiConfigs", "()Ljava/util/List;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Qcl.VH.D.鷭.If>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getWifiConfigs), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Qcl.VH.D.鷭.If>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWifiConfigs", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_handleMessage_Landroid_os_Message_;
#pragma warning disable 0169
		static Delegate GetHandleMessage_Landroid_os_Message_Handler ()
		{
			if (cb_handleMessage_Landroid_os_Message_ == null)
				cb_handleMessage_Landroid_os_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_HandleMessage_Landroid_os_Message_);
			return cb_handleMessage_Landroid_os_Message_;
		}

		static void n_HandleMessage_Landroid_os_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Qcl.VH.Service.WifiService __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Service.WifiService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Message p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Message> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.HandleMessage (p0);
		}
#pragma warning restore 0169

		static IntPtr id_handleMessage_Landroid_os_Message_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='WifiService']/method[@name='handleMessage' and count(parameter)=1 and parameter[1][@type='android.os.Message']]"
		[Register ("handleMessage", "(Landroid/os/Message;)V", "GetHandleMessage_Landroid_os_Message_Handler")]
		public virtual unsafe void HandleMessage (global::Android.OS.Message p0)
		{
			if (id_handleMessage_Landroid_os_Message_ == IntPtr.Zero)
				id_handleMessage_Landroid_os_Message_ = JNIEnv.GetMethodID (class_ref, "handleMessage", "(Landroid/os/Message;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_handleMessage_Landroid_os_Message_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "handleMessage", "(Landroid/os/Message;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onBind_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetOnBind_Landroid_content_Intent_Handler ()
		{
			if (cb_onBind_Landroid_content_Intent_ == null)
				cb_onBind_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnBind_Landroid_content_Intent_);
			return cb_onBind_Landroid_content_Intent_;
		}

		static IntPtr n_OnBind_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Qcl.VH.Service.WifiService __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Service.WifiService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnBind (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onBind_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='WifiService']/method[@name='onBind' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;", "GetOnBind_Landroid_content_Intent_Handler")]
		public override unsafe global::Android.OS.IBinder OnBind (global::Android.Content.Intent p0)
		{
			if (id_onBind_Landroid_content_Intent_ == IntPtr.Zero)
				id_onBind_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Android.OS.IBinder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallObjectMethod  (Handle, id_onBind_Landroid_content_Intent_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_processWifiConfig_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetProcessWifiConfig_Ljava_util_List_Handler ()
		{
			if (cb_processWifiConfig_Ljava_util_List_ == null)
				cb_processWifiConfig_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ProcessWifiConfig_Ljava_util_List_);
			return cb_processWifiConfig_Ljava_util_List_;
		}

		static void n_ProcessWifiConfig_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Qcl.VH.Service.WifiService __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Service.WifiService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Qcl.VH.D.鷭.If>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ProcessWifiConfig (p0);
		}
#pragma warning restore 0169

		static IntPtr id_processWifiConfig_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='WifiService']/method[@name='processWifiConfig' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.qcl.vh.d.鷭.if&gt;']]"
		[Register ("processWifiConfig", "(Ljava/util/List;)V", "GetProcessWifiConfig_Ljava_util_List_Handler")]
		protected virtual unsafe void ProcessWifiConfig (global::System.Collections.Generic.IList<global::Com.Qcl.VH.D.鷭.If> p0)
		{
			if (id_processWifiConfig_Ljava_util_List_ == IntPtr.Zero)
				id_processWifiConfig_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "processWifiConfig", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Qcl.VH.D.鷭.If>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_processWifiConfig_Ljava_util_List_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "processWifiConfig", "(Ljava/util/List;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setUpServiceHandler;
#pragma warning disable 0169
		static Delegate GetSetUpServiceHandlerHandler ()
		{
			if (cb_setUpServiceHandler == null)
				cb_setUpServiceHandler = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SetUpServiceHandler);
			return cb_setUpServiceHandler;
		}

		static void n_SetUpServiceHandler (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Qcl.VH.Service.WifiService __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Service.WifiService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetUpServiceHandler ();
		}
#pragma warning restore 0169

		static IntPtr id_setUpServiceHandler;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='WifiService']/method[@name='setUpServiceHandler' and count(parameter)=0]"
		[Register ("setUpServiceHandler", "()V", "GetSetUpServiceHandlerHandler")]
		protected virtual unsafe void SetUpServiceHandler ()
		{
			if (id_setUpServiceHandler == IntPtr.Zero)
				id_setUpServiceHandler = JNIEnv.GetMethodID (class_ref, "setUpServiceHandler", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setUpServiceHandler);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUpServiceHandler", "()V"));
			} finally {
			}
		}

	}
}
