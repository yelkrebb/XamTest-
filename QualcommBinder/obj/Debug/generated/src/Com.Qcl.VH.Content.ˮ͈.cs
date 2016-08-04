using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.Content {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='ˮ͈']"
	[global::Android.Runtime.Register ("com/qcl/vh/content/ˮ͈", DoNotGenerateAcw=true)]
	public sealed partial class ˮ͈ : global::Java.Lang.Object {


		static IntPtr ˮ͈_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='ˮ͈']/field[@name='ˮ͈']"
		[Register ("ˮ͈")]
		public string ˮ͈ {
			get {
				if (ˮ͈_jfieldId == IntPtr.Zero)
					ˮ͈_jfieldId = JNIEnv.GetFieldID (class_ref, "ˮ͈", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, ˮ͈_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (ˮ͈_jfieldId == IntPtr.Zero)
					ˮ͈_jfieldId = JNIEnv.GetFieldID (class_ref, "ˮ͈", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, ˮ͈_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr 櫯_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='ˮ͈']/field[@name='櫯']"
		[Register ("櫯")]
		public IList<byte> 櫯 {
			get {
				if (櫯_jfieldId == IntPtr.Zero)
					櫯_jfieldId = JNIEnv.GetFieldID (class_ref, "櫯", "[B");
				return JavaArray<byte>.FromJniHandle (JNIEnv.GetObjectField (Handle, 櫯_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (櫯_jfieldId == IntPtr.Zero)
					櫯_jfieldId = JNIEnv.GetFieldID (class_ref, "櫯", "[B");
				IntPtr native_value = JavaArray<byte>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, 櫯_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr 鷭_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='ˮ͈']/field[@name='鷭']"
		[Register ("鷭")]
		public long 鷭 {
			get {
				if (鷭_jfieldId == IntPtr.Zero)
					鷭_jfieldId = JNIEnv.GetFieldID (class_ref, "鷭", "J");
				return JNIEnv.GetLongField (Handle, 鷭_jfieldId);
			}
			set {
				if (鷭_jfieldId == IntPtr.Zero)
					鷭_jfieldId = JNIEnv.GetFieldID (class_ref, "鷭", "J");
				try {
					JNIEnv.SetField (Handle, 鷭_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qcl/vh/content/ˮ͈", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ˮ͈); }
		}

		internal ˮ͈ (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_JarrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='ˮ͈']/constructor[@name='ˮ͈' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='byte[]']]"
		[Register (".ctor", "(J[B)V", "")]
		public unsafe ˮ͈ (long p0, byte[] p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				if (GetType () != typeof (ˮ͈)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(J[B)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(J[B)V", __args);
					return;
				}

				if (id_ctor_JarrayB == IntPtr.Zero)
					id_ctor_JarrayB = JNIEnv.GetMethodID (class_ref, "<init>", "(J[B)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_JarrayB, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_JarrayB, __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_ctor_JarrayBLjava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='ˮ͈']/constructor[@name='ˮ͈' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='byte[]'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(J[BLjava/lang/String;)V", "")]
		public unsafe ˮ͈ (long p0, byte[] p1, string p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				if (GetType () != typeof (ˮ͈)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(J[BLjava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(J[BLjava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_JarrayBLjava_lang_String_ == IntPtr.Zero)
					id_ctor_JarrayBLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(J[BLjava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_JarrayBLjava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_JarrayBLjava_lang_String_, __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_toString;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='ˮ͈']/method[@name='toString' and count(parameter)=0]"
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
