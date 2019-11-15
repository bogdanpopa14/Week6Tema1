using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp
{
    public class Store:IStore
    {
        private bool OrderSit = true;
        private List<IOrder> Orders;
        private IVehicle CurentCar;
        public string Name { get; }
        public Store(string name)
        {
            this.Name = name;
            Orders = new List<IOrder>();
        }

        public IOrder BuyCar(IVehicle car, IPerson client)
        {
            CurentCar = car;
            var order = new Order(client, car, DateTime.Now);
            Orders.Add(order);
            return order;
        }

        public void CancelOrder(IOrder order)
        {
            OrderSit = false;
            
            Orders.Remove(order);
        }
        public void OrderSituation(IOrder order)
        {
            if(OrderSit)
            {
                Console.WriteLine($"Comanda este: {CurentCar.Produc.Name} {CurentCar.Name} {CurentCar.Price}$ si ajunge in");
            }
            else
            {
                Console.WriteLine($"Ati anulat comanda pentru {this.Name} {CurentCar.Name}");
            }
        }
    }
}
