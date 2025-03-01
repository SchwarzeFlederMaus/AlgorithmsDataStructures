namespace DataStructures.Queue
{
    public class DoublyNode<T>
    {
        public T Data { get; set; }
        public DoublyNode<T> Next { get; set; }
        public DoublyNode<T> Previous { get; set; }

        public DoublyNode(T data) => Data = data;

        public override string ToString() => Data.ToString();
    }
}
