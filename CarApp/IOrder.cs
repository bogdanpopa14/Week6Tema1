using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp
{
   

    public interface IOrder
    {
        IPerson Client { get; }
         DateTime Delivery { get;  }
        IVehicle Car { get; }


    }
}
