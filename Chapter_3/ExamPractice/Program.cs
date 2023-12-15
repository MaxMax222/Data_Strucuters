using System;
using System.Globalization;
namespace ExamPractice;
class Program
{
    static int Smallest(int n)
    {
        n = Math.Abs(n);
        if (n < 10)
            return n;
        return Math.Min(n / 10, Smallest(n / 10));
    }
    static bool AscendingOrder(int n)
    {
        if (n < 10)
        {
            return true;
        }
        if (n % 10 <= n / 10 % 10)
        {
            return false;
        }
        return AscendingOrder(n);
    }
    static int Fib(int num)
    {
        if (num == 1)
        {
            return 0;
        }
        if (num == 2)
        {
            return 1;
        }
        return Fib(num - 1) + Fib(num - 2);
    }
    static bool What2(int num1, int num2)
    {
        if (num2 == 0)
            return true;
        if (num1 == num2)
            return true;
        else if (num1 < num2)
            return false;
        else
            return What2(num1 - num2, num2);
    }
    static void Main(string[] args)
    {
        // System.Console.WriteLine(Smallest(5248));
        // Console.WriteLine($"Fibonaci 4 ={Fib(4)}");
        Console.WriteLine($"{What2(80, 3)}");


    }
}
