using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.IO;
using Xunit;
namespace _11_ArraysAndListsChallenge.Tests
{
    public class ProgramTest
    {
        public static readonly IEnumerable<object[]> _testArrays = new List<object[]>{
            new object[] {new int[]{ 1, 2, 3, 4, 5, 6, 7}},
            new object[] {new int[]{ 9, 8, 7, 6, 5, 4, 3, 2}},
            new object[] {new int[]{ 5, 1, 0, 2, 8, 9, 3}},
            new object[] {new int[]{ 0, 9, 2, 6, 5, 8, 2, 33}}
        };

        public static readonly IEnumerable<object[]> _twins = new List<object[]>{
            new object[] {new int[]{ 1, 2, 3, 4, 5, 6, 7}, new int[]{ 3, 4, 5, 6, 7, 8, 9}},
            new object[] {new int[]{ 9, 8, 7, 6, 5, 4, 3, 2}, new int[]{ 11, 10, 9, 8, 7, 6, 5, 4}},
            new object[] {new int[]{ 5, 1, 0, 2, 8, 9, 3}, new int[]{ 7, 3, 2, 4, 10, 11, 5}},
            new object[] {new int[]{ 0, 9, 2, 6, 5, 8, 2, 33}, new int[]{ 2, 11, 4, 8, 7, 10, 4, 35}}
        };

        public static readonly IEnumerable<object[]> _testArrayLists = new List<object[]>{
            new object[] {new ArrayList(){ 1, 2, 3, 4, 5, 6.0, 7}},
            new object[] {new ArrayList(){ 9.0, 8, 7, 6, 5.0, 4, 3, 2}},
            new object[] {new ArrayList(){ 5, 1.0, 0, 2.0, "hellos", 9, 3}},
            new object[] {new ArrayList(){ -1, 9, 2, 6, 5, 8.0, 2, "33"}}
        };
        public static readonly IEnumerable<object[]> _testList = new List<object[]>{
            new object[] {new List<int>(){ 1, 2, 3, 5, 6, 7}, 4},
            new object[] {new List<int>(){ 9, 8, 7, 6, 5, 3, 2, 1}, 4},
            new object[] {new List<int>(){ 5, 1, 0, 2, 8, 9}, 4},
            new object[] {new List<int>(){ 0, 9, 11, 6, 5, 8, 2, 3}, 4}
        };
        public static readonly IEnumerable<object[]> _testStringList = new List<object[]>{
            new object[] {new List<string>(){"Hi", "My", "Name", "is", "marielle"}, "Hi"},
            new object[] {new List<string>(){"Hello", "I", "am", "from", "Mars"}, "Hello"},
            new object[] {new List<string>(){"How", "are", "you"}, "you"},
            new object[] {new List<string>(){"Hi", "My", "Name", "is", "marielle"}, "mother"},
            new object[] {new List<string>(){"Hello", "I", "am", "from", "Mars"}, "father"},
            new object[] {new List<string>(){"How", "are", "you"}, "hello"}
        };

        [Theory]
        [MemberData(nameof(_testArrays))]
        public void AverageOfValuesShouldReturnAverage(int[] input)
        {
            Assert.Equal(input.Average(), Program.AverageOfValues(input), 0);
        }

        [Theory]
        [MemberData(nameof(_twins))]
        public void SunIsShiningShouldAlterArray(int[] input, int[] copy)
        {
            Assert.Equal(copy, Program.SunIsShining(input));
        }

        [Theory]
        [MemberData(nameof(_testArrayLists))]
        public void ArrayListAvgReturnsAvg(ArrayList myArrayList)
        {
            double sum = 0;
            int numNums = 0;
            foreach (object obj in myArrayList)
            {
                if (obj is int)
                {
                    sum += Convert.ToDouble(obj);
                    numNums++;
                }
                else if (obj is double)
                {
                    sum += (double)obj;
                    numNums++;
                }
            }
            Assert.Equal((decimal)Math.Round(sum / numNums, 3), Program.ArrayListAvg(myArrayList));
        }

        [Theory]
        [MemberData(nameof(_testList))]
        public void ListAscendingOrderShouldOrder(List<int> input, int initial)
        {
            int result = Program.ListAscendingOrder(input, initial);
            Assert.Equal(result, initial);
        }

        [Theory]
        [MemberData(nameof(_testStringList))]
        public void FindShouldFind(List<string> input, string word)
        {
            Assert.Equal(input.Contains(word), Program.FindStringInList(input, word));
        }
    }
}
