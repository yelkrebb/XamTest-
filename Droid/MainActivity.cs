using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace XamTest.Droid
{
	[Activity (Label = "XamTest.Droid", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			global::Xamarin.Forms.Forms.Init (this, bundle);

			var adapter = new Motion.Mobile.Core.BLE.Adapter ();

			Motion.Core.SyncHandler.SyncHandler.GetInstance().setAdapter(adapter);

			App app = new App();
			app.SetSyncHandler(Motion.Core.SyncHandler.SyncHandler.GetInstance());
			//App.SetAdapter (a);

			LoadApplication (new App ());
		}
	}
}

