using System;

namespace Codeforces
{
	class BitPlusPlus
	{
		static void Main(string[] args)
        {
			string[] commandArray = GetInput();

			int x = 0;

			for (int i = 0; i < commandArray.Length; i++)
			{
				char command = AddOrMinus(commandArray[i]);

				if (command == '+')
				{
					x += 1;
				} else if (command == '-')
				{
					x -= 1;
				}

			}

			Console.WriteLine(x);
        }

		static string[] GetInput()
        {
			int n = Convert.ToInt32(Console.ReadLine());
			string[] returnArray = new string[n];

			for (int i = 0; i < n; i++)
            {
				returnArray[i] = Console.ReadLine();
            }

			return returnArray;
        }

		static char AddOrMinus(string command)
		{
			for (int i = 0; i < 3; i++)
			{
				if (command[i] == '+')
				{
					return '+';
				} else if (command[i] == '-')
				{
					return '-';
				}
			}

			return '0';
		}
	}
}
