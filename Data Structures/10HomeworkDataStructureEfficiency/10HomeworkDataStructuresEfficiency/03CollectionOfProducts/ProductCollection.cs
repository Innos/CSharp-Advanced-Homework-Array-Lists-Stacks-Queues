namespace _03CollectionOfProducts
{
    using System.Collections.Generic;
    using System.Linq;

    using Wintellect.PowerCollections;

    public class ProductCollection
    {
        private Dictionary<int, Product> productsById;

        private OrderedMultiDictionary<double, Product> productsByPrice;

        private Dictionary<string, SortedSet<Product>> productsByTitle;

        private Dictionary<string, SortedSet<Product>> productsByTitleAndPrice;

        private Dictionary<string, OrderedDictionary<double, SortedSet<Product>>> productsByTitleAndPriceRange;

        private Dictionary<string, SortedSet<Product>> productsBySupplierAndPrice;

        private Dictionary<string, OrderedDictionary<double, SortedSet<Product>>> productsBySupplierAndPriceRange;

        public ProductCollection()
        {
            this.productsById = new Dictionary<int, Product>();
            this.productsByPrice = new OrderedMultiDictionary<double, Product>(false);
            this.productsByTitle = new Dictionary<string, SortedSet<Product>>();
            this.productsByTitleAndPrice = new Dictionary<string, SortedSet<Product>>();
            this.productsByTitleAndPriceRange = new Dictionary<string, OrderedDictionary<double, SortedSet<Product>>>();
            this.productsBySupplierAndPrice = new Dictionary<string, SortedSet<Product>>();
            this.productsBySupplierAndPriceRange = new Dictionary<string, OrderedDictionary<double, SortedSet<Product>>>();
        }

        public void Add(Product product)
        {
            this.Remove(product.Id);
            this.AddNonexistant(product);
        }

        public bool Remove(int id)
        {
            if (this.productsById.ContainsKey(id))
            {
                var prevProduct = this.productsById[id];
                var prevTitleAndPrice = prevProduct.Title + "|~!~|" + prevProduct.Price;
                var prevSupplierAndPrice = prevProduct.Supplier + "~!|!~" + prevProduct.Price;
                this.productsByPrice[prevProduct.Price].Remove(prevProduct);
                this.productsByTitle[prevProduct.Title].Remove(prevProduct);
                this.productsByTitleAndPrice[prevTitleAndPrice].Remove(prevProduct);
                this.productsByTitleAndPriceRange[prevProduct.Title][prevProduct.Price].Remove(prevProduct);
                this.productsBySupplierAndPrice[prevSupplierAndPrice].Remove(prevProduct);
                this.productsBySupplierAndPriceRange[prevProduct.Supplier][prevProduct.Price].Remove(prevProduct);
                this.productsById.Remove(prevProduct.Id);
                return true;
            }

            return false;
        }

        // why desire the results sorted by id, the fastest we can do is create a new sorted set with the results
        // speed for that is ~O(m log m) where m is the number of products in the result
        public IEnumerable<Product> FindProductsByPriceRange(double priceFrom, double priceTo)
        {
            var items = this.productsByPrice.Range(priceFrom, true, priceTo, true).SelectMany(x => x.Value);
            return new SortedSet<Product>(items);
        }

        public IEnumerable<Product> FindProductsByTitle(string title)
        {
            if (!this.productsByTitle.ContainsKey(title))
            {
                return Enumerable.Empty<Product>();
            }

            return this.productsByTitle[title];
        }

        public IEnumerable<Product> FindProductsByTitleAndPrice(string title, double price)
        {
            var titleAndPrice = title + "|~!~|" + price;
            if (!this.productsByTitleAndPrice.ContainsKey(titleAndPrice))
            {
                return Enumerable.Empty<Product>();
            }

            return this.productsByTitleAndPrice[titleAndPrice];
        }

        public IEnumerable<Product> FindProductsByTitleAndPriceRange(string title, double priceFrom, double priceTo)
        {
            if (!this.productsByTitleAndPriceRange.ContainsKey(title))
            {
                return Enumerable.Empty<Product>();
            }

            var items =
                this.productsByTitleAndPriceRange[title].Range(priceFrom, true, priceTo, true).SelectMany(x => x.Value);

            return new SortedSet<Product>(items);
        }

        public IEnumerable<Product> FindProductsBySupplierAndPrice(string supplier, double price)
        {
            var supplierAndPrice = supplier + "~!|!~" + price;
            if (!this.productsBySupplierAndPrice.ContainsKey(supplier))
            {
                return Enumerable.Empty<Product>();
            }

            return this.productsBySupplierAndPrice[supplierAndPrice];
        }

        public IEnumerable<Product> FindProductsBySupplierAndPriceRange(string supplier, double priceFrom, double priceTo)
        {
            if (!this.productsBySupplierAndPriceRange.ContainsKey(supplier))
            {
                return Enumerable.Empty<Product>();
            }

            var items =
                this.productsBySupplierAndPriceRange[supplier].Range(priceFrom, true, priceTo, true).SelectMany(x => x.Value);

            return new SortedSet<Product>(items);
        }

        private void AddNonexistant(Product product)
        {
            var titleAndPrice = product.Title + "|~!~|" + product.Price;
            var supplierAndPrice = product.Supplier + "~!|!~" + product.Price;

            this.productsById.Add(product.Id, product);

            //price
            this.productsByPrice.Add(product.Price, product);

            //title
            this.productsByTitle.AppendValueToKey(product.Title, product);

            //title and price
            this.productsByTitleAndPrice.AppendValueToKey(titleAndPrice, product);

            //title and price range
            if (!this.productsByTitleAndPriceRange.ContainsKey(product.Title))
            {
                this.productsByTitleAndPriceRange.Add(
                    product.Title,
                    new OrderedDictionary<double, SortedSet<Product>>());
            }

            this.productsByTitleAndPriceRange[product.Title].AppendValueToKey(product.Price, product);

            //suplier and price
            this.productsBySupplierAndPrice.AppendValueToKey(supplierAndPrice, product);

            //suplier and price range
            if (!this.productsBySupplierAndPriceRange.ContainsKey(product.Supplier))
            {
                this.productsBySupplierAndPriceRange.Add(
                    product.Supplier,
                    new OrderedDictionary<double, SortedSet<Product>>());
            }

            this.productsBySupplierAndPriceRange[product.Supplier].AppendValueToKey(product.Price, product);
        }
    }
}
