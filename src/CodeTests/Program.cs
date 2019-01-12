using CodeTests.Library;
using System;

namespace CodeTests
{
    class Program
    {
        static void Main(string[] args)
        {
            //FizzBuzz(100);
            //CheckPalindrome();
        }

        public static void CheckPalindrome()
        {
            Console.Write("Please enter a word: ");
            var word = Console.ReadLine();

            Console.WriteLine(Palindrome.IsPalindrome(word));
            Console.Read();
        }

        public static void FizzBuzz(int upto)
        {
            for (int i = 1; i <= upto; i++)
            {
                Console.WriteLine(FizzBuzzer.GetValue(i));
            }
            Console.ReadLine();
        }
    }
}
