using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using System.ComponentModel;
using System.Threading.Tasks;

namespace Champagn
{
    public partial class App : Application
    {
        #region Private Variables

        #endregion

        #region Public Properties
        public static double ScreenHeight { get; set; }
        public static double ScreenWidth { get; set; }
		public static RootPage RootPage { get; set; }
		public static bool IsTest { get; set; }
		public static int ExitPressCount{ get; set; }
		public static string Username { get; set; }

        #endregion      
        public App()
        {
            // The root page of your application
			InitializeComponent();

			//MainPage = new NavigationPage (new LoginPage());
			//MainPage = new NavigationPage (new HomePage());
			//MainPage = new NavigationPage (new TemplateListPage());

			//MainPage = App.RootPage = new RootPage();
			//MainPage = new NavigationPage(new MyPage());
			MainPage = new NavigationPage(new CustomiseLabelPage());
        }

		public static App Instance
		{
			get
			{
				return (App)Xamarin.Forms.Application.Current;
			}
		}

		public void Alert(string message, string title = null, string closeButton = null)
		{
			if (string.IsNullOrEmpty(closeButton))
				closeButton = "OK";

			MainPage.DisplayAlert(title, message, closeButton);
		}

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
