namespace _03MassEffect
{
    public class StarSystem : IShape
    {
        public StarSystem(string name, double x, double y)
        {
            this.Name = name;
            this.Dimensions = new double[2];
            this.Dimensions[0] = x;
            this.Dimensions[1] = y;
        }

        public string Name { get; set; }

        public double[] Dimensions { get; private set; }
    }
}
