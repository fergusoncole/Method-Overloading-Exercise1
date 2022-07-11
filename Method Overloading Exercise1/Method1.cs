using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloading_Exercise1
{
    internal class Method1
    {
		public static int Add(int x, int y)
		{
			return x + y;
		}

		public static decimal Add(decimal x, decimal y)
		{
			return x + y;
		}

		public static string Add(int x, int y, bool isCheck)
		{
			var sum = x + y;

			if (isCheck == true && sum > 1)
			{
				return $"{sum} dollars";
			}
			else if (isCheck == true && sum == 1)
			{
				return $"{sum} dollar";
			}
			else if (isCheck == true && sum < 1)
			{
				return $"{sum} dollars";
			}
			else
			{
				return sum.ToString();
			}
		}
	}
}
