namespace Task3_13;
class Program
{
    static void PrintRowAsterisk(int n)
    {
        if (n > 0)
        {
            Console.Write("*");
            PrintRowAsterisk(n - 1);
        }
    }

    static void PrintRowNumbers(int n, int i)
    {
        if (i > 0)
        {
            Console.Write(n);
            PrintRowNumbers(n, i - 1);
        }
    }
    static void PrintRowSpaces(int n)
    {
        if (n > 0)
        {
            Console.Write(" ");
            PrintRowSpaces(n - 1);
        }
    }
    //Q1
    static void PrintRectangle(int n, int m)
    {
        if (n > 0)
        {
            PrintRowAsterisk(m);
            Console.WriteLine();
            PrintRectangle(n - 1, m);
        }
    }

    //Q2
    static void PrintTriangleDown(int n)
    {
        if (n > 0)
        {
            PrintRowAsterisk(n);
            Console.WriteLine();
            PrintTriangleDown(n - 1);
        }
    }

    //Q3
    static void PrintTriangleUp(int n)
    {
        if (n > 0)
        {
            PrintTriangleUp(n - 1);
            PrintRowAsterisk(n);
            Console.WriteLine();
        }
    }

    //Q4
    static void Print2Triangles(int n)
    {
        if (n == 1)
        {
            Console.WriteLine("*");
        }
        else
        {
            PrintRowAsterisk(n);
            Console.WriteLine();
            Print2Triangles(n - 1);
            PrintRowAsterisk(n);
            Console.WriteLine();
        }
    }

    //Q5
    static void PrintTriangleNumbersDown(int n)
    {
        if (n > 0)
        {
            PrintRowNumbers(n, n);
            Console.WriteLine();
            PrintTriangleNumbersDown(n - 1);
        }
    }

    //Q6
    static void Print2TrianglesNumbers(int n)
    {
        if (n > 0)
        {
            PrintRowNumbers(n, n);
            Console.WriteLine();
            Print2TrianglesNumbers(n - 1);
            PrintRowNumbers(n, n);
            Console.WriteLine();
        }
    }

    //Q7 
    static void PrintPyramidAfterSpaces(int n)
    {
        if (n > 0)
        {
            PrintRowSpaces(n);
            Console.Write($"*");
            Console.WriteLine();
            PrintPyramidAfterSpaces(n - 1);
        }
    }

    //Q8
    static void PrintTriangleToRight(int n)
    {
        PrintTriangleToRight(n, n);
    }

    static void PrintTriangleToRight(int n, int total)
    {
        if (n > 0)
        {
            PrintRowSpaces(total - n);
            PrintRowAsterisk(n);
            Console.WriteLine();
            PrintTriangleToRight(n - 1, total);
        }
    }


    //Q9


    static void Main(string[] args)
    {
        PrintRectangle(3, 5);
        Console.WriteLine();
        PrintTriangleDown(3);
        Console.WriteLine();
        PrintTriangleUp(3);
        Console.WriteLine();
        Print2Triangles(3);
        Console.WriteLine();
        PrintTriangleNumbersDown(3);
        Console.WriteLine();
        Print2TrianglesNumbers(3);
        Console.WriteLine();
        PrintPyramidAfterSpaces(3);
        Console.WriteLine();
        PrintTriangleToRight(3);
        Console.WriteLine();
        PrintGlassHour(3);

    }
}
