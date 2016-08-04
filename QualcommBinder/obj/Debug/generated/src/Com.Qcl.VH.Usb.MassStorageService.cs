using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.Usb {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.usb']/class[@name='MassStorageService']"
	[global::Android.Runtime.Register ("com/qcl/vh/usb/MassStorageService", DoNotGenerateAcw=true)]
	public partial class MassStorageService : global::Com.Qcl.VH.Usb.UsbService {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.usb']/class[@name='MassStorageService.if']"
		[global::Android.Runtime.Register ("com/qcl/vh/usb/MassStorageService$if", DoNotGenerateAcw=true)]
		public new partial class If : global::Java.Lang.Thread, global::Com.Qcl.VH.Usb.IIf {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/qcl/vh/usb/MassStorageService$if", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (If); }
			}

			protected If (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_qcl_vh_usb_MassStorageService_Lcom_qcl_vh_content_MedicalDevice_Landroid_net_Uri_Ljava_util_concurrent_CountDownLatch_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.usb']/class[@name='MassStorageService.if']/constructor[@name='MassStorageService.if' and count(parameter)=4 and parameter[1][@type='com.qcl.vh.usb.MassStorageService'] and parameter[2][@type='com.qcl.vh.content.MedicalDevice'] and parameter[3][@type='android.net.Uri'] and parameter[4][@type='java.util.concurrent.CountDownLatch']]"
			[Register (".ctor", "(Lcom/qcl/vh/usb/MassStorageService;Lcom/qcl/vh/content/MedicalDevice;Landroid/net/Uri;Ljava/util/concurrent/CountDownLatch;)V", "")]
			public unsafe If (global::Com.Qcl.VH.Usb.MassStorageService __self, global::Com.Qcl.VH.Content.MedicalDevice p1, global::Android.Net.Uri p2, global::Java.Util.Concurrent.CountDownLatch p3)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [4];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					__args [3] = new JValue (p3);
					if (GetType () != typeof (If)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Lcom/qcl/vh/content/MedicalDevice;Landroid/net/Uri;Ljava/util/concurrent/CountDownLatch;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Lcom/qcl/vh/content/MedicalDevice;Landroid/net/Uri;Ljava/util/concurrent/CountDownLatch;)V", __args);
						return;
					}

					if (id_ctor_Lcom_qcl_vh_usb_MassStorageService_Lcom_qcl_vh_content_MedicalDevice_Landroid_net_Uri_Ljava_util_concurrent_CountDownLatch_ == IntPtr.Zero)
						id_ctor_Lcom_qcl_vh_usb_MassStorageService_Lcom_qcl_vh_content_MedicalDevice_Landroid_net_Uri_Ljava_util_concurrent_CountDownLatch_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/qcl/vh/usb/MassStorageService;Lcom/qcl/vh/content/MedicalDevice;Landroid/net/Uri;Ljava/util/concurrent/CountDownLatch;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_qcl_vh_usb_MassStorageService_Lcom_qcl_vh_content_MedicalDevice_Landroid_net_Uri_Ljava_util_concurrent_CountDownLatch_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_qcl_vh_usb_MassStorageService_Lcom_qcl_vh_content_MedicalDevice_Landroid_net_Uri_Ljava_util_concurrent_CountDownLatch_, __args);
				} finally {
				}
			}

			static IntPtr id_run;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.usb']/class[@name='MassStorageService.if']/method[@name='run' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.usb']/class[@name='MassStorageService.if']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.qcl.vh.content.ˮ͈&gt;']]"
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.usb']/class[@name='MassStorageService.鷭']"
		[global::Android.Runtime.Register ("com/qcl/vh/usb/MassStorageService$鷭", DoNotGenerateAcw=true)]
		public new partial class 鷭 : global::Java.Lang.Object, global::Java.Lang.IRunnable {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/qcl/vh/usb/MassStorageService$鷭", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (鷭); }
			}

			protected 鷭 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_qcl_vh_usb_MassStorageService_Landroid_content_Context_Landroid_net_Uri_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.usb']/class[@name='MassStorageService.鷭']/constructor[@name='MassStorageService.鷭' and count(parameter)=3 and parameter[1][@type='com.qcl.vh.usb.MassStorageService'] and parameter[2][@type='android.content.Context'] and parameter[3][@type='android.net.Uri']]"
			[Register (".ctor", "(Lcom/qcl/vh/usb/MassStorageService;Landroid/content/Context;Landroid/net/Uri;)V", "")]
			public unsafe 鷭 (global::Com.Qcl.VH.Usb.MassStorageService __self, global::Android.Content.Context p1, global::Android.Net.Uri p2)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					if (GetType () != typeof (鷭)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/content/Context;Landroid/net/Uri;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/content/Context;Landroid/net/Uri;)V", __args);
						return;
					}

					if (id_ctor_Lcom_qcl_vh_usb_MassStorageService_Landroid_content_Context_Landroid_net_Uri_ == IntPtr.Zero)
						id_ctor_Lcom_qcl_vh_usb_MassStorageService_Landroid_content_Context_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/qcl/vh/usb/MassStorageService;Landroid/content/Context;Landroid/net/Uri;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_qcl_vh_usb_MassStorageService_Landroid_content_Context_Landroid_net_Uri_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_qcl_vh_usb_MassStorageService_Landroid_content_Context_Landroid_net_Uri_, __args);
				} finally {
				}
			}

			static IntPtr id_run;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.usb']/class[@name='MassStorageService.鷭']/method[@name='run' and count(parameter)=0]"
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

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qcl/vh/usb/MassStorageService", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MassStorageService); }
		}

		protected MassStorageService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.usb']/class[@name='MassStorageService']/constructor[@name='MassStorageService' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MassStorageService ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (MassStorageService)) {
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

	}
}
