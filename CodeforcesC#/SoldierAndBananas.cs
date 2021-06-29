using System;
using System.Collections.Generic;

namespace Codeforces
{
	class SoldierAndBananas
	{
		static void Main(string[] args)
		{
			List<int> knw = new List<int>();
			string[] enter = Console.ReadLine().Split();
			int multiplier = 1;
			int priceTotal = 0;
			foreach (string s in enter)
			{
				knw.Add(Convert.ToInt32(s));
			}

			int k = knw[0];
			int n = knw[1];
			int w = knw[2];

			for(int i = 0; i < w; i++)
			{
				priceTotal += multiplier * k;
				multiplier += 1;
			}

			if (priceTotal - n < 0)
			{
				Console.WriteLine(0);
			}
			else
			{
				Console.WriteLine(priceTotal - n);
			}
		}

	}
}
