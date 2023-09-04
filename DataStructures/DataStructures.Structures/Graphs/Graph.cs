namespace DataStructures.Structures.Graphs
{
    public class Graph
    {
        private List<Node> _nodes;

        private readonly int[,] _matrix;

        internal List<Node> Nodes { get {
                return _nodes;
            } 
        }

        internal int[,] Matrix
        {
            get
            {
                return _matrix;
            }
        }

        public Graph(int size)
        {
            _matrix = new int[size,size];
            _nodes = new List<Node>();
        }

        public void AddNode(Node node)
        {
            _nodes.Add(node);
        }

        public void AddEdge(int src, int dst, int data = 1)
        {
            _matrix[src, dst] = data;
        }

        public void Search(ISearch search, int src)
        {
            search.Search(this, src);
        }
    }
 
}
