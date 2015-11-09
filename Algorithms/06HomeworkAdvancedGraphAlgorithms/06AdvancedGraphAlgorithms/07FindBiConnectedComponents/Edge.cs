namespace _07FindBiConnectedComponents
{
    public class Edge
    {
        public Edge(int parent, int child)
        {
            this.Parent = parent;
            this.Child = child;
        }

        public int Parent { get; set; }

        public int Child { get; set; }
    }
}
