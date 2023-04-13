using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryMethod.Cars
{
    public class FormulaCar : Car
    {

        public override string GetInfo()
        {
              string str = $"The formula will be {Name} model and {Color} color!";
               return str;
        }
    }
}
