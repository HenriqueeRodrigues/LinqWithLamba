using LinqWithLamba.DataBase;
using LinqWithLamba.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithLamba.Tests
{
    public class TestSelect : ITest
    {
        public void Test()
        {
            var customers = DataBase.DataBase.GetCustomers();

            var fisrtQueryCustomers = from customer in customers
                                      //select new { customer.Name }; se torna uma lista de string com apenas um item
                                      //select new { customer.Id, customer.Name }; se torna ma lista de tipo local com 2 items ou mais
                                      select new { customer.Id, nameHenrique = customer.Name };

            //foreach(var customer in fisrtQueryCustomers)
            //{
            //    Console.WriteLine(customer.nameHenrique );
            //}


            var secondQueryWithLambda = customers
             //.Select(customer => customer.Name); Uma lista de string apenas 1 item 
             //.Select(customer => new { NameHenrqiue = customer.Name, customer.Id}); //Uma lista tipo um novo objeto com os 2 items, renomeando a propriedade
             //.Select(customer => new { customer.Name, customer.Id}); //Uma lista tipo um novo objeto com os 2 items
             .Select(customer => new { Description = "Customer Name" + customer.Name + " Age: " + customer.Age });

            foreach (var customer in secondQueryWithLambda)
            {
                Console.WriteLine(customer.Description);
            }

        }
    }
}
