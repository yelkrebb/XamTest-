using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.MD.Jnj {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.md.jnj']/class[@name='ˮ͈']"
	[global::Android.Runtime.Register ("com/qcl/vh/md/jnj/ˮ͈", DoNotGenerateAcw=true)]
	public sealed partial class ˮ͈ : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qcl/vh/md/jnj/ˮ͈", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ˮ͈); }
		}

		internal ˮ͈ (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.md.jnj']/class[@name='ˮ͈']/constructor[@name='ˮ͈' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ˮ͈ ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ˮ͈)) {
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

		static IntPtr id_ˮ͈;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.jnj']/class[@name='ˮ͈']/method[@name='ˮ͈' and count(parameter)=0]"
		[Register ("ˮ͈", "()Ljava/util/ArrayList;", "")]
		public unsafe global::System.Collections.Generic.IList<global::Com.Qcl.VH.MD.Jnj.If> Invokeˮ͈ ()
		{
			if (id_ˮ͈ == IntPtr.Zero)
				id_ˮ͈ = JNIEnv.GetMethodID (class_ref, "ˮ͈", "()Ljava/util/ArrayList;");
			try {
				return global::Android.Runtime.JavaList<global::Com.Qcl.VH.MD.Jnj.If>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_ˮ͈), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_櫯;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.jnj']/class[@name='ˮ͈']/method[@name='櫯' and count(parameter)=0]"
		[Register ("櫯", "()Ljava/util/ArrayList;", "")]
		public unsafe global::System.Collections.Generic.IList<global::Com.Qcl.VH.MD.Jnj.If> 櫯 ()
		{
			if (id_櫯 == IntPtr.Zero)
				id_櫯 = JNIEnv.GetMethodID (class_ref, "櫯", "()Ljava/util/ArrayList;");
			try {
				return global::Android.Runtime.JavaList<global::Com.Qcl.VH.MD.Jnj.If>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_櫯), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_鷭;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.jnj']/class[@name='ˮ͈']/method[@name='鷭' and count(parameter)=0]"
		[Register ("鷭", "()Ljava/util/ArrayList;", "")]
		public unsafe global::System.Collections.Generic.IList<global::Com.Qcl.VH.MD.Jnj.If> 鷭 ()
		{
			if (id_鷭 == IntPtr.Zero)
				id_鷭 = JNIEnv.GetMethodID (class_ref, "鷭", "()Ljava/util/ArrayList;");
			try {
				return global::Android.Runtime.JavaList<global::Com.Qcl.VH.MD.Jnj.If>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_鷭), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
