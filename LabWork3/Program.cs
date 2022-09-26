using System;

//14.Перевірити істинність вислову:
//"Цифри даного тризначного числа утворюють зростаючу або спадаючу послідовність". 

namespace LabWork3;
class Program
{
    static void Main(string[] args)
    {
        int number,
            counter = 0,
            length = 3;
        int[] arr = new int[length];
        bool flag;

        do
        {
            Console.WriteLine("Write a {0}-digit number:", length);
            flag = Int32.TryParse(Console.ReadLine(), out number);
            number = Math.Abs(number);
        } while (!(flag && number >= (Math.Pow(10, length - 1)) && number < (Math.Pow(10, length))));

        for (int i = 1; i < length + 1; i++)
        {
            arr[length - i] = number % 10;
            number /= 10;
        }

        for (int i = 1; i < length; i++)
        {
            if (arr[i] > arr[i - 1])
            {
                ++counter;
            }
            else if (arr[i] < arr[i - 1])
            {
                --counter;
            }
        }

        if (counter == -(length - 1))
        {
            Console.WriteLine("Descending sequence");
            Console.ReadLine();
            return;
        }
        else if (counter == length - 1)
        {
            Console.WriteLine("Increasing sequence");
            Console.ReadLine();
            return;
        }

        Console.WriteLine("Sequence not found");

        Console.ReadLine();
    }
}
