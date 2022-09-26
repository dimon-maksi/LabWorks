using System;

//3.Дана матриця розміру m *  n. Знайти 1) мінімальне; 2) максимальне значення в кожному рядку (стовпчику).  

namespace Name;
class Program
{
    static void ReadInt32(out uint number)
    {
        bool flag = false;
        do
        {
            flag = UInt32.TryParse(Console.ReadLine(), out number);
        } while (!(flag && number <= 10));
    }
    static void Main(string[] args)
    {
        Random random = new Random();
        uint M, N;

        Console.WriteLine("Whire M: ");
        ReadInt32(out M);
        Console.WriteLine("Whire N: ");
        ReadInt32(out N);

        int[,] arr = new int[M, N];
        int[,] Mresult = new int[M, 2];
        int[,] Nresult = new int[N, 2];

        for (int i = 0; i < M; ++i)
        {
            for (int j = 0; j < N; ++j)
            {
                arr[i, j] = random.Next(0,25);
                Console.Write(" " + arr[i, j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        for (int i = 0; i < M; i++)
        {
            Mresult[i, 0] = arr[i, 0];
            Mresult[i, 1] = arr[i, 0];

            for (int j = 0; j < N; j++)
            {
                if (arr[i, j] < Mresult[i, 0])
                {
                    Mresult[i, 0] = arr[i, j];
                }
                if (arr[i, j] > Mresult[i, 1])
                {
                    Mresult[i, 1] = arr[i, j];
                }
            }
        }

        for (int i = 0; i < N; i++)
        {
            Nresult[i, 0] = arr[0, i];
            Nresult[i, 1] = arr[0, i];

            for (int j = 0; j < M; j++)
            {
                if (arr[j, i] < Nresult[i, 0])
                {
                    Nresult[i, 0] = arr[j, i];
                }
                if (arr[j, i] > Nresult[i, 1])
                {
                    Nresult[i, 1] = arr[j, i];
                }
            }
        }

        for (int i = 0; i < M; i++)
        {
            Console.Write("{0}.row min elem = {1}", i+1, Mresult[i,0]);
            Console.WriteLine(" / max elem = {1}", i + 1, Mresult[i, 1]);
        }
        Console.WriteLine();
        for (int i = 0; i < N; i++)
        {
            Console.Write("{0}.column min elem = {1}", i + 1, Nresult[i, 0]);
            Console.WriteLine(" / max elem = {1}", i + 1, Nresult[i, 1]);
        }

        Console.ReadLine();
    }
}