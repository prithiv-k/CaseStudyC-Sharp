
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy9
{
    class Problem4
    {
        static void Main()
        {
            //4. Write a LINQ query to sort products in ascending order by product Category.
            Product product = new Product();
            var products = product.GetProducts();
            var result = products.OrderBy(pro => pro.ProCategory);

            foreach (var prod in result)
            {
                Console.WriteLine($"{prod.ProCode}\t{prod.ProName}\t{prod.ProCategory}\t{prod.ProMrp}");
            }
        }
    }
}
