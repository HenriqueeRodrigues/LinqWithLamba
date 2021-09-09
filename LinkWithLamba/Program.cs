using System;
using LinqWithLamba.Tests;

namespace LinqWithLamba
{
    class Program
    {
        static void Main(string[] args)
        {
            ITest test = new TestUnion();
            test.Test();

            Console.ReadLine();
        }
    }
}
 