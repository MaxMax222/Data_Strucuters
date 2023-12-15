namespace Task5_3
{
    public class Node
    {
        private int value;
        private Node? next;

        public Node(int value, Node node)
        {
            this.value = value;
            this.next = node;
        }
        public Node(int value)
        {
            this.value = value;
            this.next = null;
        }

        public int Value
        {
            get { return value; }
            set { this.value = value; }
        }

        public Node? Next
        {
            get { return this.next; }
            set
            {
                if (value.GetType() == typeof(Node))
                    next = value;
                else
                    throw new ArgumentException("The value must be a node");
            }
        }
        public override string ToString()
        {
            return $"{value} -> {next}";
        }
    }
}