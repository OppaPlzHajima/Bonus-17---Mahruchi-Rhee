using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Bonus_16___Mahruchi_Rhee
{
    class Program
    {

        static void Main(string[] args)
        {
      
            Console.WriteLine("Welcome to the Grand Circus Motors admin console!");
            Console.WriteLine("How many cars are you entering?");
            int quantity = int.Parse(Console.ReadLine());

            List<Car> amount = new List<Car>(quantity);


            for (int i = 0; i < quantity; i++)
            {
                Console.WriteLine("Please input the car model");
                string model = Console.ReadLine().Trim();
                Console.WriteLine("Please input a vehicle make");
                string make = Console.ReadLine().Trim();
                Console.WriteLine("Please input vehicle year.");
                string response = Console.ReadLine().Trim();
                int year = Convert.ToInt32(response);
                Console.WriteLine("Please input vehicle price.");
                string response1 = Console.ReadLine().Trim();
                double price = Convert.ToDouble(response1);
                Car input = new Car(year, make, model, price);
                amount.Add(new Car(year, make, model, price));
            }

            Console.WriteLine("Current Inventory:");
            for (int i = 0; i < amount.Count; i++)
            {
                int v = i + 1;
                Car full = amount[i];
                Console.WriteLine(full.Make + "\t" + full.Model + "\t" + full.Price.ToString("C2", CultureInfo.CurrentCulture) + "\t" + full.Year);
            }

        }
    }
}
