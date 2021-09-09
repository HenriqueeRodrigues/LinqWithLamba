using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithLamba.Tests
{
    public class TestGroupBy : ITest
    {
        public void Test()
        {
            var orders = DataBase.DataBase.GetOrders();

            var totalOrders = orders.GroupBy(x => x.CustomerId)
                .Select(y =>
                new
                {
                    CustomerId = y.Key,
                    Totalvalue = y.Sum(x => x.TotalValue),
                    AverageValue = y.Average(x => x.TotalValue),
                    CountOrders = orders.Count()
                });

            foreach(var totalOrder in totalOrders)
            {
                Console.WriteLine("Customer" + totalOrder.CustomerId + " - totalValue: " + totalOrder.Totalvalue.ToString("c2")+
                    " - Average value: " + totalOrder.AverageValue.ToString("c2") + " - Count Orders" + totalOrder.CountOrders);
            }
        }
    } 
}
