using System.Diagnostics.CodeAnalysis;

namespace Task3_9;
class Program
{
    //Q1
    static void PrintDollarNtimes(int n)
    {
        if (n > 0)
        {
            Console.Write($"$ ");
            PrintDollarNtimes(n - 1);
        }
    }

    //Q2
    static void PrintNtoN(int n)
    {
        if (n == 1)
        {
            Console.Write($"1");
        }
        else
        {
            Console.Write(n);
            PrintNtoN(n - 1);
            Console.Write(n);
        }
    }

    //Q3
    static void Print2Nto2N(int n)
    {
        Print2Nto2Nhelper(n * 2);
    }
    static void Print2Nto2Nhelper(int n)
    {
        if (n == 2)
        {
            Console.Write($"22");
        }
        else
        {
            Console.Write(n);
            Print2Nto2Nhelper(n - 2);
            Console.Write(n);
        }
    }

    //Q4
    static void PrintOneToNToOne(int n)
    {
        PrintOneToNToOne(n, 1);
    }
    static void PrintOneToNToOne(int n, int i)
    {
        if (i == n)
        {
            Console.Write($"{n}{n}");
        }
        else
        {
            Console.Write($"{i}");
            PrintOneToNToOne(n, i + 1);
            Console.Write($"{i}");
        }
    }

    //Q5
    static void PrintSums(int n)
    {
        if (n == 1)
        {
            Console.Write($"1 ");
        }
        else
        {
            PrintSums(n - 1);
            Console.Write($"{Sum(n)} ");
        }
    }

    static int Sum(int n)
    {
        if (n == 1)
        {
            return 1;
        }
        return Sum(n - 1) + n;
    }

    //Q6
    static void PrintSumsReverse(int n)
    {
        if (n == 1)
        {
            Console.Write($"1 ");
        }
        else
        {
            Console.Write($"{Sum(n)} ");
            PrintSums(n - 1);
        }
    }

    //Q7
    static void FactorialNtimes(int n)
    {
        if (n == 1)
        {
            Console.Write($"1 ");
        }
        else
        {
            FactorialNtimes(n - 1);
            Console.Write($"{Factorial(n)} ");
        }
    }
    static int Factorial(int n)
    {
        if (n == 1)
        {
            return 1;
        }
        return Factorial(n - 1) * n;
    }
    static void Main(string[] args)
    {
        PrintDollarNtimes(5);
        Console.WriteLine();
        PrintNtoN(5);
        Console.WriteLine();
        Print2Nto2N(4);
        Console.WriteLine();
        PrintOneToNToOne(4);
        Console.WriteLine();
        PrintSums(4);
        Console.WriteLine();
        PrintSumsReverse(4);
        Console.WriteLine();
        FactorialNtimes(5);
    }
}
