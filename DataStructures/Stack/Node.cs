namespace DataStructures.Stack
{
    public class Node <T>
    {
        public T Data;
        public Node<T> Previous;

        public Node(T data) => Data = data;
    }
}
