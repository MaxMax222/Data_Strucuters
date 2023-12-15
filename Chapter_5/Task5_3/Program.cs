
namespace Task5_3;

class Program
{

    static int GetLength(Node? list)
    {
        if (list.Next == null)
        {
            return 1;
        }
        return GetLength(list.Next) + 1;
    }
    static int ListSum(Node? list)
    {
        if (list.Next == null)
        {
            return list.Value;
        }
        return ListSum(list.Next) + list.Value;
    }

    //*Q1
    static void PrintInRangeByIndex(Node list, int num1, int num2)
    {
        int cnt = 1;
        while (list.Next != null)
        {
            if (cnt >= Math.Min(num1, num2) && cnt <= Math.Max(num1, num2))
            {
                Console.Write($"{list.Value}");
            }
            list = list.Next;
        }
    }
    //*Q2
    static bool IsInList(Node? list, int value)
    {
        if (list == null)
        {
            return false;
        }
        if (list.Value == value)
        {
            return true;
        }

        return IsInList(list.Next, value);
    }
    //*Q3
    static double Avg(Node? list)
    {
        return ListSum(list) / GetLength(list);
    }

    //*Q4
    static char MoreOddOrEven(Node list)
    {
        int cntOdd = 0, cntEven = 0;
        while (list.Next != null)
        {
            if (list.Value % 2 == 0)
            {
                cntEven++;
            }
            else
            {
                cntOdd++;
            }
            list = list.Next;
        }

        if (cntEven > cntOdd)
        {
            return 'z';
        }
        else if (cntOdd > cntEven)
        {
            return 'e';
        }
        else
        {
            return 's';
        }

    }
    //*Q5
    static bool IsSorted(Node? list)
    {
        if (list.Next == null)
        {
            return true;
        }
        if (list.Value >= list.Next.Value)
        {
            return false;
        }

        return IsSorted(list.Next);
    }

    //* Q6
    static void PrintBiggerThenNext(Node? list)
    {
        if (list.Next != null)
        {
            if (list.Value > list.Next.Value)
            {
                Console.WriteLine($"{list.Value}");
            }
            PrintBiggerThenNext(list.Next);
        }

    }

    //* Q7

    static int CountSequencesOfnum(Node? list, int num)
    {
        if (list.Next == null)
        {
            if (list.Value == num)
            {
                return 1;
            }
            return 0;
        }

        if (list.Value == num && list.Next.Value != num)
        {
            return CountSequencesOfnum(list.Next, num) + 1;
        }
        return CountSequencesOfnum(list.Next, num);
    }

    //* Q8
    static bool IsBalanced(Node? list)
    {
        double avg = Avg(list);
        int cntBelowAvg = 0, cntAboveAvg = 0;
        while (list.Next != null)
        {
            if (list.Value > avg)
            {
                cntAboveAvg++;
            }
            else if (list.Value < avg)
            {
                cntBelowAvg++;
            }
        }
        return cntAboveAvg == cntBelowAvg;
    }

    //*Q9
    static Node GetNode(Node list)
    {
        if (list.Next == null)
        {
            return list;
        }
        return GetNode(list);
    }


    //*Q10
    static Node? GetPrev(Node list, Node node)
    {
        Node prev = list;
        while (list.Next != null)
        {
            if (list.Next == node)
            {
                return prev;
            }
            prev = list;
            list = list.Next;
        }
        return null;
    }

    //*Q11
    static Node? GetPos(Node? list, int value)
    {
        if (list == null)
        {
            return null;
        }
        if (list.Value == value)
        {
            return list;
        }

        return GetPos(list.Next, value);
    }

    static Random rnd = new Random();

    static void Main(string[] args)
    {

        Node list = new Node(rnd.Next(51));
        Node pointer = list;
        for (int i = 0; i < 9; i++)
        {
            pointer.Next = new Node(rnd.Next(51));
            pointer = pointer.Next;
        }

        Node? node3 = list.Next.Next.Next;
        // Test PrintInRangeByIndex
        Console.WriteLine("Print elements in the range [2, 4]:");
        PrintInRangeByIndex(list, 2, 4);
        Console.WriteLine();

        // Test IsInList
        int searchValue = 3;
        Console.WriteLine($"Is {searchValue} in the list: {IsInList(list, searchValue)}");

        // Test Avg
        Console.WriteLine($"Average of the list: {Avg(list)}");

        // Test MoreOddOrEven
        Console.WriteLine($"More odd or even in the list: {MoreOddOrEven(list)}");

        // Test IsSorted (Note: This is the second IsSorted method you provided)
        Console.WriteLine($"Is the list sorted: {IsSorted(list)}");

        // Test PrintBiggerThenNext
        Console.WriteLine("Elements bigger than the next element:");
        PrintBiggerThenNext(list);
        Console.WriteLine();

        // Test CountSequencesOfnum
        int numToCount = 3;
        Console.WriteLine($"Number of sequences of {numToCount}: {CountSequencesOfnum(list, numToCount)}");

        // Test IsBalanced
        Console.WriteLine($"Is the list balanced: {IsBalanced(list)}");

        // Test GetNode
        Console.WriteLine($"Last node in the list: {GetNode(list).Value}");

        // Test GetPrev
        Node? prevNode = GetPrev(list, node3);
        Console.WriteLine($"Previous node to the third node: {prevNode}");

        // Test GetPos
        int valueToFind = 4;
        Node? posNode = GetPos(list, valueToFind);
        Console.WriteLine($"Node with value {valueToFind} found: {(posNode != null ? "Yes" : "No")}");
    }
}
