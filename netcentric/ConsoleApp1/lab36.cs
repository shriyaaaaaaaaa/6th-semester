/*using System;

class Program
{
    static void Main()
    {
        double[] marks = new double[5];
        double total = 0, percentage;

        Console.WriteLine("Enter marks for 5 subjects:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Subject {i + 1}: ");
            marks[i] = double.Parse(Console.ReadLine());
            total += marks[i];
        }

        percentage = total / 5;

        Console.WriteLine($"Percentage: {percentage:F2}%");

        if (percentage >= 80)
        {
            Console.WriteLine("Division: Distinction");
        }
        else if (percentage >= 60)
        {
            Console.WriteLine("Division: First Division");
        }
        else if (percentage >= 50)
        {
            Console.WriteLine("Division: Second Division");
        }
        else if (percentage >= 40)
        {
            Console.WriteLine("Division: Third Division");
        }
        else
        {
            Console.WriteLine("Division: Fail");
        }
    }
}
*/