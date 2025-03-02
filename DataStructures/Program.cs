using DataStructures.LinkedList;
using DataStructures.Queue;
using DataStructures.Set;
using DataStructures.Stack;
using System.Collections;

Console.WriteLine("Start is here");


var setA = new SetOnList<int>(new[]{ 1, 2, 3, 7, 6});
var setB = new SetOnList<int>(new[]{ 7, 6, 9, 12, 15});
var setC = new SetOnList<int>(new[] { 9, 12 });

Console.WriteLine("Set A:");
foreach (var item in setA) Console.Write($"{item} ");
Console.WriteLine();
Console.WriteLine("Set B:");
foreach (var item in setB) Console.Write($"{item} ");
Console.WriteLine();
Console.WriteLine("Set C:");
foreach (var item in setC) Console.Write($"{item} ");
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Union:");
var union = setA.UnionWith(setB);
foreach (var item in union) Console.Write($"{item} ");
Console.WriteLine();

Console.WriteLine("Intersection:");
var intersection = setA.IntersectWith(setB);
foreach (var item in intersection) Console.Write($"{item} ");
Console.WriteLine();

Console.WriteLine("Difference For A:");
var differenceA = setA.DifferenceWith(setB);
foreach (var item in differenceA) Console.Write($"{item} ");
Console.WriteLine();

Console.WriteLine("Difference For B:");
var differenceB = setB.DifferenceWith(setA);
foreach (var item in differenceB) Console.Write($"{item} ");
Console.WriteLine();

Console.WriteLine("Is C Subset B:");
Console.WriteLine(setC.IsSubset(setB));

Console.WriteLine("Is B Subset C:");
Console.WriteLine(setB.IsSubset(setC));

Console.WriteLine("SymetricDifference:");
var symetricDifference = setA.SymmetricDifferenceWith(setB);
foreach (var item in symetricDifference) Console.Write($"{item} ");
Console.WriteLine();

Console.WriteLine("End is here");
Console.ReadLine();