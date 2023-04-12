using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryMethod.ServiceCars
{
    class FormulaSalon : CarSalon
    {
        public override string Receive(string location)
        {
               string str = $"Order Formula to salon from {location}!";
               return str;
        }
    }
}
