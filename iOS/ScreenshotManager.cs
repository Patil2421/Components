using System;
using Champagn;
using Champagn.iOS;
using UIKit;

[assembly: Xamarin.Forms.Dependency(typeof(Champagn.iOS.ScreenshotManager))]
namespace Champagn.iOS
{
	public class ScreenshotManager : IScreenshotManager
	{
		public byte[] CaptureAsync(int height,int width)
		{
			var view = UIApplication.SharedApplication.KeyWindow.RootViewController.View;

			view.Frame = new CoreGraphics.CGRect (0, 0, width, height);

			CoreGraphics.CGSize newsize = view.Frame.Size;

			UIGraphics.BeginImageContext(newsize);

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

