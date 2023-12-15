namespace Q3_Q4;
class Program
{
    //Q3
    static void NTo1(int n)
    {
        if (n > 0)
        {
            Console.Write(n + " ");
            NTo1(n - 1);
        }
    }

    //Q4
    static void OneToN(int n)
    {
        if (n > 0)
        {
            OneToN(n - 1);
            Console.Write($"{n} ");
        }
    }
    static void Main(string[] args)
    {
        NTo1(5);
        Console.WriteLine($"");
        OneToN(5);
    }
}
