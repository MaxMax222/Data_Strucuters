namespace Task5_6;

class Program
{
    static Node<int>? BuildBackwards(int n, Node<int> list = null)
    {
        if (n>0)
        {
            Console.Write($"enter a number: ");
            list = new Node<int>(int.Parse(Console.ReadLine()), list);
        }
        if (n==0)
        {
            return list;
        }
        return BuildBackwards(n - 1, list);
    }

    static Node<int>? BuildList(int n, Node<int> list = null){
        if (n == 0)
        {
            return list;
        }
        Console.Write($"enter a numbre: ");
        list = new Node<int>(int.Parse(Console.ReadLine()), BuildList(n-1, list));
        return list;
    }


    static Node<int> BuildSorted(int n)
        {
            Console.Write($"enter a num: ");
            Node<int> list = new Node<int>(int.Parse(Console.ReadLine()));
            Node<int> head = list;
            for (int i = 1; i < n; i++)
            {
                Console.Write($"enter a num: ");
                int num = int.Parse(Console.ReadLine());
                if (num <= head.Value)
                {
                    head = new Node<int>(num, head);
                }
                else
                {
                    list = head;
                    while (list.HasNext && num > list.Next.Value)
                    {
                        list = list.Next;
                    }
                    list.Next = new Node<int>(num, list.Next);
                }
            }
            return head;
        }
    static void Main(string[] args)
    {
    }
}
