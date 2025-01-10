using System;
using System.Collections.Generic;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> history = new List<string>();
            double num1, num2, result;
            string operation;

            while (true)
            {
                Console.WriteLine("Please enter first number:");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please enter second number:");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Choose the operation (+, -, *, /, %): ");
                operation = Console.ReadLine();

                switch (operation)
                {
                    case "+":
                        result = num1 + num2;
                        history.Add($"{num1} + {num2} = {result}");
                        break;
                    case "-":
                        result = num1 - num2;
                        history.Add($"{num1} - {num2} = {result}");
                        break;
                    case "*":
                        result = num1 * num2;
                        history.Add($"{num1} * {num2} = {result}");
                        break;
                    case "/":
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                            history.Add($"{num1} / {num2} = {result}");
                        }
                        else
                        {
                            Console.WriteLine("Error: Division by zero.");
                            continue;
                        }
                        break;
                    case "%":
                        result = num1 % num2;
                        history.Add($"{num1} % {num2} = {result}");
                        break;
                    default:
                        Console.WriteLine("Invalid operation.");
                        continue;
                }

                Console.WriteLine($"Result: {num1} {operation} {num2} = {result}");

                Console.WriteLine("1. Perform another calculation");
                Console.WriteLine("2. View history");
                Console.WriteLine("3. Exit");

                string choice = Console.ReadLine();

                if (choice == "1") continue;
                if (choice == "2")
                {
                    Console.WriteLine("\nHistory:");
                    foreach (var entry in history)
                    {
                        Console.WriteLine(entry);
                    }
                }
                if (choice == "3") break;
                else Console.WriteLine("Invalid choice. Exiting.");
            }
        }
    }
}
