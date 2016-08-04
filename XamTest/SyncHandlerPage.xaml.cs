using System;
using System.Collections.Generic;
using System.Diagnostics;
using Motion.Core.SyncHandler;
using Xamarin.Forms;

namespace XamTest
{
	public partial class SyncHandlerPage : ContentPage
	{
		public SyncHandlerPage()
		{
			InitializeComponent();
		}

		public void StartScan()
		{
			Debug.WriteLine("XAML: Start Scan...");
			SyncHandler.GetInstance().StartScan();
		}
	}
}

