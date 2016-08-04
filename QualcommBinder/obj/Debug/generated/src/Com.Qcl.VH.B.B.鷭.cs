using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.B.B {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.b.b']/class[@name='鷭']"
	[global::Android.Runtime.Register ("com/qcl/vh/b/b/鷭", DoNotGenerateAcw=true)]
	public abstract partial class 鷭 : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qcl/vh/b/b/鷭", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (鷭); }
		}

		protected 鷭 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.b.b']/class[@name='鷭']/constructor[@name='鷭' and count(parameter)=0]"
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

		static Delegate cb_櫯;
#pragma warning disable 0169
		static Delegate Get櫯Handler ()
		{
			if (cb_櫯 == null)
				cb_櫯 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_櫯);
			return cb_櫯;
		}

		static IntPtr n_櫯 (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Qcl.VH.B.B.鷭 __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.B.B.鷭> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Qcl.VH.Service.DiagnosticService.LogMetadataEntry>.ToLocalJniHandle (__this.櫯 ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.b.b']/class[@name='鷭']/method[@name='櫯' and count(parameter)=0]"
		[Register ("櫯", "()Ljava/util/ArrayList;", "Get櫯Handler")]
		public abstract global::System.Collections.Generic.IList<global::Com.Qcl.VH.Service.DiagnosticService.LogMetadataEntry> 櫯 ();

		static Delegate cb_鷭;
#pragma warning disable 0169
		static Delegate GetInvoke鷭Handler ()
		{
			if (cb_鷭 == null)
				cb_鷭 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Invoke鷭);
			return cb_鷭;
		}

		static IntPtr n_Invoke鷭 (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Qcl.VH.B.B.鷭 __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.B.B.鷭> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Invoke鷭 ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.b.b']/class[@name='鷭']/method[@name='鷭' and count(parameter)=0]"
		[Register ("鷭", "()Ljava/lang/String;", "GetInvoke鷭Handler")]
		protected abstract string Invoke鷭 ();

		static IntPtr id_鷭_Lcom_qcl_vh_service_DiagnosticService_LogMetadataEntry_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.b.b']/class[@name='鷭']/method[@name='鷭' and count(parameter)=2 and parameter[1][@type='com.qcl.vh.service.DiagnosticService.LogMetadataEntry'] and parameter[2][@type='long']]"
		[Register ("鷭", "(Lcom/qcl/vh/service/DiagnosticService$LogMetadataEntry;J)Z", "")]
		public static unsafe bool Invoke鷭 (global::Com.Qcl.VH.Service.DiagnosticService.LogMetadataEntry p0, long p1)
		{
			if (id_鷭_Lcom_qcl_vh_service_DiagnosticService_LogMetadataEntry_J == IntPtr.Zero)
				id_鷭_Lcom_qcl_vh_service_DiagnosticService_LogMetadataEntry_J = JNIEnv.GetStaticMethodID (class_ref, "鷭", "(Lcom/qcl/vh/service/DiagnosticService$LogMetadataEntry;J)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_鷭_Lcom_qcl_vh_service_DiagnosticService_LogMetadataEntry_J, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_鷭_Ljava_io_File_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.b.b']/class[@name='鷭']/method[@name='鷭' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='java.lang.String']]"
		[Register ("鷭", "(Ljava/io/File;Ljava/lang/String;)[J", "")]
		public unsafe long[] Invoke鷭 (global::Java.IO.File p0, string p1)
		{
			if (id_鷭_Ljava_io_File_Ljava_lang_String_ == IntPtr.Zero)
				id_鷭_Ljava_io_File_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "鷭", "(Ljava/io/File;Ljava/lang/String;)[J");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				long[] __ret = (long[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_鷭_Ljava_io_File_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (long));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_鷭_Ljava_lang_String_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.b.b']/class[@name='鷭']/method[@name='鷭' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long']]"
		[Register ("鷭", "(Ljava/lang/String;J)Z", "")]
		public unsafe bool Invoke鷭 (string p0, long p1)
		{
			if (id_鷭_Ljava_lang_String_J == IntPtr.Zero)
				id_鷭_Ljava_lang_String_J = JNIEnv.GetMethodID (class_ref, "鷭", "(Ljava/lang/String;J)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_鷭_Ljava_lang_String_J, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_鷭_Ljava_lang_String_JI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.b.b']/class[@name='鷭']/method[@name='鷭' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long'] and parameter[3][@type='int']]"
		[Register ("鷭", "(Ljava/lang/String;JI)[B", "")]
		public unsafe byte[] Invoke鷭 (string p0, long p1, int p2)
		{
			if (id_鷭_Ljava_lang_String_JI == IntPtr.Zero)
				id_鷭_Ljava_lang_String_JI = JNIEnv.GetMethodID (class_ref, "鷭", "(Ljava/lang/String;JI)[B");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_鷭_Ljava_lang_String_JI, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_鷭_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.b.b']/class[@name='鷭']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='java.lang.String...']]"
		[Register ("鷭", "([Ljava/lang/String;)[B", "")]
		public unsafe byte[] Invoke鷭 (params  string[] p0)
		{
			if (id_鷭_arrayLjava_lang_String_ == IntPtr.Zero)
				id_鷭_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "鷭", "([Ljava/lang/String;)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_鷭_arrayLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}

	[global::Android.Runtime.Register ("com/qcl/vh/b/b/鷭", DoNotGenerateAcw=true)]
	internal partial class 鷭Invoker : 鷭 {

		public 鷭Invoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (鷭Invoker); }
		}

		static IntPtr id_櫯;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.b.b']/class[@name='鷭']/method[@name='櫯' and count(parameter)=0]"
		[Register ("櫯", "()Ljava/util/ArrayList;", "Get櫯Handler")]
		public override unsafe global::System.Collections.Generic.IList<global::Com.Qcl.VH.Service.DiagnosticService.LogMetadataEntry> 櫯 ()
		{
			if (id_櫯 == IntPtr.Zero)
				id_櫯 = JNIEnv.GetMethodID (class_ref, "櫯", "()Ljava/util/ArrayList;");
			try {
				return global::Android.Runtime.JavaList<global::Com.Qcl.VH.Service.DiagnosticService.LogMetadataEntry>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_櫯), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_鷭;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.b.b']/class[@name='鷭']/method[@name='鷭' and count(parameter)=0]"
		[Register ("鷭", "()Ljava/lang/String;", "GetInvoke鷭Handler")]
		protected override unsafe string Invoke鷭 ()
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
