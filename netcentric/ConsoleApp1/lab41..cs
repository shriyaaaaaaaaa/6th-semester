//multidimensional array

using System;

class Program
{
    static void Main(string[] args)
    {
        // Declare and initialize a 2D array
        int[,] numbers = new int[3, 3]
        {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        // Accessing elements of the 2D array
        Console.WriteLine("Element at [0, 0]: " + numbers[0, 0]); // Output: 1
        Console.WriteLine("Element at [1, 2]: " + numbers[1, 2]); // Output: 6

        // Printing all elements in the array using nested loops
        Console.WriteLine("All elements in the array:");
        for (int i = 0; i < numbers.GetLength(0); i++) // rows
        {
            for (int j = 0; j < numbers.GetLength(1); j++) // columns
            {
                Console.Write(numbers[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

