namespace DataStructures.BinarySearchTree
{
    public class MyBinarySearchTree<T>
        where T : IComparable<T>
    {
        private Node<T> _root;
        public int Count { get; private set; }
        public bool IsEmpty => Count == 0;

        public MyBinarySearchTree()
        {
            _root = null;
            Count = 0;
        }

        public void Add(T data) => _root = AddRecursively(_root, data);
        private Node<T> AddRecursively(Node<T> node, T data)
        {
            if (node == null)
            {
                Count++;
                return new Node<T>(data);
            }

            if (node.CompareTo(data) > 0) node.Left = AddRecursively(node.Left, data);
            else node.Right = AddRecursively(node.Right, data);

            return node;
        }
        public void Remove(T data) => _root = RemoveRecursively(_root, data);
        private Node<T> RemoveRecursively(Node<T> node, T data)
        {
            if (node == null) return node;
            if (node.CompareTo(data) > 0) node.Left = RemoveRecursively(node.Left, data);
            else if (node.CompareTo(data) < 0) node.Right = RemoveRecursively(node.Right, data);
            else
            {
                if (node.Left == null || node.Right == null)
                {
                    Count--;
                    return node.Left ?? node.Right;
                }
                node.Data = MinValue(node.Right);
                node.Right = RemoveRecursively(node.Right, node.Data);
            }
            return node;
        }

        public bool Contains(T data) => ContainsRecursively(_root, data);
        private bool ContainsRecursively(Node<T> node, T data)
        {
            if (node == null) return false;
            if (node.CompareTo(data) == 0) return true;
            if (node.CompareTo(data) > 0) return ContainsRecursively(node.Left, data);
            return ContainsRecursively(node.Right, data);
        }
        public List<T> InOrderTraversal()
        {
            List<T> list = new();
            InOrderTraversalRecursively(_root, list);
            return list;
        }
        private void InOrderTraversalRecursively(Node<T> node, List<T> list)
        {
            if (node == null) return;
            InOrderTraversalRecursively(node.Left, list);
            list.Add(node.Data);
            InOrderTraversalRecursively(node.Right, list);
        }
        public List<T> PreOrderTraversal()
        {
            List<T> list = new();
            PreOrderTraversalRecursively(_root, list);
            return list;
        }
        private void PreOrderTraversalRecursively(Node<T> node, List<T> list)
        {
            if (node == null) return;
            list.Add(node.Data);
            PreOrderTraversalRecursively(node.Left, list);
            PreOrderTraversalRecursively(node.Right, list);
        }
        public List<T> PostOrderTraversal()
        {
            List<T> list = new();
            PostOrderTraversalRecursively(_root, list);
            return list;
        }
        private void PostOrderTraversalRecursively(Node<T> node, List<T> list)
        {
            if (node == null) return;
            PostOrderTraversalRecursively(node.Left, list);
            PostOrderTraversalRecursively(node.Right, list);
            list.Add(node.Data);
        }

        private T MinValue(Node<T> node)
        {
            T minValue = node.Data;
            while (node.Left != null)
            {
                minValue = node.Left.Data;
                node = node.Left;
            }
            return minValue;
        }
    }
}
