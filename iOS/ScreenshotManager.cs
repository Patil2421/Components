using System;
using YourProject;
using YourProject.iOS;
using UIKit;

[assembly: Xamarin.Forms.Dependency(typeof(YourProject.iOS.ScreenshotManager))]
namespace YourProject.iOS
{
	public class ScreenshotManager : IScreenshotManager
	{
		public byte[] CaptureAsync()
		{
			var view = UIApplication.SharedApplication.KeyWindow.RootViewController.View;

			UIGraphics.BeginImageContext(view.Frame.Size);

			view.DrawViewHierarchy(view.Frame, true);
			var image = UIGraphics.GetImageFromCurrentImageContext();

			UIGraphics.EndImageContext();

			using(var imageData = image.AsPNG())
			{
				var bytes = new byte[imageData.Length];
				System.Runtime.InteropServices.Marshal.Copy(imageData.Bytes, bytes, 0, Convert.ToInt32(imageData.Length));
				return bytes;
			}

		}
	}
}

