using System;
using calculatornamespace;
using prime;
using Prime;
using palindornumber1;
using ConsoleApp1;
using DecisionTreeNamespace;
using System.Numerics;

namespace center
{
    public  static class Center
    {
        public static void Start()
        {
            
            Console.WriteLine("Choose the method to use:");
            Console.WriteLine("1. Simple Prime Check");
            Console.WriteLine("2. Pro Prime Check");
            Console.WriteLine("3. Palindrome Check 1");
            Console.WriteLine("4. Palindrome Check 2");
            Console.WriteLine("5. Decision Tree");

            char choice = Console.ReadKey(true).KeyChar;
            
            


            Console.Clear();





            switch (choice)
            {
                case '1':
                case '2':
                case '3':
                case '4':
                    
                    Console.WriteLine("Enter a number: ");
                    BigInteger number = BigInteger.Parse(Console.ReadLine());
                  
                    Console.Clear();

                    switch (choice)
                    {
                        case '1':

                                Console.WriteLine(number < 1000?$"Is the number {number} prime? {Simpleprime.IsPrime(number)}": "Number is  large for Simple Prime Check.pealse check it with Pro Prime Check.");
                
                            break;
                        case '2':
                            Console.WriteLine(number >= 1000 ? $"Is the number {number} prime? {new Proprime().IsPrime(number)}" : " Number is small.please check it with Simple Prime Check ");
                            
                            break;
                        case '3':
                            Console.WriteLine($"Is the number {number} a palindrome? {palindorome1.IsPalindorome(number)}");
                            break;
                        case '4':
                            Console.WriteLine($"Is the number {number} a palindrome? {palindorome_2.IsPalindorome(number)}");
                            break;
                    }
                    break;
                case '5':
                    DecisionTree.Decision();
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}
