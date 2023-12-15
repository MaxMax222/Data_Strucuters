using System;
namespace Task3_5;
class Program
{
    //Q2

    static int Search(int[] arr, int target)
    {
        return Search(arr, target, 0, arr.Length - 1);
    }
    static int Search(int[] arr, int x, int left, int right)
    {
        if (left < right)
        {
            int mid = (left + right) / 2;

            if (arr[mid] == x)
            {
                return mid;
            }

            if (arr[mid] > x)
            {
                return Search(arr, x, left, mid - 1);
            }

            return Search(arr, x, mid + 1, right);
        }

        return -1;
    }


    //Q3
    static bool IsSorted(int[] arr, int i = 0)
    {
        if (i == arr.Length - 1)
        {
            return true;
        }
        if (arr[i] >= arr[i + 1])
        {
            return false;
        }
        return IsSorted(arr, i + 1);
    }

    //Q4
    static int LargerThanNeighbors(int[] arr, int i = 1)
    {
        if (i == arr.Length - 2)
        {
            if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
            {
                return 1;
            }
            return 0;
        }
        if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
        {
            return LargerThanNeighbors(arr, i + 1) + 1;
        }
        return LargerThanNeighbors(arr, i + 1);
    }

    //Q5
    static int EvenSumDiffOddSum(int[] arr, int evenSum = 0, int oddSum = 0, int i = 0)
    {
        if (i == arr.Length - 1)
        {
            if (i % 2 == 0)
            {
                evenSum += arr[i];
            }
            else
            {
                oddSum += arr[i];
            }
            return evenSum - oddSum;
        }
        if (i % 2 == 0)
        {
            return EvenSumDiffOddSum(arr, evenSum + arr[i], oddSum, i + 1);
        }
        return EvenSumDiffOddSum(arr, evenSum, oddSum + arr[i], i + 1);
    }
    //Q6
    static bool IsReversed(int[] arr1, int[] arr2, int i = 0)
    {
        if (i == arr1.Length)
        {
            return true;
        }

        if (arr1[i] != arr2[arr2.Length - 1 - i])
        {
            return false;
        }
        return IsReversed(arr1, arr2, i + 1);
    }
    //Q7
    static bool IsPalindrome(int[] arr, int i = 0)
    {
        if (i == arr.Length)
        {
            return true;
        }
        if (arr[i] != arr[arr.Length - 1 - i])
        {
            return false;
        }
        return IsPalindrome(arr, i + 1);
    }
    //Q8
    static bool IsSeria(int[] arr, int i = 0)
    {
        if (i == arr.Length - 3)
        {
            return (arr[i + 1] - arr[i]) == (arr[i + 2] - arr[i + 1]);
        }
        if (!((arr[i + 1] - arr[i]) == (arr[i + 2] - arr[i + 1])))
        {
            return false;
        }

        return IsSeria(arr, i + 1);
    }
    //Q9
    static bool ContainsPrimal(int[] arr, int i = 0)
    {
        if (i == arr.Length)
        {
            return false;
        }
        if (IsPrimal(arr[i], 2))
        {
            return true;
        }
        return ContainsPrimal(arr, i + 1);

    }
    static bool IsPrimal(int x, int div)
    {
        if (div > x / 2)
        {
            return true;
        }
        if (x % div == 0)
        {
            return false;
        }
        return IsPrimal(x, div + 1);
    }

    //Q10

    static int CountPositive(int[] arr, int from)
    {
        if (from == arr.Length)
        {
            return 0;
        }

        if (arr[from] > 0)
        {
            return CountPositive(arr, from + 1) + 1;
        }
        return CountPositive(arr, from + 1);
    }

    static int CountNegative(int[] arr, int until, int i)
    {
        if (until == i)
        {
            return 0;
        }

        if (arr[until] < 0)
        {
            return CountNegative(arr, until, i + 1) + 1;
        }
        return CountNegative(arr, until, i + 1);
    }
    static int CountBalanced(int[] arr, int i = 0)
    {
        if (i == arr.Length - 2)
        {
            if (CountNegative(arr, i, 0) == CountPositive(arr, i))
            {
                return 1;
            }
            return 0;
        }
        if (CountNegative(arr, i, 0) == CountPositive(arr, i))
        {
            return CountBalanced(arr, i + 1) + 1;
        }
        return CountBalanced(arr, i + 1);
    }
    static void Main(string[] args)
    {
        int[] arr1 = { 1, 2, 3, 4, 5 };
        int[] arr2 = { 5, 4, 3, 2, 1 };
        int[] arr3 = { 1, 2, 3, 2, 1 };
        int[] arr4 = { 1, 9, 8, 4, 4, 6 };
        int[] arr5 = { 1, -2, 3, -2, 1, 0 };

        Console.WriteLine("Q2 - Search:");
        Console.WriteLine("Search for 3 in arr1: " + Search(arr1, 3)); // Should print "2"
        Console.WriteLine("Search for 6 in arr1: " + Search(arr1, 6)); // Should print "-1"
        Console.WriteLine();

        Console.WriteLine("Q3 - IsSorted:");
        Console.WriteLine("Is arr1 sorted? " + IsSorted(arr1)); // Should print "True"
        Console.WriteLine("Is arr2 sorted? " + IsSorted(arr2)); // Should print "False"
        Console.WriteLine();

        Console.WriteLine("Q4 - LargerThanNeighbors:");
        Console.WriteLine("Number of elements larger than neighbors in arr3: " + LargerThanNeighbors(arr3)); // Should print "1"
        Console.WriteLine("Number of elements larger than neighbors in arr4: " + LargerThanNeighbors(arr4)); // Should print "1"
        Console.WriteLine();

        Console.WriteLine("Q5 - EvenSumDiffOddSum:");
        Console.WriteLine("Difference between even and odd sums in arr1: " + EvenSumDiffOddSum(arr1)); // Should print "3"
        Console.WriteLine("Difference between even and odd sums in arr5: " + EvenSumDiffOddSum(arr5)); // Should print "9"
        Console.WriteLine();

        Console.WriteLine("Q6 - IsReversed:");
        Console.WriteLine("Is arr1 reversed in arr2? " + IsReversed(arr1, arr2)); // Should print "True"
        Console.WriteLine("Is arr1 reversed in arr3? " + IsReversed(arr1, arr3)); // Should print "False"
        Console.WriteLine();

        Console.WriteLine("Q7 - IsPalindrome:");
        Console.WriteLine("Is arr1 a palindrome? " + IsPalindrome(arr1)); // Should print "False"
        Console.WriteLine("Is arr3 a palindrome? " + IsPalindrome(arr3)); // Should print "True"
        Console.WriteLine();

        Console.WriteLine("Q8 - IsSeria:");
        Console.WriteLine("Is arr1 a seria? " + IsSeria(arr1)); // Should print "True"
        Console.WriteLine("Is arr3 a seria? " + IsSeria(arr3)); // Should print "False"
        Console.WriteLine();

        Console.WriteLine("Q9 - ContainsPrimal:");
        Console.WriteLine("Does arr1 contain prime numbers? " + ContainsPrimal(arr1)); // Should print "True"
        Console.WriteLine("Does arr4 contain prime numbers? " + ContainsPrimal(arr4)); // Should print "False"
        Console.WriteLine();

        Console.WriteLine("Q10 - CountBalanced:");
        Console.WriteLine("Number of balanced subarrays in arr1: " + CountBalanced(arr1)); // Should print "0"
        Console.WriteLine("Number of balanced subarrays in arr5: " + CountBalanced(arr5)); // Should print "1"
    }
}
