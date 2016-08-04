using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.Content {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubPreferences']"
	[global::Android.Runtime.Register ("com/qcl/vh/content/VirtualHubPreferences", DoNotGenerateAcw=true)]
	public partial class VirtualHubPreferences : global::Java.Lang.Object {


		static IntPtr KEY_DIAGNOSTIC_EVENTS_UPLOADED_SET_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubPreferences']/field[@name='KEY_DIAGNOSTIC_EVENTS_UPLOADED_SET']"
		[Register ("KEY_DIAGNOSTIC_EVENTS_UPLOADED_SET")]
		public static string KeyDiagnosticEventsUploadedSet {
			get {
				if (KEY_DIAGNOSTIC_EVENTS_UPLOADED_SET_jfieldId == IntPtr.Zero)
					KEY_DIAGNOSTIC_EVENTS_UPLOADED_SET_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "KEY_DIAGNOSTIC_EVENTS_UPLOADED_SET", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, KEY_DIAGNOSTIC_EVENTS_UPLOADED_SET_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (KEY_DIAGNOSTIC_EVENTS_UPLOADED_SET_jfieldId == IntPtr.Zero)
					KEY_DIAGNOSTIC_EVENTS_UPLOADED_SET_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "KEY_DIAGNOSTIC_EVENTS_UPLOADED_SET", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, KEY_DIAGNOSTIC_EVENTS_UPLOADED_SET_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr KEY_HUB_STARTED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubPreferences']/field[@name='KEY_HUB_STARTED']"
		[Register ("KEY_HUB_STARTED")]
		public static string KeyHubStarted {
			get {
				if (KEY_HUB_STARTED_jfieldId == IntPtr.Zero)
					KEY_HUB_STARTED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "KEY_HUB_STARTED", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, KEY_HUB_STARTED_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (KEY_HUB_STARTED_jfieldId == IntPtr.Zero)
					KEY_HUB_STARTED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "KEY_HUB_STARTED", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, KEY_HUB_STARTED_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr KEY_MCD_ID_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubPreferences']/field[@name='KEY_MCD_ID']"
		[Register ("KEY_MCD_ID")]
		public static string KeyMcdId {
			get {
				if (KEY_MCD_ID_jfieldId == IntPtr.Zero)
					KEY_MCD_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "KEY_MCD_ID", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, KEY_MCD_ID_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (KEY_MCD_ID_jfieldId == IntPtr.Zero)
					KEY_MCD_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "KEY_MCD_ID", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, KEY_MCD_ID_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr KEY_PENDING_READINGS_COUNT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubPreferences']/field[@name='KEY_PENDING_READINGS_COUNT']"
		[Register ("KEY_PENDING_READINGS_COUNT")]
		public static string KeyPendingReadingsCount {
			get {
				if (KEY_PENDING_READINGS_COUNT_jfieldId == IntPtr.Zero)
					KEY_PENDING_READINGS_COUNT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "KEY_PENDING_READINGS_COUNT", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, KEY_PENDING_READINGS_COUNT_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (KEY_PENDING_READINGS_COUNT_jfieldId == IntPtr.Zero)
					KEY_PENDING_READINGS_COUNT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "KEY_PENDING_READINGS_COUNT", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, KEY_PENDING_READINGS_COUNT_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr PREFERENCES_NAME_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubPreferences']/field[@name='PREFERENCES_NAME']"
		[Register ("PREFERENCES_NAME")]
		public static string PreferencesName {
			get {
				if (PREFERENCES_NAME_jfieldId == IntPtr.Zero)
					PREFERENCES_NAME_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PREFERENCES_NAME", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PREFERENCES_NAME_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (PREFERENCES_NAME_jfieldId == IntPtr.Zero)
					PREFERENCES_NAME_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PREFERENCES_NAME", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, PREFERENCES_NAME_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qcl/vh/content/VirtualHubPreferences", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VirtualHubPreferences); }
		}

		protected VirtualHubPreferences (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubPreferences']/constructor[@name='VirtualHubPreferences' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe VirtualHubPreferences ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (VirtualHubPreferences)) {
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

		static IntPtr id_addEventUploaded_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubPreferences']/method[@name='addEventUploaded' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("addEventUploaded", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static unsafe void AddEventUploaded (global::Android.Content.Context p0, string p1)
		{
			if (id_addEventUploaded_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_addEventUploaded_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "addEventUploaded", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_addEventUploaded_Landroid_content_Context_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_clearEventsUploaded_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubPreferences']/method[@name='clearEventsUploaded' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("clearEventsUploaded", "(Landroid/content/Context;)V", "")]
		public static unsafe void ClearEventsUploaded (global::Android.Content.Context p0)
		{
			if (id_clearEventsUploaded_Landroid_content_Context_ == IntPtr.Zero)
				id_clearEventsUploaded_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "clearEventsUploaded", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_clearEventsUploaded_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_getMcdId_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubPreferences']/method[@name='getMcdId' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getMcdId", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetMcdId (global::Android.Content.Context p0)
		{
			if (id_getMcdId_Landroid_content_Context_ == IntPtr.Zero)
				id_getMcdId_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getMcdId", "(Landroid/content/Context;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getMcdId_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getPendingReadingsCount_Landroid_content_Context_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubPreferences']/method[@name='getPendingReadingsCount' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("getPendingReadingsCount", "(Landroid/content/Context;I)I", "")]
		public static unsafe int GetPendingReadingsCount (global::Android.Content.Context p0, int p1)
		{
			if (id_getPendingReadingsCount_Landroid_content_Context_I == IntPtr.Zero)
				id_getPendingReadingsCount_Landroid_content_Context_I = JNIEnv.GetStaticMethodID (class_ref, "getPendingReadingsCount", "(Landroid/content/Context;I)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getPendingReadingsCount_Landroid_content_Context_I, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isEventUploaded_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubPreferences']/method[@name='isEventUploaded' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("isEventUploaded", "(Landroid/content/Context;Ljava/lang/String;)Z", "")]
		public static unsafe bool IsEventUploaded (global::Android.Content.Context p0, string p1)
		{
			if (id_isEventUploaded_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_isEventUploaded_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "isEventUploaded", "(Landroid/content/Context;Ljava/lang/String;)Z");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isEventUploaded_Landroid_content_Context_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_isHubStarted_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubPreferences']/method[@name='isHubStarted' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isHubStarted", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool IsHubStarted (global::Android.Content.Context p0)
		{
			if (id_isHubStarted_Landroid_content_Context_ == IntPtr.Zero)
				id_isHubStarted_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "isHubStarted", "(Landroid/content/Context;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isHubStarted_Landroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_setHubStartedState_Landroid_content_Context_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubPreferences']/method[@name='setHubStartedState' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='boolean']]"
		[Register ("setHubStartedState", "(Landroid/content/Context;Z)V", "")]
		public static unsafe void SetHubStartedState (global::Android.Content.Context p0, bool p1)
		{
			if (id_setHubStartedState_Landroid_content_Context_Z == IntPtr.Zero)
				id_setHubStartedState_Landroid_content_Context_Z = JNIEnv.GetStaticMethodID (class_ref, "setHubStartedState", "(Landroid/content/Context;Z)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setHubStartedState_Landroid_content_Context_Z, __args);
			} finally {
			}
		}

		static IntPtr id_setMcdId_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubPreferences']/method[@name='setMcdId' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("setMcdId", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static unsafe void SetMcdId (global::Android.Content.Context p0, string p1)
		{
			if (id_setMcdId_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_setMcdId_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "setMcdId", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setMcdId_Landroid_content_Context_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_setPendingReadingsCount_Landroid_content_Context_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubPreferences']/method[@name='setPendingReadingsCount' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("setPendingReadingsCount", "(Landroid/content/Context;I)V", "")]
		public static unsafe void SetPendingReadingsCount (global::Android.Content.Context p0, int p1)
		{
			if (id_setPendingReadingsCount_Landroid_content_Context_I == IntPtr.Zero)
				id_setPendingReadingsCount_Landroid_content_Context_I = JNIEnv.GetStaticMethodID (class_ref, "setPendingReadingsCount", "(Landroid/content/Context;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setPendingReadingsCount_Landroid_content_Context_I, __args);
			} finally {
			}
		}

	}
}
