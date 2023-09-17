// See https://aka.ms/new-console-template for more information
using DataStructures.Structures.Graphs;
using DataStructures.Structures.Misc;
using DataStructures.Structures.SortAlgorithm;
using System;

Graph graph = new Graph(5);

graph.AddNode(new Node("A"));
graph.AddNode(new Node("B"));
graph.AddNode(new Node("C"));
graph.AddNode(new Node("D"));
graph.AddNode(new Node("E"));

graph.AddEdge(0, 1);
graph.AddEdge(1, 2);
graph.AddEdge(1, 4);
graph.AddEdge(2, 3);
graph.AddEdge(2, 4);
graph.AddEdge(4, 0);
graph.AddEdge(4, 2);

graph.Print();

Console.WriteLine("===========BFS==========");
graph.Search(new DFS(), 0);
Console.WriteLine();
Console.WriteLine("===========DFS==========");
graph.Search(new BFS(), 0);

Console.WriteLine("===========Dictionary==========");
Random random = new Random();

var dictionaryTest = new DictionaryTest();
var totalRecords = 100000;
for (int i=0; i< totalRecords; i++)
{
    dictionaryTest.Add(i);
}

for (int i = 0; i < totalRecords; i++)
{
    dictionaryTest.Add(random.Next(totalRecords));
}

var value = 0;
var keyToFind = random.Next(totalRecords);
var watch = new System.Diagnostics.Stopwatch();
watch.Start();
value = dictionaryTest.GetElementAt(keyToFind);
watch.Stop();

Console.WriteLine(string.Format($"{ keyToFind} - {watch.ElapsedMilliseconds} - {value}"));
watch.Reset();
watch.Start();
value = dictionaryTest.GetValue(keyToFind);
watch.Stop();

Console.WriteLine(string.Format($"{keyToFind} - {watch.ElapsedMilliseconds} - {value}"));

Console.WriteLine("===========HashTable==========");
var hashTableTest = new HashTableTest();

for (int i = 0; i < totalRecords; i++)
{
    hashTableTest.Add(i);
}
watch.Reset();
watch.Start();
var valueObj = hashTableTest.GetValue((object) keyToFind);
watch.Stop();

Console.WriteLine(string.Format($"{keyToFind} - {watch.ElapsedMilliseconds} - {valueObj}"));

Random randNum = new Random();
int Min = 0, Max = 100;

Console.WriteLine("===========Quick sort==========");

int[] array = Enumerable
    .Repeat(0, 10)
    .Select(i => randNum.Next(Min, Max))
    .ToArray();

ISortStrategy sortStrategy = new QuickSort();

sortStrategy.Sort(array);

Helper<int>.PrintArray(array);

Console.WriteLine("===========Merget sort==========");

int[] array1 = Enumerable
    .Repeat(0, 10)
    .Select(i => randNum.Next(Min, Max))
    .ToArray();

ISortStrategy sortStrategy1 = new MergeSort();

sortStrategy1.Sort(array1);

Helper<int>.PrintArray(array1);

int[] array2 = Enumerable
    .Repeat(0, 10)
    .Select(i => randNum.Next(Min, Max))
    .ToArray();

Console.WriteLine("===========Find Nth Item==========");
Console.WriteLine($"3 Largest number in array is {FindNthItem.LargestItem(array2, 3)}");
Console.WriteLine($"4 Smallest number in array is {FindNthItem.SmallestItem(array2, 4)}");
sortStrategy1.Sort(array2);

Helper<int>.PrintArray(array2);




