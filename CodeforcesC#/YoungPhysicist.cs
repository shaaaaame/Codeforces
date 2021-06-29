using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Security.Cryptography.X509Certificates;

namespace Codeforces
{
	class YoungPhysicist
	{

		static void Main(string[] args)
		{
			string[] vectors = GetInput();
			int x = 0;
			int y = 0;
			int z = 0;

			foreach(string v in vectors)
			{
				string[] vector = v.Split();
				x += Convert.ToInt32(vector[0]);
				y += Convert.ToInt32(vector[1]);
				z += Convert.ToInt32(vector[2]);
			}

			if (x == 0 && y == 0 && z == 0)
			{
				Console.WriteLine("YES");
			}
			else
			{
				Console.WriteLine("NO");
			}

		}

		static string[] GetInput()
        {
			int n = Convert.ToInt32(Console.ReadLine());
			string[] returnArray = new string[n];

			for (int i = 0; i< n; i++)
            {
				returnArray[i] = Console.ReadLine();
            }

			return returnArray;
			
        }
	}
}
