using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the first number:");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter operator (+, -, *, /): ");
        char operation = Convert.ToChar(Console.ReadLine());

        int result;
        switch (operation)
        {
            case '+':
                result = num1 + num2;
                Console.WriteLine($"Result: {result}");
                break;
            case '-':
                result = num1 - num2;
                Console.WriteLine($"Result: {result}");
                break;
            case '*':
                result = num1 * num2;
                Console.WriteLine($"Result: {result}");
                break;
            case '/':
                if (num2 != 0)
                {
                    double divResult = (double)num1 / num2;
                    Console.WriteLine($"Result: {divResult}");
                }
                else
                {
                    Console.WriteLine("Error: division by zero!");
                }
                break;
            default:
                Console.WriteLine("Error: Invalid operator!");
                break;
        }
    }
}