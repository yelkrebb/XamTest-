using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.Content {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='DeviceManager']"
	[global::Android.Runtime.Register ("com/qcl/vh/content/DeviceManager", DoNotGenerateAcw=true)]
	public partial class DeviceManager : global::Java.Lang.Object {


		static IntPtr CONN_INTERVAL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='DeviceManager']/field[@name='CONN_INTERVAL']"
		[Register ("CONN_INTERVAL")]
		public static string ConnInterval {
			get {
				if (CONN_INTERVAL_jfieldId == IntPtr.Zero)
					CONN_INTERVAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONN_INTERVAL", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CONN_INTERVAL_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (CONN_INTERVAL_jfieldId == IntPtr.Zero)
					CONN_INTERVAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONN_INTERVAL", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, CONN_INTERVAL_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr HEART_BEAT_INTERVAL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='DeviceManager']/field[@name='HEART_BEAT_INTERVAL']"
		[Register ("HEART_BEAT_INTERVAL")]
		public static string HeartBeatInterval {
			get {
				if (HEART_BEAT_INTERVAL_jfieldId == IntPtr.Zero)
					HEART_BEAT_INTERVAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HEART_BEAT_INTERVAL", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, HEART_BEAT_INTERVAL_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (HEART_BEAT_INTERVAL_jfieldId == IntPtr.Zero)
					HEART_BEAT_INTERVAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HEART_BEAT_INTERVAL", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, HEART_BEAT_INTERVAL_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qcl/vh/content/DeviceManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DeviceManager); }
		}

		protected DeviceManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='DeviceManager']/constructor[@name='DeviceManager' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe DeviceManager (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (DeviceManager)) {
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

		static Delegate cb_addBleDeviceClass_Ljava_lang_String_ZZZIILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddBleDeviceClass_Ljava_lang_String_ZZZIILjava_lang_String_Handler ()
		{
			if (cb_addBleDeviceClass_Ljava_lang_String_ZZZIILjava_lang_String_ == null)
				cb_addBleDeviceClass_Ljava_lang_String_ZZZIILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool, bool, bool, int, int, IntPtr, IntPtr>) n_AddBleDeviceClass_Ljava_lang_String_ZZZIILjava_lang_String_);
			return cb_addBleDeviceClass_Ljava_lang_String_ZZZIILjava_lang_String_;
		}

		static IntPtr n_AddBleDeviceClass_Ljava_lang_String_ZZZIILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1, bool p2, bool p3, int p4, int p5, IntPtr native_p6)
		{
			global::Com.Qcl.VH.Content.DeviceManager __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.DeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p6 = JNIEnv.GetString (native_p6, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddBleDeviceClass (p0, p1, p2, p3, p4, p5, p6));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addBleDeviceClass_Ljava_lang_String_ZZZIILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='DeviceManager']/method[@name='addBleDeviceClass' and count(parameter)=7 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean'] and parameter[4][@type='boolean'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='java.lang.String']]"
		[Register ("addBleDeviceClass", "(Ljava/lang/String;ZZZIILjava/lang/String;)Landroid/net/Uri;", "GetAddBleDeviceClass_Ljava_lang_String_ZZZIILjava_lang_String_Handler")]
		public virtual unsafe global::Android.Net.Uri AddBleDeviceClass (string p0, bool p1, bool p2, bool p3, int p4, int p5, string p6)
		{
			if (id_addBleDeviceClass_Ljava_lang_String_ZZZIILjava_lang_String_ == IntPtr.Zero)
				id_addBleDeviceClass_Ljava_lang_String_ZZZIILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addBleDeviceClass", "(Ljava/lang/String;ZZZIILjava/lang/String;)Landroid/net/Uri;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p6 = JNIEnv.NewString (p6);
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (native_p6);

				global::Android.Net.Uri __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallObjectMethod  (Handle, id_addBleDeviceClass_Ljava_lang_String_ZZZIILjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addBleDeviceClass", "(Ljava/lang/String;ZZZIILjava/lang/String;)Landroid/net/Uri;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p6);
			}
		}

		static Delegate cb_addContinuaDeviceClass_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetAddContinuaDeviceClass_Ljava_lang_String_ZHandler ()
		{
			if (cb_addContinuaDeviceClass_Ljava_lang_String_Z == null)
				cb_addContinuaDeviceClass_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool, IntPtr>) n_AddContinuaDeviceClass_Ljava_lang_String_Z);
			return cb_addContinuaDeviceClass_Ljava_lang_String_Z;
		}

		static IntPtr n_AddContinuaDeviceClass_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Qcl.VH.Content.DeviceManager __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.DeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddContinuaDeviceClass (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addContinuaDeviceClass_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='DeviceManager']/method[@name='addContinuaDeviceClass' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("addContinuaDeviceClass", "(Ljava/lang/String;Z)Landroid/net/Uri;", "GetAddContinuaDeviceClass_Ljava_lang_String_ZHandler")]
		public virtual unsafe global::Android.Net.Uri AddContinuaDeviceClass (string p0, bool p1)
		{
			if (id_addContinuaDeviceClass_Ljava_lang_String_Z == IntPtr.Zero)
				id_addContinuaDeviceClass_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "addContinuaDeviceClass", "(Ljava/lang/String;Z)Landroid/net/Uri;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				global::Android.Net.Uri __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallObjectMethod  (Handle, id_addContinuaDeviceClass_Ljava_lang_String_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addContinuaDeviceClass", "(Ljava/lang/String;Z)Landroid/net/Uri;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_addDevice_Ljava_lang_String_JILjava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddDevice_Ljava_lang_String_JILjava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_addDevice_Ljava_lang_String_JILjava_lang_String_Ljava_lang_String_ == null)
				cb_addDevice_Ljava_lang_String_JILjava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long, int, IntPtr, IntPtr, IntPtr>) n_AddDevice_Ljava_lang_String_JILjava_lang_String_Ljava_lang_String_);
			return cb_addDevice_Ljava_lang_String_JILjava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_AddDevice_Ljava_lang_String_JILjava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, int p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Com.Qcl.VH.Content.DeviceManager __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.DeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddDevice (p0, p1, p2, p3, p4));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addDevice_Ljava_lang_String_JILjava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='DeviceManager']/method[@name='addDevice' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String']]"
		[Register ("addDevice", "(Ljava/lang/String;JILjava/lang/String;Ljava/lang/String;)Landroid/net/Uri;", "GetAddDevice_Ljava_lang_String_JILjava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe global::Android.Net.Uri AddDevice (string p0, long p1, int p2, string p3, string p4)
		{
			if (id_addDevice_Ljava_lang_String_JILjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_addDevice_Ljava_lang_String_JILjava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addDevice", "(Ljava/lang/String;JILjava/lang/String;Ljava/lang/String;)Landroid/net/Uri;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);

				global::Android.Net.Uri __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallObjectMethod  (Handle, id_addDevice_Ljava_lang_String_JILjava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addDevice", "(Ljava/lang/String;JILjava/lang/String;Ljava/lang/String;)Landroid/net/Uri;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static Delegate cb_addDevice_Ljava_lang_String_JLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddDevice_Ljava_lang_String_JLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_addDevice_Ljava_lang_String_JLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_addDevice_Ljava_lang_String_JLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AddDevice_Ljava_lang_String_JLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_addDevice_Ljava_lang_String_JLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_AddDevice_Ljava_lang_String_JLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5)
		{
			global::Com.Qcl.VH.Content.DeviceManager __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.DeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			string p5 = JNIEnv.GetString (native_p5, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddDevice (p0, p1, p2, p3, p4, p5));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addDevice_Ljava_lang_String_JLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='DeviceManager']/method[@name='addDevice' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String']]"
		[Register ("addDevice", "(Ljava/lang/String;JLjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Landroid/net/Uri;", "GetAddDevice_Ljava_lang_String_JLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe global::Android.Net.Uri AddDevice (string p0, long p1, string p2, string p3, string p4, string p5)
		{
			if (id_addDevice_Ljava_lang_String_JLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_addDevice_Ljava_lang_String_JLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addDevice", "(Ljava/lang/String;JLjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Landroid/net/Uri;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (native_p5);

				global::Android.Net.Uri __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallObjectMethod  (Handle, id_addDevice_Ljava_lang_String_JLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addDevice", "(Ljava/lang/String;JLjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Landroid/net/Uri;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p5);
			}
		}

		static Delegate cb_addDeviceClass_Ljava_lang_String_JJLjava_lang_String_Ljava_lang_String_ZZZZIJLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddDeviceClass_Ljava_lang_String_JJLjava_lang_String_Ljava_lang_String_ZZZZIJLjava_lang_String_Handler ()
		{
			if (cb_addDeviceClass_Ljava_lang_String_JJLjava_lang_String_Ljava_lang_String_ZZZZIJLjava_lang_String_ == null)
				cb_addDeviceClass_Ljava_lang_String_JJLjava_lang_String_Ljava_lang_String_ZZZZIJLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long, long, IntPtr, IntPtr, bool, bool, bool, bool, int, long, IntPtr, IntPtr>) n_AddDeviceClass_Ljava_lang_String_JJLjava_lang_String_Ljava_lang_String_ZZZZIJLjava_lang_String_);
			return cb_addDeviceClass_Ljava_lang_String_JJLjava_lang_String_Ljava_lang_String_ZZZZIJLjava_lang_String_;
		}

		static IntPtr n_AddDeviceClass_Ljava_lang_String_JJLjava_lang_String_Ljava_lang_String_ZZZZIJLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, long p2, IntPtr native_p3, IntPtr native_p4, bool p5, bool p6, bool p7, bool p8, int p9, long p10, IntPtr native_p11)
		{
			global::Com.Qcl.VH.Content.DeviceManager __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.DeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			string p11 = JNIEnv.GetString (native_p11, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddDeviceClass (p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addDeviceClass_Ljava_lang_String_JJLjava_lang_String_Ljava_lang_String_ZZZZIJLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='DeviceManager']/method[@name='addDeviceClass' and count(parameter)=12 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long'] and parameter[3][@type='long'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='boolean'] and parameter[7][@type='boolean'] and parameter[8][@type='boolean'] and parameter[9][@type='boolean'] and parameter[10][@type='int'] and parameter[11][@type='long'] and parameter[12][@type='java.lang.String']]"
		[Register ("addDeviceClass", "(Ljava/lang/String;JJLjava/lang/String;Ljava/lang/String;ZZZZIJLjava/lang/String;)Landroid/net/Uri;", "GetAddDeviceClass_Ljava_lang_String_JJLjava_lang_String_Ljava_lang_String_ZZZZIJLjava_lang_String_Handler")]
		public virtual unsafe global::Android.Net.Uri AddDeviceClass (string p0, long p1, long p2, string p3, string p4, bool p5, bool p6, bool p7, bool p8, int p9, long p10, string p11)
		{
			if (id_addDeviceClass_Ljava_lang_String_JJLjava_lang_String_Ljava_lang_String_ZZZZIJLjava_lang_String_ == IntPtr.Zero)
				id_addDeviceClass_Ljava_lang_String_JJLjava_lang_String_Ljava_lang_String_ZZZZIJLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addDeviceClass", "(Ljava/lang/String;JJLjava/lang/String;Ljava/lang/String;ZZZZIJLjava/lang/String;)Landroid/net/Uri;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p11 = JNIEnv.NewString (p11);
			try {
				JValue* __args = stackalloc JValue [12];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				__args [8] = new JValue (p8);
				__args [9] = new JValue (p9);
				__args [10] = new JValue (p10);
				__args [11] = new JValue (native_p11);

				global::Android.Net.Uri __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallObjectMethod  (Handle, id_addDeviceClass_Ljava_lang_String_JJLjava_lang_String_Ljava_lang_String_ZZZZIJLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addDeviceClass", "(Ljava/lang/String;JJLjava/lang/String;Ljava/lang/String;ZZZZIJLjava/lang/String;)Landroid/net/Uri;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p11);
			}
		}

		static Delegate cb_addSensor_Lcom_qcl_vh_a_c_Ę_;
#pragma warning disable 0169
		static Delegate GetAddSensor_Lcom_qcl_vh_a_c_Ę_Handler ()
		{
			if (cb_addSensor_Lcom_qcl_vh_a_c_Ę_ == null)
				cb_addSensor_Lcom_qcl_vh_a_c_Ę_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddSensor_Lcom_qcl_vh_a_c_Ę_);
			return cb_addSensor_Lcom_qcl_vh_a_c_Ę_;
		}

		static IntPtr n_AddSensor_Lcom_qcl_vh_a_c_Ę_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Qcl.VH.Content.DeviceManager __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.DeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Qcl.VH.A.C.Ę p0 = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.A.C.Ę> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddSensor (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addSensor_Lcom_qcl_vh_a_c_Ę_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='DeviceManager']/method[@name='addSensor' and count(parameter)=1 and parameter[1][@type='com.qcl.vh.a.c.Ę']]"
		[Register ("addSensor", "(Lcom/qcl/vh/a/c/Ę;)Landroid/net/Uri;", "GetAddSensor_Lcom_qcl_vh_a_c_Ę_Handler")]
		public virtual unsafe global::Android.Net.Uri AddSensor (global::Com.Qcl.VH.A.C.Ę p0)
		{
			if (id_addSensor_Lcom_qcl_vh_a_c_Ę_ == IntPtr.Zero)
				id_addSensor_Lcom_qcl_vh_a_c_Ę_ = JNIEnv.GetMethodID (class_ref, "addSensor", "(Lcom/qcl/vh/a/c/Ę;)Landroid/net/Uri;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Android.Net.Uri __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallObjectMethod  (Handle, id_addSensor_Lcom_qcl_vh_a_c_Ę_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addSensor", "(Lcom/qcl/vh/a/c/Ę;)Landroid/net/Uri;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_addUsbDevice_Ljava_lang_String_JLjava_lang_String_ZLjava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddUsbDevice_Ljava_lang_String_JLjava_lang_String_ZLjava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_addUsbDevice_Ljava_lang_String_JLjava_lang_String_ZLjava_lang_String_Ljava_lang_String_ == null)
				cb_addUsbDevice_Ljava_lang_String_JLjava_lang_String_ZLjava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long, IntPtr, bool, IntPtr, IntPtr, IntPtr>) n_AddUsbDevice_Ljava_lang_String_JLjava_lang_String_ZLjava_lang_String_Ljava_lang_String_);
			return cb_addUsbDevice_Ljava_lang_String_JLjava_lang_String_ZLjava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_AddUsbDevice_Ljava_lang_String_JLjava_lang_String_ZLjava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, IntPtr native_p2, bool p3, IntPtr native_p4, IntPtr native_p5)
		{
			global::Com.Qcl.VH.Content.DeviceManager __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.DeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			string p5 = JNIEnv.GetString (native_p5, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddUsbDevice (p0, p1, p2, p3, p4, p5));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addUsbDevice_Ljava_lang_String_JLjava_lang_String_ZLjava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='DeviceManager']/method[@name='addUsbDevice' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='boolean'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String']]"
		[Register ("addUsbDevice", "(Ljava/lang/String;JLjava/lang/String;ZLjava/lang/String;Ljava/lang/String;)Landroid/net/Uri;", "GetAddUsbDevice_Ljava_lang_String_JLjava_lang_String_ZLjava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe global::Android.Net.Uri AddUsbDevice (string p0, long p1, string p2, bool p3, string p4, string p5)
		{
			if (id_addUsbDevice_Ljava_lang_String_JLjava_lang_String_ZLjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_addUsbDevice_Ljava_lang_String_JLjava_lang_String_ZLjava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addUsbDevice", "(Ljava/lang/String;JLjava/lang/String;ZLjava/lang/String;Ljava/lang/String;)Landroid/net/Uri;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (native_p5);

				global::Android.Net.Uri __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallObjectMethod  (Handle, id_addUsbDevice_Ljava_lang_String_JLjava_lang_String_ZLjava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addUsbDevice", "(Ljava/lang/String;JLjava/lang/String;ZLjava/lang/String;Ljava/lang/String;)Landroid/net/Uri;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p5);
			}
		}

		static Delegate cb_deleteAllDevices;
#pragma warning disable 0169
		static Delegate GetDeleteAllDevicesHandler ()
		{
			if (cb_deleteAllDevices == null)
				cb_deleteAllDevices = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DeleteAllDevices);
			return cb_deleteAllDevices;
		}

		static void n_DeleteAllDevices (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Qcl.VH.Content.DeviceManager __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.DeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DeleteAllDevices ();
		}
#pragma warning restore 0169

		static IntPtr id_deleteAllDevices;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='DeviceManager']/method[@name='deleteAllDevices' and count(parameter)=0]"
		[Register ("deleteAllDevices", "()V", "GetDeleteAllDevicesHandler")]
		public virtual unsafe void DeleteAllDevices ()
		{
			if (id_deleteAllDevices == IntPtr.Zero)
				id_deleteAllDevices = JNIEnv.GetMethodID (class_ref, "deleteAllDevices", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_deleteAllDevices);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deleteAllDevices", "()V"));
			} finally {
			}
		}

		static Delegate cb_findAll;
#pragma warning disable 0169
		static Delegate GetFindAllHandler ()
		{
			if (cb_findAll == null)
				cb_findAll = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_FindAll);
			return cb_findAll;
		}

		static IntPtr n_FindAll (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Qcl.VH.Content.DeviceManager __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.DeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<global::Com.Qcl.VH.Content.MedicalDevice>.ToLocalJniHandle (__this.FindAll ());
		}
#pragma warning restore 0169

		static IntPtr id_findAll;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='DeviceManager']/method[@name='findAll' and count(parameter)=0]"
		[Register ("findAll", "()Ljava/util/Set;", "GetFindAllHandler")]
		public virtual unsafe global::System.Collections.Generic.ICollection<global::Com.Qcl.VH.Content.MedicalDevice> FindAll ()
		{
			if (id_findAll == IntPtr.Zero)
				id_findAll = JNIEnv.GetMethodID (class_ref, "findAll", "()Ljava/util/Set;");
			try {

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaSet<global::Com.Qcl.VH.Content.MedicalDevice>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_findAll), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaSet<global::Com.Qcl.VH.Content.MedicalDevice>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "findAll", "()Ljava/util/Set;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_findAllBleDevices;
#pragma warning disable 0169
		static Delegate GetFindAllBleDevicesHandler ()
		{
			if (cb_findAllBleDevices == null)
				cb_findAllBleDevices = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_FindAllBleDevices);
			return cb_findAllBleDevices;
		}

		static IntPtr n_FindAllBleDevices (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Qcl.VH.Content.DeviceManager __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.DeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<global::Com.Qcl.VH.Content.MedicalDevice>.ToLocalJniHandle (__this.FindAllBleDevices ());
		}
#pragma warning restore 0169

		static IntPtr id_findAllBleDevices;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='DeviceManager']/method[@name='findAllBleDevices' and count(parameter)=0]"
		[Register ("findAllBleDevices", "()Ljava/util/Set;", "GetFindAllBleDevicesHandler")]
		public virtual unsafe global::System.Collections.Generic.ICollection<global::Com.Qcl.VH.Content.MedicalDevice> FindAllBleDevices ()
		{
			if (id_findAllBleDevices == IntPtr.Zero)
				id_findAllBleDevices = JNIEnv.GetMethodID (class_ref, "findAllBleDevices", "()Ljava/util/Set;");
			try {

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaSet<global::Com.Qcl.VH.Content.MedicalDevice>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_findAllBleDevices), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaSet<global::Com.Qcl.VH.Content.MedicalDevice>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "findAllBleDevices", "()Ljava/util/Set;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_findAllUsbDevices;
#pragma warning disable 0169
		static Delegate GetFindAllUsbDevicesHandler ()
		{
			if (cb_findAllUsbDevices == null)
				cb_findAllUsbDevices = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_FindAllUsbDevices);
			return cb_findAllUsbDevices;
		}

		static IntPtr n_FindAllUsbDevices (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Qcl.VH.Content.DeviceManager __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.DeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<global::Com.Qcl.VH.Content.MedicalDevice>.ToLocalJniHandle (__this.FindAllUsbDevices ());
		}
#pragma warning restore 0169

		static IntPtr id_findAllUsbDevices;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='DeviceManager']/method[@name='findAllUsbDevices' and count(parameter)=0]"
		[Register ("findAllUsbDevices", "()Ljava/util/Set;", "GetFindAllUsbDevicesHandler")]
		public virtual unsafe global::System.Collections.Generic.ICollection<global::Com.Qcl.VH.Content.MedicalDevice> FindAllUsbDevices ()
		{
			if (id_findAllUsbDevices == IntPtr.Zero)
				id_findAllUsbDevices = JNIEnv.GetMethodID (class_ref, "findAllUsbDevices", "()Ljava/util/Set;");
			try {

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaSet<global::Com.Qcl.VH.Content.MedicalDevice>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_findAllUsbDevices), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaSet<global::Com.Qcl.VH.Content.MedicalDevice>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "findAllUsbDevices", "()Ljava/util/Set;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_findAlwaysOnBleDevices;
#pragma warning disable 0169
		static Delegate GetFindAlwaysOnBleDevicesHandler ()
		{
			if (cb_findAlwaysOnBleDevices == null)
				cb_findAlwaysOnBleDevices = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_FindAlwaysOnBleDevices);
			return cb_findAlwaysOnBleDevices;
		}

		static IntPtr n_FindAlwaysOnBleDevices (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Qcl.VH.Content.DeviceManager __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.DeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<global::Com.Qcl.VH.Content.MedicalDevice>.ToLocalJniHandle (__this.FindAlwaysOnBleDevices ());
		}
#pragma warning restore 0169

		static IntPtr id_findAlwaysOnBleDevices;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='DeviceManager']/method[@name='findAlwaysOnBleDevices' and count(parameter)=0]"
		[Register ("findAlwaysOnBleDevices", "()Ljava/util/Set;", "GetFindAlwaysOnBleDevicesHandler")]
		public virtual unsafe global::System.Collections.Generic.ICollection<global::Com.Qcl.VH.Content.MedicalDevice> FindAlwaysOnBleDevices ()
		{
			if (id_findAlwaysOnBleDevices == IntPtr.Zero)
				id_findAlwaysOnBleDevices = JNIEnv.GetMethodID (class_ref, "findAlwaysOnBleDevices", "()Ljava/util/Set;");
			try {

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaSet<global::Com.Qcl.VH.Content.MedicalDevice>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_findAlwaysOnBleDevices), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaSet<global::Com.Qcl.VH.Content.MedicalDevice>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "findAlwaysOnBleDevices", "()Ljava/util/Set;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_findAutoConnectBleDevices;
#pragma warning disable 0169
		static Delegate GetFindAutoConnectBleDevicesHandler ()
		{
			if (cb_findAutoConnectBleDevices == null)
				cb_findAutoConnectBleDevices = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_FindAutoConnectBleDevices);
			return cb_findAutoConnectBleDevices;
		}

		static IntPtr n_FindAutoConnectBleDevices (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Qcl.VH.Content.DeviceManager __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.DeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<global::Com.Qcl.VH.Content.MedicalDevice>.ToLocalJniHandle (__this.FindAutoConnectBleDevices ());
		}
#pragma warning restore 0169

		static IntPtr id_findAutoConnectBleDevices;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='DeviceManager']/method[@name='findAutoConnectBleDevices' and count(parameter)=0]"
		[Register ("findAutoConnectBleDevices", "()Ljava/util/Set;", "GetFindAutoConnectBleDevicesHandler")]
		public virtual unsafe global::System.Collections.Generic.ICollection<global::Com.Qcl.VH.Content.MedicalDevice> FindAutoConnectBleDevices ()
		{
			if (id_findAutoConnectBleDevices == IntPtr.Zero)
				id_findAutoConnectBleDevices = JNIEnv.GetMethodID (class_ref, "findAutoConnectBleDevices", "()Ljava/util/Set;");
			try {

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaSet<global::Com.Qcl.VH.Content.MedicalDevice>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_findAutoConnectBleDevices), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaSet<global::Com.Qcl.VH.Content.MedicalDevice>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "findAutoConnectBleDevices", "()Ljava/util/Set;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_findByAdapter_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetFindByAdapter_Ljava_lang_String_Handler ()
		{
			if (cb_findByAdapter_Ljava_lang_String_ == null)
				cb_findByAdapter_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_FindByAdapter_Ljava_lang_String_);
			return cb_findByAdapter_Ljava_lang_String_;
		}

		static IntPtr n_FindByAdapter_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Qcl.VH.Content.DeviceManager __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.DeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaSet<global::Com.Qcl.VH.Content.MedicalDevice>.ToLocalJniHandle (__this.FindByAdapter (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_findByAdapter_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='DeviceManager']/method[@name='findByAdapter' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("findByAdapter", "(Ljava/lang/String;)Ljava/util/Set;", "GetFindByAdapter_Ljava_lang_String_Handler")]
		public virtual unsafe global::System.Collections.Generic.ICollection<global::Com.Qcl.VH.Content.MedicalDevice> FindByAdapter (string p0)
		{
			if (id_findByAdapter_Ljava_lang_String_ == IntPtr.Zero)
				id_findByAdapter_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "findByAdapter", "(Ljava/lang/String;)Ljava/util/Set;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::System.Collections.Generic.ICollection<global::Com.Qcl.VH.Content.MedicalDevice> __ret;
				if (GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaSet<global::Com.Qcl.VH.Content.MedicalDevice>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_findByAdapter_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaSet<global::Com.Qcl.VH.Content.MedicalDevice>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "findByAdapter", "(Ljava/lang/String;)Ljava/util/Set;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_findByAddress_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetFindByAddress_Ljava_lang_String_Handler ()
		{
			if (cb_findByAddress_Ljava_lang_String_ == null)
				cb_findByAddress_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_FindByAddress_Ljava_lang_String_);
			return cb_findByAddress_Ljava_lang_String_;
		}

		static IntPtr n_FindByAddress_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Qcl.VH.Content.DeviceManager __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.DeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.FindByAddress (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_findByAddress_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='DeviceManager']/method[@name='findByAddress' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("findByAddress", "(Ljava/lang/String;)Lcom/qcl/vh/content/MedicalDevice;", "GetFindByAddress_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Qcl.VH.Content.MedicalDevice FindByAddress (string p0)
		{
			if (id_findByAddress_Ljava_lang_String_ == IntPtr.Zero)
				id_findByAddress_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "findByAddress", "(Ljava/lang/String;)Lcom/qcl/vh/content/MedicalDevice;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Qcl.VH.Content.MedicalDevice __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.MedicalDevice> (JNIEnv.CallObjectMethod  (Handle, id_findByAddress_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.MedicalDevice> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "findByAddress", "(Ljava/lang/String;)Lcom/qcl/vh/content/MedicalDevice;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_findByModelAndCompanyId_II;
#pragma warning disable 0169
		static Delegate GetFindByModelAndCompanyId_IIHandler ()
		{
			if (cb_findByModelAndCompanyId_II == null)
				cb_findByModelAndCompanyId_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr>) n_FindByModelAndCompanyId_II);
			return cb_findByModelAndCompanyId_II;
		}

		static IntPtr n_FindByModelAndCompanyId_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Qcl.VH.Content.DeviceManager __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.DeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FindByModelAndCompanyId (p0, p1));
		}
#pragma warning restore 0169

		static IntPtr id_findByModelAndCompanyId_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='DeviceManager']/method[@name='findByModelAndCompanyId' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("findByModelAndCompanyId", "(II)Lcom/qcl/vh/content/MedicalDevice;", "GetFindByModelAndCompanyId_IIHandler")]
		public virtual unsafe global::Com.Qcl.VH.Content.MedicalDevice FindByModelAndCompanyId (int p0, int p1)
		{
			if (id_findByModelAndCompanyId_II == IntPtr.Zero)
				id_findByModelAndCompanyId_II = JNIEnv.GetMethodID (class_ref, "findByModelAndCompanyId", "(II)Lcom/qcl/vh/content/MedicalDevice;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.MedicalDevice> (JNIEnv.CallObjectMethod  (Handle, id_findByModelAndCompanyId_II, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.MedicalDevice> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "findByModelAndCompanyId", "(II)Lcom/qcl/vh/content/MedicalDevice;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_findBySensorId_I;
#pragma warning disable 0169
		static Delegate GetFindBySensorId_IHandler ()
		{
			if (cb_findBySensorId_I == null)
				cb_findBySensorId_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_FindBySensorId_I);
			return cb_findBySensorId_I;
		}

		static IntPtr n_FindBySensorId_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Qcl.VH.Content.DeviceManager __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.DeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FindBySensorId (p0));
		}
#pragma warning restore 0169

		static IntPtr id_findBySensorId_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='DeviceManager']/method[@name='findBySensorId' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("findBySensorId", "(I)Lcom/qcl/vh/content/MedicalDevice;", "GetFindBySensorId_IHandler")]
		public virtual unsafe global::Com.Qcl.VH.Content.MedicalDevice FindBySensorId (int p0)
		{
			if (id_findBySensorId_I == IntPtr.Zero)
				id_findBySensorId_I = JNIEnv.GetMethodID (class_ref, "findBySensorId", "(I)Lcom/qcl/vh/content/MedicalDevice;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.MedicalDevice> (JNIEnv.CallObjectMethod  (Handle, id_findBySensorId_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.MedicalDevice> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "findBySensorId", "(I)Lcom/qcl/vh/content/MedicalDevice;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_findContinuaDevices;
#pragma warning disable 0169
		static Delegate GetFindContinuaDevicesHandler ()
		{
			if (cb_findContinuaDevices == null)
				cb_findContinuaDevices = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_FindContinuaDevices);
			return cb_findContinuaDevices;
		}

		static IntPtr n_FindContinuaDevices (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Qcl.VH.Content.DeviceManager __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.DeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<global::Com.Qcl.VH.Content.MedicalDevice>.ToLocalJniHandle (__this.FindContinuaDevices ());
		}
#pragma warning restore 0169

		static IntPtr id_findContinuaDevices;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='DeviceManager']/method[@name='findContinuaDevices' and count(parameter)=0]"
		[Register ("findContinuaDevices", "()Ljava/util/Set;", "GetFindContinuaDevicesHandler")]
		public virtual unsafe global::System.Collections.Generic.ICollection<global::Com.Qcl.VH.Content.MedicalDevice> FindContinuaDevices ()
		{
			if (id_findContinuaDevices == IntPtr.Zero)
				id_findContinuaDevices = JNIEnv.GetMethodID (class_ref, "findContinuaDevices", "()Ljava/util/Set;");
			try {

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaSet<global::Com.Qcl.VH.Content.MedicalDevice>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_findContinuaDevices), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaSet<global::Com.Qcl.VH.Content.MedicalDevice>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "findContinuaDevices", "()Ljava/util/Set;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_findExplicitBondingDevices;
#pragma warning disable 0169
		static Delegate GetFindExplicitBondingDevicesHandler ()
		{
			if (cb_findExplicitBondingDevices == null)
				cb_findExplicitBondingDevices = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_FindExplicitBondingDevices);
			return cb_findExplicitBondingDevices;
		}

		static IntPtr n_FindExplicitBondingDevices (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Qcl.VH.Content.DeviceManager __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.DeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<global::Com.Qcl.VH.Content.MedicalDevice>.ToLocalJniHandle (__this.FindExplicitBondingDevices ());
		}
#pragma warning restore 0169

		static IntPtr id_findExplicitBondingDevices;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='DeviceManager']/method[@name='findExplicitBondingDevices' and count(parameter)=0]"
		[Register ("findExplicitBondingDevices", "()Ljava/util/Set;", "GetFindExplicitBondingDevicesHandler")]
		public virtual unsafe global::System.Collections.Generic.ICollection<global::Com.Qcl.VH.Content.MedicalDevice> FindExplicitBondingDevices ()
		{
			if (id_findExplicitBondingDevices == IntPtr.Zero)
				id_findExplicitBondingDevices = JNIEnv.GetMethodID (class_ref, "findExplicitBondingDevices", "()Ljava/util/Set;");
			try {

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaSet<global::Com.Qcl.VH.Content.MedicalDevice>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_findExplicitBondingDevices), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaSet<global::Com.Qcl.VH.Content.MedicalDevice>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "findExplicitBondingDevices", "()Ljava/util/Set;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_findMasters;
#pragma warning disable 0169
		static Delegate GetFindMastersHandler ()
		{
			if (cb_findMasters == null)
				cb_findMasters = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_FindMasters);
			return cb_findMasters;
		}

		static IntPtr n_FindMasters (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Qcl.VH.Content.DeviceManager __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.DeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<global::Com.Qcl.VH.Content.MedicalDevice>.ToLocalJniHandle (__this.FindMasters ());
		}
#pragma warning restore 0169

		static IntPtr id_findMasters;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='DeviceManager']/method[@name='findMasters' and count(parameter)=0]"
		[Register ("findMasters", "()Ljava/util/Set;", "GetFindMastersHandler")]
		public virtual unsafe global::System.Collections.Generic.ICollection<global::Com.Qcl.VH.Content.MedicalDevice> FindMasters ()
		{
			if (id_findMasters == IntPtr.Zero)
				id_findMasters = JNIEnv.GetMethodID (class_ref, "findMasters", "()Ljava/util/Set;");
			try {

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaSet<global::Com.Qcl.VH.Content.MedicalDevice>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_findMasters), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaSet<global::Com.Qcl.VH.Content.MedicalDevice>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "findMasters", "()Ljava/util/Set;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_findSlaves;
#pragma warning disable 0169
		static Delegate GetFindSlavesHandler ()
		{
			if (cb_findSlaves == null)
				cb_findSlaves = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_FindSlaves);
			return cb_findSlaves;
		}

		static IntPtr n_FindSlaves (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Qcl.VH.Content.DeviceManager __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.DeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<global::Com.Qcl.VH.Content.MedicalDevice>.ToLocalJniHandle (__this.FindSlaves ());
		}
#pragma warning restore 0169

		static IntPtr id_findSlaves;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='DeviceManager']/method[@name='findSlaves' and count(parameter)=0]"
		[Register ("findSlaves", "()Ljava/util/Set;", "GetFindSlavesHandler")]
		public virtual unsafe global::System.Collections.Generic.ICollection<global::Com.Qcl.VH.Content.MedicalDevice> FindSlaves ()
		{
			if (id_findSlaves == IntPtr.Zero)
				id_findSlaves = JNIEnv.GetMethodID (class_ref, "findSlaves", "()Ljava/util/Set;");
			try {

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaSet<global::Com.Qcl.VH.Content.MedicalDevice>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_findSlaves), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaSet<global::Com.Qcl.VH.Content.MedicalDevice>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "findSlaves", "()Ljava/util/Set;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_findUsbDevicesByInterfaceClass_I;
#pragma warning disable 0169
		static Delegate GetFindUsbDevicesByInterfaceClass_IHandler ()
		{
			if (cb_findUsbDevicesByInterfaceClass_I == null)
				cb_findUsbDevicesByInterfaceClass_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_FindUsbDevicesByInterfaceClass_I);
			return cb_findUsbDevicesByInterfaceClass_I;
		}

		static IntPtr n_FindUsbDevicesByInterfaceClass_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Qcl.VH.Content.DeviceManager __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.DeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<global::Com.Qcl.VH.Content.MedicalDevice>.ToLocalJniHandle (__this.FindUsbDevicesByInterfaceClass (p0));
		}
#pragma warning restore 0169

		static IntPtr id_findUsbDevicesByInterfaceClass_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='DeviceManager']/method[@name='findUsbDevicesByInterfaceClass' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("findUsbDevicesByInterfaceClass", "(I)Ljava/util/Set;", "GetFindUsbDevicesByInterfaceClass_IHandler")]
		public virtual unsafe global::System.Collections.Generic.ICollection<global::Com.Qcl.VH.Content.MedicalDevice> FindUsbDevicesByInterfaceClass (int p0)
		{
			if (id_findUsbDevicesByInterfaceClass_I == IntPtr.Zero)
				id_findUsbDevicesByInterfaceClass_I = JNIEnv.GetMethodID (class_ref, "findUsbDevicesByInterfaceClass", "(I)Ljava/util/Set;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaSet<global::Com.Qcl.VH.Content.MedicalDevice>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_findUsbDevicesByInterfaceClass_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaSet<global::Com.Qcl.VH.Content.MedicalDevice>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "findUsbDevicesByInterfaceClass", "(I)Ljava/util/Set;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_findUsbDevicesByVidPid_II;
#pragma warning disable 0169
		static Delegate GetFindUsbDevicesByVidPid_IIHandler ()
		{
			if (cb_findUsbDevicesByVidPid_II == null)
				cb_findUsbDevicesByVidPid_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr>) n_FindUsbDevicesByVidPid_II);
			return cb_findUsbDevicesByVidPid_II;
		}

		static IntPtr n_FindUsbDevicesByVidPid_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Qcl.VH.Content.DeviceManager __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.DeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<global::Com.Qcl.VH.Content.MedicalDevice>.ToLocalJniHandle (__this.FindUsbDevicesByVidPid (p0, p1));
		}
#pragma warning restore 0169

		static IntPtr id_findUsbDevicesByVidPid_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='DeviceManager']/method[@name='findUsbDevicesByVidPid' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("findUsbDevicesByVidPid", "(II)Ljava/util/Set;", "GetFindUsbDevicesByVidPid_IIHandler")]
		public virtual unsafe global::System.Collections.Generic.ICollection<global::Com.Qcl.VH.Content.MedicalDevice> FindUsbDevicesByVidPid (int p0, int p1)
		{
			if (id_findUsbDevicesByVidPid_II == IntPtr.Zero)
				id_findUsbDevicesByVidPid_II = JNIEnv.GetMethodID (class_ref, "findUsbDevicesByVidPid", "(II)Ljava/util/Set;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaSet<global::Com.Qcl.VH.Content.MedicalDevice>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_findUsbDevicesByVidPid_II, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaSet<global::Com.Qcl.VH.Content.MedicalDevice>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "findUsbDevicesByVidPid", "(II)Ljava/util/Set;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getSensorState_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetSensorState_Ljava_lang_String_Handler ()
		{
			if (cb_getSensorState_Ljava_lang_String_ == null)
				cb_getSensorState_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetSensorState_Ljava_lang_String_);
			return cb_getSensorState_Ljava_lang_String_;
		}

		static IntPtr n_GetSensorState_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Qcl.VH.Content.DeviceManager __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.DeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetSensorState (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getSensorState_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='DeviceManager']/method[@name='getSensorState' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getSensorState", "(Ljava/lang/String;)Lcom/qcl/vh/a/c/廅;", "GetGetSensorState_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Qcl.VH.A.C.廅 GetSensorState (string p0)
		{
			if (id_getSensorState_Ljava_lang_String_ == IntPtr.Zero)
				id_getSensorState_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getSensorState", "(Ljava/lang/String;)Lcom/qcl/vh/a/c/廅;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Qcl.VH.A.C.廅 __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.A.C.廅> (JNIEnv.CallObjectMethod  (Handle, id_getSensorState_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.A.C.廅> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSensorState", "(Ljava/lang/String;)Lcom/qcl/vh/a/c/廅;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_isDeviceClassAdded_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIsDeviceClassAdded_Ljava_lang_String_Handler ()
		{
			if (cb_isDeviceClassAdded_Ljava_lang_String_ == null)
				cb_isDeviceClassAdded_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsDeviceClassAdded_Ljava_lang_String_);
			return cb_isDeviceClassAdded_Ljava_lang_String_;
		}

		static bool n_IsDeviceClassAdded_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Qcl.VH.Content.DeviceManager __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.DeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsDeviceClassAdded (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isDeviceClassAdded_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='DeviceManager']/method[@name='isDeviceClassAdded' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isDeviceClassAdded", "(Ljava/lang/String;)Z", "GetIsDeviceClassAdded_Ljava_lang_String_Handler")]
		public virtual unsafe bool IsDeviceClassAdded (string p0)
		{
			if (id_isDeviceClassAdded_Ljava_lang_String_ == IntPtr.Zero)
				id_isDeviceClassAdded_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "isDeviceClassAdded", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_isDeviceClassAdded_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isDeviceClassAdded", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_removeByAddress_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveByAddress_Ljava_lang_String_Handler ()
		{
			if (cb_removeByAddress_Ljava_lang_String_ == null)
				cb_removeByAddress_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveByAddress_Ljava_lang_String_);
			return cb_removeByAddress_Ljava_lang_String_;
		}

		static void n_RemoveByAddress_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Qcl.VH.Content.DeviceManager __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.DeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveByAddress (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeByAddress_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='DeviceManager']/method[@name='removeByAddress' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("removeByAddress", "(Ljava/lang/String;)V", "GetRemoveByAddress_Ljava_lang_String_Handler")]
		public virtual unsafe void RemoveByAddress (string p0)
		{
			if (id_removeByAddress_Ljava_lang_String_ == IntPtr.Zero)
				id_removeByAddress_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "removeByAddress", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_removeByAddress_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeByAddress", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_removeSensor_Lcom_qcl_vh_a_c_Ę_;
#pragma warning disable 0169
		static Delegate GetRemoveSensor_Lcom_qcl_vh_a_c_Ę_Handler ()
		{
			if (cb_removeSensor_Lcom_qcl_vh_a_c_Ę_ == null)
				cb_removeSensor_Lcom_qcl_vh_a_c_Ę_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveSensor_Lcom_qcl_vh_a_c_Ę_);
			return cb_removeSensor_Lcom_qcl_vh_a_c_Ę_;
		}

		static void n_RemoveSensor_Lcom_qcl_vh_a_c_Ę_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Qcl.VH.Content.DeviceManager __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.DeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Qcl.VH.A.C.Ę p0 = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.A.C.Ę> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveSensor (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeSensor_Lcom_qcl_vh_a_c_Ę_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='DeviceManager']/method[@name='removeSensor' and count(parameter)=1 and parameter[1][@type='com.qcl.vh.a.c.Ę']]"
		[Register ("removeSensor", "(Lcom/qcl/vh/a/c/Ę;)V", "GetRemoveSensor_Lcom_qcl_vh_a_c_Ę_Handler")]
		public virtual unsafe void RemoveSensor (global::Com.Qcl.VH.A.C.Ę p0)
		{
			if (id_removeSensor_Lcom_qcl_vh_a_c_Ę_ == IntPtr.Zero)
				id_removeSensor_Lcom_qcl_vh_a_c_Ę_ = JNIEnv.GetMethodID (class_ref, "removeSensor", "(Lcom/qcl/vh/a/c/Ę;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_removeSensor_Lcom_qcl_vh_a_c_Ę_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeSensor", "(Lcom/qcl/vh/a/c/Ę;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_removeSensors_Ljava_util_Set_;
#pragma warning disable 0169
		static Delegate GetRemoveSensors_Ljava_util_Set_Handler ()
		{
			if (cb_removeSensors_Ljava_util_Set_ == null)
				cb_removeSensors_Ljava_util_Set_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveSensors_Ljava_util_Set_);
			return cb_removeSensors_Ljava_util_Set_;
		}

		static void n_RemoveSensors_Ljava_util_Set_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Qcl.VH.Content.DeviceManager __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.DeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaSet<global::Com.Qcl.VH.A.C.Ę>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveSensors (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeSensors_Ljava_util_Set_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='DeviceManager']/method[@name='removeSensors' and count(parameter)=1 and parameter[1][@type='java.util.Set&lt;com.qcl.vh.a.c.Ę&gt;']]"
		[Register ("removeSensors", "(Ljava/util/Set;)V", "GetRemoveSensors_Ljava_util_Set_Handler")]
		public virtual unsafe void RemoveSensors (global::System.Collections.Generic.ICollection<global::Com.Qcl.VH.A.C.Ę> p0)
		{
			if (id_removeSensors_Ljava_util_Set_ == IntPtr.Zero)
				id_removeSensors_Ljava_util_Set_ = JNIEnv.GetMethodID (class_ref, "removeSensors", "(Ljava/util/Set;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaSet<global::Com.Qcl.VH.A.C.Ę>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_removeSensors_Ljava_util_Set_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeSensors", "(Ljava/util/Set;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_updateBondStatus_Lcom_qcl_vh_content_MedicalDevice_ZZ;
#pragma warning disable 0169
		static Delegate GetUpdateBondStatus_Lcom_qcl_vh_content_MedicalDevice_ZZHandler ()
		{
			if (cb_updateBondStatus_Lcom_qcl_vh_content_MedicalDevice_ZZ == null)
				cb_updateBondStatus_Lcom_qcl_vh_content_MedicalDevice_ZZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool, bool, bool>) n_UpdateBondStatus_Lcom_qcl_vh_content_MedicalDevice_ZZ);
			return cb_updateBondStatus_Lcom_qcl_vh_content_MedicalDevice_ZZ;
		}

		static bool n_UpdateBondStatus_Lcom_qcl_vh_content_MedicalDevice_ZZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1, bool p2)
		{
			global::Com.Qcl.VH.Content.DeviceManager __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.DeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Qcl.VH.Content.MedicalDevice p0 = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.MedicalDevice> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.UpdateBondStatus (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_updateBondStatus_Lcom_qcl_vh_content_MedicalDevice_ZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='DeviceManager']/method[@name='updateBondStatus' and count(parameter)=3 and parameter[1][@type='com.qcl.vh.content.MedicalDevice'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean']]"
		[Register ("updateBondStatus", "(Lcom/qcl/vh/content/MedicalDevice;ZZ)Z", "GetUpdateBondStatus_Lcom_qcl_vh_content_MedicalDevice_ZZHandler")]
		public virtual unsafe bool UpdateBondStatus (global::Com.Qcl.VH.Content.MedicalDevice p0, bool p1, bool p2)
		{
			if (id_updateBondStatus_Lcom_qcl_vh_content_MedicalDevice_ZZ == IntPtr.Zero)
				id_updateBondStatus_Lcom_qcl_vh_content_MedicalDevice_ZZ = JNIEnv.GetMethodID (class_ref, "updateBondStatus", "(Lcom/qcl/vh/content/MedicalDevice;ZZ)Z");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_updateBondStatus_Lcom_qcl_vh_content_MedicalDevice_ZZ, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateBondStatus", "(Lcom/qcl/vh/content/MedicalDevice;ZZ)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_updateChannel_Lcom_qcl_vh_content_MedicalDevice_IZ;
#pragma warning disable 0169
		static Delegate GetUpdateChannel_Lcom_qcl_vh_content_MedicalDevice_IZHandler ()
		{
			if (cb_updateChannel_Lcom_qcl_vh_content_MedicalDevice_IZ == null)
				cb_updateChannel_Lcom_qcl_vh_content_MedicalDevice_IZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, bool, bool>) n_UpdateChannel_Lcom_qcl_vh_content_MedicalDevice_IZ);
			return cb_updateChannel_Lcom_qcl_vh_content_MedicalDevice_IZ;
		}

		static bool n_UpdateChannel_Lcom_qcl_vh_content_MedicalDevice_IZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, bool p2)
		{
			global::Com.Qcl.VH.Content.DeviceManager __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.DeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Qcl.VH.Content.MedicalDevice p0 = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.MedicalDevice> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.UpdateChannel (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_updateChannel_Lcom_qcl_vh_content_MedicalDevice_IZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='DeviceManager']/method[@name='updateChannel' and count(parameter)=3 and parameter[1][@type='com.qcl.vh.content.MedicalDevice'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("updateChannel", "(Lcom/qcl/vh/content/MedicalDevice;IZ)Z", "GetUpdateChannel_Lcom_qcl_vh_content_MedicalDevice_IZHandler")]
		public virtual unsafe bool UpdateChannel (global::Com.Qcl.VH.Content.MedicalDevice p0, int p1, bool p2)
		{
			if (id_updateChannel_Lcom_qcl_vh_content_MedicalDevice_IZ == IntPtr.Zero)
				id_updateChannel_Lcom_qcl_vh_content_MedicalDevice_IZ = JNIEnv.GetMethodID (class_ref, "updateChannel", "(Lcom/qcl/vh/content/MedicalDevice;IZ)Z");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_updateChannel_Lcom_qcl_vh_content_MedicalDevice_IZ, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateChannel", "(Lcom/qcl/vh/content/MedicalDevice;IZ)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_updateCoolOffTime_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetUpdateCoolOffTime_Ljava_lang_String_IHandler ()
		{
			if (cb_updateCoolOffTime_Ljava_lang_String_I == null)
				cb_updateCoolOffTime_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, bool>) n_UpdateCoolOffTime_Ljava_lang_String_I);
			return cb_updateCoolOffTime_Ljava_lang_String_I;
		}

		static bool n_UpdateCoolOffTime_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Qcl.VH.Content.DeviceManager __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.DeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.UpdateCoolOffTime (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_updateCoolOffTime_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='DeviceManager']/method[@name='updateCoolOffTime' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("updateCoolOffTime", "(Ljava/lang/String;I)Z", "GetUpdateCoolOffTime_Ljava_lang_String_IHandler")]
		public virtual unsafe bool UpdateCoolOffTime (string p0, int p1)
		{
			if (id_updateCoolOffTime_Ljava_lang_String_I == IntPtr.Zero)
				id_updateCoolOffTime_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "updateCoolOffTime", "(Ljava/lang/String;I)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_updateCoolOffTime_Ljava_lang_String_I, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateCoolOffTime", "(Ljava/lang/String;I)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_updateLastConnectAttemptTime_Lcom_qcl_vh_content_MedicalDevice_J;
#pragma warning disable 0169
		static Delegate GetUpdateLastConnectAttemptTime_Lcom_qcl_vh_content_MedicalDevice_JHandler ()
		{
			if (cb_updateLastConnectAttemptTime_Lcom_qcl_vh_content_MedicalDevice_J == null)
				cb_updateLastConnectAttemptTime_Lcom_qcl_vh_content_MedicalDevice_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long, bool>) n_UpdateLastConnectAttemptTime_Lcom_qcl_vh_content_MedicalDevice_J);
			return cb_updateLastConnectAttemptTime_Lcom_qcl_vh_content_MedicalDevice_J;
		}

		static bool n_UpdateLastConnectAttemptTime_Lcom_qcl_vh_content_MedicalDevice_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			global::Com.Qcl.VH.Content.DeviceManager __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.DeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Qcl.VH.Content.MedicalDevice p0 = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.MedicalDevice> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.UpdateLastConnectAttemptTime (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_updateLastConnectAttemptTime_Lcom_qcl_vh_content_MedicalDevice_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='DeviceManager']/method[@name='updateLastConnectAttemptTime' and count(parameter)=2 and parameter[1][@type='com.qcl.vh.content.MedicalDevice'] and parameter[2][@type='long']]"
		[Register ("updateLastConnectAttemptTime", "(Lcom/qcl/vh/content/MedicalDevice;J)Z", "GetUpdateLastConnectAttemptTime_Lcom_qcl_vh_content_MedicalDevice_JHandler")]
		public virtual unsafe bool UpdateLastConnectAttemptTime (global::Com.Qcl.VH.Content.MedicalDevice p0, long p1)
		{
			if (id_updateLastConnectAttemptTime_Lcom_qcl_vh_content_MedicalDevice_J == IntPtr.Zero)
				id_updateLastConnectAttemptTime_Lcom_qcl_vh_content_MedicalDevice_J = JNIEnv.GetMethodID (class_ref, "updateLastConnectAttemptTime", "(Lcom/qcl/vh/content/MedicalDevice;J)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_updateLastConnectAttemptTime_Lcom_qcl_vh_content_MedicalDevice_J, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateLastConnectAttemptTime", "(Lcom/qcl/vh/content/MedicalDevice;J)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_updateLastReadingTime_Lcom_qcl_vh_content_MedicalDevice_JZ;
#pragma warning disable 0169
		static Delegate GetUpdateLastReadingTime_Lcom_qcl_vh_content_MedicalDevice_JZHandler ()
		{
			if (cb_updateLastReadingTime_Lcom_qcl_vh_content_MedicalDevice_JZ == null)
				cb_updateLastReadingTime_Lcom_qcl_vh_content_MedicalDevice_JZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long, bool, bool>) n_UpdateLastReadingTime_Lcom_qcl_vh_content_MedicalDevice_JZ);
			return cb_updateLastReadingTime_Lcom_qcl_vh_content_MedicalDevice_JZ;
		}

		static bool n_UpdateLastReadingTime_Lcom_qcl_vh_content_MedicalDevice_JZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, bool p2)
		{
			global::Com.Qcl.VH.Content.DeviceManager __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.DeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Qcl.VH.Content.MedicalDevice p0 = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.MedicalDevice> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.UpdateLastReadingTime (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_updateLastReadingTime_Lcom_qcl_vh_content_MedicalDevice_JZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='DeviceManager']/method[@name='updateLastReadingTime' and count(parameter)=3 and parameter[1][@type='com.qcl.vh.content.MedicalDevice'] and parameter[2][@type='long'] and parameter[3][@type='boolean']]"
		[Register ("updateLastReadingTime", "(Lcom/qcl/vh/content/MedicalDevice;JZ)Z", "GetUpdateLastReadingTime_Lcom_qcl_vh_content_MedicalDevice_JZHandler")]
		public virtual unsafe bool UpdateLastReadingTime (global::Com.Qcl.VH.Content.MedicalDevice p0, long p1, bool p2)
		{
			if (id_updateLastReadingTime_Lcom_qcl_vh_content_MedicalDevice_JZ == IntPtr.Zero)
				id_updateLastReadingTime_Lcom_qcl_vh_content_MedicalDevice_JZ = JNIEnv.GetMethodID (class_ref, "updateLastReadingTime", "(Lcom/qcl/vh/content/MedicalDevice;JZ)Z");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_updateLastReadingTime_Lcom_qcl_vh_content_MedicalDevice_JZ, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateLastReadingTime", "(Lcom/qcl/vh/content/MedicalDevice;JZ)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_updateLastSeenTime_Lcom_qcl_vh_content_MedicalDevice_JZ;
#pragma warning disable 0169
		static Delegate GetUpdateLastSeenTime_Lcom_qcl_vh_content_MedicalDevice_JZHandler ()
		{
			if (cb_updateLastSeenTime_Lcom_qcl_vh_content_MedicalDevice_JZ == null)
				cb_updateLastSeenTime_Lcom_qcl_vh_content_MedicalDevice_JZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long, bool, bool>) n_UpdateLastSeenTime_Lcom_qcl_vh_content_MedicalDevice_JZ);
			return cb_updateLastSeenTime_Lcom_qcl_vh_content_MedicalDevice_JZ;
		}

		static bool n_UpdateLastSeenTime_Lcom_qcl_vh_content_MedicalDevice_JZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, bool p2)
		{
			global::Com.Qcl.VH.Content.DeviceManager __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.DeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Qcl.VH.Content.MedicalDevice p0 = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.MedicalDevice> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.UpdateLastSeenTime (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_updateLastSeenTime_Lcom_qcl_vh_content_MedicalDevice_JZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='DeviceManager']/method[@name='updateLastSeenTime' and count(parameter)=3 and parameter[1][@type='com.qcl.vh.content.MedicalDevice'] and parameter[2][@type='long'] and parameter[3][@type='boolean']]"
		[Register ("updateLastSeenTime", "(Lcom/qcl/vh/content/MedicalDevice;JZ)Z", "GetUpdateLastSeenTime_Lcom_qcl_vh_content_MedicalDevice_JZHandler")]
		public virtual unsafe bool UpdateLastSeenTime (global::Com.Qcl.VH.Content.MedicalDevice p0, long p1, bool p2)
		{
			if (id_updateLastSeenTime_Lcom_qcl_vh_content_MedicalDevice_JZ == IntPtr.Zero)
				id_updateLastSeenTime_Lcom_qcl_vh_content_MedicalDevice_JZ = JNIEnv.GetMethodID (class_ref, "updateLastSeenTime", "(Lcom/qcl/vh/content/MedicalDevice;JZ)Z");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_updateLastSeenTime_Lcom_qcl_vh_content_MedicalDevice_JZ, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateLastSeenTime", "(Lcom/qcl/vh/content/MedicalDevice;JZ)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_updateLastSetDateTime_Lcom_qcl_vh_content_MedicalDevice_J;
#pragma warning disable 0169
		static Delegate GetUpdateLastSetDateTime_Lcom_qcl_vh_content_MedicalDevice_JHandler ()
		{
			if (cb_updateLastSetDateTime_Lcom_qcl_vh_content_MedicalDevice_J == null)
				cb_updateLastSetDateTime_Lcom_qcl_vh_content_MedicalDevice_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long, bool>) n_UpdateLastSetDateTime_Lcom_qcl_vh_content_MedicalDevice_J);
			return cb_updateLastSetDateTime_Lcom_qcl_vh_content_MedicalDevice_J;
		}

		static bool n_UpdateLastSetDateTime_Lcom_qcl_vh_content_MedicalDevice_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			global::Com.Qcl.VH.Content.DeviceManager __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.DeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Qcl.VH.Content.MedicalDevice p0 = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.MedicalDevice> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.UpdateLastSetDateTime (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_updateLastSetDateTime_Lcom_qcl_vh_content_MedicalDevice_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='DeviceManager']/method[@name='updateLastSetDateTime' and count(parameter)=2 and parameter[1][@type='com.qcl.vh.content.MedicalDevice'] and parameter[2][@type='long']]"
		[Register ("updateLastSetDateTime", "(Lcom/qcl/vh/content/MedicalDevice;J)Z", "GetUpdateLastSetDateTime_Lcom_qcl_vh_content_MedicalDevice_JHandler")]
		public virtual unsafe bool UpdateLastSetDateTime (global::Com.Qcl.VH.Content.MedicalDevice p0, long p1)
		{
			if (id_updateLastSetDateTime_Lcom_qcl_vh_content_MedicalDevice_J == IntPtr.Zero)
				id_updateLastSetDateTime_Lcom_qcl_vh_content_MedicalDevice_J = JNIEnv.GetMethodID (class_ref, "updateLastSetDateTime", "(Lcom/qcl/vh/content/MedicalDevice;J)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_updateLastSetDateTime_Lcom_qcl_vh_content_MedicalDevice_J, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateLastSetDateTime", "(Lcom/qcl/vh/content/MedicalDevice;J)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_updateLastSuccessfulDisconnectTime_Lcom_qcl_vh_content_MedicalDevice_JZ;
#pragma warning disable 0169
		static Delegate GetUpdateLastSuccessfulDisconnectTime_Lcom_qcl_vh_content_MedicalDevice_JZHandler ()
		{
			if (cb_updateLastSuccessfulDisconnectTime_Lcom_qcl_vh_content_MedicalDevice_JZ == null)
				cb_updateLastSuccessfulDisconnectTime_Lcom_qcl_vh_content_MedicalDevice_JZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long, bool, bool>) n_UpdateLastSuccessfulDisconnectTime_Lcom_qcl_vh_content_MedicalDevice_JZ);
			return cb_updateLastSuccessfulDisconnectTime_Lcom_qcl_vh_content_MedicalDevice_JZ;
		}

		static bool n_UpdateLastSuccessfulDisconnectTime_Lcom_qcl_vh_content_MedicalDevice_JZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, bool p2)
		{
			global::Com.Qcl.VH.Content.DeviceManager __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.DeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Qcl.VH.Content.MedicalDevice p0 = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.MedicalDevice> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.UpdateLastSuccessfulDisconnectTime (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_updateLastSuccessfulDisconnectTime_Lcom_qcl_vh_content_MedicalDevice_JZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='DeviceManager']/method[@name='updateLastSuccessfulDisconnectTime' and count(parameter)=3 and parameter[1][@type='com.qcl.vh.content.MedicalDevice'] and parameter[2][@type='long'] and parameter[3][@type='boolean']]"
		[Register ("updateLastSuccessfulDisconnectTime", "(Lcom/qcl/vh/content/MedicalDevice;JZ)Z", "GetUpdateLastSuccessfulDisconnectTime_Lcom_qcl_vh_content_MedicalDevice_JZHandler")]
		public virtual unsafe bool UpdateLastSuccessfulDisconnectTime (global::Com.Qcl.VH.Content.MedicalDevice p0, long p1, bool p2)
		{
			if (id_updateLastSuccessfulDisconnectTime_Lcom_qcl_vh_content_MedicalDevice_JZ == IntPtr.Zero)
				id_updateLastSuccessfulDisconnectTime_Lcom_qcl_vh_content_MedicalDevice_JZ = JNIEnv.GetMethodID (class_ref, "updateLastSuccessfulDisconnectTime", "(Lcom/qcl/vh/content/MedicalDevice;JZ)Z");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_updateLastSuccessfulDisconnectTime_Lcom_qcl_vh_content_MedicalDevice_JZ, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateLastSuccessfulDisconnectTime", "(Lcom/qcl/vh/content/MedicalDevice;JZ)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_updateLastUnsuccessfulDisconnectTime_Lcom_qcl_vh_content_MedicalDevice_JZ;
#pragma warning disable 0169
		static Delegate GetUpdateLastUnsuccessfulDisconnectTime_Lcom_qcl_vh_content_MedicalDevice_JZHandler ()
		{
			if (cb_updateLastUnsuccessfulDisconnectTime_Lcom_qcl_vh_content_MedicalDevice_JZ == null)
				cb_updateLastUnsuccessfulDisconnectTime_Lcom_qcl_vh_content_MedicalDevice_JZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long, bool, bool>) n_UpdateLastUnsuccessfulDisconnectTime_Lcom_qcl_vh_content_MedicalDevice_JZ);
			return cb_updateLastUnsuccessfulDisconnectTime_Lcom_qcl_vh_content_MedicalDevice_JZ;
		}

		static bool n_UpdateLastUnsuccessfulDisconnectTime_Lcom_qcl_vh_content_MedicalDevice_JZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, bool p2)
		{
			global::Com.Qcl.VH.Content.DeviceManager __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.DeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Qcl.VH.Content.MedicalDevice p0 = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.MedicalDevice> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.UpdateLastUnsuccessfulDisconnectTime (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_updateLastUnsuccessfulDisconnectTime_Lcom_qcl_vh_content_MedicalDevice_JZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='DeviceManager']/method[@name='updateLastUnsuccessfulDisconnectTime' and count(parameter)=3 and parameter[1][@type='com.qcl.vh.content.MedicalDevice'] and parameter[2][@type='long'] and parameter[3][@type='boolean']]"
		[Register ("updateLastUnsuccessfulDisconnectTime", "(Lcom/qcl/vh/content/MedicalDevice;JZ)Z", "GetUpdateLastUnsuccessfulDisconnectTime_Lcom_qcl_vh_content_MedicalDevice_JZHandler")]
		public virtual unsafe bool UpdateLastUnsuccessfulDisconnectTime (global::Com.Qcl.VH.Content.MedicalDevice p0, long p1, bool p2)
		{
			if (id_updateLastUnsuccessfulDisconnectTime_Lcom_qcl_vh_content_MedicalDevice_JZ == IntPtr.Zero)
				id_updateLastUnsuccessfulDisconnectTime_Lcom_qcl_vh_content_MedicalDevice_JZ = JNIEnv.GetMethodID (class_ref, "updateLastUnsuccessfulDisconnectTime", "(Lcom/qcl/vh/content/MedicalDevice;JZ)Z");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_updateLastUnsuccessfulDisconnectTime_Lcom_qcl_vh_content_MedicalDevice_JZ, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateLastUnsuccessfulDisconnectTime", "(Lcom/qcl/vh/content/MedicalDevice;JZ)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_updateSensor_Lcom_qcl_vh_a_c_Ę_;
#pragma warning disable 0169
		static Delegate GetUpdateSensor_Lcom_qcl_vh_a_c_Ę_Handler ()
		{
			if (cb_updateSensor_Lcom_qcl_vh_a_c_Ę_ == null)
				cb_updateSensor_Lcom_qcl_vh_a_c_Ę_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UpdateSensor_Lcom_qcl_vh_a_c_Ę_);
			return cb_updateSensor_Lcom_qcl_vh_a_c_Ę_;
		}

		static void n_UpdateSensor_Lcom_qcl_vh_a_c_Ę_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Qcl.VH.Content.DeviceManager __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.DeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Qcl.VH.A.C.Ę p0 = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.A.C.Ę> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UpdateSensor (p0);
		}
#pragma warning restore 0169

		static IntPtr id_updateSensor_Lcom_qcl_vh_a_c_Ę_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='DeviceManager']/method[@name='updateSensor' and count(parameter)=1 and parameter[1][@type='com.qcl.vh.a.c.Ę']]"
		[Register ("updateSensor", "(Lcom/qcl/vh/a/c/Ę;)V", "GetUpdateSensor_Lcom_qcl_vh_a_c_Ę_Handler")]
		public virtual unsafe void UpdateSensor (global::Com.Qcl.VH.A.C.Ę p0)
		{
			if (id_updateSensor_Lcom_qcl_vh_a_c_Ę_ == IntPtr.Zero)
				id_updateSensor_Lcom_qcl_vh_a_c_Ę_ = JNIEnv.GetMethodID (class_ref, "updateSensor", "(Lcom/qcl/vh/a/c/Ę;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_updateSensor_Lcom_qcl_vh_a_c_Ę_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateSensor", "(Lcom/qcl/vh/a/c/Ę;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_updateSensorState_Ljava_lang_String_Lcom_qcl_vh_a_c_廅_;
#pragma warning disable 0169
		static Delegate GetUpdateSensorState_Ljava_lang_String_Lcom_qcl_vh_a_c_廅_Handler ()
		{
			if (cb_updateSensorState_Ljava_lang_String_Lcom_qcl_vh_a_c_廅_ == null)
				cb_updateSensorState_Ljava_lang_String_Lcom_qcl_vh_a_c_廅_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_UpdateSensorState_Ljava_lang_String_Lcom_qcl_vh_a_c_廅_);
			return cb_updateSensorState_Ljava_lang_String_Lcom_qcl_vh_a_c_廅_;
		}

		static bool n_UpdateSensorState_Ljava_lang_String_Lcom_qcl_vh_a_c_廅_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Qcl.VH.Content.DeviceManager __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.DeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Qcl.VH.A.C.廅 p1 = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.A.C.廅> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.UpdateSensorState (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_updateSensorState_Ljava_lang_String_Lcom_qcl_vh_a_c_廅_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='DeviceManager']/method[@name='updateSensorState' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.qcl.vh.a.c.廅']]"
		[Register ("updateSensorState", "(Ljava/lang/String;Lcom/qcl/vh/a/c/廅;)Z", "GetUpdateSensorState_Ljava_lang_String_Lcom_qcl_vh_a_c_廅_Handler")]
		public virtual unsafe bool UpdateSensorState (string p0, global::Com.Qcl.VH.A.C.廅 p1)
		{
			if (id_updateSensorState_Ljava_lang_String_Lcom_qcl_vh_a_c_廅_ == IntPtr.Zero)
				id_updateSensorState_Ljava_lang_String_Lcom_qcl_vh_a_c_廅_ = JNIEnv.GetMethodID (class_ref, "updateSensorState", "(Ljava/lang/String;Lcom/qcl/vh/a/c/廅;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_updateSensorState_Ljava_lang_String_Lcom_qcl_vh_a_c_廅_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateSensorState", "(Ljava/lang/String;Lcom/qcl/vh/a/c/廅;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_updateSensors_Ljava_util_Set_;
#pragma warning disable 0169
		static Delegate GetUpdateSensors_Ljava_util_Set_Handler ()
		{
			if (cb_updateSensors_Ljava_util_Set_ == null)
				cb_updateSensors_Ljava_util_Set_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UpdateSensors_Ljava_util_Set_);
			return cb_updateSensors_Ljava_util_Set_;
		}

		static void n_UpdateSensors_Ljava_util_Set_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Qcl.VH.Content.DeviceManager __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.DeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaSet<global::Com.Qcl.VH.A.C.Ę>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UpdateSensors (p0);
		}
#pragma warning restore 0169

		static IntPtr id_updateSensors_Ljava_util_Set_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='DeviceManager']/method[@name='updateSensors' and count(parameter)=1 and parameter[1][@type='java.util.Set&lt;com.qcl.vh.a.c.Ę&gt;']]"
		[Register ("updateSensors", "(Ljava/util/Set;)V", "GetUpdateSensors_Ljava_util_Set_Handler")]
		public virtual unsafe void UpdateSensors (global::System.Collections.Generic.ICollection<global::Com.Qcl.VH.A.C.Ę> p0)
		{
			if (id_updateSensors_Ljava_util_Set_ == IntPtr.Zero)
				id_updateSensors_Ljava_util_Set_ = JNIEnv.GetMethodID (class_ref, "updateSensors", "(Ljava/util/Set;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaSet<global::Com.Qcl.VH.A.C.Ę>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_updateSensors_Ljava_util_Set_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateSensors", "(Ljava/util/Set;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
