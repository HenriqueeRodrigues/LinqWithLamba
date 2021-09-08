using System;
using LinqWithLamba.Tests;

namespace LinqWithLamba
{
    class Program
    {
        static void Main(string[] args)
        {
            ITest test = new TestAll();
            test.Test();

            Console.ReadLine();
        }
    }
}
 