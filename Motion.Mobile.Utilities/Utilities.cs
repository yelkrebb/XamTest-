using System;
using System.Linq;
using System.Globalization;

namespace Motion.Mobile.Utilities
{
	public static class Utilities
	{
		public static string StringToHexString(string param)
		{
			char[] charValues = param.ToCharArray();
			string hexOutput="";
			foreach (char _eachChar in charValues )
			{
				// Get the integral value of the character.
				int value = Convert.ToInt32(_eachChar);
				// Convert the decimal value to a hexadecimal value in string form.
				hexOutput += String.Format("{0:X}", value);
				// to make output as your eg 
				//  hexOutput +=" "+ String.Format("{0:X}", value);
			}
			return hexOutput;
		}

		public static byte[] StringToByteArray(string hex) 
		{
			return Enumerable.Range(0, hex.Length)
				.Where(x => x % 2 == 0)
				.Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
				.ToArray();
		}

		public static string getMonthFullName(DateTime date)
		{
			return CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName (date.Month);
		}

		public static string getMonthShortName(DateTime date)
		{
			return CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName (date.Month);
		}
			
	}
}

