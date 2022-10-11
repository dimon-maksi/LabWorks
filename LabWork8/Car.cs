using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork8_1
{
    public class Car
    {
        public string Model { get; private set; }
        public string Color { get; private set; }
        public int Speed { get; private set; }
        public int Age { get; private set; }

        public Car()
        {
            bool flag = false;

            Console.WriteLine("Model: ");
            this.Model = Console.ReadLine();

            Console.WriteLine("Color: ");
            this.Color = Console.ReadLine();

            int speed;
            do
            {
                Console.WriteLine("Speed: ");
                flag = Int32.TryParse(Console.ReadLine(), out speed);
            } while (!(flag && speed >= 0));
            this.Speed = speed;

            int age;
            do
            {
                Console.WriteLine("Age: ");
                flag = Int32.TryParse(Console.ReadLine(), out age);
            } while (!(flag && age >= 1886));
            this.Age = age;
        }

        public Car(string Model, string Color, int Speed, int Age)
        {
            this.Model = Model;
            this.Color = Color;
            this.Speed = Speed;
            this.Age = Age;
        }

        public override string ToString()
        {
            return Model + " , with " + Color + " color, " + Age + " ages and at a speed of " + Speed + " kilometers per hour.";
        }

    }
}
