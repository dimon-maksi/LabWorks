using System;

//У банку зберігається наступна інформація про кожен платіж: дата платежу,
//номер картки відправника та отримувача, сума операції, код валюти (UAH,
//USD, EUR) та поточний статус (завершено, помилка, в обробці). За даними про 
//n платежів дізнайтеся:
//1) скільки операцій виконано із заданого номера картки? Виведіть інформацію 
//про кожну із них;
//2) яка загальна сума усіх успішних операцій для кожної картки?

namespace LabWork0;
class Program
{
    static void Main(string[] args)
    {
        List<User> users = new List<User>();
        User Vlad = new User("Vlad");
        User Artem = new User("Artem");
        User Arsen = new User("Arsen");
        User Dima = new User("Dima");

        Operations.NewPayment(Vlad, Artem, 1, Currency.UAH);
        Operations.NewPayment(Dima, Arsen, 300, Currency.USD);
        Operations.NewPayment(Vlad, Vlad, 15, Currency.UAH);
        Operations.NewPayment(Arsen, Artem, 1500, Currency.USD);
        Operations.NewPayment(Arsen, Artem, 0, Currency.USD);
        Operations.NewPayment(Arsen, Artem, 1500, Currency.USD);

        Operations.InfoAboutUser(Vlad);
        Operations.InfoAboutUser(Dima);
        Operations.InfoAboutUser(Arsen);
        Operations.InfoAboutUser(Artem);
        Console.WriteLine();

        Console.WriteLine("Total of all payments: " + Operations.totalOfAllPayments() + " " + Currency.UAH);

        Console.ReadKey();
    }
}
