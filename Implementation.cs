using System;
using System.Collections.Generic;
using System.IO;

using Xamarin.Forms;

namespace Champagn
{
	public partial class Mark2 : ContentPage
	{
		public Mark2 ()
		{
			InitializeComponent ();

			byte[] ScreenShotdata = await DependencyService.Get<IScreenshotManager> ().CaptureAsync ();

			GestureFrame gi = new GestureFrame
			{
				HorizontalOptions = LayoutOptions.FillAndExpand,
				VerticalOptions = LayoutOptions.FillAndExpand,
				BackgroundColor = Color.FromHex("bf3122"),
			};

			gi.SwipeDown += (s, e) =>
			{
				DisplayAlert("Gesture Info", "Swipe Down Detected", "OK");
			};

			gi.SwipeTop += (s, e) =>
			{
				DisplayAlert("Gesture Info", "Swipe Top Detected", "OK");

			};

			gi.SwipeLeft += (s, e) =>
			{
				DisplayAlert("Gesture Info", "Swipe Left Detected", "OK");

			};

			gi.SwipeRight += (s, e) =>
			{
				DisplayAlert("Gesture Info", "Swipe Right Detected", "OK");

			};

			this.Content = gi;
		}
	}
}

