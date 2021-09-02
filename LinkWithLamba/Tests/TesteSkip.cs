using LinqWithLamba.DataBase;
using LinqWithLamba.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkWithLamba.Tests
{
     public class TesteSkip : ITest
    {
        public void Test()
        {
            var customers = DataBase.GetCustomers();

            var skipCustomers = customers.Skip(10);

            foreach(var customer in skipCustomers)
            {
                Console.WriteLine(customer.Name);
            }

            var skipWhileCustomers = customers.SkipWhile(customer => customer.Age != 40); //vi trazer os cara apos o 40, vai pular os 40 iniciiais

            foreach(var customer in skipWhileCustomers)
            {
                Console.WriteLine("Skip While " + customer.Name + " Age " + customer.Age);
            }
        }
    }
}
