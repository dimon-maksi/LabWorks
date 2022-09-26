using System;

//2.Створити ліст трінгових змінних, дозволити можливість заповнення з калвіатури.
// Вивести індекси змінних рівних перевірочній(теж ввести з клавіатури). Скопіювати ліст в масив.

namespace LabWork7;
class Program
{
    static void Search(List<string> strings)
    {
        Console.WriteLine("Write the string you are looking for: ");
        string sentence = Console.ReadLine();
        for (int i = 0; i < strings.Count; i++)
        {
            if (strings[i] == sentence)
            {
                Console.WriteLine("A row with index {0} will do", i);
            }
        }
    }

    static void Main(string[] args)
    {
        List<string> strings = new List<string>();
        string[] result;
        bool flag = true;
        short userChoise;

        do
        {
            Console.WriteLine("Choose:\n[1] Add\n[2] Search");
            userChoise = Int16.Parse(Console.ReadLine());
            switch (userChoise)
            {
                case 1:
                    {
                        Console.WriteLine("Add new string: ");
                        strings.Add(Console.ReadLine());
                    }
                    break;
                case 2:
                    {
                        Search(strings);
                        flag = false;
                    }
                    break;
                default:
                    break;
            }
        } while (flag);

        result = strings.ToArray();
    }
}