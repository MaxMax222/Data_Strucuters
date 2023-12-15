namespace LinkedListObj;
class Program
{
    static void Main(string[] args)
    {
        Node<int> List = new Node<int>(0);
        Node<int> pointer = List; // Store the reference to the head node

        for (int i = 1; i <= 10; i++)
        {
            pointer.Next = new Node<int>(i);
            pointer = pointer.Next; // Update the reference to the last node
        }

    }
}
