// See https://aka.ms/new-console-template for more information
using DataStructures.Structures.Graphs;
using DataStructures.Structures.Misc;
using DataStructures.Structures.SortAlgorithm;

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


Console.WriteLine("===========Quick sort==========");

int[] array = { 8, 2, 5, 3, 9, 4, 7, 6, 1 };

ISortStrategy sortStrategy = new QuickSort();

sortStrategy.Sort(array);

for (int i = 0; i< array.Length; i++)
{
    Console.Write($"{array[i]} ");
}
Console.WriteLine();





