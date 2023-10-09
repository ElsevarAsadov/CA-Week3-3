
using System;

namespace HomeWork { 

   

    internal class Car
    {

        public string Brand;
        public string Model;
        public float CurrentFuel;
        public float FuelFor1km;
        public float Mileage;


        public Car(string brand, string model, float currentFuel, float fuelFor1km, float mileage)
        {
            this.Brand = brand;
            this.Model = model;
            this.CurrentFuel = currentFuel;
            this.FuelFor1km = fuelFor1km;
            this.Mileage = mileage;
        }

        public void Drive(int km)
        {
            if (this.CurrentFuel < this.FuelFor1km * km)
            {
                Console.WriteLine("You do not have enough fuel for destination");
            }
            else
            {
                this.CurrentFuel -= this.FuelFor1km * km;
                this.Mileage += km;
                Console.WriteLine($"You arrived the point.\nCurrent Fuel Capacity: {this.CurrentFuel}\nCurrent Mileage : {this.Mileage}");
            }
        }
    }
}

