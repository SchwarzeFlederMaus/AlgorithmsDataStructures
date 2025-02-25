using DataStructures.LinkedList;
using DataStructures.Stack;

Console.WriteLine("Start is here");

var myStack = new Stack<int>();
myStack.Push(1);
myStack.Push(2);
myStack.Push(3);
myStack.Push(4);
myStack.Push(5);

Console.WriteLine($"Stack Count: {myStack.Count}");
Console.WriteLine($"Stack Peek: {myStack.Peek()}");
myStack.Pop();
Console.WriteLine($"Stack Count: {myStack.Count}");
Console.WriteLine($"Stack Peek: {myStack.Peek()}");



Console.ReadLine();