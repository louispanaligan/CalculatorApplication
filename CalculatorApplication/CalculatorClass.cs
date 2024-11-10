using System;

public delegate T Information<T>(T arg1, T arg2);

public class CalculatorClass
{
    public Information<double> info;

    public event Information<double> CalculateEvent
    {
        add
        {
            info += value;
            Console.WriteLine("Added the Delegate");
        }
        remove
        {
            info -= value;
            Console.WriteLine("Removed the Delegate");
        }
    }

    public double GetSum(double num1, double num2)
    {
        return num1 + num2;
    }

    public double GetDifference(double num1, double num2)
    {
        return num1 - num2;
    }

    public double GetProduct(double num1, double num2)
    {
        return num1 * num2;
    }

    public double GetQuotient(double num1, double num2)
    {
        return num1 / num2;
    }
}