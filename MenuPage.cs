using System;
using Xamarin.Forms;
using System.Collections.Generic;

namespace Champagn
{
	public class MenuPage : ContentPage
	{
		public MenuPage ()
		{
			NavigationPage.SetHasNavigationBar (this, false);
			Title = "menu"; 
			BackgroundColor = Color.FromHex ("FFFFFF");

			//HEADER Image
			Image imgLogo = new Image 
			{
				HorizontalOptions=LayoutOptions.CenterAndExpand,
				VerticalOptions=LayoutOptions.Start,
				Source=Constants.logoIcon,
				WidthRequest = App.ScreenWidth/3,
				Aspect = Aspect.AspectFill,
			};

			//////////CONTENT LINKS STARTS//////////

			//LINK Home
			Image icoHome = new Image {
				Source = Constants.homeIcon,
				Aspect = Aspect.AspectFit,
				VerticalOptions = LayoutOptions.Center,
				HorizontalOptions = LayoutOptions.Start
			};
			Label lblHome = new Label {
				Style = (Style)Application.Current.Resources["MenuItemLabel"],
				Text = "Home",
				ClassId = "1"
			};
			StackLayout stkHome = new StackLayout { 
				VerticalOptions = LayoutOptions.Center,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				BackgroundColor = Color.White,
				Orientation = StackOrientation.Horizontal,
			};
			stkHome.Children.Add (icoHome);
			stkHome.Children.Add (lblHome);

			TapGestureRecognizer HomeTapGesture = new TapGestureRecognizer ();
			HomeTapGesture.NumberOfTapsRequired = 1;
			HomeTapGesture.Tapped += (object sender, EventArgs e) => {App.RootPage.Detail = new NavigationPage(new HomePage());App.RootPage.IsPresented=false;};
			stkHome.GestureRecognizers.Add (HomeTapGesture);

			//LINK AboutUS
			Image icoAboutUs = new Image {
				Source = Constants.aboutUsIcon,
				Aspect = Aspect.AspectFit,
				VerticalOptions = LayoutOptions.Center,
				HorizontalOptions = LayoutOptions.Start
			};
			Label lblAboutUs = new Label {
				Style = (Style)Application.Current.Resources["MenuItemLabel"],
				Text = "About Us",
				ClassId = "1"
			};
			StackLayout stkAboutUs = new StackLayout { 
				VerticalOptions = LayoutOptions.Center,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				BackgroundColor = Color.White,
				Orientation = StackOrientation.Horizontal,
			};
			stkAboutUs.Children.Add (icoAboutUs);
			stkAboutUs.Children.Add (lblAboutUs);
			TapGestureRecognizer AboutUsTapGesture = new TapGestureRecognizer ();
			AboutUsTapGesture.NumberOfTapsRequired = 1;
			AboutUsTapGesture.Tapped += (object sender, EventArgs e) => {DisplayAlert(Constants.AlertTitleDefaultText,Constants.PageUnderConstructionMessage,Constants.AlertCancelButtonDefaultText);App.RootPage.IsPresented=false;};
			stkAboutUs.GestureRecognizers.Add (AboutUsTapGesture);

			//LINK PrivacyPolicy
			Image icoPrivacyPolicy = new Image {
				Source = Constants.privacyPolicyIcon,
				Aspect = Aspect.AspectFit,
				VerticalOptions = LayoutOptions.Center,
				HorizontalOptions = LayoutOptions.Start
			};
			Label lblPrivacyPolicy = new Label {
				Style = (Style)Application.Current.Resources["MenuItemLabel"],
				Text = "Privacy Policy",
				ClassId = "1"
			};
			StackLayout stkPrivacyPolicy = new StackLayout { 
				VerticalOptions = LayoutOptions.Center,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				BackgroundColor = Color.White,
				Orientation = StackOrientation.Horizontal,
			};
			stkPrivacyPolicy.Children.Add (icoPrivacyPolicy);
			stkPrivacyPolicy.Children.Add (lblPrivacyPolicy);
			TapGestureRecognizer PrivacyPolicyUsTapGesture = new TapGestureRecognizer ();
			PrivacyPolicyUsTapGesture.NumberOfTapsRequired = 1;
			PrivacyPolicyUsTapGesture.Tapped += (object sender, EventArgs e) => {DisplayAlert(Constants.AlertTitleDefaultText,Constants.PageUnderConstructionMessage,Constants.AlertCancelButtonDefaultText);App.RootPage.IsPresented=false;};
			stkPrivacyPolicy.GestureRecognizers.Add (PrivacyPolicyUsTapGesture);

			//LINK TermsOfUse
			Image icoTerms = new Image {
				Source = Constants.TermsOfUseIcon,
				Aspect = Aspect.AspectFit,
				VerticalOptions = LayoutOptions.Center,
				HorizontalOptions = LayoutOptions.Start
			};
			Label lblTerms = new Label {
				Style = (Style)Application.Current.Resources["MenuItemLabel"],
				Text = "Terms of Use",
				ClassId = "1"
			};
			StackLayout stkTerms = new StackLayout { 
				VerticalOptions = LayoutOptions.Center,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				BackgroundColor = Color.White,
				Orientation = StackOrientation.Horizontal,
			};
			stkTerms.Children.Add (icoTerms);
			stkTerms.Children.Add (lblTerms);
			TapGestureRecognizer TermsUsTapGesture = new TapGestureRecognizer ();
			TermsUsTapGesture.NumberOfTapsRequired = 1;
			TermsUsTapGesture.Tapped += (object sender, EventArgs e) => {DisplayAlert(Constants.AlertTitleDefaultText,Constants.PageUnderConstructionMessage,Constants.AlertCancelButtonDefaultText);App.RootPage.IsPresented=false;};
			stkTerms.GestureRecognizers.Add (TermsUsTapGesture);

			StackLayout stkContent = new StackLayout { 
				Spacing = 25, 
				VerticalOptions = LayoutOptions.FillAndExpand,
				BackgroundColor = Color.White,
				Padding = new Thickness(0,40,0,0),
			};

			stkContent.Children.Add (stkHome);
			stkContent.Children.Add (stkAboutUs);
			stkContent.Children.Add (stkPrivacyPolicy);
			stkContent.Children.Add (stkTerms);
			//////////CONTENT LINKS ENDS//////////

			//LOGIN Link STARTS
			Button btnLogin = new Button {
				Text = "SIGN IN",
				HorizontalOptions = LayoutOptions.FillAndExpand,
				VerticalOptions = LayoutOptions.End,
				Style = (Style)Application.Current.Resources["commonButtonFill"],
			};
			btnLogin.Clicked += (object sender, EventArgs e) => {App.RootPage.Detail = new LoginPage ();App.RootPage.IsPresented = false;};
			//LOGIN Link ENDS

			//REGISTER Link STARTS
			var stkSignUp = new StackLayout {
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				VerticalOptions = LayoutOptions.End,
				Orientation = StackOrientation.Horizontal
			};
			Image imgUserIcon = new Image 
			{
				VerticalOptions=LayoutOptions.Center,
				Source=Constants.newUserIcon,
				Aspect = Aspect.AspectFit
			};

			Label lblnewuser = new Label {
				Style = (Style)Application.Current.Resources["signUpPageNormalLbl"],
				VerticalOptions=LayoutOptions.Center,
				Text = "New user?"
			};
			Label lblRegister = new Label {
				Style = (Style)Application.Current.Resources["signUpDarkLbl"],
				VerticalOptions=LayoutOptions.Center,
				Text = "Register"
			};
			stkSignUp.Children.Add (imgUserIcon);
			stkSignUp.Children.Add (lblnewuser);
			stkSignUp.Children.Add (lblRegister);

			TapGestureRecognizer RegisterTapGesture = new TapGestureRecognizer ();
			RegisterTapGesture.NumberOfTapsRequired = 1;
			RegisterTapGesture.Tapped += (object sender, EventArgs e) => {App.RootPage.Detail = new SignUpPage ();App.RootPage.IsPresented = false;};
			stkSignUp.GestureRecognizers.Add (RegisterTapGesture);
			//REGISTER Link ENDS

			//STACK SUBLAYOUT
			StackLayout layout = new StackLayout { 
				Spacing = 20, 
				Padding = new Thickness(50),
				VerticalOptions = LayoutOptions.FillAndExpand,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				BackgroundColor = Color.White,
			};

			layout.Children.Add (imgLogo);
			layout.Children.Add (stkContent);
			layout.Children.Add (btnLogin);
			layout.Children.Add (stkSignUp);

			//STACK MAINLAYOUT
			StackLayout mainlayout = new StackLayout { 
				Orientation = StackOrientation.Horizontal,
				Spacing = 0, 
				VerticalOptions = LayoutOptions.FillAndExpand,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				BackgroundColor = Color.White,
			};
			Image imgShadow = new Image {
				Source = Constants.shadowImage,
				HorizontalOptions = LayoutOptions.End,
				VerticalOptions = LayoutOptions.EndAndExpand,
				Aspect = Aspect.AspectFit
			};
			mainlayout.Children.Add (layout);
			mainlayout.Children.Add (imgShadow);


			Content = mainlayout;

		}
	}
}


