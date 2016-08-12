using System;
using YourProject;
using YourProject.Droid;
using Android.App;
using Android.Graphics;
using System.IO;

[assembly: Xamarin.Forms.Dependency(typeof(YourProject.Droid.ScreenshotManager))]
namespace YourProject.Droid
{
	public class ScreenshotManager : IScreenshotManager
	{
		public static Activity Activity { get; set; }

		public byte[] CaptureAsync()
		{
			if(Activity == null)
			{
				throw new Exception("You have to set ScreenshotManager.Activity in your Android project");
			}

			var view = Activity.Window.DecorView;

			view.DrawingCacheEnabled = true;

			Bitmap bitmap = view.GetDrawingCache(true);

			byte[] bitmapData;

			using (var stream = new MemoryStream())
			{
				bitmap.Compress(Bitmap.CompressFormat.Png, 0, stream);
				bitmapData = stream.ToArray();
			}

			return bitmapData;
		}
	}
}

