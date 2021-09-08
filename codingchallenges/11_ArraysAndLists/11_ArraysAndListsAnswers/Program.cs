using System;
using System.Collections;
using System.Collections.Generic;

namespace _11_ArraysAndListsChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // 1. send array to method
            int[] intArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 11 };// avg 5.6
            double avg = AverageOfValues(intArray);
            System.Console.WriteLine($"The average of the int values in the array are {avg}");


            int[] happiness = { 2, 3, 4, 5, 6 };
            int[] result = SunIsShining(happiness);
            System.Console.WriteLine($"happiness array is =>  ");
            foreach (int y in happiness)
            {
                Console.Write($"{y} ");
            }
            System.Console.WriteLine();


            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(25);
            myArrayList.Add("Hello");
            myArrayList.Add(13.37);
            myArrayList.Add(13);
            myArrayList.Add(128);
            myArrayList.Add(25.3);
            myArrayList.Add(13);
            decimal avg1 = ArrayListAvg(myArrayList);
            System.Console.WriteLine($"The average of the int and double values in myArrayList is {avg1}.");


            List<int> myList1 = new List<int>() { 1, 7, 10, 5, 8, 2, 3, 6, 4 };
            int yourRank = ListAscendingOrder(myList1, 9);// 9 should come back as position 9
            System.Console.WriteLine($"{yourRank}");


            List<string> myList2 = new List<string>() { "Jill", "will", "try", "to", "chill", "...", "out", };
            string word = "...";
            bool found = FindStringInList(myList2, word);
            System.Console.WriteLine($"The word, {word} , was found = {found}");
            found = FindStringInList(myList2, "....");
            System.Console.WriteLine($"The word, {word} , was found = {found}");
        }//EoM

        /// <summary>
        /// This method takes an array of integers and returns a double, the average 
        /// value of all the integers in the array
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static double AverageOfValues(int[] array)
        {
            // throw new NotImplementedException("AverageOfValues has not been implemented yet.");
            double avg = 0;
            int sum = 0;
            int arrayLength = array.Length;

            foreach (int x in array)
            {
                sum += x;
            }
            avg = (double)sum / arrayLength;
            return avg;
        }

        /// <summary>
        /// This method increases each array element by 2 and 
        /// returns an array with the altered values.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int[] SunIsShining(int[] x)
        {
            // throw new NotImplementedException("SunIsShining has not been implemented yet.");

            for (int i = 0; i < x.Length; i++) x[i] += 2;
            return x;
        }

        /// <summary>
        /// This method takes an ArrayList containing types of double, int, and string 
        /// and returns the average of the ints and doubles only, as a decimal.
        /// It ignores the string values and rounds the result to 3 decimal places toward the nearest even number.
        /// </summary>
        /// <param name="myArrayList"></param>
        /// <returns></returns>
        public static decimal ArrayListAvg(ArrayList myArrayList)
        {
            // throw new NotImplementedException("ArrayListAvg has not been implemented yet.");

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
            return (decimal)Math.Round(sum / numNums, 3);
        }

        /// <summary>
        /// This method returns the rank (starting with 1st place) of a new 
        /// score entered into a list of randomly ordered scores.
        /// </summary>
        /// <param name="myArray1"></param>
        public static int ListAscendingOrder(List<int> scores, int yourScore)
        {
            // throw new NotImplementedException("ListAscendingOrder has not been implemented yet.");
            scores.Add(yourScore);
            scores.Sort();
            return scores.IndexOf(yourScore) + 1;
        }

        /// <summary>
        /// This method has with two parameters takes a List<string> and a string.
        /// The method returns true if the string parameter is found in the List, otherwise false.
        /// </summary>
        /// <param name="myArray2"></param>
        /// <param name="word"></param>
        /// <returns></returns>
        public static bool FindStringInList(List<string> myArray2, string word)
        {
            // throw new NotImplementedException("FindStringInList has not been implemented yet.");

            if (myArray2.Contains(word)) return true;
            else return false;
        }
    }//EoP
}// EoN