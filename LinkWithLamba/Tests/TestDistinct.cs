using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithLamba.Tests
{
    public class TestDistinct : ITest
    {
        public void Test()
        {
            var orders = DataBase.DataBase.GetOrders();

            //foreach(var order in orders)
            //{
            //    Console.WriteLine(order.CustomerId);
            //}

            var customerIds = orders.Select(x => x.CustomerId).Distinct();

            foreach (var customerId in customerIds)
            {
                Console.WriteLine(customerId);
            }
        }
    } 
}
