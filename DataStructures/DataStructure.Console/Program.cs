// See https://aka.ms/new-console-template for more information
using DataStructures.Structures.Graphs;




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



