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

        switch (operation)
        {
            case '+':
                Console.WriteLine($"Result: {num1 + num2}");
                break;
            case '-':
                Console.WriteLine($"Result: {num1 - num2}");
                break;
            case '*':
                Console.WriteLine($"Result: {num1 * num2}");
                break;
            case '/':
                if (num2 != 0)
                {
                    Console.WriteLine($"Result: {num1 / num2}");
                }
                else
                {
                    Console.WriteLine("Division by zero is not allowed.");
                }
                break;
            default:
                Console.WriteLine("Invalid operator.");
                break;
        }
    }
}
*/