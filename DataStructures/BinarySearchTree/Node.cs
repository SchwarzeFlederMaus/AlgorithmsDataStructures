namespace DataStructures.BinarySearchTree
{
    public class Node<T> : IComparable<Node<T>>, IComparable<T>
        where T : IComparable<T>
    {
        public T Data { get; set; }
        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }

        public Node(T data)
        {
            Data = data;
            Left = null;
            Right = null;
        }
        public Node(T data, Node<T> left, Node<T> right)
        {
            Data = data;
            Left = left;
            Right = right;
        }
        public int CompareTo(Node<T> other) => Data.CompareTo(other.Data);
        public int CompareTo(T other) => Data.CompareTo(other);
    }
}
