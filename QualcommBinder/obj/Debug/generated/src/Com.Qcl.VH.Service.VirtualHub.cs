using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.Service {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='VirtualHub']"
	[global::Android.Runtime.Register ("com/qcl/vh/service/VirtualHub", DoNotGenerateAcw=true)]
	public partial class VirtualHub : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='VirtualHub']/field[@name='TAG']"
		[Register ("TAG")]
		public const string Tag = (string) "VirtualHub";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qcl/vh/service/VirtualHub", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VirtualHub); }
		}

		protected VirtualHub (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='VirtualHub']/constructor[@name='VirtualHub' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe VirtualHub ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (VirtualHub)) {
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

		static IntPtr id_getBuildTime;
		public static unsafe string BuildTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='VirtualHub']/method[@name='getBuildTime' and count(parameter)=0]"
			[Register ("getBuildTime", "()Ljava/lang/String;", "GetGetBuildTimeHandler")]
			get {
				if (id_getBuildTime == IntPtr.Zero)
					id_getBuildTime = JNIEnv.GetStaticMethodID (class_ref, "getBuildTime", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getBuildTime), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getVersion;
		public static unsafe string Version {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.service']/class[@name='VirtualHub']/method[@name='getVersion' and count(parameter)=0]"
			[Register ("getVersion", "()Ljava/lang/String;", "GetGetVersionHandler")]
			get {
				if (id_getVersion == IntPtr.Zero)
					id_getVersion = JNIEnv.GetStaticMethodID (class_ref, "getVersion", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getVersion), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
