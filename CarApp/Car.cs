using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp
{
    public class Car:IVehicle
    {
        public string Name { get; }
        
        public int Price { get; }

        public IProducer Produc { get; }
        public Car(string name, IProducer prod, int price)
        {
            this.Name = name;
            this.Produc = prod;
            this.Price = price;
        }

    }
}
