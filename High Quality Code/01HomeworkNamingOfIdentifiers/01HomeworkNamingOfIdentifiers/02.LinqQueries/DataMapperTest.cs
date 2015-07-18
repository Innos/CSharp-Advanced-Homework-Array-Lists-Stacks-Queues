namespace Orders
{
    #region

    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Threading;

    using Orders.Models;

    #endregion

    internal class DataMapperTest
    {
        private static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            var dataMapper = new DataMapper();
            var dataMapperCategories = dataMapper.GetAllCategories();
            var dataMapperProducts = dataMapper.GetAllProducts();
            var dataMapperOrders = dataMapper.GetAllOrders();

            // Names of the 5 most expensive products
            var mostExpensiveProducts = GetMostExpensiveProducts(dataMapperProducts);
            // Number of products in each category
            var numberOfProducts = GetNumberOfProductsInEachCategory(dataMapperProducts, dataMapperCategories);
            // The 5 top products (by order quantity)
            var topProducts = GetTopProductsByQuantity(dataMapperOrders, dataMapperProducts);
            // The most profitable category
            var mostProfitableCategory = GetMostProfitableCategory(dataMapperOrders, dataMapperProducts, dataMapperCategories);


            //Printing
            Console.WriteLine(string.Join(Environment.NewLine, mostExpensiveProducts));
            Console.WriteLine(new string('-', 10));
            foreach (var item in numberOfProducts)
            {
                Console.WriteLine("{0}: {1}", item.Key, item.Value);
            }
            Console.WriteLine(new string('-', 10));
            foreach (var item in topProducts)
            {
                Console.WriteLine("{0}: {1}", item.Key, item.Value);
            }
            Console.WriteLine(new string('-', 10));
            Console.WriteLine("{0}: {1}", mostProfitableCategory.Key, mostProfitableCategory.Value);



        }

        private static KeyValuePair<string, decimal> GetMostProfitableCategory(IEnumerable<Order> dataMapperOrders, IEnumerable<Product> dataMapperProducts, IEnumerable<Category> dataMapperCategories)
        {
            return dataMapperOrders.GroupBy(o => o.ProductId)
                .Select(
                    g =>
                    new
                        {
                            dataMapperProducts.First(product => product.Id == g.Key).CategoryId,
                            price = dataMapperProducts.First(product => product.Id == g.Key).UnitPrice,
                            quantity = g.Sum(product => product.Quantity)
                        })
                .GroupBy(gg => gg.CategoryId)
                .Select(
                    group =>
                    new
                        {
                            category_name = dataMapperCategories.First(category => category.Id == @group.Key).Name,
                            total_quantity = @group.Sum(g => g.quantity * g.price)
                        })
                .OrderByDescending(g => g.total_quantity)
                .ToDictionary(x => x.category_name, y => y.total_quantity)
                .First();
        }

        private static Dictionary<string, int> GetTopProductsByQuantity(IEnumerable<Order> dataMapperOrders, IEnumerable<Product> dataMapperProducts)
        {
            return dataMapperOrders.GroupBy(order => order.ProductId)
                .Select(
                    group =>
                    new
                        {
                            Product = dataMapperProducts.First(product => product.Id == @group.Key).Name,
                            Quantities = @group.Sum(grpgrp => grpgrp.Quantity)
                        })
                .OrderByDescending(q => q.Quantities)
                .Take(5)
                .ToDictionary(x => x.Product, y => y.Quantities);
        }

        private static Dictionary<string, int> GetNumberOfProductsInEachCategory(IEnumerable<Product> dataMapperProducts, IEnumerable<Category> dataMapperCategories)
        {
            return dataMapperProducts.GroupBy(product => product.CategoryId)
                .Select(group => new { Category = dataMapperCategories.First(category => category.Id == @group.Key).Name, Count = @group.Count() })
                .ToDictionary(x => x.Category, y => y.Count);
        }

        private static IEnumerable<string> GetMostExpensiveProducts(IEnumerable<Product> dataMapperProducts)
        {
            return dataMapperProducts.OrderByDescending(product => product.UnitPrice).Take(5).Select(product => product.Name);

        }
    }
}