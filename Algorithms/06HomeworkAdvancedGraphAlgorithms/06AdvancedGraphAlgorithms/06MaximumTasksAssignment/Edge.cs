namespace _06MaximumTasksAssignment
{
    public class Edge
    {
        public Edge(string parent, string child)
        {
            this.Parent = parent;
            this.Child = child;
        }

        public string Parent { get; set; }

        public string Child { get; set; }

        public bool Used { get; set; }
    }
}
