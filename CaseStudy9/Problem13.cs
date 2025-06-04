using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy9
{
    class Problem13
    {
        static void Main()
        {
            //13.Write a LINQ query to display Min price.
            Product product = new Product();
            var products = product.GetProducts();
            var res = products.Min(pro => pro.ProMrp);
            Console.WriteLine($"The Min Price Amoung all products is {res}");
        }
    }
}
