using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithLamba.Tests
{
    public class TestWhere : ITest
    {
        public void Test()
        {
            var customers = DataBase.DataBase.GetCustomers();
            var orders = DataBase.DataBase.GetOrders();

            var ageCustomers = customers.Where(customer => customer.Age > 40 && customer.Age < 51);
            foreach (var customer in ageCustomers)
            {
                Console.WriteLine(customer.Name + " Age: " + customer.Age);
            }

            var fisrtCustomerOrders = orders.Where(order => ValidateOrders(order));

            foreach (var order in fisrtCustomerOrders)
            {
                Console.WriteLine(order.CustomerId + " - Purchased: " + order.TotalValue.ToString("c2"));
            }

            static bool ValidateOrders(Model.Order order)
            {
                return order.CustomerId == 1 && order.TotalValue > 1000 && order.TotalValue < 3000 || (order.CustomerId == 2);
            }
        }

    }
}
