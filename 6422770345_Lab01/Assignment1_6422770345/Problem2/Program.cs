//Write a C# program that takes a positive integer as input and calculates the sum
//of all numbers from 1 to that integer. Do the exercise with a while loop first and
//then a for loop to implement the solution. (1 point)


using System;
using System.Runtime.InteropServices.Marshalling;

namespace prob2
{
    class Prob2
    {
        static void Main(string[] args)
        {
            int n;
            int ans = 0;
            while (true)
            {
                n = Convert.ToInt32(Console.ReadLine());
                if (n > 0)
                {
                    break;
                }

            }
            for (int i = 1; i <= n; i++)
            {
                ans = ans + i;
            }
            Console.WriteLine("The sum of numbers from 1 " + "to " + n + " is: " + ans);
        }
    }
}




