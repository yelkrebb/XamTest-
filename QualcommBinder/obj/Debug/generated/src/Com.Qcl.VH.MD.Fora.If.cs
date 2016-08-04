using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.MD.Fora {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.md.fora']/class[@name='If']"
	[global::Android.Runtime.Register ("com/qcl/vh/md/fora/If", DoNotGenerateAcw=true)]
	public sealed partial class If : global::Java.Lang.Object, global::Com.Qcl.VH.MD.Fora.IIf {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qcl/vh/md/fora/If", ref java_class_handle);
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.md.fora']/class[@name='If']/constructor[@name='If' and count(parameter)=0]"
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

		static IntPtr id_鷭_ILjava_io_OutputStream_Ljava_io_InputStream_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.fora']/class[@name='If']/method[@name='鷭' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='java.io.OutputStream'] and parameter[3][@type='java.io.InputStream'] and parameter[4][@type='int']]"
		[Register ("鷭", "(ILjava/io/OutputStream;Ljava/io/InputStream;I)[B", "")]
		public unsafe byte[] 鷭 (int p0, global::System.IO.Stream p1, global::System.IO.Stream p2, int p3)
		{
			if (id_鷭_ILjava_io_OutputStream_Ljava_io_InputStream_I == IntPtr.Zero)
				id_鷭_ILjava_io_OutputStream_Ljava_io_InputStream_I = JNIEnv.GetMethodID (class_ref, "鷭", "(ILjava/io/OutputStream;Ljava/io/InputStream;I)[B");
			IntPtr native_p1 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p1);
			IntPtr native_p2 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_鷭_ILjava_io_OutputStream_Ljava_io_InputStream_I, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

	}
}
