using System;

namespace LabWork8_1;
class Program
{
    static void Main(string[] args)
    {
        Garage.AddNewCar(new Car(Model: "qwerty", Color: "red", Speed: 1, Age: 2020));
        Garage.AddNewCar(new Car(Model: "asdfgh", Color: "blue", Speed: 123, Age: 2020));
        Garage.AddNewCar(new Car(Model: "zxcvbn", Color: "red", Speed: 123, Age: 2010));
        Garage.AddNewCar(new Car());
        Garage.LetsRide();
        Garage.RemoveCar();
    }
}