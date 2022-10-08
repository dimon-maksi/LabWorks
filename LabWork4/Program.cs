using System;

//14.Даний масив розміру N.
//Знайти максимальний (мінімальний) з його локальних мінімумів (максимумів). 


namespace LabWork4;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int length = 10;
        int[] arr = new int[length]; 
        int temp = 1;
        bool flag;

        for (int i = 0; i < length; i++)
        {
            arr[i] = random.Next(1, 5);
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
        Console.Write(arr[0]);
        for (int i = 1; i < length - 1; i++)
        {
            if (arr[i] == arr[i + 1])
            {
                temp++;
            }
            if ((arr[i] < arr[i - temp] && arr[i] < arr[i + 1]) || (arr[i] > arr[i - temp] && arr[i] > arr[i + 1]))
            {
                Console.Write(" " + arr[i]);
                temp = 1;
            }
        }
        Console.WriteLine(" " + arr[length - 1]);
    }
}