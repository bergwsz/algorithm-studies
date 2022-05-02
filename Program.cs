using System;

namespace AlgorithmApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Choose the exercise: ");
            string exercise = Console.ReadLine();

            switch (exercise)
            {
                case "Hello world!":
                    Console.Clear();
                    Console.WriteLine($"Exercise {exercise} initiated.\n\n");
                    HelloWorld();
                    break;

                case "1":
                    Console.Clear();
                    Console.WriteLine($"Exercise {exercise} initiated.\n\n");
                    Exercise1();
                    break;

                case "2":
                    Console.Clear();
                    Console.WriteLine($"Exercise {exercise} initiated.\n\n");
                    Exercise2();
                    break;

                case "3":
                    Console.Clear();
                    Console.WriteLine($"Exercise {exercise} initiated.\n\n");
                    Exercise3();
                    break;

                case "4":
                    Console.Clear();
                    Console.WriteLine($"Exercise {exercise} initiated.\n\n");
                    Exercise4();
                    break;

                default:
                    Console.WriteLine("Exercise not found.");
                    Main(args);
                    break;
            }
        }

        static void HelloWorld()
        {
            Console.WriteLine("Hello world!");
        }
        static void Exercise1()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Sup {name}! It's a pleasure to meet ya.");
        }
        static void Exercise2()
        {
            Console.Write("Name of the employee: ");
            string name = Console.ReadLine();

            Console.Clear();

            Console.Write("Salary: ");
            double salary = double
                .Parse(Console.ReadLine());

            Console.WriteLine($"The employee {name} has a salary of ${salary}");
        }
        static void Exercise3()
        {
            Console.Write("Input a number: ");
            double num1 = double
                .Parse(Console.ReadLine());

            Console.Write("Input the second number: ");
            double num2 = double
                .Parse(Console.ReadLine());

            var sum = num1 + num2;
            Console.WriteLine($"Sum: {sum}");
        }
        static void Exercise4()
        {
            try
            {
                Console.WriteLine("First note: ");
                double num1 = double
                    .Parse(Console.ReadLine());

                if (num1 > 10 || num1 < 0)
                {
                    Console.Clear();
                    Console.WriteLine("Note out of the scope for validation (0-10)");
                    Exercise4();
                }

                Console.WriteLine("Second note: ");
                double num2 = double
                    .Parse(Console.ReadLine());

                if (num2 > 10 || num2 < 0)
                {
                    Console.Clear();
                    Console.WriteLine("Note out of the scope for validation (0-10)");
                    Exercise4();
                }


                double average = (num1 + num2) / 2;
                if (average > 10 || average < 0)
                {
                    Console.Clear();
                    Console.WriteLine("Note out of the scope for validation (0-10)");
                    Exercise4();
                }

                Console.WriteLine($"Average: {average.ToString()}");
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
