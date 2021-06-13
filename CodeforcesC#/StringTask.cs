using System;

namespace Codeforces
{
    class StringTask
    {
        static void Main(string[] args)
        {
            string enter = Console.ReadLine();
            enter = enter.ToLower();
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'y' };

            string ans = "";

            //remove vowels
            for (int i = 0; i < enter.Length; i++)
            {
                bool hasVowel = false;

                for (int x = 0; x < 6; x++)
                {
                    if (enter[i] == vowels[x])
                    {
                        hasVowel = true;
                    }
                }

                if (hasVowel == false)
                {
                    ans += ".";
                    ans += enter[i];
                }
            }

            Console.WriteLine(ans);

        }
    }
}
