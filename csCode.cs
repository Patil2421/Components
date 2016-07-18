using System;
using Xamarin.Forms;
using System.Windows.Input;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Plugin.Connectivity;

namespace YourProject
{
	public class LoginPage : BaseViewModel
	{

		public LoginPageViewModel ()
		{
			SetDefaultValues ();
		}

		void SaveAutoLoginValues()
		{
			DataPersistance dataPersistance = new DataPersistance ();
			dataPersistance.ClearValues ();
			dataPersistance.AddValues (userDetail.response.user.email.ToString ());
			dataPersistance.AddValues (userDetail.response.user.id.ToString ());
			dataPersistance.AddValues (userDetail.response.user.name.ToString());
		}
		
		void GetAutoLoginValues()
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

