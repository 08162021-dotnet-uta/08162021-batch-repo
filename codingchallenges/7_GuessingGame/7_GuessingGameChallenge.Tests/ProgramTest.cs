using System;
using Xunit;
using _7_GuessingGameChallenge;
namespace _7_GuessingGameChallenge.Tests
{
    public class ProgramTest
    {
        [Fact]
        public void GetRandomNumberShouldReturnInRangeNumber()
        {
            for (int x = 0; x < 1000; x++)
            {
                Assert.True(Program.GetRandomNumber() > -1);
                Assert.True(Program.GetRandomNumber() < 101);
            }
        }

        [Fact]
        public void CompareNumsShouldReturnNeg1()
        {
            Assert.Equal(1, Program.CompareNums(2, 1));
        }

        [Fact]
        public void CompareNumsShouldReturn0()
        {
            Assert.Equal(0, Program.CompareNums(1, 1));
        }

        [Fact]
        public void CompareNumsShouldReturn1()
        {
            Assert.Equal(-1, Program.CompareNums(1, 2));
        }

        // [Fact]
        // public void GetUsersGuessShouldReturnValidInt()
        // {

        // }
    }
}
