using System;

//Записати формулу №14

namespace LabWork2;
class Program
{
    static void Main(string[] args)
    {
        int nk, nn;
        double a = 1;
        bool flag = false;
        do
        {
            Console.WriteLine("nn: ");
            flag = int.TryParse(Console.ReadLine(), out nn);
        } while (nn <= 0 || !flag);
        flag = false;
        do
        {
            Console.WriteLine("nk: ");
            flag = int.TryParse(Console.ReadLine(), out nk);
        } while (nk <= nn || !flag);

        for (int k = nn; k < nk; k++)
        {
            a *= (Math.Pow(-1, k) * k + 8) / (2 * Math.Pow(k, 2) + k + 7);
        }
        Console.WriteLine("a = {0}", a);
    }
}