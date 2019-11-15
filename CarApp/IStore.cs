using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp
{
    interface IStore
    {
        string Name { get; }
        IOrder BuyCar(IVehicle car, IPerson client);
        void CancelOrder(IOrder order);
    }
}
