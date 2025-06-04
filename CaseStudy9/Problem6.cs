using CaseStudy9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy9
{
    class Problem6
    {
        //6.Write a LINQ query to sort products in descending order by product Mrp.
        static void Main()
        {
            Product product = new Product();
            var products = product.GetProducts();
            var result = products.OrderByDescending(pro=>pro.ProMrp);

            foreach (var prod in result)
            {
                Console.WriteLine($"{prod.ProCode}\t{prod.ProName}\t{prod.ProCategory}\t{prod.ProMrp}");
            }
        }

    }
}
