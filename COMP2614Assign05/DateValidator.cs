using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Assign05
{
	class DateValidator
	{
		public static Boolean Validate(string year, string month, string day)
		{
			var result = false;
			if (String.IsNullOrEmpty(year) || String.IsNullOrEmpty(month) || String.IsNullOrEmpty(day))
			{
				return result;
			}

			int y;
			var isValidYear = int.TryParse(year, out y);

			int m;
			var isValidMonth = int.TryParse(month, out m);

			int d;
			var isValidDay = int.TryParse(day, out d);

			if (isValidYear && isValidMonth && isValidDay)
				result = true;

			return result;
		}
	}
}
