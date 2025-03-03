namespace DataStructures.Dictionary
{
    public class Node<TKey, TValue>
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }
        public Node<TKey, TValue> Next { get; set; }
        public Node(TKey key, TValue value)
        {
            Key = key;
            Value = value;
        }
    }
}
