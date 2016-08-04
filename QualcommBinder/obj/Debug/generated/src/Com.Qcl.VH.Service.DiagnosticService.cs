using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.Service {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='DiagnosticService']"
	[global::Android.Runtime.Register ("com/qcl/vh/service/DiagnosticService", DoNotGenerateAcw=true)]
	public partial class DiagnosticService : global::Android.App.Service {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='DiagnosticService']/field[@name='ACTION_DIAGNOSTIC_REQUEST']"
		[Register ("ACTION_DIAGNOSTIC_REQUEST")]
		public const string ActionDiagnosticRequest = (string) "com.qcl.hub.diagnostic.ACTION_DIAGNOSTIC_REQUEST";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='DiagnosticService']/field[@name='ACTION_INIT']"
		[Register ("ACTION_INIT")]
		public const string ActionInit = (string) "com.qcl.hub.diagnostic.ACTION_INIT";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='DiagnosticService']/field[@name='EXTRA_DIAGNOSTIC_REQUEST_DESCRIPTION']"
		[Register ("EXTRA_DIAGNOSTIC_REQUEST_DESCRIPTION")]
		public const string ExtraDiagnosticRequestDescription = (string) "com.qcl.hub.diagnostic.EVENT_DESC";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='DiagnosticService']/field[@name='EXTRA_DIAGNOSTIC_REQUEST_EVENT_TYPE']"
		[Register ("EXTRA_DIAGNOSTIC_REQUEST_EVENT_TYPE")]
		public const string ExtraDiagnosticRequestEventType = (string) "com.qcl.hub.diagnostic.EVENT_TYPE";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='DiagnosticService']/field[@name='EXTRA_DIAGNOSTIC_REQUEST_EVENT_UPLOAD_MESSAGE_ID']"
		[Register ("EXTRA_DIAGNOSTIC_REQUEST_EVENT_UPLOAD_MESSAGE_ID")]
		public const string ExtraDiagnosticRequestEventUploadMessageId = (string) "com.qcl.hub.diagnostic.UPLOAD_MESSAGE_ID";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='DiagnosticService']/field[@name='EXTRA_DIAGNOSTIC_REQUEST_LOG_END_DATE']"
		[Register ("EXTRA_DIAGNOSTIC_REQUEST_LOG_END_DATE")]
		public const string ExtraDiagnosticRequestLogEndDate = (string) "com.qcl.hub.diagnostic.LOG_END_DATE";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='DiagnosticService']/field[@name='EXTRA_DIAGNOSTIC_REQUEST_LOG_START_DATE']"
		[Register ("EXTRA_DIAGNOSTIC_REQUEST_LOG_START_DATE")]
		public const string ExtraDiagnosticRequestLogStartDate = (string) "com.qcl.hub.diagnostic.LOG_START_DATE";
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.qcl.vh.service']/interface[@name='DiagnosticService.LogInfoProvider']"
		[Register ("com/qcl/vh/service/DiagnosticService$LogInfoProvider", "", "Com.Qcl.VH.Service.DiagnosticService/ILogInfoProviderInvoker")]
		public partial interface ILogInfoProvider : IJavaObject {

			global::System.Collections.Generic.IList<global::Com.Qcl.VH.Service.DiagnosticService.LogMetadataEntry> LogMetadata {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.service']/interface[@name='DiagnosticService.LogInfoProvider']/method[@name='getLogMetadata' and count(parameter)=0]"
				[Register ("getLogMetadata", "()Ljava/util/ArrayList;", "GetGetLogMetadataHandler:Com.Qcl.VH.Service.DiagnosticService/ILogInfoProviderInvoker, QualcommBinder")] get;
			}

			string LogTimestampFormat {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.service']/interface[@name='DiagnosticService.LogInfoProvider']/method[@name='getLogTimestampFormat' and count(parameter)=0]"
				[Register ("getLogTimestampFormat", "()Ljava/lang/String;", "GetGetLogTimestampFormatHandler:Com.Qcl.VH.Service.DiagnosticService/ILogInfoProviderInvoker, QualcommBinder")] get;
			}

		}

		[global::Android.Runtime.Register ("com/qcl/vh/service/DiagnosticService$LogInfoProvider", DoNotGenerateAcw=true)]
		internal class ILogInfoProviderInvoker : global::Java.Lang.Object, ILogInfoProvider {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/qcl/vh/service/DiagnosticService$LogInfoProvider");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ILogInfoProviderInvoker); }
			}

			IntPtr class_ref;

			public static ILogInfoProvider GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ILogInfoProvider> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.qcl.vh.service.DiagnosticService.LogInfoProvider"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ILogInfoProviderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_getLogMetadata;
#pragma warning disable 0169
			static Delegate GetGetLogMetadataHandler ()
			{
				if (cb_getLogMetadata == null)
					cb_getLogMetadata = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLogMetadata);
				return cb_getLogMetadata;
			}

			static IntPtr n_GetLogMetadata (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Qcl.VH.Service.DiagnosticService.ILogInfoProvider __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Service.DiagnosticService.ILogInfoProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return global::Android.Runtime.JavaList<global::Com.Qcl.VH.Service.DiagnosticService.LogMetadataEntry>.ToLocalJniHandle (__this.LogMetadata);
			}
#pragma warning restore 0169

			IntPtr id_getLogMetadata;
			public unsafe global::System.Collections.Generic.IList<global::Com.Qcl.VH.Service.DiagnosticService.LogMetadataEntry> LogMetadata {
				get {
					if (id_getLogMetadata == IntPtr.Zero)
						id_getLogMetadata = JNIEnv.GetMethodID (class_ref, "getLogMetadata", "()Ljava/util/ArrayList;");
					return global::Android.Runtime.JavaList<global::Com.Qcl.VH.Service.DiagnosticService.LogMetadataEntry>.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_getLogMetadata), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_getLogTimestampFormat;
#pragma warning disable 0169
			static Delegate GetGetLogTimestampFormatHandler ()
			{
				if (cb_getLogTimestampFormat == null)
					cb_getLogTimestampFormat = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLogTimestampFormat);
				return cb_getLogTimestampFormat;
			}

			static IntPtr n_GetLogTimestampFormat (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Qcl.VH.Service.DiagnosticService.ILogInfoProvider __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Service.DiagnosticService.ILogInfoProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.LogTimestampFormat);
			}
#pragma warning restore 0169

			IntPtr id_getLogTimestampFormat;
			public unsafe string LogTimestampFormat {
				get {
					if (id_getLogTimestampFormat == IntPtr.Zero)
						id_getLogTimestampFormat = JNIEnv.GetMethodID (class_ref, "getLogTimestampFormat", "()Ljava/lang/String;");
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getLogTimestampFormat), JniHandleOwnership.TransferLocalRef);
				}
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='DiagnosticService.LogMetadataEntry']"
		[global::Android.Runtime.Register ("com/qcl/vh/service/DiagnosticService$LogMetadataEntry", DoNotGenerateAcw=true)]
		public partial class LogMetadataEntry : global::Java.Lang.Object, global::Java.Lang.IComparable {

			// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='DiagnosticService.LogMetadataEntry.LOG_TYPE']"
			[global::Android.Runtime.Register ("com/qcl/vh/service/DiagnosticService$LogMetadataEntry$LOG_TYPE", DoNotGenerateAcw=true)]
			public sealed partial class LOG_TYPE : global::Java.Lang.Enum {


				static IntPtr APP_ONLY_jfieldId;

				// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='DiagnosticService.LogMetadataEntry.LOG_TYPE']/field[@name='APP_ONLY']"
				[Register ("APP_ONLY")]
				public static global::Com.Qcl.VH.Service.DiagnosticService.LogMetadataEntry.LOG_TYPE AppOnly {
					get {
						if (APP_ONLY_jfieldId == IntPtr.Zero)
							APP_ONLY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "APP_ONLY", "Lcom/qcl/vh/service/DiagnosticService$LogMetadataEntry$LOG_TYPE;");
						IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, APP_ONLY_jfieldId);
						return global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Service.DiagnosticService.LogMetadataEntry.LOG_TYPE> (__ret, JniHandleOwnership.TransferLocalRef);
					}
				}

				static IntPtr EVENT_jfieldId;

				// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='DiagnosticService.LogMetadataEntry.LOG_TYPE']/field[@name='EVENT']"
				[Register ("EVENT")]
				public static global::Com.Qcl.VH.Service.DiagnosticService.LogMetadataEntry.LOG_TYPE Event {
					get {
						if (EVENT_jfieldId == IntPtr.Zero)
							EVENT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EVENT", "Lcom/qcl/vh/service/DiagnosticService$LogMetadataEntry$LOG_TYPE;");
						IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EVENT_jfieldId);
						return global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Service.DiagnosticService.LogMetadataEntry.LOG_TYPE> (__ret, JniHandleOwnership.TransferLocalRef);
					}
				}

				static IntPtr MAIN_jfieldId;

				// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='DiagnosticService.LogMetadataEntry.LOG_TYPE']/field[@name='MAIN']"
				[Register ("MAIN")]
				public static global::Com.Qcl.VH.Service.DiagnosticService.LogMetadataEntry.LOG_TYPE Main {
					get {
						if (MAIN_jfieldId == IntPtr.Zero)
							MAIN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MAIN", "Lcom/qcl/vh/service/DiagnosticService$LogMetadataEntry$LOG_TYPE;");
						IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MAIN_jfieldId);
						return global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Service.DiagnosticService.LogMetadataEntry.LOG_TYPE> (__ret, JniHandleOwnership.TransferLocalRef);
					}
				}

				static IntPtr RADIO_jfieldId;

				// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='DiagnosticService.LogMetadataEntry.LOG_TYPE']/field[@name='RADIO']"
				[Register ("RADIO")]
				public static global::Com.Qcl.VH.Service.DiagnosticService.LogMetadataEntry.LOG_TYPE Radio {
					get {
						if (RADIO_jfieldId == IntPtr.Zero)
							RADIO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RADIO", "Lcom/qcl/vh/service/DiagnosticService$LogMetadataEntry$LOG_TYPE;");
						IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RADIO_jfieldId);
						return global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Service.DiagnosticService.LogMetadataEntry.LOG_TYPE> (__ret, JniHandleOwnership.TransferLocalRef);
					}
				}
				internal static IntPtr java_class_handle;
				internal static IntPtr class_ref {
					get {
						return JNIEnv.FindClass ("com/qcl/vh/service/DiagnosticService$LogMetadataEntry$LOG_TYPE", ref java_class_handle);
					}
				}

				protected override IntPtr ThresholdClass {
					get { return class_ref; }
				}

				protected override global::System.Type ThresholdType {
					get { return typeof (LOG_TYPE); }
				}

				internal LOG_TYPE (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

				static IntPtr id_valueOf_Ljava_lang_String_;
				// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='DiagnosticService.LogMetadataEntry.LOG_TYPE']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("valueOf", "(Ljava/lang/String;)Lcom/qcl/vh/service/DiagnosticService$LogMetadataEntry$LOG_TYPE;", "")]
				public static unsafe global::Com.Qcl.VH.Service.DiagnosticService.LogMetadataEntry.LOG_TYPE ValueOf (string p0)
				{
					if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
						id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/qcl/vh/service/DiagnosticService$LogMetadataEntry$LOG_TYPE;");
					IntPtr native_p0 = JNIEnv.NewString (p0);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_p0);
						global::Com.Qcl.VH.Service.DiagnosticService.LogMetadataEntry.LOG_TYPE __ret = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Service.DiagnosticService.LogMetadataEntry.LOG_TYPE> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
						return __ret;
					} finally {
						JNIEnv.DeleteLocalRef (native_p0);
					}
				}

				static IntPtr id_values;
				// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='DiagnosticService.LogMetadataEntry.LOG_TYPE']/method[@name='values' and count(parameter)=0]"
				[Register ("values", "()[Lcom/qcl/vh/service/DiagnosticService$LogMetadataEntry$LOG_TYPE;", "")]
				public static unsafe global::Com.Qcl.VH.Service.DiagnosticService.LogMetadataEntry.LOG_TYPE[] Values ()
				{
					if (id_values == IntPtr.Zero)
						id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/qcl/vh/service/DiagnosticService$LogMetadataEntry$LOG_TYPE;");
					try {
						return (global::Com.Qcl.VH.Service.DiagnosticService.LogMetadataEntry.LOG_TYPE[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Qcl.VH.Service.DiagnosticService.LogMetadataEntry.LOG_TYPE));
					} finally {
					}
				}

			}

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/qcl/vh/service/DiagnosticService$LogMetadataEntry", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (LogMetadataEntry); }
			}

			protected LogMetadataEntry (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='DiagnosticService.LogMetadataEntry']/constructor[@name='DiagnosticService.LogMetadataEntry' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe LogMetadataEntry ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (LogMetadataEntry)) {
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

			static Delegate cb_isCurrentLogFile;
#pragma warning disable 0169
			static Delegate GetIsCurrentLogFileHandler ()
			{
				if (cb_isCurrentLogFile == null)
					cb_isCurrentLogFile = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsCurrentLogFile);
				return cb_isCurrentLogFile;
			}

			static bool n_IsCurrentLogFile (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Qcl.VH.Service.DiagnosticService.LogMetadataEntry __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Service.DiagnosticService.LogMetadataEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.CurrentLogFile;
			}
#pragma warning restore 0169

			static Delegate cb_setCurrentLogFile_Z;
#pragma warning disable 0169
			static Delegate GetSetCurrentLogFile_ZHandler ()
			{
				if (cb_setCurrentLogFile_Z == null)
					cb_setCurrentLogFile_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetCurrentLogFile_Z);
				return cb_setCurrentLogFile_Z;
			}

			static void n_SetCurrentLogFile_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Com.Qcl.VH.Service.DiagnosticService.LogMetadataEntry __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Service.DiagnosticService.LogMetadataEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.CurrentLogFile = p0;
			}
#pragma warning restore 0169

			static IntPtr id_isCurrentLogFile;
			static IntPtr id_setCurrentLogFile_Z;
			public virtual unsafe bool CurrentLogFile {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='DiagnosticService.LogMetadataEntry']/method[@name='isCurrentLogFile' and count(parameter)=0]"
				[Register ("isCurrentLogFile", "()Z", "GetIsCurrentLogFileHandler")]
				get {
					if (id_isCurrentLogFile == IntPtr.Zero)
						id_isCurrentLogFile = JNIEnv.GetMethodID (class_ref, "isCurrentLogFile", "()Z");
					try {

						if (GetType () == ThresholdType)
							return JNIEnv.CallBooleanMethod  (Handle, id_isCurrentLogFile);
						else
							return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isCurrentLogFile", "()Z"));
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='DiagnosticService.LogMetadataEntry']/method[@name='setCurrentLogFile' and count(parameter)=1 and parameter[1][@type='boolean']]"
				[Register ("setCurrentLogFile", "(Z)V", "GetSetCurrentLogFile_ZHandler")]
				set {
					if (id_setCurrentLogFile_Z == IntPtr.Zero)
						id_setCurrentLogFile_Z = JNIEnv.GetMethodID (class_ref, "setCurrentLogFile", "(Z)V");
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (value);

						if (GetType () == ThresholdType)
							JNIEnv.CallVoidMethod  (Handle, id_setCurrentLogFile_Z, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCurrentLogFile", "(Z)V"), __args);
					} finally {
					}
				}
			}

			static Delegate cb_getEndDate;
#pragma warning disable 0169
			static Delegate GetGetEndDateHandler ()
			{
				if (cb_getEndDate == null)
					cb_getEndDate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetEndDate);
				return cb_getEndDate;
			}

			static long n_GetEndDate (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Qcl.VH.Service.DiagnosticService.LogMetadataEntry __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Service.DiagnosticService.LogMetadataEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.EndDate;
			}
#pragma warning restore 0169

			static Delegate cb_setEndDate_J;
#pragma warning disable 0169
			static Delegate GetSetEndDate_JHandler ()
			{
				if (cb_setEndDate_J == null)
					cb_setEndDate_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetEndDate_J);
				return cb_setEndDate_J;
			}

			static void n_SetEndDate_J (IntPtr jnienv, IntPtr native__this, long p0)
			{
				global::Com.Qcl.VH.Service.DiagnosticService.LogMetadataEntry __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Service.DiagnosticService.LogMetadataEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.EndDate = p0;
			}
#pragma warning restore 0169

			static IntPtr id_getEndDate;
			static IntPtr id_setEndDate_J;
			public virtual unsafe long EndDate {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='DiagnosticService.LogMetadataEntry']/method[@name='getEndDate' and count(parameter)=0]"
				[Register ("getEndDate", "()J", "GetGetEndDateHandler")]
				get {
					if (id_getEndDate == IntPtr.Zero)
						id_getEndDate = JNIEnv.GetMethodID (class_ref, "getEndDate", "()J");
					try {

						if (GetType () == ThresholdType)
							return JNIEnv.CallLongMethod  (Handle, id_getEndDate);
						else
							return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEndDate", "()J"));
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='DiagnosticService.LogMetadataEntry']/method[@name='setEndDate' and count(parameter)=1 and parameter[1][@type='long']]"
				[Register ("setEndDate", "(J)V", "GetSetEndDate_JHandler")]
				set {
					if (id_setEndDate_J == IntPtr.Zero)
						id_setEndDate_J = JNIEnv.GetMethodID (class_ref, "setEndDate", "(J)V");
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (value);

						if (GetType () == ThresholdType)
							JNIEnv.CallVoidMethod  (Handle, id_setEndDate_J, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEndDate", "(J)V"), __args);
					} finally {
					}
				}
			}

			static Delegate cb_getLogFilename;
#pragma warning disable 0169
			static Delegate GetGetLogFilenameHandler ()
			{
				if (cb_getLogFilename == null)
					cb_getLogFilename = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLogFilename);
				return cb_getLogFilename;
			}

			static IntPtr n_GetLogFilename (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Qcl.VH.Service.DiagnosticService.LogMetadataEntry __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Service.DiagnosticService.LogMetadataEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.LogFilename);
			}
#pragma warning restore 0169

			static Delegate cb_setLogFilename_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetLogFilename_Ljava_lang_String_Handler ()
			{
				if (cb_setLogFilename_Ljava_lang_String_ == null)
					cb_setLogFilename_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLogFilename_Ljava_lang_String_);
				return cb_setLogFilename_Ljava_lang_String_;
			}

			static void n_SetLogFilename_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Qcl.VH.Service.DiagnosticService.LogMetadataEntry __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Service.DiagnosticService.LogMetadataEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.LogFilename = p0;
			}
#pragma warning restore 0169

			static IntPtr id_getLogFilename;
			static IntPtr id_setLogFilename_Ljava_lang_String_;
			public virtual unsafe string LogFilename {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='DiagnosticService.LogMetadataEntry']/method[@name='getLogFilename' and count(parameter)=0]"
				[Register ("getLogFilename", "()Ljava/lang/String;", "GetGetLogFilenameHandler")]
				get {
					if (id_getLogFilename == IntPtr.Zero)
						id_getLogFilename = JNIEnv.GetMethodID (class_ref, "getLogFilename", "()Ljava/lang/String;");
					try {

						if (GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getLogFilename), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLogFilename", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='DiagnosticService.LogMetadataEntry']/method[@name='setLogFilename' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setLogFilename", "(Ljava/lang/String;)V", "GetSetLogFilename_Ljava_lang_String_Handler")]
				set {
					if (id_setLogFilename_Ljava_lang_String_ == IntPtr.Zero)
						id_setLogFilename_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setLogFilename", "(Ljava/lang/String;)V");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_value);

						if (GetType () == ThresholdType)
							JNIEnv.CallVoidMethod  (Handle, id_setLogFilename_Ljava_lang_String_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLogFilename", "(Ljava/lang/String;)V"), __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static Delegate cb_getLogType;
#pragma warning disable 0169
			static Delegate GetGetLogTypeHandler ()
			{
				if (cb_getLogType == null)
					cb_getLogType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLogType);
				return cb_getLogType;
			}

			static IntPtr n_GetLogType (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Qcl.VH.Service.DiagnosticService.LogMetadataEntry __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Service.DiagnosticService.LogMetadataEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.LogType);
			}
#pragma warning restore 0169

			static Delegate cb_setLogType_Lcom_qcl_vh_service_DiagnosticService_LogMetadataEntry_LOG_TYPE_;
#pragma warning disable 0169
			static Delegate GetSetLogType_Lcom_qcl_vh_service_DiagnosticService_LogMetadataEntry_LOG_TYPE_Handler ()
			{
				if (cb_setLogType_Lcom_qcl_vh_service_DiagnosticService_LogMetadataEntry_LOG_TYPE_ == null)
					cb_setLogType_Lcom_qcl_vh_service_DiagnosticService_LogMetadataEntry_LOG_TYPE_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLogType_Lcom_qcl_vh_service_DiagnosticService_LogMetadataEntry_LOG_TYPE_);
				return cb_setLogType_Lcom_qcl_vh_service_DiagnosticService_LogMetadataEntry_LOG_TYPE_;
			}

			static void n_SetLogType_Lcom_qcl_vh_service_DiagnosticService_LogMetadataEntry_LOG_TYPE_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Qcl.VH.Service.DiagnosticService.LogMetadataEntry __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Service.DiagnosticService.LogMetadataEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Qcl.VH.Service.DiagnosticService.LogMetadataEntry.LOG_TYPE p0 = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Service.DiagnosticService.LogMetadataEntry.LOG_TYPE> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.LogType = p0;
			}
#pragma warning restore 0169

			static IntPtr id_getLogType;
			static IntPtr id_setLogType_Lcom_qcl_vh_service_DiagnosticService_LogMetadataEntry_LOG_TYPE_;
			public virtual unsafe global::Com.Qcl.VH.Service.DiagnosticService.LogMetadataEntry.LOG_TYPE LogType {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='DiagnosticService.LogMetadataEntry']/method[@name='getLogType' and count(parameter)=0]"
				[Register ("getLogType", "()Lcom/qcl/vh/service/DiagnosticService$LogMetadataEntry$LOG_TYPE;", "GetGetLogTypeHandler")]
				get {
					if (id_getLogType == IntPtr.Zero)
						id_getLogType = JNIEnv.GetMethodID (class_ref, "getLogType", "()Lcom/qcl/vh/service/DiagnosticService$LogMetadataEntry$LOG_TYPE;");
					try {

						if (GetType () == ThresholdType)
							return global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Service.DiagnosticService.LogMetadataEntry.LOG_TYPE> (JNIEnv.CallObjectMethod  (Handle, id_getLogType), JniHandleOwnership.TransferLocalRef);
						else
							return global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Service.DiagnosticService.LogMetadataEntry.LOG_TYPE> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLogType", "()Lcom/qcl/vh/service/DiagnosticService$LogMetadataEntry$LOG_TYPE;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='DiagnosticService.LogMetadataEntry']/method[@name='setLogType' and count(parameter)=1 and parameter[1][@type='com.qcl.vh.service.DiagnosticService.LogMetadataEntry.LOG_TYPE']]"
				[Register ("setLogType", "(Lcom/qcl/vh/service/DiagnosticService$LogMetadataEntry$LOG_TYPE;)V", "GetSetLogType_Lcom_qcl_vh_service_DiagnosticService_LogMetadataEntry_LOG_TYPE_Handler")]
				set {
					if (id_setLogType_Lcom_qcl_vh_service_DiagnosticService_LogMetadataEntry_LOG_TYPE_ == IntPtr.Zero)
						id_setLogType_Lcom_qcl_vh_service_DiagnosticService_LogMetadataEntry_LOG_TYPE_ = JNIEnv.GetMethodID (class_ref, "setLogType", "(Lcom/qcl/vh/service/DiagnosticService$LogMetadataEntry$LOG_TYPE;)V");
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (value);

						if (GetType () == ThresholdType)
							JNIEnv.CallVoidMethod  (Handle, id_setLogType_Lcom_qcl_vh_service_DiagnosticService_LogMetadataEntry_LOG_TYPE_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLogType", "(Lcom/qcl/vh/service/DiagnosticService$LogMetadataEntry$LOG_TYPE;)V"), __args);
					} finally {
					}
				}
			}

			static Delegate cb_compareTo_Lcom_qcl_vh_service_DiagnosticService_LogMetadataEntry_;
#pragma warning disable 0169
			static Delegate GetCompareTo_Lcom_qcl_vh_service_DiagnosticService_LogMetadataEntry_Handler ()
			{
				if (cb_compareTo_Lcom_qcl_vh_service_DiagnosticService_LogMetadataEntry_ == null)
					cb_compareTo_Lcom_qcl_vh_service_DiagnosticService_LogMetadataEntry_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_CompareTo_Lcom_qcl_vh_service_DiagnosticService_LogMetadataEntry_);
				return cb_compareTo_Lcom_qcl_vh_service_DiagnosticService_LogMetadataEntry_;
			}

			static int n_CompareTo_Lcom_qcl_vh_service_DiagnosticService_LogMetadataEntry_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Qcl.VH.Service.DiagnosticService.LogMetadataEntry __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Service.DiagnosticService.LogMetadataEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Qcl.VH.Service.DiagnosticService.LogMetadataEntry p0 = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Service.DiagnosticService.LogMetadataEntry> (native_p0, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.CompareTo (p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_compareTo_Lcom_qcl_vh_service_DiagnosticService_LogMetadataEntry_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='DiagnosticService.LogMetadataEntry']/method[@name='compareTo' and count(parameter)=1 and parameter[1][@type='com.qcl.vh.service.DiagnosticService.LogMetadataEntry']]"
			[Register ("compareTo", "(Lcom/qcl/vh/service/DiagnosticService$LogMetadataEntry;)I", "GetCompareTo_Lcom_qcl_vh_service_DiagnosticService_LogMetadataEntry_Handler")]
			public virtual unsafe int CompareTo (global::Com.Qcl.VH.Service.DiagnosticService.LogMetadataEntry p0)
			{
				if (id_compareTo_Lcom_qcl_vh_service_DiagnosticService_LogMetadataEntry_ == IntPtr.Zero)
					id_compareTo_Lcom_qcl_vh_service_DiagnosticService_LogMetadataEntry_ = JNIEnv.GetMethodID (class_ref, "compareTo", "(Lcom/qcl/vh/service/DiagnosticService$LogMetadataEntry;)I");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					int __ret;
					if (GetType () == ThresholdType)
						__ret = JNIEnv.CallIntMethod  (Handle, id_compareTo_Lcom_qcl_vh_service_DiagnosticService_LogMetadataEntry_, __args);
					else
						__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "compareTo", "(Lcom/qcl/vh/service/DiagnosticService$LogMetadataEntry;)I"), __args);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_getmStartDate;
#pragma warning disable 0169
			static Delegate GetGetmStartDateHandler ()
			{
				if (cb_getmStartDate == null)
					cb_getmStartDate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetmStartDate);
				return cb_getmStartDate;
			}

			static long n_GetmStartDate (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Qcl.VH.Service.DiagnosticService.LogMetadataEntry __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Service.DiagnosticService.LogMetadataEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.GetmStartDate ();
			}
#pragma warning restore 0169

			static IntPtr id_getmStartDate;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='DiagnosticService.LogMetadataEntry']/method[@name='getmStartDate' and count(parameter)=0]"
			[Register ("getmStartDate", "()J", "GetGetmStartDateHandler")]
			public virtual unsafe long GetmStartDate ()
			{
				if (id_getmStartDate == IntPtr.Zero)
					id_getmStartDate = JNIEnv.GetMethodID (class_ref, "getmStartDate", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod  (Handle, id_getmStartDate);
					else
						return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getmStartDate", "()J"));
				} finally {
				}
			}

			static Delegate cb_setStartDate_J;
#pragma warning disable 0169
			static Delegate GetSetStartDate_JHandler ()
			{
				if (cb_setStartDate_J == null)
					cb_setStartDate_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetStartDate_J);
				return cb_setStartDate_J;
			}

			static void n_SetStartDate_J (IntPtr jnienv, IntPtr native__this, long p0)
			{
				global::Com.Qcl.VH.Service.DiagnosticService.LogMetadataEntry __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Service.DiagnosticService.LogMetadataEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.SetStartDate (p0);
			}
#pragma warning restore 0169

			static IntPtr id_setStartDate_J;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='DiagnosticService.LogMetadataEntry']/method[@name='setStartDate' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setStartDate", "(J)V", "GetSetStartDate_JHandler")]
			public virtual unsafe void SetStartDate (long p0)
			{
				if (id_setStartDate_J == IntPtr.Zero)
					id_setStartDate_J = JNIEnv.GetMethodID (class_ref, "setStartDate", "(J)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setStartDate_J, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStartDate", "(J)V"), __args);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qcl/vh/service/DiagnosticService", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DiagnosticService); }
		}

		protected DiagnosticService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='DiagnosticService']/constructor[@name='DiagnosticService' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DiagnosticService ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (DiagnosticService)) {
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

		static IntPtr id_addDiagnosticRequest_Landroid_content_Context_Lcom_qcl_vh_content_a_櫯_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='DiagnosticService']/method[@name='addDiagnosticRequest' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.qcl.vh.content.a.櫯'] and parameter[3][@type='java.lang.String']]"
		[Register ("addDiagnosticRequest", "(Landroid/content/Context;Lcom/qcl/vh/content/a/櫯;Ljava/lang/String;)V", "")]
		public static unsafe void AddDiagnosticRequest (global::Android.Content.Context p0, global::Com.Qcl.VH.Content.A.櫯 p1, string p2)
		{
			if (id_addDiagnosticRequest_Landroid_content_Context_Lcom_qcl_vh_content_a_櫯_Ljava_lang_String_ == IntPtr.Zero)
				id_addDiagnosticRequest_Landroid_content_Context_Lcom_qcl_vh_content_a_櫯_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "addDiagnosticRequest", "(Landroid/content/Context;Lcom/qcl/vh/content/a/櫯;Ljava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_addDiagnosticRequest_Landroid_content_Context_Lcom_qcl_vh_content_a_櫯_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_addDiagnosticRequest_Landroid_content_Context_Lcom_qcl_vh_content_a_櫯_Ljava_lang_String_JJI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='DiagnosticService']/method[@name='addDiagnosticRequest' and count(parameter)=6 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.qcl.vh.content.a.櫯'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='long'] and parameter[5][@type='long'] and parameter[6][@type='int']]"
		[Register ("addDiagnosticRequest", "(Landroid/content/Context;Lcom/qcl/vh/content/a/櫯;Ljava/lang/String;JJI)V", "")]
		public static unsafe void AddDiagnosticRequest (global::Android.Content.Context p0, global::Com.Qcl.VH.Content.A.櫯 p1, string p2, long p3, long p4, int p5)
		{
			if (id_addDiagnosticRequest_Landroid_content_Context_Lcom_qcl_vh_content_a_櫯_Ljava_lang_String_JJI == IntPtr.Zero)
				id_addDiagnosticRequest_Landroid_content_Context_Lcom_qcl_vh_content_a_櫯_Ljava_lang_String_JJI = JNIEnv.GetStaticMethodID (class_ref, "addDiagnosticRequest", "(Landroid/content/Context;Lcom/qcl/vh/content/a/櫯;Ljava/lang/String;JJI)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_addDiagnosticRequest_Landroid_content_Context_Lcom_qcl_vh_content_a_櫯_Ljava_lang_String_JJI, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_getAllLogs;
#pragma warning disable 0169
		static Delegate GetGetAllLogsHandler ()
		{
			if (cb_getAllLogs == null)
				cb_getAllLogs = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAllLogs);
			return cb_getAllLogs;
		}

		static IntPtr n_GetAllLogs (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Qcl.VH.Service.DiagnosticService __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Service.DiagnosticService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetAllLogs ());
		}
#pragma warning restore 0169

		static IntPtr id_getAllLogs;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='DiagnosticService']/method[@name='getAllLogs' and count(parameter)=0]"
		[Register ("getAllLogs", "()[B", "GetGetAllLogsHandler")]
		public virtual unsafe byte[] GetAllLogs ()
		{
			if (id_getAllLogs == IntPtr.Zero)
				id_getAllLogs = JNIEnv.GetMethodID (class_ref, "getAllLogs", "()[B");
			try {

				if (GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getAllLogs), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAllLogs", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_getLogSnippet_JI;
#pragma warning disable 0169
		static Delegate GetGetLogSnippet_JIHandler ()
		{
			if (cb_getLogSnippet_JI == null)
				cb_getLogSnippet_JI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, int, IntPtr>) n_GetLogSnippet_JI);
			return cb_getLogSnippet_JI;
		}

		static IntPtr n_GetLogSnippet_JI (IntPtr jnienv, IntPtr native__this, long p0, int p1)
		{
			global::Com.Qcl.VH.Service.DiagnosticService __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Service.DiagnosticService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetLogSnippet (p0, p1));
		}
#pragma warning restore 0169

		static IntPtr id_getLogSnippet_JI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='DiagnosticService']/method[@name='getLogSnippet' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='int']]"
		[Register ("getLogSnippet", "(JI)[B", "GetGetLogSnippet_JIHandler")]
		public virtual unsafe byte[] GetLogSnippet (long p0, int p1)
		{
			if (id_getLogSnippet_JI == IntPtr.Zero)
				id_getLogSnippet_JI = JNIEnv.GetMethodID (class_ref, "getLogSnippet", "(JI)[B");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getLogSnippet_JI, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLogSnippet", "(JI)[B"), __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_getLogSnippet_JJI;
#pragma warning disable 0169
		static Delegate GetGetLogSnippet_JJIHandler ()
		{
			if (cb_getLogSnippet_JJI == null)
				cb_getLogSnippet_JJI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, long, int, IntPtr>) n_GetLogSnippet_JJI);
			return cb_getLogSnippet_JJI;
		}

		static IntPtr n_GetLogSnippet_JJI (IntPtr jnienv, IntPtr native__this, long p0, long p1, int p2)
		{
			global::Com.Qcl.VH.Service.DiagnosticService __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Service.DiagnosticService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetLogSnippet (p0, p1, p2));
		}
#pragma warning restore 0169

		static IntPtr id_getLogSnippet_JJI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='DiagnosticService']/method[@name='getLogSnippet' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='int']]"
		[Register ("getLogSnippet", "(JJI)[B", "GetGetLogSnippet_JJIHandler")]
		public virtual unsafe byte[] GetLogSnippet (long p0, long p1, int p2)
		{
			if (id_getLogSnippet_JJI == IntPtr.Zero)
				id_getLogSnippet_JJI = JNIEnv.GetMethodID (class_ref, "getLogSnippet", "(JJI)[B");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getLogSnippet_JJI, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLogSnippet", "(JJI)[B"), __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static IntPtr id_initialize_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='DiagnosticService']/method[@name='initialize' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("initialize", "(Landroid/content/Context;)V", "")]
		public static unsafe void Initialize (global::Android.Content.Context p0)
		{
			if (id_initialize_Landroid_content_Context_ == IntPtr.Zero)
				id_initialize_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "initialize", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_initialize_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static Delegate cb_insertDiagnosticRequest_Lcom_qcl_vh_content_a_櫯_Ljava_lang_String_JJI;
#pragma warning disable 0169
		static Delegate GetInsertDiagnosticRequest_Lcom_qcl_vh_content_a_櫯_Ljava_lang_String_JJIHandler ()
		{
			if (cb_insertDiagnosticRequest_Lcom_qcl_vh_content_a_櫯_Ljava_lang_String_JJI == null)
				cb_insertDiagnosticRequest_Lcom_qcl_vh_content_a_櫯_Ljava_lang_String_JJI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, long, long, int>) n_InsertDiagnosticRequest_Lcom_qcl_vh_content_a_櫯_Ljava_lang_String_JJI);
			return cb_insertDiagnosticRequest_Lcom_qcl_vh_content_a_櫯_Ljava_lang_String_JJI;
		}

		static void n_InsertDiagnosticRequest_Lcom_qcl_vh_content_a_櫯_Ljava_lang_String_JJI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, long p2, long p3, int p4)
		{
			global::Com.Qcl.VH.Service.DiagnosticService __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Service.DiagnosticService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Qcl.VH.Content.A.櫯 p0 = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.A.櫯> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.InsertDiagnosticRequest (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		static IntPtr id_insertDiagnosticRequest_Lcom_qcl_vh_content_a_櫯_Ljava_lang_String_JJI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='DiagnosticService']/method[@name='insertDiagnosticRequest' and count(parameter)=5 and parameter[1][@type='com.qcl.vh.content.a.櫯'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='long'] and parameter[4][@type='long'] and parameter[5][@type='int']]"
		[Register ("insertDiagnosticRequest", "(Lcom/qcl/vh/content/a/櫯;Ljava/lang/String;JJI)V", "GetInsertDiagnosticRequest_Lcom_qcl_vh_content_a_櫯_Ljava_lang_String_JJIHandler")]
		protected virtual unsafe void InsertDiagnosticRequest (global::Com.Qcl.VH.Content.A.櫯 p0, string p1, long p2, long p3, int p4)
		{
			if (id_insertDiagnosticRequest_Lcom_qcl_vh_content_a_櫯_Ljava_lang_String_JJI == IntPtr.Zero)
				id_insertDiagnosticRequest_Lcom_qcl_vh_content_a_櫯_Ljava_lang_String_JJI = JNIEnv.GetMethodID (class_ref, "insertDiagnosticRequest", "(Lcom/qcl/vh/content/a/櫯;Ljava/lang/String;JJI)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_insertDiagnosticRequest_Lcom_qcl_vh_content_a_櫯_Ljava_lang_String_JJI, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "insertDiagnosticRequest", "(Lcom/qcl/vh/content/a/櫯;Ljava/lang/String;JJI)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_notifyLogUpdated_Z;
#pragma warning disable 0169
		static Delegate GetNotifyLogUpdated_ZHandler ()
		{
			if (cb_notifyLogUpdated_Z == null)
				cb_notifyLogUpdated_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_NotifyLogUpdated_Z);
			return cb_notifyLogUpdated_Z;
		}

		static void n_NotifyLogUpdated_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Qcl.VH.Service.DiagnosticService __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Service.DiagnosticService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NotifyLogUpdated (p0);
		}
#pragma warning restore 0169

		static IntPtr id_notifyLogUpdated_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='DiagnosticService']/method[@name='notifyLogUpdated' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("notifyLogUpdated", "(Z)V", "GetNotifyLogUpdated_ZHandler")]
		public virtual unsafe void NotifyLogUpdated (bool p0)
		{
			if (id_notifyLogUpdated_Z == IntPtr.Zero)
				id_notifyLogUpdated_Z = JNIEnv.GetMethodID (class_ref, "notifyLogUpdated", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_notifyLogUpdated_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "notifyLogUpdated", "(Z)V"), __args);
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
			global::Com.Qcl.VH.Service.DiagnosticService __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Service.DiagnosticService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnBind (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onBind_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='DiagnosticService']/method[@name='onBind' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
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

		static Delegate cb_refreshLogMetadaCache;
#pragma warning disable 0169
		static Delegate GetRefreshLogMetadaCacheHandler ()
		{
			if (cb_refreshLogMetadaCache == null)
				cb_refreshLogMetadaCache = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RefreshLogMetadaCache);
			return cb_refreshLogMetadaCache;
		}

		static void n_RefreshLogMetadaCache (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Qcl.VH.Service.DiagnosticService __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Service.DiagnosticService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RefreshLogMetadaCache ();
		}
#pragma warning restore 0169

		static IntPtr id_refreshLogMetadaCache;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='DiagnosticService']/method[@name='refreshLogMetadaCache' and count(parameter)=0]"
		[Register ("refreshLogMetadaCache", "()V", "GetRefreshLogMetadaCacheHandler")]
		public virtual unsafe void RefreshLogMetadaCache ()
		{
			if (id_refreshLogMetadaCache == IntPtr.Zero)
				id_refreshLogMetadaCache = JNIEnv.GetMethodID (class_ref, "refreshLogMetadaCache", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_refreshLogMetadaCache);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "refreshLogMetadaCache", "()V"));
			} finally {
			}
		}

		static Delegate cb_startDbDataLoader;
#pragma warning disable 0169
		static Delegate GetStartDbDataLoaderHandler ()
		{
			if (cb_startDbDataLoader == null)
				cb_startDbDataLoader = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StartDbDataLoader);
			return cb_startDbDataLoader;
		}

		static void n_StartDbDataLoader (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Qcl.VH.Service.DiagnosticService __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Service.DiagnosticService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartDbDataLoader ();
		}
#pragma warning restore 0169

		static IntPtr id_startDbDataLoader;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='DiagnosticService']/method[@name='startDbDataLoader' and count(parameter)=0]"
		[Register ("startDbDataLoader", "()V", "GetStartDbDataLoaderHandler")]
		public virtual unsafe void StartDbDataLoader ()
		{
			if (id_startDbDataLoader == IntPtr.Zero)
				id_startDbDataLoader = JNIEnv.GetMethodID (class_ref, "startDbDataLoader", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_startDbDataLoader);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startDbDataLoader", "()V"));
			} finally {
			}
		}

	}
}
