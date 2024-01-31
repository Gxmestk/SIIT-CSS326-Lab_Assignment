//Write a C# program that does the following:
//(i) Takes an array of integers as input from the user.
//(ii) Calculates and prints the following:

//(a).The sum of all the elements in the array.
//(b). The maximum element in the array.
//(c). The minimum element in the array.
//(d). The average of all the elements in the array


using System;

namespace prob3
{
    class Prob3
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of elements in the array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter {0} integer elements: ",n);
            int[] arr = new int[n];
            for (int i = 1;i <= n; i++)
            {
                Console.Write("Element {0}: ", i);
                arr[i - 1] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Sum of elements: " + arr.Sum());
            Console.WriteLine("Maximum of elements: " + arr.Max());
            Console.WriteLine("Minimum of elements: " + arr.Min());
            Console.WriteLine("Average of elements: " + arr.Average());
        }
    }
}
