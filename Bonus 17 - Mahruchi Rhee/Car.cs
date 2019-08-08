using System;
using System.Collections.Generic;
using System.Text;

namespace Bonus_16___Mahruchi_Rhee

{
    class Car
    {

        //private int year;
        //public int Year { 
        //    get
        //    {
        //        return year;
        //    }
        //}
        //private string make;
        //public string Make
        //{
        //    get
        //    {
        //        return make;
        //    }
        //}
                            
        //private string model;
        //public string Model
        //{
        //    get
        //    {
        //        return model;
        //    }
        //}
        //private double price; 
        //public double Price
        //  {
        //      get
        //   {
        //        return price;
        //      }
        //}
        public double Price { get; set; }
        public int Year { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }

        public Car()
        {
            this.Year = 1882;
            this.Price = 100.00;
            this.Model = "Ford" ;
            this.Make = "Focus";
        }

        public Car(int year, string make, string model, double price)
        {
            this.Year = year;
            this.Make = make;
            this.Model = model;
            this.Price = price;
        }

        public virtual void GetFromInput()
        {
            Console.Write("Enter the make of vehicle: ");
            Make = Console.ReadLine();
            Console.Write("Enter the model of vehicle: ");
            Model = Console.ReadLine();
            Console.WriteLine("Enter the year of manufacturing for vehicle: ");
            Year = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the price of the vehicle: ");
            Price = double.Parse(Console.ReadLine());


        }

        public override string ToString()
        {
            Console.WriteLine("Current Inventory: ");
            return string.Format("{0}        {1}         {2}         {3}.", Make, Model, Year, Price);

        }


    }
}

