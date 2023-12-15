using System.Diagnostics.CodeAnalysis;

namespace Task3_3;
class Program
{
    //Q1
    static int LengthDifference(int num1, int num2)
    {
        if (num1 == 0 && num2 == 0)
        {
            return 0;
        }
        if (num1 == 0)
        {
            return LengthDifference(num1, num2 / 10) - 1;
        }
        return LengthDifference(num1 / 10, num2) + 1;
    }

    //Q2
    static int CountSame(int num1, int num2)
    {
        if (num1 == 0 || num2 == 0)
        {
            return 0;
        }
        if (num1 % 10 == num2 % 10)
        {
            return CountSame(num1 / 10, num2 / 10) + 1;
        }
        return CountSame(num1 / 10, num2 / 10);
    }

    //Q3
    // static int MinimalDiv(int a, int b, int div = 2)
    // {
    //     if (div > Math.Min(a, b))
    //     {
    //         return -1;
    //     }
    //     if (a % div == 0 && b % div == 0)
    //     {
    //         return div;
    //     }
    //     return MinimalDiv(a, b, div + 1);
    // }

    static int MinDiviser(int num1, int num2)
    {
        return MinDiviser(num1, num2, 2);
    }

    static int MinDiviser(int num1, int num2, int divisior)
    {
        if (divisior > Math.Min(num1, num2))
        {
            return -1;
        }
        if (num1 % divisior == 0 && num2 % divisior == 0)
        {
            return divisior;
        }
        return MinDiviser(num1, num2, divisior + 1);
    }

    //Q4
    static int MaximalDiv(int num1, int num2)
    {
        return MaximalDiv(num1, num2, Math.Min(num1, num2));
    }

    static int MaximalDiv(int num1, int num2, int divisior)
    {
        if (divisior == 1)
        {
            return -1;
        }

        if (num1 % divisior == 0 && num2 % divisior == 0)
        {
            return divisior;
        }
        return MaximalDiv(num1, num2, divisior--);
    }





    // static int MaximalDiv(int a, int b)
    // {
    //     if (a == 1)
    //     {
    //         return -1;
    //     }
    //     if (b == 0)
    //     {
    //         return a;
    //     }
    //     return MaximalDiv(b, a % b);
    // }




    static void Main(string[] args)
    {
        // Test cases for LengthDifference
        int lengthDiff1 = LengthDifference(12345, 9876);
        Console.WriteLine($"Length difference of 12345 and 9876: {lengthDiff1}"); // Expected output: 0

        int lengthDiff2 = LengthDifference(12345, 54321);
        Console.WriteLine($"Length difference of 12345 and 54321: {lengthDiff2}"); // Expected output: 0

        int lengthDiff3 = LengthDifference(1234, 54321);
        Console.WriteLine($"Length difference of 1234 and 54321: {lengthDiff3}"); // Expected output: 1

        // Test cases for CountSame
        int countSame1 = CountSame(12345, 9876);
        Console.WriteLine($"Count of same digits in 12345 and 9876: {countSame1}"); // Expected output: 0

        int countSame2 = CountSame(12345, 54321);
        Console.WriteLine($"Count of same digits in 12345 and 54321: {countSame2}"); // Expected output: 1  

        // Test cases for MinimalDiv
        // int minimalDiv1 = MinimalDiv(12, 18);
        // Console.WriteLine($"Minimal common divider of 12 and 18: {minimalDiv1}"); // Expected output: 2

        // int minimalDiv2 = MinimalDiv(15, 28);
        // Console.WriteLine($"Minimal common divider of 15 and 28: {minimalDiv2}"); // Expected output: -1 (no common divider)

        // Test cases for MaximalDiv
        // int maximalDiv1 = MaximalDiv(48, 18);
        // Console.WriteLine($"Maximal common divider of 48 and 18: {maximalDiv1}"); // Expected output: 6

        // int maximalDiv2 = MaximalDiv(35, 7);
        // Console.WriteLine($"Maximal common divider of 35 and 7: {maximalDiv2}"); // Expected output: 7


    }
}
