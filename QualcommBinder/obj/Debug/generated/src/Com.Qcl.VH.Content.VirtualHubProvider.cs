using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Qcl.VH.Content {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']"
	[global::Android.Runtime.Register ("com/qcl/vh/content/VirtualHubProvider", DoNotGenerateAcw=true)]
	public partial class VirtualHubProvider : global::Android.Content.ContentProvider {


		static IntPtr AUTHORITY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/field[@name='AUTHORITY']"
		[Register ("AUTHORITY")]
		public static string Authority {
			get {
				if (AUTHORITY_jfieldId == IntPtr.Zero)
					AUTHORITY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AUTHORITY", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AUTHORITY_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (AUTHORITY_jfieldId == IntPtr.Zero)
					AUTHORITY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AUTHORITY", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, AUTHORITY_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr AUTHORITY_DIAGNOSTICS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/field[@name='AUTHORITY_DIAGNOSTICS']"
		[Register ("AUTHORITY_DIAGNOSTICS")]
		public static string AuthorityDiagnostics {
			get {
				if (AUTHORITY_DIAGNOSTICS_jfieldId == IntPtr.Zero)
					AUTHORITY_DIAGNOSTICS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AUTHORITY_DIAGNOSTICS", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AUTHORITY_DIAGNOSTICS_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (AUTHORITY_DIAGNOSTICS_jfieldId == IntPtr.Zero)
					AUTHORITY_DIAGNOSTICS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AUTHORITY_DIAGNOSTICS", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, AUTHORITY_DIAGNOSTICS_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/field[@name='COLUMN_NAME_ADDRESS']"
		[Register ("COLUMN_NAME_ADDRESS")]
		public const string ColumnNameAddress = (string) "address";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/field[@name='COLUMN_NAME_AUTO_CONNECT_COOL_OFF_TIME']"
		[Register ("COLUMN_NAME_AUTO_CONNECT_COOL_OFF_TIME")]
		public const string ColumnNameAutoConnectCoolOffTime = (string) "auto_connect_cool_off_time";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/field[@name='COLUMN_NAME_CHANNEL_MODE']"
		[Register ("COLUMN_NAME_CHANNEL_MODE")]
		public const string ColumnNameChannelMode = (string) "channelMode";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/field[@name='COLUMN_NAME_CHANNEL_NUMBER']"
		[Register ("COLUMN_NAME_CHANNEL_NUMBER")]
		public const string ColumnNameChannelNumber = (string) "channelNumber";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/field[@name='COLUMN_NAME_COMMAND']"
		[Register ("COLUMN_NAME_COMMAND")]
		public const string ColumnNameCommand = (string) "command";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/field[@name='COLUMN_NAME_COMMAND_RESPONSE']"
		[Register ("COLUMN_NAME_COMMAND_RESPONSE")]
		public const string ColumnNameCommandResponse = (string) "response";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/field[@name='COLUMN_NAME_COMMAND_RESPONSE_DESC']"
		[Register ("COLUMN_NAME_COMMAND_RESPONSE_DESC")]
		public const string ColumnNameCommandResponseDesc = (string) "description";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/field[@name='COLUMN_NAME_COMMAND_RESPONSE_TYPE']"
		[Register ("COLUMN_NAME_COMMAND_RESPONSE_TYPE")]
		public const string ColumnNameCommandResponseType = (string) "type";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/field[@name='COLUMN_NAME_COMMAND_TYPE']"
		[Register ("COLUMN_NAME_COMMAND_TYPE")]
		public const string ColumnNameCommandType = (string) "commandType";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/field[@name='COLUMN_NAME_CUSTOMER_ID']"
		[Register ("COLUMN_NAME_CUSTOMER_ID")]
		public const string ColumnNameCustomerId = (string) "customerId";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/field[@name='COLUMN_NAME_DATA']"
		[Register ("COLUMN_NAME_DATA")]
		public const string ColumnNameData = (string) "data";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/field[@name='COLUMN_NAME_DATA_DECODED']"
		[Register ("COLUMN_NAME_DATA_DECODED")]
		public const string ColumnNameDataDecoded = (string) "dataDecoded";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/field[@name='COLUMN_NAME_DATE_CREATED']"
		[Register ("COLUMN_NAME_DATE_CREATED")]
		public const string ColumnNameDateCreated = (string) "dateCreated";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/field[@name='COLUMN_NAME_DECODED_DATA']"
		[Register ("COLUMN_NAME_DECODED_DATA")]
		public const string ColumnNameDecodedData = (string) "data";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/field[@name='COLUMN_NAME_DECODER_TYPE']"
		[Register ("COLUMN_NAME_DECODER_TYPE")]
		public const string ColumnNameDecoderType = (string) "decoder_type";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/field[@name='COLUMN_NAME_DECODE_DATA']"
		[Register ("COLUMN_NAME_DECODE_DATA")]
		public const string ColumnNameDecodeData = (string) "decodeData";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/field[@name='COLUMN_NAME_DEVICE_ADAPTER']"
		[Register ("COLUMN_NAME_DEVICE_ADAPTER")]
		public const string ColumnNameDeviceAdapter = (string) "deviceAdapter";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/field[@name='COLUMN_NAME_DEVICE_CLASS_NAME']"
		[Register ("COLUMN_NAME_DEVICE_CLASS_NAME")]
		public const string ColumnNameDeviceClassName = (string) "deviceClassName";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/field[@name='COLUMN_NAME_DEVICE_MODEL']"
		[Register ("COLUMN_NAME_DEVICE_MODEL")]
		public const string ColumnNameDeviceModel = (string) "deviceModel";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/field[@name='COLUMN_NAME_DEVICE_TYPE']"
		[Register ("COLUMN_NAME_DEVICE_TYPE")]
		public const string ColumnNameDeviceType = (string) "deviceType";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/field[@name='COLUMN_NAME_FILTER_INVALID_FRAMES']"
		[Register ("COLUMN_NAME_FILTER_INVALID_FRAMES")]
		public const string ColumnNameFilterInvalidFrames = (string) "filterInvalidFrames";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/field[@name='COLUMN_NAME_FILTER_INVALID_READINGS']"
		[Register ("COLUMN_NAME_FILTER_INVALID_READINGS")]
		public const string ColumnNameFilterInvalidReadings = (string) "filterInvalidReadings";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/field[@name='COLUMN_NAME_HEARTBEAT_INTERVAL']"
		[Register ("COLUMN_NAME_HEARTBEAT_INTERVAL")]
		public const string ColumnNameHeartbeatInterval = (string) "heartbeatInteval";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/field[@name='COLUMN_NAME_INTERFACE_TYPE']"
		[Register ("COLUMN_NAME_INTERFACE_TYPE")]
		public const string ColumnNameInterfaceType = (string) "interfaceType";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/field[@name='COLUMN_NAME_IS_ALWAYS_ON']"
		[Register ("COLUMN_NAME_IS_ALWAYS_ON")]
		public const string ColumnNameIsAlwaysOn = (string) "isAlwaysOn";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/field[@name='COLUMN_NAME_IS_BLE']"
		[Register ("COLUMN_NAME_IS_BLE")]
		public const string ColumnNameIsBle = (string) "isBle";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/field[@name='COLUMN_NAME_IS_BONDED']"
		[Register ("COLUMN_NAME_IS_BONDED")]
		public const string ColumnNameIsBonded = (string) "isBonded";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/field[@name='COLUMN_NAME_IS_CONTINUA']"
		[Register ("COLUMN_NAME_IS_CONTINUA")]
		public const string ColumnNameIsContinua = (string) "isContinua";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/field[@name='COLUMN_NAME_IS_INSECURE']"
		[Register ("COLUMN_NAME_IS_INSECURE")]
		public const string ColumnNameIsInsecure = (string) "isInsecure";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/field[@name='COLUMN_NAME_IS_MASTER']"
		[Register ("COLUMN_NAME_IS_MASTER")]
		public const string ColumnNameIsMaster = (string) "isMaster";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/field[@name='COLUMN_NAME_IS_SLAVE']"
		[Register ("COLUMN_NAME_IS_SLAVE")]
		public const string ColumnNameIsSlave = (string) "isSlave";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/field[@name='COLUMN_NAME_IV']"
		[Register ("COLUMN_NAME_IV")]
		public const string ColumnNameIv = (string) "iv";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/field[@name='COLUMN_NAME_KEY']"
		[Register ("COLUMN_NAME_KEY")]
		public const string ColumnNameKey = (string) "key";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/field[@name='COLUMN_NAME_LAST_CONNECT_ATTEMPT_TIME']"
		[Register ("COLUMN_NAME_LAST_CONNECT_ATTEMPT_TIME")]
		public const string ColumnNameLastConnectAttemptTime = (string) "lastConnectAttemptTime";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/field[@name='COLUMN_NAME_LAST_READING_TIME']"
		[Register ("COLUMN_NAME_LAST_READING_TIME")]
		public const string ColumnNameLastReadingTime = (string) "lastReadingTime";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/field[@name='COLUMN_NAME_LAST_SEEN_TIME']"
		[Register ("COLUMN_NAME_LAST_SEEN_TIME")]
		public const string ColumnNameLastSeenTime = (string) "lastSeenTime";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/field[@name='COLUMN_NAME_LAST_SET_DATE_TIME']"
		[Register ("COLUMN_NAME_LAST_SET_DATE_TIME")]
		public const string ColumnNameLastSetDateTime = (string) "lastSetDateTime";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/field[@name='COLUMN_NAME_LAST_SUCCESSFUL_DISCONNECT_TIME']"
		[Register ("COLUMN_NAME_LAST_SUCCESSFUL_DISCONNECT_TIME")]
		public const string ColumnNameLastSuccessfulDisconnectTime = (string) "lastSuccessfulDisconnectTime";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/field[@name='COLUMN_NAME_LAST_UNSUCCESSFUL_DISCONNECT_TIME']"
		[Register ("COLUMN_NAME_LAST_UNSUCCESSFUL_DISCONNECT_TIME")]
		public const string ColumnNameLastUnsuccessfulDisconnectTime = (string) "lastUnsuccessfulDisconnectTime";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/field[@name='COLUMN_NAME_MESSAGE_ID']"
		[Register ("COLUMN_NAME_MESSAGE_ID")]
		public const string ColumnNameMessageId = (string) "messageId";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/field[@name='COLUMN_NAME_MODEL_ID']"
		[Register ("COLUMN_NAME_MODEL_ID")]
		public const string ColumnNameModelId = (string) "modelId";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/field[@name='COLUMN_NAME_NAME']"
		[Register ("COLUMN_NAME_NAME")]
		public const string ColumnNameName = (string) "name";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/field[@name='COLUMN_NAME_PASSWORD']"
		[Register ("COLUMN_NAME_PASSWORD")]
		public const string ColumnNamePassword = (string) "password";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/field[@name='COLUMN_NAME_PIN']"
		[Register ("COLUMN_NAME_PIN")]
		public const string ColumnNamePin = (string) "pin";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/field[@name='COLUMN_NAME_POLL_INTERVAL']"
		[Register ("COLUMN_NAME_POLL_INTERVAL")]
		public const string ColumnNamePollInterval = (string) "pollInteval";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/field[@name='COLUMN_NAME_REQUIRES_DISCOVERY']"
		[Register ("COLUMN_NAME_REQUIRES_DISCOVERY")]
		public const string ColumnNameRequiresDiscovery = (string) "requiresDiscovery";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/field[@name='COLUMN_NAME_REQUIRES_EXPLICIT_BONDING']"
		[Register ("COLUMN_NAME_REQUIRES_EXPLICIT_BONDING")]
		public const string ColumnNameRequiresExplicitBonding = (string) "requiresExplicitBonding";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/field[@name='COLUMN_NAME_SENSOR_CONFIG']"
		[Register ("COLUMN_NAME_SENSOR_CONFIG")]
		public const string ColumnNameSensorConfig = (string) "sensorConfig";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/field[@name='COLUMN_NAME_SENSOR_ID']"
		[Register ("COLUMN_NAME_SENSOR_ID")]
		public const string ColumnNameSensorId = (string) "sensorId";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/field[@name='COLUMN_NAME_SENSOR_STATE']"
		[Register ("COLUMN_NAME_SENSOR_STATE")]
		public const string ColumnNameSensorState = (string) "sensorState";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/field[@name='COLUMN_NAME_SENSOR_STATE_TIME']"
		[Register ("COLUMN_NAME_SENSOR_STATE_TIME")]
		public const string ColumnNameSensorStateTime = (string) "sensorStateTime";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/field[@name='COLUMN_NAME_SERIAL_NUMBER']"
		[Register ("COLUMN_NAME_SERIAL_NUMBER")]
		public const string ColumnNameSerialNumber = (string) "serialNumber";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/field[@name='COLUMN_NAME_SERVICE_NAME']"
		[Register ("COLUMN_NAME_SERVICE_NAME")]
		public const string ColumnNameServiceName = (string) "serviceName";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/field[@name='COLUMN_NAME_TIME_SET_FREQUENCY']"
		[Register ("COLUMN_NAME_TIME_SET_FREQUENCY")]
		public const string ColumnNameTimeSetFrequency = (string) "timeSetFrequency";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/field[@name='COLUMN_NAME_TIME_SET_TYPE']"
		[Register ("COLUMN_NAME_TIME_SET_TYPE")]
		public const string ColumnNameTimeSetType = (string) "timeSetType";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/field[@name='COLUMN_NAME_UPLOAD_ATTEMPTS']"
		[Register ("COLUMN_NAME_UPLOAD_ATTEMPTS")]
		public const string ColumnNameUploadAttempts = (string) "uploadAttemtps";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/field[@name='COLUMN_NAME_UPLOAD_DECODED_DATA']"
		[Register ("COLUMN_NAME_UPLOAD_DECODED_DATA")]
		public const string ColumnNameUploadDecodedData = (string) "uploadDecodedData";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/field[@name='COLUMN_NAME_USB_DEVICE_CLASS']"
		[Register ("COLUMN_NAME_USB_DEVICE_CLASS")]
		public const string ColumnNameUsbDeviceClass = (string) "usbDeviceClass";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/field[@name='COLUMN_NAME_UUID_LSBS']"
		[Register ("COLUMN_NAME_UUID_LSBS")]
		public const string ColumnNameUuidLsbs = (string) "uuidLsbs";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/field[@name='COLUMN_NAME_UUID_MSBS']"
		[Register ("COLUMN_NAME_UUID_MSBS")]
		public const string ColumnNameUuidMsbs = (string) "uuidMsbs";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/field[@name='COLUMN_NAME_UUID_STRING']"
		[Register ("COLUMN_NAME_UUID_STRING")]
		public const string ColumnNameUuidString = (string) "uuidString";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/field[@name='COLUMN_NAME_VERIFY_SERIAL_NUM']"
		[Register ("COLUMN_NAME_VERIFY_SERIAL_NUM")]
		public const string ColumnNameVerifySerialNum = (string) "verifySerialNum";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/field[@name='CONTENT_ITEM_TYPE_DECODED_READINGS']"
		[Register ("CONTENT_ITEM_TYPE_DECODED_READINGS")]
		public const string ContentItemTypeDecodedReadings = (string) "vnd.android.cursor.item/vnd.qcl.vhub.decoded_readings";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/field[@name='CONTENT_ITEM_TYPE_DEVICES']"
		[Register ("CONTENT_ITEM_TYPE_DEVICES")]
		public const string ContentItemTypeDevices = (string) "vnd.android.cursor.item/vnd.qcl.vhub.devices";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/field[@name='CONTENT_ITEM_TYPE_READINGS']"
		[Register ("CONTENT_ITEM_TYPE_READINGS")]
		public const string ContentItemTypeReadings = (string) "vnd.android.cursor.item/vnd.qcl.vhub.readings";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/field[@name='CONTENT_TYPE_DECODED_READINGS']"
		[Register ("CONTENT_TYPE_DECODED_READINGS")]
		public const string ContentTypeDecodedReadings = (string) "vnd.android.cursor.dir/vnd.qcl.vhub.decoded_readings";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/field[@name='CONTENT_TYPE_DEVICES']"
		[Register ("CONTENT_TYPE_DEVICES")]
		public const string ContentTypeDevices = (string) "vnd.android.cursor.dir/vnd.qcl.vhub.devices";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/field[@name='CONTENT_TYPE_READINGS']"
		[Register ("CONTENT_TYPE_READINGS")]
		public const string ContentTypeReadings = (string) "vnd.android.cursor.dir/vnd.qcl.vhub.readings";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/field[@name='MIME_TYPE_READINGS_ITEM']"
		[Register ("MIME_TYPE_READINGS_ITEM")]
		public const string MimeTypeReadingsItem = (string) "application/octet-stream";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/field[@name='QUERY_PARAM_DISTINCT']"
		[Register ("QUERY_PARAM_DISTINCT")]
		public const string QueryParamDistinct = (string) "distinct";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/field[@name='TABLE_NAME_COMMANDS']"
		[Register ("TABLE_NAME_COMMANDS")]
		public const string TableNameCommands = (string) "commands";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/field[@name='TABLE_NAME_COMMAND_RESPONSES']"
		[Register ("TABLE_NAME_COMMAND_RESPONSES")]
		public const string TableNameCommandResponses = (string) "commandResponses";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/field[@name='TABLE_NAME_DECODED_READINGS']"
		[Register ("TABLE_NAME_DECODED_READINGS")]
		public const string TableNameDecodedReadings = (string) "decodedReadings";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/field[@name='TABLE_NAME_DEVICES']"
		[Register ("TABLE_NAME_DEVICES")]
		public const string TableNameDevices = (string) "devices";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/field[@name='TABLE_NAME_DEVICE_CLASSES']"
		[Register ("TABLE_NAME_DEVICE_CLASSES")]
		public const string TableNameDeviceClasses = (string) "deviceClasses";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/field[@name='TABLE_NAME_READINGS']"
		[Register ("TABLE_NAME_READINGS")]
		public const string TableNameReadings = (string) "readings";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/field[@name='USB_DEVICE_CLASS_MASS_STORAGE']"
		[Register ("USB_DEVICE_CLASS_MASS_STORAGE")]
		public const int UsbDeviceClassMassStorage = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/field[@name='USB_DEVICE_CLASS_UNKNOWN']"
		[Register ("USB_DEVICE_CLASS_UNKNOWN")]
		public const int UsbDeviceClassUnknown = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/field[@name='_ID']"
		[Register ("_ID")]
		public const string Id = (string) "_id";
		// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider.If']"
		[global::Android.Runtime.Register ("com/qcl/vh/content/VirtualHubProvider$If", DoNotGenerateAcw=true)]
		public partial class If : global::Java.Lang.Object, global::Android.Content.ContentProvider.IPipeDataWriter {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/qcl/vh/content/VirtualHubProvider$If", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (If); }
			}

			protected If (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_writeDataToPipe_Landroid_os_ParcelFileDescriptor_Landroid_net_Uri_Ljava_lang_String_Landroid_os_Bundle_Ljava_lang_Object_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider.If']/method[@name='writeDataToPipe' and count(parameter)=5 and parameter[1][@type='android.os.ParcelFileDescriptor'] and parameter[2][@type='android.net.Uri'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='android.os.Bundle'] and parameter[5][@type='java.lang.Object']]"
			[Register ("writeDataToPipe", "(Landroid/os/ParcelFileDescriptor;Landroid/net/Uri;Ljava/lang/String;Landroid/os/Bundle;Ljava/lang/Object;)V", "")]
			public unsafe void WriteDataToPipe (global::Android.OS.ParcelFileDescriptor p0, global::Android.Net.Uri p1, string p2, global::Android.OS.Bundle p3, global::Java.Lang.Object p4)
			{
				if (id_writeDataToPipe_Landroid_os_ParcelFileDescriptor_Landroid_net_Uri_Ljava_lang_String_Landroid_os_Bundle_Ljava_lang_Object_ == IntPtr.Zero)
					id_writeDataToPipe_Landroid_os_ParcelFileDescriptor_Landroid_net_Uri_Ljava_lang_String_Landroid_os_Bundle_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "writeDataToPipe", "(Landroid/os/ParcelFileDescriptor;Landroid/net/Uri;Ljava/lang/String;Landroid/os/Bundle;Ljava/lang/Object;)V");
				IntPtr native_p2 = JNIEnv.NewString (p2);
				try {
					JValue* __args = stackalloc JValue [5];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (native_p2);
					__args [3] = new JValue (p3);
					__args [4] = new JValue (p4);
					JNIEnv.CallVoidMethod  (Handle, id_writeDataToPipe_Landroid_os_ParcelFileDescriptor_Landroid_net_Uri_Ljava_lang_String_Landroid_os_Bundle_Ljava_lang_Object_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider.if']"
		[global::Android.Runtime.Register ("com/qcl/vh/content/VirtualHubProvider$if", DoNotGenerateAcw=true)]
		public partial class If : global::Android.Database.Sqlite.SQLiteOpenHelper {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/qcl/vh/content/VirtualHubProvider$if", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (If); }
			}

			protected If (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_onCreate_Landroid_database_sqlite_SQLiteDatabase_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider.if']/method[@name='onCreate' and count(parameter)=1 and parameter[1][@type='android.database.sqlite.SQLiteDatabase']]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider.if']/method[@name='onUpgrade' and count(parameter)=3 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider.櫯']"
		[global::Android.Runtime.Register ("com/qcl/vh/content/VirtualHubProvider$櫯", DoNotGenerateAcw=true)]
		public partial class 櫯 : global::Java.Lang.Object {


			static IntPtr ˮ͈_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider.櫯']/field[@name='ˮ͈']"
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

			// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider.櫯']/field[@name='櫯']"
			[Register ("櫯")]
			public long 櫯 {
				get {
					if (櫯_jfieldId == IntPtr.Zero)
						櫯_jfieldId = JNIEnv.GetFieldID (class_ref, "櫯", "J");
					return JNIEnv.GetLongField (Handle, 櫯_jfieldId);
				}
				set {
					if (櫯_jfieldId == IntPtr.Zero)
						櫯_jfieldId = JNIEnv.GetFieldID (class_ref, "櫯", "J");
					try {
						JNIEnv.SetField (Handle, 櫯_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr 鷭_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider.櫯']/field[@name='鷭']"
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
					return JNIEnv.FindClass ("com/qcl/vh/content/VirtualHubProvider$櫯", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (櫯); }
			}

			protected 櫯 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_qcl_vh_content_VirtualHubProvider_Ljava_lang_String_Ljava_lang_String_J;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider.櫯']/constructor[@name='VirtualHubProvider.櫯' and count(parameter)=4 and parameter[1][@type='com.qcl.vh.content.VirtualHubProvider'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='long']]"
			[Register (".ctor", "(Lcom/qcl/vh/content/VirtualHubProvider;Ljava/lang/String;Ljava/lang/String;J)V", "")]
			public unsafe 櫯 (global::Com.Qcl.VH.Content.VirtualHubProvider __self, string p1, string p2, long p3)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p1 = JNIEnv.NewString (p1);
				IntPtr native_p2 = JNIEnv.NewString (p2);
				try {
					JValue* __args = stackalloc JValue [4];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (native_p1);
					__args [2] = new JValue (native_p2);
					__args [3] = new JValue (p3);
					if (GetType () != typeof (櫯)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Ljava/lang/String;Ljava/lang/String;J)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Ljava/lang/String;Ljava/lang/String;J)V", __args);
						return;
					}

					if (id_ctor_Lcom_qcl_vh_content_VirtualHubProvider_Ljava_lang_String_Ljava_lang_String_J == IntPtr.Zero)
						id_ctor_Lcom_qcl_vh_content_VirtualHubProvider_Ljava_lang_String_Ljava_lang_String_J = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/qcl/vh/content/VirtualHubProvider;Ljava/lang/String;Ljava/lang/String;J)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_qcl_vh_content_VirtualHubProvider_Ljava_lang_String_Ljava_lang_String_J, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_qcl_vh_content_VirtualHubProvider_Ljava_lang_String_Ljava_lang_String_J, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider.鷭']"
		[global::Android.Runtime.Register ("com/qcl/vh/content/VirtualHubProvider$鷭", DoNotGenerateAcw=true)]
		public sealed partial class 鷭 : global::Java.Lang.Enum {


			static IntPtr 櫯_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider.鷭']/field[@name='櫯']"
			[Register ("櫯")]
			public static global::Com.Qcl.VH.Content.VirtualHubProvider.鷭 櫯 {
				get {
					if (櫯_jfieldId == IntPtr.Zero)
						櫯_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "櫯", "Lcom/qcl/vh/content/VirtualHubProvider$鷭;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, 櫯_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.VirtualHubProvider.鷭> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/qcl/vh/content/VirtualHubProvider$鷭", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (鷭); }
			}

			internal 鷭 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider.鷭']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/qcl/vh/content/VirtualHubProvider$鷭;", "")]
			public static unsafe global::Com.Qcl.VH.Content.VirtualHubProvider.鷭 ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/qcl/vh/content/VirtualHubProvider$鷭;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Qcl.VH.Content.VirtualHubProvider.鷭 __ret = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.VirtualHubProvider.鷭> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider.鷭']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/qcl/vh/content/VirtualHubProvider$鷭;", "")]
			public static unsafe global::Com.Qcl.VH.Content.VirtualHubProvider.鷭[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/qcl/vh/content/VirtualHubProvider$鷭;");
				try {
					return (global::Com.Qcl.VH.Content.VirtualHubProvider.鷭[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Qcl.VH.Content.VirtualHubProvider.鷭));
				} finally {
				}
			}

			static IntPtr id_鷭;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider.鷭']/method[@name='鷭' and count(parameter)=0]"
			[Register ("鷭", "()I", "")]
			public unsafe int Invoke鷭 ()
			{
				if (id_鷭 == IntPtr.Zero)
					id_鷭 = JNIEnv.GetMethodID (class_ref, "鷭", "()I");
				try {
					return JNIEnv.CallIntMethod  (Handle, id_鷭);
				} finally {
				}
			}

			static IntPtr id_鷭_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider.鷭']/method[@name='鷭' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("鷭", "(I)Lcom/qcl/vh/content/VirtualHubProvider$鷭;", "")]
			public static unsafe global::Com.Qcl.VH.Content.VirtualHubProvider.鷭 Invoke鷭 (int p0)
			{
				if (id_鷭_I == IntPtr.Zero)
					id_鷭_I = JNIEnv.GetStaticMethodID (class_ref, "鷭", "(I)Lcom/qcl/vh/content/VirtualHubProvider$鷭;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					return global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.VirtualHubProvider.鷭> (JNIEnv.CallStaticObjectMethod  (class_ref, id_鷭_I, __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/qcl/vh/content/VirtualHubProvider", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VirtualHubProvider); }
		}

		protected VirtualHubProvider (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/constructor[@name='VirtualHubProvider' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe VirtualHubProvider ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (VirtualHubProvider)) {
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

		static Delegate cb_delete_Landroid_net_Uri_Ljava_lang_String_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDelete_Landroid_net_Uri_Ljava_lang_String_arrayLjava_lang_String_Handler ()
		{
			if (cb_delete_Landroid_net_Uri_Ljava_lang_String_arrayLjava_lang_String_ == null)
				cb_delete_Landroid_net_Uri_Ljava_lang_String_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_Delete_Landroid_net_Uri_Ljava_lang_String_arrayLjava_lang_String_);
			return cb_delete_Landroid_net_Uri_Ljava_lang_String_arrayLjava_lang_String_;
		}

		static int n_Delete_Landroid_net_Uri_Ljava_lang_String_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Qcl.VH.Content.VirtualHubProvider __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.VirtualHubProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string[] p2 = (string[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (string));
			int __ret = __this.Delete (p0, p1, p2);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_delete_Landroid_net_Uri_Ljava_lang_String_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/method[@name='delete' and count(parameter)=3 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String[]']]"
		[Register ("delete", "(Landroid/net/Uri;Ljava/lang/String;[Ljava/lang/String;)I", "GetDelete_Landroid_net_Uri_Ljava_lang_String_arrayLjava_lang_String_Handler")]
		public override unsafe int Delete (global::Android.Net.Uri p0, string p1, string[] p2)
		{
			if (id_delete_Landroid_net_Uri_Ljava_lang_String_arrayLjava_lang_String_ == IntPtr.Zero)
				id_delete_Landroid_net_Uri_Ljava_lang_String_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "delete", "(Landroid/net/Uri;Ljava/lang/String;[Ljava/lang/String;)I");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod  (Handle, id_delete_Landroid_net_Uri_Ljava_lang_String_arrayLjava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "delete", "(Landroid/net/Uri;Ljava/lang/String;[Ljava/lang/String;)I"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static IntPtr id_getCommandResponsesUri_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/method[@name='getCommandResponsesUri' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getCommandResponsesUri", "(Landroid/content/Context;)Landroid/net/Uri;", "")]
		public static unsafe global::Android.Net.Uri GetCommandResponsesUri (global::Android.Content.Context p0)
		{
			if (id_getCommandResponsesUri_Landroid_content_Context_ == IntPtr.Zero)
				id_getCommandResponsesUri_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getCommandResponsesUri", "(Landroid/content/Context;)Landroid/net/Uri;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Android.Net.Uri __ret = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getCommandResponsesUri_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getCommandsUri_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/method[@name='getCommandsUri' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getCommandsUri", "(Landroid/content/Context;)Landroid/net/Uri;", "")]
		public static unsafe global::Android.Net.Uri GetCommandsUri (global::Android.Content.Context p0)
		{
			if (id_getCommandsUri_Landroid_content_Context_ == IntPtr.Zero)
				id_getCommandsUri_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getCommandsUri", "(Landroid/content/Context;)Landroid/net/Uri;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Android.Net.Uri __ret = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getCommandsUri_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getDecodedReadingsUri_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/method[@name='getDecodedReadingsUri' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getDecodedReadingsUri", "(Landroid/content/Context;)Landroid/net/Uri;", "")]
		public static unsafe global::Android.Net.Uri GetDecodedReadingsUri (global::Android.Content.Context p0)
		{
			if (id_getDecodedReadingsUri_Landroid_content_Context_ == IntPtr.Zero)
				id_getDecodedReadingsUri_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getDecodedReadingsUri", "(Landroid/content/Context;)Landroid/net/Uri;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Android.Net.Uri __ret = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDecodedReadingsUri_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getDeviceClassesUri_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/method[@name='getDeviceClassesUri' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getDeviceClassesUri", "(Landroid/content/Context;)Landroid/net/Uri;", "")]
		public static unsafe global::Android.Net.Uri GetDeviceClassesUri (global::Android.Content.Context p0)
		{
			if (id_getDeviceClassesUri_Landroid_content_Context_ == IntPtr.Zero)
				id_getDeviceClassesUri_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getDeviceClassesUri", "(Landroid/content/Context;)Landroid/net/Uri;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Android.Net.Uri __ret = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDeviceClassesUri_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getDevicesUri_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/method[@name='getDevicesUri' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getDevicesUri", "(Landroid/content/Context;)Landroid/net/Uri;", "")]
		public static unsafe global::Android.Net.Uri GetDevicesUri (global::Android.Content.Context p0)
		{
			if (id_getDevicesUri_Landroid_content_Context_ == IntPtr.Zero)
				id_getDevicesUri_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getDevicesUri", "(Landroid/content/Context;)Landroid/net/Uri;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Android.Net.Uri __ret = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDevicesUri_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getReadingsUri_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/method[@name='getReadingsUri' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getReadingsUri", "(Landroid/content/Context;)Landroid/net/Uri;", "")]
		public static unsafe global::Android.Net.Uri GetReadingsUri (global::Android.Content.Context p0)
		{
			if (id_getReadingsUri_Landroid_content_Context_ == IntPtr.Zero)
				id_getReadingsUri_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getReadingsUri", "(Landroid/content/Context;)Landroid/net/Uri;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Android.Net.Uri __ret = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getReadingsUri_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getType_Landroid_net_Uri_;
#pragma warning disable 0169
		static Delegate GetGetType_Landroid_net_Uri_Handler ()
		{
			if (cb_getType_Landroid_net_Uri_ == null)
				cb_getType_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetType_Landroid_net_Uri_);
			return cb_getType_Landroid_net_Uri_;
		}

		static IntPtr n_GetType_Landroid_net_Uri_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Qcl.VH.Content.VirtualHubProvider __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.VirtualHubProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetType (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getType_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/method[@name='getType' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register ("getType", "(Landroid/net/Uri;)Ljava/lang/String;", "GetGetType_Landroid_net_Uri_Handler")]
		public override unsafe string GetType (global::Android.Net.Uri p0)
		{
			if (id_getType_Landroid_net_Uri_ == IntPtr.Zero)
				id_getType_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "getType", "(Landroid/net/Uri;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getType_Landroid_net_Uri_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getType", "(Landroid/net/Uri;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_insert_Landroid_net_Uri_Landroid_content_ContentValues_;
#pragma warning disable 0169
		static Delegate GetInsert_Landroid_net_Uri_Landroid_content_ContentValues_Handler ()
		{
			if (cb_insert_Landroid_net_Uri_Landroid_content_ContentValues_ == null)
				cb_insert_Landroid_net_Uri_Landroid_content_ContentValues_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Insert_Landroid_net_Uri_Landroid_content_ContentValues_);
			return cb_insert_Landroid_net_Uri_Landroid_content_ContentValues_;
		}

		static IntPtr n_Insert_Landroid_net_Uri_Landroid_content_ContentValues_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Qcl.VH.Content.VirtualHubProvider __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.VirtualHubProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.ContentValues p1 = global::Java.Lang.Object.GetObject<global::Android.Content.ContentValues> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Insert (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_insert_Landroid_net_Uri_Landroid_content_ContentValues_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/method[@name='insert' and count(parameter)=2 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='android.content.ContentValues']]"
		[Register ("insert", "(Landroid/net/Uri;Landroid/content/ContentValues;)Landroid/net/Uri;", "GetInsert_Landroid_net_Uri_Landroid_content_ContentValues_Handler")]
		public override unsafe global::Android.Net.Uri Insert (global::Android.Net.Uri p0, global::Android.Content.ContentValues p1)
		{
			if (id_insert_Landroid_net_Uri_Landroid_content_ContentValues_ == IntPtr.Zero)
				id_insert_Landroid_net_Uri_Landroid_content_ContentValues_ = JNIEnv.GetMethodID (class_ref, "insert", "(Landroid/net/Uri;Landroid/content/ContentValues;)Landroid/net/Uri;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Android.Net.Uri __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallObjectMethod  (Handle, id_insert_Landroid_net_Uri_Landroid_content_ContentValues_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "insert", "(Landroid/net/Uri;Landroid/content/ContentValues;)Landroid/net/Uri;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_onCreate;
#pragma warning disable 0169
		static Delegate GetOnCreateHandler ()
		{
			if (cb_onCreate == null)
				cb_onCreate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_OnCreate);
			return cb_onCreate;
		}

		static bool n_OnCreate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Qcl.VH.Content.VirtualHubProvider __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.VirtualHubProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OnCreate ();
		}
#pragma warning restore 0169

		static IntPtr id_onCreate;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/method[@name='onCreate' and count(parameter)=0]"
		[Register ("onCreate", "()Z", "GetOnCreateHandler")]
		public override unsafe bool OnCreate ()
		{
			if (id_onCreate == IntPtr.Zero)
				id_onCreate = JNIEnv.GetMethodID (class_ref, "onCreate", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_onCreate);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCreate", "()Z"));
			} finally {
			}
		}

		static Delegate cb_query_Landroid_net_Uri_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetQuery_Landroid_net_Uri_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_query_Landroid_net_Uri_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_ == null)
				cb_query_Landroid_net_Uri_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Query_Landroid_net_Uri_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_);
			return cb_query_Landroid_net_Uri_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_Query_Landroid_net_Uri_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Com.Qcl.VH.Content.VirtualHubProvider __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.VirtualHubProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
			string[] p1 = (string[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (string));
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string[] p3 = (string[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (string));
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Query (p0, p1, p2, p3, p4));
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_query_Landroid_net_Uri_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/method[@name='query' and count(parameter)=5 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='java.lang.String[]'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String[]'] and parameter[5][@type='java.lang.String']]"
		[Register ("query", "(Landroid/net/Uri;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;", "GetQuery_Landroid_net_Uri_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Handler")]
		public override unsafe global::Android.Database.ICursor Query (global::Android.Net.Uri p0, string[] p1, string p2, string[] p3, string p4)
		{
			if (id_query_Landroid_net_Uri_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_query_Landroid_net_Uri_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "query", "(Landroid/net/Uri;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);

				global::Android.Database.ICursor __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Database.ICursor> (JNIEnv.CallObjectMethod  (Handle, id_query_Landroid_net_Uri_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Database.ICursor> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "query", "(Landroid/net/Uri;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				JNIEnv.DeleteLocalRef (native_p2);
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static Delegate cb_setupColumnMap_ILjava_util_HashMap_;
#pragma warning disable 0169
		static Delegate GetSetupColumnMap_ILjava_util_HashMap_Handler ()
		{
			if (cb_setupColumnMap_ILjava_util_HashMap_ == null)
				cb_setupColumnMap_ILjava_util_HashMap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_SetupColumnMap_ILjava_util_HashMap_);
			return cb_setupColumnMap_ILjava_util_HashMap_;
		}

		static void n_SetupColumnMap_ILjava_util_HashMap_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Qcl.VH.Content.VirtualHubProvider __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.VirtualHubProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetupColumnMap (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setupColumnMap_ILjava_util_HashMap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/method[@name='setupColumnMap' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.util.HashMap&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("setupColumnMap", "(ILjava/util/HashMap;)V", "GetSetupColumnMap_ILjava_util_HashMap_Handler")]
		protected virtual unsafe void SetupColumnMap (int p0, global::System.Collections.Generic.IDictionary<string, string> p1)
		{
			if (id_setupColumnMap_ILjava_util_HashMap_ == IntPtr.Zero)
				id_setupColumnMap_ILjava_util_HashMap_ = JNIEnv.GetMethodID (class_ref, "setupColumnMap", "(ILjava/util/HashMap;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setupColumnMap_ILjava_util_HashMap_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setupColumnMap", "(ILjava/util/HashMap;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_update_Landroid_net_Uri_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpdate_Landroid_net_Uri_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_Handler ()
		{
			if (cb_update_Landroid_net_Uri_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_ == null)
				cb_update_Landroid_net_Uri_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_Update_Landroid_net_Uri_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_);
			return cb_update_Landroid_net_Uri_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_;
		}

		static int n_Update_Landroid_net_Uri_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Qcl.VH.Content.VirtualHubProvider __this = global::Java.Lang.Object.GetObject<global::Com.Qcl.VH.Content.VirtualHubProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.ContentValues p1 = global::Java.Lang.Object.GetObject<global::Android.Content.ContentValues> (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string[] p3 = (string[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (string));
			int __ret = __this.Update (p0, p1, p2, p3);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_update_Landroid_net_Uri_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.qcl.vh.content']/class[@name='VirtualHubProvider']/method[@name='update' and count(parameter)=4 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='android.content.ContentValues'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String[]']]"
		[Register ("update", "(Landroid/net/Uri;Landroid/content/ContentValues;Ljava/lang/String;[Ljava/lang/String;)I", "GetUpdate_Landroid_net_Uri_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_Handler")]
		public override unsafe int Update (global::Android.Net.Uri p0, global::Android.Content.ContentValues p1, string p2, string[] p3)
		{
			if (id_update_Landroid_net_Uri_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_ == IntPtr.Zero)
				id_update_Landroid_net_Uri_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "update", "(Landroid/net/Uri;Landroid/content/ContentValues;Ljava/lang/String;[Ljava/lang/String;)I");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod  (Handle, id_update_Landroid_net_Uri_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "update", "(Landroid/net/Uri;Landroid/content/ContentValues;Ljava/lang/String;[Ljava/lang/String;)I"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}
		}

	}
}
