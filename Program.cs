﻿// See https://aka.ms/new-console-template for more information
using System;
using MyNewApp.Utilities;

namespace MyNewApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = Utility.CalculateAge(new DateTime(2002, 7, 25));
            Console.WriteLine($"age is {age}");

            Car bmw = new Car();
            bmw.getCarInfo();


            BMW obj = new BMW();

            Bike objBike = new Bike();
            objBike.GetColor();
            objBike.GetMileage();

            Person avi = new Person("AVI", "KUMAR");
        }
    }
}

namespace MyNewApp.Utilities
{
    class Utility
    {
        public static int CalculateAge(DateTime dateOfBirth)
        {
            int age = 0;
            age = DateTime.Now.Year - dateOfBirth.Year;
            return age;
        }
    }
}
