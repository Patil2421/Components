using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace YourProject
{
    public class DataPersistance
    {
        public ObservableCollection<string> values;
        public IPlatformPreferences prefs;

        public DataPersistance()
        {
            prefs = DependencyService.Get<IPlatformPreferences>();
            if (prefs == null)
            {
                values = new ObservableCollection<string>();
            }
            else
            {
                values = new ObservableCollection<string>(prefs.getValues());
            }
        }
        public void AddValues(string Value)
        {
            values.Add(Value);

            if (prefs != null)
            {
                prefs.saveValues(values);
            }            
        }
        public void ClearValues()
        {
            values.Clear();
            if (prefs != null)
            {
                prefs.saveValues(values);
            }
        }
        public void RemoveValues(string Value)
        {
            values.Remove(Value);            
        }
    }
}
