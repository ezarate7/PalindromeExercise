using System;
using Xunit;
using System.Collections.Generic;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar",true)]
        [InlineData("hello",false)]
        [InlineData("Racecar",false)]
        public void Test1(string word, bool expected)
        {
            var test = new WordSmith();
            var actual = test.IsAPalindrome(word);
            Assert.Equal(expected, actual);
            
                
            

        }
    }
}
