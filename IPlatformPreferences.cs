using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourProject
{
	public interface IPlatformPreferences
	{
		Collection<string> getValues();
		void saveValues(Collection<string> values);
		void clearValues();
	}
}
