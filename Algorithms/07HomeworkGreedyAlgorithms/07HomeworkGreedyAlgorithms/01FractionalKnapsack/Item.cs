namespace _01FractionalKnapsack
{
    using System;

    public class Item : IComparable<Item>
    {
        public Item(int price, int weight)
        {
            this.Price = price;
            this.Weight = weight;
            this.CostEfficency = price / (double)weight;
        }

        public int Price { get; set; }

        public int Weight { get; set; }

        public double CostEfficency { get; set; }

        public int CompareTo(Item other)
        {
            return this.CostEfficency.CompareTo(other.CostEfficency);
        }
    }
}
