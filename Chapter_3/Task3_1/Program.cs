namespace Task3_1;
using System;

class Program
{
    // Q1: Returns the number of digits in the given number.
    static int GetLengthOfNum(int num)
    {
        if (num / 10 == 0)
        {
            return 1;
        }
        return GetLengthOfNum(num / 10) + 1;
    }

    // Q2: Returns the sum of the digits of the given number.
    static int SumOfDigits(int num)
    {
        if (num / 10 == 0)
        {
            return num;
        }
        return SumOfDigits(num / 10) + num % 10;
    }

    // Q3: Returns the sum of even digits in the given number.
    static int SumOfEvenDigits(int num)
    {
        num = Math.Abs(num);

        if (num == 0)
        {
            return 0;
        }

        int lastDigit = num % 10;

        if (lastDigit % 2 == 0)
        {
            return SumOfEvenDigits(num / 10) + lastDigit;
        }
        return SumOfEvenDigits(num / 10);
    }

    // Q4: Checks if the digit 5 is present in the given number.
    static bool Is5InNum(int num)
    {
        if (num / 10 == 0)
        {
            return num == 5;
        }
        if (num % 10 == 5)
        {
            return true;
        }
        return Is5InNum(num / 10);
    }

    // Q5: Checks if there is a digit in the number that is divisible by 3.
    static bool ContainsADigitThatCanBeDividedBy3(int num)
    {
        if (num / 10 == 0)
        {
            return num % 3 == 0;
        }

        if (num % 10 % 3 == 0)
        {
            return true;
        }
        return ContainsADigitThatCanBeDividedBy3(num / 10);
    }

    // Q6: Checks if all digits in the number are even.
    static bool AllDigitsAreEven(int num)
    {
        if (num / 10 == 0)
        {
            return num % 2 == 0;
        }

        if (num % 10 % 2 != 0)
        {
            return false;
        }
        return AllDigitsAreEven(num / 10);
    }

    // Q7: Checks if the digits in the number are in rising order.
    static bool IsRising(int num)
    {
        if (num / 10 == 0)
        {
            return true;
        }
        if (num % 10 < num / 10 % 10)
        {
            return false;
        }
        return IsRising(num / 10);
    }

    // Q8: Returns the least digit in the number.
    static int LeastDigit(int num)
    {
        if (num / 10 == 0)
        {
            return num;
        }
        int x = num % 10;
        int y = LeastDigit(num / 10);
        if (x < y)
        {
            return x;
        }
        return y;
    }

    static void Main()
    {
        // Test the functions
        int num1 = 12345;
        Console.WriteLine("Q1: Length of {0} is {1}", num1, GetLengthOfNum(num1));
        Console.WriteLine("Q2: Sum of digits in {0} is {1}", num1, SumOfDigits(num1));
        Console.WriteLine("Q3: Sum of even digits in {0} is {1}", num1, SumOfEvenDigits(num1));
        Console.WriteLine("Q4: Is 5 in {0}? {1}", num1, Is5InNum(num1));
        Console.WriteLine("Q5: Contains a digit divisible by 3 in {0}? {1}", num1, ContainsADigitThatCanBeDividedBy3(num1));
        Console.WriteLine("Q6: All digits are even in {0}? {1}", num1, AllDigitsAreEven(num1));
        Console.WriteLine("Q7: Digits are in rising order in {0}? {1}", num1, IsRising(num1));
        Console.WriteLine("Q8: Least digit in {0} is {1}", num1, LeastDigit(num1));
    }
}


