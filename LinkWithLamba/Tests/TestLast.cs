using LinqWithLamba.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithLamba.Tests
{
    public class TestLast
    {
        public void Test()
        {
            var customers = DataBase.DataBase.GetCustomers();

            var lastCustomer = customers.Last();

            Console.WriteLine(lastCustomer.Name);

            try
            {
                var errorCustomer = customers.Last(customer => customer.Id < 0);
            }
            catch { }

            var customerWithLastOrDefault = customers.LastOrDefault(customer => customer.Id < 0);
            {
                Console.WriteLine("There is no customer.");
            }

            var customweWithAge = customers.LastOrDefault(customer => customer.Age < 40);
            Console.WriteLine(customweWithAge.Name);
        }
    }
}
