using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp
{
    public class Order:IOrder
    {
        public DateTime Delivery { get; }
        public IPerson Client { get; }
        public IVehicle Car { get; }
        public Order(IPerson client,IVehicle car,DateTime delivery)
        {
            this.Car = car;
            this.Client = client;
            this.Delivery = delivery;
        }
    }
}
