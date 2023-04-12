﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryMethod.Cars
{
     public abstract class Car
     {
          public string Name { get; set; }
          public string Color { get; set; }  

          public abstract string Create(string name, string color);
     }
}
