using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryMethod.ServiceCars
{
    public class TruckSalon : CarSalon
    {
        public override string Receive(string location)
        {
               string str = $"Order Truck to salon from {location}!";
               return str;
          }
    }
}
