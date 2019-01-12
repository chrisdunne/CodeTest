using NUnit.Framework;

namespace CodeTests.Library.Tests
{
    [TestFixture]
    public class PalindromeTests
    {
        [Test]
        public void Palindrome_WhenReverse_ReturnString()
        {
            string input = "Palindrome";
            string output = Palindrome.Reverse(input);
            Assert.IsInstanceOf(typeof(string), output);
        }

        [Test]
        public void Palindrome_WhenReverse_ReturnReverse()
        {
            string input = "Palindrome";
            string output = Palindrome.Reverse(input);
            Assert.AreEqual("emordnilaP", output);
        }

        [Test]
        public void Palindrome_WhenChecked_ReturnValid()
        {
            string input = "level";
            string output = Palindrome.IsPalindrome(input);
            Assert.AreEqual($"The word {input} is a Palindrome", output);
        }

        [Test]
        public void Palindrome_WhenChecked_ReturnInvalid()
        {
            string input = "Palindrome";
            string output = Palindrome.IsPalindrome(input);
            Assert.AreEqual($"The word {input} is not a Palindrome", output);
        }

        [Test]
        public void Palindrome_WhenDifCase_ReturnValid()
        {
            string input = "Level";
            string output = Palindrome.IsPalindrome(input);
            Assert.AreEqual($"The word {input} is a Palindrome", output);
        }
    }
}
