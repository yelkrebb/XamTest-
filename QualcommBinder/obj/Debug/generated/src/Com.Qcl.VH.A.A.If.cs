using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.A.A {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.a.a']/class[@name='if']"
	[global::Android.Runtime.Register ("com/qcl/vh/a/a/if", DoNotGenerateAcw=true)]
	public sealed partial class If : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qcl/vh/a/a/if", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (If); }
		}

		internal If (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_net_Socket_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.a.a']/class[@name='if']/constructor[@name='if' and count(parameter)=1 and parameter[1][@type='java.net.Socket']]"
		[Register (".ctor", "(Ljava/net/Socket;)V", "")]
		public unsafe If (global::Java.Net.Socket p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (If)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/net/Socket;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/net/Socket;)V", __args);
					return;
				}

				if (id_ctor_Ljava_net_Socket_ == IntPtr.Zero)
					id_ctor_Ljava_net_Socket_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/net/Socket;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_net_Socket_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_net_Socket_, __args);
			} finally {
			}
		}

		static IntPtr id_toString;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.a']/class[@name='if']/method[@name='toString' and count(parameter)=0]"
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

		static IntPtr id_櫯;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.a']/class[@name='if']/method[@name='櫯' and count(parameter)=0]"
		[Register ("櫯", "()Lcom/qcl/vh/a/c/Con;", "")]
		public unsafe global::Com.Qcl.VH.A.C.Con 櫯 ()
		{
			if (id_櫯 == IntPtr.Zero)
				id_櫯 = JNIEnv.GetMethodID (class_ref, "櫯", "()Lcom/qcl/vh/a/c/Con;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.A.C.Con> (JNIEnv.CallObjectMethod  (Handle, id_櫯), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_鷭;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.a']/class[@name='if']/method[@name='鷭' and count(parameter)=0]"
		[Register ("鷭", "()J", "")]
		public unsafe long 鷭 ()
		{
			if (id_鷭 == IntPtr.Zero)
				id_鷭 = JNIEnv.GetMethodID (class_ref, "鷭", "()J");
			try {
				return JNIEnv.CallLongMethod  (Handle, id_鷭);
			} finally {
			}
		}

		static IntPtr id_鷭_Lcom_qcl_vh_a_c_Con_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.a.a']/class[@name='if']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='com.qcl.vh.a.c.Con']]"
		[Register ("鷭", "(Lcom/qcl/vh/a/c/Con;)V", "")]
		public unsafe void 鷭 (global::Com.Qcl.VH.A.C.Con p0)
		{
			if (id_鷭_Lcom_qcl_vh_a_c_Con_ == IntPtr.Zero)
				id_鷭_Lcom_qcl_vh_a_c_Con_ = JNIEnv.GetMethodID (class_ref, "鷭", "(Lcom/qcl/vh/a/c/Con;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_鷭_Lcom_qcl_vh_a_c_Con_, __args);
			} finally {
			}
		}

	}
}
