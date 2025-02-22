namespace SinglyLinkedListLibrary
{

    public class Node
    {
        private short data;
        private Node? next;

        public short Data
        {
            get => data;
            set => data = value;
        }

        public Node Next
        {
            get => next;
            set => next = value;
        }

        public Node(short data)
        {
            this.data = data;
            next = null;
        }
    }
}