using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.Usb {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.usb']/class[@name='UsbService']"
	[global::Android.Runtime.Register ("com/qcl/vh/usb/UsbService", DoNotGenerateAcw=true)]
	public partial class UsbService : global::Android.App.Service, global::Android.OS.Handler.ICallback {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.usb']/class[@name='UsbService']/field[@name='ADAPTER_READ_TIMEOUT_MIN']"
		[Register ("ADAPTER_READ_TIMEOUT_MIN")]
		protected const int AdapterReadTimeoutMin = (int) 15;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.usb']/class[@name='UsbService']/field[@name='DEVICE_READING_COMPLETED']"
		[Register ("DEVICE_READING_COMPLETED")]
		protected const int DeviceReadingCompleted = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.usb']/class[@name='UsbService']/field[@name='POLLING_INTERVAL_IN_SEC']"
		[Register ("POLLING_INTERVAL_IN_SEC")]
		protected const long PollingIntervalInSec = (long) 5L;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.usb']/class[@name='UsbService']/field[@name='TWONET_WILDCARD_SERIAL_NUMBER_PREFIX']"
		[Register ("TWONET_WILDCARD_SERIAL_NUMBER_PREFIX")]
		public const string TwonetWildcardSerialNumberPrefix = (string) "2netSN_";

		static IntPtr mContext_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.usb']/class[@name='UsbService']/field[@name='mContext']"
		[Register ("mContext")]
		protected global::Android.Content.Context MContext {
			get {
				if (mContext_jfieldId == IntPtr.Zero)
					mContext_jfieldId = JNIEnv.GetFieldID (class_ref, "mContext", "Landroid/content/Context;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mContext_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mContext_jfieldId == IntPtr.Zero)
					mContext_jfieldId = JNIEnv.GetFieldID (class_ref, "mContext", "Landroid/content/Context;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, mContext_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mExecutor_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.usb']/class[@name='UsbService']/field[@name='mExecutor']"
		[Register ("mExecutor")]
		protected global::Java.Util.Concurrent.ThreadPoolExecutor MExecutor {
			get {
				if (mExecutor_jfieldId == IntPtr.Zero)
					mExecutor_jfieldId = JNIEnv.GetFieldID (class_ref, "mExecutor", "Ljava/util/concurrent/ThreadPoolExecutor;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mExecutor_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.ThreadPoolExecutor> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mExecutor_jfieldId == IntPtr.Zero)
					mExecutor_jfieldId = JNIEnv.GetFieldID (class_ref, "mExecutor", "Ljava/util/concurrent/ThreadPoolExecutor;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, mExecutor_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mMainHandler_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.usb']/class[@name='UsbService']/field[@name='mMainHandler']"
		[Register ("mMainHandler")]
		protected global::Android.OS.Handler MMainHandler {
			get {
				if (mMainHandler_jfieldId == IntPtr.Zero)
					mMainHandler_jfieldId = JNIEnv.GetFieldID (class_ref, "mMainHandler", "Landroid/os/Handler;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mMainHandler_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mMainHandler_jfieldId == IntPtr.Zero)
					mMainHandler_jfieldId = JNIEnv.GetFieldID (class_ref, "mMainHandler", "Landroid/os/Handler;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, mMainHandler_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mUsbSessionsTable_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.usb']/class[@name='UsbService']/field[@name='mUsbSessionsTable']"
		[Register ("mUsbSessionsTable")]
		protected global::Java.Util.Hashtable MUsbSessionsTable {
			get {
				if (mUsbSessionsTable_jfieldId == IntPtr.Zero)
					mUsbSessionsTable_jfieldId = JNIEnv.GetFieldID (class_ref, "mUsbSessionsTable", "Ljava/util/Hashtable;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mUsbSessionsTable_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Hashtable> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mUsbSessionsTable_jfieldId == IntPtr.Zero)
					mUsbSessionsTable_jfieldId = JNIEnv.GetFieldID (class_ref, "mUsbSessionsTable", "Ljava/util/Hashtable;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, mUsbSessionsTable_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.usb']/class[@name='UsbService.If']"
		[global::Android.Runtime.Register ("com/qcl/vh/usb/UsbService$If", DoNotGenerateAcw=true)]
		public partial class If : global::Java.Lang.Object, global::Java.Util.Concurrent.IThreadFactory {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/qcl/vh/usb/UsbService$If", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (If); }
			}

			protected If (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_newThread_Ljava_lang_Runnable_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.usb']/class[@name='UsbService.If']/method[@name='newThread' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
			[Register ("newThread", "(Ljava/lang/Runnable;)Ljava/lang/Thread;", "")]
			public unsafe global::Java.Lang.Thread NewThread (global::Java.Lang.IRunnable p0)
			{
				if (id_newThread_Ljava_lang_Runnable_ == IntPtr.Zero)
					id_newThread_Ljava_lang_Runnable_ = JNIEnv.GetMethodID (class_ref, "newThread", "(Ljava/lang/Runnable;)Ljava/lang/Thread;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					global::Java.Lang.Thread __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Thread> (JNIEnv.CallObjectMethod  (Handle, id_newThread_Ljava_lang_Runnable_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.usb']/class[@name='UsbService.iF']"
		[global::Android.Runtime.Register ("com/qcl/vh/usb/UsbService$iF", DoNotGenerateAcw=true)]
		public partial class IF : global::Java.Lang.Thread, global::Com.Qcl.VH.Usb.IIf {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/qcl/vh/usb/UsbService$iF", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IF); }
			}

			protected IF (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_qcl_vh_usb_UsbService_Lcom_qcl_vh_content_MedicalDevice_Ljava_lang_String_Ljava_util_concurrent_CountDownLatch_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.usb']/class[@name='UsbService.iF']/constructor[@name='UsbService.iF' and count(parameter)=4 and parameter[1][@type='com.qcl.vh.usb.UsbService'] and parameter[2][@type='com.qcl.vh.content.MedicalDevice'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.util.concurrent.CountDownLatch']]"
			[Register (".ctor", "(Lcom/qcl/vh/usb/UsbService;Lcom/qcl/vh/content/MedicalDevice;Ljava/lang/String;Ljava/util/concurrent/CountDownLatch;)V", "")]
			public unsafe IF (global::Com.Qcl.VH.Usb.UsbService __self, global::Com.Qcl.VH.Content.MedicalDevice p1, string p2, global::Java.Util.Concurrent.CountDownLatch p3)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p2 = JNIEnv.NewString (p2);
				try {
					JValue* __args = stackalloc JValue [4];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (native_p2);
					__args [3] = new JValue (p3);
					if (GetType () != typeof (IF)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Lcom/qcl/vh/content/MedicalDevice;Ljava/lang/String;Ljava/util/concurrent/CountDownLatch;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Lcom/qcl/vh/content/MedicalDevice;Ljava/lang/String;Ljava/util/concurrent/CountDownLatch;)V", __args);
						return;
					}

					if (id_ctor_Lcom_qcl_vh_usb_UsbService_Lcom_qcl_vh_content_MedicalDevice_Ljava_lang_String_Ljava_util_concurrent_CountDownLatch_ == IntPtr.Zero)
						id_ctor_Lcom_qcl_vh_usb_UsbService_Lcom_qcl_vh_content_MedicalDevice_Ljava_lang_String_Ljava_util_concurrent_CountDownLatch_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/qcl/vh/usb/UsbService;Lcom/qcl/vh/content/MedicalDevice;Ljava/lang/String;Ljava/util/concurrent/CountDownLatch;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_qcl_vh_usb_UsbService_Lcom_qcl_vh_content_MedicalDevice_Ljava_lang_String_Ljava_util_concurrent_CountDownLatch_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_qcl_vh_usb_UsbService_Lcom_qcl_vh_content_MedicalDevice_Ljava_lang_String_Ljava_util_concurrent_CountDownLatch_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}

			static IntPtr id_run;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.usb']/class[@name='UsbService.iF']/method[@name='run' and count(parameter)=0]"
			[Register ("run", "()V", "")]
			public override sealed unsafe void Run ()
			{
				if (id_run == IntPtr.Zero)
					id_run = JNIEnv.GetMethodID (class_ref, "run", "()V");
				try {
					JNIEnv.CallVoidMethod  (Handle, id_run);
				} finally {
				}
			}

			static IntPtr id_鷭_Ljava_util_List_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.usb']/class[@name='UsbService.iF']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.qcl.vh.content.ˮ͈&gt;']]"
			[Register ("鷭", "(Ljava/util/List;)V", "")]
			public unsafe void 鷭 (global::System.Collections.Generic.IList<global::Com.Qcl.VH.Content.ˮ͈> p0)
			{
				if (id_鷭_Ljava_util_List_ == IntPtr.Zero)
					id_鷭_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "鷭", "(Ljava/util/List;)V");
				IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Qcl.VH.Content.ˮ͈>.ToLocalJniHandle (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					JNIEnv.CallVoidMethod  (Handle, id_鷭_Ljava_util_List_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.usb']/class[@name='UsbService.if']"
		[global::Android.Runtime.Register ("com/qcl/vh/usb/UsbService$if", DoNotGenerateAcw=true)]
		public partial class If : global::Android.Database.ContentObserver {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/qcl/vh/usb/UsbService$if", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (If); }
			}

			protected If (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_qcl_vh_usb_UsbService_Landroid_os_Handler_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.usb']/class[@name='UsbService.if']/constructor[@name='UsbService.if' and count(parameter)=2 and parameter[1][@type='com.qcl.vh.usb.UsbService'] and parameter[2][@type='android.os.Handler']]"
			[Register (".ctor", "(Lcom/qcl/vh/usb/UsbService;Landroid/os/Handler;)V", "")]
			public unsafe If (global::Com.Qcl.VH.Usb.UsbService __self, global::Android.OS.Handler p1)
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
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/os/Handler;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/os/Handler;)V", __args);
						return;
					}

					if (id_ctor_Lcom_qcl_vh_usb_UsbService_Landroid_os_Handler_ == IntPtr.Zero)
						id_ctor_Lcom_qcl_vh_usb_UsbService_Landroid_os_Handler_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/qcl/vh/usb/UsbService;Landroid/os/Handler;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_qcl_vh_usb_UsbService_Landroid_os_Handler_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_qcl_vh_usb_UsbService_Landroid_os_Handler_, __args);
				} finally {
				}
			}

			static IntPtr id_onChange_Z;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.usb']/class[@name='UsbService.if']/method[@name='onChange' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("onChange", "(Z)V", "")]
			public override sealed unsafe void OnChange (bool p0)
			{
				if (id_onChange_Z == IntPtr.Zero)
					id_onChange_Z = JNIEnv.GetMethodID (class_ref, "onChange", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					JNIEnv.CallVoidMethod  (Handle, id_onChange_Z, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.usb']/class[@name='UsbService.ˮ͈']"
		[global::Android.Runtime.Register ("com/qcl/vh/usb/UsbService$ˮ͈", DoNotGenerateAcw=true)]
		public partial class ˮ͈ : global::Java.Lang.Object {

			protected ˮ͈ (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.usb']/class[@name='UsbService.櫯']"
		[global::Android.Runtime.Register ("com/qcl/vh/usb/UsbService$櫯", DoNotGenerateAcw=true)]
		public partial class 櫯 : global::Java.Lang.Object, global::Java.Lang.IRunnable {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/qcl/vh/usb/UsbService$櫯", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (櫯); }
			}

			protected 櫯 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_qcl_vh_usb_UsbService_Landroid_content_Context_Landroid_hardware_usb_UsbDevice_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.usb']/class[@name='UsbService.櫯']/constructor[@name='UsbService.櫯' and count(parameter)=3 and parameter[1][@type='com.qcl.vh.usb.UsbService'] and parameter[2][@type='android.content.Context'] and parameter[3][@type='android.hardware.usb.UsbDevice']]"
			[Register (".ctor", "(Lcom/qcl/vh/usb/UsbService;Landroid/content/Context;Landroid/hardware/usb/UsbDevice;)V", "")]
			public unsafe 櫯 (global::Com.Qcl.VH.Usb.UsbService __self, global::Android.Content.Context p1, global::Android.Hardware.Usb.UsbDevice p2)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					if (GetType () != typeof (櫯)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/content/Context;Landroid/hardware/usb/UsbDevice;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/content/Context;Landroid/hardware/usb/UsbDevice;)V", __args);
						return;
					}

					if (id_ctor_Lcom_qcl_vh_usb_UsbService_Landroid_content_Context_Landroid_hardware_usb_UsbDevice_ == IntPtr.Zero)
						id_ctor_Lcom_qcl_vh_usb_UsbService_Landroid_content_Context_Landroid_hardware_usb_UsbDevice_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/qcl/vh/usb/UsbService;Landroid/content/Context;Landroid/hardware/usb/UsbDevice;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_qcl_vh_usb_UsbService_Landroid_content_Context_Landroid_hardware_usb_UsbDevice_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_qcl_vh_usb_UsbService_Landroid_content_Context_Landroid_hardware_usb_UsbDevice_, __args);
				} finally {
				}
			}

			static IntPtr id_run;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.usb']/class[@name='UsbService.櫯']/method[@name='run' and count(parameter)=0]"
			[Register ("run", "()V", "")]
			public unsafe void Run ()
			{
				if (id_run == IntPtr.Zero)
					id_run = JNIEnv.GetMethodID (class_ref, "run", "()V");
				try {
					JNIEnv.CallVoidMethod  (Handle, id_run);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.usb']/class[@name='UsbService.鷭']"
		[global::Android.Runtime.Register ("com/qcl/vh/usb/UsbService$鷭", DoNotGenerateAcw=true)]
		public partial class 鷭 : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/qcl/vh/usb/UsbService$鷭", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (鷭); }
			}

			protected 鷭 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_qcl_vh_usb_UsbService_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.usb']/class[@name='UsbService.鷭']/constructor[@name='UsbService.鷭' and count(parameter)=1 and parameter[1][@type='com.qcl.vh.usb.UsbService']]"
			[Register (".ctor", "(Lcom/qcl/vh/usb/UsbService;)V", "")]
			protected unsafe 鷭 (global::Com.Qcl.VH.Usb.UsbService __self)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (__self);
					if (GetType () != typeof (鷭)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args);
						return;
					}

					if (id_ctor_Lcom_qcl_vh_usb_UsbService_ == IntPtr.Zero)
						id_ctor_Lcom_qcl_vh_usb_UsbService_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/qcl/vh/usb/UsbService;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_qcl_vh_usb_UsbService_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_qcl_vh_usb_UsbService_, __args);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qcl/vh/usb/UsbService", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UsbService); }
		}

		protected UsbService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.usb']/class[@name='UsbService']/constructor[@name='UsbService' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UsbService ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (UsbService)) {
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

		static IntPtr id_checkForAttachedDevices_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.usb']/class[@name='UsbService']/method[@name='checkForAttachedDevices' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("checkForAttachedDevices", "(Landroid/content/Context;)V", "")]
		public static unsafe void CheckForAttachedDevices (global::Android.Content.Context p0)
		{
			if (id_checkForAttachedDevices_Landroid_content_Context_ == IntPtr.Zero)
				id_checkForAttachedDevices_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "checkForAttachedDevices", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_checkForAttachedDevices_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_getAddress_IILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.usb']/class[@name='UsbService']/method[@name='getAddress' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("getAddress", "(IILjava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetAddress (int p0, int p1, string p2)
		{
			if (id_getAddress_IILjava_lang_String_ == IntPtr.Zero)
				id_getAddress_IILjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getAddress", "(IILjava/lang/String;)Ljava/lang/String;");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getAddress_IILjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_handleMessage_Landroid_os_Message_;
#pragma warning disable 0169
		static Delegate GetHandleMessage_Landroid_os_Message_Handler ()
		{
			if (cb_handleMessage_Landroid_os_Message_ == null)
				cb_handleMessage_Landroid_os_Message_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_HandleMessage_Landroid_os_Message_);
			return cb_handleMessage_Landroid_os_Message_;
		}

		static bool n_HandleMessage_Landroid_os_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Qcl.VH.Usb.UsbService __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Usb.UsbService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Message p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Message> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.HandleMessage (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_handleMessage_Landroid_os_Message_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.usb']/class[@name='UsbService']/method[@name='handleMessage' and count(parameter)=1 and parameter[1][@type='android.os.Message']]"
		[Register ("handleMessage", "(Landroid/os/Message;)Z", "GetHandleMessage_Landroid_os_Message_Handler")]
		public virtual unsafe bool HandleMessage (global::Android.OS.Message p0)
		{
			if (id_handleMessage_Landroid_os_Message_ == IntPtr.Zero)
				id_handleMessage_Landroid_os_Message_ = JNIEnv.GetMethodID (class_ref, "handleMessage", "(Landroid/os/Message;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_handleMessage_Landroid_os_Message_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "handleMessage", "(Landroid/os/Message;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_isDeviceRegistered_Ljava_util_Set_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIsDeviceRegistered_Ljava_util_Set_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_isDeviceRegistered_Ljava_util_Set_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_isDeviceRegistered_Ljava_util_Set_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_IsDeviceRegistered_Ljava_util_Set_Ljava_lang_String_Ljava_lang_String_);
			return cb_isDeviceRegistered_Ljava_util_Set_Ljava_lang_String_Ljava_lang_String_;
		}

		static bool n_IsDeviceRegistered_Ljava_util_Set_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Qcl.VH.Usb.UsbService __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Usb.UsbService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaSet<global::Com.Qcl.VH.Content.MedicalDevice>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsDeviceRegistered (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isDeviceRegistered_Ljava_util_Set_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.usb']/class[@name='UsbService']/method[@name='isDeviceRegistered' and count(parameter)=3 and parameter[1][@type='java.util.Set&lt;com.qcl.vh.content.MedicalDevice&gt;'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("isDeviceRegistered", "(Ljava/util/Set;Ljava/lang/String;Ljava/lang/String;)Z", "GetIsDeviceRegistered_Ljava_util_Set_Ljava_lang_String_Ljava_lang_String_Handler")]
		protected virtual unsafe bool IsDeviceRegistered (global::System.Collections.Generic.ICollection<global::Com.Qcl.VH.Content.MedicalDevice> p0, string p1, string p2)
		{
			if (id_isDeviceRegistered_Ljava_util_Set_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_isDeviceRegistered_Ljava_util_Set_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "isDeviceRegistered", "(Ljava/util/Set;Ljava/lang/String;Ljava/lang/String;)Z");
			IntPtr native_p0 = global::Android.Runtime.JavaSet<global::Com.Qcl.VH.Content.MedicalDevice>.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_isDeviceRegistered_Ljava_util_Set_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isDeviceRegistered", "(Ljava/util/Set;Ljava/lang/String;Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
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
			global::Com.Qcl.VH.Usb.UsbService __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Usb.UsbService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnBind (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onBind_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.usb']/class[@name='UsbService']/method[@name='onBind' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
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

		static IntPtr id_stop_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.usb']/class[@name='UsbService']/method[@name='stop' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("stop", "(Landroid/content/Context;)V", "")]
		public static unsafe void Stop (global::Android.Content.Context p0)
		{
			if (id_stop_Landroid_content_Context_ == IntPtr.Zero)
				id_stop_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "stop", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_stop_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static Delegate cb_stopUsbService_Z;
#pragma warning disable 0169
		static Delegate GetStopUsbService_ZHandler ()
		{
			if (cb_stopUsbService_Z == null)
				cb_stopUsbService_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_StopUsbService_Z);
			return cb_stopUsbService_Z;
		}

		static void n_StopUsbService_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Qcl.VH.Usb.UsbService __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Usb.UsbService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopUsbService (p0);
		}
#pragma warning restore 0169

		static IntPtr id_stopUsbService_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.usb']/class[@name='UsbService']/method[@name='stopUsbService' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("stopUsbService", "(Z)V", "GetStopUsbService_ZHandler")]
		protected virtual unsafe void StopUsbService (bool p0)
		{
			if (id_stopUsbService_Z == IntPtr.Zero)
				id_stopUsbService_Z = JNIEnv.GetMethodID (class_ref, "stopUsbService", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_stopUsbService_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stopUsbService", "(Z)V"), __args);
			} finally {
			}
		}

	}
}
