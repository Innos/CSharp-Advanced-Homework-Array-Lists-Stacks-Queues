namespace _01ShortestPathInAMatrix
{
    using System;
    using System.Collections.Generic;

    public class Node : IComparable<Node>
    {
        public Node(int value, int distance)
        {
            this.Value = value;
            this.Edges = new List<Edge>();
            this.Distance = distance;
        }

        public int Value { get; set; }

        public int Distance { get; set; }

        public List<Edge> Edges { get; private set; }

        public int CompareTo(Node other)
        {
            int result = this.Distance.CompareTo(other.Distance);
            if (result == 0)
            {
                result = this.Value.CompareTo(other.Value);
            }
            return result;
        }
    }
}
