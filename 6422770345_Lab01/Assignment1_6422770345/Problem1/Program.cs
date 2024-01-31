// 1. Write a C# program that takes two numbers (integers) as input and calculates
// their sum, difference, product, and quotient (division result). Print the results to
// the console.(1 point)


using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sum: " + (A+B));
            Console.WriteLine("Difference: " + (A-B));
            Console.WriteLine("Product: " + (A*B));
            Console.WriteLine("Quotient: " + (A/B));


        }
    }
}
