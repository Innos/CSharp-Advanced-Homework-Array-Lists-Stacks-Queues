namespace _01FractionalKnapsack
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FractionalKnapsack
    {
        public static void Main(string[] args)
        {
            double capacity = double.Parse(Console.ReadLine().Substring(10));
            int items = int.Parse(Console.ReadLine().Substring(7));
            double totalPrice = 0;
            List<Item> itemsByCostEfficency = new List<Item>();

            for (int i = 0; i < items; i++)
            {
                string[] parameters = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                int price = int.Parse(parameters[0]);
                int weight = int.Parse(parameters[1]);
                Item newItem = new Item(price, weight);
                itemsByCostEfficency.Add(newItem);
            }

            itemsByCostEfficency = itemsByCostEfficency.OrderByDescending(x => x.CostEfficency).ToList();
            while (capacity > 0)
            {
                Item item = itemsByCostEfficency[0];
                if (capacity - item.Weight >= 0)
                {
                    capacity -= item.Weight;
                    totalPrice += item.Price;
                    Console.WriteLine("Take 100% of item with price {0:0.00} and weight {1:0.00}", item.Price, item.Weight);
                }
                else if (capacity - item.Weight < 0)
                {
                    double percentage = capacity / item.Weight;
                    capacity -= item.Weight;
                    totalPrice += percentage * item.Price;
                    percentage = percentage * 100;
                    Console.WriteLine("Take {0:0.00}% of item with price {1:0.00} and weight {2:0.00}", percentage, item.Price, item.Weight);
                }

                itemsByCostEfficency.Remove(item);
            }
            Console.WriteLine("Total price: {0:0.00}", totalPrice);
        }
    }
}
