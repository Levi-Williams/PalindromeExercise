using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("car", false)]
        [InlineData("girafarig", true)]
        [InlineData("mom", true)]
        [InlineData("memory", false)]

        public void Test1(string word, bool expected)
        {
            var test = new WordSmith();

            var actual = test.IsAPalindrome(word);

            Assert.Equal(expected, actual);    
        }
    }
}
