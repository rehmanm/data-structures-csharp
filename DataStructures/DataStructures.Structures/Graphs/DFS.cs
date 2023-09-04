namespace DataStructures.Structures.Graphs
{
    public class DFS : ISearch
    {
        public void Search(Graph graph, int src)
        {
            bool[] visited = new bool[graph.Matrix.GetLength(0)];
            DFSHelper(graph, src, visited);
        }

        private void DFSHelper(Graph graph, int src, bool[] visited)
        {
            if (visited[src])
            {
                return;
            }
            else
            {
                visited[src] = true;
                Console.WriteLine(graph.Nodes[src].Data + " = visited");
            }

            for (int i = 0; i < graph.Matrix.GetLength(0); i++)
            {
                if (graph.Matrix[src, i] > 0)
                {
                    DFSHelper(graph, i, visited);
                }
            }
        } 
    }
}
