using System;
using System.Collections.Generic;

namespace Codeforces
{
	class WordSubtraction
	{
		static void Main(string[] args)
		{
			string[] enter = Console.ReadLine().Split(" ");
			int n = Convert.ToInt32(enter[0]);
			int k = Convert.ToInt32(enter[1]);

			for (int i = 0; i < k; i++)
			{
				if (n % 10 == 0)
				{
					n = n / 10;
				}
				else
				{
					n = n - 1;
				}
			}

			Console.WriteLine(n);

		}

	}
}
