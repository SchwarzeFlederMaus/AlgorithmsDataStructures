using DataStructures.LinkedList;
using DataStructures.Queue;
using DataStructures.Stack;

Console.WriteLine("Start is here");

var queueOnArray = new QueueOnArray<int>(5);
queueOnArray.Enqueue(1);
queueOnArray.Enqueue(2);
queueOnArray.Enqueue(3);
queueOnArray.Enqueue(4);
queueOnArray.Enqueue(5);

Console.WriteLine(queueOnArray.Dequeue());
Console.WriteLine(queueOnArray.Dequeue());
Console.WriteLine(queueOnArray.Dequeue());
Console.WriteLine(queueOnArray.Dequeue());
Console.WriteLine(queueOnArray.Dequeue());


Console.ReadLine();