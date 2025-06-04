using CaseStudy9;
using System;
using System.Linq;

namespace CaseStudy9
{
    class Problem9
    {
        // 9. Write a LINQ query to display product detail with highest price in FMCG category.
        static void Main()
        {
            Product product = new Product();
            var products = product.GetProducts();

            var result = products
                         .Where(p => p.ProCategory == "FMCG")
                         .OrderByDescending(p => p.ProMrp)
                         .FirstOrDefault();

            if (result != null)
            {
                Console.WriteLine($"Highest Priced FMCG Product:");
                Console.WriteLine($"{result.ProCode}\t{result.ProName}\t{result.ProCategory}\t{result.ProMrp}");
            }
            else
            {
                Console.WriteLine("No products found in FMCG category.");
            }
        }
    }
}
