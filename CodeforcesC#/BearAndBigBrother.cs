using System;
using System.Collections.Generic;

namespace Codeforces
{
	class BearAndBigBrother
	{
		static void Main(string[] args)
		{
			string[] enter = Console.ReadLine().Split(" ");
			int wLimak = Convert.ToInt32(enter[0]);
			int wBob = Convert.ToInt32(enter[1]);
			int years = 0;

			while (wLimak <= wBob)
            {
				years += 1;
				Increase(ref wLimak, ref wBob);
            }

			Console.WriteLine(years);
		}

		static void Increase(ref int a, ref int b)
		{
			a *= 3;
			b *= 2;
		}

	}
}
