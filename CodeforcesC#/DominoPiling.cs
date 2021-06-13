using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Codeforces
{
    
    class DominoPiling
    {
        static void Main(string[] args)
        {
            int[] mn = GetInput();
            int m = mn[0];
            int n = mn[1];

            Console.WriteLine(Convert.ToInt32(m * n / 2));


        }

        static int[] GetInput()
        {
            string[] enter = Console.ReadLine().Split(" ");
            int[] o = new int[2];

            o[0] = Convert.ToInt32(enter[0]);
            o[1] = Convert.ToInt32(enter[1]);

            return o;
        }
    }
}
