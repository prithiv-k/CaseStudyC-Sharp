using CaseStudy9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy9
{
    // 3. Write a LINQ query to sort products in ascending order by product code.
    class Problem3
    {
        static void Main()
        {
            Product product = new Product();
            var products = product.GetProducts();
            var result = products.OrderBy(pro => pro.ProCode);

            foreach (var prod in result)
            {
                Console.WriteLine($"{prod.ProCode}\t{prod.ProName}\t{prod.ProCategory}\t{prod.ProMrp}");
            }
        }
    }
}
