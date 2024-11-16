using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Numerics;

namespace calculatornamespace
{
     public  class Calculator
    {
       

        public static BigInteger GetNumber()
        {
            Console.WriteLine("Enter your number: ");
            BigInteger number = BigInteger.Parse(Console.ReadLine());

            return number;
        }
    }
}