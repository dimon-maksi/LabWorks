using System;

namespace LabWork8_1;
class Program
{
    static void Main(string[] args)
    {
        Car car = new Car(model: "qwerty", color: "red", speed: 123, age: 2020);
        Garage.AddNewCar(car);
        Garage.LetsRide();
    }
}