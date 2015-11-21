namespace _01ShortestPathInAMatrix
{
    public class Edge
    {
        public Edge(int parent, int child, int distance)
        {
            this.Parent = parent;
            this.Child = child;
            this.Distance = distance;
        }

        public int Parent { get; set; }
        public int Child { get; set; }
        public int Distance { get; set; }
    }
}
