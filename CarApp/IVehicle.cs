using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp
{
    public interface IVehicle
    {
        IProducer Produc { get; }
        string Name { get; }
        int Price { get; }
        
       
    }
}
