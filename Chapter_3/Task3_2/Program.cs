
namespace Task3_1;
class Program
{
    // Q1
    static int SumToNum(int n)
    {
        if (n == 1)
        {
            return 1;
        }
        int sum = SumToNum(n - 1) + n;
        return sum;
    }

    //Q3
    static int MultiplyOddUntilNum(int n)
    {
        if (n == 1)
        {
            return 1;
        }
        if (n % 2 == 0)
        {
            return MultiplyOddUntilNum(n - 1);
        }
        return MultiplyOddUntilNum(n - 1) * n;
    }
    // Q5
    static int Division(int n, int den)
    {
        if (n < den)
        {
            return 0;
        }
        return Division(n - den, den) + 1;
    }

    // Q6
    static int Module(int n, int den)
    {
        if (n < den)
        {
            return n;
        }
        return Module(n - den, den);
    }

    //Q7
    static bool IsMulti(int x, int y)
    {
        if (x < y)
        {
            return false;
        }
        if (x == y)
        {
            return true;
        }
        return IsMulti(x - y, y);
    }

    //Q9
    static bool AllOddOrEven(int num)
    {
        if (num < 10)
        {
            return true;
        }
        if (num % 10 % 2 != num / 10 % 2)
        {
            return false;
        }
        return AllOddOrEven(num / 10);
    }

    // Multiplication
    static int Multiplication(int n, int m)
    {
        if (m == 1)
        {
            return n;
        }
        return Multiplication(n, m - 1) + n;
    }

    static int BiggestEvenDigit(int num)
    {
        if (num / 10 == 0)
        {
            if (num % 2 == 0)
            {
                return num;
            }
            return -1;
        }
        int x = num % 10;
        int y = BiggestEvenDigit(num / 10);
        if (x > y)
        {
            return x;
        }
        return y;

    }
    static void Main(string[] args)
    {
        // Q1: Test for SumToNum function
        int sumResult = SumToNum(5); // Sum of numbers from 1 to 5 = 1 + 2 + 3 + 4 + 5 = 15
        Console.WriteLine($"SumToNum(5) should be 15, Result: {sumResult}");

        // Q3: Test for MultiplyOddUntilNum function
        int multiplyResult = MultiplyOddUntilNum(5); // Product of odd numbers from 1 to 5 = 1 * 3 * 5 = 15
        Console.WriteLine($"MultiplyOddUntilNum(5) should be 15, Result: {multiplyResult}");

        // Q5: Test for Division function
        int divisionResult = Division(10, 3); // Integer division of 10 by 3 = 3
        Console.WriteLine($"Division(10, 3) should be 3, Result: {divisionResult}");

        // Q6: Test for Module function
        int moduleResult = Module(10, 3); // Remainder of 10 divided by 3 = 1
        Console.WriteLine($"Module(10, 3) should be 1, Result: {moduleResult}");

        // Q7: Test for IsMulti function
        bool isMultiResult = IsMulti(12, 4); // 12 is a multiple of 4
        Console.WriteLine($"IsMulti(12, 4) should be true, Result: {isMultiResult}");

        // Q9: Test for AllOddOrEven function
        bool allOddOrEvenResult = AllOddOrEven(2468); // All digits are even
        Console.WriteLine($"AllOddOrEven(2468) should be true, Result: {allOddOrEvenResult}");

        // Multiplication: Test for Multiplication function
        int multiplicationResult = Multiplication(5, 3); // 5 * 3 = 15
        Console.WriteLine($"Multiplication(5, 3) should be 15, Result: {multiplicationResult}");

        // BiggestEvenDigit: Test for BiggestEvenDigit function
        int biggestEvenDigitResult = BiggestEvenDigit(763528); // Largest even digit is 8
        Console.WriteLine($"BiggestEvenDigit(763528) should be 8, Result: {biggestEvenDigitResult}");
    }
}
