using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithLamba.Tests
{
    public class TestSumAverage : ITest
    {
        public void Test()
        {
            var orders = DataBase.DataBase.GetOrders();

            var sumTotalValues = orders.Sum( x => x.TotalValue);
            var avergeTotalValues = orders.Average( x => x.TotalValue);
            Console.WriteLine("Sum total values: " + sumTotalValues.ToString("c2"));
            Console.WriteLine("Average total values: " + avergeTotalValues.ToString("c2"));
            Console.WriteLine("Count total orders count: " + orders.Count());
            Console.WriteLine("Average total values: " + (sumTotalValues / orders.Count()).ToString("c2"));

            var fisrCustomerOrders = orders.Where(x => x.CustomerId == 0);
            Console.WriteLine("Fist Customer Sum Total Values:" + fisrCustomerOrders.Sum(x => x.TotalValue).ToString("c2"));
            Console.WriteLine("Fist Customer AVG Total Values:" + fisrCustomerOrders.Average(x => x.TotalValue).ToString("c2"));



        }
    } 
}
