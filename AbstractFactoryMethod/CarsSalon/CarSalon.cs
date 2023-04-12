using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryMethod.ServiceCars
{
     public abstract class CarSalon
     {
          public string Location { get; set; }
          public abstract string Receive(string location);
     }
}
