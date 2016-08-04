using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.Content {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='BroadcastNotifier']"
	[global::Android.Runtime.Register ("com/qcl/vh/content/BroadcastNotifier", DoNotGenerateAcw=true)]
	public sealed partial class BroadcastNotifier : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='BroadcastNotifier']/field[@name='ACTION_ACTIVATION_STATE_CHANGED']"
		[Register ("ACTION_ACTIVATION_STATE_CHANGED")]
		public const string ActionActivationStateChanged = (string) "com.qcl.vh.action.ACTIVATION_STATE_CHANGED";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='BroadcastNotifier']/field[@name='ACTION_AUTH_RESULT_RECEIVED']"
		[Register ("ACTION_AUTH_RESULT_RECEIVED")]
		public const string ActionAuthResultReceived = (string) "com.qcl.vh.action.AUTH_RESULT_RECEIVED";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='BroadcastNotifier']/field[@name='ACTION_CERTIFICATE_EXPIRED']"
		[Register ("ACTION_CERTIFICATE_EXPIRED")]
		public const string ActionCertificateExpired = (string) "com.qcl.vh.action.CERTIFICATE_EXPIRED";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='BroadcastNotifier']/field[@name='ACTION_CONNECTION_STATE_CHANGED']"
		[Register ("ACTION_CONNECTION_STATE_CHANGED")]
		public const string ActionConnectionStateChanged = (string) "com.qcl.vh.action.CONNECTION_STATE_CHANGED";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='BroadcastNotifier']/field[@name='ACTION_READING_RECEIVED']"
		[Register ("ACTION_READING_RECEIVED")]
		public const string ActionReadingReceived = (string) "com.qcl.vh.action.READING_RECEIVED";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='BroadcastNotifier']/field[@name='ACTION_SERVER_COMM_STATUS_RECEIVED']"
		[Register ("ACTION_SERVER_COMM_STATUS_RECEIVED")]
		public const string ActionServerCommStatusReceived = (string) "com.qcl.vh.action.SERVER_COMM_STATUS_RECEIVED";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='BroadcastNotifier']/field[@name='CONNECTED']"
		[Register ("CONNECTED")]
		public const int Connected = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='BroadcastNotifier']/field[@name='DISCONNECTED']"
		[Register ("DISCONNECTED")]
		public const int Disconnected = (int) 2;

		static IntPtr EXTRA_ACTIVATION_ENDS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='BroadcastNotifier']/field[@name='EXTRA_ACTIVATION_ENDS']"
		[Register ("EXTRA_ACTIVATION_ENDS")]
		public static string ExtraActivationEnds {
			get {
				if (EXTRA_ACTIVATION_ENDS_jfieldId == IntPtr.Zero)
					EXTRA_ACTIVATION_ENDS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EXTRA_ACTIVATION_ENDS", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EXTRA_ACTIVATION_ENDS_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (EXTRA_ACTIVATION_ENDS_jfieldId == IntPtr.Zero)
					EXTRA_ACTIVATION_ENDS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EXTRA_ACTIVATION_ENDS", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, EXTRA_ACTIVATION_ENDS_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr EXTRA_ACTIVATION_STARTS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='BroadcastNotifier']/field[@name='EXTRA_ACTIVATION_STARTS']"
		[Register ("EXTRA_ACTIVATION_STARTS")]
		public static string ExtraActivationStarts {
			get {
				if (EXTRA_ACTIVATION_STARTS_jfieldId == IntPtr.Zero)
					EXTRA_ACTIVATION_STARTS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EXTRA_ACTIVATION_STARTS", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EXTRA_ACTIVATION_STARTS_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (EXTRA_ACTIVATION_STARTS_jfieldId == IntPtr.Zero)
					EXTRA_ACTIVATION_STARTS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EXTRA_ACTIVATION_STARTS", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, EXTRA_ACTIVATION_STARTS_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='BroadcastNotifier']/field[@name='EXTRA_ADDRESS']"
		[Register ("EXTRA_ADDRESS")]
		public const string ExtraAddress = (string) "com.qcl.vh.extra.ADDRESS";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='BroadcastNotifier']/field[@name='EXTRA_AUTH_RESULT']"
		[Register ("EXTRA_AUTH_RESULT")]
		public const string ExtraAuthResult = (string) "com.qcl.vh.extra.AUTH_STATUS";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='BroadcastNotifier']/field[@name='EXTRA_CONNECTION_STATE']"
		[Register ("EXTRA_CONNECTION_STATE")]
		public const string ExtraConnectionState = (string) "com.qcl.vh.extra.CONNECTION_STATE";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='BroadcastNotifier']/field[@name='EXTRA_DATA']"
		[Register ("EXTRA_DATA")]
		public const string ExtraData = (string) "com.qcl.vh.extra.DATA";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='BroadcastNotifier']/field[@name='EXTRA_DECODED_DATA']"
		[Register ("EXTRA_DECODED_DATA")]
		public const string ExtraDecodedData = (string) "com.qcl.vh.extra.DECODED_DATA";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='BroadcastNotifier']/field[@name='EXTRA_IS_ACTIVE']"
		[Register ("EXTRA_IS_ACTIVE")]
		public const string ExtraIsActive = (string) "com.qcl.vh.extra.IS_ACTIVE";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='BroadcastNotifier']/field[@name='EXTRA_SERVER_COMM_STATUS']"
		[Register ("EXTRA_SERVER_COMM_STATUS")]
		public const string ExtraServerCommStatus = (string) "com.qcl.vh.extra.SERVER_COMM_STATUS";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='BroadcastNotifier']/field[@name='EXTRA_TIME']"
		[Register ("EXTRA_TIME")]
		public const string ExtraTime = (string) "com.qcl.vh.extra.TIME";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='BroadcastNotifier']/field[@name='PERMISSION_RECEIVE_CONTROL_EVENTS_SUFFIX']"
		[Register ("PERMISSION_RECEIVE_CONTROL_EVENTS_SUFFIX")]
		public const string PermissionReceiveControlEventsSuffix = (string) ".vh.permission.RECEIVE_CONTROL_EVENTS";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='BroadcastNotifier']/field[@name='PERMISSION_RECEIVE_READINGS_SUFFIX']"
		[Register ("PERMISSION_RECEIVE_READINGS_SUFFIX")]
		public const string PermissionReceiveReadingsSuffix = (string) ".vh.permission.RECEIVE_SENSOR_READINGS";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qcl/vh/content/BroadcastNotifier", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BroadcastNotifier); }
		}

		internal BroadcastNotifier (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='BroadcastNotifier']/constructor[@name='BroadcastNotifier' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BroadcastNotifier ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (BroadcastNotifier)) {
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

		static IntPtr id_鷭_Landroid_content_Context_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='BroadcastNotifier']/method[@name='鷭' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='boolean']]"
		[Register ("鷭", "(Landroid/content/Context;Z)V", "")]
		public static unsafe void 鷭 (global::Android.Content.Context p0, bool p1)
		{
			if (id_鷭_Landroid_content_Context_Z == IntPtr.Zero)
				id_鷭_Landroid_content_Context_Z = JNIEnv.GetStaticMethodID (class_ref, "鷭", "(Landroid/content/Context;Z)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_鷭_Landroid_content_Context_Z, __args);
			} finally {
			}
		}

		static IntPtr id_鷭_Landroid_content_Context_ZLcom_qcl_vh_content_ConfigManager_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='BroadcastNotifier']/method[@name='鷭' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='boolean'] and parameter[3][@type='com.qcl.vh.content.ConfigManager']]"
		[Register ("鷭", "(Landroid/content/Context;ZLcom/qcl/vh/content/ConfigManager;)V", "")]
		public static unsafe void 鷭 (global::Android.Content.Context p0, bool p1, global::Com.Qcl.VH.Content.ConfigManager p2)
		{
			if (id_鷭_Landroid_content_Context_ZLcom_qcl_vh_content_ConfigManager_ == IntPtr.Zero)
				id_鷭_Landroid_content_Context_ZLcom_qcl_vh_content_ConfigManager_ = JNIEnv.GetStaticMethodID (class_ref, "鷭", "(Landroid/content/Context;ZLcom/qcl/vh/content/ConfigManager;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_鷭_Landroid_content_Context_ZLcom_qcl_vh_content_ConfigManager_, __args);
			} finally {
			}
		}

		static IntPtr id_鷭_Landroid_content_Context_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='BroadcastNotifier']/method[@name='鷭' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("鷭", "(Landroid/content/Context;I)V", "")]
		public static unsafe void 鷭 (global::Android.Content.Context p0, int p1)
		{
			if (id_鷭_Landroid_content_Context_I == IntPtr.Zero)
				id_鷭_Landroid_content_Context_I = JNIEnv.GetStaticMethodID (class_ref, "鷭", "(Landroid/content/Context;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_鷭_Landroid_content_Context_I, __args);
			} finally {
			}
		}

		static IntPtr id_鷭_Landroid_content_Context_Ljava_lang_String_Lcom_qcl_vh_content_ˮ͈_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='BroadcastNotifier']/method[@name='鷭' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.qcl.vh.content.ˮ͈'] and parameter[4][@type='android.net.Uri']]"
		[Register ("鷭", "(Landroid/content/Context;Ljava/lang/String;Lcom/qcl/vh/content/ˮ͈;Landroid/net/Uri;)V", "")]
		public static unsafe void 鷭 (global::Android.Content.Context p0, string p1, global::Com.Qcl.VH.Content.ˮ͈ p2, global::Android.Net.Uri p3)
		{
			if (id_鷭_Landroid_content_Context_Ljava_lang_String_Lcom_qcl_vh_content_ˮ͈_Landroid_net_Uri_ == IntPtr.Zero)
				id_鷭_Landroid_content_Context_Ljava_lang_String_Lcom_qcl_vh_content_ˮ͈_Landroid_net_Uri_ = JNIEnv.GetStaticMethodID (class_ref, "鷭", "(Landroid/content/Context;Ljava/lang/String;Lcom/qcl/vh/content/ˮ͈;Landroid/net/Uri;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_鷭_Landroid_content_Context_Ljava_lang_String_Lcom_qcl_vh_content_ˮ͈_Landroid_net_Uri_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_鷭_Landroid_content_Context_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='BroadcastNotifier']/method[@name='鷭' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("鷭", "(Landroid/content/Context;Ljava/lang/String;I)V", "")]
		public static unsafe void 鷭 (global::Android.Content.Context p0, string p1, int p2)
		{
			if (id_鷭_Landroid_content_Context_Ljava_lang_String_I == IntPtr.Zero)
				id_鷭_Landroid_content_Context_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "鷭", "(Landroid/content/Context;Ljava/lang/String;I)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_鷭_Landroid_content_Context_Ljava_lang_String_I, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
