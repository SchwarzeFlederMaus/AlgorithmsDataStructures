namespace DataStructures.BinaryHeap
{
    public class Node<T> : IComparable<T>
        where T : IComparable<T>
    {
        public T Data { get; set; }
        public Node(T data)
        {
            Data = data;
        }

        public int CompareTo(T other) => Data.CompareTo(other);
    }
}
