using AbstractFactoryMethod.Cars;
using AbstractFactoryMethod.ServiceCars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryMethod.Factories
{
    class FormulaFactory : IFactory
    {
        public Car CreateCar()
        {
               return new FormulaCar();
        }

        public CarSalon ViewSalon()
        {
               return new FormulaSalon();
        }
    }
}
