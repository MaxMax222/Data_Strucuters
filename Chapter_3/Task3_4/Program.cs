using System.Transactions;
using System.Runtime.Intrinsics.X86;

namespace Task3_4;
class Program
{
    static int SumCells(int[] arr, int i = 0)
    {
        if (i == arr.Length - 1)
        {
            return arr[i];
        }

        return SumCells(arr, i + 1) + arr[i];
    }

    static int PositiveCellsAmount(int[] arr, int i = 0)
    {
        if (i == arr.Length - 1)
        {
            if (arr[i] > 0)
            {
                return 1;
            }
            return 0;
        }
        if (arr[i] > 0)
        {
            return PositiveCellsAmount(arr, i + 1) + 1;
        }
        return PositiveCellsAmount(arr, i + 1);
    }

    static bool ContainsNegative(int[] arr, int i = 0)
    {
        if (i == arr.Length)
        {
            return false;
        }
        if (arr[i] < 0)
        {
            return true;
        }
        return ContainsNegative(arr, i + 1);
    }

    static int MaxValue(int[] arr, int i = 0, int max = 0)
    {
        if (i == arr.Length - 1)
        {
            if (arr[i] > max)
            {
                return arr[i];
            }
            return max;
        }
        if (arr[i] > max)
        {
            max = arr[i];
        }
        return MaxValue(arr, i + 1, max);
    }

    static bool ThreeSameInRow(int[] arr, int i = 0)
    {
        if (i == arr.Length - 3)
        {
            return arr[i] == arr[i + 1] && arr[i + 1] == arr[i + 2];
        }

        if (arr[i] == arr[i + 1] && arr[i + 1] == arr[i + 2])
        {
            return true;
        }
        return ThreeSameInRow(arr, i + 1);
    }

    static bool NeighborsWithSameOddity(int[] arr, int i = 0)
    {
        if (i == arr.Length - 2)
        {
            return arr[i] % 2 == arr[i + 1] % 2;
        }
        if (arr[i] % 2 == arr[i + 1] % 2)
        {
            return true;
        }
        return NeighborsWithSameOddity(arr, i + 1);
    }

    static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5, -1, -2, -3, 6, 7 };

        Console.WriteLine("Sum of all cells: " + SumCells(arr));
        Console.WriteLine("Number of positive cells: " + PositiveCellsAmount(arr));
        Console.WriteLine("Contains negative element: " + ContainsNegative(arr));
        Console.WriteLine("Max value in the array: " + MaxValue(arr));
        Console.WriteLine("Three consecutive same elements: " + ThreeSameInRow(arr));
        Console.WriteLine("Neighbors with the same oddity: " + NeighborsWithSameOddity(arr));
    }
}
