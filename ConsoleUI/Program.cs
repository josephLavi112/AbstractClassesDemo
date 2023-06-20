using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var sedan = new Car();
            sedan.Make = "Toyota";
            sedan.Model = "Prius";
            sedan.Year = "2021";
            sedan.HasTrunk = true;

            var harley = new Motorcycle();
            harley.Make = "Harley";
            harley.Model = "Big";
            harley.Year = "2019";
            harley.HasSideCar = false;

            Vehicle toyota = new Car();
            toyota.Make = "Toyota";
            toyota.Model = "Camry";
            toyota.Year = "1999";

            Vehicle porsche = new Car();
            porsche.Make = "Porsche";
            porsche.Model = "911";
            porsche.Year = "2015";

            var vehicles = new List<Vehicle>() { porsche, toyota, harley, sedan };

            foreach(var ride in vehicles)
            {
                Console.WriteLine($"Make: {ride.Make}\nModel: {ride.Model}\nYear: {ride.Year}\n");
            }
           

            #region Vehicles

            


            #endregion            
            Console.ReadLine();
        }
    }
}
