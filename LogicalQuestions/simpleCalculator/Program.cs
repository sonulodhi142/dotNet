using System;


    class Program
    {
        static void Main(string[] args)
        {
            double result = 0;
            

            Console.WriteLine("Simple Calculator in C#");
            Console.WriteLine("----------------------");

            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter an operator (+, -, *, /): ");
            string ch = Console.ReadLine();
            char operation = ch[0];

            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

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
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Error: Cannot divide by zero.");
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operation.");
                    return;
            }

            Console.WriteLine($"Result: {num1} {operation} {num2} = {result}");

            Console.ReadKey(); // Keeps the console window open until a key is pressed
        }
    }
