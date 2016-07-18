using Foundation;
using Xamarin.Forms;
using YourProject.iOS;
using System.Collections.ObjectModel;

[assembly: Dependency(typeof(Preferences))]
namespace YourProject.iOS
{
	public class Preferences : IPlatformPreferences
	{
		private const string VALUES = "VALUES";

		public Collection<string> getValues()
		{
			Collection<string> values = new Collection<string>();
			NSObject[] arrayValues = NSUserDefaults.StandardUserDefaults.ArrayForKey(VALUES);
			if (arrayValues != null)
			{
				foreach (NSObject arrayvalue in arrayValues)
				{
					values.Add(arrayvalue.ToString());
				}
			}

			return values;
		}

		public void saveValues(Collection<string> values)
		{
			NSMutableArray arrayValues = new NSMutableArray();
			for (int i = 0; i < values.Count; i++)
			{
				arrayValues.Add(new NSString(values[i]));
			}
			NSUserDefaults.StandardUserDefaults.SetValueForKey(arrayValues, new NSString(VALUES));
			NSUserDefaults.StandardUserDefaults.Synchronize();            
		}

		public void clearValues()
		{
			NSUserDefaults.StandardUserDefaults.RemoveObject(VALUES);
			NSUserDefaults.StandardUserDefaults.Synchronize();
		}

	}
}
