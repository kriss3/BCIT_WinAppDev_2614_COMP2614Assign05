using System;

namespace COMP2614Assign05
{
	class DateValidator
	{
		public static Boolean Validate(string year, string month, string day)
		{
			var result = false;
			if (string.IsNullOrEmpty(year) || String.IsNullOrEmpty(month) || String.IsNullOrEmpty(day))
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
			{
				if (IsValidDate(y, m, d))
					result = true;
			}

			return result;
		}

		private static bool IsValidDate(int y, int m, int d)
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
