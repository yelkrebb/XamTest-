using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.Service {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='NetworkService']"
	[global::Android.Runtime.Register ("com/qcl/vh/service/NetworkService", DoNotGenerateAcw=true)]
	public partial class NetworkService : global::Android.App.Service {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='NetworkService']/field[@name='ACK_ERROR']"
		[Register ("ACK_ERROR")]
		public const int AckError = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='NetworkService']/field[@name='ACTION_AUTHENTICATE']"
		[Register ("ACTION_AUTHENTICATE")]
		public const string ActionAuthenticate = (string) "com.qcl.vh.action.AUTHENTICATE";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='NetworkService']/field[@name='AUTH_ERROR']"
		[Register ("AUTH_ERROR")]
		public const int AuthError = (int) 9;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='NetworkService']/field[@name='EXTRA_APP_ID']"
		[Register ("EXTRA_APP_ID")]
		public const string ExtraAppId = (string) "com.qcl.vh.service.network.extra.APP_ID";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='NetworkService']/field[@name='EXTRA_AUTH_CODE']"
		[Register ("EXTRA_AUTH_CODE")]
		public const string ExtraAuthCode = (string) "com.qcl.vh.service.network.extra.AUTH_CODE";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='NetworkService']/field[@name='FAILURE']"
		[Register ("FAILURE")]
		public const int Failure = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='NetworkService']/field[@name='HANDSHAKE_FAILED']"
		[Register ("HANDSHAKE_FAILED")]
		public const int HandshakeFailed = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='NetworkService']/field[@name='INACTIVE_SESSION']"
		[Register ("INACTIVE_SESSION")]
		public const int InactiveSession = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='NetworkService']/field[@name='NO_NETWORK']"
		[Register ("NO_NETWORK")]
		public const int NoNetwork = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='NetworkService']/field[@name='READ_ERROR']"
		[Register ("READ_ERROR")]
		public const int ReadError = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='NetworkService']/field[@name='SEND_ERROR']"
		[Register ("SEND_ERROR")]
		public const int SendError = (int) 7;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='NetworkService']/field[@name='TIMED_OUT']"
		[Register ("TIMED_OUT")]
		public const int TimedOut = (int) 2;

		static IntPtr sServerCommAlarmSet_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='NetworkService']/field[@name='sServerCommAlarmSet']"
		[Register ("sServerCommAlarmSet")]
		protected static bool SServerCommAlarmSet {
			get {
				if (sServerCommAlarmSet_jfieldId == IntPtr.Zero)
					sServerCommAlarmSet_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "sServerCommAlarmSet", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, sServerCommAlarmSet_jfieldId);
			}
			set {
				if (sServerCommAlarmSet_jfieldId == IntPtr.Zero)
					sServerCommAlarmSet_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "sServerCommAlarmSet", "Z");
				try {
					JNIEnv.SetStaticField (class_ref, sServerCommAlarmSet_jfieldId, value);
				} finally {
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='NetworkService.if']"
		[global::Android.Runtime.Register ("com/qcl/vh/service/NetworkService$if", DoNotGenerateAcw=true)]
		public sealed partial class If : global::Android.OS.Handler {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/qcl/vh/service/NetworkService$if", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (If); }
			}

			internal If (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_qcl_vh_service_NetworkService_Landroid_os_Looper_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='NetworkService.if']/constructor[@name='NetworkService.if' and count(parameter)=2 and parameter[1][@type='com.qcl.vh.service.NetworkService'] and parameter[2][@type='android.os.Looper']]"
			[Register (".ctor", "(Lcom/qcl/vh/service/NetworkService;Landroid/os/Looper;)V", "")]
			public unsafe If (global::Com.Qcl.VH.Service.NetworkService __self, global::Android.OS.Looper p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (p1);
					if (GetType () != typeof (If)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/os/Looper;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/os/Looper;)V", __args);
						return;
					}

					if (id_ctor_Lcom_qcl_vh_service_NetworkService_Landroid_os_Looper_ == IntPtr.Zero)
						id_ctor_Lcom_qcl_vh_service_NetworkService_Landroid_os_Looper_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/qcl/vh/service/NetworkService;Landroid/os/Looper;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_qcl_vh_service_NetworkService_Landroid_os_Looper_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_qcl_vh_service_NetworkService_Landroid_os_Looper_, __args);
				} finally {
				}
			}

			static IntPtr id_handleMessage_Landroid_os_Message_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='NetworkService.if']/method[@name='handleMessage' and count(parameter)=1 and parameter[1][@type='android.os.Message']]"
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='NetworkService.鷭']"
		[global::Android.Runtime.Register ("com/qcl/vh/service/NetworkService$鷭", DoNotGenerateAcw=true)]
		public sealed partial class 鷭 : global::Android.OS.Handler {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/qcl/vh/service/NetworkService$鷭", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (鷭); }
			}

			internal 鷭 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_qcl_vh_service_NetworkService_Landroid_os_Looper_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='NetworkService.鷭']/constructor[@name='NetworkService.鷭' and count(parameter)=2 and parameter[1][@type='com.qcl.vh.service.NetworkService'] and parameter[2][@type='android.os.Looper']]"
			[Register (".ctor", "(Lcom/qcl/vh/service/NetworkService;Landroid/os/Looper;)V", "")]
			public unsafe 鷭 (global::Com.Qcl.VH.Service.NetworkService __self, global::Android.OS.Looper p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (p1);
					if (GetType () != typeof (鷭)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/os/Looper;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/os/Looper;)V", __args);
						return;
					}

					if (id_ctor_Lcom_qcl_vh_service_NetworkService_Landroid_os_Looper_ == IntPtr.Zero)
						id_ctor_Lcom_qcl_vh_service_NetworkService_Landroid_os_Looper_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/qcl/vh/service/NetworkService;Landroid/os/Looper;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_qcl_vh_service_NetworkService_Landroid_os_Looper_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_qcl_vh_service_NetworkService_Landroid_os_Looper_, __args);
				} finally {
				}
			}

			static IntPtr id_handleMessage_Landroid_os_Message_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='NetworkService.鷭']/method[@name='handleMessage' and count(parameter)=1 and parameter[1][@type='android.os.Message']]"
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
				return JNIEnv.FindClass ("com/qcl/vh/service/NetworkService", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NetworkService); }
		}

		protected NetworkService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='NetworkService']/constructor[@name='NetworkService' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe NetworkService ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (NetworkService)) {
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

		static IntPtr id_getGmtOffsetInMinutes;
		public static unsafe int GmtOffsetInMinutes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='NetworkService']/method[@name='getGmtOffsetInMinutes' and count(parameter)=0]"
			[Register ("getGmtOffsetInMinutes", "()I", "GetGetGmtOffsetInMinutesHandler")]
			get {
				if (id_getGmtOffsetInMinutes == IntPtr.Zero)
					id_getGmtOffsetInMinutes = JNIEnv.GetStaticMethodID (class_ref, "getGmtOffsetInMinutes", "()I");
				try {
					return JNIEnv.CallStaticIntMethod  (class_ref, id_getGmtOffsetInMinutes);
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
			global::Com.Qcl.VH.Service.NetworkService __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Service.NetworkService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsHubActive;
		}
#pragma warning restore 0169

		static IntPtr id_isHubActive;
		protected virtual unsafe bool IsHubActive {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='NetworkService']/method[@name='isHubActive' and count(parameter)=0]"
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

		static Delegate cb_createPendingIntent_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetCreatePendingIntent_Landroid_content_Context_Handler ()
		{
			if (cb_createPendingIntent_Landroid_content_Context_ == null)
				cb_createPendingIntent_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CreatePendingIntent_Landroid_content_Context_);
			return cb_createPendingIntent_Landroid_content_Context_;
		}

		static IntPtr n_CreatePendingIntent_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Qcl.VH.Service.NetworkService __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Service.NetworkService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreatePendingIntent (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_createPendingIntent_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='NetworkService']/method[@name='createPendingIntent' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("createPendingIntent", "(Landroid/content/Context;)Landroid/app/PendingIntent;", "GetCreatePendingIntent_Landroid_content_Context_Handler")]
		protected virtual unsafe global::Android.App.PendingIntent CreatePendingIntent (global::Android.Content.Context p0)
		{
			if (id_createPendingIntent_Landroid_content_Context_ == IntPtr.Zero)
				id_createPendingIntent_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "createPendingIntent", "(Landroid/content/Context;)Landroid/app/PendingIntent;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Android.App.PendingIntent __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.App.PendingIntent> (JNIEnv.CallObjectMethod  (Handle, id_createPendingIntent_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.App.PendingIntent> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createPendingIntent", "(Landroid/content/Context;)Landroid/app/PendingIntent;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_doAuthentication_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDoAuthentication_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_doAuthentication_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_doAuthentication_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_DoAuthentication_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_);
			return cb_doAuthentication_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_DoAuthentication_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Qcl.VH.Service.NetworkService __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Service.NetworkService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.DoAuthentication (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_doAuthentication_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='NetworkService']/method[@name='doAuthentication' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("doAuthentication", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", "GetDoAuthentication_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Handler")]
		protected virtual unsafe void DoAuthentication (global::Android.Content.Context p0, string p1, string p2)
		{
			if (id_doAuthentication_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_doAuthentication_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "doAuthentication", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_doAuthentication_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "doAuthentication", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_doHandShake;
#pragma warning disable 0169
		static Delegate GetDoHandShakeHandler ()
		{
			if (cb_doHandShake == null)
				cb_doHandShake = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DoHandShake);
			return cb_doHandShake;
		}

		static void n_DoHandShake (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Qcl.VH.Service.NetworkService __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Service.NetworkService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DoHandShake ();
		}
#pragma warning restore 0169

		static IntPtr id_doHandShake;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='NetworkService']/method[@name='doHandShake' and count(parameter)=0]"
		[Register ("doHandShake", "()V", "GetDoHandShakeHandler")]
		protected virtual unsafe void DoHandShake ()
		{
			if (id_doHandShake == IntPtr.Zero)
				id_doHandShake = JNIEnv.GetMethodID (class_ref, "doHandShake", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_doHandShake);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "doHandShake", "()V"));
			} finally {
			}
		}

		static Delegate cb_getConfigManager_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetGetConfigManager_Landroid_content_Context_Handler ()
		{
			if (cb_getConfigManager_Landroid_content_Context_ == null)
				cb_getConfigManager_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetConfigManager_Landroid_content_Context_);
			return cb_getConfigManager_Landroid_content_Context_;
		}

		static IntPtr n_GetConfigManager_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Qcl.VH.Service.NetworkService __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Service.NetworkService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetConfigManager (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getConfigManager_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='NetworkService']/method[@name='getConfigManager' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getConfigManager", "(Landroid/content/Context;)Lcom/qcl/vh/content/ConfigManager;", "GetGetConfigManager_Landroid_content_Context_Handler")]
		protected virtual unsafe global::Com.Qcl.VH.Content.ConfigManager GetConfigManager (global::Android.Content.Context p0)
		{
			if (id_getConfigManager_Landroid_content_Context_ == IntPtr.Zero)
				id_getConfigManager_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "getConfigManager", "(Landroid/content/Context;)Lcom/qcl/vh/content/ConfigManager;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Qcl.VH.Content.ConfigManager __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.ConfigManager> (JNIEnv.CallObjectMethod  (Handle, id_getConfigManager_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.ConfigManager> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConfigManager", "(Landroid/content/Context;)Lcom/qcl/vh/content/ConfigManager;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getPublicKey_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='NetworkService']/method[@name='getPublicKey' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getPublicKey", "(Landroid/content/Context;)Ljava/security/PublicKey;", "")]
		public static unsafe global::Java.Security.IPublicKey GetPublicKey (global::Android.Content.Context p0)
		{
			if (id_getPublicKey_Landroid_content_Context_ == IntPtr.Zero)
				id_getPublicKey_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getPublicKey", "(Landroid/content/Context;)Ljava/security/PublicKey;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Java.Security.IPublicKey __ret = global::Java.Lang.Object.GetObject<global::Java.Security.IPublicKey> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getPublicKey_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isCertificateValid_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='NetworkService']/method[@name='isCertificateValid' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isCertificateValid", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool IsCertificateValid (global::Android.Content.Context p0)
		{
			if (id_isCertificateValid_Landroid_content_Context_ == IntPtr.Zero)
				id_isCertificateValid_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "isCertificateValid", "(Landroid/content/Context;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isCertificateValid_Landroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isNetworkAvailable_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='NetworkService']/method[@name='isNetworkAvailable' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isNetworkAvailable", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool IsNetworkAvailable (global::Android.Content.Context p0)
		{
			if (id_isNetworkAvailable_Landroid_content_Context_ == IntPtr.Zero)
				id_isNetworkAvailable_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "isNetworkAvailable", "(Landroid/content/Context;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isNetworkAvailable_Landroid_content_Context_, __args);
				return __ret;
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
			global::Com.Qcl.VH.Service.NetworkService __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Service.NetworkService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnBind (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onBind_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='NetworkService']/method[@name='onBind' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
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

		static Delegate cb_processStopReason_I;
#pragma warning disable 0169
		static Delegate GetProcessStopReason_IHandler ()
		{
			if (cb_processStopReason_I == null)
				cb_processStopReason_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_ProcessStopReason_I);
			return cb_processStopReason_I;
		}

		static void n_ProcessStopReason_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Qcl.VH.Service.NetworkService __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Service.NetworkService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ProcessStopReason (p0);
		}
#pragma warning restore 0169

		static IntPtr id_processStopReason_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='NetworkService']/method[@name='processStopReason' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("processStopReason", "(I)V", "GetProcessStopReason_IHandler")]
		protected virtual unsafe void ProcessStopReason (int p0)
		{
			if (id_processStopReason_I == IntPtr.Zero)
				id_processStopReason_I = JNIEnv.GetMethodID (class_ref, "processStopReason", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_processStopReason_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "processStopReason", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_queueMessage_Lcom_qcl_vh_a_c_CON_Lcom_qcl_vh_content_鷭_;
#pragma warning disable 0169
		static Delegate GetQueueMessage_Lcom_qcl_vh_a_c_CON_Lcom_qcl_vh_content_鷭_Handler ()
		{
			if (cb_queueMessage_Lcom_qcl_vh_a_c_CON_Lcom_qcl_vh_content_鷭_ == null)
				cb_queueMessage_Lcom_qcl_vh_a_c_CON_Lcom_qcl_vh_content_鷭_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_QueueMessage_Lcom_qcl_vh_a_c_CON_Lcom_qcl_vh_content_鷭_);
			return cb_queueMessage_Lcom_qcl_vh_a_c_CON_Lcom_qcl_vh_content_鷭_;
		}

		static bool n_QueueMessage_Lcom_qcl_vh_a_c_CON_Lcom_qcl_vh_content_鷭_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Qcl.VH.Service.NetworkService __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Service.NetworkService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Qcl.VH.A.C.CON p0 = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.A.C.CON> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Qcl.VH.Content.I鷭 p1 = (global::Com.Qcl.VH.Content.I鷭)global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.I鷭> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.QueueMessage (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_queueMessage_Lcom_qcl_vh_a_c_CON_Lcom_qcl_vh_content_鷭_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='NetworkService']/method[@name='queueMessage' and count(parameter)=2 and parameter[1][@type='com.qcl.vh.a.c.CON'] and parameter[2][@type='com.qcl.vh.content.鷭']]"
		[Register ("queueMessage", "(Lcom/qcl/vh/a/c/CON;Lcom/qcl/vh/content/鷭;)Z", "GetQueueMessage_Lcom_qcl_vh_a_c_CON_Lcom_qcl_vh_content_鷭_Handler")]
		public virtual unsafe bool QueueMessage (global::Com.Qcl.VH.A.C.CON p0, global::Com.Qcl.VH.Content.I鷭 p1)
		{
			if (id_queueMessage_Lcom_qcl_vh_a_c_CON_Lcom_qcl_vh_content_鷭_ == IntPtr.Zero)
				id_queueMessage_Lcom_qcl_vh_a_c_CON_Lcom_qcl_vh_content_鷭_ = JNIEnv.GetMethodID (class_ref, "queueMessage", "(Lcom/qcl/vh/a/c/CON;Lcom/qcl/vh/content/鷭;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_queueMessage_Lcom_qcl_vh_a_c_CON_Lcom_qcl_vh_content_鷭_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "queueMessage", "(Lcom/qcl/vh/a/c/CON;Lcom/qcl/vh/content/鷭;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setUpCallbackHandler;
#pragma warning disable 0169
		static Delegate GetSetUpCallbackHandlerHandler ()
		{
			if (cb_setUpCallbackHandler == null)
				cb_setUpCallbackHandler = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SetUpCallbackHandler);
			return cb_setUpCallbackHandler;
		}

		static void n_SetUpCallbackHandler (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Qcl.VH.Service.NetworkService __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Service.NetworkService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetUpCallbackHandler ();
		}
#pragma warning restore 0169

		static IntPtr id_setUpCallbackHandler;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='NetworkService']/method[@name='setUpCallbackHandler' and count(parameter)=0]"
		[Register ("setUpCallbackHandler", "()V", "GetSetUpCallbackHandlerHandler")]
		protected virtual unsafe void SetUpCallbackHandler ()
		{
			if (id_setUpCallbackHandler == IntPtr.Zero)
				id_setUpCallbackHandler = JNIEnv.GetMethodID (class_ref, "setUpCallbackHandler", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setUpCallbackHandler);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUpCallbackHandler", "()V"));
			} finally {
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
			global::Com.Qcl.VH.Service.NetworkService __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Service.NetworkService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetUpServiceHandler ();
		}
#pragma warning restore 0169

		static IntPtr id_setUpServiceHandler;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='NetworkService']/method[@name='setUpServiceHandler' and count(parameter)=0]"
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

		static Delegate cb_shouldUploadHubHealth_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetShouldUploadHubHealth_Ljava_lang_String_Handler ()
		{
			if (cb_shouldUploadHubHealth_Ljava_lang_String_ == null)
				cb_shouldUploadHubHealth_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_ShouldUploadHubHealth_Ljava_lang_String_);
			return cb_shouldUploadHubHealth_Ljava_lang_String_;
		}

		static bool n_ShouldUploadHubHealth_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Qcl.VH.Service.NetworkService __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Service.NetworkService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ShouldUploadHubHealth (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_shouldUploadHubHealth_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='NetworkService']/method[@name='shouldUploadHubHealth' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("shouldUploadHubHealth", "(Ljava/lang/String;)Z", "GetShouldUploadHubHealth_Ljava_lang_String_Handler")]
		protected virtual unsafe bool ShouldUploadHubHealth (string p0)
		{
			if (id_shouldUploadHubHealth_Ljava_lang_String_ == IntPtr.Zero)
				id_shouldUploadHubHealth_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "shouldUploadHubHealth", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_shouldUploadHubHealth_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "shouldUploadHubHealth", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_start_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='NetworkService']/method[@name='start' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("start", "(Landroid/content/Context;)V", "")]
		public static unsafe void Start (global::Android.Content.Context p0)
		{
			if (id_start_Landroid_content_Context_ == IntPtr.Zero)
				id_start_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "start", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_start_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_start_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='NetworkService']/method[@name='start' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("start", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static unsafe void Start (global::Android.Content.Context p0, string p1)
		{
			if (id_start_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_start_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "start", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_start_Landroid_content_Context_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
