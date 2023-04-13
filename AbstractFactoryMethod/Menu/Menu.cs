using AbstractFactoryMethod.Cars;
using AbstractFactoryMethod.Factories;
using AbstractFactoryMethod.ServiceCars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
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

               IFactory factory = null;
               Car transport = null;
               CarSalon carSalon = null;

               if (choice == 1)
               {
                    factory = new FormulaFactory();
               }
               else if (choice == 2)
               {
                    factory = new TruckFactory();
               }
               else
               {
                    Console.WriteLine("\nChoose the existing variant!");
                    Console.ReadLine();
                    MainMenu();
               }

               transport = CreateCar(factory.CreateCar());
               carSalon = CarSalonView(factory.ViewSalon());
               Console.Clear();
               Console.WriteLine("\n\n\n\t\t\t\tCONGRATULATIONS!");
               Console.WriteLine($"\n\nYour order:" +
               $"\n{transport.GetInfo()}" +
                    $"\n{factory.ViewSalon().Receive(carSalon.Location)}" +
                    $"\nOrder will be done: {formattedDate}");



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

               return car;
          }
     }
}
