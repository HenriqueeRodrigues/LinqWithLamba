using LinqWithLamba.DataBase;
using LinqWithLamba.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkWithLamba.Tests
{
    public class TestTake : ITest
    {
        public void Test()
        {
            var customers = DataBase.GetCustomers();

            var firstCustomers = customers.Take(10);

            foreach (var customer in firstCustomers)
            {
                Console.WriteLine(customer.Name);
            }

            var takeWhileCustomers = customers.TakeWhile(customer => customer.Age != 40);

            foreach (var customer in takeWhileCustomers)
            {
                Console.WriteLine("Take While: " + customer.Name + " Age: " + customer.Age);
            }
        }
    }
}
