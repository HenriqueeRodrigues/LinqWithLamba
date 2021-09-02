using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithLamba.Model
{
    public class Customer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public int SecondAge { get
            {
                Console.WriteLine("I am this " + Name);
                return Age;
            } }
    }
}
