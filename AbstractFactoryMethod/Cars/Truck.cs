using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryMethod.Cars
{
    public class Truck : Car
    {
          public override string GetInfo()
        {
               string str = $"The truck will be {Name} model and {Color} color!";
               return str ;
          }
    }
}
