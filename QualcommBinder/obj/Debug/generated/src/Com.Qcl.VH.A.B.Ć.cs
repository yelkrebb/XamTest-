using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.A.B {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.a.b']/class[@name='ć']"
	[global::Android.Runtime.Register ("com/qcl/vh/a/b/ć", DoNotGenerateAcw=true)]
	public sealed partial class Ć : global::Com.Qcl.VH.A.D.鷭, global::Com.Qcl.VH.A.D.IIF {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.a.b']/class[@name='ć.if']"
		[global::Android.Runtime.Register ("com/qcl/vh/a/b/ć$if", DoNotGenerateAcw=true)]
		public partial class If : global::Java.Lang.Object, global::Com.Qcl.VH.A.D.Ą.I鷭 {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/qcl/vh/a/b/ć$if", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (If); }
			}

			protected If (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_qcl_vh_a_b_ć_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.a.b']/class[@name='ć.if']/constructor[@name='ć.if' and count(parameter)=1 and parameter[1][@type='com.qcl.vh.a.b.ć']]"
			[Register (".ctor", "(Lcom/qcl/vh/a/b/ć;)V", "")]
			public unsafe If (global::Com.Qcl.VH.A.B.Ć __self)
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

					if (id_ctor_Lcom_qcl_vh_a_b_ć_ == IntPtr.Zero)
						id_ctor_Lcom_qcl_vh_a_b_ć_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/qcl/vh/a/b/ć;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_qcl_vh_a_b_ć_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_qcl_vh_a_b_ć_, __args);
				} finally {
				}
			}

			static IntPtr id_ctor_Lcom_qcl_vh_a_b_ć_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.a.b']/class[@name='ć.if']/constructor[@name='ć.if' and count(parameter)=1 and parameter[1][@type='com.qcl.vh.a.b.ć']]"
			[Register (".ctor", "(Lcom/qcl/vh/a/b/ć;)V", "")]
			public unsafe If (global::Com.Qcl.VH.A.B.Ć __self)
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

					if (id_ctor_Lcom_qcl_vh_a_b_ć_ == IntPtr.Zero)
						id_ctor_Lcom_qcl_vh_a_b_ć_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/qcl/vh/a/b/ć;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_qcl_vh_a_b_ć_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_qcl_vh_a_b_ć_, __args);
				} finally {
				}
			}

			static IntPtr id_ˮ͈_Landroid_bluetooth_BluetoothDevice_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.b']/class[@name='ć.if']/method[@name='ˮ͈' and count(parameter)=1 and parameter[1][@type='android.bluetooth.BluetoothDevice']]"
			[Register ("ˮ͈", "(Landroid/bluetooth/BluetoothDevice;)Z", "")]
			public static unsafe bool ˮ͈ (global::Android.Bluetooth.BluetoothDevice p0)
			{
				if (id_ˮ͈_Landroid_bluetooth_BluetoothDevice_ == IntPtr.Zero)
					id_ˮ͈_Landroid_bluetooth_BluetoothDevice_ = JNIEnv.GetStaticMethodID (class_ref, "ˮ͈", "(Landroid/bluetooth/BluetoothDevice;)Z");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_ˮ͈_Landroid_bluetooth_BluetoothDevice_, __args);
					return __ret;
				} finally {
				}
			}

			static IntPtr id_櫯_Landroid_bluetooth_BluetoothDevice_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.b']/class[@name='ć.if']/method[@name='櫯' and count(parameter)=1 and parameter[1][@type='android.bluetooth.BluetoothDevice']]"
			[Register ("櫯", "(Landroid/bluetooth/BluetoothDevice;)Z", "")]
			public static unsafe bool 櫯 (global::Android.Bluetooth.BluetoothDevice p0)
			{
				if (id_櫯_Landroid_bluetooth_BluetoothDevice_ == IntPtr.Zero)
					id_櫯_Landroid_bluetooth_BluetoothDevice_ = JNIEnv.GetStaticMethodID (class_ref, "櫯", "(Landroid/bluetooth/BluetoothDevice;)Z");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_櫯_Landroid_bluetooth_BluetoothDevice_, __args);
					return __ret;
				} finally {
				}
			}

			static IntPtr id_鷭_Landroid_bluetooth_BluetoothAdapter_Ljava_lang_Integer_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.b']/class[@name='ć.if']/method[@name='鷭' and count(parameter)=2 and parameter[1][@type='android.bluetooth.BluetoothAdapter'] and parameter[2][@type='java.lang.Integer']]"
			[Register ("鷭", "(Landroid/bluetooth/BluetoothAdapter;Ljava/lang/Integer;)Landroid/bluetooth/BluetoothServerSocket;", "")]
			public static unsafe global::Android.Bluetooth.BluetoothServerSocket 鷭 (global::Android.Bluetooth.BluetoothAdapter p0, global::Java.Lang.Integer p1)
			{
				if (id_鷭_Landroid_bluetooth_BluetoothAdapter_Ljava_lang_Integer_ == IntPtr.Zero)
					id_鷭_Landroid_bluetooth_BluetoothAdapter_Ljava_lang_Integer_ = JNIEnv.GetStaticMethodID (class_ref, "鷭", "(Landroid/bluetooth/BluetoothAdapter;Ljava/lang/Integer;)Landroid/bluetooth/BluetoothServerSocket;");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					global::Android.Bluetooth.BluetoothServerSocket __ret = global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothServerSocket> (JNIEnv.CallStaticObjectMethod  (class_ref, id_鷭_Landroid_bluetooth_BluetoothAdapter_Ljava_lang_Integer_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static IntPtr id_鷭_Landroid_bluetooth_BluetoothDevice_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.b']/class[@name='ć.if']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='android.bluetooth.BluetoothDevice']]"
			[Register ("鷭", "(Landroid/bluetooth/BluetoothDevice;)Z", "")]
			public static unsafe bool 鷭 (global::Android.Bluetooth.BluetoothDevice p0)
			{
				if (id_鷭_Landroid_bluetooth_BluetoothDevice_ == IntPtr.Zero)
					id_鷭_Landroid_bluetooth_BluetoothDevice_ = JNIEnv.GetStaticMethodID (class_ref, "鷭", "(Landroid/bluetooth/BluetoothDevice;)Z");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_鷭_Landroid_bluetooth_BluetoothDevice_, __args);
					return __ret;
				} finally {
				}
			}

			static IntPtr id_鷭_Landroid_bluetooth_BluetoothDevice_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.b']/class[@name='ć.if']/method[@name='鷭' and count(parameter)=2 and parameter[1][@type='android.bluetooth.BluetoothDevice'] and parameter[2][@type='java.lang.String']]"
			[Register ("鷭", "(Landroid/bluetooth/BluetoothDevice;Ljava/lang/String;)Z", "")]
			public static unsafe bool 鷭 (global::Android.Bluetooth.BluetoothDevice p0, string p1)
			{
				if (id_鷭_Landroid_bluetooth_BluetoothDevice_Ljava_lang_String_ == IntPtr.Zero)
					id_鷭_Landroid_bluetooth_BluetoothDevice_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "鷭", "(Landroid/bluetooth/BluetoothDevice;Ljava/lang/String;)Z");
				IntPtr native_p1 = JNIEnv.NewString (p1);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (native_p1);
					bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_鷭_Landroid_bluetooth_BluetoothDevice_Ljava_lang_String_, __args);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

			static IntPtr id_鷭_Landroid_bluetooth_BluetoothServerSocket_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.b']/class[@name='ć.if']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='android.bluetooth.BluetoothServerSocket']]"
			[Register ("鷭", "(Landroid/bluetooth/BluetoothServerSocket;)Ljava/lang/Integer;", "")]
			public static unsafe global::Java.Lang.Integer 鷭 (global::Android.Bluetooth.BluetoothServerSocket p0)
			{
				if (id_鷭_Landroid_bluetooth_BluetoothServerSocket_ == IntPtr.Zero)
					id_鷭_Landroid_bluetooth_BluetoothServerSocket_ = JNIEnv.GetStaticMethodID (class_ref, "鷭", "(Landroid/bluetooth/BluetoothServerSocket;)Ljava/lang/Integer;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					global::Java.Lang.Integer __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_鷭_Landroid_bluetooth_BluetoothServerSocket_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static IntPtr id_鷭_Landroid_content_Context_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.b']/class[@name='ć.if']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
			[Register ("鷭", "(Landroid/content/Context;)Z", "")]
			public static unsafe bool 鷭 (global::Android.Content.Context p0)
			{
				if (id_鷭_Landroid_content_Context_ == IntPtr.Zero)
					id_鷭_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "鷭", "(Landroid/content/Context;)Z");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_鷭_Landroid_content_Context_, __args);
					return __ret;
				} finally {
				}
			}

			static IntPtr id_鷭_Ljava_io_InputStream_II;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.b']/class[@name='ć.if']/method[@name='鷭' and count(parameter)=3 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("鷭", "(Ljava/io/InputStream;II)Z", "")]
			public static unsafe bool 鷭 (global::System.IO.Stream p0, int p1, int p2)
			{
				if (id_鷭_Ljava_io_InputStream_II == IntPtr.Zero)
					id_鷭_Ljava_io_InputStream_II = JNIEnv.GetStaticMethodID (class_ref, "鷭", "(Ljava/io/InputStream;II)Z");
				IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_鷭_Ljava_io_InputStream_II, __args);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_鷭_Ljava_io_InputStream_J;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.b']/class[@name='ć.if']/method[@name='鷭' and count(parameter)=2 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='long']]"
			[Register ("鷭", "(Ljava/io/InputStream;J)Z", "")]
			public static unsafe bool 鷭 (global::System.IO.Stream p0, long p1)
			{
				if (id_鷭_Ljava_io_InputStream_J == IntPtr.Zero)
					id_鷭_Ljava_io_InputStream_J = JNIEnv.GetStaticMethodID (class_ref, "鷭", "(Ljava/io/InputStream;J)Z");
				IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (p1);
					bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_鷭_Ljava_io_InputStream_J, __args);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// This method is explicitly implemented as a member of an instantiated Com.Qcl.VH.A.D.Ą.I鷭
			global::Java.Lang.Object global::Com.Qcl.VH.A.D.Ą.I鷭.鷭 (global::System.IO.Stream p0)
			{
				return global::Java.Interop.JavaObjectExtensions.JavaCast<Java.Lang.Object>(鷭 (p0));
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.a.b']/class[@name='ć.鷭']"
		[global::Android.Runtime.Register ("com/qcl/vh/a/b/ć$鷭", DoNotGenerateAcw=true)]
		public partial class 鷭 : global::Java.Lang.Object, global::Com.Qcl.VH.A.D.Ą.I鷭 {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/qcl/vh/a/b/ć$鷭", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (鷭); }
			}

			protected 鷭 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_鷭_Ljava_io_ByteArrayOutputStream_Ljava_lang_Object_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.b']/class[@name='ć.鷭']/method[@name='鷭' and count(parameter)=2 and parameter[1][@type='java.io.ByteArrayOutputStream'] and parameter[2][@type='java.lang.Object']]"
			[Register ("鷭", "(Ljava/io/ByteArrayOutputStream;Ljava/lang/Object;)V", "")]
			public unsafe void Invoke鷭 (global::Java.IO.ByteArrayOutputStream p0, global::Java.Lang.Object p1)
			{
				if (id_鷭_Ljava_io_ByteArrayOutputStream_Ljava_lang_Object_ == IntPtr.Zero)
					id_鷭_Ljava_io_ByteArrayOutputStream_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "鷭", "(Ljava/io/ByteArrayOutputStream;Ljava/lang/Object;)V");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					JNIEnv.CallVoidMethod  (Handle, id_鷭_Ljava_io_ByteArrayOutputStream_Ljava_lang_Object_, __args);
				} finally {
				}
			}

			// This method is explicitly implemented as a member of an instantiated Com.Qcl.VH.A.D.Ą.I鷭
			void global::Com.Qcl.VH.A.D.Ą.I鷭.鷭 (global::System.IO.Stream p0, global::Java.Lang.Object p1)
			{
				鷭 (p0, global::Java.Interop.JavaObjectExtensions.JavaCast<global::Com.Qcl.VH.A.C.Ȋ>(p1));
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qcl/vh/a/b/ć", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Ć); }
		}

		internal Ć (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.a.b']/class[@name='ć']/constructor[@name='ć' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Ć ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Ć)) {
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

		// This method is explicitly implemented as a member of an instantiated Com.Qcl.VH.A.D.IIF
		global::Com.Qcl.VH.A.D.Ą.I鷭 global::Com.Qcl.VH.A.D.IIF.櫯 ()
		{
			return global::Java.Interop.JavaObjectExtensions.JavaCast<Com.Qcl.VH.A.D.Ą.I鷭>(櫯 ());
		}

		// This method is explicitly implemented as a member of an instantiated Com.Qcl.VH.A.D.IIF
		global::Com.Qcl.VH.A.D.Ą.I鷭 global::Com.Qcl.VH.A.D.IIF.鷭 ()
		{
			return global::Java.Interop.JavaObjectExtensions.JavaCast<Com.Qcl.VH.A.D.Ą.I鷭>(鷭 ());
		}

	}
}
