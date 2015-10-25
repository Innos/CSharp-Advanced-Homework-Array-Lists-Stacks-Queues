
namespace _01DistanceBetweenVertices
{
    using System.Collections.Generic;

    public class Node
    {
        public Node(int value)
        {
            this.Value = value;
            this.Children = new List<Node>();
            this.Parent = null;
            this.Distance = -1;
        }

        public int Value { get; set; }

        public int Distance { get; set; }

        public List<Node> Children { get; set; }

        public Node Parent { get; set; }
    }
}
