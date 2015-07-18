namespace Orders
{
    #region UsingDirectives

    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    using Models;

    #endregion

    public class DataMapper
    {
        private readonly string categoriesFileName;

        private readonly string ordersFileName;

        private readonly string productsFileName;

        public DataMapper(string categoriesFileName, string productsFileName, string ordersFileName)
        {
            this.categoriesFileName = categoriesFileName;
            this.productsFileName = productsFileName;
            this.ordersFileName = ordersFileName;
        }

        public DataMapper()
            : this("../../Data/categories.txt", "../../Data/products.txt", "../../Data/orders.txt")
        {
        }

        public IEnumerable<Category> GetAllCategories()
        {
            var categories = this.ReadFileLines(this.categoriesFileName, true);
            return
                categories.Select(category => category.Split(','))
                    .Select(
                        category =>
                        new Category
                            {
                                Id = int.Parse(category[0]),
                                Name = category[1], 
                                Description = category[2]
                            });
        }

        public IEnumerable<Product> GetAllProducts()
        {
            var products = this.ReadFileLines(this.productsFileName, true);
            return
                products.Select(product => product.Split(','))
                    .Select(
                        product =>
                        new Product
                            {
                                Id = int.Parse(product[0]),
                                Name = product[1],
                                CategoryId = int.Parse(product[2]),
                                UnitPrice = decimal.Parse(product[3]),
                                UnitsInStock = int.Parse(product[4])
                            });
        }

        public IEnumerable<Order> GetAllOrders()
        {
            var orders = this.ReadFileLines(this.ordersFileName, true);
            return
                orders.Select(order => order.Split(','))
                    .Select(
                        order =>
                        new Order
                            {
                                Id = int.Parse(order[0]),
                                ProductId = int.Parse(order[1]),
                                Quantity = int.Parse(order[2]),
                                Discount = decimal.Parse(order[3])
                            });
        }

        private List<string> ReadFileLines(string filename, bool hasHeader)
        {
            var allLines = new List<string>();
            using (var reader = new StreamReader(filename))
            {
                if (hasHeader)
                {
                    reader.ReadLine();
                }

                string currentLine = reader.ReadLine();
                while (currentLine != null)
                {
                    allLines.Add(currentLine);
                    currentLine = reader.ReadLine();
                }
            }

            return allLines;
        }
    }
}