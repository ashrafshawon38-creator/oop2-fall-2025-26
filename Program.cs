using System;

class Program
{
    static void Main()
    {
        string again = "y";

        do
        {
            Console.WriteLine("\nChoose operation:");
            Console.WriteLine("1) Add  2) Subtract  3) Multiply  4) Divide");
            Console.Write("Enter option (1-4): ");
            int op = int.Parse(Console.ReadLine());

            Console.Write("Enter first number: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            double b = double.Parse(Console.ReadLine());

            switch (op)
            {
                case 1: Console.WriteLine($"Result: {a + b}"); break;
                case 2: Console.WriteLine($"Result: {a - b}"); break;
                case 3: Console.WriteLine($"Result: {a * b}"); break;
                case 4:
                    if (b == 0)
                        Console.WriteLine("Cannot divide by zero!");
                    else
                        Console.WriteLine($"Result: {a / b}");
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }

            Console.Write("Do another? (y/n): ");
            again = Console.ReadLine().ToLower();
        }
        while (again == "y");
    }
}