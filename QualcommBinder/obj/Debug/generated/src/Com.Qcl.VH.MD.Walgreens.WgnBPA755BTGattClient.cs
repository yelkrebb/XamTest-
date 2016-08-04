using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.MD.Walgreens {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.md.walgreens']/class[@name='WgnBPA755BTGattClient']"
	[global::Android.Runtime.Register ("com/qcl/vh/md/walgreens/WgnBPA755BTGattClient", DoNotGenerateAcw=true)]
	public partial class WgnBPA755BTGattClient : global::Com.Qcl.VH.MD.Walgreens.WgnBPMGenericGattClient {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qcl/vh/md/walgreens/WgnBPA755BTGattClient", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (WgnBPA755BTGattClient); }
		}

		protected WgnBPA755BTGattClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.md.walgreens']/class[@name='WgnBPA755BTGattClient']/constructor[@name='WgnBPA755BTGattClient' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe WgnBPA755BTGattClient ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (WgnBPA755BTGattClient)) {
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
