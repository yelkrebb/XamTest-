using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.Ble.A {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.ble.a']/class[@name='if']"
	[global::Android.Runtime.Register ("com/qcl/vh/ble/a/if", DoNotGenerateAcw=true)]
	public sealed partial class If : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qcl/vh/ble/a/if", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (If); }
		}

		internal If (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.ble.a']/class[@name='if']/constructor[@name='if' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe If ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (If)) {
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

		static IntPtr id_鷭_BBBIBIZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble.a']/class[@name='if']/method[@name='鷭' and count(parameter)=8 and parameter[1][@type='byte'] and parameter[2][@type='byte'] and parameter[3][@type='byte'] and parameter[4][@type='int'] and parameter[5][@type='byte'] and parameter[6][@type='int'] and parameter[7][@type='boolean'] and parameter[8][@type='boolean']]"
		[Register ("鷭", "(BBBIBIZZ)[B", "")]
		public static unsafe byte[] 鷭 (sbyte p0, sbyte p1, sbyte p2, int p3, sbyte p4, int p5, bool p6, bool p7)
		{
			if (id_鷭_BBBIBIZZ == IntPtr.Zero)
				id_鷭_BBBIBIZZ = JNIEnv.GetStaticMethodID (class_ref, "鷭", "(BBBIBIZZ)[B");
			try {
				JValue* __args = stackalloc JValue [8];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_鷭_BBBIBIZZ, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static IntPtr id_鷭_IarrayBBBB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.ble.a']/class[@name='if']/method[@name='鷭' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte'] and parameter[4][@type='byte'] and parameter[5][@type='byte']]"
		[Register ("鷭", "(I[BBBB)[B", "")]
		public static unsafe byte[] 鷭 (int p0, byte[] p1, sbyte p2, sbyte p3, sbyte p4)
		{
			if (id_鷭_IarrayBBBB == IntPtr.Zero)
				id_鷭_IarrayBBBB = JNIEnv.GetStaticMethodID (class_ref, "鷭", "(I[BBBB)[B");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_鷭_IarrayBBBB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

	}
}
