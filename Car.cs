using System;

namespace Hometask;

public class Car
{
    public string Make = "";
    public string Model = "";
    public int Year;
    public double Mileage;
    public double Fuel = 0;


    public Car(string make, string model, int year, double mileage, double fuel)
    {
        Make = make;
        Model = model;
        Year = year;
        Mileage = mileage;
        Fuel = fuel;
    }

    public void Drive(double miles)
    {
        double neededFuel = miles / 20;
        
        if (miles <= 0)
        {
            Console.WriteLine("Ne dostatochna benzina");
        }
        Mileage += miles;
    }

    public void AddFuel(double gallons)
    {
        if (gallons > 0)
        {
            Fuel += gallons;

            Console.WriteLine($"Added {gallons} gallons of fuel. Current fuel level: {Fuel} gallons.");
        }
    }
}
