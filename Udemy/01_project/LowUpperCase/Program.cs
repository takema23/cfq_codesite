using System;
using System.Collections.Generic;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;

namespace RandomNumber
{
    public class numberAdded // Class for all numbers
    {
        public void add(List<int> numbers) // Method for addition
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            Console.WriteLine($"The sum of the numbers is: {sum}");
        }
        public void subtract(List<int> numbers) // Method for subtraction
        {
            if (numbers.Count == 0)
            {
                Console.WriteLine("No numbers provided for subtraction.");
                return;
            }
            int result = numbers[0];
            for (int i = 1; i < numbers.Count; i++)
            {
                result -= numbers[i];
            }
            Console.WriteLine($"The result of the subtraction is: {result}");
        }
        public void divide(List<int> numbers) // Method for division
        {
            if (numbers.Count == 0)
            {
                Console.WriteLine("No numbers provided for division.");
                return;
            }
            double result = numbers[0];
            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] == 0)
                {
                    Console.WriteLine("Division by zero is not allowed.");
                    return;
                }
                result /= numbers[i];
            }
            Console.WriteLine($"The result of the division is: {result}");
        }
        public void multiply(List<int> numbers) // Method for multiplication
        {
            if (numbers.Count == 0)
            {
                Console.WriteLine("No numbers provided for multiplication.");
                return;
            }
            int result = 1;
            foreach (int number in numbers)
            {
                result *= number;
            }
            Console.WriteLine($"The result of the multiplication is: {result}");
        }
    }

    class Program // Main class
    {
        static void Main(string[] args)
        {
            Console.WriteLine("================================================================");
            Console.WriteLine("Welcome to my first application!");
            Console.WriteLine("This application can calculate results for basic operations");
            Console.WriteLine("Please select the operation you want to execute or press Escape:");
            Console.WriteLine("================================================================");
            Console.WriteLine(
                "1. Multiply\n" +
                "2. Addition\n" +
                "3. Minus\n" +
                "4. Division\n" +
                "5. Exit\n"
            );
            Console.Write("Please enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    // Call the multiply method
                    break;
                case "2":
                    // Call the addition method
                    break;
                case "3":
                    // Call the minus method
                    break;
                case "4":
                    // Call the division method
                    break;
                case "5":
                    Console.WriteLine("Exiting the application...");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
            Console.WriteLine("================================================================");
            Console.WriteLine("Please enter the numbers you want to operate on (comma separated):");
            string input = Console.ReadLine();
            List<int> numbers = new List<int>();
            foreach (string num in input.Split(','))
            {
                if (int.TryParse(num.Trim(), out int result))
                {
                    numbers.Add(result);
                }
            }

            // Call the appropriate method based on the user's choice
            switch (choice)
            {
                case "1":
                    new numberAdded().multiply(numbers);
                    break;
                case "2":
                    new numberAdded().add(numbers);
                    break;
                case "3":
                    new numberAdded().subtract(numbers);
                    break;
                case "4":
                    new numberAdded().divide(numbers);
                    break;
                case "5":
                    Console.WriteLine("Exiting the application...");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
            Console.WriteLine("Thank you for using the application!");
        }
    }
}