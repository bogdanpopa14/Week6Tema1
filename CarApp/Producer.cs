using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp
{
    public class Producer:IProducer
    {
        public string Name { get; }
        public Producer(string n )
        {
            this.Name = n;
        }

    }
}
