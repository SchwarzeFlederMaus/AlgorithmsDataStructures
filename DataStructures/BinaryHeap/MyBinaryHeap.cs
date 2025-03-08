
namespace DataStructures.BinaryHeap
{
    public class MyBinaryHeap<T>
        where T : IComparable<T>
    {
        private Node<T>[] _heapArray;
        private int _size;
        private int _currentPosition = -1;

        public MyBinaryHeap(int size = 100)
        {
            _size = size;
            _heapArray = new Node<T>[size];
        }

        public void Insert(T data)
        {
            if (_currentPosition == _size - 1)
            {
                throw new InvalidOperationException("Heap is full");
            }

            var node = new Node<T>(data);
            _heapArray[++_currentPosition] = node;
            HeapifyUp(_currentPosition);
        }

        public T DeleteRoot()
        {
            if (_currentPosition == -1)
            {
                throw new InvalidOperationException("Heap is empty");
            }

            var root = _heapArray[0].Data;
            _heapArray[0] = _heapArray[_currentPosition--];
            HeapifyDown(0);
            return root;
        }

        private void HeapifyUp(int index)
        {
            var parentIndex = (index - 1) / 2;
            while (index > 0 && _heapArray[index].CompareTo(_heapArray[parentIndex].Data) > 0)
            {
                Swap(index, parentIndex);
                index = parentIndex;
                parentIndex = (index - 1) / 2;
            }
        }

        private void HeapifyDown(int index)
        {
            while (index <= _currentPosition)
            {
                var leftChildIndex = 2 * index + 1;
                var rightChildIndex = 2 * index + 2;
                var largestIndex = index;

                if (leftChildIndex <= _currentPosition && _heapArray[leftChildIndex].CompareTo(_heapArray[largestIndex].Data) > 0)
                {
                    largestIndex = leftChildIndex;
                }

                if (rightChildIndex <= _currentPosition && _heapArray[rightChildIndex].CompareTo(_heapArray[largestIndex].Data) > 0)
                {
                    largestIndex = rightChildIndex;
                }

                if (largestIndex == index)
                {
                    break;
                }

                Swap(index, largestIndex);
                index = largestIndex;
            }
        }

        private void Swap(int index1, int index2)
        {
            var temp = _heapArray[index1];
            _heapArray[index1] = _heapArray[index2];
            _heapArray[index2] = temp;
        }
    }
}
