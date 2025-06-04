using System;
using System.Linq;
using System.Collections.Generic;

namespace CaseStudy9
{
    class Problem14
    {
        static void Main()
        {
            // 14. Write a LINQ query to display whether all products are below MRP Rs.30 or not.
            Product product = new Product();
            var products = product.GetProducts();

            bool areAllBelow30 = products.All(p => p.ProMrp < 30);

            if (areAllBelow30)
            {
                Console.WriteLine("All products are below Rs.30.");
            }
            else
            {
                Console.WriteLine("Not all products are below Rs.30.");
            }
        }
    }
}
