using System;
using Xamarin.Forms;
using System.Collections.Generic;
using Plugin.Connectivity;

namespace Champagn
{
	public class UserMenuPage : ContentPage
	{
		public UserMenuPage ()
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

			//HEADER Label
			Label lblUserDetail = new Label 
			{
				HorizontalOptions=LayoutOptions.CenterAndExpand,
				VerticalOptions=LayoutOptions.Start,
				Text = SessionManager.UserName,
				Style = (Style)Application.Current.Resources["MenuItemHeader"],
				FontAttributes = FontAttributes.Bold,
				ClassId="9"
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
			HomeTapGesture.Tapped += (object sender, EventArgs e) => {App.RootPage.Detail = new HomePage ();App.RootPage.IsPresented=false;};
			stkHome.GestureRecognizers.Add (HomeTapGesture);

			//LINK Profile
			Image icoProfile = new Image {
				Source = Constants.aboutUsIcon,
				Aspect = Aspect.AspectFit,
				VerticalOptions = LayoutOptions.Center,
				HorizontalOptions = LayoutOptions.Start
			};
			Label lblProfile = new Label {
				Style = (Style)Application.Current.Resources["MenuItemLabel"],
				Text = "Profile",
				ClassId = "1"
			};
			StackLayout stkProfile = new StackLayout { 
				VerticalOptions = LayoutOptions.Center,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				BackgroundColor = Color.White,
				Orientation = StackOrientation.Horizontal,
			};
			stkProfile.Children.Add (icoProfile);
			stkProfile.Children.Add (lblProfile);
			TapGestureRecognizer ProfileTapGesture = new TapGestureRecognizer ();
			ProfileTapGesture.NumberOfTapsRequired = 1;
			ProfileTapGesture.Tapped += (object sender, EventArgs e) => {DisplayAlert(Constants.AlertTitleDefaultText,Constants.PageUnderConstructionMessage,Constants.AlertCancelButtonDefaultText);App.RootPage.IsPresented=false;};
			stkProfile.GestureRecognizers.Add (ProfileTapGesture);

			//LINK OrderHistory
			Image icoOrderHistory = new Image {
				Source = Constants.TermsOfUseIcon,
				Aspect = Aspect.AspectFit,
				VerticalOptions = LayoutOptions.Center,
				HorizontalOptions = LayoutOptions.Start
			};
			Label lblOrderHistory = new Label {
				Style = (Style)Application.Current.Resources["MenuItemLabel"],
				Text = "Order History",
				ClassId = "1"
			};
			StackLayout stkOrderHistory = new StackLayout { 
				VerticalOptions = LayoutOptions.Center,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				BackgroundColor = Color.White,
				Orientation = StackOrientation.Horizontal,
			};
			stkOrderHistory.Children.Add (icoOrderHistory);
			stkOrderHistory.Children.Add (lblOrderHistory);
			TapGestureRecognizer OrderHistoryTapGesture = new TapGestureRecognizer ();
			OrderHistoryTapGesture.NumberOfTapsRequired = 1;
			OrderHistoryTapGesture.Tapped += (object sender, EventArgs e) => {DisplayAlert(Constants.AlertTitleDefaultText,Constants.PageUnderConstructionMessage,Constants.AlertCancelButtonDefaultText);App.RootPage.IsPresented=false;};
			stkOrderHistory.GestureRecognizers.Add (OrderHistoryTapGesture);

			//LINK RefundRequest
			Image icoRefundRequest = new Image {
				Source = Constants.refundRequestIcon,
				Aspect = Aspect.AspectFit,
				VerticalOptions = LayoutOptions.Center,
				HorizontalOptions = LayoutOptions.Start
			};
			Label lblRefundRequest = new Label {
				Style = (Style)Application.Current.Resources["MenuItemLabel"],
				Text = "Refund Request",
				ClassId = "1"
			};
			StackLayout stkRefundRequest = new StackLayout { 
				VerticalOptions = LayoutOptions.Center,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				BackgroundColor = Color.White,
				Orientation = StackOrientation.Horizontal,
			};
			stkRefundRequest.Children.Add (icoRefundRequest);
			stkRefundRequest.Children.Add (lblRefundRequest);
			TapGestureRecognizer RefundRequestTapGesture = new TapGestureRecognizer ();
			RefundRequestTapGesture.NumberOfTapsRequired = 1;
			RefundRequestTapGesture.Tapped += (object sender, EventArgs e) => {DisplayAlert(Constants.AlertTitleDefaultText,Constants.PageUnderConstructionMessage,Constants.AlertCancelButtonDefaultText);App.RootPage.IsPresented=false;};
			stkRefundRequest.GestureRecognizers.Add (RefundRequestTapGesture);

			//LINK PaymentMethods
			Image icoPaymentMethods = new Image {
				Source = Constants.paymentMethodsIcon,
				Aspect = Aspect.AspectFit,
				VerticalOptions = LayoutOptions.Center,
				HorizontalOptions = LayoutOptions.Start
			};
			Label lblPaymentMethods = new Label {
				Style = (Style)Application.Current.Resources["MenuItemLabel"],
				Text = "Payment Methods",
				ClassId = "1"
			};
			StackLayout stkPaymentMethods = new StackLayout { 
				VerticalOptions = LayoutOptions.Center,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				BackgroundColor = Color.White,
				Orientation = StackOrientation.Horizontal,
			};
			stkPaymentMethods.Children.Add (icoPaymentMethods);
			stkPaymentMethods.Children.Add (lblPaymentMethods);
			TapGestureRecognizer PaymentMethodsTapGesture = new TapGestureRecognizer ();
			PaymentMethodsTapGesture.NumberOfTapsRequired = 1;
			PaymentMethodsTapGesture.Tapped += (object sender, EventArgs e) => {DisplayAlert(Constants.AlertTitleDefaultText,Constants.PageUnderConstructionMessage,Constants.AlertCancelButtonDefaultText);App.RootPage.IsPresented=false;};
			stkPaymentMethods.GestureRecognizers.Add (PaymentMethodsTapGesture);

			//LINK SavedAddress
			Image icoSavedAddress = new Image {
				Source = Constants.savedAddressIcon,
				Aspect = Aspect.AspectFit,
				VerticalOptions = LayoutOptions.Center,
				HorizontalOptions = LayoutOptions.Start
			};
			Label lblSavedAddress = new Label {
				Style = (Style)Application.Current.Resources["MenuItemLabel"],
				Text = "Saved Address",
				ClassId = "1"
			};
			StackLayout stkSavedAddress = new StackLayout { 
				VerticalOptions = LayoutOptions.Center,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				BackgroundColor = Color.White,
				Orientation = StackOrientation.Horizontal,
			};
			stkSavedAddress.Children.Add (icoSavedAddress);
			stkSavedAddress.Children.Add (lblSavedAddress);
			TapGestureRecognizer SavedAddressTapGesture = new TapGestureRecognizer ();
			SavedAddressTapGesture.NumberOfTapsRequired = 1;
			SavedAddressTapGesture.Tapped += (object sender, EventArgs e) => {DisplayAlert(Constants.AlertTitleDefaultText,Constants.PageUnderConstructionMessage,Constants.AlertCancelButtonDefaultText);App.RootPage.IsPresented=false;};
			stkSavedAddress.GestureRecognizers.Add (SavedAddressTapGesture);

			//LINK SocialShare
			Image icoSocialShare = new Image {
				Source = Constants.socialShareIcon,
				Aspect = Aspect.AspectFit,
				VerticalOptions = LayoutOptions.Center,
				HorizontalOptions = LayoutOptions.Start
			};
			Label lblSocialShare = new Label {
				Style = (Style)Application.Current.Resources["MenuItemLabel"],
				Text = "Social Share",
				ClassId = "1"
			};
			StackLayout stkSocialShare = new StackLayout { 
				VerticalOptions = LayoutOptions.Center,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				BackgroundColor = Color.White,
				Orientation = StackOrientation.Horizontal,
			};
			stkSocialShare.Children.Add (icoSocialShare);
			stkSocialShare.Children.Add (lblSocialShare);
			TapGestureRecognizer SocialShareTapGesture = new TapGestureRecognizer ();
			SocialShareTapGesture.NumberOfTapsRequired = 1;
			SocialShareTapGesture.Tapped += (object sender, EventArgs e) => {DisplayAlert(Constants.AlertTitleDefaultText,Constants.PageUnderConstructionMessage,Constants.AlertCancelButtonDefaultText);App.RootPage.IsPresented=false;};
			stkSocialShare.GestureRecognizers.Add (SocialShareTapGesture);

			StackLayout stkContent = new StackLayout { 
				Spacing = 20, 
				VerticalOptions = LayoutOptions.FillAndExpand,
				BackgroundColor = Color.White,
				Padding = new Thickness(0,20,0,0),
			};

			stkContent.Children.Add (stkHome);
			stkContent.Children.Add (stkProfile);
			stkContent.Children.Add (stkOrderHistory);
			stkContent.Children.Add (stkRefundRequest);
			stkContent.Children.Add (stkPaymentMethods);
			stkContent.Children.Add (stkSavedAddress);
			stkContent.Children.Add (stkSocialShare);
			//////////CONTENT LINKS ENDS//////////

			//LOGOUT Link STARTS
			Image imgLogout = new Image 
			{
				HorizontalOptions=LayoutOptions.CenterAndExpand,
				VerticalOptions=LayoutOptions.End,
				Source=Constants.logoutIcon,
				Aspect = Aspect.AspectFit,
			};
			TapGestureRecognizer LogoutTapGesture = new TapGestureRecognizer ();
			LogoutTapGesture.NumberOfTapsRequired = 1;
			LogoutTapGesture.Tapped += (object sender, EventArgs e) => 
			{
				try
				{
					if (!CrossConnectivity.Current.IsConnected) {
						DisplayAlert(Constants.AlertTitleDefaultText,Constants.NoInternet, Constants.AlertCancelButtonDefaultText);
					} 
					else
					{
						SessionManager.EmailAddress = null;
						SessionManager.UserId = -1;
						DataPersistance dataPersistance = new DataPersistance();
						dataPersistance.ClearValues();
						App.RootPage.Master = new MenuPage();
						App.RootPage.Detail = new NavigationPage(new HomePage());
					}
				}
				catch(Exception ex)
				{

				}
				App.RootPage.IsPresented=false;
			};
			imgLogout.GestureRecognizers.Add (LogoutTapGesture);
			//LOGOUT Link ENDS

			//STACK SUBLAYOUT
			StackLayout layout = new StackLayout { 
				Spacing = 20, 
				Padding = new Thickness(50,50,50,0),
				VerticalOptions = LayoutOptions.FillAndExpand,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				BackgroundColor = Color.White,
			};
			layout.Children.Add (imgLogo);
			layout.Children.Add (lblUserDetail);
			layout.Children.Add (stkContent);
			layout.Children.Add (imgLogout);

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


