/*using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double num2 = double.Parse(Console.ReadLine());

        Console.Write("Enter an arithmetic operator (+, -, *, /): ");
        char operation = char.Parse(Console.ReadLine());

        double result;

        if (operation == '+')
        {
            result = num1 + num2;
        }
        else if (operation == '-')
        {
            result = num1 - num2;
        }
        else if (operation == '*')
        {
            result = num1 * num2;
        }
        else if (operation == '/')
        {
            if (num2 != 0)
            {
                result = num1 / num2;
            }
            else
            {
                Console.WriteLine("Division by zero is not allowed.");
                return;
            }
        }
        else
        {
            Console.WriteLine("Invalid operator.");
            return;
        }

        Console.WriteLine($"The result is: {result}");
    }
}
*/