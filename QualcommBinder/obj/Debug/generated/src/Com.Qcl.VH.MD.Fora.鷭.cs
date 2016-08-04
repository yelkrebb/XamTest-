using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.MD.Fora {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.md.fora']/class[@name='鷭']"
	[global::Android.Runtime.Register ("com/qcl/vh/md/fora/鷭", DoNotGenerateAcw=true)]
	public sealed partial class 鷭 : global::Java.Lang.Object {


		static IntPtr Ą_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.md.fora']/class[@name='鷭']/field[@name='Ą']"
		[Register ("Ą")]
		public global::Com.Qcl.VH.MD.Fora.IIf Ą {
			get {
				if (Ą_jfieldId == IntPtr.Zero)
					Ą_jfieldId = JNIEnv.GetFieldID (class_ref, "Ą", "Lcom/qcl/vh/md/fora/if;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, Ą_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.MD.Fora.IIf> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (Ą_jfieldId == IntPtr.Zero)
					Ą_jfieldId = JNIEnv.GetFieldID (class_ref, "Ą", "Lcom/qcl/vh/md/fora/if;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, Ą_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr ȃ_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.md.fora']/class[@name='鷭']/field[@name='ȃ']"
		[Register ("ȃ")]
		public int Ȃ {
			get {
				if (ȃ_jfieldId == IntPtr.Zero)
					ȃ_jfieldId = JNIEnv.GetFieldID (class_ref, "ȃ", "I");
				return JNIEnv.GetIntField (Handle, ȃ_jfieldId);
			}
			set {
				if (ȃ_jfieldId == IntPtr.Zero)
					ȃ_jfieldId = JNIEnv.GetFieldID (class_ref, "ȃ", "I");
				try {
					JNIEnv.SetField (Handle, ȃ_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr ˮ͈_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.md.fora']/class[@name='鷭']/field[@name='ˮ͈']"
		[Register ("ˮ͈")]
		public sbyte ˮ͈ {
			get {
				if (ˮ͈_jfieldId == IntPtr.Zero)
					ˮ͈_jfieldId = JNIEnv.GetFieldID (class_ref, "ˮ͈", "B");
				return JNIEnv.GetByteField (Handle, ˮ͈_jfieldId);
			}
			set {
				if (ˮ͈_jfieldId == IntPtr.Zero)
					ˮ͈_jfieldId = JNIEnv.GetFieldID (class_ref, "ˮ͈", "B");
				try {
					JNIEnv.SetField (Handle, ˮ͈_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr 櫯_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.md.fora']/class[@name='鷭']/field[@name='櫯']"
		[Register ("櫯")]
		public sbyte 櫯 {
			get {
				if (櫯_jfieldId == IntPtr.Zero)
					櫯_jfieldId = JNIEnv.GetFieldID (class_ref, "櫯", "B");
				return JNIEnv.GetByteField (Handle, 櫯_jfieldId);
			}
			set {
				if (櫯_jfieldId == IntPtr.Zero)
					櫯_jfieldId = JNIEnv.GetFieldID (class_ref, "櫯", "B");
				try {
					JNIEnv.SetField (Handle, 櫯_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr 鷭_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.md.fora']/class[@name='鷭']/field[@name='鷭']"
		[Register ("鷭")]
		public string 鷭 {
			get {
				if (鷭_jfieldId == IntPtr.Zero)
					鷭_jfieldId = JNIEnv.GetFieldID (class_ref, "鷭", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, 鷭_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (鷭_jfieldId == IntPtr.Zero)
					鷭_jfieldId = JNIEnv.GetFieldID (class_ref, "鷭", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, 鷭_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qcl/vh/md/fora/鷭", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (鷭); }
		}

		internal 鷭 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_BBILcom_qcl_vh_md_fora_if_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.md.fora']/class[@name='鷭']/constructor[@name='鷭' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte'] and parameter[3][@type='byte'] and parameter[4][@type='int'] and parameter[5][@type='com.qcl.vh.md.fora.if']]"
		[Register (".ctor", "(Ljava/lang/String;BBILcom/qcl/vh/md/fora/if;)V", "")]
		public unsafe 鷭 (string p0, sbyte p1, sbyte p2, int p3, global::Com.Qcl.VH.MD.Fora.IIf p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				if (GetType () != typeof (鷭)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;BBILcom/qcl/vh/md/fora/if;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;BBILcom/qcl/vh/md/fora/if;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_BBILcom_qcl_vh_md_fora_if_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_BBILcom_qcl_vh_md_fora_if_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;BBILcom/qcl/vh/md/fora/if;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_BBILcom_qcl_vh_md_fora_if_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_BBILcom_qcl_vh_md_fora_if_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
