using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork8_1
{
    static public class Garage
    {
        static private List<Car> _cars = new List<Car>();
        static private char[] _separators = new char[] { ' ', ',', '.'};
        private const int _countOfProp = 4;

        static public void LetsRide()
        {
            Console.WriteLine("Which car do you want to drive?");
            Ride(Choose());
        }

        static public void AddNewCar(Car car)
        {
            _cars.Add(car);
        }

        static public void RemoveCar()
        {
            Console.WriteLine("What car do you want to remove?");
            Remove(Choose());
        }

        static private void Remove(Car car)
        {
            if (car == null)
            {
                return;
            }
            Console.WriteLine("you removed a " + car.ToString());
            _cars.Remove(car);
        }

        static private void Ride(Car car)
        {
            if (car == null)
            {
                return;
            }
            Console.WriteLine("You were driving a " + car.ToString());
        }

        static private Car Choose()
        {
            Console.WriteLine("Enter parameters: ");

            string prop = Console.ReadLine();
            List<Car> subCars = Search(prop.Split(_separators, StringSplitOptions.RemoveEmptyEntries));

            if (subCars.Count == 0)
            {
                Console.WriteLine("You don't have such a car.");
                return null;
            }

            for (int i = 0; i < subCars.Count; i++)
            {
                Console.WriteLine($"[{i+1}] {subCars[i].ToString()}");
            }

            Console.WriteLine("Choose you car: ");

            int userChoise;
            bool flag = false;
            do
            {
                flag = Int32.TryParse(Console.ReadLine(), out userChoise);
            } while (!flag && userChoise <= subCars.Count);

            return subCars[userChoise - 1];
        }

        static private List<Car> Search(string[] param)
        {
            List<Car> subCars = new List<Car> { }; //чому без ініціалізації тут не пускає робити нові елементи ліста, хоча вище пустило?
            bool flag = false;

            for (int i = 0; i < _cars.Count(); i++)
            {
                for (int j = 0; j < param.Length; j++)
                {
                    if (param[j] == _cars[i].Model ||
                        param[j] == Convert.ToString(_cars[i].Speed) ||
                        param[j] == _cars[i].Color ||
                        param[j] == Convert.ToString(_cars[i].Age))
                    {
                        flag = true;
                    } //Як це зробити не так каряво?
                    else
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    subCars.Add(_cars[i]);
                }
            }

            return subCars;
        }
    }
}
