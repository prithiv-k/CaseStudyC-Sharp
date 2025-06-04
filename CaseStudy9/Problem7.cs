using CaseStudy9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy9
{
    class Problem7
    {
        static void Main()
        {
            // 7. Write a LINQ query to display products grouped by product Category.
            Product product = new Product();
            var Products = product.GetProducts();

            var result = Products.GroupBy(pro => pro.ProCategory);

            foreach (var group in result)
            {
                Console.WriteLine($"Category: {group.Key}");
                foreach (var prod in group)
                {
                    Console.WriteLine($"\t{prod.ProCode}\t{prod.ProName}\t{prod.ProMrp}");
                }
            }
        }
    }
}
