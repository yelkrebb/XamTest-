using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.MD.Asthmapolis {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.md.asthmapolis']/class[@name='鷭']"
	[global::Android.Runtime.Register ("com/qcl/vh/md/asthmapolis/鷭", DoNotGenerateAcw=true)]
	public sealed partial class 鷭 : global::Java.Lang.Object {


		static IntPtr 鷭_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.md.asthmapolis']/class[@name='鷭']/field[@name='鷭']"
		[Register ("鷭")]
		public int 鷭 {
			get {
				if (鷭_jfieldId == IntPtr.Zero)
					鷭_jfieldId = JNIEnv.GetFieldID (class_ref, "鷭", "I");
				return JNIEnv.GetIntField (Handle, 鷭_jfieldId);
			}
			set {
				if (鷭_jfieldId == IntPtr.Zero)
					鷭_jfieldId = JNIEnv.GetFieldID (class_ref, "鷭", "I");
				try {
					JNIEnv.SetField (Handle, 鷭_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qcl/vh/md/asthmapolis/鷭", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (鷭); }
		}

		internal 鷭 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_toString;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.asthmapolis']/class[@name='鷭']/method[@name='toString' and count(parameter)=0]"
		[Register ("toString", "()Ljava/lang/String;", "")]
		public override sealed unsafe string ToString ()
		{
			if (id_toString == IntPtr.Zero)
				id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_toString), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
