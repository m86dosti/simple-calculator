using System;

class SimpleCalculator
{
    static void Main()
    {
        Console.WriteLine("Enter first number:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter an operator (+, -, *, /):");
        char operation = Console.ReadLine()[0];

        double result;

        switch (operation)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                result = num1 / num2;
                break;
            default:
                Console.WriteLine("Invalid operator.");
                return;
        }
        Console.WriteLine("The result is: {result}");
    }
}
