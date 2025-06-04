using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy9
{
    class Problem12
    {
        static void Main()
        {
            //12.Write a LINQ query to display Max price.
            Product product = new Product();    
            var products=product.GetProducts();
            var res = products.Max(pro => pro.ProMrp);
            Console.WriteLine($"The Max Price Amounf all products is {res}");
        }
    }
}
