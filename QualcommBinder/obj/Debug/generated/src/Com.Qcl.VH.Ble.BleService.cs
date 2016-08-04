using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.Ble {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BleService']"
	[global::Android.Runtime.Register ("com/qcl/vh/ble/BleService", DoNotGenerateAcw=true)]
	public partial class BleService : global::Android.App.Service {


		static IntPtr mMainHandler_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BleService']/field[@name='mMainHandler']"
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

		static IntPtr mWorkerHandler_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BleService']/field[@name='mWorkerHandler']"
		[Register ("mWorkerHandler")]
		protected global::Android.OS.Handler MWorkerHandler {
			get {
				if (mWorkerHandler_jfieldId == IntPtr.Zero)
					mWorkerHandler_jfieldId = JNIEnv.GetFieldID (class_ref, "mWorkerHandler", "Landroid/os/Handler;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mWorkerHandler_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mWorkerHandler_jfieldId == IntPtr.Zero)
					mWorkerHandler_jfieldId = JNIEnv.GetFieldID (class_ref, "mWorkerHandler", "Landroid/os/Handler;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, mWorkerHandler_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr sStarted_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BleService']/field[@name='sStarted']"
		[Register ("sStarted")]
		protected static bool SStarted {
			get {
				if (sStarted_jfieldId == IntPtr.Zero)
					sStarted_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "sStarted", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, sStarted_jfieldId);
			}
			set {
				if (sStarted_jfieldId == IntPtr.Zero)
					sStarted_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "sStarted", "Z");
				try {
					JNIEnv.SetStaticField (class_ref, sStarted_jfieldId, value);
				} finally {
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BleService.If']"
		[global::Android.Runtime.Register ("com/qcl/vh/ble/BleService$If", DoNotGenerateAcw=true)]
		public partial class If : global::Android.Database.ContentObserver {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/qcl/vh/ble/BleService$If", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (If); }
			}

			protected If (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_qcl_vh_ble_BleService_Landroid_os_Handler_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BleService.If']/constructor[@name='BleService.If' and count(parameter)=2 and parameter[1][@type='com.qcl.vh.ble.BleService'] and parameter[2][@type='android.os.Handler']]"
			[Register (".ctor", "(Lcom/qcl/vh/ble/BleService;Landroid/os/Handler;)V", "")]
			public unsafe If (global::Com.Qcl.VH.Ble.BleService __self, global::Android.OS.Handler p1)
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

					if (id_ctor_Lcom_qcl_vh_ble_BleService_Landroid_os_Handler_ == IntPtr.Zero)
						id_ctor_Lcom_qcl_vh_ble_BleService_Landroid_os_Handler_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/qcl/vh/ble/BleService;Landroid/os/Handler;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_qcl_vh_ble_BleService_Landroid_os_Handler_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_qcl_vh_ble_BleService_Landroid_os_Handler_, __args);
				} finally {
				}
			}

			static IntPtr id_onChange_Z;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BleService.If']/method[@name='onChange' and count(parameter)=1 and parameter[1][@type='boolean']]"
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BleService.iF']"
		[global::Android.Runtime.Register ("com/qcl/vh/ble/BleService$iF", DoNotGenerateAcw=true)]
		public partial class IF : global::Java.Lang.Object {

			// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BleService.iF.鷭']"
			[global::Android.Runtime.Register ("com/qcl/vh/ble/BleService$iF$鷭", DoNotGenerateAcw=true)]
			public sealed partial class 鷭 : global::Java.Lang.Enum {


				static IntPtr ȃ_jfieldId;

				// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BleService.iF.鷭']/field[@name='ȃ']"
				[Register ("ȃ")]
				public static global::Com.Qcl.VH.Ble.BleService.IF.鷭 Ȃ {
					get {
						if (ȃ_jfieldId == IntPtr.Zero)
							ȃ_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ȃ", "Lcom/qcl/vh/ble/BleService$iF$鷭;");
						IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ȃ_jfieldId);
						return global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Ble.BleService.IF.鷭> (__ret, JniHandleOwnership.TransferLocalRef);
					}
				}

				static IntPtr ˮ͈_jfieldId;

				// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BleService.iF.鷭']/field[@name='ˮ͈']"
				[Register ("ˮ͈")]
				public static global::Com.Qcl.VH.Ble.BleService.IF.鷭 ˮ͈ {
					get {
						if (ˮ͈_jfieldId == IntPtr.Zero)
							ˮ͈_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ˮ͈", "Lcom/qcl/vh/ble/BleService$iF$鷭;");
						IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ˮ͈_jfieldId);
						return global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Ble.BleService.IF.鷭> (__ret, JniHandleOwnership.TransferLocalRef);
					}
				}

				static IntPtr 櫯_jfieldId;

				// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BleService.iF.鷭']/field[@name='櫯']"
				[Register ("櫯")]
				public static global::Com.Qcl.VH.Ble.BleService.IF.鷭 櫯 {
					get {
						if (櫯_jfieldId == IntPtr.Zero)
							櫯_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "櫯", "Lcom/qcl/vh/ble/BleService$iF$鷭;");
						IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, 櫯_jfieldId);
						return global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Ble.BleService.IF.鷭> (__ret, JniHandleOwnership.TransferLocalRef);
					}
				}

				static IntPtr 鷭_jfieldId;

				// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BleService.iF.鷭']/field[@name='鷭']"
				[Register ("鷭")]
				public static global::Com.Qcl.VH.Ble.BleService.IF.鷭 鷭 {
					get {
						if (鷭_jfieldId == IntPtr.Zero)
							鷭_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "鷭", "Lcom/qcl/vh/ble/BleService$iF$鷭;");
						IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, 鷭_jfieldId);
						return global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Ble.BleService.IF.鷭> (__ret, JniHandleOwnership.TransferLocalRef);
					}
				}
				internal static IntPtr java_class_handle;
				internal static IntPtr class_ref {
					get {
						return JNIEnv.FindClass ("com/qcl/vh/ble/BleService$iF$鷭", ref java_class_handle);
					}
				}

				protected override IntPtr ThresholdClass {
					get { return class_ref; }
				}

				protected override global::System.Type ThresholdType {
					get { return typeof (鷭); }
				}

				internal 鷭 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			}

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/qcl/vh/ble/BleService$iF", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IF); }
			}

			protected IF (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_toString;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BleService.iF']/method[@name='toString' and count(parameter)=0]"
			[Register ("toString", "()Ljava/lang/String;", "")]
			public override sealed unsafe string ToString ()
			{
				if (id_toString == IntPtr.Zero)
					id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_toString), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BleService.if']"
		[global::Android.Runtime.Register ("com/qcl/vh/ble/BleService$if", DoNotGenerateAcw=true)]
		public partial class If : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/qcl/vh/ble/BleService$if", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (If); }
			}

			protected If (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Landroid_bluetooth_BluetoothGatt_Ljava_lang_Runnable_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BleService.if']/constructor[@name='BleService.if' and count(parameter)=2 and parameter[1][@type='android.bluetooth.BluetoothGatt'] and parameter[2][@type='java.lang.Runnable']]"
			[Register (".ctor", "(Landroid/bluetooth/BluetoothGatt;Ljava/lang/Runnable;)V", "")]
			public unsafe If (global::Android.Bluetooth.BluetoothGatt p0, global::Java.Lang.IRunnable p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					if (GetType () != typeof (If)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/bluetooth/BluetoothGatt;Ljava/lang/Runnable;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/bluetooth/BluetoothGatt;Ljava/lang/Runnable;)V", __args);
						return;
					}

					if (id_ctor_Landroid_bluetooth_BluetoothGatt_Ljava_lang_Runnable_ == IntPtr.Zero)
						id_ctor_Landroid_bluetooth_BluetoothGatt_Ljava_lang_Runnable_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/bluetooth/BluetoothGatt;Ljava/lang/Runnable;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_bluetooth_BluetoothGatt_Ljava_lang_Runnable_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_bluetooth_BluetoothGatt_Ljava_lang_Runnable_, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BleService.ˮ͈']"
		[global::Android.Runtime.Register ("com/qcl/vh/ble/BleService$ˮ͈", DoNotGenerateAcw=true)]
		public partial class ˮ͈ : global::Android.Bluetooth.BluetoothGattCallback {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/qcl/vh/ble/BleService$ˮ͈", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ˮ͈); }
			}

			protected ˮ͈ (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_qcl_vh_ble_BleService_Landroid_content_Context_Lcom_qcl_vh_content_MedicalDevice_Lcom_qcl_vh_ble_BleService_櫯_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BleService.ˮ͈']/constructor[@name='BleService.ˮ͈' and count(parameter)=4 and parameter[1][@type='com.qcl.vh.ble.BleService'] and parameter[2][@type='android.content.Context'] and parameter[3][@type='com.qcl.vh.content.MedicalDevice'] and parameter[4][@type='com.qcl.vh.ble.BleService.櫯']]"
			[Register (".ctor", "(Lcom/qcl/vh/ble/BleService;Landroid/content/Context;Lcom/qcl/vh/content/MedicalDevice;Lcom/qcl/vh/ble/BleService$櫯;)V", "")]
			public unsafe ˮ͈ (global::Com.Qcl.VH.Ble.BleService __self, global::Android.Content.Context p1, global::Com.Qcl.VH.Content.MedicalDevice p2, global::Com.Qcl.VH.Ble.BleService.櫯 p3)
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
					if (GetType () != typeof (ˮ͈)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/content/Context;Lcom/qcl/vh/content/MedicalDevice;Lcom/qcl/vh/ble/BleService$櫯;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/content/Context;Lcom/qcl/vh/content/MedicalDevice;Lcom/qcl/vh/ble/BleService$櫯;)V", __args);
						return;
					}

					if (id_ctor_Lcom_qcl_vh_ble_BleService_Landroid_content_Context_Lcom_qcl_vh_content_MedicalDevice_Lcom_qcl_vh_ble_BleService_櫯_ == IntPtr.Zero)
						id_ctor_Lcom_qcl_vh_ble_BleService_Landroid_content_Context_Lcom_qcl_vh_content_MedicalDevice_Lcom_qcl_vh_ble_BleService_櫯_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/qcl/vh/ble/BleService;Landroid/content/Context;Lcom/qcl/vh/content/MedicalDevice;Lcom/qcl/vh/ble/BleService$櫯;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_qcl_vh_ble_BleService_Landroid_content_Context_Lcom_qcl_vh_content_MedicalDevice_Lcom_qcl_vh_ble_BleService_櫯_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_qcl_vh_ble_BleService_Landroid_content_Context_Lcom_qcl_vh_content_MedicalDevice_Lcom_qcl_vh_ble_BleService_櫯_, __args);
				} finally {
				}
			}

			static Delegate cb_鷭_Landroid_bluetooth_BluetoothGatt_II;
#pragma warning disable 0169
			static Delegate Get鷭_Landroid_bluetooth_BluetoothGatt_IIHandler ()
			{
				if (cb_鷭_Landroid_bluetooth_BluetoothGatt_II == null)
					cb_鷭_Landroid_bluetooth_BluetoothGatt_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_鷭_Landroid_bluetooth_BluetoothGatt_II);
				return cb_鷭_Landroid_bluetooth_BluetoothGatt_II;
			}

			static void n_鷭_Landroid_bluetooth_BluetoothGatt_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
			{
				global::Com.Qcl.VH.Ble.BleService.ˮ͈ __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Ble.BleService.ˮ͈> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Bluetooth.BluetoothGatt p0 = global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothGatt> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.鷭 (p0, p1, p2);
			}
#pragma warning restore 0169

			static IntPtr id_鷭_Landroid_bluetooth_BluetoothGatt_II;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BleService.ˮ͈']/method[@name='鷭' and count(parameter)=3 and parameter[1][@type='android.bluetooth.BluetoothGatt'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("鷭", "(Landroid/bluetooth/BluetoothGatt;II)V", "Get鷭_Landroid_bluetooth_BluetoothGatt_IIHandler")]
			protected virtual unsafe void 鷭 (global::Android.Bluetooth.BluetoothGatt p0, int p1, int p2)
			{
				if (id_鷭_Landroid_bluetooth_BluetoothGatt_II == IntPtr.Zero)
					id_鷭_Landroid_bluetooth_BluetoothGatt_II = JNIEnv.GetMethodID (class_ref, "鷭", "(Landroid/bluetooth/BluetoothGatt;II)V");
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_鷭_Landroid_bluetooth_BluetoothGatt_II, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "鷭", "(Landroid/bluetooth/BluetoothGatt;II)V"), __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BleService.櫯']"
		[global::Android.Runtime.Register ("com/qcl/vh/ble/BleService$櫯", DoNotGenerateAcw=true)]
		public partial class 櫯 : global::Java.Lang.Thread {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/qcl/vh/ble/BleService$櫯", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (櫯); }
			}

			protected 櫯 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_lang_String_I;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BleService.櫯']/constructor[@name='BleService.櫯' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
			[Register (".ctor", "(Ljava/lang/String;I)V", "")]
			public unsafe 櫯 (string p0, int p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (p1);
					if (GetType () != typeof (櫯)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;I)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;I)V", __args);
						return;
					}

					if (id_ctor_Ljava_lang_String_I == IntPtr.Zero)
						id_ctor_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;I)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_I, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_I, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_run;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BleService.櫯']/method[@name='run' and count(parameter)=0]"
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

			static IntPtr id_鷭;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BleService.櫯']/method[@name='鷭' and count(parameter)=0]"
			[Register ("鷭", "()V", "")]
			public unsafe void 鷭 ()
			{
				if (id_鷭 == IntPtr.Zero)
					id_鷭 = JNIEnv.GetMethodID (class_ref, "鷭", "()V");
				try {
					JNIEnv.CallVoidMethod  (Handle, id_鷭);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BleService.鷭']"
		[global::Android.Runtime.Register ("com/qcl/vh/ble/BleService$鷭", DoNotGenerateAcw=true)]
		public partial class 鷭 : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/qcl/vh/ble/BleService$鷭", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (鷭); }
			}

			protected 鷭 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_ILcom_qcl_vh_ble_BleService_if_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BleService.鷭']/constructor[@name='BleService.鷭' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.qcl.vh.ble.BleService.if']]"
			[Register (".ctor", "(ILcom/qcl/vh/ble/BleService$if;)V", "")]
			public unsafe 鷭 (int p0, global::Com.Qcl.VH.Ble.BleService.If p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					if (GetType () != typeof (鷭)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(ILcom/qcl/vh/ble/BleService$if;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(ILcom/qcl/vh/ble/BleService$if;)V", __args);
						return;
					}

					if (id_ctor_ILcom_qcl_vh_ble_BleService_if_ == IntPtr.Zero)
						id_ctor_ILcom_qcl_vh_ble_BleService_if_ = JNIEnv.GetMethodID (class_ref, "<init>", "(ILcom/qcl/vh/ble/BleService$if;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_ILcom_qcl_vh_ble_BleService_if_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_ILcom_qcl_vh_ble_BleService_if_, __args);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qcl/vh/ble/BleService", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BleService); }
		}

		protected BleService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BleService']/constructor[@name='BleService' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BleService ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (BleService)) {
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

		static Delegate cb_getHandler;
#pragma warning disable 0169
		static Delegate GetGetHandlerHandler ()
		{
			if (cb_getHandler == null)
				cb_getHandler = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHandler);
			return cb_getHandler;
		}

		static IntPtr n_GetHandler (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Qcl.VH.Ble.BleService __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Ble.BleService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Handler);
		}
#pragma warning restore 0169

		static IntPtr id_getHandler;
		protected virtual unsafe global::Android.OS.Handler Handler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BleService']/method[@name='getHandler' and count(parameter)=0]"
			[Register ("getHandler", "()Landroid/os/Handler;", "GetGetHandlerHandler")]
			get {
				if (id_getHandler == IntPtr.Zero)
					id_getHandler = JNIEnv.GetMethodID (class_ref, "getHandler", "()Landroid/os/Handler;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (JNIEnv.CallObjectMethod  (Handle, id_getHandler), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHandler", "()Landroid/os/Handler;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isReconnectAfterCleanupNeeded;
#pragma warning disable 0169
		static Delegate GetIsReconnectAfterCleanupNeededHandler ()
		{
			if (cb_isReconnectAfterCleanupNeeded == null)
				cb_isReconnectAfterCleanupNeeded = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsReconnectAfterCleanupNeeded);
			return cb_isReconnectAfterCleanupNeeded;
		}

		static bool n_IsReconnectAfterCleanupNeeded (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Qcl.VH.Ble.BleService __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Ble.BleService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsReconnectAfterCleanupNeeded;
		}
#pragma warning restore 0169

		static IntPtr id_isReconnectAfterCleanupNeeded;
		protected virtual unsafe bool IsReconnectAfterCleanupNeeded {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BleService']/method[@name='isReconnectAfterCleanupNeeded' and count(parameter)=0]"
			[Register ("isReconnectAfterCleanupNeeded", "()Z", "GetIsReconnectAfterCleanupNeededHandler")]
			get {
				if (id_isReconnectAfterCleanupNeeded == IntPtr.Zero)
					id_isReconnectAfterCleanupNeeded = JNIEnv.GetMethodID (class_ref, "isReconnectAfterCleanupNeeded", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isReconnectAfterCleanupNeeded);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isReconnectAfterCleanupNeeded", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isScanning;
#pragma warning disable 0169
		static Delegate GetIsScanningHandler ()
		{
			if (cb_isScanning == null)
				cb_isScanning = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsScanning);
			return cb_isScanning;
		}

		static bool n_IsScanning (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Qcl.VH.Ble.BleService __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Ble.BleService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Scanning;
		}
#pragma warning restore 0169

		static Delegate cb_setScanning_Z;
#pragma warning disable 0169
		static Delegate GetSetScanning_ZHandler ()
		{
			if (cb_setScanning_Z == null)
				cb_setScanning_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetScanning_Z);
			return cb_setScanning_Z;
		}

		static void n_SetScanning_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Qcl.VH.Ble.BleService __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Ble.BleService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Scanning = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isScanning;
		static IntPtr id_setScanning_Z;
		public virtual unsafe bool Scanning {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BleService']/method[@name='isScanning' and count(parameter)=0]"
			[Register ("isScanning", "()Z", "GetIsScanningHandler")]
			get {
				if (id_isScanning == IntPtr.Zero)
					id_isScanning = JNIEnv.GetMethodID (class_ref, "isScanning", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isScanning);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isScanning", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BleService']/method[@name='setScanning' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setScanning", "(Z)V", "GetSetScanning_ZHandler")]
			set {
				if (id_setScanning_Z == IntPtr.Zero)
					id_setScanning_Z = JNIEnv.GetMethodID (class_ref, "setScanning", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setScanning_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setScanning", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_cleanUpGattClient_Landroid_content_Context_Landroid_bluetooth_BluetoothGatt_ZZ;
#pragma warning disable 0169
		static Delegate GetCleanUpGattClient_Landroid_content_Context_Landroid_bluetooth_BluetoothGatt_ZZHandler ()
		{
			if (cb_cleanUpGattClient_Landroid_content_Context_Landroid_bluetooth_BluetoothGatt_ZZ == null)
				cb_cleanUpGattClient_Landroid_content_Context_Landroid_bluetooth_BluetoothGatt_ZZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, bool, bool>) n_CleanUpGattClient_Landroid_content_Context_Landroid_bluetooth_BluetoothGatt_ZZ);
			return cb_cleanUpGattClient_Landroid_content_Context_Landroid_bluetooth_BluetoothGatt_ZZ;
		}

		static void n_CleanUpGattClient_Landroid_content_Context_Landroid_bluetooth_BluetoothGatt_ZZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, bool p2, bool p3)
		{
			global::Com.Qcl.VH.Ble.BleService __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Ble.BleService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Bluetooth.BluetoothGatt p1 = global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothGatt> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.CleanUpGattClient (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_cleanUpGattClient_Landroid_content_Context_Landroid_bluetooth_BluetoothGatt_ZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BleService']/method[@name='cleanUpGattClient' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.bluetooth.BluetoothGatt'] and parameter[3][@type='boolean'] and parameter[4][@type='boolean']]"
		[Register ("cleanUpGattClient", "(Landroid/content/Context;Landroid/bluetooth/BluetoothGatt;ZZ)V", "GetCleanUpGattClient_Landroid_content_Context_Landroid_bluetooth_BluetoothGatt_ZZHandler")]
		protected virtual unsafe void CleanUpGattClient (global::Android.Content.Context p0, global::Android.Bluetooth.BluetoothGatt p1, bool p2, bool p3)
		{
			if (id_cleanUpGattClient_Landroid_content_Context_Landroid_bluetooth_BluetoothGatt_ZZ == IntPtr.Zero)
				id_cleanUpGattClient_Landroid_content_Context_Landroid_bluetooth_BluetoothGatt_ZZ = JNIEnv.GetMethodID (class_ref, "cleanUpGattClient", "(Landroid/content/Context;Landroid/bluetooth/BluetoothGatt;ZZ)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_cleanUpGattClient_Landroid_content_Context_Landroid_bluetooth_BluetoothGatt_ZZ, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cleanUpGattClient", "(Landroid/content/Context;Landroid/bluetooth/BluetoothGatt;ZZ)V"), __args);
			} finally {
			}
		}

		static Delegate cb_closeOnMainThread_Landroid_content_Context_Landroid_bluetooth_BluetoothGatt_;
#pragma warning disable 0169
		static Delegate GetCloseOnMainThread_Landroid_content_Context_Landroid_bluetooth_BluetoothGatt_Handler ()
		{
			if (cb_closeOnMainThread_Landroid_content_Context_Landroid_bluetooth_BluetoothGatt_ == null)
				cb_closeOnMainThread_Landroid_content_Context_Landroid_bluetooth_BluetoothGatt_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_CloseOnMainThread_Landroid_content_Context_Landroid_bluetooth_BluetoothGatt_);
			return cb_closeOnMainThread_Landroid_content_Context_Landroid_bluetooth_BluetoothGatt_;
		}

		static void n_CloseOnMainThread_Landroid_content_Context_Landroid_bluetooth_BluetoothGatt_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Qcl.VH.Ble.BleService __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Ble.BleService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Bluetooth.BluetoothGatt p1 = global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothGatt> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.CloseOnMainThread (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_closeOnMainThread_Landroid_content_Context_Landroid_bluetooth_BluetoothGatt_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BleService']/method[@name='closeOnMainThread' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.bluetooth.BluetoothGatt']]"
		[Register ("closeOnMainThread", "(Landroid/content/Context;Landroid/bluetooth/BluetoothGatt;)V", "GetCloseOnMainThread_Landroid_content_Context_Landroid_bluetooth_BluetoothGatt_Handler")]
		public virtual unsafe void CloseOnMainThread (global::Android.Content.Context p0, global::Android.Bluetooth.BluetoothGatt p1)
		{
			if (id_closeOnMainThread_Landroid_content_Context_Landroid_bluetooth_BluetoothGatt_ == IntPtr.Zero)
				id_closeOnMainThread_Landroid_content_Context_Landroid_bluetooth_BluetoothGatt_ = JNIEnv.GetMethodID (class_ref, "closeOnMainThread", "(Landroid/content/Context;Landroid/bluetooth/BluetoothGatt;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_closeOnMainThread_Landroid_content_Context_Landroid_bluetooth_BluetoothGatt_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "closeOnMainThread", "(Landroid/content/Context;Landroid/bluetooth/BluetoothGatt;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_discoveryRequired;
#pragma warning disable 0169
		static Delegate GetDiscoveryRequiredHandler ()
		{
			if (cb_discoveryRequired == null)
				cb_discoveryRequired = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_DiscoveryRequired);
			return cb_discoveryRequired;
		}

		static bool n_DiscoveryRequired (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Qcl.VH.Ble.BleService __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Ble.BleService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DiscoveryRequired ();
		}
#pragma warning restore 0169

		static IntPtr id_discoveryRequired;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BleService']/method[@name='discoveryRequired' and count(parameter)=0]"
		[Register ("discoveryRequired", "()Z", "GetDiscoveryRequiredHandler")]
		protected virtual unsafe bool DiscoveryRequired ()
		{
			if (id_discoveryRequired == IntPtr.Zero)
				id_discoveryRequired = JNIEnv.GetMethodID (class_ref, "discoveryRequired", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_discoveryRequired);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "discoveryRequired", "()Z"));
			} finally {
			}
		}

		static IntPtr id_getBleServiceIntent_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BleService']/method[@name='getBleServiceIntent' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getBleServiceIntent", "(Landroid/content/Context;)Landroid/content/Intent;", "")]
		protected static unsafe global::Android.Content.Intent GetBleServiceIntent (global::Android.Content.Context p0)
		{
			if (id_getBleServiceIntent_Landroid_content_Context_ == IntPtr.Zero)
				id_getBleServiceIntent_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getBleServiceIntent", "(Landroid/content/Context;)Landroid/content/Intent;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Android.Content.Intent __ret = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getBleServiceIntent_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_initializeOnMainThread;
#pragma warning disable 0169
		static Delegate GetInitializeOnMainThreadHandler ()
		{
			if (cb_initializeOnMainThread == null)
				cb_initializeOnMainThread = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_InitializeOnMainThread);
			return cb_initializeOnMainThread;
		}

		static void n_InitializeOnMainThread (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Qcl.VH.Ble.BleService __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Ble.BleService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InitializeOnMainThread ();
		}
#pragma warning restore 0169

		static IntPtr id_initializeOnMainThread;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BleService']/method[@name='initializeOnMainThread' and count(parameter)=0]"
		[Register ("initializeOnMainThread", "()V", "GetInitializeOnMainThreadHandler")]
		protected virtual unsafe void InitializeOnMainThread ()
		{
			if (id_initializeOnMainThread == IntPtr.Zero)
				id_initializeOnMainThread = JNIEnv.GetMethodID (class_ref, "initializeOnMainThread", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_initializeOnMainThread);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "initializeOnMainThread", "()V"));
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
			global::Com.Qcl.VH.Ble.BleService __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Ble.BleService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnBind (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onBind_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BleService']/method[@name='onBind' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
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

		static Delegate cb_purgeQueuedTasks_Landroid_bluetooth_BluetoothGatt_;
#pragma warning disable 0169
		static Delegate GetPurgeQueuedTasks_Landroid_bluetooth_BluetoothGatt_Handler ()
		{
			if (cb_purgeQueuedTasks_Landroid_bluetooth_BluetoothGatt_ == null)
				cb_purgeQueuedTasks_Landroid_bluetooth_BluetoothGatt_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PurgeQueuedTasks_Landroid_bluetooth_BluetoothGatt_);
			return cb_purgeQueuedTasks_Landroid_bluetooth_BluetoothGatt_;
		}

		static void n_PurgeQueuedTasks_Landroid_bluetooth_BluetoothGatt_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Qcl.VH.Ble.BleService __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Ble.BleService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Bluetooth.BluetoothGatt p0 = global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothGatt> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PurgeQueuedTasks (p0);
		}
#pragma warning restore 0169

		static IntPtr id_purgeQueuedTasks_Landroid_bluetooth_BluetoothGatt_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BleService']/method[@name='purgeQueuedTasks' and count(parameter)=1 and parameter[1][@type='android.bluetooth.BluetoothGatt']]"
		[Register ("purgeQueuedTasks", "(Landroid/bluetooth/BluetoothGatt;)V", "GetPurgeQueuedTasks_Landroid_bluetooth_BluetoothGatt_Handler")]
		protected virtual unsafe void PurgeQueuedTasks (global::Android.Bluetooth.BluetoothGatt p0)
		{
			if (id_purgeQueuedTasks_Landroid_bluetooth_BluetoothGatt_ == IntPtr.Zero)
				id_purgeQueuedTasks_Landroid_bluetooth_BluetoothGatt_ = JNIEnv.GetMethodID (class_ref, "purgeQueuedTasks", "(Landroid/bluetooth/BluetoothGatt;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_purgeQueuedTasks_Landroid_bluetooth_BluetoothGatt_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "purgeQueuedTasks", "(Landroid/bluetooth/BluetoothGatt;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_scheduleConnectTimeout_Landroid_content_Context_Landroid_bluetooth_BluetoothGatt_Lcom_qcl_vh_content_MedicalDevice_;
#pragma warning disable 0169
		static Delegate GetScheduleConnectTimeout_Landroid_content_Context_Landroid_bluetooth_BluetoothGatt_Lcom_qcl_vh_content_MedicalDevice_Handler ()
		{
			if (cb_scheduleConnectTimeout_Landroid_content_Context_Landroid_bluetooth_BluetoothGatt_Lcom_qcl_vh_content_MedicalDevice_ == null)
				cb_scheduleConnectTimeout_Landroid_content_Context_Landroid_bluetooth_BluetoothGatt_Lcom_qcl_vh_content_MedicalDevice_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_ScheduleConnectTimeout_Landroid_content_Context_Landroid_bluetooth_BluetoothGatt_Lcom_qcl_vh_content_MedicalDevice_);
			return cb_scheduleConnectTimeout_Landroid_content_Context_Landroid_bluetooth_BluetoothGatt_Lcom_qcl_vh_content_MedicalDevice_;
		}

		static IntPtr n_ScheduleConnectTimeout_Landroid_content_Context_Landroid_bluetooth_BluetoothGatt_Lcom_qcl_vh_content_MedicalDevice_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Qcl.VH.Ble.BleService __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Ble.BleService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Bluetooth.BluetoothGatt p1 = global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothGatt> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Qcl.VH.Content.MedicalDevice p2 = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.MedicalDevice> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ScheduleConnectTimeout (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_scheduleConnectTimeout_Landroid_content_Context_Landroid_bluetooth_BluetoothGatt_Lcom_qcl_vh_content_MedicalDevice_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BleService']/method[@name='scheduleConnectTimeout' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.bluetooth.BluetoothGatt'] and parameter[3][@type='com.qcl.vh.content.MedicalDevice']]"
		[Register ("scheduleConnectTimeout", "(Landroid/content/Context;Landroid/bluetooth/BluetoothGatt;Lcom/qcl/vh/content/MedicalDevice;)Ljava/lang/Runnable;", "GetScheduleConnectTimeout_Landroid_content_Context_Landroid_bluetooth_BluetoothGatt_Lcom_qcl_vh_content_MedicalDevice_Handler")]
		protected virtual unsafe global::Java.Lang.IRunnable ScheduleConnectTimeout (global::Android.Content.Context p0, global::Android.Bluetooth.BluetoothGatt p1, global::Com.Qcl.VH.Content.MedicalDevice p2)
		{
			if (id_scheduleConnectTimeout_Landroid_content_Context_Landroid_bluetooth_BluetoothGatt_Lcom_qcl_vh_content_MedicalDevice_ == IntPtr.Zero)
				id_scheduleConnectTimeout_Landroid_content_Context_Landroid_bluetooth_BluetoothGatt_Lcom_qcl_vh_content_MedicalDevice_ = JNIEnv.GetMethodID (class_ref, "scheduleConnectTimeout", "(Landroid/content/Context;Landroid/bluetooth/BluetoothGatt;Lcom/qcl/vh/content/MedicalDevice;)Ljava/lang/Runnable;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				global::Java.Lang.IRunnable __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (JNIEnv.CallObjectMethod  (Handle, id_scheduleConnectTimeout_Landroid_content_Context_Landroid_bluetooth_BluetoothGatt_Lcom_qcl_vh_content_MedicalDevice_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "scheduleConnectTimeout", "(Landroid/content/Context;Landroid/bluetooth/BluetoothGatt;Lcom/qcl/vh/content/MedicalDevice;)Ljava/lang/Runnable;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_scheduleDiscovery;
#pragma warning disable 0169
		static Delegate GetScheduleDiscoveryHandler ()
		{
			if (cb_scheduleDiscovery == null)
				cb_scheduleDiscovery = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ScheduleDiscovery);
			return cb_scheduleDiscovery;
		}

		static void n_ScheduleDiscovery (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Qcl.VH.Ble.BleService __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Ble.BleService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ScheduleDiscovery ();
		}
#pragma warning restore 0169

		static IntPtr id_scheduleDiscovery;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BleService']/method[@name='scheduleDiscovery' and count(parameter)=0]"
		[Register ("scheduleDiscovery", "()V", "GetScheduleDiscoveryHandler")]
		protected virtual unsafe void ScheduleDiscovery ()
		{
			if (id_scheduleDiscovery == IntPtr.Zero)
				id_scheduleDiscovery = JNIEnv.GetMethodID (class_ref, "scheduleDiscovery", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_scheduleDiscovery);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "scheduleDiscovery", "()V"));
			} finally {
			}
		}

		static Delegate cb_startConnect;
#pragma warning disable 0169
		static Delegate GetStartConnectHandler ()
		{
			if (cb_startConnect == null)
				cb_startConnect = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StartConnect);
			return cb_startConnect;
		}

		static void n_StartConnect (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Qcl.VH.Ble.BleService __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Ble.BleService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartConnect ();
		}
#pragma warning restore 0169

		static IntPtr id_startConnect;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BleService']/method[@name='startConnect' and count(parameter)=0]"
		[Register ("startConnect", "()V", "GetStartConnectHandler")]
		protected virtual unsafe void StartConnect ()
		{
			if (id_startConnect == IntPtr.Zero)
				id_startConnect = JNIEnv.GetMethodID (class_ref, "startConnect", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_startConnect);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startConnect", "()V"));
			} finally {
			}
		}

		static Delegate cb_startDiscovery;
#pragma warning disable 0169
		static Delegate GetStartDiscoveryHandler ()
		{
			if (cb_startDiscovery == null)
				cb_startDiscovery = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StartDiscovery);
			return cb_startDiscovery;
		}

		static void n_StartDiscovery (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Qcl.VH.Ble.BleService __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Ble.BleService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartDiscovery ();
		}
#pragma warning restore 0169

		static IntPtr id_startDiscovery;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BleService']/method[@name='startDiscovery' and count(parameter)=0]"
		[Register ("startDiscovery", "()V", "GetStartDiscoveryHandler")]
		protected virtual unsafe void StartDiscovery ()
		{
			if (id_startDiscovery == IntPtr.Zero)
				id_startDiscovery = JNIEnv.GetMethodID (class_ref, "startDiscovery", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_startDiscovery);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startDiscovery", "()V"));
			} finally {
			}
		}

		static IntPtr id_startIfNotRunning_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BleService']/method[@name='startIfNotRunning' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("startIfNotRunning", "(Landroid/content/Context;)V", "")]
		public static unsafe void StartIfNotRunning (global::Android.Content.Context p0)
		{
			if (id_startIfNotRunning_Landroid_content_Context_ == IntPtr.Zero)
				id_startIfNotRunning_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "startIfNotRunning", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_startIfNotRunning_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_startPolling_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BleService']/method[@name='startPolling' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("startPolling", "(Landroid/content/Context;)V", "")]
		public static unsafe void StartPolling (global::Android.Content.Context p0)
		{
			if (id_startPolling_Landroid_content_Context_ == IntPtr.Zero)
				id_startPolling_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "startPolling", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_startPolling_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_stop_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BleService']/method[@name='stop' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
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

		static Delegate cb_stopAllConnectedGattClients;
#pragma warning disable 0169
		static Delegate GetStopAllConnectedGattClientsHandler ()
		{
			if (cb_stopAllConnectedGattClients == null)
				cb_stopAllConnectedGattClients = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StopAllConnectedGattClients);
			return cb_stopAllConnectedGattClients;
		}

		static void n_StopAllConnectedGattClients (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Qcl.VH.Ble.BleService __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Ble.BleService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopAllConnectedGattClients ();
		}
#pragma warning restore 0169

		static IntPtr id_stopAllConnectedGattClients;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BleService']/method[@name='stopAllConnectedGattClients' and count(parameter)=0]"
		[Register ("stopAllConnectedGattClients", "()V", "GetStopAllConnectedGattClientsHandler")]
		protected virtual unsafe void StopAllConnectedGattClients ()
		{
			if (id_stopAllConnectedGattClients == IntPtr.Zero)
				id_stopAllConnectedGattClients = JNIEnv.GetMethodID (class_ref, "stopAllConnectedGattClients", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_stopAllConnectedGattClients);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stopAllConnectedGattClients", "()V"));
			} finally {
			}
		}

		static Delegate cb_stopDiscovery;
#pragma warning disable 0169
		static Delegate GetStopDiscoveryHandler ()
		{
			if (cb_stopDiscovery == null)
				cb_stopDiscovery = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StopDiscovery);
			return cb_stopDiscovery;
		}

		static void n_StopDiscovery (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Qcl.VH.Ble.BleService __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Ble.BleService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopDiscovery ();
		}
#pragma warning restore 0169

		static IntPtr id_stopDiscovery;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BleService']/method[@name='stopDiscovery' and count(parameter)=0]"
		[Register ("stopDiscovery", "()V", "GetStopDiscoveryHandler")]
		protected virtual unsafe void StopDiscovery ()
		{
			if (id_stopDiscovery == IntPtr.Zero)
				id_stopDiscovery = JNIEnv.GetMethodID (class_ref, "stopDiscovery", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_stopDiscovery);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stopDiscovery", "()V"));
			} finally {
			}
		}

	}
}
