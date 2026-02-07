using System;

namespace ComputeAverageApp
{
    class ComputeAverageProgram
    {
        static void Main(string[] args)
        {
            // Ask the user to enter five grades
            Console.WriteLine("Enter 5 grades separated by new line:");
            double[] grades = new double[5];
            for (int i = 0; i < 5; i++)
            {
                grades[i] = double.Parse(Console.ReadLine());
            }

            // Compute the average of the grades
            double sum = 0;
            foreach (double grade in grades)
            {
                sum += grade;
            }
            double average = sum / grades.Length;

            // Round off the average using Math class
            double roundedAverage = Math.Round(average);

            // Output the result
            Console.WriteLine($"The average is {average} and round off to {roundedAverage}");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}



