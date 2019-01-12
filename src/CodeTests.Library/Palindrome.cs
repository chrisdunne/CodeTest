using System;

namespace CodeTests.Library
{
    public class Palindrome
    {
        public static string Reverse(string input)
        {
            var charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static string IsPalindrome(string input)
        {
            var reverse = Reverse(input);

            if (reverse.ToLower() == input.ToLower())
                return $"The word {input} is a Palindrome";
            else
                return $"The word {input} is not a Palindrome";
        }
    }
}
