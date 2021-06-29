using System;
using System.Collections.Generic;

namespace Codeforces
{
	class BoyOrGirl
	{

		static void Main(string[] args)
		{
			string enter = Console.ReadLine();
			List<char> charList = new List<char>();
			int distinctTotal = 0;

			for (int i = 0; i < enter.Length; i++)
            {
				if (!charList.Contains(enter[i])){
					charList.Add(enter[i]);
					distinctTotal += 1;
                }
            }
            
			if(distinctTotal % 2 == 0)
            {
				Console.WriteLine("CHAT WITH HER!");
            }
            else
            {
				Console.WriteLine("IGNORE HIM!");
            }


		}
	}
}
