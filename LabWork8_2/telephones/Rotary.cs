using System.Text;

namespace LabWork8_2.telephones
{
    public class Rotary : Phone
    {
        protected List<char> symbols = new List<char> { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
        public readonly string Number;   

        public Rotary()
        {
            Console.WriteLine("*Something tells you that you need to enter your phone number*");
            this.Number = writeANumber();
            addANumber(Number);
        }
        
        public override void Call()
        {
            Console.WriteLine("*Something tells you that you need to enter the phone number you want to call");

            string Number = writeANumber();

            Console.WriteLine("*You called the number: {0} and waited a long time for an answer...*", Number);
        }

        public override void AcceptCall()
        {
            Console.WriteLine("*You picked up the phone, but no one answered*");
        }

        protected string writeANumber()
        {
            string tempStr;
            int tempInt;

            var sb = new StringBuilder();

            for (int i = 0; i < 5; ++i)
            {
                Console.WriteLine("Enter {0} digit of your number:", i+1);
                tempStr = Console.ReadLine();
                if (tempStr.Length != 1)
                {
                    Console.WriteLine("Invalid value, try again.");
                    --i;
                    continue;
                }
                if (Int32.TryParse(tempStr, out tempInt) == false)
                {
                    Console.WriteLine("Unavailable symbol, please try again.");
                    --i;
                    continue;
                }
                sb.Append(tempStr);
            }
            
            return sb.ToString();
        }
        protected void addANumber(string Number)
        {
            Numbers.Numbers_Array.Add(Number);

        }
    }
}
