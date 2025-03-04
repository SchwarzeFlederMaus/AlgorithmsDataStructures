using DataStructures.BinarySearchTree;
using DataStructures.Dictionary;
using DataStructures.LinkedList;
using DataStructures.Queue;
using DataStructures.Set;
using DataStructures.Stack;
using System.Collections;

Console.WriteLine("Start is here");

var MyBinarySearchTree = new MyBinarySearchTree<int>();
MyBinarySearchTree.Add(5);
MyBinarySearchTree.Add(3);
MyBinarySearchTree.Add(8);
MyBinarySearchTree.Add(7);
MyBinarySearchTree.Add(4);
MyBinarySearchTree.Add(1);
MyBinarySearchTree.Add(6);
MyBinarySearchTree.Add(9);
MyBinarySearchTree.Add(2);

foreach (var item in MyBinarySearchTree.InOrderTraversal())
{
    Console.Write($"{item} ");
}
Console.WriteLine();
foreach (var item in MyBinarySearchTree.PreOrderTraversal())
{
    Console.Write($"{item} ");
}
Console.WriteLine();
foreach (var item in MyBinarySearchTree.PostOrderTraversal())
{
    Console.Write($"{item} ");
}
Console.WriteLine();

Console.WriteLine("End is here");
Console.ReadLine();