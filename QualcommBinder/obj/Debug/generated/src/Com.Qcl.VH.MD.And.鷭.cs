using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.MD.And {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.md.and']/class[@name='鷭']"
	[global::Android.Runtime.Register ("com/qcl/vh/md/and/鷭", DoNotGenerateAcw=true)]
	public sealed partial class 鷭 : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qcl/vh/md/and/鷭", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (鷭); }
		}

		internal 鷭 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.md.and']/class[@name='鷭']/constructor[@name='鷭' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe 鷭 ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (鷭)) {
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

		static IntPtr id_Ą_B;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.and']/class[@name='鷭']/method[@name='Ą' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("Ą", "(B)V", "")]
		public unsafe void Ą (sbyte p0)
		{
			if (id_Ą_B == IntPtr.Zero)
				id_Ą_B = JNIEnv.GetMethodID (class_ref, "Ą", "(B)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_Ą_B, __args);
			} finally {
			}
		}

		static IntPtr id_ȃ_B;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.and']/class[@name='鷭']/method[@name='ȃ' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("ȃ", "(B)V", "")]
		public unsafe void Ȃ (sbyte p0)
		{
			if (id_ȃ_B == IntPtr.Zero)
				id_ȃ_B = JNIEnv.GetMethodID (class_ref, "ȃ", "(B)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_ȃ_B, __args);
			} finally {
			}
		}

		static IntPtr id_ˮ͈_B;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.and']/class[@name='鷭']/method[@name='ˮ͈' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("ˮ͈", "(B)V", "")]
		public unsafe void ˮ͈ (sbyte p0)
		{
			if (id_ˮ͈_B == IntPtr.Zero)
				id_ˮ͈_B = JNIEnv.GetMethodID (class_ref, "ˮ͈", "(B)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_ˮ͈_B, __args);
			} finally {
			}
		}

		static IntPtr id_櫯;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.and']/class[@name='鷭']/method[@name='櫯' and count(parameter)=0]"
		[Register ("櫯", "()V", "")]
		public unsafe void 櫯 ()
		{
			if (id_櫯 == IntPtr.Zero)
				id_櫯 = JNIEnv.GetMethodID (class_ref, "櫯", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_櫯);
			} finally {
			}
		}

		static IntPtr id_櫯_B;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.and']/class[@name='鷭']/method[@name='櫯' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("櫯", "(B)V", "")]
		public unsafe void 櫯 (sbyte p0)
		{
			if (id_櫯_B == IntPtr.Zero)
				id_櫯_B = JNIEnv.GetMethodID (class_ref, "櫯", "(B)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_櫯_B, __args);
			} finally {
			}
		}

		static IntPtr id_鷭;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.and']/class[@name='鷭']/method[@name='鷭' and count(parameter)=0]"
		[Register ("鷭", "()[B", "")]
		public unsafe byte[] Invoke鷭 ()
		{
			if (id_鷭 == IntPtr.Zero)
				id_鷭 = JNIEnv.GetMethodID (class_ref, "鷭", "()[B");
			try {
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_鷭), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static IntPtr id_鷭_B;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.and']/class[@name='鷭']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("鷭", "(B)V", "")]
		public unsafe void Invoke鷭 (sbyte p0)
		{
			if (id_鷭_B == IntPtr.Zero)
				id_鷭_B = JNIEnv.GetMethodID (class_ref, "鷭", "(B)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_鷭_B, __args);
			} finally {
			}
		}

		static IntPtr id_鷭_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.and']/class[@name='鷭']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("鷭", "(I)V", "")]
		public unsafe void Invoke鷭 (int p0)
		{
			if (id_鷭_I == IntPtr.Zero)
				id_鷭_I = JNIEnv.GetMethodID (class_ref, "鷭", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_鷭_I, __args);
			} finally {
			}
		}

	}
}
