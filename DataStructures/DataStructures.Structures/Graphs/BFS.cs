namespace DataStructures.Structures.Graphs
{
    public class BFS : ISearch
    {
        public void Search(Graph graph, int src)
        {
            bool[] visited = new bool[graph.Matrix.GetLength(0)];

            Queue<int> queue = new Queue<int>();

            queue.Enqueue(src);
            visited[src] = true;

            while (queue.Count > 0)
            {
                src = queue.Dequeue();
                Console.WriteLine(string.Format($"{graph.Nodes[src].Data} = visited"));

                for (int i=0;i<graph.Matrix.GetLength(1); i++)
                {
                    if (graph.Matrix[src, i] > 0 && !visited[i])
                    {
                        queue.Enqueue(i);
                        visited[i] = true;
                    }
                }
            }
        }
    }
}
