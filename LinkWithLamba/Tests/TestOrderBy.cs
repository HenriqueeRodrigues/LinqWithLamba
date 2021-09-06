using LinqWithLamba.DataBase;
using LinqWithLamba.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithLamba.Tests
{
    public class TestOrderBy : ITest
    {
        public void Test()
        {
            var customers = DataBase.DataBase.GetCustomers();
            var orders = DataBase.DataBase.GetOrders();

            var customerOrders = customers.Join(
                orders,
                customer => customer.Id,
                order => order.CustomerId,
                (customer, order) => new
                {
                    CustomerId = customer.Id,
                    Name = customer.Name,
                    Age = customer.Age,
                    TotalValue = order.TotalValue,
                    CreateDate = order.CreatedDate
                });

            //foreach (var customerOrder in customerOrders.OrderBy(order => order.TotalValue)) 
            //{
            //    Console.WriteLine(customerOrder.Name + " - Purchased " + customerOrder.TotalValue.ToString("c2"));
            //}

            //foreach (var customerOrder in customerOrders.OrderByDescending(order => order.TotalValue)) 
            //{
            //    Console.WriteLine(customerOrder.Name + " - Purchased " + customerOrder.TotalValue.ToString("c2"));
            //}

            //foreach (var customerOrder in customerOrders.OrderBy(order => order.TotalValue).ThenByDescending(name => name.Name))
            //{
            //    Console.WriteLine(customerOrder.Name + " - Purchased " + customerOrder.TotalValue.ToString("c2"));
            //}
            foreach (var customerOrder in customerOrders.OrderBy(order => order.TotalValue).ThenBy(name => name.Name))
            {
                Console.WriteLine(customerOrder.Name + " - Purchased " + customerOrder.TotalValue.ToString("c2"));
            }
        }

    }


}
