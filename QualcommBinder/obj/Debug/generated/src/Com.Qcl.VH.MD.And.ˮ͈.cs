using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.MD.And {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.md.and']/class[@name='ˮ͈']"
	[global::Android.Runtime.Register ("com/qcl/vh/md/and/ˮ͈", DoNotGenerateAcw=true)]
	public abstract partial class ˮ͈ : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.md.and']/class[@name='ˮ͈.鷭']"
		[global::Android.Runtime.Register ("com/qcl/vh/md/and/ˮ͈$鷭", DoNotGenerateAcw=true)]
		public partial class 鷭 : global::Java.Lang.Object {


			static IntPtr 櫯_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.md.and']/class[@name='ˮ͈.鷭']/field[@name='櫯']"
			[Register ("櫯")]
			protected int 櫯 {
				get {
					if (櫯_jfieldId == IntPtr.Zero)
						櫯_jfieldId = JNIEnv.GetFieldID (class_ref, "櫯", "I");
					return JNIEnv.GetIntField (Handle, 櫯_jfieldId);
				}
				set {
					if (櫯_jfieldId == IntPtr.Zero)
						櫯_jfieldId = JNIEnv.GetFieldID (class_ref, "櫯", "I");
					try {
						JNIEnv.SetField (Handle, 櫯_jfieldId, value);
					} finally {
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/qcl/vh/md/and/ˮ͈$鷭", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (鷭); }
			}

			protected 鷭 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_qcl_vh_md_and_ˮ͈_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.md.and']/class[@name='ˮ͈.鷭']/constructor[@name='ˮ͈.鷭' and count(parameter)=1 and parameter[1][@type='com.qcl.vh.md.and.ˮ͈']]"
			[Register (".ctor", "(Lcom/qcl/vh/md/and/ˮ͈;)V", "")]
			public unsafe 鷭 (global::Com.Qcl.VH.MD.And.ˮ͈ __self)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (__self);
					if (GetType () != typeof (鷭)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args);
						return;
					}

					if (id_ctor_Lcom_qcl_vh_md_and_ˮ͈_ == IntPtr.Zero)
						id_ctor_Lcom_qcl_vh_md_and_ˮ͈_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/qcl/vh/md/and/ˮ͈;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_qcl_vh_md_and_ˮ͈_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_qcl_vh_md_and_ˮ͈_, __args);
				} finally {
				}
			}

			static IntPtr id_ctor_Lcom_qcl_vh_md_and_ˮ͈_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.md.and']/class[@name='ˮ͈.鷭']/constructor[@name='ˮ͈.鷭' and count(parameter)=1 and parameter[1][@type='com.qcl.vh.md.and.ˮ͈']]"
			[Register (".ctor", "(Lcom/qcl/vh/md/and/ˮ͈;)V", "")]
			public unsafe 鷭 (global::Com.Qcl.VH.MD.And.ˮ͈ __self)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (__self);
					if (GetType () != typeof (鷭)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args);
						return;
					}

					if (id_ctor_Lcom_qcl_vh_md_and_ˮ͈_ == IntPtr.Zero)
						id_ctor_Lcom_qcl_vh_md_and_ˮ͈_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/qcl/vh/md/and/ˮ͈;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_qcl_vh_md_and_ˮ͈_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_qcl_vh_md_and_ˮ͈_, __args);
				} finally {
				}
			}

			static IntPtr id_Ą;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.and']/class[@name='ˮ͈.鷭']/method[@name='Ą' and count(parameter)=0]"
			[Register ("Ą", "()[B", "")]
			public unsafe byte[] Ą ()
			{
				if (id_Ą == IntPtr.Zero)
					id_Ą = JNIEnv.GetMethodID (class_ref, "Ą", "()[B");
				try {
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_Ą), JniHandleOwnership.TransferLocalRef, typeof (byte));
				} finally {
				}
			}

			static IntPtr id_鷭_arrayB;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.and']/class[@name='ˮ͈.鷭']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("鷭", "([B)V", "")]
			public unsafe void Invoke鷭 (byte[] p0)
			{
				if (id_鷭_arrayB == IntPtr.Zero)
					id_鷭_arrayB = JNIEnv.GetMethodID (class_ref, "鷭", "([B)V");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					JNIEnv.CallVoidMethod  (Handle, id_鷭_arrayB, __args);
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qcl/vh/md/and/ˮ͈", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ˮ͈); }
		}

		protected ˮ͈ (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.md.and']/class[@name='ˮ͈']/constructor[@name='ˮ͈' and count(parameter)=0]"
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

		static Delegate cb_ˮ͈;
#pragma warning disable 0169
		static Delegate GetInvokeˮ͈Handler ()
		{
			if (cb_ˮ͈ == null)
				cb_ˮ͈ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Invokeˮ͈);
			return cb_ˮ͈;
		}

		static IntPtr n_Invokeˮ͈ (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Qcl.VH.MD.And.ˮ͈ __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.MD.And.ˮ͈> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Invokeˮ͈ ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.and']/class[@name='ˮ͈']/method[@name='ˮ͈' and count(parameter)=0]"
		[Register ("ˮ͈", "()Ljava/util/Iterator;", "GetInvokeˮ͈Handler")]
		public abstract global::Java.Util.IIterator Invokeˮ͈ ();

		static Delegate cb_櫯;
#pragma warning disable 0169
		static Delegate Get櫯Handler ()
		{
			if (cb_櫯 == null)
				cb_櫯 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_櫯);
			return cb_櫯;
		}

		static long n_櫯 (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Qcl.VH.MD.And.ˮ͈ __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.MD.And.ˮ͈> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.櫯 ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.and']/class[@name='ˮ͈']/method[@name='櫯' and count(parameter)=0]"
		[Register ("櫯", "()J", "Get櫯Handler")]
		public abstract long 櫯 ();

		static Delegate cb_櫯_Lcom_qcl_vh_md_and_ˮ͈_鷭_;
#pragma warning disable 0169
		static Delegate Get櫯_Lcom_qcl_vh_md_and_ˮ͈_鷭_Handler ()
		{
			if (cb_櫯_Lcom_qcl_vh_md_and_ˮ͈_鷭_ == null)
				cb_櫯_Lcom_qcl_vh_md_and_ˮ͈_鷭_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_櫯_Lcom_qcl_vh_md_and_ˮ͈_鷭_);
			return cb_櫯_Lcom_qcl_vh_md_and_ˮ͈_鷭_;
		}

		static int n_櫯_Lcom_qcl_vh_md_and_ˮ͈_鷭_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Qcl.VH.MD.And.ˮ͈ __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.MD.And.ˮ͈> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Qcl.VH.MD.And.ˮ͈.鷭 p0 = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.MD.And.ˮ͈.鷭> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.櫯 (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.and']/class[@name='ˮ͈']/method[@name='櫯' and count(parameter)=1 and parameter[1][@type='com.qcl.vh.md.and.ˮ͈.鷭']]"
		[Register ("櫯", "(Lcom/qcl/vh/md/and/ˮ͈$鷭;)I", "Get櫯_Lcom_qcl_vh_md_and_ˮ͈_鷭_Handler")]
		public abstract int 櫯 (global::Com.Qcl.VH.MD.And.ˮ͈.鷭 p0);

		static Delegate cb_鷭;
#pragma warning disable 0169
		static Delegate GetInvoke鷭Handler ()
		{
			if (cb_鷭 == null)
				cb_鷭 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Invoke鷭);
			return cb_鷭;
		}

		static bool n_Invoke鷭 (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Qcl.VH.MD.And.ˮ͈ __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.MD.And.ˮ͈> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Invoke鷭 ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.and']/class[@name='ˮ͈']/method[@name='鷭' and count(parameter)=0]"
		[Register ("鷭", "()Z", "GetInvoke鷭Handler")]
		public abstract bool Invoke鷭 ();

		static IntPtr id_鷭_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.and']/class[@name='ˮ͈']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("鷭", "([B)V", "")]
		public unsafe void Invoke鷭 (byte[] p0)
		{
			if (id_鷭_arrayB == IntPtr.Zero)
				id_鷭_arrayB = JNIEnv.GetMethodID (class_ref, "鷭", "([B)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod  (Handle, id_鷭_arrayB, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_鷭_Lcom_qcl_vh_md_and_ˮ͈_鷭_;
#pragma warning disable 0169
		static Delegate GetInvoke鷭_Lcom_qcl_vh_md_and_ˮ͈_鷭_Handler ()
		{
			if (cb_鷭_Lcom_qcl_vh_md_and_ˮ͈_鷭_ == null)
				cb_鷭_Lcom_qcl_vh_md_and_ˮ͈_鷭_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_Invoke鷭_Lcom_qcl_vh_md_and_ˮ͈_鷭_);
			return cb_鷭_Lcom_qcl_vh_md_and_ˮ͈_鷭_;
		}

		static int n_Invoke鷭_Lcom_qcl_vh_md_and_ˮ͈_鷭_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Qcl.VH.MD.And.ˮ͈ __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.MD.And.ˮ͈> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Qcl.VH.MD.And.ˮ͈.鷭 p0 = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.MD.And.ˮ͈.鷭> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Invoke鷭 (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.and']/class[@name='ˮ͈']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='com.qcl.vh.md.and.ˮ͈.鷭']]"
		[Register ("鷭", "(Lcom/qcl/vh/md/and/ˮ͈$鷭;)I", "GetInvoke鷭_Lcom_qcl_vh_md_and_ˮ͈_鷭_Handler")]
		public abstract int Invoke鷭 (global::Com.Qcl.VH.MD.And.ˮ͈.鷭 p0);

	}

	[global::Android.Runtime.Register ("com/qcl/vh/md/and/ˮ͈", DoNotGenerateAcw=true)]
	internal partial class ˮ͈Invoker : ˮ͈ {

		public ˮ͈Invoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (ˮ͈Invoker); }
		}

		static IntPtr id_ˮ͈;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.and']/class[@name='ˮ͈']/method[@name='ˮ͈' and count(parameter)=0]"
		[Register ("ˮ͈", "()Ljava/util/Iterator;", "GetInvokeˮ͈Handler")]
		public override unsafe global::Java.Util.IIterator Invokeˮ͈ ()
		{
			if (id_ˮ͈ == IntPtr.Zero)
				id_ˮ͈ = JNIEnv.GetMethodID (class_ref, "ˮ͈", "()Ljava/util/Iterator;");
			try {
				return global::Java.Lang.Object.GetObject<global::Java.Util.IIterator> (JNIEnv.CallObjectMethod  (Handle, id_ˮ͈), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_櫯;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.and']/class[@name='ˮ͈']/method[@name='櫯' and count(parameter)=0]"
		[Register ("櫯", "()J", "Get櫯Handler")]
		public override unsafe long 櫯 ()
		{
			if (id_櫯 == IntPtr.Zero)
				id_櫯 = JNIEnv.GetMethodID (class_ref, "櫯", "()J");
			try {
				return JNIEnv.CallLongMethod  (Handle, id_櫯);
			} finally {
			}
		}

		static IntPtr id_櫯_Lcom_qcl_vh_md_and_ˮ͈_鷭_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.and']/class[@name='ˮ͈']/method[@name='櫯' and count(parameter)=1 and parameter[1][@type='com.qcl.vh.md.and.ˮ͈.鷭']]"
		[Register ("櫯", "(Lcom/qcl/vh/md/and/ˮ͈$鷭;)I", "Get櫯_Lcom_qcl_vh_md_and_ˮ͈_鷭_Handler")]
		public override unsafe int 櫯 (global::Com.Qcl.VH.MD.And.ˮ͈.鷭 p0)
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.and']/class[@name='ˮ͈']/method[@name='鷭' and count(parameter)=0]"
		[Register ("鷭", "()Z", "GetInvoke鷭Handler")]
		public override unsafe bool Invoke鷭 ()
		{
			if (id_鷭 == IntPtr.Zero)
				id_鷭 = JNIEnv.GetMethodID (class_ref, "鷭", "()Z");
			try {
				return JNIEnv.CallBooleanMethod  (Handle, id_鷭);
			} finally {
			}
		}

		static IntPtr id_鷭_Lcom_qcl_vh_md_and_ˮ͈_鷭_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.md.and']/class[@name='ˮ͈']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='com.qcl.vh.md.and.ˮ͈.鷭']]"
		[Register ("鷭", "(Lcom/qcl/vh/md/and/ˮ͈$鷭;)I", "GetInvoke鷭_Lcom_qcl_vh_md_and_ˮ͈_鷭_Handler")]
		public override unsafe int Invoke鷭 (global::Com.Qcl.VH.MD.And.ˮ͈.鷭 p0)
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
