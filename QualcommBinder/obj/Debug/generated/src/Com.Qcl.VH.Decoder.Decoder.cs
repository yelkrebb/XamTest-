using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.Decoder {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.decoder']/class[@name='Decoder']"
	[global::Android.Runtime.Register ("com/qcl/vh/decoder/Decoder", DoNotGenerateAcw=true)]
	public partial class Decoder : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qcl/vh/decoder/Decoder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Decoder); }
		}

		protected Decoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.decoder']/class[@name='Decoder']/constructor[@name='Decoder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Decoder ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Decoder)) {
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

		static IntPtr id_decodeData_arrayBI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.decoder']/class[@name='Decoder']/method[@name='decodeData' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("decodeData", "([BI)Ljava/lang/String;", "")]
		public static unsafe string DecodeData (byte[] p0, int p1)
		{
			if (id_decodeData_arrayBI == IntPtr.Zero)
				id_decodeData_arrayBI = JNIEnv.GetStaticMethodID (class_ref, "decodeData", "([BI)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_decodeData_arrayBI, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_鷭_arrayBLcom_qcl_vh_decoder_鷭_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.decoder']/class[@name='Decoder']/method[@name='鷭' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='com.qcl.vh.decoder.鷭']]"
		[Register ("鷭", "([BLcom/qcl/vh/decoder/鷭;)Ljava/lang/String;", "")]
		public static unsafe string 鷭 (byte[] p0, global::Com.Qcl.VH.Decoder.鷭 p1)
		{
			if (id_鷭_arrayBLcom_qcl_vh_decoder_鷭_ == IntPtr.Zero)
				id_鷭_arrayBLcom_qcl_vh_decoder_鷭_ = JNIEnv.GetStaticMethodID (class_ref, "鷭", "([BLcom/qcl/vh/decoder/鷭;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_鷭_arrayBLcom_qcl_vh_decoder_鷭_, __args), JniHandleOwnership.TransferLocalRef);
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
