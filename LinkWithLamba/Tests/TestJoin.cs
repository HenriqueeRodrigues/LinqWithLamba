using LinqWithLamba.DataBase;
using LinqWithLamba.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithLamba.Tests
{
    public class TestJoin : ITest
    {
        public void Test()
        {
            var customers = DataBase.DataBase.GetCustomers();
            var orders = DataBase.DataBase.GetOrders();

            //    //foreach(var customer in customers)
            //    //{
            //    //    foreach(var order in orders)
            //    //    {
            //    //        if(customer.Id == order.CustomerId)
            //    //        {
            //    //            //this order is from this customer
            //    //        }
            //    //    }
            //    //}

            //    var customerOrders = customers.Join(
            //         orders,
            //         customer => customer.Id,
            //         orders => orders.CustomerId,
            //         //(customerOrders, order) => new { Customer = customerOrders, Order = order });
            //         (customerOrders, order) => new { Name = customerOrders.Name, TotalValue =order.TotalValue, CreateDate = order.CreatedDate }); // Só o que eu quero, o que eu instanciei 

            //    foreach(var customerOrder in customerOrders)
            //    {
            //        //Console.WriteLine("The Customer " + customerOrder.Customer.Name + " purchased " + customerOrder.Order.TotalValue.ToString() + " in " + customerOrder.Order.CreatedDate.ToString("dd/MM/yyyy"));
            //        Console.WriteLine("The Customer " + customerOrder.Name + " purchased " + customerOrder.TotalValue.ToString() + " in " + customerOrder.CreateDate.ToString("dd/MM/yyyy"));


            //    }
             
            var customerOrders = customers.GroupJoin(
                 orders,
                 customer => customer.Id,
                 order => order.CustomerId,
                 (customer, allOrders) => new { Customer = customer, AllOrders = allOrders });

            foreach (var customerOrder in customerOrders)
            {
                Console.WriteLine("The Customer " + customerOrder.Customer.Name + " purchased : ");

                foreach(var order in customerOrder.AllOrders)
                {
                    Console.WriteLine("Total Value: " + order.TotalValue.ToString("c2") + " in " + order.CreatedDate.ToString("dd/MM/yyyy"));
                }
            }
        }
    }
}

