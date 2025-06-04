using CaseStudy9;
using System;
using System.Linq;

namespace CaseStudy9
{
    class Problem10
    {
        // 10. Write a LINQ query to display count of total products.
        static void Main()
        {
            Product product = new Product();
            var products = product.GetProducts();

            int totalCount = products.Count();

            Console.WriteLine($"Total number of products: {totalCount}");
        }
    }
}
