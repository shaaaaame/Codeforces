using System;
using System.Text;

namespace Codeforces
{
	class TheatreSquare
	{
		static void Main(string[] args)
		{
			int[] nma = GetInput();
			decimal n = nma[0];
			decimal  m = nma[1];
			decimal a = nma[2];

			decimal x = n / a;
			decimal y = m / a;

			decimal ans = Math.Ceiling(x) * Math.Ceiling(y);

			Console.WriteLine(ans);



		}

		static int[] GetInput()
		{
			string enter = Console.ReadLine();
			string[] enterSplit = enter.Split();

			int[] returnArray = new int[3];

			for (int i = 0; i < 3; i++)
			{
				returnArray[i] = Convert.ToInt32(enterSplit[i]);
			}

			return returnArray;
		}
	}


}