using System;

namespace _4_MethodsChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //1
            string name = GetName();
            GreetFriend(name);

            //2
            double result1 = GetNumber();
            double result2 = GetNumber();
            int action1 = GetAction();
            double result3 = DoAction(result1, result2, action1);

            System.Console.WriteLine($"The result of your mathematical operation is {result3}.");


        }

        public static string GetName()
        {
            //System.Console.WriteLine("Please enter your name.");
            string input = Console.ReadLine();
            return input;
        }

        public static string GreetFriend(string name)
        {
            return $"Hello, {name}. You are my friend.";
        }

        public static double GetNumber()
        {
            System.Console.WriteLine("Please enter a number. It can also be a decimal or a negative.");
            string userInput = Console.ReadLine();
            double number;
            bool unSuccessful = double.TryParse(userInput, out number);
            if (!unSuccessful)
            {
                throw new FormatException($"The user input, {userInput}, is invalid.");
            }
            return number;
        }

        public static int GetAction()
        {
            bool unsuccessful;
            int num1;
            do
            {
                System.Console.WriteLine("Please enter the number of the action you want to take on the numbers");
                System.Console.WriteLine("\n\t1 for add.\n\t2 for subtract.\n\t3 for multiply.\n\t4 for divide.\n");
                string input = Console.ReadLine();
                unsuccessful = int.TryParse(input, out num1);
            } while (!unsuccessful || num1 < 1 || num1 > 4);

            return num1;
        }

        public static double DoAction(double x, double y, int action)
        {
            switch (action)
            {
                case 1:
                    return x + y;
                case 2:
                    return Math.Max(x, y) - Math.Min(x, y);
                case 3:
                    return x * y;
                case 4:
                    return Math.Max(x, y) / Math.Min(x, y);
                default:
                    throw new FormatException("Something went wrong in DoAction()");
            }
        }
    }
}
