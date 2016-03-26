using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03CollectionOfProducts
{
    class CollectionOfProductsTest
    {
        static void Main(string[] args)
        {
            var a = new ProductCollection();
            a.Add(new Product(109, "test2", "sup5", 8));
            a.Add(new Product(1, "test2", "sup1", 10));
            a.Add(new Product(3, "test2", "sup2", 3));
            a.Add(new Product(15, "test3", "sup1", 15));
            a.Add(new Product(2, "test4", "sup5", 3));
            a.Add(new Product(20, "test2", "sup5", 5000));
            a.Add(new Product(22, "test2", "sup5", 1000));
            a.Add(new Product(21, "test5", "sup5", 3));

            //overwriting an element
            a.Add(new Product(22, "test2", "sup20", 5000));

            foreach (var product in a.FindProductsByPriceRange(8, 10))
            {
                Console.WriteLine(product);
            }

            Console.WriteLine();

            foreach (var product in a.FindProductsBySupplierAndPrice("sup1", 10))
            {
                Console.WriteLine(product);
            }

            Console.WriteLine();

            foreach (var product in a.FindProductsBySupplierAndPriceRange("sup5", 3, 20))
            {
                Console.WriteLine(product);
            }

            Console.WriteLine();

            foreach (var product in a.FindProductsByTitleAndPriceRange("test2", 8, 1000))
            {
                Console.WriteLine(product);
            }

            Console.WriteLine();

            foreach (var product in a.FindProductsByTitleAndPrice("test2", 5000))
            {
                Console.WriteLine(product);
            }

            Console.WriteLine();

            foreach (var product in a.FindProductsByTitle("test2"))
            {
                Console.WriteLine(product);
            }

            Console.WriteLine();

            foreach (var product in a.FindProductsByPriceRange(3, 3))
            {
                Console.WriteLine(product);
            }
        }
    }
}
