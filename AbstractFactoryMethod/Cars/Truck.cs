using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryMethod.Cars
{
    public class Truck : Car
    {
        public override string Create(string name,string color)
        {
               string str = $"The truck will be {name} model and {color} color!";
               return str ;
          }
    }
}
