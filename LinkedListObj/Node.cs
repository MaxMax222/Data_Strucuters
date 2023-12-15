namespace LinkedListObj
{
    public class Node<T>
    {
        private T value;
        private Node<T>? next;

        public Node(T value, Node<T> node)
        {
            this.value = value;
            this.next = node;
        }
        public Node(T value)
        {
            this.value = value;
            this.next = null;
        }

        public T Value
        {
            get { return value; }
            set { this.value = value; }
        }

        public Node<T>? Next
        {
            get { return this.next; }
            set
            {
                if (value.GetType() == typeof(Node<T>))
                    next = value;
                else
                    throw new ArgumentException("The value must be a node");
            }
        }
        public Node<T>? GetNodeAt(int position)
        {
            Node<T> current = this;

            for (int i = 1; i <= position; i++)
            {
                if (current == null)
                {
                    // The list is shorter than the specified position
                    return null;
                }

                current = current.Next;
            }

            return current;
        }

        public override string ToString()
        {
            return $"{value} -> {next}";
        }
    }
}