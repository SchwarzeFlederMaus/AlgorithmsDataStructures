using DataStructures.LinkedList;

Console.WriteLine("Start is here");



var myLinkedList = new MyLinkedList<int>();
myLinkedList.Add(1);
myLinkedList.Add(2);
myLinkedList.Add(3);
myLinkedList.Add(4);
myLinkedList.Add(5);

foreach (var item in myLinkedList)
{
    Console.Write(item + " ");
}
Console.WriteLine();

myLinkedList.Remove(1);
myLinkedList.Remove(3);
myLinkedList.Remove(5);
myLinkedList.Remove(7);
myLinkedList.AppendFirst(0);

foreach (var item in myLinkedList)
{
    Console.Write(item + " ");
}
Console.WriteLine();

Console.WriteLine(myLinkedList.Contains(0));
Console.WriteLine(myLinkedList.Contains(7));


Console.ReadLine();