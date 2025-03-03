using DataStructures.Dictionary;
using DataStructures.LinkedList;
using DataStructures.Queue;
using DataStructures.Set;
using DataStructures.Stack;
using System.Collections;

Console.WriteLine("Start is here");

var myDictionary = new MyDictionary<int, string>();
myDictionary.Add(1, "One");
myDictionary.Add(2, "Two");
myDictionary.Add(3, "Three");
myDictionary.Add(4, "Four");
myDictionary.Add(5, "Five");
myDictionary.Add(6, "Six");

Console.WriteLine("MyDictionary:");
foreach (var item in myDictionary)
{
    Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
}

Console.WriteLine("End is here");
Console.ReadLine();