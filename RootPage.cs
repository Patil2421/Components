using System;
using Xamarin.Forms;
using System.Linq;
using System.Collections.ObjectModel;

namespace YourProject
{
	public class RootPage : MasterDetailPage
	{
		public RootPage ()
		{
			Detail = new NavigationPage (new HomePage ());

			App.RootPage = this;

			NavigationPage.SetHasNavigationBar (this, false);
		}
	}
}


