using AbstractFactoryMethod.Cars;
using AbstractFactoryMethod.Factories;
using AbstractFactoryMethod.ServiceCars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryMethod.Menu
{
     public class Menu
     {
          List<string> locations = new List<string>() { "Germany", "Italy", "Moscow", "USA" };

          public void MainMenu()
          {
               DateTimeOffset today = DateTimeOffset.UtcNow;
               DateTimeOffset tenDaysAfter = today.AddDays(10);
               string formattedDate = tenDaysAfter.DateTime.ToString("yyyy-MM-dd");

               Console.Clear();
               Console.WriteLine("\n\n\t\t\t\t\t\tCARS SALON");
               Console.WriteLine("\n\n\nSelect the salon");
               Console.WriteLine("We have all type of cars!");
               Console.WriteLine("\n[1] Formula");
               Console.WriteLine("[2] Truck");
               Console.Write("\nSelect:");

               int choice = int.Parse(Console.ReadLine());

               if (choice == 1)
               {
                    FormulaFactory formula = new FormulaFactory();
                    Car car = CreateCar(formula.CreateCar());
                    CarSalon carSalon = CarSalonView(formula.ViewSalon());

                    Console.Clear();
                    Console.WriteLine("\n\n\n\t\t\t\tCONGRATULATIONS!");
                    Console.WriteLine($"\n\nYour order:" +
                         $"\n{formula.CreateCar().Create(car.Name, car.Color)}" +
                         $"\n{formula.ViewSalon().Receive(carSalon.Location)}" +
                         $"\nOrder will be done: {formattedDate}");

               }
               else if (choice == 2)
               {
                    TruckFactory truck = new TruckFactory();
                    Car car = CreateCar(truck.CreateCar());
                    CarSalon carSalon = CarSalonView(truck.ViewSalon());

                    Console.Clear();
                    Console.WriteLine("\n\n\n\t\t\t\tCONGRATULATIONS!");
                    Console.WriteLine($"\n\nYour order:" +
                         $"\n{truck.CreateCar().Create(car.Name, car.Color)}" +
                         $"\n{truck.ViewSalon().Receive(carSalon.Location)}" +
                         $"\nOrder will be done: {formattedDate}");
               }
               else
               {
                    Console.WriteLine("\nChoose the existing variant!");
                    Console.ReadLine();
                    MainMenu();
               }

          }

          public CarSalon CarSalonView(CarSalon carSalon)
          {
               Console.Clear();
               Console.Write("\n\n\t\tChoice the location from where are you want to order vehicle: \n\n");
               int i = 1;
               foreach (var al in locations)
               {
                    Console.WriteLine($"[{i}] {al}");
                    i++;
               }

               Console.Write("\n\nSelect: ");
               int choice = int.Parse(Console.ReadLine());
               string location = null;

               foreach (var verif in locations)
               {
                    if (choice - 1 >= 0 && choice - 1 < locations.Count)
                    {
                         location = locations[choice - 1];
                    }
               }

               carSalon.Location = location;

               carSalon.Receive(location);
               return carSalon;

          }


          public Car CreateCar(Car car)
          {
               Console.Clear();
               Console.Write("\n\nWrite name of model what you prefer to order: ");
               string name = Console.ReadLine();
               car.Name = name;

               Console.Write("\nWrite Color what you prefer: ");
               string color = Console.ReadLine();
               car.Color = color;

               car.Create(name, color);
               return car;

          }
     }
}
