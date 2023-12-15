using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;

namespace Task5_20;
class Program
{
    static bool Contains(Node<string> list, string name)
    {
        if (list == null)
        {
            return false;
        }
        else if (list.Value.Equals(name))
        {
            return true;
        }
        return Contains(list.Next, name);
    }

    static string GetShortestName(Node<string> list)
    {
        if (list.Next == null)
        {
            return list.Value;
        }
        string name = GetShortestName(list.Next);
        if (name.Length < list.Value.Length)
        {
            return name;
        }
        return list.Value;
    }

    static bool AlphabeticlySorted(Node<string> list)
    {
        if (list.Next == null)
        {
            return true;
        }
        else if (list.Value.CompareTo(list.Next.Value) > 0)
        {
            return false;
        }
        return AlphabeticlySorted(list.Next);
    }

    //helper function
    //assuming all names in lowercase
    static void GetAllLettersThatListDontContains(Node<string> list, int[] abc)
    {
        if (list != null)
        {
            for (int i = 0; i < list.Value.Length; i++)
            {
                abc[list.Value[i] - 97]++;
            }    
            GetAllLettersThatListDontContains(list.Next, abc);
        }
    }

    static void PrintAllLettersThatListDontContains(Node<string> list)
    {
        int[] abc = new int[26];
        GetAllLettersThatListDontContains(list, abc);
        for (int i = 0; i < abc.Length; i++)
        {
            if (abc[i] == 0)
            {
                Console.Write($"{(char)(i + 97)}");
            }
        }
    }

    static void Main(string[] args)
    {
        Node<string> list =
        new Node<string>("alice",
        new Node<string>("bob",
        new Node<string>("charlie",
        new Node<string>("david",
        new Node<string>("eva",
        new Node<string>("frank",
        new Node<string>("grace")))))));
        
        Console.WriteLine($"{list.ToString()
        }");
        
        // Testing Contains function
        string searchName = "banana";
        bool containsResult = Contains(list, searchName);
        Console.WriteLine($"Contains '{searchName}': {containsResult}");

        // Testing GetShortestName function
        string shortestName = GetShortestName(list);
        Console.WriteLine($"Shortest Name: {shortestName}");

        // Testing AlphabeticlySorted function
        bool isSorted = AlphabeticlySorted(list);
        Console.WriteLine($"Alphabeticly Sorted: {isSorted}");

        // Testing PrintAllLettersThatListDontContains function
        Console.Write("Letters that are not in the list: ");
        PrintAllLettersThatListDontContains(list);
    }
}
