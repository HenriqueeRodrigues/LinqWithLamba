using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithLamba.Tests
{
    public class TestCountMaxMin : ITest
    {
        public void Test()
        {
            var orders = DataBase.DataBase.GetOrders();

            //var orderCount = orders.Count();
            //Console.WriteLine("Orders count: " + orderCount);


            //var orderMax = orders.Max( x => x.TotalValue);
            //Console.WriteLine("Orders max Total Value: " + orderMax);

            //var orderMin = orders.Min( x => x.TotalValue);
            //Console.WriteLine("Orders Min Total Value: " + orderMin);

            var firstCustomerOrders = orders.Where(x => x.Id == 45);
            Console.WriteLine("FirstCustomerOrders count: " + firstCustomerOrders.Count());
            Console.WriteLine("FirstCustomerOrders Max total Value: " + firstCustomerOrders.Max( x => x.TotalValue));
            Console.WriteLine("FirstCustomerOrders Min total Value: " + firstCustomerOrders.Min( x=> x.TotalValue));
        }
    } 
}
