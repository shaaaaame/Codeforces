using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;

namespace Codeforces
{
	class Football
	{

		static void Main(string[] args)
		{
			string enter = Console.ReadLine();
			int count = 1;
			bool danger = false;

			for(int i = 0; i < enter.Length - 1; i++)
			{
				if (enter[i] == enter[i + 1])
				{
					count += 1;
				}
				else
				{
					count = 1;
				}

				if(count == 7)
				{
					danger = true;
					break;
				} 

			}


			if (danger)
			{
				Console.WriteLine("YES");
			}
			else
			{
				Console.WriteLine("NO");
			}

			
		}
	}
}
