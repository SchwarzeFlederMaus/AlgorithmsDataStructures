namespace DataStructures.Trie
{
    public class Node <T>
    {
        public T Data { get; set; }
        public Node<T> Parent { get; set; }
        public Node<T>[] Children { get; set; }
        public bool IsEndOfWord { get; set; }
        public Node(T data)
        {
            Data = data;
            Children = new Node<T>[26];
        }
    }
}
