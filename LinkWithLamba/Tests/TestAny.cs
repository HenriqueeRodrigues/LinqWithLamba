using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithLamba.Tests
{
    public class TestAny : ITest
    {
        public void Test()
        {
            var customers = DataBase.DataBase.GetCustomers();
            var orders = DataBase.DataBase.GetOrders();
           foreach (var customer in customers) 
            {
                Console.WriteLine("Nome " + customer.Name + " Idade " + customer.Age + " CustomerID " + customer.Id);
            
            }

            //var bigOrders = orders.Where(order => order.TotalValue > 500);

            //if (bigOrders.Any())
            //{
            //    Console.WriteLine("We have big orders");
            //}
            //else
            //{
            //    Console.WriteLine("We don't have big orders");
            //}

            var bigOrders = orders.Any(order => order.TotalValue > 500);

            if (bigOrders)
            {
                Console.WriteLine("We have big orders");
            }
            else
            {
                Console.WriteLine("We don't have big orders");
            }

            var oldCustomerOrders = orders.Where(order => customers.Any(customer => customer.Id == order.CustomerId && customer.Age != default));

            foreach(var order in oldCustomerOrders)
            {
                Console.WriteLine("Customer Id " + order.CustomerId + " - Purchaed " + order.TotalValue.ToString("c2"));
            }
        }
    } 
}
