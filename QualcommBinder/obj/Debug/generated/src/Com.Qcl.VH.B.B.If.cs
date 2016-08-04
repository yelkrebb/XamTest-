using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.B.B {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.b.b']/class[@name='if']"
	[global::Android.Runtime.Register ("com/qcl/vh/b/b/if", DoNotGenerateAcw=true)]
	public partial class If : global::Com.Qcl.VH.B.B.鷭 {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qcl/vh/b/b/if", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (If); }
		}

		protected If (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.b.b']/class[@name='if']/constructor[@name='if' and count(parameter)=0]"
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

		static IntPtr id_櫯;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.b.b']/class[@name='if']/method[@name='櫯' and count(parameter)=0]"
		[Register ("櫯", "()Ljava/util/ArrayList;", "")]
		public override sealed unsafe global::System.Collections.Generic.IList<global::Com.Qcl.VH.Service.DiagnosticService.LogMetadataEntry> 櫯 ()
		{
			if (id_櫯 == IntPtr.Zero)
				id_櫯 = JNIEnv.GetMethodID (class_ref, "櫯", "()Ljava/util/ArrayList;");
			try {
				return global::Android.Runtime.JavaList<global::Com.Qcl.VH.Service.DiagnosticService.LogMetadataEntry>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_櫯), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_鷭;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.b.b']/class[@name='if']/method[@name='鷭' and count(parameter)=0]"
		[Register ("鷭", "()Ljava/lang/String;", "")]
		public override sealed unsafe string 鷭 ()
		{
			if (id_鷭 == IntPtr.Zero)
				id_鷭 = JNIEnv.GetMethodID (class_ref, "鷭", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_鷭), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
