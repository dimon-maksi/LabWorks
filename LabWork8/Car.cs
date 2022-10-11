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

        public Car(string model, string color, int speed, int age)
        {
            Model = model;
            Color = color;
            Speed = speed;
            Age = age;
        }
        public override string ToString()
        {
            return Model + ", with" + Color + "color," + Age + "ages and at a speed of" + Speed + "kilometers per hour.";
        }

    }
}
