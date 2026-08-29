//using System;
//using System.Numerics;

//public class A
//{
//    public static int Add(int a, int b)
//    {
//        return a + b;
//    }

//    public static int Subs(int a, int b)
//    {
//        return a - b;
//    }

//    public static int Mult(int a, int b)
//    {
//        return a * b;
//    }

//    public static int Div(int a, int b)
//    {
//        return a / b;
//    }

//    public static int Moduls(int a, int b)
//    {
//        return a % b;
//    }

//    public static void Main(string[] args)
//    {
//        Console.WriteLine("Enter A value");
//        int a = Convert.ToInt32(Console.ReadLine());

//        Console.WriteLine("Enter B value");
//        int b = Convert.ToInt32(Console.ReadLine());

//        Console.WriteLine("Choose an operation:");
//        Console.WriteLine("1 for ADD");
//        Console.WriteLine("2 for SUBTRACT");
//        Console.WriteLine("3 for MULTIPLY");
//        Console.WriteLine("4 for DIVISION");
//        Console.WriteLine("5 for MODULUS");

//        int choice = Convert.ToInt32(Console.ReadLine());

//        if (choice == 1)
//        {
//            Console.WriteLine("Addition = " + Add(a, b));
//        }
//        else if (choice == 2)
//        {
//            Console.WriteLine("Subtraction = " + Subs(a, b));
//        }
//        else if (choice == 3)
//        {
//            Console.WriteLine("Multiplication = " + Mult(a, b));
//        }
//        else if (choice == 4)
//        {
//            if (b != 0)
//                Console.WriteLine("Division = " + Div(a, b));
//            else
//                Console.WriteLine("Cannot divide by zero.");
//        }
//        else if (choice == 5)
//        {
//            Console.WriteLine("Modulus = " + Moduls(a, b));
//        }
//        else
//        {
//            Console.WriteLine("Invalid Choice");
//        }
//    }
//}

// write a program to accept number 1 to 200

class Practice
{
    static void Main()
    {

        int number;

        for (int i=1; i<=200;i++)
        {
            
            {
                Console.WriteLine("Enter number");
                number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("You're number is " + number);
                if (number % 2 == 0)
                {
                    Console.WriteLine("Even number");
                }
                else
                {
                    Console.WriteLine("Odd number");
                }
            }
        }

    }
}