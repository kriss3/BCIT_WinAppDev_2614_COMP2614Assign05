using System;

namespace COMP2614Assign05
{
	/// <summary>
	/// Helper class for Date validation;
	/// Repo location: https://github.com/kriss3/BCIT_WinAppDev_2614_COMP2614Assign05.git
	/// </summary>
	class DateValidator
	{
		/// <summary>
		/// Static method to validate input and call interal method contructing proper date;
		/// </summary>
		/// <param name="year">input year</param>
		/// <param name="month">input month</param>
		/// <param name="day">intput day</param>
		/// <returns></returns>
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
