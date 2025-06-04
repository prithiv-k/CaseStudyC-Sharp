using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CaseStudy9;
using System.Threading.Tasks;

namespace CaseStudy9
{
    class Problem11
    {
        static void Main()
        {
            //11. Write a LINQ query to display count of total products with category FMCG.
            Product product = new Product();
            var products = product.GetProducts();
            var result=products.Count(pro=>pro.ProCategory=="FMCG");
            Console.WriteLine($"Total number of Product with FMCG Category is { result}");
        }
    }
}
