using LinqWithLamba.DataBase;
using LinqWithLamba.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithLamba.Tests
{
    public class TestSingle : ITest
    {
        public void Test()
        {
            var customers = DataBase.DataBase.GetCustomers();

            //var customerWithAge = customers.Single(customer => customer.Age == 19);

            //var customerWithAge = customers.Single(customer => customer.Age == 10);

            //var customerWithAge = customers.SingleOrDefault(customer => customer.Age == 10);

            //if(customerWithAge != null)
            //{
            //Console.WriteLine(customerWithAge.Id + customerWithAge.Name + " Age " + customerWithAge.Age);

            //}
            //else
            //{
            //    Console.WriteLine("There is no customers with this condition");
            //}

            //var customerWithAgeFirst = customers.SingleOrDefault(customer => customer.SecondAge == 19);
            //Console.WriteLine("This is the customer: " + customerWithAgeFirst.Name);

            //var customerWithAgeSingle = customers.SingleOrDefault(customer => customer.SecondAge == 19 );
            //Console.WriteLine("This is the customer: " + customerWithAgeSingle.Name); single corre a lista toda mesmo achando a condição desejada.

            var customerAnotherDifference = customers.SingleOrDefault(customer => customer.Age > 20);
            Console.WriteLine("This is selected customer: " + customerAnotherDifference.Name);// single e singleordefault sempre vai quebrar quando tiver mais de uma condição desejada

        }
    }
}
