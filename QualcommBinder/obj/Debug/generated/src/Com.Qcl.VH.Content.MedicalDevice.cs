using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.Content {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='MedicalDevice']"
	[global::Android.Runtime.Register ("com/qcl/vh/content/MedicalDevice", DoNotGenerateAcw=true)]
	public partial class MedicalDevice : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='MedicalDevice']/field[@name='CHANNEL_MODE_NORMAL']"
		[Register ("CHANNEL_MODE_NORMAL")]
		public const int ChannelModeNormal = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='MedicalDevice']/field[@name='CHANNEL_MODE_STICKY']"
		[Register ("CHANNEL_MODE_STICKY")]
		public const int ChannelModeSticky = (int) 1;

		static IntPtr _id_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='MedicalDevice']/field[@name='_id']"
		[Register ("_id")]
		public long Id {
			get {
				if (_id_jfieldId == IntPtr.Zero)
					_id_jfieldId = JNIEnv.GetFieldID (class_ref, "_id", "J");
				return JNIEnv.GetLongField (Handle, _id_jfieldId);
			}
			set {
				if (_id_jfieldId == IntPtr.Zero)
					_id_jfieldId = JNIEnv.GetFieldID (class_ref, "_id", "J");
				try {
					JNIEnv.SetField (Handle, _id_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qcl/vh/content/MedicalDevice", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MedicalDevice); }
		}

		protected MedicalDevice (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='MedicalDevice']/constructor[@name='MedicalDevice' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MedicalDevice ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (MedicalDevice)) {
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

		static Delegate cb_getAddress;
#pragma warning disable 0169
		static Delegate GetGetAddressHandler ()
		{
			if (cb_getAddress == null)
				cb_getAddress = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAddress);
			return cb_getAddress;
		}

		static IntPtr n_GetAddress (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Qcl.VH.Content.MedicalDevice __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.MedicalDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Address);
		}
#pragma warning restore 0169

		static IntPtr id_getAddress;
		public virtual unsafe string Address {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='MedicalDevice']/method[@name='getAddress' and count(parameter)=0]"
			[Register ("getAddress", "()Ljava/lang/String;", "GetGetAddressHandler")]
			get {
				if (id_getAddress == IntPtr.Zero)
					id_getAddress = JNIEnv.GetMethodID (class_ref, "getAddress", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getAddress), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAddress", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getChannel;
#pragma warning disable 0169
		static Delegate GetGetChannelHandler ()
		{
			if (cb_getChannel == null)
				cb_getChannel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetChannel);
			return cb_getChannel;
		}

		static int n_GetChannel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Qcl.VH.Content.MedicalDevice __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.MedicalDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Channel;
		}
#pragma warning restore 0169

		static IntPtr id_getChannel;
		public virtual unsafe int Channel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='MedicalDevice']/method[@name='getChannel' and count(parameter)=0]"
			[Register ("getChannel", "()I", "GetGetChannelHandler")]
			get {
				if (id_getChannel == IntPtr.Zero)
					id_getChannel = JNIEnv.GetMethodID (class_ref, "getChannel", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getChannel);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getChannel", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getChannelMode;
#pragma warning disable 0169
		static Delegate GetGetChannelModeHandler ()
		{
			if (cb_getChannelMode == null)
				cb_getChannelMode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetChannelMode);
			return cb_getChannelMode;
		}

		static int n_GetChannelMode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Qcl.VH.Content.MedicalDevice __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.MedicalDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ChannelMode;
		}
#pragma warning restore 0169

		static IntPtr id_getChannelMode;
		public virtual unsafe int ChannelMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='MedicalDevice']/method[@name='getChannelMode' and count(parameter)=0]"
			[Register ("getChannelMode", "()I", "GetGetChannelModeHandler")]
			get {
				if (id_getChannelMode == IntPtr.Zero)
					id_getChannelMode = JNIEnv.GetMethodID (class_ref, "getChannelMode", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getChannelMode);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getChannelMode", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getDiscreteAdapterClassName;
#pragma warning disable 0169
		static Delegate GetGetDiscreteAdapterClassNameHandler ()
		{
			if (cb_getDiscreteAdapterClassName == null)
				cb_getDiscreteAdapterClassName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDiscreteAdapterClassName);
			return cb_getDiscreteAdapterClassName;
		}

		static IntPtr n_GetDiscreteAdapterClassName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Qcl.VH.Content.MedicalDevice __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.MedicalDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DiscreteAdapterClassName);
		}
#pragma warning restore 0169

		static IntPtr id_getDiscreteAdapterClassName;
		public virtual unsafe string DiscreteAdapterClassName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='MedicalDevice']/method[@name='getDiscreteAdapterClassName' and count(parameter)=0]"
			[Register ("getDiscreteAdapterClassName", "()Ljava/lang/String;", "GetGetDiscreteAdapterClassNameHandler")]
			get {
				if (id_getDiscreteAdapterClassName == IntPtr.Zero)
					id_getDiscreteAdapterClassName = JNIEnv.GetMethodID (class_ref, "getDiscreteAdapterClassName", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getDiscreteAdapterClassName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDiscreteAdapterClassName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getHeartBeatInterval;
#pragma warning disable 0169
		static Delegate GetGetHeartBeatIntervalHandler ()
		{
			if (cb_getHeartBeatInterval == null)
				cb_getHeartBeatInterval = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetHeartBeatInterval);
			return cb_getHeartBeatInterval;
		}

		static long n_GetHeartBeatInterval (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Qcl.VH.Content.MedicalDevice __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.MedicalDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HeartBeatInterval;
		}
#pragma warning restore 0169

		static IntPtr id_getHeartBeatInterval;
		public virtual unsafe long HeartBeatInterval {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='MedicalDevice']/method[@name='getHeartBeatInterval' and count(parameter)=0]"
			[Register ("getHeartBeatInterval", "()J", "GetGetHeartBeatIntervalHandler")]
			get {
				if (id_getHeartBeatInterval == IntPtr.Zero)
					id_getHeartBeatInterval = JNIEnv.GetMethodID (class_ref, "getHeartBeatInterval", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod  (Handle, id_getHeartBeatInterval);
					else
						return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHeartBeatInterval", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getInterfaceType;
#pragma warning disable 0169
		static Delegate GetGetInterfaceTypeHandler ()
		{
			if (cb_getInterfaceType == null)
				cb_getInterfaceType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInterfaceType);
			return cb_getInterfaceType;
		}

		static IntPtr n_GetInterfaceType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Qcl.VH.Content.MedicalDevice __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.MedicalDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InterfaceType);
		}
#pragma warning restore 0169

		static IntPtr id_getInterfaceType;
		public virtual unsafe global::Com.Qcl.VH.Content.VirtualHubProvider.鷭 InterfaceType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='MedicalDevice']/method[@name='getInterfaceType' and count(parameter)=0]"
			[Register ("getInterfaceType", "()Lcom/qcl/vh/content/VirtualHubProvider$鷭;", "GetGetInterfaceTypeHandler")]
			get {
				if (id_getInterfaceType == IntPtr.Zero)
					id_getInterfaceType = JNIEnv.GetMethodID (class_ref, "getInterfaceType", "()Lcom/qcl/vh/content/VirtualHubProvider$鷭;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.VirtualHubProvider.鷭> (JNIEnv.CallObjectMethod  (Handle, id_getInterfaceType), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.VirtualHubProvider.鷭> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInterfaceType", "()Lcom/qcl/vh/content/VirtualHubProvider$鷭;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isAlwaysOn;
#pragma warning disable 0169
		static Delegate GetIsAlwaysOnHandler ()
		{
			if (cb_isAlwaysOn == null)
				cb_isAlwaysOn = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsAlwaysOn);
			return cb_isAlwaysOn;
		}

		static bool n_IsAlwaysOn (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Qcl.VH.Content.MedicalDevice __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.MedicalDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAlwaysOn;
		}
#pragma warning restore 0169

		static IntPtr id_isAlwaysOn;
		public virtual unsafe bool IsAlwaysOn {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='MedicalDevice']/method[@name='isAlwaysOn' and count(parameter)=0]"
			[Register ("isAlwaysOn", "()Z", "GetIsAlwaysOnHandler")]
			get {
				if (id_isAlwaysOn == IntPtr.Zero)
					id_isAlwaysOn = JNIEnv.GetMethodID (class_ref, "isAlwaysOn", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isAlwaysOn);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isAlwaysOn", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isBonded;
#pragma warning disable 0169
		static Delegate GetIsBondedHandler ()
		{
			if (cb_isBonded == null)
				cb_isBonded = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsBonded);
			return cb_isBonded;
		}

		static bool n_IsBonded (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Qcl.VH.Content.MedicalDevice __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.MedicalDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsBonded;
		}
#pragma warning restore 0169

		static IntPtr id_isBonded;
		public virtual unsafe bool IsBonded {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='MedicalDevice']/method[@name='isBonded' and count(parameter)=0]"
			[Register ("isBonded", "()Z", "GetIsBondedHandler")]
			get {
				if (id_isBonded == IntPtr.Zero)
					id_isBonded = JNIEnv.GetMethodID (class_ref, "isBonded", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isBonded);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isBonded", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isDataFilterEnabled;
#pragma warning disable 0169
		static Delegate GetIsDataFilterEnabledHandler ()
		{
			if (cb_isDataFilterEnabled == null)
				cb_isDataFilterEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDataFilterEnabled);
			return cb_isDataFilterEnabled;
		}

		static bool n_IsDataFilterEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Qcl.VH.Content.MedicalDevice __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.MedicalDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDataFilterEnabled;
		}
#pragma warning restore 0169

		static IntPtr id_isDataFilterEnabled;
		public virtual unsafe bool IsDataFilterEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='MedicalDevice']/method[@name='isDataFilterEnabled' and count(parameter)=0]"
			[Register ("isDataFilterEnabled", "()Z", "GetIsDataFilterEnabledHandler")]
			get {
				if (id_isDataFilterEnabled == IntPtr.Zero)
					id_isDataFilterEnabled = JNIEnv.GetMethodID (class_ref, "isDataFilterEnabled", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isDataFilterEnabled);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isDataFilterEnabled", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isDecodeDataEnabled;
#pragma warning disable 0169
		static Delegate GetIsDecodeDataEnabledHandler ()
		{
			if (cb_isDecodeDataEnabled == null)
				cb_isDecodeDataEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDecodeDataEnabled);
			return cb_isDecodeDataEnabled;
		}

		static bool n_IsDecodeDataEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Qcl.VH.Content.MedicalDevice __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.MedicalDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDecodeDataEnabled;
		}
#pragma warning restore 0169

		static IntPtr id_isDecodeDataEnabled;
		public virtual unsafe bool IsDecodeDataEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='MedicalDevice']/method[@name='isDecodeDataEnabled' and count(parameter)=0]"
			[Register ("isDecodeDataEnabled", "()Z", "GetIsDecodeDataEnabledHandler")]
			get {
				if (id_isDecodeDataEnabled == IntPtr.Zero)
					id_isDecodeDataEnabled = JNIEnv.GetMethodID (class_ref, "isDecodeDataEnabled", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isDecodeDataEnabled);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isDecodeDataEnabled", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isFrameFilterEnabled;
#pragma warning disable 0169
		static Delegate GetIsFrameFilterEnabledHandler ()
		{
			if (cb_isFrameFilterEnabled == null)
				cb_isFrameFilterEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsFrameFilterEnabled);
			return cb_isFrameFilterEnabled;
		}

		static bool n_IsFrameFilterEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Qcl.VH.Content.MedicalDevice __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.MedicalDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsFrameFilterEnabled;
		}
#pragma warning restore 0169

		static IntPtr id_isFrameFilterEnabled;
		public virtual unsafe bool IsFrameFilterEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='MedicalDevice']/method[@name='isFrameFilterEnabled' and count(parameter)=0]"
			[Register ("isFrameFilterEnabled", "()Z", "GetIsFrameFilterEnabledHandler")]
			get {
				if (id_isFrameFilterEnabled == IntPtr.Zero)
					id_isFrameFilterEnabled = JNIEnv.GetMethodID (class_ref, "isFrameFilterEnabled", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isFrameFilterEnabled);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isFrameFilterEnabled", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isInsecure;
#pragma warning disable 0169
		static Delegate GetIsInsecureHandler ()
		{
			if (cb_isInsecure == null)
				cb_isInsecure = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsInsecure);
			return cb_isInsecure;
		}

		static bool n_IsInsecure (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Qcl.VH.Content.MedicalDevice __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.MedicalDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsInsecure;
		}
#pragma warning restore 0169

		static IntPtr id_isInsecure;
		public virtual unsafe bool IsInsecure {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='MedicalDevice']/method[@name='isInsecure' and count(parameter)=0]"
			[Register ("isInsecure", "()Z", "GetIsInsecureHandler")]
			get {
				if (id_isInsecure == IntPtr.Zero)
					id_isInsecure = JNIEnv.GetMethodID (class_ref, "isInsecure", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isInsecure);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isInsecure", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isMaster;
#pragma warning disable 0169
		static Delegate GetIsMasterHandler ()
		{
			if (cb_isMaster == null)
				cb_isMaster = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsMaster);
			return cb_isMaster;
		}

		static bool n_IsMaster (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Qcl.VH.Content.MedicalDevice __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.MedicalDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsMaster;
		}
#pragma warning restore 0169

		static IntPtr id_isMaster;
		public virtual unsafe bool IsMaster {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='MedicalDevice']/method[@name='isMaster' and count(parameter)=0]"
			[Register ("isMaster", "()Z", "GetIsMasterHandler")]
			get {
				if (id_isMaster == IntPtr.Zero)
					id_isMaster = JNIEnv.GetMethodID (class_ref, "isMaster", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isMaster);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isMaster", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isSlave;
#pragma warning disable 0169
		static Delegate GetIsSlaveHandler ()
		{
			if (cb_isSlave == null)
				cb_isSlave = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSlave);
			return cb_isSlave;
		}

		static bool n_IsSlave (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Qcl.VH.Content.MedicalDevice __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.MedicalDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSlave;
		}
#pragma warning restore 0169

		static IntPtr id_isSlave;
		public virtual unsafe bool IsSlave {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='MedicalDevice']/method[@name='isSlave' and count(parameter)=0]"
			[Register ("isSlave", "()Z", "GetIsSlaveHandler")]
			get {
				if (id_isSlave == IntPtr.Zero)
					id_isSlave = JNIEnv.GetMethodID (class_ref, "isSlave", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isSlave);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isSlave", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isUploadDecodedDataEnabled;
#pragma warning disable 0169
		static Delegate GetIsUploadDecodedDataEnabledHandler ()
		{
			if (cb_isUploadDecodedDataEnabled == null)
				cb_isUploadDecodedDataEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsUploadDecodedDataEnabled);
			return cb_isUploadDecodedDataEnabled;
		}

		static bool n_IsUploadDecodedDataEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Qcl.VH.Content.MedicalDevice __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.MedicalDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsUploadDecodedDataEnabled;
		}
#pragma warning restore 0169

		static IntPtr id_isUploadDecodedDataEnabled;
		public virtual unsafe bool IsUploadDecodedDataEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='MedicalDevice']/method[@name='isUploadDecodedDataEnabled' and count(parameter)=0]"
			[Register ("isUploadDecodedDataEnabled", "()Z", "GetIsUploadDecodedDataEnabledHandler")]
			get {
				if (id_isUploadDecodedDataEnabled == IntPtr.Zero)
					id_isUploadDecodedDataEnabled = JNIEnv.GetMethodID (class_ref, "isUploadDecodedDataEnabled", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isUploadDecodedDataEnabled);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isUploadDecodedDataEnabled", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getLastConnectAttemptTime;
#pragma warning disable 0169
		static Delegate GetGetLastConnectAttemptTimeHandler ()
		{
			if (cb_getLastConnectAttemptTime == null)
				cb_getLastConnectAttemptTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetLastConnectAttemptTime);
			return cb_getLastConnectAttemptTime;
		}

		static long n_GetLastConnectAttemptTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Qcl.VH.Content.MedicalDevice __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.MedicalDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LastConnectAttemptTime;
		}
#pragma warning restore 0169

		static IntPtr id_getLastConnectAttemptTime;
		public virtual unsafe long LastConnectAttemptTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='MedicalDevice']/method[@name='getLastConnectAttemptTime' and count(parameter)=0]"
			[Register ("getLastConnectAttemptTime", "()J", "GetGetLastConnectAttemptTimeHandler")]
			get {
				if (id_getLastConnectAttemptTime == IntPtr.Zero)
					id_getLastConnectAttemptTime = JNIEnv.GetMethodID (class_ref, "getLastConnectAttemptTime", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod  (Handle, id_getLastConnectAttemptTime);
					else
						return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLastConnectAttemptTime", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getLastReadingTime;
#pragma warning disable 0169
		static Delegate GetGetLastReadingTimeHandler ()
		{
			if (cb_getLastReadingTime == null)
				cb_getLastReadingTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetLastReadingTime);
			return cb_getLastReadingTime;
		}

		static long n_GetLastReadingTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Qcl.VH.Content.MedicalDevice __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.MedicalDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LastReadingTime;
		}
#pragma warning restore 0169

		static IntPtr id_getLastReadingTime;
		public virtual unsafe long LastReadingTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='MedicalDevice']/method[@name='getLastReadingTime' and count(parameter)=0]"
			[Register ("getLastReadingTime", "()J", "GetGetLastReadingTimeHandler")]
			get {
				if (id_getLastReadingTime == IntPtr.Zero)
					id_getLastReadingTime = JNIEnv.GetMethodID (class_ref, "getLastReadingTime", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod  (Handle, id_getLastReadingTime);
					else
						return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLastReadingTime", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getLastSeenTime;
#pragma warning disable 0169
		static Delegate GetGetLastSeenTimeHandler ()
		{
			if (cb_getLastSeenTime == null)
				cb_getLastSeenTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetLastSeenTime);
			return cb_getLastSeenTime;
		}

		static long n_GetLastSeenTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Qcl.VH.Content.MedicalDevice __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.MedicalDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LastSeenTime;
		}
#pragma warning restore 0169

		static IntPtr id_getLastSeenTime;
		public virtual unsafe long LastSeenTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='MedicalDevice']/method[@name='getLastSeenTime' and count(parameter)=0]"
			[Register ("getLastSeenTime", "()J", "GetGetLastSeenTimeHandler")]
			get {
				if (id_getLastSeenTime == IntPtr.Zero)
					id_getLastSeenTime = JNIEnv.GetMethodID (class_ref, "getLastSeenTime", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod  (Handle, id_getLastSeenTime);
					else
						return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLastSeenTime", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getLastSuccessfulDisconnectTime;
#pragma warning disable 0169
		static Delegate GetGetLastSuccessfulDisconnectTimeHandler ()
		{
			if (cb_getLastSuccessfulDisconnectTime == null)
				cb_getLastSuccessfulDisconnectTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetLastSuccessfulDisconnectTime);
			return cb_getLastSuccessfulDisconnectTime;
		}

		static long n_GetLastSuccessfulDisconnectTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Qcl.VH.Content.MedicalDevice __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.MedicalDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LastSuccessfulDisconnectTime;
		}
#pragma warning restore 0169

		static IntPtr id_getLastSuccessfulDisconnectTime;
		public virtual unsafe long LastSuccessfulDisconnectTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='MedicalDevice']/method[@name='getLastSuccessfulDisconnectTime' and count(parameter)=0]"
			[Register ("getLastSuccessfulDisconnectTime", "()J", "GetGetLastSuccessfulDisconnectTimeHandler")]
			get {
				if (id_getLastSuccessfulDisconnectTime == IntPtr.Zero)
					id_getLastSuccessfulDisconnectTime = JNIEnv.GetMethodID (class_ref, "getLastSuccessfulDisconnectTime", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod  (Handle, id_getLastSuccessfulDisconnectTime);
					else
						return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLastSuccessfulDisconnectTime", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getLastUnsuccessfulDisconnectTime;
#pragma warning disable 0169
		static Delegate GetGetLastUnsuccessfulDisconnectTimeHandler ()
		{
			if (cb_getLastUnsuccessfulDisconnectTime == null)
				cb_getLastUnsuccessfulDisconnectTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetLastUnsuccessfulDisconnectTime);
			return cb_getLastUnsuccessfulDisconnectTime;
		}

		static long n_GetLastUnsuccessfulDisconnectTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Qcl.VH.Content.MedicalDevice __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.MedicalDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LastUnsuccessfulDisconnectTime;
		}
#pragma warning restore 0169

		static IntPtr id_getLastUnsuccessfulDisconnectTime;
		public virtual unsafe long LastUnsuccessfulDisconnectTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='MedicalDevice']/method[@name='getLastUnsuccessfulDisconnectTime' and count(parameter)=0]"
			[Register ("getLastUnsuccessfulDisconnectTime", "()J", "GetGetLastUnsuccessfulDisconnectTimeHandler")]
			get {
				if (id_getLastUnsuccessfulDisconnectTime == IntPtr.Zero)
					id_getLastUnsuccessfulDisconnectTime = JNIEnv.GetMethodID (class_ref, "getLastUnsuccessfulDisconnectTime", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod  (Handle, id_getLastUnsuccessfulDisconnectTime);
					else
						return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLastUnsuccessfulDisconnectTime", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Qcl.VH.Content.MedicalDevice __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.MedicalDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		static IntPtr id_getName;
		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='MedicalDevice']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPassword;
#pragma warning disable 0169
		static Delegate GetGetPasswordHandler ()
		{
			if (cb_getPassword == null)
				cb_getPassword = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPassword);
			return cb_getPassword;
		}

		static IntPtr n_GetPassword (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Qcl.VH.Content.MedicalDevice __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.MedicalDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Password);
		}
#pragma warning restore 0169

		static IntPtr id_getPassword;
		public virtual unsafe string Password {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='MedicalDevice']/method[@name='getPassword' and count(parameter)=0]"
			[Register ("getPassword", "()Ljava/lang/String;", "GetGetPasswordHandler")]
			get {
				if (id_getPassword == IntPtr.Zero)
					id_getPassword = JNIEnv.GetMethodID (class_ref, "getPassword", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getPassword), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPassword", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPin;
#pragma warning disable 0169
		static Delegate GetGetPinHandler ()
		{
			if (cb_getPin == null)
				cb_getPin = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPin);
			return cb_getPin;
		}

		static int n_GetPin (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Qcl.VH.Content.MedicalDevice __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.MedicalDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Pin;
		}
#pragma warning restore 0169

		static IntPtr id_getPin;
		public virtual unsafe int Pin {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='MedicalDevice']/method[@name='getPin' and count(parameter)=0]"
			[Register ("getPin", "()I", "GetGetPinHandler")]
			get {
				if (id_getPin == IntPtr.Zero)
					id_getPin = JNIEnv.GetMethodID (class_ref, "getPin", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getPin);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPin", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getPollingInterval;
#pragma warning disable 0169
		static Delegate GetGetPollingIntervalHandler ()
		{
			if (cb_getPollingInterval == null)
				cb_getPollingInterval = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetPollingInterval);
			return cb_getPollingInterval;
		}

		static long n_GetPollingInterval (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Qcl.VH.Content.MedicalDevice __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.MedicalDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PollingInterval;
		}
#pragma warning restore 0169

		static IntPtr id_getPollingInterval;
		public virtual unsafe long PollingInterval {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='MedicalDevice']/method[@name='getPollingInterval' and count(parameter)=0]"
			[Register ("getPollingInterval", "()J", "GetGetPollingIntervalHandler")]
			get {
				if (id_getPollingInterval == IntPtr.Zero)
					id_getPollingInterval = JNIEnv.GetMethodID (class_ref, "getPollingInterval", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod  (Handle, id_getPollingInterval);
					else
						return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPollingInterval", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getSendCommandAdapterClassName;
#pragma warning disable 0169
		static Delegate GetGetSendCommandAdapterClassNameHandler ()
		{
			if (cb_getSendCommandAdapterClassName == null)
				cb_getSendCommandAdapterClassName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSendCommandAdapterClassName);
			return cb_getSendCommandAdapterClassName;
		}

		static IntPtr n_GetSendCommandAdapterClassName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Qcl.VH.Content.MedicalDevice __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.MedicalDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SendCommandAdapterClassName);
		}
#pragma warning restore 0169

		static IntPtr id_getSendCommandAdapterClassName;
		public virtual unsafe string SendCommandAdapterClassName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='MedicalDevice']/method[@name='getSendCommandAdapterClassName' and count(parameter)=0]"
			[Register ("getSendCommandAdapterClassName", "()Ljava/lang/String;", "GetGetSendCommandAdapterClassNameHandler")]
			get {
				if (id_getSendCommandAdapterClassName == IntPtr.Zero)
					id_getSendCommandAdapterClassName = JNIEnv.GetMethodID (class_ref, "getSendCommandAdapterClassName", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getSendCommandAdapterClassName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSendCommandAdapterClassName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSensorConfig;
#pragma warning disable 0169
		static Delegate GetGetSensorConfigHandler ()
		{
			if (cb_getSensorConfig == null)
				cb_getSensorConfig = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSensorConfig);
			return cb_getSensorConfig;
		}

		static IntPtr n_GetSensorConfig (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Qcl.VH.Content.MedicalDevice __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.MedicalDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SensorConfig);
		}
#pragma warning restore 0169

		static IntPtr id_getSensorConfig;
		public virtual unsafe global::Java.Util.HashSet SensorConfig {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='MedicalDevice']/method[@name='getSensorConfig' and count(parameter)=0]"
			[Register ("getSensorConfig", "()Ljava/util/HashSet;", "GetGetSensorConfigHandler")]
			get {
				if (id_getSensorConfig == IntPtr.Zero)
					id_getSensorConfig = JNIEnv.GetMethodID (class_ref, "getSensorConfig", "()Ljava/util/HashSet;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.HashSet> (JNIEnv.CallObjectMethod  (Handle, id_getSensorConfig), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.HashSet> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSensorConfig", "()Ljava/util/HashSet;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSensorId;
#pragma warning disable 0169
		static Delegate GetGetSensorIdHandler ()
		{
			if (cb_getSensorId == null)
				cb_getSensorId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetSensorId);
			return cb_getSensorId;
		}

		static long n_GetSensorId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Qcl.VH.Content.MedicalDevice __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.MedicalDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SensorId;
		}
#pragma warning restore 0169

		static IntPtr id_getSensorId;
		public virtual unsafe long SensorId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='MedicalDevice']/method[@name='getSensorId' and count(parameter)=0]"
			[Register ("getSensorId", "()J", "GetGetSensorIdHandler")]
			get {
				if (id_getSensorId == IntPtr.Zero)
					id_getSensorId = JNIEnv.GetMethodID (class_ref, "getSensorId", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod  (Handle, id_getSensorId);
					else
						return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSensorId", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getSerialNumber;
#pragma warning disable 0169
		static Delegate GetGetSerialNumberHandler ()
		{
			if (cb_getSerialNumber == null)
				cb_getSerialNumber = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSerialNumber);
			return cb_getSerialNumber;
		}

		static IntPtr n_GetSerialNumber (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Qcl.VH.Content.MedicalDevice __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.MedicalDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SerialNumber);
		}
#pragma warning restore 0169

		static IntPtr id_getSerialNumber;
		public virtual unsafe string SerialNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='MedicalDevice']/method[@name='getSerialNumber' and count(parameter)=0]"
			[Register ("getSerialNumber", "()Ljava/lang/String;", "GetGetSerialNumberHandler")]
			get {
				if (id_getSerialNumber == IntPtr.Zero)
					id_getSerialNumber = JNIEnv.GetMethodID (class_ref, "getSerialNumber", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getSerialNumber), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSerialNumber", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getServiceName;
#pragma warning disable 0169
		static Delegate GetGetServiceNameHandler ()
		{
			if (cb_getServiceName == null)
				cb_getServiceName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetServiceName);
			return cb_getServiceName;
		}

		static IntPtr n_GetServiceName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Qcl.VH.Content.MedicalDevice __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.MedicalDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ServiceName);
		}
#pragma warning restore 0169

		static IntPtr id_getServiceName;
		public virtual unsafe string ServiceName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='MedicalDevice']/method[@name='getServiceName' and count(parameter)=0]"
			[Register ("getServiceName", "()Ljava/lang/String;", "GetGetServiceNameHandler")]
			get {
				if (id_getServiceName == IntPtr.Zero)
					id_getServiceName = JNIEnv.GetMethodID (class_ref, "getServiceName", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getServiceName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getServiceName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getUsbDeviceClass;
#pragma warning disable 0169
		static Delegate GetGetUsbDeviceClassHandler ()
		{
			if (cb_getUsbDeviceClass == null)
				cb_getUsbDeviceClass = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetUsbDeviceClass);
			return cb_getUsbDeviceClass;
		}

		static int n_GetUsbDeviceClass (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Qcl.VH.Content.MedicalDevice __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.MedicalDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UsbDeviceClass;
		}
#pragma warning restore 0169

		static IntPtr id_getUsbDeviceClass;
		public virtual unsafe int UsbDeviceClass {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='MedicalDevice']/method[@name='getUsbDeviceClass' and count(parameter)=0]"
			[Register ("getUsbDeviceClass", "()I", "GetGetUsbDeviceClassHandler")]
			get {
				if (id_getUsbDeviceClass == IntPtr.Zero)
					id_getUsbDeviceClass = JNIEnv.GetMethodID (class_ref, "getUsbDeviceClass", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getUsbDeviceClass);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUsbDeviceClass", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getUuid;
#pragma warning disable 0169
		static Delegate GetGetUuidHandler ()
		{
			if (cb_getUuid == null)
				cb_getUuid = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUuid);
			return cb_getUuid;
		}

		static IntPtr n_GetUuid (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Qcl.VH.Content.MedicalDevice __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.MedicalDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Uuid);
		}
#pragma warning restore 0169

		static IntPtr id_getUuid;
		public virtual unsafe global::Java.Util.UUID Uuid {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='MedicalDevice']/method[@name='getUuid' and count(parameter)=0]"
			[Register ("getUuid", "()Ljava/util/UUID;", "GetGetUuidHandler")]
			get {
				if (id_getUuid == IntPtr.Zero)
					id_getUuid = JNIEnv.GetMethodID (class_ref, "getUuid", "()Ljava/util/UUID;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (JNIEnv.CallObjectMethod  (Handle, id_getUuid), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUuid", "()Ljava/util/UUID;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getmCoolOffTime;
#pragma warning disable 0169
		static Delegate GetGetmCoolOffTimeHandler ()
		{
			if (cb_getmCoolOffTime == null)
				cb_getmCoolOffTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetmCoolOffTime);
			return cb_getmCoolOffTime;
		}

		static long n_GetmCoolOffTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Qcl.VH.Content.MedicalDevice __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.MedicalDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetmCoolOffTime ();
		}
#pragma warning restore 0169

		static IntPtr id_getmCoolOffTime;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='MedicalDevice']/method[@name='getmCoolOffTime' and count(parameter)=0]"
		[Register ("getmCoolOffTime", "()J", "GetGetmCoolOffTimeHandler")]
		public virtual unsafe long GetmCoolOffTime ()
		{
			if (id_getmCoolOffTime == IntPtr.Zero)
				id_getmCoolOffTime = JNIEnv.GetMethodID (class_ref, "getmCoolOffTime", "()J");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod  (Handle, id_getmCoolOffTime);
				else
					return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getmCoolOffTime", "()J"));
			} finally {
			}
		}

		static Delegate cb_requiresDiscovery;
#pragma warning disable 0169
		static Delegate GetRequiresDiscoveryHandler ()
		{
			if (cb_requiresDiscovery == null)
				cb_requiresDiscovery = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_RequiresDiscovery);
			return cb_requiresDiscovery;
		}

		static bool n_RequiresDiscovery (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Qcl.VH.Content.MedicalDevice __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.MedicalDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RequiresDiscovery ();
		}
#pragma warning restore 0169

		static IntPtr id_requiresDiscovery;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='MedicalDevice']/method[@name='requiresDiscovery' and count(parameter)=0]"
		[Register ("requiresDiscovery", "()Z", "GetRequiresDiscoveryHandler")]
		public virtual unsafe bool RequiresDiscovery ()
		{
			if (id_requiresDiscovery == IntPtr.Zero)
				id_requiresDiscovery = JNIEnv.GetMethodID (class_ref, "requiresDiscovery", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_requiresDiscovery);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "requiresDiscovery", "()Z"));
			} finally {
			}
		}

		static Delegate cb_requiresSNVerification;
#pragma warning disable 0169
		static Delegate GetRequiresSNVerificationHandler ()
		{
			if (cb_requiresSNVerification == null)
				cb_requiresSNVerification = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_RequiresSNVerification);
			return cb_requiresSNVerification;
		}

		static bool n_RequiresSNVerification (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Qcl.VH.Content.MedicalDevice __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.MedicalDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RequiresSNVerification ();
		}
#pragma warning restore 0169

		static IntPtr id_requiresSNVerification;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='MedicalDevice']/method[@name='requiresSNVerification' and count(parameter)=0]"
		[Register ("requiresSNVerification", "()Z", "GetRequiresSNVerificationHandler")]
		public virtual unsafe bool RequiresSNVerification ()
		{
			if (id_requiresSNVerification == IntPtr.Zero)
				id_requiresSNVerification = JNIEnv.GetMethodID (class_ref, "requiresSNVerification", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_requiresSNVerification);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "requiresSNVerification", "()Z"));
			} finally {
			}
		}

		static Delegate cb_shouldSetTime_J;
#pragma warning disable 0169
		static Delegate GetShouldSetTime_JHandler ()
		{
			if (cb_shouldSetTime_J == null)
				cb_shouldSetTime_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, bool>) n_ShouldSetTime_J);
			return cb_shouldSetTime_J;
		}

		static bool n_ShouldSetTime_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Qcl.VH.Content.MedicalDevice __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.MedicalDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShouldSetTime (p0);
		}
#pragma warning restore 0169

		static IntPtr id_shouldSetTime_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='MedicalDevice']/method[@name='shouldSetTime' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("shouldSetTime", "(J)Z", "GetShouldSetTime_JHandler")]
		public virtual unsafe bool ShouldSetTime (long p0)
		{
			if (id_shouldSetTime_J == IntPtr.Zero)
				id_shouldSetTime_J = JNIEnv.GetMethodID (class_ref, "shouldSetTime", "(J)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_shouldSetTime_J, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "shouldSetTime", "(J)Z"), __args);
			} finally {
			}
		}

	}
}
