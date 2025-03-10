﻿
namespace DataStructures.Queue
{
    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; }

        public Node(T data)
        {
            Data = data;
        }

        public override string ToString() => Data.ToString();
    }
}
