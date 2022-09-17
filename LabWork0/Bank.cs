using System;

namespace LabWork0
{
    public enum Status { COMPLETED, ERROR, PROCESSING }

    public enum Currency { USD, EUR, UAH }

    public static class Operations
    {
        private static List<Payment> _payments = new List<Payment>();

        public static bool NewPayment(User sender, User receiver, decimal amount, Currency currency)
        {
            Payment newPayment = new Payment(sender, receiver, amount, currency);
            _paymentProcessing(newPayment);
            _payments.Add(newPayment);
            return true;
        }

        public static bool InfoAboutUser(User user)
        {
            Console.WriteLine("Name: {0}\tId: {1}\tCount of payment: {2}", user.Name, user.Id, _numberOfPayments(user));
            return true;
        }

        public static decimal totalOfAllPayments()
        {
            decimal total = 0;
            foreach (var payment in _payments)
            {
                if (payment.Status.Equals(Status.COMPLETED))
                {
                    if (payment.Currency.Equals(Currency.USD))
                    {
                        total += payment.Amount * 5.1809m;
                    }
                    else if (payment.Currency.Equals(Currency.USD))
                    {
                        total += payment.Amount * 6.3067m;
                    }
                    else
                    {
                        total += payment.Amount;
                    }
                }
            }
            return total;
        }

        private static int _numberOfPayments(User user)
        {
            int counter = 0;
            foreach (Payment payment in _payments)
            {
                if (payment.Sender.Equals(user))
                {
                    if (!payment.Status.Equals(Status.COMPLETED))
                    {
                        Console.WriteLine($"{payment.Status} | {payment.Date} | {payment.Sender.Name} -> {payment.Receiver.Name} | {payment.Amount} {payment.Currency}");
                    }
                    else
                    {
                        counter++;
                    }
                }

            }
            return counter;
        }

        private static bool _paymentProcessing(Payment payment)
        {
            if (payment.Sender == payment.Receiver || payment.Amount < 1)
            {
                payment.Status = Status.ERROR;
                return false;
            }
            payment.Status = Status.COMPLETED;
            return true;
        }
    }

    public class Payment
    {
        public User Sender { get; set; }
        public User Receiver { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public Status Status { get; set; }
        public Currency Currency { get; set; }

        public Payment(User sender, User receiver, decimal amount, Currency currency, Status status = Status.PROCESSING)
        {
            Date = DateTime.Now;
            Sender = sender;
            Receiver = receiver;
            Amount = amount;
            Status = status;
            Currency = currency;
        }
    }

    public class User
    {
        public readonly Guid Id;

        public string Name { get; set; }

        public User()
        {
            Id = Guid.NewGuid();
        }
        public User(string name)
        {
            Name = name;
        }

    }
}
