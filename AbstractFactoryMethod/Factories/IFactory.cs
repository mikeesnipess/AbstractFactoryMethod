using AbstractFactoryMethod.Cars;
using AbstractFactoryMethod.ServiceCars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryMethod.Factories
{
     public interface IFactory
    {
          Car CreateCar();
          CarSalon ViewSalon();
    }
}
