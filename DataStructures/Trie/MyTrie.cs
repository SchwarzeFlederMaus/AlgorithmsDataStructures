namespace DataStructures.Trie
{
    public class MyTrie<T>
    {
        private readonly Node<T> root;
        public MyTrie()
        {
            root = new Node<T>(default);
        }
        public void Add(string key, T data)
        {
            Node<T> current = root;
            for (int i = 0; i < key.Length; i++)
            {
                int index = key[i] - 'a';
                if (current.Children[index] == null)
                {
                    current.Children[index] = new Node<T>(default);
                    current.Children[index].Parent = current;
                }
                current = current.Children[index];
            }
            current.IsEndOfWord = true;
            current.Data = data;
        }
        public bool Search(string key)
        {
            Node<T> current = root;
            for (int i = 0; i < key.Length; i++)
            {
                int index = key[i] - 'a';
                if (current.Children[index] == null)
                {
                    return false;
                }
                current = current.Children[index];
            }
            return current != null && current.IsEndOfWord;
        }
        public void Delete(string key)
        {
            Delete(root, key, 0);
        }
        private bool Delete(Node<T> current, string key, int index)
        {
            if (index == key.Length)
            {
                if (!current.IsEndOfWord)
                {
                    return false;
                }
                current.IsEndOfWord = false;
                return IsFreeNode(current);
            }
            int idx = key[index] - 'a';
            if (current.Children[idx] == null)
            {
                return false;
            }
            bool shouldDeleteCurrentNode = Delete(current.Children[idx], key, index + 1);
            if (shouldDeleteCurrentNode)
            {
                current.Children[idx] = null;
                return IsFreeNode(current);
            }
            return false;
        }
        private bool IsFreeNode(Node<T> current)
        {
            for (int i = 0; i < current.Children.Length; i++)
            {
                if (current.Children[i] != null)
                {
                    return false;
                }
            }
            return true;
        }
        public T GetData(string key)
        {
            Node<T> current = root;
            for (int i = 0; i < key.Length; i++)
            {
                int index = key[i] - 'a';
                if (current.Children[index] == null)
                {
                    return default;
                }
                current = current.Children[index];
            }
            return current.Data;
        }
    }
}
