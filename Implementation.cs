using System;
using System.Collections.Generic;
using System.IO;
using Xamarin.Forms;

namespace YourProject
{
	public Mark2 ()
	{
		InitializeComponent ();
		//Gets the Screenshot Image in byte[]
		byte[] ScreenShotdata = await DependencyService.Get<IScreenshotManager> ().CaptureAsync ();
		
	}
}

