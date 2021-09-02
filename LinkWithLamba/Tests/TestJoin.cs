using LinqWithLamba.DataBase;
using LinqWithLamba.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkWithLamba.Tests
{
    public class TestJoin : ITest
    {
        public void Test()
        {
            var customers = DataBase.GetCustomers();
            var orders = DataBase.GeOrders();

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
                 orders => orders.CustomerId,
                 (customerOrders, order) => new { Customer = customerOrders, Order = order });
                 //(customerOrders, order) => new { Name = customerOrders.Name, TotalValue = order.TotalValue, CreateDate = order.CreatedDate }); // Só o que eu quero, o que eu instanciei 

            foreach(var customerOrder in customerOrders)
            {
                //Console.WriteLine("The Customer " + customerOrder.Customer.Name + " purchased " + customerOrder.Order.TotalValue.ToString() + " in " + customerOrder.Order.CreatedDate.ToString("dd/MM/yyyy"));
                Console.WriteLine("The Customer " + customerOrder.Name + " purchased " + customerOrder.TotalValue.ToString() + " in " + customerOrder.CreateDate.ToString("dd/MM/yyyy"));


        //    }
    }
}
}
