using System;

//Обчислення об'єму циліндра по відомим значенням висоти основи та радіуса

namespace LabWork1;
class Program
{
    static void Main(string[] args)
    {
        double h, R, V;
        bool flag = false;
        do
        {
            Console.WriteLine("h: ");
            flag = double.TryParse(Console.ReadLine(), out h);
        } while (h <= 0 || !flag);
        flag = false;
        do
        {
            Console.WriteLine("R: ");
            flag = double.TryParse(Console.ReadLine(), out R);
        } while (R <= 0 || !flag);

        V = Math.PI * Math.Pow(R, 2) * h;

        Console.WriteLine("V = {0}", V);

        Console.ReadLine();
    }
}