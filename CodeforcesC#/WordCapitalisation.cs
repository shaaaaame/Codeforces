using System;

namespace Codeforces
{
	class WordCapitalisation
	{
		static void Main(string[] args)
		{
			string enter = Console.ReadLine();
			string ans = "";
			ans += enter[0].ToString().ToUpper();
			ans += enter.Substring(1, enter.Length - 1);
			Console.WriteLine(ans);
		}
	}
}
