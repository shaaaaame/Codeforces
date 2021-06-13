using System;
using System.Text;

namespace Codeforces
{
	class PetyaAndStrings
	{
		static void Main(string[] args)
        {
			string line1 = Console.ReadLine().ToLower();
			string line2 = Console.ReadLine().ToLower();

			for (int i = 0; i < line1.Length; i++)
			{
				int o = Compare(line1[i], line2[i]);

				if (o == -1 || o == 1 )
				{
					Console.WriteLine(o);
					break;
				} else if (i == line1.Length - 1)
				{
					Console.WriteLine(o);
				}
			}
        }

		static int Compare(char a, char b)
		{
			int asciiA = (int)a;
			int asciiB = (int)b;

			if (asciiA > asciiB)
			{
				return 1;
			}
			else if (asciiB > asciiA)
			{
				return -1;
			}
			else return 0;
		}
	}
}
