using System;

namespace PlayingWithBoxingConsole
{
  public struct Point
  {
    public int x;
    public int y;
    public Point(int x, int y)
    {
      this.x = x;
      this.y = y;
    }
  }
  class Program
  {
    static void Main(string[] args)
    {
      SimpleBoxingAndUnboxingDemo();
      BoxingAndUnboxingWithCastingDemo();
      ProvingReferenceTypingWhenBoxingDemo();
      PlayingWithBoxingInterface();
    }


    public static void SimpleBoxingAndUnboxingDemo()
    {
      Console.WriteLine("This is a simple boxing and unboxing demo.\n");
      //Declaring a variable of type double
      double someDouble = 2.12345;
      Console.WriteLine("double someDouble = 2.12345;\n");

      Console.WriteLine("Boxing the variable as type 'object'.");
      //Boxing
      object someObject = someDouble;
      Console.WriteLine("object someObject = someDouble;");
      Console.Read();

      Console.WriteLine("Unboxing the value.");
      //Unboxing
      double unboxedDouble = (double)someObject;
      Console.WriteLine("double unboxedDouble = (double)someObject;");
      Console.Read();

      Console.WriteLine("The value of someDouble = " + someDouble);
      Console.WriteLine("The value of unboxedDouble = " + unboxedDouble);
      Console.WriteLine("Press Enter to move on.");
      Console.Read();
    }

    public static void BoxingAndUnboxingWithCastingDemo()
    {
      Console.WriteLine("This is showing the incorrect and correct way to unbox and implement casting.\n");
      //Declare a variable of type double
      double someDouble = 23.12345;
      //We can cast someDouble into an int
      int someInt = (int)someDouble;
      Console.WriteLine("double someDouble = 23.12345;\nint someInt = (int)someDouble;");
      Console.WriteLine($"someDouble = {someDouble}. someInt = {someInt}.");
      Console.WriteLine("We already know this casting works.");
      Console.Read();
      Console.WriteLine("What if we wanted to cast a boxed double to an int?");
      Console.Read();
      Console.WriteLine("object someObject = someDouble;");
      object someObject = someDouble;
      Console.WriteLine("int someInt1 = (int)someObject;");
      Console.WriteLine("Will this work?");
      Console.Read();
      Console.WriteLine("Runtime exception!");
      Console.WriteLine("Unhandled exception. System.InvalidCastException: Unable to cast object of type 'System.Double' to type 'System.Int32'.");
      Console.WriteLine("It will NOT work! We must first unbox the object to a double before casting to an int.\n");
      Console.WriteLine("Correct Declaration: \nint someInt1 = (int)(double)someObject;");
      int someInt1 = (int)(double)someObject;
      Console.WriteLine($"someDouble = {someDouble}. someInt1 = {someInt1}");
      Console.WriteLine("Press Enter to move on.");
      Console.Read();
    }

    public static void ProvingReferenceTypingWhenBoxingDemo()
    {
      Console.WriteLine("This is showing that boxed values have reference typing.\n");
      int someNumber = 10;
      object o1 = someNumber;
      object o2 = someNumber;
      Console.WriteLine("int someNumber = 10;\nobject o1 = someNumber;\nobject o2 = someNumber;\n");
      Console.WriteLine("What will be the value of (o1 == o2)?");
      Console.Read();
      Console.WriteLine("(o1 == o2) = " + (o1 == o2));
      Console.WriteLine("Press Enter to move on.");
      Console.Read();
    }


    public static void PlayingWithBoxingInterface()
    {

      Console.WriteLine("Boxing and Unboxing using a struct.");
      Console.WriteLine("\nstruct Point{\n\tpublic int x;\n\tpublic int y;\n\tpublic Point(int x, int y){\n\t\tthis.x = x;\n\t\tthis.y = y;\n\t}\n}");
      Console.WriteLine("\nPoint p = new Point(10,10);\nobject o = p;\np.x = 20;");
      Point p = new Point(10, 10);
      object o = p;
      p.x = 20;
      Console.WriteLine("What will the value of x be after unboxing o?");
      Console.Read();
      int someInt = ((Point)o).x;
      Console.WriteLine($"p.x = {p.x}\n((Point)o).x = {someInt}");
      Console.WriteLine("Press Enter to move on.");
      Console.Read();


    }



  }
}
