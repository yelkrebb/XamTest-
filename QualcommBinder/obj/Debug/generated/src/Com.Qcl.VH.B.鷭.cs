using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.B {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.b']/class[@name='鷭']"
	[global::Android.Runtime.Register ("com/qcl/vh/b/鷭", DoNotGenerateAcw=true)]
	public sealed partial class 鷭 : global::Android.Database.Sqlite.SQLiteOpenHelper {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qcl/vh/b/鷭", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (鷭); }
		}

		internal 鷭 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.b']/class[@name='鷭']/constructor[@name='鷭' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe 鷭 (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (鷭)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_onCreate_Landroid_database_sqlite_SQLiteDatabase_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.b']/class[@name='鷭']/method[@name='onCreate' and count(parameter)=1 and parameter[1][@type='android.database.sqlite.SQLiteDatabase']]"
		[Register ("onCreate", "(Landroid/database/sqlite/SQLiteDatabase;)V", "")]
		public override sealed unsafe void OnCreate (global::Android.Database.Sqlite.SQLiteDatabase p0)
		{
			if (id_onCreate_Landroid_database_sqlite_SQLiteDatabase_ == IntPtr.Zero)
				id_onCreate_Landroid_database_sqlite_SQLiteDatabase_ = JNIEnv.GetMethodID (class_ref, "onCreate", "(Landroid/database/sqlite/SQLiteDatabase;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_onCreate_Landroid_database_sqlite_SQLiteDatabase_, __args);
			} finally {
			}
		}

		static IntPtr id_onUpgrade_Landroid_database_sqlite_SQLiteDatabase_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.b']/class[@name='鷭']/method[@name='onUpgrade' and count(parameter)=3 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("onUpgrade", "(Landroid/database/sqlite/SQLiteDatabase;II)V", "")]
		public override sealed unsafe void OnUpgrade (global::Android.Database.Sqlite.SQLiteDatabase p0, int p1, int p2)
		{
			if (id_onUpgrade_Landroid_database_sqlite_SQLiteDatabase_II == IntPtr.Zero)
				id_onUpgrade_Landroid_database_sqlite_SQLiteDatabase_II = JNIEnv.GetMethodID (class_ref, "onUpgrade", "(Landroid/database/sqlite/SQLiteDatabase;II)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod  (Handle, id_onUpgrade_Landroid_database_sqlite_SQLiteDatabase_II, __args);
			} finally {
			}
		}

	}
}
