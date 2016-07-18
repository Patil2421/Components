using System;
using Android.Content;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using YourProject.Droid;
using YourProject;

[assembly: Dependency(typeof(Preferences))]
namespace YourProject.Droid
{
	public class Preferences : IPlatformPreferences
	{
		private const string PREFS_NAME = "YourProject";
		private const string VALUES = "VALUES";

		private ISharedPreferences getPreferences()
		{
			Context context = MainActivity.APPLICATION_CONTEXT;
			return context.GetSharedPreferences(PREFS_NAME, FileCreationMode.Private);
		}

		public Collection<string> getValues()
		{
			ISharedPreferences preferences = getPreferences();
			string prefValues = preferences.GetString(VALUES, "");
			Collection<string> values = new Collection<string>();

			string[] arrayValues = prefValues.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
			foreach (string value in arrayValues)
			{
				values.Add(value);
			}

			return values;
		}

		public void saveValues(Collection<string> values)
		{
			string prefValues = "";
			foreach (string value in values)
			{
				prefValues += value + "|";
			}

			ISharedPreferences preferences = getPreferences();
			ISharedPreferencesEditor editor = preferences.Edit();
			editor.PutString(VALUES, prefValues);
			editor.Commit();
		}

		public void clearValues()
		{
			ISharedPreferences preferences = getPreferences();
			ISharedPreferencesEditor editor = preferences.Edit();
			editor.Remove(VALUES);
			editor.Commit();
		}
	}
}