namespace Task4_0;
class Program
{
    // 3n + 3
    static double AvgGrade(int[] grades, int students)
    {
        double sum = 0;
        for (int i = 0; i < grades.Length; i++)
        {
            sum += grades[i];
        }
        return sum / students;
    }

    // 6n^2 + 3n + 1
    static void Bsort(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i; j < arr.Length - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int n = arr[j + 1];
                    arr[j + 1] = arr[j];
                    arr[j] = n;
                }
            }
        }
    }

    // 3n + 3
    static int Factorial(int n)
    {
        int fac = 1;
        for (int i = n; i > 1; i--)
        {
            fac *= i;
        }
        return fac;
    }

    // 3n + 2 
    static int CntDigits(int num)
    {
        int cnt = 0;
        while (num != 0)
        {
            cnt++;
            num /= 10;
        }
        return cnt;
    }

    // 5n^2 + 11n +8
    static int SameDigits(int n1, int n2)
    {
        int n1Len = CntDigits(n1);
        int n2Len = CntDigits(n2);
        int cnt = 0, temp;
        for (int i = 0; i < n1Len; i++)
        {
            temp = n2;
            for (int j = 0; j < n2Len; j++)
            {
                if (n1 % 10 == temp % 10)
                {
                    cnt++;
                }
                temp /= 10;
            }
            n1 /= 10;
        }
        return cnt;
    }

    // 3n+2
    static int CountA(string txt)
    {
        int cnt = 0;
        foreach (char letter in txt)
        {
            if (letter == 'a')
            {
                cnt++;
            }
        }
        return cnt;
    }

    // 3n^2 + 3n + 3
    static bool AllTheSame(int[,] mat)
    {
        int n = mat[0, 0];
        for (int i = 0; i < mat.GetLength(0); i++)
        {
            for (int j = 0; j < mat.GetLength(1); j++)
            {
                if (mat[i, j] != n)
                {
                    return false;
                }
            }
        }
        return true;
    }


    // 3n + 3
    static bool AllTheSameOnDiagonale(int[,] mat)
    {
        int n = mat[0, 0];
        for (int i = 0; i < mat.GetLength(0); i++)
        {
            if (mat[i, i] != n)
            {
                return false;
            }
        }
        return true;
    }

    //4n^2 + 3n + 3
    static int MaxInMat(int[,] mat)
    {
        int max = mat[0, 0];
        for (int i = 0; i < mat.GetLength(0); i++)
        {
            for (int j = 0; j < mat.GetLength(1); j++)
            {
                if (mat[i, j] == max)
                {
                    max = mat[i, j];
                }
            }
        }
        return max;
    }

    // 3n^2 + 3n + 2
    static bool Exist(int[,] mat, int num)
    {
        for (int i = 0; i < mat.GetLength(0); i++)
        {
            for (int j = 0; j < mat.GetLength(0); j++)
            {
                if (mat[i, j] == num)
                {
                    return true;
                }
            }
        }
        return false;
    }
    static void Main(string[] args)
    {
        // int[] arr = { 45, 50, 98, 100 };
        // int[] arr2 = { 1, 9, -9, 10, 8 };
        // Bsort(arr2);
        // Console.WriteLine($"{AvgGrade(arr, arr.Length)}");
        // for (int i = 0; i < arr2.Length; i++)
        // {
        //     Console.Write($"{arr2[i]} ");
        // }
        // Console.WriteLine();

        // Console.WriteLine($"{CntDigits(arr[3])}");

        Console.WriteLine($"{SameDigits(100, 120)}");

    }
}
