﻿using System;
using LinkWithLamba.Tests;
using LinqWithLamba.Tests;

namespace LinqWithLamba
{
    class Program
    {
        static void Main(string[] args)
        {
            ITest test = new TestJoin();
            test.Test();

            Console.ReadLine();
        }
    }
}
 