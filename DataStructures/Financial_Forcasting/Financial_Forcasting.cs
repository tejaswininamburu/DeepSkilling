using System;

class Program
{
    // Recursive method to calculate future value
    static double Forecast(double currentValue, double growthRate, int years)
    {
        // Base case
        if (years == 0)
        {
            return currentValue;
        }

        // Recursive call
        return Forecast(currentValue * (1 + growthRate), growthRate, years - 1);
    }

    static void Main()
    {
        // Read input from user
        Console.Write("Enter Current Value: ");
        double currentValue = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Growth Rate (%): ");
        double growthRate = Convert.ToDouble(Console.ReadLine()) / 100;

        Console.Write("Enter Number of Years: ");
        int years = Convert.ToInt32(Console.ReadLine());

        // Calculate future value
        double futureValue = Forecast(currentValue, growthRate, years);

        // Display output
        Console.WriteLine("\n----- Financial Forecast -----");
        Console.WriteLine("Current Value : " + currentValue);
        Console.WriteLine("Growth Rate   : " + (growthRate * 100) + "%");
        Console.WriteLine("Years         : " + years);
        Console.WriteLine("Future Value  : " + futureValue);

        // Analysis
        Console.WriteLine("\nAnalysis:");
        Console.WriteLine("Time Complexity  : O(n)");
        Console.WriteLine("Space Complexity : O(n)");
        
    }
}