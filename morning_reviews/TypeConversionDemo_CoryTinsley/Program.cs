using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversionDemo
{
    class Casting
    {
        public static bool DemoRunning { get; set; }
        List<string> datatypes = new List<string>() {
            "char",
            "int",
            "long",
            "float",
            "double"
        };
        /// <summary>
        /// View XML comment for Switch Methods to see demo controls 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Casting c = new Casting();
            c.Run();
        }

        /// <summary>
        /// Call run to start demo
        /// </summary>
        public void Run()
        {
            DemoStart();
        }

        private static void DemoStart()
        {
            DemoRunning = true;


            Console.WriteLine("What is type conversion?");
            Console.ReadLine();

            Console.WriteLine("Changing the datatype of your variable");
            Console.ReadLine();
            Console.WriteLine("Two Types of Casting:");
            Console.ReadLine();


            while (DemoRunning)
            {
                SwitchMethods(Console.ReadLine());

                //Implicit();
                //string input = Console.ReadLine();
                //if (input == "1")
                //    break;


                //Explicit();
                // string input2 = Console.ReadLine();
                //if (input2 == "1")
                //    break;


                //ConversionMethod();
                //string input3 = Console.ReadLine();
                //if (input3 == "1")
                //    break;


                //ClassConversion();
                //string input4 = Console.ReadLine();
                //if (input4 == "1")
                //    break;

            }
        }
        /// <summary>
        /// Press 1 for implicit, 2 for explicit, 3 for conversion methods, and 4 for class conversion. (Press 9 to exit Conversion Methods when you hit the loop)
        /// </summary>
        /// <param name="i"></param>
        private static void SwitchMethods(string i)
        {
            switch (i)
            {
                case "1":

                    Implicit();
                    break;
                case "2":

                    Explicit();
                    break;
                case "3":

                    ConversionMethod();
                    break;
                case "4":

                    ClassConversion();
                    break;
                case "0":
                    DemoRunning = false;
                    break;

            }
        }

        private static void Implicit()
        {
            Console.WriteLine("Implicit Casting \n=========================");

            long myLong = 10;
            double myDouble = myLong;

            Console.WriteLine($"My Double = {myDouble}\n\n\n\n");
        }

        private static void Explicit()
        {
            Console.WriteLine("Explicit Casting \n=========================");

            //float myFloat = 10;
            //int myint = myFloat; 

            float myFloat = 10.2f;
            int myInt = (int)myFloat;

            Console.WriteLine($"My myInt = {myInt}\n\n\n\n");
        }


        private static void ConversionMethod()
        {
            Random rand = new Random();
            Console.WriteLine("Conversion Methods \n=========================");

            bool myBool = true;
            int falseInt = 0;
            int trueInt = 1;

            Console.WriteLine($"The value of myBool = {myBool}");
            Console.WriteLine($"If I convert myBool to a double, I get the value {Convert.ToDouble(myBool)}");
            Console.WriteLine($"If I convert an int with the value 0 to a bool, I get {Convert.ToBoolean(falseInt)}");
            Console.WriteLine($"If I convert an int with the value 1 to a bool, I get {Convert.ToBoolean(trueInt)}");

            bool go = false;
            while (!go)
            {
                decimal result = Math.Round(Convert.ToDecimal(rand.Next(10, 30)) / 5) * 5;
                string input = Console.ReadLine();
                Console.WriteLine(result);
                if (input == "9")
                    go = true;
            }

            Console.WriteLine($"\n\n\n\n");
        }

        private static void ClassConversion()
        {
            Console.WriteLine("Class Conversion \n=========================");
            Console.WriteLine("When converting reference types, the conversion is implicit between derived classes");
            Animal a = new Animal();
            Animal d = new Dog();
            Animal p = new Poodle();
            Dog p1 = new Poodle();
            Dog d2 = (Dog)d;


            //Console.WriteLine("Animal a = new Animal(); \nAnimal d = new Dog(); \nAnimal p = new Poodle(); \nDog p1 = new Poodle(); \nDog a1 = (Dog)a;");
            Console.WriteLine($"\n\n\n\n");
        }

    }//End of Casting Class


    class Animal
    {

    }//End of Animal Class

    class Dog : Animal
    {

    }//End of Dog Class

    class Poodle : Dog
    {

    }//End of Poodle Class


}//End of Namespace
