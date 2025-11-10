using System;
using System.Globalization;

class MortgageCalculatorV1
{
    static void Main()
    {
        Console.WriteLine("=== Mortgage Calculator V1 (Bangladesh) ===");

        Console.Write("Enter loan amount: ");
        double principal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter annual interest rate (in %): ");
        double annualRate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter loan period (in years): ");
        int years = Convert.ToInt32(Console.ReadLine());

        double monthlyRate = annualRate / 100 / 12;
        int months = years * 12;

        double monthlyPayment = (principal * monthlyRate * Math.Pow(1 + monthlyRate, months))
                               / (Math.Pow(1 + monthlyRate, months) - 1);

        double totalPaid = monthlyPayment * months;
        double totalInterest = totalPaid - principal;

        // Bangladeshi Taka currency format
        CultureInfo bdCulture = new CultureInfo("bn-BD");

        Console.WriteLine("\n===== Payment Details =====");
        Console.WriteLine($"Monthly Payment: {monthlyPayment.ToString("C", bdCulture)}");
        Console.WriteLine($"Total Paid: {totalPaid.ToString("C", bdCulture)}");
        Console.WriteLine($"Total Interest: {totalInterest.ToString("C", bdCulture)}");

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
