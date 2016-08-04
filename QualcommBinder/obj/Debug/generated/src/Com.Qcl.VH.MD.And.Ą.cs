using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.MD.And {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.md.and']/class[@name='Ą']"
	[global::Android.Runtime.Register ("com/qcl/vh/md/and/Ą", DoNotGenerateAcw=true)]
	public partial class Ą : global::Com.Qcl.VH.MD.And.ˮ͈ {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.md.and']/class[@name='Ą.if']"
		[global::Android.Runtime.Register ("com/qcl/vh/md/and/Ą$if", DoNotGenerateAcw=true)]
		public partial class If : global::Com.Qcl.VH.MD.And.ˮ͈.鷭 {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/qcl/vh/md/and/Ą$if", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (If); }
			}

			protected If (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_qcl_vh_md_and_Ą_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.md.and']/class[@name='Ą.if']/constructor[@name='Ą.if' and count(parameter)=1 and parameter[1][@type='com.qcl.vh.md.and.Ą']]"
			[Register (".ctor", "(Lcom/qcl/vh/md/and/Ą;)V", "")]
			public unsafe If (global::Com.Qcl.VH.MD.And.Ą __self)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (__self);
					if (GetType () != typeof (If)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args);
						return;
					}

					if (id_ctor_Lcom_qcl_vh_md_and_Ą_ == IntPtr.Zero)
						id_ctor_Lcom_qcl_vh_md_and_Ą_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/qcl/vh/md/and/Ą;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_qcl_vh_md_and_Ą_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_qcl_vh_md_and_Ą_, __args);
				} finally {
				}
			}

			static IntPtr id_櫯;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.and']/class[@name='Ą.if']/method[@name='櫯' and count(parameter)=0]"
			[Register ("櫯", "()Z", "")]
			public unsafe bool 櫯 ()
			{
				if (id_櫯 == IntPtr.Zero)
					id_櫯 = JNIEnv.GetMethodID (class_ref, "櫯", "()Z");
				try {
					return JNIEnv.CallBooleanMethod  (Handle, id_櫯);
				} finally {
				}
			}

			static IntPtr id_鷭;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.and']/class[@name='Ą.if']/method[@name='鷭' and count(parameter)=0]"
			[Register ("鷭", "()V", "")]
			public unsafe void 鷭 ()
			{
				if (id_鷭 == IntPtr.Zero)
					id_鷭 = JNIEnv.GetMethodID (class_ref, "鷭", "()V");
				try {
					JNIEnv.CallVoidMethod  (Handle, id_鷭);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.md.and']/class[@name='Ą.鷭']"
		[global::Android.Runtime.Register ("com/qcl/vh/md/and/Ą$鷭", DoNotGenerateAcw=true)]
		public new partial class 鷭 : global::Java.Lang.Object, global::Java.Util.IIterator {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/qcl/vh/md/and/Ą$鷭", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (鷭); }
			}

			protected 鷭 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_qcl_vh_md_and_Ą_Lcom_qcl_vh_md_and_Ą_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.md.and']/class[@name='Ą.鷭']/constructor[@name='Ą.鷭' and count(parameter)=2 and parameter[1][@type='com.qcl.vh.md.and.Ą'] and parameter[2][@type='com.qcl.vh.md.and.Ą']]"
			[Register (".ctor", "(Lcom/qcl/vh/md/and/Ą;Lcom/qcl/vh/md/and/Ą;)V", "")]
			public unsafe 鷭 (global::Com.Qcl.VH.MD.And.Ą __self, global::Com.Qcl.VH.MD.And.Ą p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (p1);
					if (GetType () != typeof (鷭)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Lcom/qcl/vh/md/and/Ą;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Lcom/qcl/vh/md/and/Ą;)V", __args);
						return;
					}

					if (id_ctor_Lcom_qcl_vh_md_and_Ą_Lcom_qcl_vh_md_and_Ą_ == IntPtr.Zero)
						id_ctor_Lcom_qcl_vh_md_and_Ą_Lcom_qcl_vh_md_and_Ą_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/qcl/vh/md/and/Ą;Lcom/qcl/vh/md/and/Ą;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_qcl_vh_md_and_Ą_Lcom_qcl_vh_md_and_Ą_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_qcl_vh_md_and_Ą_Lcom_qcl_vh_md_and_Ą_, __args);
				} finally {
				}
			}

			static IntPtr id_hasNext;
			public unsafe bool HasNext {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.and']/class[@name='Ą.鷭']/method[@name='hasNext' and count(parameter)=0]"
				[Register ("hasNext", "()Z", "GetHasNextHandler")]
				get {
					if (id_hasNext == IntPtr.Zero)
						id_hasNext = JNIEnv.GetMethodID (class_ref, "hasNext", "()Z");
					try {
						return JNIEnv.CallBooleanMethod  (Handle, id_hasNext);
					} finally {
					}
				}
			}

			static IntPtr id_next;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.and']/class[@name='Ą.鷭']/method[@name='next' and count(parameter)=0]"
			[Register ("next", "()Ljava/lang/Object;", "")]
			public unsafe global::Java.Lang.Object Next ()
			{
				if (id_next == IntPtr.Zero)
					id_next = JNIEnv.GetMethodID (class_ref, "next", "()Ljava/lang/Object;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_next), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_remove;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.and']/class[@name='Ą.鷭']/method[@name='remove' and count(parameter)=0]"
			[Register ("remove", "()V", "")]
			public unsafe void Remove ()
			{
				if (id_remove == IntPtr.Zero)
					id_remove = JNIEnv.GetMethodID (class_ref, "remove", "()V");
				try {
					JNIEnv.CallVoidMethod  (Handle, id_remove);
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qcl/vh/md/and/Ą", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Ą); }
		}

		protected Ą (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.md.and']/class[@name='Ą']/constructor[@name='Ą' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Ą ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Ą)) {
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.and']/class[@name='Ą']/method[@name='ˮ͈' and count(parameter)=0]"
		[Register ("ˮ͈", "()Ljava/util/Iterator;", "")]
		public override sealed unsafe global::Java.Util.IIterator ˮ͈ ()
		{
			if (id_ˮ͈ == IntPtr.Zero)
				id_ˮ͈ = JNIEnv.GetMethodID (class_ref, "ˮ͈", "()Ljava/util/Iterator;");
			try {
				return global::Java.Lang.Object.GetObject<global::Java.Util.IIterator> (JNIEnv.CallObjectMethod  (Handle, id_ˮ͈), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_櫯;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.and']/class[@name='Ą']/method[@name='櫯' and count(parameter)=0]"
		[Register ("櫯", "()J", "")]
		public override sealed unsafe long 櫯 ()
		{
			if (id_櫯 == IntPtr.Zero)
				id_櫯 = JNIEnv.GetMethodID (class_ref, "櫯", "()J");
			try {
				return JNIEnv.CallLongMethod  (Handle, id_櫯);
			} finally {
			}
		}

		static IntPtr id_櫯_Lcom_qcl_vh_md_and_ˮ͈_鷭_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.and']/class[@name='Ą']/method[@name='櫯' and count(parameter)=1 and parameter[1][@type='com.qcl.vh.md.and.ˮ͈.鷭']]"
		[Register ("櫯", "(Lcom/qcl/vh/md/and/ˮ͈$鷭;)I", "")]
		public override sealed unsafe int 櫯 (global::Com.Qcl.VH.MD.And.ˮ͈.鷭 p0)
		{
			if (id_櫯_Lcom_qcl_vh_md_and_ˮ͈_鷭_ == IntPtr.Zero)
				id_櫯_Lcom_qcl_vh_md_and_ˮ͈_鷭_ = JNIEnv.GetMethodID (class_ref, "櫯", "(Lcom/qcl/vh/md/and/ˮ͈$鷭;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				int __ret = JNIEnv.CallIntMethod  (Handle, id_櫯_Lcom_qcl_vh_md_and_ˮ͈_鷭_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_鷭;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.and']/class[@name='Ą']/method[@name='鷭' and count(parameter)=0]"
		[Register ("鷭", "()Z", "")]
		public override sealed unsafe bool Invoke鷭 ()
		{
			if (id_鷭 == IntPtr.Zero)
				id_鷭 = JNIEnv.GetMethodID (class_ref, "鷭", "()Z");
			try {
				return JNIEnv.CallBooleanMethod  (Handle, id_鷭);
			} finally {
			}
		}

		static IntPtr id_鷭_Lcom_qcl_vh_md_and_ˮ͈_鷭_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.and']/class[@name='Ą']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='com.qcl.vh.md.and.ˮ͈.鷭']]"
		[Register ("鷭", "(Lcom/qcl/vh/md/and/ˮ͈$鷭;)I", "")]
		public override sealed unsafe int Invoke鷭 (global::Com.Qcl.VH.MD.And.ˮ͈.鷭 p0)
		{
			if (id_鷭_Lcom_qcl_vh_md_and_ˮ͈_鷭_ == IntPtr.Zero)
				id_鷭_Lcom_qcl_vh_md_and_ˮ͈_鷭_ = JNIEnv.GetMethodID (class_ref, "鷭", "(Lcom/qcl/vh/md/and/ˮ͈$鷭;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				int __ret = JNIEnv.CallIntMethod  (Handle, id_鷭_Lcom_qcl_vh_md_and_ˮ͈_鷭_, __args);
				return __ret;
			} finally {
			}
		}

	}
}
