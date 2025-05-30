using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("kayak", true)]
        [InlineData("truck", false)]
        [InlineData("boat", false)]
        public void IsPalindrome(string word, bool expected)
        {
            var tester = new Palindrome();

            var actual = tester.IsAPalindrome(word);

            Assert.Equal(expected, actual);
        }
    }
    
    
    
    
     
}
