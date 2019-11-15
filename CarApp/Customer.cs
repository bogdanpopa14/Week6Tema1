using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp
{
    public class Customer : IPerson
    {
        public string Name { get; }
        public Customer(string n)
        {
            this.Name = n;
        }
    }
}
