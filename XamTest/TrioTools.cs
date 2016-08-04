using System;
using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

//[assembly: XamlCompilationAttribute(XamlCompilationOptions.Compile)]
using System.Collections.ObjectModel;
using System.Diagnostics;
using Motion.Mobile.Utilities;
using Motion.Core.WSHandler;
using Motion.Core.SyncHandler;
using System.Net.Http;
using System.Threading.Tasks;

namespace XamTest
{
	public class App : Application
	{
		//TestPage testPage;
		static SyncHandler SyncHandler;
		SyncHandlerPage testPage;
		//File file;
		public App ()
		{

			//MainPage = new NavigationPage(this.testPage = new TestPage(Adapter)) {
			MainPage = new NavigationPage(this.testPage = new SyncHandlerPage())
			{
				BarBackgroundColor = Color.Yellow,
				BarTextColor = Color.Blue
			};

		}

		public void SetSyncHandler(SyncHandler syncHandler)
		{
			SyncHandler = syncHandler;
		}

		//public static void SetAdapter (IAdapter adapter) {
		//	Adapter = adapter;
		//}

		protected override void OnStart ()
		{
			// Handle when your app starts
			//this.testPage.StartScanning(0x180F.UuidFromPartial());
			this.testPage.StartScan();

		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

