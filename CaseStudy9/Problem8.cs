using CaseStudy9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy9
{
    class Problem8
    {
        //8. Write a LINQ query to display products group by product Mrp.
        static void Main()
        {
            Product product = new Product();
            var products = product.GetProducts();
            var result = products.GroupBy(pro => pro.ProMrp);
            foreach (var group in result)
            {
                Console.WriteLine($"MRP:{group.Key}");
                foreach (var item in group)
                {
                    Console.WriteLine($"\t{item.ProCode}\t{item.ProName}\t{item.ProCategory}");
                }
            }
        }
    }
}
