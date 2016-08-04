using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.Utility {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.utility']/class[@name='PersistenceUtil']"
	[global::Android.Runtime.Register ("com/qcl/vh/utility/PersistenceUtil", DoNotGenerateAcw=true)]
	public partial class PersistenceUtil : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.utility']/class[@name='PersistenceUtil']/field[@name='TAG']"
		[Register ("TAG")]
		public const string Tag = (string) "PersistenceUtil";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qcl/vh/utility/PersistenceUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PersistenceUtil); }
		}

		protected PersistenceUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.utility']/class[@name='PersistenceUtil']/constructor[@name='PersistenceUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PersistenceUtil ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (PersistenceUtil)) {
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

		static IntPtr id_encryptAndSaveReading_Landroid_content_Context_Ljavax_crypto_spec_SecretKeySpec_arrayBJLjava_lang_String_Lcom_qcl_vh_content_ˮ͈_Lcom_qcl_vh_a_c_廅_JZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.utility']/class[@name='PersistenceUtil']/method[@name='encryptAndSaveReading' and count(parameter)=9 and parameter[1][@type='android.content.Context'] and parameter[2][@type='javax.crypto.spec.SecretKeySpec'] and parameter[3][@type='byte[]'] and parameter[4][@type='long'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='com.qcl.vh.content.ˮ͈'] and parameter[7][@type='com.qcl.vh.a.c.廅'] and parameter[8][@type='long'] and parameter[9][@type='boolean']]"
		[Register ("encryptAndSaveReading", "(Landroid/content/Context;Ljavax/crypto/spec/SecretKeySpec;[BJLjava/lang/String;Lcom/qcl/vh/content/ˮ͈;Lcom/qcl/vh/a/c/廅;JZ)Landroid/net/Uri;", "")]
		public static unsafe global::Android.Net.Uri EncryptAndSaveReading (global::Android.Content.Context p0, global::Javax.Crypto.Spec.SecretKeySpec p1, byte[] p2, long p3, string p4, global::Com.Qcl.VH.Content.ˮ͈ p5, global::Com.Qcl.VH.A.C.廅 p6, long p7, bool p8)
		{
			if (id_encryptAndSaveReading_Landroid_content_Context_Ljavax_crypto_spec_SecretKeySpec_arrayBJLjava_lang_String_Lcom_qcl_vh_content_ˮ͈_Lcom_qcl_vh_a_c_廅_JZ == IntPtr.Zero)
				id_encryptAndSaveReading_Landroid_content_Context_Ljavax_crypto_spec_SecretKeySpec_arrayBJLjava_lang_String_Lcom_qcl_vh_content_ˮ͈_Lcom_qcl_vh_a_c_廅_JZ = JNIEnv.GetStaticMethodID (class_ref, "encryptAndSaveReading", "(Landroid/content/Context;Ljavax/crypto/spec/SecretKeySpec;[BJLjava/lang/String;Lcom/qcl/vh/content/ˮ͈;Lcom/qcl/vh/a/c/廅;JZ)Landroid/net/Uri;");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JValue* __args = stackalloc JValue [9];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				__args [8] = new JValue (p8);
				global::Android.Net.Uri __ret = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallStaticObjectMethod  (class_ref, id_encryptAndSaveReading_Landroid_content_Context_Ljavax_crypto_spec_SecretKeySpec_arrayBJLjava_lang_String_Lcom_qcl_vh_content_ˮ͈_Lcom_qcl_vh_a_c_廅_JZ, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static IntPtr id_getChannelToMasterMap_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.utility']/class[@name='PersistenceUtil']/method[@name='getChannelToMasterMap' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getChannelToMasterMap", "(Landroid/content/Context;)Ljava/util/HashMap;", "")]
		public static unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Integer> GetChannelToMasterMap (global::Android.Content.Context p0)
		{
			if (id_getChannelToMasterMap_Landroid_content_Context_ == IntPtr.Zero)
				id_getChannelToMasterMap_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getChannelToMasterMap", "(Landroid/content/Context;)Ljava/util/HashMap;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Integer> __ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Integer>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_getChannelToMasterMap_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getLastHubHealthUploadTime_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.utility']/class[@name='PersistenceUtil']/method[@name='getLastHubHealthUploadTime' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getLastHubHealthUploadTime", "(Landroid/content/Context;)J", "")]
		public static unsafe long GetLastHubHealthUploadTime (global::Android.Content.Context p0)
		{
			if (id_getLastHubHealthUploadTime_Landroid_content_Context_ == IntPtr.Zero)
				id_getLastHubHealthUploadTime_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getLastHubHealthUploadTime", "(Landroid/content/Context;)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_getLastHubHealthUploadTime_Landroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getPollingServiceInterval_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.utility']/class[@name='PersistenceUtil']/method[@name='getPollingServiceInterval' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getPollingServiceInterval", "(Landroid/content/Context;)J", "")]
		public static unsafe long GetPollingServiceInterval (global::Android.Content.Context p0)
		{
			if (id_getPollingServiceInterval_Landroid_content_Context_ == IntPtr.Zero)
				id_getPollingServiceInterval_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getPollingServiceInterval", "(Landroid/content/Context;)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_getPollingServiceInterval_Landroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getServerCommunicationFailureTimeStamp_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.utility']/class[@name='PersistenceUtil']/method[@name='getServerCommunicationFailureTimeStamp' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getServerCommunicationFailureTimeStamp", "(Landroid/content/Context;)Ljava/lang/Long;", "")]
		public static unsafe global::Java.Lang.Long GetServerCommunicationFailureTimeStamp (global::Android.Content.Context p0)
		{
			if (id_getServerCommunicationFailureTimeStamp_Landroid_content_Context_ == IntPtr.Zero)
				id_getServerCommunicationFailureTimeStamp_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getServerCommunicationFailureTimeStamp", "(Landroid/content/Context;)Ljava/lang/Long;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Java.Lang.Long __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getServerCommunicationFailureTimeStamp_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getUpgradeCheckIntervalInSeconds_Landroid_content_Context_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.utility']/class[@name='PersistenceUtil']/method[@name='getUpgradeCheckIntervalInSeconds' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='long']]"
		[Register ("getUpgradeCheckIntervalInSeconds", "(Landroid/content/Context;J)J", "")]
		public static unsafe long GetUpgradeCheckIntervalInSeconds (global::Android.Content.Context p0, long p1)
		{
			if (id_getUpgradeCheckIntervalInSeconds_Landroid_content_Context_J == IntPtr.Zero)
				id_getUpgradeCheckIntervalInSeconds_Landroid_content_Context_J = JNIEnv.GetStaticMethodID (class_ref, "getUpgradeCheckIntervalInSeconds", "(Landroid/content/Context;J)J");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_getUpgradeCheckIntervalInSeconds_Landroid_content_Context_J, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getVhAuthServer_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.utility']/class[@name='PersistenceUtil']/method[@name='getVhAuthServer' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getVhAuthServer", "(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetVhAuthServer (global::Android.Content.Context p0, string p1)
		{
			if (id_getVhAuthServer_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_getVhAuthServer_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getVhAuthServer", "(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getVhAuthServer_Landroid_content_Context_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_getVhId_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.utility']/class[@name='PersistenceUtil']/method[@name='getVhId' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getVhId", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetVhId (global::Android.Content.Context p0)
		{
			if (id_getVhId_Landroid_content_Context_ == IntPtr.Zero)
				id_getVhId_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getVhId", "(Landroid/content/Context;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getVhId_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getVhServer_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.utility']/class[@name='PersistenceUtil']/method[@name='getVhServer' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getVhServer", "(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetVhServer (global::Android.Content.Context p0, string p1)
		{
			if (id_getVhServer_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_getVhServer_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getVhServer", "(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getVhServer_Landroid_content_Context_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_saveChannelForMaster_Landroid_content_Context_Ljava_lang_String_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.utility']/class[@name='PersistenceUtil']/method[@name='saveChannelForMaster' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Integer']]"
		[Register ("saveChannelForMaster", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/Integer;)Z", "")]
		public static unsafe bool SaveChannelForMaster (global::Android.Content.Context p0, string p1, global::Java.Lang.Integer p2)
		{
			if (id_saveChannelForMaster_Landroid_content_Context_Ljava_lang_String_Ljava_lang_Integer_ == IntPtr.Zero)
				id_saveChannelForMaster_Landroid_content_Context_Ljava_lang_String_Ljava_lang_Integer_ = JNIEnv.GetStaticMethodID (class_ref, "saveChannelForMaster", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/Integer;)Z");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_saveChannelForMaster_Landroid_content_Context_Ljava_lang_String_Ljava_lang_Integer_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_saveEncryptedReading_Landroid_content_Context_JLjava_lang_String_arrayBarrayBarrayBarrayBLcom_qcl_vh_a_c_廅_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.utility']/class[@name='PersistenceUtil']/method[@name='saveEncryptedReading' and count(parameter)=9 and parameter[1][@type='android.content.Context'] and parameter[2][@type='long'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='byte[]'] and parameter[5][@type='byte[]'] and parameter[6][@type='byte[]'] and parameter[7][@type='byte[]'] and parameter[8][@type='com.qcl.vh.a.c.廅'] and parameter[9][@type='long']]"
		[Register ("saveEncryptedReading", "(Landroid/content/Context;JLjava/lang/String;[B[B[B[BLcom/qcl/vh/a/c/廅;J)Landroid/net/Uri;", "")]
		public static unsafe global::Android.Net.Uri SaveEncryptedReading (global::Android.Content.Context p0, long p1, string p2, byte[] p3, byte[] p4, byte[] p5, byte[] p6, global::Com.Qcl.VH.A.C.廅 p7, long p8)
		{
			if (id_saveEncryptedReading_Landroid_content_Context_JLjava_lang_String_arrayBarrayBarrayBarrayBLcom_qcl_vh_a_c_廅_J == IntPtr.Zero)
				id_saveEncryptedReading_Landroid_content_Context_JLjava_lang_String_arrayBarrayBarrayBarrayBLcom_qcl_vh_a_c_廅_J = JNIEnv.GetStaticMethodID (class_ref, "saveEncryptedReading", "(Landroid/content/Context;JLjava/lang/String;[B[B[B[BLcom/qcl/vh/a/c/廅;J)Landroid/net/Uri;");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			IntPtr native_p5 = JNIEnv.NewArray (p5);
			IntPtr native_p6 = JNIEnv.NewArray (p6);
			try {
				JValue* __args = stackalloc JValue [9];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (native_p5);
				__args [6] = new JValue (native_p6);
				__args [7] = new JValue (p7);
				__args [8] = new JValue (p8);
				global::Android.Net.Uri __ret = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallStaticObjectMethod  (class_ref, id_saveEncryptedReading_Landroid_content_Context_JLjava_lang_String_arrayBarrayBarrayBarrayBLcom_qcl_vh_a_c_廅_J, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
				if (p4 != null) {
					JNIEnv.CopyArray (native_p4, p4);
					JNIEnv.DeleteLocalRef (native_p4);
				}
				if (p5 != null) {
					JNIEnv.CopyArray (native_p5, p5);
					JNIEnv.DeleteLocalRef (native_p5);
				}
				if (p6 != null) {
					JNIEnv.CopyArray (native_p6, p6);
					JNIEnv.DeleteLocalRef (native_p6);
				}
			}
		}

		static IntPtr id_saveEncryptedReading_Landroid_content_Context_JLjava_lang_String_arrayBarrayBarrayBarrayBJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.utility']/class[@name='PersistenceUtil']/method[@name='saveEncryptedReading' and count(parameter)=8 and parameter[1][@type='android.content.Context'] and parameter[2][@type='long'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='byte[]'] and parameter[5][@type='byte[]'] and parameter[6][@type='byte[]'] and parameter[7][@type='byte[]'] and parameter[8][@type='long']]"
		[Register ("saveEncryptedReading", "(Landroid/content/Context;JLjava/lang/String;[B[B[B[BJ)Landroid/net/Uri;", "")]
		public static unsafe global::Android.Net.Uri SaveEncryptedReading (global::Android.Content.Context p0, long p1, string p2, byte[] p3, byte[] p4, byte[] p5, byte[] p6, long p7)
		{
			if (id_saveEncryptedReading_Landroid_content_Context_JLjava_lang_String_arrayBarrayBarrayBarrayBJ == IntPtr.Zero)
				id_saveEncryptedReading_Landroid_content_Context_JLjava_lang_String_arrayBarrayBarrayBarrayBJ = JNIEnv.GetStaticMethodID (class_ref, "saveEncryptedReading", "(Landroid/content/Context;JLjava/lang/String;[B[B[B[BJ)Landroid/net/Uri;");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			IntPtr native_p5 = JNIEnv.NewArray (p5);
			IntPtr native_p6 = JNIEnv.NewArray (p6);
			try {
				JValue* __args = stackalloc JValue [8];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (native_p5);
				__args [6] = new JValue (native_p6);
				__args [7] = new JValue (p7);
				global::Android.Net.Uri __ret = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallStaticObjectMethod  (class_ref, id_saveEncryptedReading_Landroid_content_Context_JLjava_lang_String_arrayBarrayBarrayBarrayBJ, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
				if (p4 != null) {
					JNIEnv.CopyArray (native_p4, p4);
					JNIEnv.DeleteLocalRef (native_p4);
				}
				if (p5 != null) {
					JNIEnv.CopyArray (native_p5, p5);
					JNIEnv.DeleteLocalRef (native_p5);
				}
				if (p6 != null) {
					JNIEnv.CopyArray (native_p6, p6);
					JNIEnv.DeleteLocalRef (native_p6);
				}
			}
		}

		static IntPtr id_saveEncryptedReading_Landroid_content_Context_JLjava_lang_String_arrayBarrayBarrayBJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.utility']/class[@name='PersistenceUtil']/method[@name='saveEncryptedReading' and count(parameter)=7 and parameter[1][@type='android.content.Context'] and parameter[2][@type='long'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='byte[]'] and parameter[5][@type='byte[]'] and parameter[6][@type='byte[]'] and parameter[7][@type='long']]"
		[Register ("saveEncryptedReading", "(Landroid/content/Context;JLjava/lang/String;[B[B[BJ)Landroid/net/Uri;", "")]
		public static unsafe global::Android.Net.Uri SaveEncryptedReading (global::Android.Content.Context p0, long p1, string p2, byte[] p3, byte[] p4, byte[] p5, long p6)
		{
			if (id_saveEncryptedReading_Landroid_content_Context_JLjava_lang_String_arrayBarrayBarrayBJ == IntPtr.Zero)
				id_saveEncryptedReading_Landroid_content_Context_JLjava_lang_String_arrayBarrayBarrayBJ = JNIEnv.GetStaticMethodID (class_ref, "saveEncryptedReading", "(Landroid/content/Context;JLjava/lang/String;[B[B[BJ)Landroid/net/Uri;");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			IntPtr native_p5 = JNIEnv.NewArray (p5);
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (native_p5);
				__args [6] = new JValue (p6);
				global::Android.Net.Uri __ret = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallStaticObjectMethod  (class_ref, id_saveEncryptedReading_Landroid_content_Context_JLjava_lang_String_arrayBarrayBarrayBJ, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
				if (p4 != null) {
					JNIEnv.CopyArray (native_p4, p4);
					JNIEnv.DeleteLocalRef (native_p4);
				}
				if (p5 != null) {
					JNIEnv.CopyArray (native_p5, p5);
					JNIEnv.DeleteLocalRef (native_p5);
				}
			}
		}

		static IntPtr id_saveUnencryptedDecodedReading_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.utility']/class[@name='PersistenceUtil']/method[@name='saveUnencryptedDecodedReading' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='long']]"
		[Register ("saveUnencryptedDecodedReading", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;J)Landroid/net/Uri;", "")]
		public static unsafe global::Android.Net.Uri SaveUnencryptedDecodedReading (global::Android.Content.Context p0, string p1, string p2, long p3)
		{
			if (id_saveUnencryptedDecodedReading_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_J == IntPtr.Zero)
				id_saveUnencryptedDecodedReading_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_J = JNIEnv.GetStaticMethodID (class_ref, "saveUnencryptedDecodedReading", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;J)Landroid/net/Uri;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				global::Android.Net.Uri __ret = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallStaticObjectMethod  (class_ref, id_saveUnencryptedDecodedReading_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_J, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_setLastHubHealthUploadTime_Landroid_content_Context_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.utility']/class[@name='PersistenceUtil']/method[@name='setLastHubHealthUploadTime' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='long']]"
		[Register ("setLastHubHealthUploadTime", "(Landroid/content/Context;J)V", "")]
		public static unsafe void SetLastHubHealthUploadTime (global::Android.Content.Context p0, long p1)
		{
			if (id_setLastHubHealthUploadTime_Landroid_content_Context_J == IntPtr.Zero)
				id_setLastHubHealthUploadTime_Landroid_content_Context_J = JNIEnv.GetStaticMethodID (class_ref, "setLastHubHealthUploadTime", "(Landroid/content/Context;J)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setLastHubHealthUploadTime_Landroid_content_Context_J, __args);
			} finally {
			}
		}

		static IntPtr id_setPollingServiceInterval_Landroid_content_Context_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.utility']/class[@name='PersistenceUtil']/method[@name='setPollingServiceInterval' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='long']]"
		[Register ("setPollingServiceInterval", "(Landroid/content/Context;J)V", "")]
		public static unsafe void SetPollingServiceInterval (global::Android.Content.Context p0, long p1)
		{
			if (id_setPollingServiceInterval_Landroid_content_Context_J == IntPtr.Zero)
				id_setPollingServiceInterval_Landroid_content_Context_J = JNIEnv.GetStaticMethodID (class_ref, "setPollingServiceInterval", "(Landroid/content/Context;J)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setPollingServiceInterval_Landroid_content_Context_J, __args);
			} finally {
			}
		}

		static IntPtr id_setServerCommunicationFailureTimeStamp_Landroid_content_Context_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.utility']/class[@name='PersistenceUtil']/method[@name='setServerCommunicationFailureTimeStamp' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='long']]"
		[Register ("setServerCommunicationFailureTimeStamp", "(Landroid/content/Context;J)V", "")]
		public static unsafe void SetServerCommunicationFailureTimeStamp (global::Android.Content.Context p0, long p1)
		{
			if (id_setServerCommunicationFailureTimeStamp_Landroid_content_Context_J == IntPtr.Zero)
				id_setServerCommunicationFailureTimeStamp_Landroid_content_Context_J = JNIEnv.GetStaticMethodID (class_ref, "setServerCommunicationFailureTimeStamp", "(Landroid/content/Context;J)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setServerCommunicationFailureTimeStamp_Landroid_content_Context_J, __args);
			} finally {
			}
		}

		static IntPtr id_setUpdateCheckInterval_Landroid_content_Context_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.utility']/class[@name='PersistenceUtil']/method[@name='setUpdateCheckInterval' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='long']]"
		[Register ("setUpdateCheckInterval", "(Landroid/content/Context;J)V", "")]
		public static unsafe void SetUpdateCheckInterval (global::Android.Content.Context p0, long p1)
		{
			if (id_setUpdateCheckInterval_Landroid_content_Context_J == IntPtr.Zero)
				id_setUpdateCheckInterval_Landroid_content_Context_J = JNIEnv.GetStaticMethodID (class_ref, "setUpdateCheckInterval", "(Landroid/content/Context;J)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setUpdateCheckInterval_Landroid_content_Context_J, __args);
			} finally {
			}
		}

		static IntPtr id_setVhAuthServer_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.utility']/class[@name='PersistenceUtil']/method[@name='setVhAuthServer' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("setVhAuthServer", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static unsafe void SetVhAuthServer (global::Android.Content.Context p0, string p1)
		{
			if (id_setVhAuthServer_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_setVhAuthServer_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "setVhAuthServer", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setVhAuthServer_Landroid_content_Context_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_setVhId_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.utility']/class[@name='PersistenceUtil']/method[@name='setVhId' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("setVhId", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static unsafe void SetVhId (global::Android.Content.Context p0, string p1)
		{
			if (id_setVhId_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_setVhId_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "setVhId", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setVhId_Landroid_content_Context_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_setVhServer_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.utility']/class[@name='PersistenceUtil']/method[@name='setVhServer' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("setVhServer", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static unsafe void SetVhServer (global::Android.Content.Context p0, string p1)
		{
			if (id_setVhServer_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_setVhServer_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "setVhServer", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setVhServer_Landroid_content_Context_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_updatePendingReadingsCount_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.utility']/class[@name='PersistenceUtil']/method[@name='updatePendingReadingsCount' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("updatePendingReadingsCount", "(Landroid/content/Context;)V", "")]
		public static unsafe void UpdatePendingReadingsCount (global::Android.Content.Context p0)
		{
			if (id_updatePendingReadingsCount_Landroid_content_Context_ == IntPtr.Zero)
				id_updatePendingReadingsCount_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "updatePendingReadingsCount", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_updatePendingReadingsCount_Landroid_content_Context_, __args);
			} finally {
			}
		}

	}
}
