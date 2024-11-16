using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using calculatornamespace;


namespace ConsoleApp1
{
    internal class palindorome_2:Calculator
    {
        public static bool IsPalindorome(BigInteger number)
        {
            string num = number.ToString();
            for(int i = 0; i < num.Length/2 ; i++)
            {
                if (num[i] != num[num.Length - i - 1])
                {
                    return false;
                }
            }
            return true;

        }
    }
}
