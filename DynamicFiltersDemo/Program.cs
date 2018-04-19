using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFramework.DynamicFilters;

namespace DynamicFiltersDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbcontext = new SSoTestEntities();
            //dbcontext.DisableFilter("ProductsFilter");
            var res = dbcontext.Products.Count();
            Console.WriteLine(res);
            Console.WriteLine("禁用过滤后：");
            dbcontext.DisableFilter("ProductsFilter");
            var res2 = dbcontext.Products.Count();
            Console.WriteLine(res2);
            Console.ReadLine();
        }
    }
}
