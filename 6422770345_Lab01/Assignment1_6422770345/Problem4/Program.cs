//Write a C# program to calculate the class average for a given number of students.
//The program should prompt the user to enter the number of students, and then
//take the scores of each student as input. Calculate and display the class average
//(create a method to calculate the class average). (1.5 points)

namespace prob4
{
    class Prob4
    {
        public static void avg(int[] arr)
        {
            Console.WriteLine("The class average is: " + arr.Average());
        }

        static void Main(string[] args)
        {
            Console.Write("Enter the number of students: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 1; i <= n; i++)
            {
                Console.Write("Enter the score for student " + i + " ");
                arr[i - 1] = Convert.ToInt32(Console.ReadLine());
            }
            avg(arr);
        }
    }
}

