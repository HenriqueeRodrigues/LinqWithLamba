﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithLamba.Tests
{
    public class TestAllCustomers : ITest
    {
        public void Test()
        {
            var customers = DataBase.DataBase.GetCustomers();

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Name);
            }
        }
    }
}
