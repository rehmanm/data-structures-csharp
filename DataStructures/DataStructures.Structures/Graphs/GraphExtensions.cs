namespace DataStructures.Structures.Graphs
{
    public static class GraphExtensions
    {
        public static void Print(this Graph graph)
        {
            Console.Write("\t");

            foreach (Node node in graph.Nodes)
            {
                Console.Write(node.Data + "\t");
            }
            Console.WriteLine();

            for (int i = 0; i < graph.Matrix.GetLength(0); i++)
            {
                Console.Write(graph.Nodes[i].Data + "\t");

                for (int j = 0; j < graph.Matrix.GetLength(1); j++)
                {
                    Console.Write(graph.Matrix[i, j].ToString() + "\t");
                }
                Console.WriteLine();

            }
            Console.WriteLine();
        }
    }
}
