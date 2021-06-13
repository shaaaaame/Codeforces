using System;
using System.CodeDom.Compiler;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;

namespace Codeforces
{
	class BeautifulMatrix
	{
		static void Main(string[] args)
        {
			int[] xy = GetInput();
			int x = xy[0];
			int y = xy[1];

			int moves = Math.Abs(x - 2) + Math.Abs(y - 2);

			Console.WriteLine(moves);

        }

		static int[] GetInput()
        {
			int x = 0;
			int y = 0;

			for (int i = 0; i < 5; i++)
            {
				string[] enter = Console.ReadLine().Split();
				for (int a = 0; a < 5; a++)
				{
					if (enter[a] == "1")
					{
						x = a;
						y = i;
					}
				}
            }

			return new int[] { x, y };
        }
	}
}
