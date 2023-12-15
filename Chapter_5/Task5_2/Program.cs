namespace Task5_2;
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

    static bool Contains(Node? list, int value)
    {
        if (list == null)
        {
            return false;
        }
        if (list.Value == value)
        {
            return true;
        }

        return Contains(list.Next, value);
    }

    static int GetMaxValue(Node? list)
    {
        if (list.Next == null)
        {
            return list.Value;
        }
        int num = GetMaxValue(list.Next);
        if (num > list.Value)
        {
            return num;
        }
        return list.Value;
    }

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

        Console.WriteLine($"{list.ToString()}");

        // Test GetLength
        Console.WriteLine($"Length of the list: {GetLength(list)}");

        // Test ListSum
        Console.WriteLine($"Sum of the list: {ListSum(list)}");

        // Test Contains
        int searchValue = 3;
        Console.WriteLine($"List contains {searchValue}: {Contains(list, searchValue)}");

        // Test GetMaxValue
        Console.WriteLine($"Max value in the list: {GetMaxValue(list)}");

        // Test IsSorted
        Console.WriteLine($"Is the list sorted: {IsSorted(list)}");

    }
}
