using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.D {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.d']/class[@name='鷭']"
	[global::Android.Runtime.Register ("com/qcl/vh/d/鷭", DoNotGenerateAcw=true)]
	public partial class 鷭 : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.d']/class[@name='鷭.if']"
		[global::Android.Runtime.Register ("com/qcl/vh/d/鷭$if", DoNotGenerateAcw=true)]
		public partial class If : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/qcl/vh/d/鷭$if", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (If); }
			}

			protected If (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.d']/class[@name='鷭.if']/constructor[@name='鷭.if' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
			[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
			public unsafe If (string p0, string p1, string p2)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = JNIEnv.NewString (p0);
				IntPtr native_p1 = JNIEnv.NewString (p1);
				IntPtr native_p2 = JNIEnv.NewString (p2);
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (native_p1);
					__args [2] = new JValue (native_p2);
					if (GetType () != typeof (If)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args);
						return;
					}

					if (id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
						id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					JNIEnv.DeleteLocalRef (native_p1);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}

			static IntPtr id_ȃ;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.d']/class[@name='鷭.if']/method[@name='ȃ' and count(parameter)=0]"
			[Register ("ȃ", "()I", "")]
			public unsafe int Ȃ ()
			{
				if (id_ȃ == IntPtr.Zero)
					id_ȃ = JNIEnv.GetMethodID (class_ref, "ȃ", "()I");
				try {
					return JNIEnv.CallIntMethod  (Handle, id_ȃ);
				} finally {
				}
			}

			static IntPtr id_ˮ͈;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.d']/class[@name='鷭.if']/method[@name='ˮ͈' and count(parameter)=0]"
			[Register ("ˮ͈", "()Ljava/lang/String;", "")]
			public unsafe string ˮ͈ ()
			{
				if (id_ˮ͈ == IntPtr.Zero)
					id_ˮ͈ = JNIEnv.GetMethodID (class_ref, "ˮ͈", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_ˮ͈), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_櫯;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.d']/class[@name='鷭.if']/method[@name='櫯' and count(parameter)=0]"
			[Register ("櫯", "()Ljava/lang/String;", "")]
			public unsafe string 櫯 ()
			{
				if (id_櫯 == IntPtr.Zero)
					id_櫯 = JNIEnv.GetMethodID (class_ref, "櫯", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_櫯), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_鷭;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.d']/class[@name='鷭.if']/method[@name='鷭' and count(parameter)=0]"
			[Register ("鷭", "()Ljava/lang/String;", "")]
			public unsafe string 鷭 ()
			{
				if (id_鷭 == IntPtr.Zero)
					id_鷭 = JNIEnv.GetMethodID (class_ref, "鷭", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_鷭), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_鷭_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.d']/class[@name='鷭.if']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("鷭", "(I)V", "")]
			public unsafe void 鷭 (int p0)
			{
				if (id_鷭_I == IntPtr.Zero)
					id_鷭_I = JNIEnv.GetMethodID (class_ref, "鷭", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					JNIEnv.CallVoidMethod  (Handle, id_鷭_I, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.d']/class[@name='鷭.鷭']"
		[global::Android.Runtime.Register ("com/qcl/vh/d/鷭$鷭", DoNotGenerateAcw=true)]
		public partial class 鷭 : global::Android.Content.BroadcastReceiver {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/qcl/vh/d/鷭$鷭", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (鷭); }
			}

			protected 鷭 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_qcl_vh_d_鷭_arrayLcom_qcl_vh_d_鷭_if_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.d']/class[@name='鷭.鷭']/constructor[@name='鷭.鷭' and count(parameter)=2 and parameter[1][@type='com.qcl.vh.d.鷭'] and parameter[2][@type='com.qcl.vh.d.鷭.if[]']]"
			[Register (".ctor", "(Lcom/qcl/vh/d/鷭;[Lcom/qcl/vh/d/鷭$if;)V", "")]
			public unsafe 鷭 (global::Com.Qcl.VH.D.鷭 __self, global::Com.Qcl.VH.D.鷭.If[] p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p1 = JNIEnv.NewArray (p1);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (native_p1);
					if (GetType () != typeof (鷭)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";[Lcom/qcl/vh/d/鷭$if;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";[Lcom/qcl/vh/d/鷭$if;)V", __args);
						return;
					}

					if (id_ctor_Lcom_qcl_vh_d_鷭_arrayLcom_qcl_vh_d_鷭_if_ == IntPtr.Zero)
						id_ctor_Lcom_qcl_vh_d_鷭_arrayLcom_qcl_vh_d_鷭_if_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/qcl/vh/d/鷭;[Lcom/qcl/vh/d/鷭$if;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_qcl_vh_d_鷭_arrayLcom_qcl_vh_d_鷭_if_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_qcl_vh_d_鷭_arrayLcom_qcl_vh_d_鷭_if_, __args);
				} finally {
					if (p1 != null) {
						JNIEnv.CopyArray (native_p1, p1);
						JNIEnv.DeleteLocalRef (native_p1);
					}
				}
			}

			static IntPtr id_onReceive_Landroid_content_Context_Landroid_content_Intent_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.d']/class[@name='鷭.鷭']/method[@name='onReceive' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.Intent']]"
			[Register ("onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V", "")]
			public override sealed unsafe void OnReceive (global::Android.Content.Context p0, global::Android.Content.Intent p1)
			{
				if (id_onReceive_Landroid_content_Context_Landroid_content_Intent_ == IntPtr.Zero)
					id_onReceive_Landroid_content_Context_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					JNIEnv.CallVoidMethod  (Handle, id_onReceive_Landroid_content_Context_Landroid_content_Intent_, __args);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qcl/vh/d/鷭", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (鷭); }
		}

		protected 鷭 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.d']/class[@name='鷭']/constructor[@name='鷭' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe 鷭 (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (鷭)) {
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

		static IntPtr id_Ą;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.d']/class[@name='鷭']/method[@name='Ą' and count(parameter)=0]"
		[Register ("Ą", "()[Lcom/qcl/vh/d/鷭$if;", "")]
		public unsafe global::Com.Qcl.VH.D.鷭.If[] Ą ()
		{
			if (id_Ą == IntPtr.Zero)
				id_Ą = JNIEnv.GetMethodID (class_ref, "Ą", "()[Lcom/qcl/vh/d/鷭$if;");
			try {
				return (global::Com.Qcl.VH.D.鷭.If[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_Ą), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Qcl.VH.D.鷭.If));
			} finally {
			}
		}

		static IntPtr id_ą;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.d']/class[@name='鷭']/method[@name='ą' and count(parameter)=0]"
		[Register ("ą", "()V", "")]
		public unsafe void Ą ()
		{
			if (id_ą == IntPtr.Zero)
				id_ą = JNIEnv.GetMethodID (class_ref, "ą", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_ą);
			} finally {
			}
		}

		static IntPtr id_ȃ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.d']/class[@name='鷭']/method[@name='ȃ' and count(parameter)=0]"
		[Register ("ȃ", "()V", "")]
		protected unsafe void Ȃ ()
		{
			if (id_ȃ == IntPtr.Zero)
				id_ȃ = JNIEnv.GetMethodID (class_ref, "ȃ", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_ȃ);
			} finally {
			}
		}

		static IntPtr id_ˮ͈;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.d']/class[@name='鷭']/method[@name='ˮ͈' and count(parameter)=0]"
		[Register ("ˮ͈", "()V", "")]
		protected unsafe void ˮ͈ ()
		{
			if (id_ˮ͈ == IntPtr.Zero)
				id_ˮ͈ = JNIEnv.GetMethodID (class_ref, "ˮ͈", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_ˮ͈);
			} finally {
			}
		}

		static IntPtr id_櫯;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.d']/class[@name='鷭']/method[@name='櫯' and count(parameter)=0]"
		[Register ("櫯", "()I", "")]
		protected unsafe int 櫯 ()
		{
			if (id_櫯 == IntPtr.Zero)
				id_櫯 = JNIEnv.GetMethodID (class_ref, "櫯", "()I");
			try {
				return JNIEnv.CallIntMethod  (Handle, id_櫯);
			} finally {
			}
		}

		static IntPtr id_櫯_Landroid_net_wifi_WifiManager_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.d']/class[@name='鷭']/method[@name='櫯' and count(parameter)=1 and parameter[1][@type='android.net.wifi.WifiManager']]"
		[Register ("櫯", "(Landroid/net/wifi/WifiManager;)V", "")]
		public unsafe void 櫯 (global::Android.Net.Wifi.WifiManager p0)
		{
			if (id_櫯_Landroid_net_wifi_WifiManager_ == IntPtr.Zero)
				id_櫯_Landroid_net_wifi_WifiManager_ = JNIEnv.GetMethodID (class_ref, "櫯", "(Landroid/net/wifi/WifiManager;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_櫯_Landroid_net_wifi_WifiManager_, __args);
			} finally {
			}
		}

		static IntPtr id_鷭;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.d']/class[@name='鷭']/method[@name='鷭' and count(parameter)=0]"
		[Register ("鷭", "()V", "")]
		protected unsafe void Invoke鷭 ()
		{
			if (id_鷭 == IntPtr.Zero)
				id_鷭 = JNIEnv.GetMethodID (class_ref, "鷭", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_鷭);
			} finally {
			}
		}

		static IntPtr id_鷭_Landroid_content_Intent_Landroid_net_NetworkInfo_Landroid_net_NetworkInfo_State_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.d']/class[@name='鷭']/method[@name='鷭' and count(parameter)=3 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='android.net.NetworkInfo'] and parameter[3][@type='android.net.NetworkInfo.State']]"
		[Register ("鷭", "(Landroid/content/Intent;Landroid/net/NetworkInfo;Landroid/net/NetworkInfo$State;)Z", "")]
		protected static unsafe bool Invoke鷭 (global::Android.Content.Intent p0, global::Android.Net.NetworkInfo p1, global::Android.Net.NetworkInfo.State p2)
		{
			if (id_鷭_Landroid_content_Intent_Landroid_net_NetworkInfo_Landroid_net_NetworkInfo_State_ == IntPtr.Zero)
				id_鷭_Landroid_content_Intent_Landroid_net_NetworkInfo_Landroid_net_NetworkInfo_State_ = JNIEnv.GetStaticMethodID (class_ref, "鷭", "(Landroid/content/Intent;Landroid/net/NetworkInfo;Landroid/net/NetworkInfo$State;)Z");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_鷭_Landroid_content_Intent_Landroid_net_NetworkInfo_Landroid_net_NetworkInfo_State_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_鷭_Landroid_net_wifi_WifiManager_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.d']/class[@name='鷭']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='android.net.wifi.WifiManager']]"
		[Register ("鷭", "(Landroid/net/wifi/WifiManager;)V", "")]
		public unsafe void Invoke鷭 (global::Android.Net.Wifi.WifiManager p0)
		{
			if (id_鷭_Landroid_net_wifi_WifiManager_ == IntPtr.Zero)
				id_鷭_Landroid_net_wifi_WifiManager_ = JNIEnv.GetMethodID (class_ref, "鷭", "(Landroid/net/wifi/WifiManager;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_鷭_Landroid_net_wifi_WifiManager_, __args);
			} finally {
			}
		}

		static IntPtr id_鷭_Landroid_net_wifi_WifiManager_Lcom_qcl_vh_d_鷭_if_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.d']/class[@name='鷭']/method[@name='鷭' and count(parameter)=2 and parameter[1][@type='android.net.wifi.WifiManager'] and parameter[2][@type='com.qcl.vh.d.鷭.if']]"
		[Register ("鷭", "(Landroid/net/wifi/WifiManager;Lcom/qcl/vh/d/鷭$if;)Z", "")]
		protected unsafe bool Invoke鷭 (global::Android.Net.Wifi.WifiManager p0, global::Com.Qcl.VH.D.鷭.If p1)
		{
			if (id_鷭_Landroid_net_wifi_WifiManager_Lcom_qcl_vh_d_鷭_if_ == IntPtr.Zero)
				id_鷭_Landroid_net_wifi_WifiManager_Lcom_qcl_vh_d_鷭_if_ = JNIEnv.GetMethodID (class_ref, "鷭", "(Landroid/net/wifi/WifiManager;Lcom/qcl/vh/d/鷭$if;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_鷭_Landroid_net_wifi_WifiManager_Lcom_qcl_vh_d_鷭_if_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_鷭_Lcom_qcl_vh_d_鷭_if_Landroid_net_wifi_WifiManager_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.d']/class[@name='鷭']/method[@name='鷭' and count(parameter)=2 and parameter[1][@type='com.qcl.vh.d.鷭.if'] and parameter[2][@type='android.net.wifi.WifiManager']]"
		[Register ("鷭", "(Lcom/qcl/vh/d/鷭$if;Landroid/net/wifi/WifiManager;)V", "")]
		protected unsafe void Invoke鷭 (global::Com.Qcl.VH.D.鷭.If p0, global::Android.Net.Wifi.WifiManager p1)
		{
			if (id_鷭_Lcom_qcl_vh_d_鷭_if_Landroid_net_wifi_WifiManager_ == IntPtr.Zero)
				id_鷭_Lcom_qcl_vh_d_鷭_if_Landroid_net_wifi_WifiManager_ = JNIEnv.GetMethodID (class_ref, "鷭", "(Lcom/qcl/vh/d/鷭$if;Landroid/net/wifi/WifiManager;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod  (Handle, id_鷭_Lcom_qcl_vh_d_鷭_if_Landroid_net_wifi_WifiManager_, __args);
			} finally {
			}
		}

		static IntPtr id_鷭_arrayLcom_qcl_vh_d_鷭_if_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.d']/class[@name='鷭']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='com.qcl.vh.d.鷭.if[]']]"
		[Register ("鷭", "([Lcom/qcl/vh/d/鷭$if;)V", "")]
		public unsafe void Invoke鷭 (global::Com.Qcl.VH.D.鷭.If[] p0)
		{
			if (id_鷭_arrayLcom_qcl_vh_d_鷭_if_ == IntPtr.Zero)
				id_鷭_arrayLcom_qcl_vh_d_鷭_if_ = JNIEnv.GetMethodID (class_ref, "鷭", "([Lcom/qcl/vh/d/鷭$if;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod  (Handle, id_鷭_arrayLcom_qcl_vh_d_鷭_if_, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_鷭_arrayLcom_qcl_vh_d_鷭_if_Landroid_net_wifi_WifiManager_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.d']/class[@name='鷭']/method[@name='鷭' and count(parameter)=2 and parameter[1][@type='com.qcl.vh.d.鷭.if[]'] and parameter[2][@type='android.net.wifi.WifiManager']]"
		[Register ("鷭", "([Lcom/qcl/vh/d/鷭$if;Landroid/net/wifi/WifiManager;)V", "")]
		protected unsafe void Invoke鷭 (global::Com.Qcl.VH.D.鷭.If[] p0, global::Android.Net.Wifi.WifiManager p1)
		{
			if (id_鷭_arrayLcom_qcl_vh_d_鷭_if_Landroid_net_wifi_WifiManager_ == IntPtr.Zero)
				id_鷭_arrayLcom_qcl_vh_d_鷭_if_Landroid_net_wifi_WifiManager_ = JNIEnv.GetMethodID (class_ref, "鷭", "([Lcom/qcl/vh/d/鷭$if;Landroid/net/wifi/WifiManager;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod  (Handle, id_鷭_arrayLcom_qcl_vh_d_鷭_if_Landroid_net_wifi_WifiManager_, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}
}
