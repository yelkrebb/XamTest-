using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.MD.Vitalograph {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.md.vitalograph']/class[@name='ˮ͈']"
	[global::Android.Runtime.Register ("com/qcl/vh/md/vitalograph/ˮ͈", DoNotGenerateAcw=true)]
	public partial class ˮ͈ : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qcl/vh/md/vitalograph/ˮ͈", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ˮ͈); }
		}

		protected ˮ͈ (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_Ą;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.vitalograph']/class[@name='ˮ͈']/method[@name='Ą' and count(parameter)=0]"
		[Register ("Ą", "()Ljava/util/List;", "")]
		public unsafe global::System.Collections.Generic.IList<global::Com.Qcl.VH.MD.Vitalograph.Ą> Ą ()
		{
			if (id_Ą == IntPtr.Zero)
				id_Ą = JNIEnv.GetMethodID (class_ref, "Ą", "()Ljava/util/List;");
			try {
				return global::Android.Runtime.JavaList<global::Com.Qcl.VH.MD.Vitalograph.Ą>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_Ą), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_ą;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.vitalograph']/class[@name='ˮ͈']/method[@name='ą' and count(parameter)=0]"
		[Register ("ą", "()Z", "")]
		public unsafe bool Ą ()
		{
			if (id_ą == IntPtr.Zero)
				id_ą = JNIEnv.GetMethodID (class_ref, "ą", "()Z");
			try {
				return JNIEnv.CallBooleanMethod  (Handle, id_ą);
			} finally {
			}
		}

		static IntPtr id_ȃ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.vitalograph']/class[@name='ˮ͈']/method[@name='ȃ' and count(parameter)=0]"
		[Register ("ȃ", "()V", "")]
		public unsafe void Ȃ ()
		{
			if (id_ȃ == IntPtr.Zero)
				id_ȃ = JNIEnv.GetMethodID (class_ref, "ȃ", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_ȃ);
			} finally {
			}
		}

		static IntPtr id_ˮ͈;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.vitalograph']/class[@name='ˮ͈']/method[@name='ˮ͈' and count(parameter)=0]"
		[Register ("ˮ͈", "()Lcom/qcl/vh/md/vitalograph/Ą;", "")]
		public unsafe global::Com.Qcl.VH.MD.Vitalograph.Ą Invokeˮ͈ ()
		{
			if (id_ˮ͈ == IntPtr.Zero)
				id_ˮ͈ = JNIEnv.GetMethodID (class_ref, "ˮ͈", "()Lcom/qcl/vh/md/vitalograph/Ą;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.MD.Vitalograph.Ą> (JNIEnv.CallObjectMethod  (Handle, id_ˮ͈), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_櫯;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.vitalograph']/class[@name='ˮ͈']/method[@name='櫯' and count(parameter)=0]"
		[Register ("櫯", "()Lcom/qcl/vh/md/vitalograph/Ą;", "")]
		public unsafe global::Com.Qcl.VH.MD.Vitalograph.Ą 櫯 ()
		{
			if (id_櫯 == IntPtr.Zero)
				id_櫯 = JNIEnv.GetMethodID (class_ref, "櫯", "()Lcom/qcl/vh/md/vitalograph/Ą;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.MD.Vitalograph.Ą> (JNIEnv.CallObjectMethod  (Handle, id_櫯), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_鷭;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.vitalograph']/class[@name='ˮ͈']/method[@name='鷭' and count(parameter)=0]"
		[Register ("鷭", "()Z", "")]
		public unsafe bool 鷭 ()
		{
			if (id_鷭 == IntPtr.Zero)
				id_鷭 = JNIEnv.GetMethodID (class_ref, "鷭", "()Z");
			try {
				return JNIEnv.CallBooleanMethod  (Handle, id_鷭);
			} finally {
			}
		}

	}
}
