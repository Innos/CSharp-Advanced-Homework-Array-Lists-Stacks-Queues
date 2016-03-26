namespace _03CollectionOfProducts
{
    using System;

    public class Product : IComparable<Product>
    {
        public Product(int id, string title, string supplier, double price)
        {
            this.Id = id;
            this.Title = title;
            this.Supplier = supplier;
            this.Price = price;
        }

        public int Id { get; private set; }

        public string Title { get; private set; }

        public string Supplier { get; private set; }

        public double Price { get; private set; }

        public int CompareTo(Product other)
        {
            return this.Id.CompareTo(other.Id);
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3:F2}", this.Id, this.Title, this.Supplier, this.Price);
        }
    }
}
