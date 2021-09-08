using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithLamba.Tests
{
    public class TestAll : ITest
    {
        public void Test()
        {
            var customers = DataBase.DataBase.GetCustomers();

            var areAllCustomersWithIdGreaterThanZero = customers.All(customers => customers.Id >= 0);

            if (areAllCustomersWithIdGreaterThanZero)
            {
                Console.WriteLine("All customers are with Id equal or greater than 0.");
            }
            else
            {
                Console.WriteLine("All customers are not with Id equal or greater than 0.");
            }

            var areAllCustomersWithAgeGreaterThanTwenty = customers.All(customer => customer.Age > 20);
            if (areAllCustomersWithAgeGreaterThanTwenty)
            {
                Console.WriteLine("All customers are more than 20 years old.");
            }
            else
            {
                Console.WriteLine("All customers are not more than 20 years old.");
            }
        }
    } 
}
