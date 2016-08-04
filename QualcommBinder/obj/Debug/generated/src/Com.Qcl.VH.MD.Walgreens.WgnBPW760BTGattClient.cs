using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.MD.Walgreens {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.md.walgreens']/class[@name='WgnBPW760BTGattClient']"
	[global::Android.Runtime.Register ("com/qcl/vh/md/walgreens/WgnBPW760BTGattClient", DoNotGenerateAcw=true)]
	public partial class WgnBPW760BTGattClient : global::Com.Qcl.VH.MD.Walgreens.WgnBPMGenericGattClient {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qcl/vh/md/walgreens/WgnBPW760BTGattClient", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (WgnBPW760BTGattClient); }
		}

		protected WgnBPW760BTGattClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.md.walgreens']/class[@name='WgnBPW760BTGattClient']/constructor[@name='WgnBPW760BTGattClient' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe WgnBPW760BTGattClient ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (WgnBPW760BTGattClient)) {
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

	}
}
