using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.MD.And {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.md.and']/class[@name='AndWeightScaleGattClient']"
	[global::Android.Runtime.Register ("com/qcl/vh/md/and/AndWeightScaleGattClient", DoNotGenerateAcw=true)]
	public partial class AndWeightScaleGattClient : global::Com.Qcl.VH.MD.And.AndBaseGattClient {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qcl/vh/md/and/AndWeightScaleGattClient", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AndWeightScaleGattClient); }
		}

		protected AndWeightScaleGattClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.md.and']/class[@name='AndWeightScaleGattClient']/constructor[@name='AndWeightScaleGattClient' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AndWeightScaleGattClient ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (AndWeightScaleGattClient)) {
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

		static IntPtr id_ć;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.and']/class[@name='AndWeightScaleGattClient']/method[@name='ć' and count(parameter)=0]"
		[Register ("ć", "()V", "")]
		protected override sealed unsafe void Ć ()
		{
			if (id_ć == IntPtr.Zero)
				id_ć = JNIEnv.GetMethodID (class_ref, "ć", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_ć);
			} finally {
			}
		}

		static IntPtr id_ˮ͈_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.and']/class[@name='AndWeightScaleGattClient']/method[@name='ˮ͈' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("ˮ͈", "([B)Ljava/util/HashMap;", "")]
		protected override sealed unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Integer> ˮ͈ (byte[] p0)
		{
			if (id_ˮ͈_arrayB == IntPtr.Zero)
				id_ˮ͈_arrayB = JNIEnv.GetMethodID (class_ref, "ˮ͈", "([B)Ljava/util/HashMap;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Integer> __ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Integer>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_ˮ͈_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_ˮ͍;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.and']/class[@name='AndWeightScaleGattClient']/method[@name='ˮ͍' and count(parameter)=0]"
		[Register ("ˮ͍", "()V", "")]
		protected override sealed unsafe void ˮ͍ ()
		{
			if (id_ˮ͍ == IntPtr.Zero)
				id_ˮ͍ = JNIEnv.GetMethodID (class_ref, "ˮ͍", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_ˮ͍);
			} finally {
			}
		}

		static IntPtr id_櫯_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.and']/class[@name='AndWeightScaleGattClient']/method[@name='櫯' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("櫯", "([B)Z", "")]
		protected override sealed unsafe bool 櫯 (byte[] p0)
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.and']/class[@name='AndWeightScaleGattClient']/method[@name='鷭' and count(parameter)=0]"
		[Register ("鷭", "()Landroid/bluetooth/le/ScanFilter;", "")]
		protected override sealed unsafe global::Android.Bluetooth.LE.ScanFilter 鷭 ()
		{
			if (id_鷭 == IntPtr.Zero)
				id_鷭 = JNIEnv.GetMethodID (class_ref, "鷭", "()Landroid/bluetooth/le/ScanFilter;");
			try {
				return global::Java.Lang.Object.GetObject<global::Android.Bluetooth.LE.ScanFilter> (JNIEnv.CallObjectMethod  (Handle, id_鷭), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_鷭_Ljava_util_UUID_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.and']/class[@name='AndWeightScaleGattClient']/method[@name='鷭' and count(parameter)=2 and parameter[1][@type='java.util.UUID'] and parameter[2][@type='byte[]']]"
		[Register ("鷭", "(Ljava/util/UUID;[B)V", "")]
		protected override sealed unsafe void 鷭 (global::Java.Util.UUID p0, byte[] p1)
		{
			if (id_鷭_Ljava_util_UUID_arrayB == IntPtr.Zero)
				id_鷭_Ljava_util_UUID_arrayB = JNIEnv.GetMethodID (class_ref, "鷭", "(Ljava/util/UUID;[B)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallVoidMethod  (Handle, id_鷭_Ljava_util_UUID_arrayB, __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

	}
}
