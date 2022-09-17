using System;

//14.Даний масив розміру N.
//Знайти максимальний (мінімальний) з його локальних мінімумів (максимумів). 


namespace LabWork4;

static class Border
{
    public static uint Begin;
    public static uint End;

    static Border()
    {
        Console.WriteLine("Write a begin of border");
        NewBorder(ref Begin);
        Console.WriteLine("Write a end of border");
        NewBorder(ref End);
        if (Begin > End)
        {
            Begin += End;
            End = Begin - End;
            Begin = Begin - End;
        }
    }

    public static void Extremum(int[] arr)
    {
        int min = arr[Begin];
        int max = arr[Begin];

        for (uint i = Begin + 1; i < End; i++)
        {
            if (min < arr[i])
            {
                min = arr[i];
            }
            if (max > arr[i])
            {
                max = arr[i];
            }
        }

        Console.WriteLine("Minimum = {0}\tMaximum = {1}", min, max);
    }

    private static void NewBorder(ref uint number)
    {
        bool flag = false;
        do
        {
            flag = UInt32.TryParse(Console.ReadLine(), out number);
        } while (!(flag && number <= 20));
    }
}
class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int length = 20;
        int[] arr = new int[length];

        for (int i = 0; i < length; i++)
        {
            arr[i] = random.Next(10, 50);
        }

        foreach (int item in arr)
        {
            Console.Write(" " + item);
        }
        Console.WriteLine();
        Console.WriteLine("-0-------------5-------------10-------------15-------------20-");

        Border.Extremum(arr);
    }
}