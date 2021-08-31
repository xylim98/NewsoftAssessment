using System;
using System.Collections.Generic;
using System.Linq;

namespace NewsoftAssessment
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Question 1
             */
            Console.WriteLine("Question 1");
            Console.WriteLine(ValidateEmail("e@edabit.com"));
            Console.WriteLine(ValidateEmail("@edabit.com"));
            Console.WriteLine(ValidateEmail("hello.email@com"));
            Console.WriteLine(ValidateEmail("john.smith@email.com"));
            Console.WriteLine(ValidateEmail("@gmail.com"));
            Console.WriteLine(ValidateEmail("hello.gmail@com"));
            Console.WriteLine(ValidateEmail("gmail"));
            Console.WriteLine(ValidateEmail("hello@gmail"));
            Console.WriteLine(ValidateEmail("hello@edabit.com"));
            Console.WriteLine("");

            /*
             * Question 2
             */
            Console.WriteLine("Question 2");
            Console.WriteLine(SockPairs("AA"));
            Console.WriteLine(SockPairs("ABABC"));
            Console.WriteLine(SockPairs("CABBACCC"));
            Console.WriteLine(SockPairs(""));
            Console.WriteLine(SockPairs("CABABABBACCCCDD"));
            Console.WriteLine("");

            /*
             * Question 3
             */
            Console.WriteLine("Question 3");
            Console.WriteLine(Maskify("4556364607935616"));
            Console.WriteLine(Maskify("64607935616"));
            Console.WriteLine(Maskify("1"));
            Console.WriteLine(Maskify(""));
            Console.WriteLine("");

            /*
            * Question 4
            */
            Console.WriteLine("Question 4");
            Console.WriteLine(RollingCipher("abcd", 1));
            Console.WriteLine(RollingCipher("abcd", -1));
            Console.WriteLine(RollingCipher("abcd", 3));
            Console.WriteLine(RollingCipher("abcd", 26));
        }

        static bool ValidateEmail(string emailStr)
        {
            int atIndex = emailStr.IndexOf('@');

            return atIndex > 0 ? (emailStr.Substring(0, atIndex).Length > 0 ? (emailStr.Substring(atIndex).Contains('.') ? true : false) : false) : false;
        }

        static int SockPairs(string socks)
        {
            List<char> tempArr = new List<char>();
            int pairCount = 0;

            foreach (char c in socks)
            {
                if (tempArr.Contains(c))
                {
                    tempArr.Remove(c);
                    pairCount++;
                }
                else
                {
                    tempArr.Add(c);
                }
            }
            return pairCount;
        }

        static string Maskify(string inputStr)
        {
            return inputStr.Length <= 4 ? inputStr : new String(inputStr.Substring(0, inputStr.Length - 4).Select(r=>'#').ToArray()) + inputStr.Substring(inputStr.Length - 4);
        }

        static string RollingCipher(string inputStr, int roll)
        {
            string cipherStr = "";
            int cipherInt;
            foreach(char c in inputStr)
            {
                cipherInt = c + mod(roll, 26);
                cipherStr += (char)(cipherInt > 122 ? cipherInt - 26: cipherInt);
            }

            return cipherStr;
        }

        static int mod(int k, int n)
        {
            return ((k %= n) < 0) ? k + n : k;
        }
    }
}
