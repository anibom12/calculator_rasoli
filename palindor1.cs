using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using calculatornamespace;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Reflection.Metadata.Ecma335;


namespace palindornumber1
{
    internal class palindorome1: Calculator
    {
        public static bool IsPalindorome(BigInteger number)
        {
            
            BigInteger tempt = number;
            BigInteger reverse = 0;
            while(tempt>0)
            {
                reverse = reverse * 10 + tempt % 10;
                tempt /= 10;
            }

            return reverse == number;
            
           

        }

    }
}
