using System;

namespace Codeforces
{
	class StonesOnTheTable
	{

		static void Main(string[] args)
        {
			int n = Convert.ToInt32(Console.ReadLine());
			string stones = Console.ReadLine();

			int total = 0;
			int pointer = 0;

			while (pointer != stones.Length - 1)
			{
				if (stones[pointer] == stones[pointer + 1])
				{
					stones = stones.Remove(pointer + 1, 1);
					total += 1;
				}
				else pointer += 1;
			}

			Console.WriteLine(total);
        }


	}
}
