using System;
using Xamarin.Forms;

namespace YourProject
{
	public static class SessionManager
	{
		public static string AccessToken
		{
			get
			{
				if (Application.Current.Properties.ContainsKey ("AccessToken"))
					return string.IsNullOrEmpty (Application.Current.Properties ["AccessToken"].ToString ())
						? string.Empty : Convert.ToString (Application.Current.Properties ["AccessToken"]);
				else
					return string.Empty;
			}
			set
			{
				Application.Current.Properties ["AccessToken"] = value;
			}
		}

		public static string EmailAddress
		{
			get
			{
				if (Application.Current.Properties.ContainsKey ("EmailAddress"))
					return string.IsNullOrEmpty (Application.Current.Properties ["EmailAddress"].ToString ()) ? string.Empty : Convert.ToString (Application.Current.Properties ["EmailAddress"]);
				else
					return string.Empty;
			}
			set
			{
				Application.Current.Properties ["EmailAddress"] = value;
			}
		}

		public static Int32 UserId
		{
			get
			{
				return Application.Current.Properties.ContainsKey ("UserId") ? Convert.ToInt32 (Application.Current.Properties ["UserId"]) : 0;
			}
			set
			{
				Application.Current.Properties ["UserId"] = value;
			}
		}	

		public static string UserName
		{
			get
			{
				if (Application.Current.Properties.ContainsKey ("UserName"))
					return string.IsNullOrEmpty (Application.Current.Properties ["UserName"].ToString ()) ? string.Empty : Convert.ToString (Application.Current.Properties ["UserName"]);
				else
					return string.Empty;
			}
			set
			{
				Application.Current.Properties ["UserName"] = value;
			}
		}

    }
}

