using System.Drawing;

namespace LabWork8_2.telephones
{
    public class BlackScreen : Button
    {
        protected Resolution ScreenResolution;
        protected Size ScreenSize;
        public Color Color { get; private set; }

        public BlackScreen() : base()
        {
            symbols.Add('s'); //Не знаю як у вас, але в мене це всі можливі символи на телефоні
            symbols.Add('y'); //Зуб даю, більше нема
            symbols.Add('m');
            symbols.Add('b');
            symbols.Add('o');
            symbols.Add('l');

            this.ScreenResolution = new Resolution(4, 3);
            this.ScreenSize = new Size(4, 3);
            this.Color = Color.Coral;
        }
        public virtual void SendSms()
        {
            Random random = new Random();
            Console.Write("Enter the text you want to send to {0} :",
                Numbers.Numbers_Array[random.Next(Numbers.Numbers_Array.Count - 1)]);
            string message = Console.ReadLine();
            Console.WriteLine("Message sent!");
        }

        public virtual void AcceptSms()
        {
            Random random = new Random();
            Console.WriteLine("You received a message from {0}: {1}",
                Numbers.Numbers_Array[random.Next(Numbers.Numbers_Array.Count - 1)],
                Messages.Messages_Array[random.Next(Messages.Messages_Array.Count - 1)]);
        }
    }
}
