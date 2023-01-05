namespace LabWork8_2.telephones
{
    public class ColorScreen : BlackScreen
    {
        public string SecondNumber;
        protected int CountOfColor;
        public bool HavingTwoSIM { get; private set; }

        public ColorScreen() : base()
        {
            MakeSecondNumber();

            this.CountOfColor = 7;
        }

        public override void Call()
        {
            Console.WriteLine("What number do you want to call?");
            string Number = writeANumber();

            if (HavingTwoSIM)
            {
                Console.WriteLine("Which number do you want to call from?\n[1] - {0}\t[2] - {1}", this.Number, this.SecondNumber);
                var temp = Console.ReadLine();

                if (temp == "1" || temp == "2")
                {
                    Console.WriteLine("*You called from {0} SIM card to the number: {1} and waited a long time for an answer..*",
                    temp == "1" ? "first" : (temp == "2" ? "second" : ""), Number);
                }
                else
                {
                    Console.WriteLine("Error!");
                }
            }
            else
            {
                Console.WriteLine("*You called the number: {0} and waited a long time for an answer...*", Number);
            }
        }

        public override void AcceptCall()
        {
            Random random = new Random();
            Console.WriteLine("{0} called you!",
                Numbers.Numbers_Array[random.Next(Numbers.Numbers_Array.Count - 1)]);
            string Number = writeANumber();

            if (HavingTwoSIM)
            {
                Console.WriteLine("Which number do you want to receive a call from?\n[1] - {0}\t[2] - {1}", this.Number, this.SecondNumber);
                var temp = Console.ReadLine();

                if (temp == "1" || temp == "2")
                {
                    Console.WriteLine("*You accepted a call from the {0} SIM card and listened to heavy breathing on the other side for a long time...*",
                    temp == "1" ? "first" : (temp == "2" ? "second" : ""));
                }
                else
                {
                    Console.WriteLine("Error!");
                }
            }
            else
            {
                Console.WriteLine("*You answered the call and listened to the heavy breathing on the other side for a long time...*");
            }
        }

        public override void SendSms()
        {
            Random random = new Random();
            Console.Write("Enter the text you want to send to {0}: ",
                Numbers.Numbers_Array[random.Next(Numbers.Numbers_Array.Count - 1)]);
            string message = Console.ReadLine();
            if (HavingTwoSIM)
            {
                Console.WriteLine("From which number do you want to send SMS?\n[1] - {0}\t[2] - {1}", this.Number, this.SecondNumber);
                var temp = Console.ReadLine();

                if (temp == "1" || temp == "2")
                {
                    Console.WriteLine("*You sent an SMS from {0} SIM card*",
                    temp == "1" ? "first" : (temp == "2" ? "second" : ""));
                }
                else
                {
                    Console.WriteLine("Error!");
                }
            }
            else
            {
                Console.WriteLine("The message has been sent!");
            }            
        }

        public void SendMms()
        {
            Random random = new Random();
            Console.Write("Enter the name of the picture you want to send to the number {0} : ",
                Numbers.Numbers_Array[random.Next(Numbers.Numbers_Array.Count - 1)]);
            string message = Console.ReadLine();
            if (HavingTwoSIM)
            {
                Console.WriteLine("From which number do you want to send MMS?\n[1] - {0}\t[2] - {1}", this.Number, this.SecondNumber);
                var temp = Console.ReadLine();

                if (temp == "1" || temp == "2")
                {
                    Console.WriteLine("*You have sent an MMS from {0} SIM card*",
                    temp == "1" ? "first" : (temp == "2" ? "second" : ""));
                }
                else
                {
                    Console.WriteLine("Error!");
                }
            }
            else
            {
                Console.WriteLine("Image sent!");
            }
        }

        public void AcceptMms()
        {
            Random random = new Random();
            Console.Write("You received an MMS from {0} : \n\t<3\theart.png",
                Numbers.Numbers_Array[random.Next(Numbers.Numbers_Array.Count - 1)]);
            
        }        

        private void MakeSecondNumber()
        {
            while (true)
            {
                Console.WriteLine("You want to activate another SIM card?\n[1] - Yes\t [2] - No");
                string temp = Console.ReadLine();
                if (temp == "1")
                {
                    HavingTwoSIM = true;
                    this.SecondNumber = writeANumber();
                    addANumber(Number);
                    break;
                }
                else if (temp == "0")
                {
                    HavingTwoSIM = false;
                    Console.WriteLine("Good!");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid value, try again");
                }
            }            
        }
    }
}
