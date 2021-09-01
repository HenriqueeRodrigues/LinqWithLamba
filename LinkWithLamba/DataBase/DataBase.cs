using LinqWithLamba.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithLamba.DataBase
{
    public static class DataBase
    {
        public static List<Customer> GetCustomers()
        {
            var customers = new List<Customer>();

            for (int index = 0; index <= 50; index++)
            {
                var customer = new Customer();
                customer.Id = index;
                customer.Name = $"Customer {index}";
                customer.Age = 19 + index;

                customers.Add(customer);
            }
            return customers;
        }

        public static List<Order> GeOrders()
        {
            var orders = new List<Order>();
            var customerId = 0;

            for (int index = 0; index <= 50; index++)
            {
                var order  = new Order();
                order.Id = index;


                if (customerId > 50)
                {
                    customerId = 0;
                }

                order.CustomerId = customerId;

                order.CreatedDate =DateTime.Now;
                order.TotalValue = 10 * index;

                orders.Add(order);
            }
            return orders;
        } 
    }
}
