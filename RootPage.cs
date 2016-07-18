using System;
using Xamarin.Forms;
using System.Linq;
using System.Collections.ObjectModel;

namespace Champagn
{
	public class RootPage : MasterDetailPage
	{
		public RootPage ()
		{
			Detail = new NavigationPage (new HomePage ());

			App.RootPage = this;

			NavigationPage.SetHasNavigationBar (this, false);

			AutoLogin ();
		}

		void AutoLogin()
		{
			DataPersistance dataPersistance = new DataPersistance();
			if (dataPersistance.prefs != null && dataPersistance.values.Count > 0)
			{
				Collection<string> dataColle = dataPersistance.values;
				if (dataColle.Count >= 3)
				{
					string UID = dataColle [1].ToString ();

					SessionManager.EmailAddress = dataColle[0].ToString();
					SessionManager.UserId = Convert.ToInt32 (UID);
					SessionManager.UserName = dataColle[2].ToString();
					App.RootPage.Master = new UserMenuPage ();
				}
				else
				{
					App.RootPage.Master = new MenuPage();
				}
			}
			else
			{
				App.RootPage.Master = new MenuPage();
			}
		}
	}
}


