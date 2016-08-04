using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.Receiver {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.receiver']/class[@name='BtBroadcastReceiver']"
	[global::Android.Runtime.Register ("com/qcl/vh/receiver/BtBroadcastReceiver", DoNotGenerateAcw=true)]
	public partial class BtBroadcastReceiver : global::Android.Content.BroadcastReceiver {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qcl/vh/receiver/BtBroadcastReceiver", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BtBroadcastReceiver); }
		}

		protected BtBroadcastReceiver (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.receiver']/class[@name='BtBroadcastReceiver']/constructor[@name='BtBroadcastReceiver' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BtBroadcastReceiver ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (BtBroadcastReceiver)) {
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

		static IntPtr id_disable_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.receiver']/class[@name='BtBroadcastReceiver']/method[@name='disable' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("disable", "(Landroid/content/Context;)V", "")]
		public static unsafe void Disable (global::Android.Content.Context p0)
		{
			if (id_disable_Landroid_content_Context_ == IntPtr.Zero)
				id_disable_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "disable", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_disable_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_enable_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.receiver']/class[@name='BtBroadcastReceiver']/method[@name='enable' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("enable", "(Landroid/content/Context;)V", "")]
		public static unsafe void Enable (global::Android.Content.Context p0)
		{
			if (id_enable_Landroid_content_Context_ == IntPtr.Zero)
				id_enable_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "enable", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_enable_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static Delegate cb_onReceive_Landroid_content_Context_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetOnReceive_Landroid_content_Context_Landroid_content_Intent_Handler ()
		{
			if (cb_onReceive_Landroid_content_Context_Landroid_content_Intent_ == null)
				cb_onReceive_Landroid_content_Context_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnReceive_Landroid_content_Context_Landroid_content_Intent_);
			return cb_onReceive_Landroid_content_Context_Landroid_content_Intent_;
		}

		static void n_OnReceive_Landroid_content_Context_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Qcl.VH.Receiver.BtBroadcastReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Receiver.BtBroadcastReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnReceive (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onReceive_Landroid_content_Context_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.receiver']/class[@name='BtBroadcastReceiver']/method[@name='onReceive' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.Intent']]"
		[Register ("onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V", "GetOnReceive_Landroid_content_Context_Landroid_content_Intent_Handler")]
		public override unsafe void OnReceive (global::Android.Content.Context p0, global::Android.Content.Intent p1)
		{
			if (id_onReceive_Landroid_content_Context_Landroid_content_Intent_ == IntPtr.Zero)
				id_onReceive_Landroid_content_Context_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onReceive_Landroid_content_Context_Landroid_content_Intent_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_startBluetoothServices_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetStartBluetoothServices_Landroid_content_Context_Handler ()
		{
			if (cb_startBluetoothServices_Landroid_content_Context_ == null)
				cb_startBluetoothServices_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_StartBluetoothServices_Landroid_content_Context_);
			return cb_startBluetoothServices_Landroid_content_Context_;
		}

		static void n_StartBluetoothServices_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Qcl.VH.Receiver.BtBroadcastReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Receiver.BtBroadcastReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.StartBluetoothServices (p0);
		}
#pragma warning restore 0169

		static IntPtr id_startBluetoothServices_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.receiver']/class[@name='BtBroadcastReceiver']/method[@name='startBluetoothServices' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("startBluetoothServices", "(Landroid/content/Context;)V", "GetStartBluetoothServices_Landroid_content_Context_Handler")]
		protected virtual unsafe void StartBluetoothServices (global::Android.Content.Context p0)
		{
			if (id_startBluetoothServices_Landroid_content_Context_ == IntPtr.Zero)
				id_startBluetoothServices_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "startBluetoothServices", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_startBluetoothServices_Landroid_content_Context_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startBluetoothServices", "(Landroid/content/Context;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_stopBluetoothServices_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetStopBluetoothServices_Landroid_content_Context_Handler ()
		{
			if (cb_stopBluetoothServices_Landroid_content_Context_ == null)
				cb_stopBluetoothServices_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_StopBluetoothServices_Landroid_content_Context_);
			return cb_stopBluetoothServices_Landroid_content_Context_;
		}

		static void n_StopBluetoothServices_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Qcl.VH.Receiver.BtBroadcastReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Receiver.BtBroadcastReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.StopBluetoothServices (p0);
		}
#pragma warning restore 0169

		static IntPtr id_stopBluetoothServices_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.receiver']/class[@name='BtBroadcastReceiver']/method[@name='stopBluetoothServices' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("stopBluetoothServices", "(Landroid/content/Context;)V", "GetStopBluetoothServices_Landroid_content_Context_Handler")]
		protected virtual unsafe void StopBluetoothServices (global::Android.Content.Context p0)
		{
			if (id_stopBluetoothServices_Landroid_content_Context_ == IntPtr.Zero)
				id_stopBluetoothServices_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "stopBluetoothServices", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_stopBluetoothServices_Landroid_content_Context_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stopBluetoothServices", "(Landroid/content/Context;)V"), __args);
			} finally {
			}
		}

	}
}
