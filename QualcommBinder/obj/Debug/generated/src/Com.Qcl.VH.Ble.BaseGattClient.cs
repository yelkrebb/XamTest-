using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.Ble {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BaseGattClient']"
	[global::Android.Runtime.Register ("com/qcl/vh/ble/BaseGattClient", DoNotGenerateAcw=true)]
	public abstract partial class BaseGattClient : global::Java.Lang.Object, global::Com.Qcl.VH.Content.IContextAwareAdapter {


		static IntPtr ċ_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BaseGattClient']/field[@name='ċ']"
		[Register ("ċ")]
		protected static global::Java.Util.UUID Ċ {
			get {
				if (ċ_jfieldId == IntPtr.Zero)
					ċ_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ċ", "Ljava/util/UUID;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ċ_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr đ_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BaseGattClient']/field[@name='đ']"
		[Register ("đ")]
		protected static global::Java.Util.UUID Đ {
			get {
				if (đ_jfieldId == IntPtr.Zero)
					đ_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "đ", "Ljava/util/UUID;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, đ_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Ē_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BaseGattClient']/field[@name='Ē']"
		[Register ("Ē")]
		protected static global::Java.Util.UUID Ē {
			get {
				if (Ē_jfieldId == IntPtr.Zero)
					Ē_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Ē", "Ljava/util/UUID;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Ē_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Ė_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BaseGattClient']/field[@name='Ė']"
		[Register ("Ė")]
		protected static global::Java.Util.UUID Ė {
			get {
				if (Ė_jfieldId == IntPtr.Zero)
					Ė_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Ė", "Ljava/util/UUID;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Ė_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Ę_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BaseGattClient']/field[@name='Ę']"
		[Register ("Ę")]
		protected static global::Java.Util.UUID Ę {
			get {
				if (Ę_jfieldId == IntPtr.Zero)
					Ę_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Ę", "Ljava/util/UUID;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Ę_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ġ_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BaseGattClient']/field[@name='ġ']"
		[Register ("ġ")]
		protected string Ġ {
			get {
				if (ġ_jfieldId == IntPtr.Zero)
					ġ_jfieldId = JNIEnv.GetFieldID (class_ref, "ġ", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, ġ_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (ġ_jfieldId == IntPtr.Zero)
					ġ_jfieldId = JNIEnv.GetFieldID (class_ref, "ġ", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, ġ_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr Ȋ_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BaseGattClient']/field[@name='Ȋ']"
		[Register ("Ȋ")]
		protected static global::Java.Util.UUID Ȋ {
			get {
				if (Ȋ_jfieldId == IntPtr.Zero)
					Ȋ_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Ȋ", "Ljava/util/UUID;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Ȋ_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Ƞ_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BaseGattClient']/field[@name='Ƞ']"
		[Register ("Ƞ")]
		protected IList<byte> Ƞ {
			get {
				if (Ƞ_jfieldId == IntPtr.Zero)
					Ƞ_jfieldId = JNIEnv.GetFieldID (class_ref, "Ƞ", "[B");
				return JavaArray<byte>.FromJniHandle (JNIEnv.GetObjectField (Handle, Ƞ_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (Ƞ_jfieldId == IntPtr.Zero)
					Ƞ_jfieldId = JNIEnv.GetFieldID (class_ref, "Ƞ", "[B");
				IntPtr native_value = JavaArray<byte>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, Ƞ_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr ˮ͍_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BaseGattClient']/field[@name='ˮ͍']"
		[Register ("ˮ͍")]
		protected static global::Java.Util.UUID ˮ͍ {
			get {
				if (ˮ͍_jfieldId == IntPtr.Zero)
					ˮ͍_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ˮ͍", "Ljava/util/UUID;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ˮ͍_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ܕ_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BaseGattClient']/field[@name='ܕ']"
		[Register ("ܕ")]
		protected static global::Java.Util.UUID ܕ {
			get {
				if (ܕ_jfieldId == IntPtr.Zero)
					ܕ_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ܕ", "Ljava/util/UUID;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ܕ_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ܨ_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BaseGattClient']/field[@name='ܨ']"
		[Register ("ܨ")]
		protected global::Android.Content.Context ܨ {
			get {
				if (ܨ_jfieldId == IntPtr.Zero)
					ܨ_jfieldId = JNIEnv.GetFieldID (class_ref, "ܨ", "Landroid/content/Context;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, ܨ_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (ܨ_jfieldId == IntPtr.Zero)
					ܨ_jfieldId = JNIEnv.GetFieldID (class_ref, "ܨ", "Landroid/content/Context;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, ܨ_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr ঽ্_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BaseGattClient']/field[@name='ঽ্']"
		[Register ("ঽ্")]
		protected IList<byte> ঽ্ {
			get {
				if (ঽ্_jfieldId == IntPtr.Zero)
					ঽ্_jfieldId = JNIEnv.GetFieldID (class_ref, "ঽ্", "[B");
				return JavaArray<byte>.FromJniHandle (JNIEnv.GetObjectField (Handle, ঽ্_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (ঽ্_jfieldId == IntPtr.Zero)
					ঽ্_jfieldId = JNIEnv.GetFieldID (class_ref, "ঽ্", "[B");
				IntPtr native_value = JavaArray<byte>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, ঽ্_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr 㥳_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BaseGattClient']/field[@name='㥳']"
		[Register ("㥳")]
		protected static global::Java.Util.UUID 㥳 {
			get {
				if (㥳_jfieldId == IntPtr.Zero)
					㥳_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "㥳", "Ljava/util/UUID;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, 㥳_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr 㱽_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BaseGattClient']/field[@name='㱽']"
		[Register ("㱽")]
		protected IList<byte> 㱽 {
			get {
				if (㱽_jfieldId == IntPtr.Zero)
					㱽_jfieldId = JNIEnv.GetFieldID (class_ref, "㱽", "[B");
				return JavaArray<byte>.FromJniHandle (JNIEnv.GetObjectField (Handle, 㱽_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (㱽_jfieldId == IntPtr.Zero)
					㱽_jfieldId = JNIEnv.GetFieldID (class_ref, "㱽", "[B");
				IntPtr native_value = JavaArray<byte>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, 㱽_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr 㵼_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BaseGattClient']/field[@name='㵼']"
		[Register ("㵼")]
		protected IList<byte> 㵼 {
			get {
				if (㵼_jfieldId == IntPtr.Zero)
					㵼_jfieldId = JNIEnv.GetFieldID (class_ref, "㵼", "[B");
				return JavaArray<byte>.FromJniHandle (JNIEnv.GetObjectField (Handle, 㵼_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (㵼_jfieldId == IntPtr.Zero)
					㵼_jfieldId = JNIEnv.GetFieldID (class_ref, "㵼", "[B");
				IntPtr native_value = JavaArray<byte>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, 㵼_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr 䒧_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BaseGattClient']/field[@name='䒧']"
		[Register ("䒧")]
		protected static global::Java.Util.UUID 䒧 {
			get {
				if (䒧_jfieldId == IntPtr.Zero)
					䒧_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "䒧", "Ljava/util/UUID;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, 䒧_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr 囃_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BaseGattClient']/field[@name='囃']"
		[Register ("囃")]
		protected IList<byte> 囃 {
			get {
				if (囃_jfieldId == IntPtr.Zero)
					囃_jfieldId = JNIEnv.GetFieldID (class_ref, "囃", "[B");
				return JavaArray<byte>.FromJniHandle (JNIEnv.GetObjectField (Handle, 囃_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (囃_jfieldId == IntPtr.Zero)
					囃_jfieldId = JNIEnv.GetFieldID (class_ref, "囃", "[B");
				IntPtr native_value = JavaArray<byte>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, 囃_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr 岱_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BaseGattClient']/field[@name='岱']"
		[Register ("岱")]
		protected static global::Java.Util.UUID 岱 {
			get {
				if (岱_jfieldId == IntPtr.Zero)
					岱_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "岱", "Ljava/util/UUID;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, 岱_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr 庸_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BaseGattClient']/field[@name='庸']"
		[Register ("庸")]
		protected static global::Java.Util.UUID 庸 {
			get {
				if (庸_jfieldId == IntPtr.Zero)
					庸_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "庸", "Ljava/util/UUID;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, 庸_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr 廂_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BaseGattClient']/field[@name='廂']"
		[Register ("廂")]
		protected IList<byte> 廂 {
			get {
				if (廂_jfieldId == IntPtr.Zero)
					廂_jfieldId = JNIEnv.GetFieldID (class_ref, "廂", "[B");
				return JavaArray<byte>.FromJniHandle (JNIEnv.GetObjectField (Handle, 廂_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (廂_jfieldId == IntPtr.Zero)
					廂_jfieldId = JNIEnv.GetFieldID (class_ref, "廂", "[B");
				IntPtr native_value = JavaArray<byte>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, 廂_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr 廅_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BaseGattClient']/field[@name='廅']"
		[Register ("廅")]
		protected IList<byte> 廅 {
			get {
				if (廅_jfieldId == IntPtr.Zero)
					廅_jfieldId = JNIEnv.GetFieldID (class_ref, "廅", "[B");
				return JavaArray<byte>.FromJniHandle (JNIEnv.GetObjectField (Handle, 廅_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (廅_jfieldId == IntPtr.Zero)
					廅_jfieldId = JNIEnv.GetFieldID (class_ref, "廅", "[B");
				IntPtr native_value = JavaArray<byte>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, 廅_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr 纫_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BaseGattClient']/field[@name='纫']"
		[Register ("纫")]
		protected static global::Java.Util.UUID 纫 {
			get {
				if (纫_jfieldId == IntPtr.Zero)
					纫_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "纫", "Ljava/util/UUID;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, 纫_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr 躆_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BaseGattClient']/field[@name='躆']"
		[Register ("躆")]
		protected static global::Java.Util.UUID 躆 {
			get {
				if (躆_jfieldId == IntPtr.Zero)
					躆_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "躆", "Ljava/util/UUID;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, 躆_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr 띥_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BaseGattClient']/field[@name='띥']"
		[Register ("띥")]
		protected static global::Java.Util.UUID 띥 {
			get {
				if (띥_jfieldId == IntPtr.Zero)
					띥_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "띥", "Ljava/util/UUID;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, 띥_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BaseGattClient.BaseGattClientBtEventsReceiver']"
		[global::Android.Runtime.Register ("com/qcl/vh/ble/BaseGattClient$BaseGattClientBtEventsReceiver", DoNotGenerateAcw=true)]
		public partial class BaseGattClientBtEventsReceiver : global::Android.Content.BroadcastReceiver {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/qcl/vh/ble/BaseGattClient$BaseGattClientBtEventsReceiver", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (BaseGattClientBtEventsReceiver); }
			}

			protected BaseGattClientBtEventsReceiver (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_qcl_vh_ble_BaseGattClient_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BaseGattClient.BaseGattClientBtEventsReceiver']/constructor[@name='BaseGattClient.BaseGattClientBtEventsReceiver' and count(parameter)=1 and parameter[1][@type='com.qcl.vh.ble.BaseGattClient']]"
			[Register (".ctor", "(Lcom/qcl/vh/ble/BaseGattClient;)V", "")]
			protected unsafe BaseGattClientBtEventsReceiver (global::Com.Qcl.VH.Ble.BaseGattClient __self)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (__self);
					if (GetType () != typeof (BaseGattClientBtEventsReceiver)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args);
						return;
					}

					if (id_ctor_Lcom_qcl_vh_ble_BaseGattClient_ == IntPtr.Zero)
						id_ctor_Lcom_qcl_vh_ble_BaseGattClient_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/qcl/vh/ble/BaseGattClient;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_qcl_vh_ble_BaseGattClient_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_qcl_vh_ble_BaseGattClient_, __args);
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
				global::Com.Qcl.VH.Ble.BaseGattClient.BaseGattClientBtEventsReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Ble.BaseGattClient.BaseGattClientBtEventsReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Content.Intent p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnReceive (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_onReceive_Landroid_content_Context_Landroid_content_Intent_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BaseGattClient.BaseGattClientBtEventsReceiver']/method[@name='onReceive' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.Intent']]"
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

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BaseGattClient.if']"
		[global::Android.Runtime.Register ("com/qcl/vh/ble/BaseGattClient$if", DoNotGenerateAcw=true)]
		public partial class If : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/qcl/vh/ble/BaseGattClient$if", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (If); }
			}

			protected If (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_qcl_vh_ble_BaseGattClient_JI;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BaseGattClient.if']/constructor[@name='BaseGattClient.if' and count(parameter)=3 and parameter[1][@type='com.qcl.vh.ble.BaseGattClient'] and parameter[2][@type='long'] and parameter[3][@type='int']]"
			[Register (".ctor", "(Lcom/qcl/vh/ble/BaseGattClient;JI)V", "")]
			public unsafe If (global::Com.Qcl.VH.Ble.BaseGattClient __self, long p1, int p2)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					if (GetType () != typeof (If)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";JI)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";JI)V", __args);
						return;
					}

					if (id_ctor_Lcom_qcl_vh_ble_BaseGattClient_JI == IntPtr.Zero)
						id_ctor_Lcom_qcl_vh_ble_BaseGattClient_JI = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/qcl/vh/ble/BaseGattClient;JI)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_qcl_vh_ble_BaseGattClient_JI, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_qcl_vh_ble_BaseGattClient_JI, __args);
				} finally {
				}
			}

			static IntPtr id_ctor_Lcom_qcl_vh_ble_BaseGattClient_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BaseGattClient.if']/constructor[@name='BaseGattClient.if' and count(parameter)=1 and parameter[1][@type='com.qcl.vh.ble.BaseGattClient']]"
			[Register (".ctor", "(Lcom/qcl/vh/ble/BaseGattClient;)V", "")]
			public unsafe If (global::Com.Qcl.VH.Ble.BaseGattClient __self)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (__self);
					if (GetType () != typeof (If)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args);
						return;
					}

					if (id_ctor_Lcom_qcl_vh_ble_BaseGattClient_ == IntPtr.Zero)
						id_ctor_Lcom_qcl_vh_ble_BaseGattClient_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/qcl/vh/ble/BaseGattClient;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_qcl_vh_ble_BaseGattClient_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_qcl_vh_ble_BaseGattClient_, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BaseGattClient.鷭']"
		[global::Android.Runtime.Register ("com/qcl/vh/ble/BaseGattClient$鷭", DoNotGenerateAcw=true)]
		public partial class 鷭 : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/qcl/vh/ble/BaseGattClient$鷭", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (鷭); }
			}

			protected 鷭 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_qcl_vh_ble_BaseGattClient_arrayBLcom_qcl_vh_ble_BaseGattClient_if_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BaseGattClient.鷭']/constructor[@name='BaseGattClient.鷭' and count(parameter)=3 and parameter[1][@type='com.qcl.vh.ble.BaseGattClient'] and parameter[2][@type='byte[]'] and parameter[3][@type='com.qcl.vh.ble.BaseGattClient.if']]"
			[Register (".ctor", "(Lcom/qcl/vh/ble/BaseGattClient;[BLcom/qcl/vh/ble/BaseGattClient$if;)V", "")]
			public unsafe 鷭 (global::Com.Qcl.VH.Ble.BaseGattClient __self, byte[] p1, global::Com.Qcl.VH.Ble.BaseGattClient.If p2)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p1 = JNIEnv.NewArray (p1);
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (native_p1);
					__args [2] = new JValue (p2);
					if (GetType () != typeof (鷭)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";[BLcom/qcl/vh/ble/BaseGattClient$if;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";[BLcom/qcl/vh/ble/BaseGattClient$if;)V", __args);
						return;
					}

					if (id_ctor_Lcom_qcl_vh_ble_BaseGattClient_arrayBLcom_qcl_vh_ble_BaseGattClient_if_ == IntPtr.Zero)
						id_ctor_Lcom_qcl_vh_ble_BaseGattClient_arrayBLcom_qcl_vh_ble_BaseGattClient_if_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/qcl/vh/ble/BaseGattClient;[BLcom/qcl/vh/ble/BaseGattClient$if;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_qcl_vh_ble_BaseGattClient_arrayBLcom_qcl_vh_ble_BaseGattClient_if_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_qcl_vh_ble_BaseGattClient_arrayBLcom_qcl_vh_ble_BaseGattClient_if_, __args);
				} finally {
					if (p1 != null) {
						JNIEnv.CopyArray (native_p1, p1);
						JNIEnv.DeleteLocalRef (native_p1);
					}
				}
			}

			static IntPtr id_ctor_Lcom_qcl_vh_ble_BaseGattClient_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BaseGattClient.鷭']/constructor[@name='BaseGattClient.鷭' and count(parameter)=1 and parameter[1][@type='com.qcl.vh.ble.BaseGattClient']]"
			[Register (".ctor", "(Lcom/qcl/vh/ble/BaseGattClient;)V", "")]
			public unsafe 鷭 (global::Com.Qcl.VH.Ble.BaseGattClient __self)
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

					if (id_ctor_Lcom_qcl_vh_ble_BaseGattClient_ == IntPtr.Zero)
						id_ctor_Lcom_qcl_vh_ble_BaseGattClient_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/qcl/vh/ble/BaseGattClient;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_qcl_vh_ble_BaseGattClient_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_qcl_vh_ble_BaseGattClient_, __args);
				} finally {
				}
			}

			static IntPtr id_櫯;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BaseGattClient.鷭']/method[@name='櫯' and count(parameter)=0]"
			[Register ("櫯", "()Lcom/qcl/vh/ble/BaseGattClient$if;", "")]
			public unsafe global::Com.Qcl.VH.Ble.BaseGattClient.If 櫯 ()
			{
				if (id_櫯 == IntPtr.Zero)
					id_櫯 = JNIEnv.GetMethodID (class_ref, "櫯", "()Lcom/qcl/vh/ble/BaseGattClient$if;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Ble.BaseGattClient.If> (JNIEnv.CallObjectMethod  (Handle, id_櫯), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_鷭;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BaseGattClient.鷭']/method[@name='鷭' and count(parameter)=0]"
			[Register ("鷭", "()[B", "")]
			public unsafe byte[] Invoke鷭 ()
			{
				if (id_鷭 == IntPtr.Zero)
					id_鷭 = JNIEnv.GetMethodID (class_ref, "鷭", "()[B");
				try {
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_鷭), JniHandleOwnership.TransferLocalRef, typeof (byte));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qcl/vh/ble/BaseGattClient", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseGattClient); }
		}

		protected BaseGattClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BaseGattClient']/constructor[@name='BaseGattClient' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BaseGattClient ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (BaseGattClient)) {
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

		static IntPtr id_Ą;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BaseGattClient']/method[@name='Ą' and count(parameter)=0]"
		[Register ("Ą", "()Z", "")]
		protected unsafe bool Ą ()
		{
			if (id_Ą == IntPtr.Zero)
				id_Ą = JNIEnv.GetMethodID (class_ref, "Ą", "()Z");
			try {
				return JNIEnv.CallBooleanMethod  (Handle, id_Ą);
			} finally {
			}
		}

		static IntPtr id_Ą_Landroid_bluetooth_BluetoothGatt_Landroid_bluetooth_BluetoothGattCharacteristic_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BaseGattClient']/method[@name='Ą' and count(parameter)=2 and parameter[1][@type='android.bluetooth.BluetoothGatt'] and parameter[2][@type='android.bluetooth.BluetoothGattCharacteristic']]"
		[Register ("Ą", "(Landroid/bluetooth/BluetoothGatt;Landroid/bluetooth/BluetoothGattCharacteristic;)Z", "")]
		public static unsafe bool Ą (global::Android.Bluetooth.BluetoothGatt p0, global::Android.Bluetooth.BluetoothGattCharacteristic p1)
		{
			if (id_Ą_Landroid_bluetooth_BluetoothGatt_Landroid_bluetooth_BluetoothGattCharacteristic_ == IntPtr.Zero)
				id_Ą_Landroid_bluetooth_BluetoothGatt_Landroid_bluetooth_BluetoothGattCharacteristic_ = JNIEnv.GetStaticMethodID (class_ref, "Ą", "(Landroid/bluetooth/BluetoothGatt;Landroid/bluetooth/BluetoothGattCharacteristic;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_Ą_Landroid_bluetooth_BluetoothGatt_Landroid_bluetooth_BluetoothGattCharacteristic_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_ą;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BaseGattClient']/method[@name='ą' and count(parameter)=0]"
		[Register ("ą", "()Z", "")]
		protected unsafe bool Ą ()
		{
			if (id_ą == IntPtr.Zero)
				id_ą = JNIEnv.GetMethodID (class_ref, "ą", "()Z");
			try {
				return JNIEnv.CallBooleanMethod  (Handle, id_ą);
			} finally {
			}
		}

		static IntPtr id_Ć;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BaseGattClient']/method[@name='Ć' and count(parameter)=0]"
		[Register ("Ć", "()Z", "")]
		protected unsafe bool Ć ()
		{
			if (id_Ć == IntPtr.Zero)
				id_Ć = JNIEnv.GetMethodID (class_ref, "Ć", "()Z");
			try {
				return JNIEnv.CallBooleanMethod  (Handle, id_Ć);
			} finally {
			}
		}

		static IntPtr id_ȃ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BaseGattClient']/method[@name='ȃ' and count(parameter)=0]"
		[Register ("ȃ", "()Ljava/util/List;", "")]
		protected unsafe global::System.Collections.Generic.IList<global::Com.Qcl.VH.Ble.BaseGattClient.鷭> Ȃ ()
		{
			if (id_ȃ == IntPtr.Zero)
				id_ȃ = JNIEnv.GetMethodID (class_ref, "ȃ", "()Ljava/util/List;");
			try {
				return global::Android.Runtime.JavaList<global::Com.Qcl.VH.Ble.BaseGattClient.鷭>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_ȃ), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_ȃ_Landroid_bluetooth_BluetoothGatt_Landroid_bluetooth_BluetoothGattCharacteristic_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BaseGattClient']/method[@name='ȃ' and count(parameter)=2 and parameter[1][@type='android.bluetooth.BluetoothGatt'] and parameter[2][@type='android.bluetooth.BluetoothGattCharacteristic']]"
		[Register ("ȃ", "(Landroid/bluetooth/BluetoothGatt;Landroid/bluetooth/BluetoothGattCharacteristic;)Z", "")]
		public static unsafe bool Ȃ (global::Android.Bluetooth.BluetoothGatt p0, global::Android.Bluetooth.BluetoothGattCharacteristic p1)
		{
			if (id_ȃ_Landroid_bluetooth_BluetoothGatt_Landroid_bluetooth_BluetoothGattCharacteristic_ == IntPtr.Zero)
				id_ȃ_Landroid_bluetooth_BluetoothGatt_Landroid_bluetooth_BluetoothGattCharacteristic_ = JNIEnv.GetStaticMethodID (class_ref, "ȃ", "(Landroid/bluetooth/BluetoothGatt;Landroid/bluetooth/BluetoothGattCharacteristic;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_ȃ_Landroid_bluetooth_BluetoothGatt_Landroid_bluetooth_BluetoothGattCharacteristic_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_ˮ͈;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BaseGattClient']/method[@name='ˮ͈' and count(parameter)=0]"
		[Register ("ˮ͈", "()Lcom/qcl/vh/content/MedicalDevice;", "")]
		protected unsafe global::Com.Qcl.VH.Content.MedicalDevice ˮ͈ ()
		{
			if (id_ˮ͈ == IntPtr.Zero)
				id_ˮ͈ = JNIEnv.GetMethodID (class_ref, "ˮ͈", "()Lcom/qcl/vh/content/MedicalDevice;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.MedicalDevice> (JNIEnv.CallObjectMethod  (Handle, id_ˮ͈), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_ˮ͈_Landroid_bluetooth_BluetoothGatt_Landroid_bluetooth_BluetoothGattCharacteristic_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BaseGattClient']/method[@name='ˮ͈' and count(parameter)=2 and parameter[1][@type='android.bluetooth.BluetoothGatt'] and parameter[2][@type='android.bluetooth.BluetoothGattCharacteristic']]"
		[Register ("ˮ͈", "(Landroid/bluetooth/BluetoothGatt;Landroid/bluetooth/BluetoothGattCharacteristic;)V", "")]
		public static unsafe void ˮ͈ (global::Android.Bluetooth.BluetoothGatt p0, global::Android.Bluetooth.BluetoothGattCharacteristic p1)
		{
			if (id_ˮ͈_Landroid_bluetooth_BluetoothGatt_Landroid_bluetooth_BluetoothGattCharacteristic_ == IntPtr.Zero)
				id_ˮ͈_Landroid_bluetooth_BluetoothGatt_Landroid_bluetooth_BluetoothGattCharacteristic_ = JNIEnv.GetStaticMethodID (class_ref, "ˮ͈", "(Landroid/bluetooth/BluetoothGatt;Landroid/bluetooth/BluetoothGattCharacteristic;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_ˮ͈_Landroid_bluetooth_BluetoothGatt_Landroid_bluetooth_BluetoothGattCharacteristic_, __args);
			} finally {
			}
		}

		static IntPtr id_櫯;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BaseGattClient']/method[@name='櫯' and count(parameter)=0]"
		[Register ("櫯", "()V", "")]
		protected unsafe void 櫯 ()
		{
			if (id_櫯 == IntPtr.Zero)
				id_櫯 = JNIEnv.GetMethodID (class_ref, "櫯", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_櫯);
			} finally {
			}
		}

		static IntPtr id_櫯_Landroid_bluetooth_BluetoothGatt_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BaseGattClient']/method[@name='櫯' and count(parameter)=1 and parameter[1][@type='android.bluetooth.BluetoothGatt']]"
		[Register ("櫯", "(Landroid/bluetooth/BluetoothGatt;)V", "")]
		protected unsafe void 櫯 (global::Android.Bluetooth.BluetoothGatt p0)
		{
			if (id_櫯_Landroid_bluetooth_BluetoothGatt_ == IntPtr.Zero)
				id_櫯_Landroid_bluetooth_BluetoothGatt_ = JNIEnv.GetMethodID (class_ref, "櫯", "(Landroid/bluetooth/BluetoothGatt;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_櫯_Landroid_bluetooth_BluetoothGatt_, __args);
			} finally {
			}
		}

		static IntPtr id_櫯_Landroid_bluetooth_BluetoothGatt_Landroid_bluetooth_BluetoothGattCharacteristic_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BaseGattClient']/method[@name='櫯' and count(parameter)=2 and parameter[1][@type='android.bluetooth.BluetoothGatt'] and parameter[2][@type='android.bluetooth.BluetoothGattCharacteristic']]"
		[Register ("櫯", "(Landroid/bluetooth/BluetoothGatt;Landroid/bluetooth/BluetoothGattCharacteristic;)Z", "")]
		public static unsafe bool 櫯 (global::Android.Bluetooth.BluetoothGatt p0, global::Android.Bluetooth.BluetoothGattCharacteristic p1)
		{
			if (id_櫯_Landroid_bluetooth_BluetoothGatt_Landroid_bluetooth_BluetoothGattCharacteristic_ == IntPtr.Zero)
				id_櫯_Landroid_bluetooth_BluetoothGatt_Landroid_bluetooth_BluetoothGattCharacteristic_ = JNIEnv.GetStaticMethodID (class_ref, "櫯", "(Landroid/bluetooth/BluetoothGatt;Landroid/bluetooth/BluetoothGattCharacteristic;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_櫯_Landroid_bluetooth_BluetoothGatt_Landroid_bluetooth_BluetoothGattCharacteristic_, __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_櫯_Landroid_bluetooth_BluetoothGatt_Ljava_util_UUID_arrayBIILjava_util_List_I;
#pragma warning disable 0169
		static Delegate Get櫯_Landroid_bluetooth_BluetoothGatt_Ljava_util_UUID_arrayBIILjava_util_List_IHandler ()
		{
			if (cb_櫯_Landroid_bluetooth_BluetoothGatt_Ljava_util_UUID_arrayBIILjava_util_List_I == null)
				cb_櫯_Landroid_bluetooth_BluetoothGatt_Ljava_util_UUID_arrayBIILjava_util_List_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, int, IntPtr, int>) n_櫯_Landroid_bluetooth_BluetoothGatt_Ljava_util_UUID_arrayBIILjava_util_List_I);
			return cb_櫯_Landroid_bluetooth_BluetoothGatt_Ljava_util_UUID_arrayBIILjava_util_List_I;
		}

		static void n_櫯_Landroid_bluetooth_BluetoothGatt_Ljava_util_UUID_arrayBIILjava_util_List_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, int p3, int p4, IntPtr native_p5, int p6)
		{
			global::Com.Qcl.VH.Ble.BaseGattClient __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Ble.BaseGattClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Bluetooth.BluetoothGatt p0 = global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothGatt> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.UUID p1 = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_p1, JniHandleOwnership.DoNotTransfer);
			byte[] p2 = (byte[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p5 = global::Android.Runtime.JavaList<global::Android.Bluetooth.BluetoothGattDescriptor>.FromJniHandle (native_p5, JniHandleOwnership.DoNotTransfer);
			__this.櫯 (p0, p1, p2, p3, p4, p5, p6);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		static IntPtr id_櫯_Landroid_bluetooth_BluetoothGatt_Ljava_util_UUID_arrayBIILjava_util_List_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BaseGattClient']/method[@name='櫯' and count(parameter)=7 and parameter[1][@type='android.bluetooth.BluetoothGatt'] and parameter[2][@type='java.util.UUID'] and parameter[3][@type='byte[]'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='java.util.List&lt;android.bluetooth.BluetoothGattDescriptor&gt;'] and parameter[7][@type='int']]"
		[Register ("櫯", "(Landroid/bluetooth/BluetoothGatt;Ljava/util/UUID;[BIILjava/util/List;I)V", "Get櫯_Landroid_bluetooth_BluetoothGatt_Ljava_util_UUID_arrayBIILjava_util_List_IHandler")]
		public virtual unsafe void 櫯 (global::Android.Bluetooth.BluetoothGatt p0, global::Java.Util.UUID p1, byte[] p2, int p3, int p4, global::System.Collections.Generic.IList<global::Android.Bluetooth.BluetoothGattDescriptor> p5, int p6)
		{
			if (id_櫯_Landroid_bluetooth_BluetoothGatt_Ljava_util_UUID_arrayBIILjava_util_List_I == IntPtr.Zero)
				id_櫯_Landroid_bluetooth_BluetoothGatt_Ljava_util_UUID_arrayBIILjava_util_List_I = JNIEnv.GetMethodID (class_ref, "櫯", "(Landroid/bluetooth/BluetoothGatt;Ljava/util/UUID;[BIILjava/util/List;I)V");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p5 = global::Android.Runtime.JavaList<global::Android.Bluetooth.BluetoothGattDescriptor>.ToLocalJniHandle (p5);
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (native_p5);
				__args [6] = new JValue (p6);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_櫯_Landroid_bluetooth_BluetoothGatt_Ljava_util_UUID_arrayBIILjava_util_List_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "櫯", "(Landroid/bluetooth/BluetoothGatt;Ljava/util/UUID;[BIILjava/util/List;I)V"), __args);
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				JNIEnv.DeleteLocalRef (native_p5);
			}
		}

		static Delegate cb_櫯_arrayB;
#pragma warning disable 0169
		static Delegate Get櫯_arrayBHandler ()
		{
			if (cb_櫯_arrayB == null)
				cb_櫯_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_櫯_arrayB);
			return cb_櫯_arrayB;
		}

		static bool n_櫯_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Qcl.VH.Ble.BaseGattClient __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Ble.BaseGattClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			bool __ret = __this.櫯 (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BaseGattClient']/method[@name='櫯' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("櫯", "([B)Z", "Get櫯_arrayBHandler")]
		protected abstract bool 櫯 (byte[] p0);

		static IntPtr id_櫯_Lcom_qcl_vh_content_ˮ͈_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BaseGattClient']/method[@name='櫯' and count(parameter)=1 and parameter[1][@type='com.qcl.vh.content.ˮ͈']]"
		[Register ("櫯", "(Lcom/qcl/vh/content/ˮ͈;)V", "")]
		protected unsafe void 櫯 (global::Com.Qcl.VH.Content.ˮ͈ p0)
		{
			if (id_櫯_Lcom_qcl_vh_content_ˮ͈_ == IntPtr.Zero)
				id_櫯_Lcom_qcl_vh_content_ˮ͈_ = JNIEnv.GetMethodID (class_ref, "櫯", "(Lcom/qcl/vh/content/ˮ͈;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_櫯_Lcom_qcl_vh_content_ˮ͈_, __args);
			} finally {
			}
		}

		static IntPtr id_櫯_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BaseGattClient']/method[@name='櫯' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("櫯", "(Ljava/lang/String;)[B", "")]
		protected unsafe byte[] 櫯 (string p0)
		{
			if (id_櫯_Ljava_lang_String_ == IntPtr.Zero)
				id_櫯_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "櫯", "(Ljava/lang/String;)[B");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_櫯_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_櫯_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BaseGattClient']/method[@name='櫯' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.util.AbstractMap.SimpleEntry&lt;java.util.UUID, byte[]&gt;&gt;']]"
		[Register ("櫯", "(Ljava/util/List;)[B", "")]
		protected static unsafe byte[] 櫯 (global::System.Collections.Generic.IList<global::Java.Util.AbstractMap.SimpleEntry> p0)
		{
			if (id_櫯_Ljava_util_List_ == IntPtr.Zero)
				id_櫯_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "櫯", "(Ljava/util/List;)[B");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Java.Util.AbstractMap.SimpleEntry>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_櫯_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_鷭;
#pragma warning disable 0169
		static Delegate GetInvoke鷭Handler ()
		{
			if (cb_鷭 == null)
				cb_鷭 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Invoke鷭);
			return cb_鷭;
		}

		static IntPtr n_Invoke鷭 (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Qcl.VH.Ble.BaseGattClient __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Ble.BaseGattClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Invoke鷭 ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BaseGattClient']/method[@name='鷭' and count(parameter)=0]"
		[Register ("鷭", "()Landroid/bluetooth/le/ScanFilter;", "GetInvoke鷭Handler")]
		protected abstract global::Android.Bluetooth.LE.ScanFilter Invoke鷭 ();

		static Delegate cb_鷭_Landroid_bluetooth_BluetoothGatt_;
#pragma warning disable 0169
		static Delegate GetInvoke鷭_Landroid_bluetooth_BluetoothGatt_Handler ()
		{
			if (cb_鷭_Landroid_bluetooth_BluetoothGatt_ == null)
				cb_鷭_Landroid_bluetooth_BluetoothGatt_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Invoke鷭_Landroid_bluetooth_BluetoothGatt_);
			return cb_鷭_Landroid_bluetooth_BluetoothGatt_;
		}

		static void n_Invoke鷭_Landroid_bluetooth_BluetoothGatt_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Qcl.VH.Ble.BaseGattClient __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Ble.BaseGattClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Bluetooth.BluetoothGatt p0 = global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothGatt> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Invoke鷭 (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BaseGattClient']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='android.bluetooth.BluetoothGatt']]"
		[Register ("鷭", "(Landroid/bluetooth/BluetoothGatt;)V", "GetInvoke鷭_Landroid_bluetooth_BluetoothGatt_Handler")]
		protected abstract void Invoke鷭 (global::Android.Bluetooth.BluetoothGatt p0);

		static IntPtr id_鷭_Landroid_bluetooth_BluetoothGatt_Landroid_bluetooth_BluetoothGattCharacteristic_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BaseGattClient']/method[@name='鷭' and count(parameter)=2 and parameter[1][@type='android.bluetooth.BluetoothGatt'] and parameter[2][@type='android.bluetooth.BluetoothGattCharacteristic']]"
		[Register ("鷭", "(Landroid/bluetooth/BluetoothGatt;Landroid/bluetooth/BluetoothGattCharacteristic;)Z", "")]
		public static unsafe bool Invoke鷭 (global::Android.Bluetooth.BluetoothGatt p0, global::Android.Bluetooth.BluetoothGattCharacteristic p1)
		{
			if (id_鷭_Landroid_bluetooth_BluetoothGatt_Landroid_bluetooth_BluetoothGattCharacteristic_ == IntPtr.Zero)
				id_鷭_Landroid_bluetooth_BluetoothGatt_Landroid_bluetooth_BluetoothGattCharacteristic_ = JNIEnv.GetStaticMethodID (class_ref, "鷭", "(Landroid/bluetooth/BluetoothGatt;Landroid/bluetooth/BluetoothGattCharacteristic;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_鷭_Landroid_bluetooth_BluetoothGatt_Landroid_bluetooth_BluetoothGattCharacteristic_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_鷭_Landroid_bluetooth_BluetoothGatt_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BaseGattClient']/method[@name='鷭' and count(parameter)=2 and parameter[1][@type='android.bluetooth.BluetoothGatt'] and parameter[2][@type='int']]"
		[Register ("鷭", "(Landroid/bluetooth/BluetoothGatt;I)V", "")]
		public unsafe void Invoke鷭 (global::Android.Bluetooth.BluetoothGatt p0, int p1)
		{
			if (id_鷭_Landroid_bluetooth_BluetoothGatt_I == IntPtr.Zero)
				id_鷭_Landroid_bluetooth_BluetoothGatt_I = JNIEnv.GetMethodID (class_ref, "鷭", "(Landroid/bluetooth/BluetoothGatt;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod  (Handle, id_鷭_Landroid_bluetooth_BluetoothGatt_I, __args);
			} finally {
			}
		}

		static Delegate cb_鷭_Landroid_bluetooth_BluetoothGatt_II;
#pragma warning disable 0169
		static Delegate GetInvoke鷭_Landroid_bluetooth_BluetoothGatt_IIHandler ()
		{
			if (cb_鷭_Landroid_bluetooth_BluetoothGatt_II == null)
				cb_鷭_Landroid_bluetooth_BluetoothGatt_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_Invoke鷭_Landroid_bluetooth_BluetoothGatt_II);
			return cb_鷭_Landroid_bluetooth_BluetoothGatt_II;
		}

		static void n_Invoke鷭_Landroid_bluetooth_BluetoothGatt_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Com.Qcl.VH.Ble.BaseGattClient __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Ble.BaseGattClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Bluetooth.BluetoothGatt p0 = global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothGatt> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Invoke鷭 (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_鷭_Landroid_bluetooth_BluetoothGatt_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BaseGattClient']/method[@name='鷭' and count(parameter)=3 and parameter[1][@type='android.bluetooth.BluetoothGatt'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("鷭", "(Landroid/bluetooth/BluetoothGatt;II)V", "GetInvoke鷭_Landroid_bluetooth_BluetoothGatt_IIHandler")]
		public virtual unsafe void Invoke鷭 (global::Android.Bluetooth.BluetoothGatt p0, int p1, int p2)
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

		static Delegate cb_鷭_Landroid_bluetooth_BluetoothGatt_Ljava_util_UUID_arrayBIILjava_util_List_;
#pragma warning disable 0169
		static Delegate GetInvoke鷭_Landroid_bluetooth_BluetoothGatt_Ljava_util_UUID_arrayBIILjava_util_List_Handler ()
		{
			if (cb_鷭_Landroid_bluetooth_BluetoothGatt_Ljava_util_UUID_arrayBIILjava_util_List_ == null)
				cb_鷭_Landroid_bluetooth_BluetoothGatt_Ljava_util_UUID_arrayBIILjava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, int, IntPtr>) n_Invoke鷭_Landroid_bluetooth_BluetoothGatt_Ljava_util_UUID_arrayBIILjava_util_List_);
			return cb_鷭_Landroid_bluetooth_BluetoothGatt_Ljava_util_UUID_arrayBIILjava_util_List_;
		}

		static void n_Invoke鷭_Landroid_bluetooth_BluetoothGatt_Ljava_util_UUID_arrayBIILjava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, int p3, int p4, IntPtr native_p5)
		{
			global::Com.Qcl.VH.Ble.BaseGattClient __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Ble.BaseGattClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Bluetooth.BluetoothGatt p0 = global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothGatt> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.UUID p1 = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_p1, JniHandleOwnership.DoNotTransfer);
			byte[] p2 = (byte[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p5 = global::Android.Runtime.JavaList<global::Android.Bluetooth.BluetoothGattDescriptor>.FromJniHandle (native_p5, JniHandleOwnership.DoNotTransfer);
			__this.Invoke鷭 (p0, p1, p2, p3, p4, p5);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BaseGattClient']/method[@name='鷭' and count(parameter)=6 and parameter[1][@type='android.bluetooth.BluetoothGatt'] and parameter[2][@type='java.util.UUID'] and parameter[3][@type='byte[]'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='java.util.List&lt;android.bluetooth.BluetoothGattDescriptor&gt;']]"
		[Register ("鷭", "(Landroid/bluetooth/BluetoothGatt;Ljava/util/UUID;[BIILjava/util/List;)V", "GetInvoke鷭_Landroid_bluetooth_BluetoothGatt_Ljava_util_UUID_arrayBIILjava_util_List_Handler")]
		public abstract void Invoke鷭 (global::Android.Bluetooth.BluetoothGatt p0, global::Java.Util.UUID p1, byte[] p2, int p3, int p4, global::System.Collections.Generic.IList<global::Android.Bluetooth.BluetoothGattDescriptor> p5);

		static Delegate cb_鷭_Landroid_bluetooth_BluetoothGatt_Ljava_util_UUID_arrayBIILjava_util_List_I;
#pragma warning disable 0169
		static Delegate GetInvoke鷭_Landroid_bluetooth_BluetoothGatt_Ljava_util_UUID_arrayBIILjava_util_List_IHandler ()
		{
			if (cb_鷭_Landroid_bluetooth_BluetoothGatt_Ljava_util_UUID_arrayBIILjava_util_List_I == null)
				cb_鷭_Landroid_bluetooth_BluetoothGatt_Ljava_util_UUID_arrayBIILjava_util_List_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, int, IntPtr, int>) n_Invoke鷭_Landroid_bluetooth_BluetoothGatt_Ljava_util_UUID_arrayBIILjava_util_List_I);
			return cb_鷭_Landroid_bluetooth_BluetoothGatt_Ljava_util_UUID_arrayBIILjava_util_List_I;
		}

		static void n_Invoke鷭_Landroid_bluetooth_BluetoothGatt_Ljava_util_UUID_arrayBIILjava_util_List_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, int p3, int p4, IntPtr native_p5, int p6)
		{
			global::Com.Qcl.VH.Ble.BaseGattClient __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Ble.BaseGattClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Bluetooth.BluetoothGatt p0 = global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothGatt> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.UUID p1 = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_p1, JniHandleOwnership.DoNotTransfer);
			byte[] p2 = (byte[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p5 = global::Android.Runtime.JavaList<global::Android.Bluetooth.BluetoothGattDescriptor>.FromJniHandle (native_p5, JniHandleOwnership.DoNotTransfer);
			__this.Invoke鷭 (p0, p1, p2, p3, p4, p5, p6);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		static IntPtr id_鷭_Landroid_bluetooth_BluetoothGatt_Ljava_util_UUID_arrayBIILjava_util_List_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BaseGattClient']/method[@name='鷭' and count(parameter)=7 and parameter[1][@type='android.bluetooth.BluetoothGatt'] and parameter[2][@type='java.util.UUID'] and parameter[3][@type='byte[]'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='java.util.List&lt;android.bluetooth.BluetoothGattDescriptor&gt;'] and parameter[7][@type='int']]"
		[Register ("鷭", "(Landroid/bluetooth/BluetoothGatt;Ljava/util/UUID;[BIILjava/util/List;I)V", "GetInvoke鷭_Landroid_bluetooth_BluetoothGatt_Ljava_util_UUID_arrayBIILjava_util_List_IHandler")]
		public virtual unsafe void Invoke鷭 (global::Android.Bluetooth.BluetoothGatt p0, global::Java.Util.UUID p1, byte[] p2, int p3, int p4, global::System.Collections.Generic.IList<global::Android.Bluetooth.BluetoothGattDescriptor> p5, int p6)
		{
			if (id_鷭_Landroid_bluetooth_BluetoothGatt_Ljava_util_UUID_arrayBIILjava_util_List_I == IntPtr.Zero)
				id_鷭_Landroid_bluetooth_BluetoothGatt_Ljava_util_UUID_arrayBIILjava_util_List_I = JNIEnv.GetMethodID (class_ref, "鷭", "(Landroid/bluetooth/BluetoothGatt;Ljava/util/UUID;[BIILjava/util/List;I)V");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p5 = global::Android.Runtime.JavaList<global::Android.Bluetooth.BluetoothGattDescriptor>.ToLocalJniHandle (p5);
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (native_p5);
				__args [6] = new JValue (p6);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_鷭_Landroid_bluetooth_BluetoothGatt_Ljava_util_UUID_arrayBIILjava_util_List_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "鷭", "(Landroid/bluetooth/BluetoothGatt;Ljava/util/UUID;[BIILjava/util/List;I)V"), __args);
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				JNIEnv.DeleteLocalRef (native_p5);
			}
		}

		static Delegate cb_鷭_Landroid_bluetooth_BluetoothGatt_Ljava_util_UUID_arrayBILjava_util_UUID_I;
#pragma warning disable 0169
		static Delegate GetInvoke鷭_Landroid_bluetooth_BluetoothGatt_Ljava_util_UUID_arrayBILjava_util_UUID_IHandler ()
		{
			if (cb_鷭_Landroid_bluetooth_BluetoothGatt_Ljava_util_UUID_arrayBILjava_util_UUID_I == null)
				cb_鷭_Landroid_bluetooth_BluetoothGatt_Ljava_util_UUID_arrayBILjava_util_UUID_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr, int>) n_Invoke鷭_Landroid_bluetooth_BluetoothGatt_Ljava_util_UUID_arrayBILjava_util_UUID_I);
			return cb_鷭_Landroid_bluetooth_BluetoothGatt_Ljava_util_UUID_arrayBILjava_util_UUID_I;
		}

		static void n_Invoke鷭_Landroid_bluetooth_BluetoothGatt_Ljava_util_UUID_arrayBILjava_util_UUID_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, int p3, IntPtr native_p4, int p5)
		{
			global::Com.Qcl.VH.Ble.BaseGattClient __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Ble.BaseGattClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Bluetooth.BluetoothGatt p0 = global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothGatt> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.UUID p1 = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_p1, JniHandleOwnership.DoNotTransfer);
			byte[] p2 = (byte[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			global::Java.Util.UUID p4 = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.Invoke鷭 (p0, p1, p2, p3, p4, p5);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		static IntPtr id_鷭_Landroid_bluetooth_BluetoothGatt_Ljava_util_UUID_arrayBILjava_util_UUID_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BaseGattClient']/method[@name='鷭' and count(parameter)=6 and parameter[1][@type='android.bluetooth.BluetoothGatt'] and parameter[2][@type='java.util.UUID'] and parameter[3][@type='byte[]'] and parameter[4][@type='int'] and parameter[5][@type='java.util.UUID'] and parameter[6][@type='int']]"
		[Register ("鷭", "(Landroid/bluetooth/BluetoothGatt;Ljava/util/UUID;[BILjava/util/UUID;I)V", "GetInvoke鷭_Landroid_bluetooth_BluetoothGatt_Ljava_util_UUID_arrayBILjava_util_UUID_IHandler")]
		public virtual unsafe void Invoke鷭 (global::Android.Bluetooth.BluetoothGatt p0, global::Java.Util.UUID p1, byte[] p2, int p3, global::Java.Util.UUID p4, int p5)
		{
			if (id_鷭_Landroid_bluetooth_BluetoothGatt_Ljava_util_UUID_arrayBILjava_util_UUID_I == IntPtr.Zero)
				id_鷭_Landroid_bluetooth_BluetoothGatt_Ljava_util_UUID_arrayBILjava_util_UUID_I = JNIEnv.GetMethodID (class_ref, "鷭", "(Landroid/bluetooth/BluetoothGatt;Ljava/util/UUID;[BILjava/util/UUID;I)V");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_鷭_Landroid_bluetooth_BluetoothGatt_Ljava_util_UUID_arrayBILjava_util_UUID_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "鷭", "(Landroid/bluetooth/BluetoothGatt;Ljava/util/UUID;[BILjava/util/UUID;I)V"), __args);
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static IntPtr id_鷭_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BaseGattClient']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("鷭", "(Landroid/content/Context;)V", "")]
		public unsafe void Invoke鷭 (global::Android.Content.Context p0)
		{
			if (id_鷭_Landroid_content_Context_ == IntPtr.Zero)
				id_鷭_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "鷭", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_鷭_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static Delegate cb_鷭_arrayB;
#pragma warning disable 0169
		static Delegate GetInvoke鷭_arrayBHandler ()
		{
			if (cb_鷭_arrayB == null)
				cb_鷭_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Invoke鷭_arrayB);
			return cb_鷭_arrayB;
		}

		static bool n_Invoke鷭_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Qcl.VH.Ble.BaseGattClient __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Ble.BaseGattClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			bool __ret = __this.Invoke鷭 (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BaseGattClient']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("鷭", "([B)Z", "GetInvoke鷭_arrayBHandler")]
		protected abstract bool Invoke鷭 (byte[] p0);

		static IntPtr id_鷭_arrayBLcom_qcl_vh_ble_BaseGattClient_if_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BaseGattClient']/method[@name='鷭' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='com.qcl.vh.ble.BaseGattClient.if']]"
		[Register ("鷭", "([BLcom/qcl/vh/ble/BaseGattClient$if;)V", "")]
		protected unsafe void Invoke鷭 (byte[] p0, global::Com.Qcl.VH.Ble.BaseGattClient.If p1)
		{
			if (id_鷭_arrayBLcom_qcl_vh_ble_BaseGattClient_if_ == IntPtr.Zero)
				id_鷭_arrayBLcom_qcl_vh_ble_BaseGattClient_if_ = JNIEnv.GetMethodID (class_ref, "鷭", "([BLcom/qcl/vh/ble/BaseGattClient$if;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod  (Handle, id_鷭_arrayBLcom_qcl_vh_ble_BaseGattClient_if_, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_鷭_arrayBI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BaseGattClient']/method[@name='鷭' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("鷭", "([BI)V", "")]
		protected static unsafe void Invoke鷭 (byte[] p0, int p1)
		{
			if (id_鷭_arrayBI == IntPtr.Zero)
				id_鷭_arrayBI = JNIEnv.GetStaticMethodID (class_ref, "鷭", "([BI)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_鷭_arrayBI, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_鷭_Lcom_qcl_vh_a_c_廅_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BaseGattClient']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='com.qcl.vh.a.c.廅']]"
		[Register ("鷭", "(Lcom/qcl/vh/a/c/廅;)V", "")]
		protected unsafe void Invoke鷭 (global::Com.Qcl.VH.A.C.廅 p0)
		{
			if (id_鷭_Lcom_qcl_vh_a_c_廅_ == IntPtr.Zero)
				id_鷭_Lcom_qcl_vh_a_c_廅_ = JNIEnv.GetMethodID (class_ref, "鷭", "(Lcom/qcl/vh/a/c/廅;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_鷭_Lcom_qcl_vh_a_c_廅_, __args);
			} finally {
			}
		}

		static IntPtr id_鷭_Lcom_qcl_vh_content_ˮ͈_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BaseGattClient']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='com.qcl.vh.content.ˮ͈']]"
		[Obsolete (@"deprecated")]
		[Register ("鷭", "(Lcom/qcl/vh/content/ˮ͈;)V", "")]
		protected unsafe void Invoke鷭 (global::Com.Qcl.VH.Content.ˮ͈ p0)
		{
			if (id_鷭_Lcom_qcl_vh_content_ˮ͈_ == IntPtr.Zero)
				id_鷭_Lcom_qcl_vh_content_ˮ͈_ = JNIEnv.GetMethodID (class_ref, "鷭", "(Lcom/qcl/vh/content/ˮ͈;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_鷭_Lcom_qcl_vh_content_ˮ͈_, __args);
			} finally {
			}
		}

		static IntPtr id_鷭_Lcom_qcl_vh_content_ˮ͈_Lcom_qcl_vh_a_c_廅_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BaseGattClient']/method[@name='鷭' and count(parameter)=2 and parameter[1][@type='com.qcl.vh.content.ˮ͈'] and parameter[2][@type='com.qcl.vh.a.c.廅']]"
		[Register ("鷭", "(Lcom/qcl/vh/content/ˮ͈;Lcom/qcl/vh/a/c/廅;)V", "")]
		protected unsafe void Invoke鷭 (global::Com.Qcl.VH.Content.ˮ͈ p0, global::Com.Qcl.VH.A.C.廅 p1)
		{
			if (id_鷭_Lcom_qcl_vh_content_ˮ͈_Lcom_qcl_vh_a_c_廅_ == IntPtr.Zero)
				id_鷭_Lcom_qcl_vh_content_ˮ͈_Lcom_qcl_vh_a_c_廅_ = JNIEnv.GetMethodID (class_ref, "鷭", "(Lcom/qcl/vh/content/ˮ͈;Lcom/qcl/vh/a/c/廅;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod  (Handle, id_鷭_Lcom_qcl_vh_content_ˮ͈_Lcom_qcl_vh_a_c_廅_, __args);
			} finally {
			}
		}

		static IntPtr id_鷭_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BaseGattClient']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("鷭", "(Ljava/lang/String;)Ljava/util/UUID;", "")]
		public static unsafe global::Java.Util.UUID Invoke鷭 (string p0)
		{
			if (id_鷭_Ljava_lang_String_ == IntPtr.Zero)
				id_鷭_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "鷭", "(Ljava/lang/String;)Ljava/util/UUID;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Java.Util.UUID __ret = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (JNIEnv.CallStaticObjectMethod  (class_ref, id_鷭_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_鷭_Ljava_lang_String_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BaseGattClient']/method[@name='鷭' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]']]"
		[Register ("鷭", "(Ljava/lang/String;[B)Lcom/qcl/vh/a/c/廅;", "")]
		protected unsafe global::Com.Qcl.VH.A.C.廅 Invoke鷭 (string p0, byte[] p1)
		{
			if (id_鷭_Ljava_lang_String_arrayB == IntPtr.Zero)
				id_鷭_Ljava_lang_String_arrayB = JNIEnv.GetMethodID (class_ref, "鷭", "(Ljava/lang/String;[B)Lcom/qcl/vh/a/c/廅;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				global::Com.Qcl.VH.A.C.廅 __ret = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.A.C.廅> (JNIEnv.CallObjectMethod  (Handle, id_鷭_Ljava_lang_String_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_鷭_Ljava_lang_String_Lcom_qcl_vh_ble_BaseGattClient_if_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BaseGattClient']/method[@name='鷭' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.qcl.vh.ble.BaseGattClient.if']]"
		[Register ("鷭", "(Ljava/lang/String;Lcom/qcl/vh/ble/BaseGattClient$if;)V", "")]
		protected unsafe void Invoke鷭 (string p0, global::Com.Qcl.VH.Ble.BaseGattClient.If p1)
		{
			if (id_鷭_Ljava_lang_String_Lcom_qcl_vh_ble_BaseGattClient_if_ == IntPtr.Zero)
				id_鷭_Ljava_lang_String_Lcom_qcl_vh_ble_BaseGattClient_if_ = JNIEnv.GetMethodID (class_ref, "鷭", "(Ljava/lang/String;Lcom/qcl/vh/ble/BaseGattClient$if;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod  (Handle, id_鷭_Ljava_lang_String_Lcom_qcl_vh_ble_BaseGattClient_if_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_鷭_Ljava_util_LinkedList_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BaseGattClient']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='java.util.LinkedList&lt;java.util.AbstractMap.SimpleEntry&lt;java.util.UUID, byte[]&gt;&gt;']]"
		[Register ("鷭", "(Ljava/util/LinkedList;)V", "")]
		protected unsafe void Invoke鷭 (global::Java.Util.LinkedList p0)
		{
			if (id_鷭_Ljava_util_LinkedList_ == IntPtr.Zero)
				id_鷭_Ljava_util_LinkedList_ = JNIEnv.GetMethodID (class_ref, "鷭", "(Ljava/util/LinkedList;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_鷭_Ljava_util_LinkedList_, __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/qcl/vh/ble/BaseGattClient", DoNotGenerateAcw=true)]
	internal partial class BaseGattClientInvoker : BaseGattClient {

		public BaseGattClientInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseGattClientInvoker); }
		}

		static IntPtr id_櫯_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BaseGattClient']/method[@name='櫯' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("櫯", "([B)Z", "Get櫯_arrayBHandler")]
		protected override unsafe bool 櫯 (byte[] p0)
		{
			if (id_櫯_arrayB == IntPtr.Zero)
				id_櫯_arrayB = JNIEnv.GetMethodID (class_ref, "櫯", "([B)Z");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_櫯_arrayB, __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_鷭;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BaseGattClient']/method[@name='鷭' and count(parameter)=0]"
		[Register ("鷭", "()Landroid/bluetooth/le/ScanFilter;", "GetInvoke鷭Handler")]
		protected override unsafe global::Android.Bluetooth.LE.ScanFilter Invoke鷭 ()
		{
			if (id_鷭 == IntPtr.Zero)
				id_鷭 = JNIEnv.GetMethodID (class_ref, "鷭", "()Landroid/bluetooth/le/ScanFilter;");
			try {
				return global::Java.Lang.Object.GetObject<global::Android.Bluetooth.LE.ScanFilter> (JNIEnv.CallObjectMethod  (Handle, id_鷭), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_鷭_Landroid_bluetooth_BluetoothGatt_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BaseGattClient']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='android.bluetooth.BluetoothGatt']]"
		[Register ("鷭", "(Landroid/bluetooth/BluetoothGatt;)V", "GetInvoke鷭_Landroid_bluetooth_BluetoothGatt_Handler")]
		protected override unsafe void Invoke鷭 (global::Android.Bluetooth.BluetoothGatt p0)
		{
			if (id_鷭_Landroid_bluetooth_BluetoothGatt_ == IntPtr.Zero)
				id_鷭_Landroid_bluetooth_BluetoothGatt_ = JNIEnv.GetMethodID (class_ref, "鷭", "(Landroid/bluetooth/BluetoothGatt;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_鷭_Landroid_bluetooth_BluetoothGatt_, __args);
			} finally {
			}
		}

		static IntPtr id_鷭_Landroid_bluetooth_BluetoothGatt_Ljava_util_UUID_arrayBIILjava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BaseGattClient']/method[@name='鷭' and count(parameter)=6 and parameter[1][@type='android.bluetooth.BluetoothGatt'] and parameter[2][@type='java.util.UUID'] and parameter[3][@type='byte[]'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='java.util.List&lt;android.bluetooth.BluetoothGattDescriptor&gt;']]"
		[Register ("鷭", "(Landroid/bluetooth/BluetoothGatt;Ljava/util/UUID;[BIILjava/util/List;)V", "GetInvoke鷭_Landroid_bluetooth_BluetoothGatt_Ljava_util_UUID_arrayBIILjava_util_List_Handler")]
		public override unsafe void Invoke鷭 (global::Android.Bluetooth.BluetoothGatt p0, global::Java.Util.UUID p1, byte[] p2, int p3, int p4, global::System.Collections.Generic.IList<global::Android.Bluetooth.BluetoothGattDescriptor> p5)
		{
			if (id_鷭_Landroid_bluetooth_BluetoothGatt_Ljava_util_UUID_arrayBIILjava_util_List_ == IntPtr.Zero)
				id_鷭_Landroid_bluetooth_BluetoothGatt_Ljava_util_UUID_arrayBIILjava_util_List_ = JNIEnv.GetMethodID (class_ref, "鷭", "(Landroid/bluetooth/BluetoothGatt;Ljava/util/UUID;[BIILjava/util/List;)V");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p5 = global::Android.Runtime.JavaList<global::Android.Bluetooth.BluetoothGattDescriptor>.ToLocalJniHandle (p5);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (native_p5);
				JNIEnv.CallVoidMethod  (Handle, id_鷭_Landroid_bluetooth_BluetoothGatt_Ljava_util_UUID_arrayBIILjava_util_List_, __args);
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				JNIEnv.DeleteLocalRef (native_p5);
			}
		}

		static IntPtr id_鷭_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble']/class[@name='BaseGattClient']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("鷭", "([B)Z", "GetInvoke鷭_arrayBHandler")]
		protected override unsafe bool Invoke鷭 (byte[] p0)
		{
			if (id_鷭_arrayB == IntPtr.Zero)
				id_鷭_arrayB = JNIEnv.GetMethodID (class_ref, "鷭", "([B)Z");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_鷭_arrayB, __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}

}
