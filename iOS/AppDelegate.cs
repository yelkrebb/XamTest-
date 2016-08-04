using System;
using System.Collections.Generic;
using System.Linq;

using XamTest;

using Foundation;
using UIKit;
using Motion.Core.SyncHandler;

namespace XamTest.iOS
{
	[Register ("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init ();

			//App.SetAdapter (Motion.Mobile.Core.BLE.Adapter.Current);


			SyncHandler syncHandler = new Motion.Core.SyncHandler.SyncHandler();
			App appl = new App();
			appl.SetSyncHandler(syncHandler);

			LoadApplication (new App ());

			return base.FinishedLaunching (app, options);
		}
	}
}

