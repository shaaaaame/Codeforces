using System;
using System.Collections.Generic;
using System.Linq;

namespace Codeforces
{
    class GivenLengthAndSum
    {
        static void Main(string[] args)
        {
            int[] ms = GetInput();

        }

        static int[] GetInput()
        {
            string enter = Console.ReadLine();
            string[] splitEnter = enter.Split(" ");

            int[] returnValue = new int[2];
            returnValue[0] = Convert.ToInt32(splitEnter[0]);
            returnValue[1] = Convert.ToInt32(splitEnter[1]);

            return returnValue;
        }

        bool can(int m, int s)
        {
            return (s >= 0 && s <= 9 * m);
        }
    }
}
