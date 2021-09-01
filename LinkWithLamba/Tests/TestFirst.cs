using LinqWithLamba.DataBase;
using LinqWithLamba.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkWithLamba.Tests
{
    public class TestFirst : ITest
    {
        public void Test()
        {
            var customers = DataBase.GetCustomers();

            // var fisrtCustomers = customers.First();
            // Console.WriteLine(fisrtCustomers.Name);

            // var firstCustomerAge = customers.First(x => x.Age > 30);
            // Console.WriteLine(firstCustomerAge.Name + " Age: " + firstCustomerAge.Age);

            // try
            // {
            //     var firstCustomerAgelessTen = customers.First(x => x.Age < 10);
            //     Console.WriteLine(firstCustomerAgelessTen.Name + " Age: " + firstCustomerAgelessTen.Age);
            // }
            // catch(Exception ex)
            // {
            //     Console.WriteLine("There is no customer with this condition. Details: " + ex.ToString());
            // }

            //// var queryWithFirstOrDefault = customers.FirstOrDefault();
            // var queryWithFirstOrDefault = customers.FirstOrDefault( customer => customer.Age > 30);
            // Console.WriteLine("Using FistOrDefault: " + queryWithFirstOrDefault.Name);

            // var customerWithAgeLessTenUsingFirstOrDefault = customers.FirstOrDefault(customer => customer.Age < 10);

            // if(customerWithAgeLessTenUsingFirstOrDefault != null)
            // {
            //     Console.WriteLine("Using FirstOrDefault with Age less than ten " + customerWithAgeLessTenUsingFirstOrDefault.Name);
            // }else
            // {
            //     Console.WriteLine("There is no customer using this condition (FirstOrDefault)");
            // }

            //var firstAge = customers.Select(customer => customer.Age).FirstOrDefault(age => age < 10);
            //Console.WriteLine(firstAge);

            var ages = customers.Select(customer => customer.Age);
            var fisrtAge = ages.FirstOrDefault(age => age < 10);
            Console.WriteLine(fisrtAge);


            int myInt = default(int);
            Console.WriteLine("Default value for int is : " + myInt );



        }
    }
}
