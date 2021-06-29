using System;
using System.Collections.Generic;
using System.Linq;

namespace Codeforces
{
	class HelpfulMaths
	{
		static void Main(string[] args)
        {
			string enter = Console.ReadLine();
			string[] enterArray = enter.Split("+");
			List<int> stringToIntArray = new List<int>();
			bool valid = true;
			int total = 0;

			for (int i = 0; i < enterArray.Length; i++)
			{
				stringToIntArray.Add(Convert.ToInt32(enterArray[i]));
			}

			int prevNum = stringToIntArray[0];

			foreach (int num in stringToIntArray)
			{
				if (num >= prevNum){
					total += num;
				}else
				{
					valid = false;
					stringToIntArray.Sort();
					break;
				}

				prevNum = num;
			}

			if (!valid)
			{
				string outputString = "";
				foreach (int i in stringToIntArray)
				{
					outputString += i.ToString();
					outputString += "+";
				}

				outputString = outputString.Remove(outputString.Length - 1);

				Console.WriteLine(outputString);
			}
			else
			{
				Console.WriteLine(total);
			}
		}		
	}
}
