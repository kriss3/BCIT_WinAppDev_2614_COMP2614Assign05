using System;

namespace COMP2614Assign05
{
	class DateValidator
	{
		public static Boolean Validate(string year, string month, string day)
		{
			var result = false;

			int y;
			var isValidYear = int.TryParse(year, out y);

			int m;
			var isValidMonth = int.TryParse(month, out m);

			int d;
			var isValidDay = int.TryParse(day, out d);

			if (isValidYear && isValidMonth && isValidDay)
			{
				if (isValidDate(y, m, d))
					result = true;
			}

			return result;
		}

		private static bool isValidDate(int y, int m, int d)
		{
			bool result;
			try
			{
				var constructDate = new DateTime(y,m,d);
				result = true;
			}
			catch
			{
				result = false;
			}
			return result;
		}
	}
}
