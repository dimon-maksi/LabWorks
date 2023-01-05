namespace LabWork8_2.telephones
{
    public class Button : Rotary
    {
        public Button() : base()
        {
            symbols.Add('*');
            symbols.Add('#');
        }

        public override void AcceptCall()
        {
            Random random = new Random();
            Console.WriteLine("You received a call from {0}, but you only breathed anxiously into the receiver)))", 
                Numbers.Numbers_Array[random.Next(Numbers.Numbers_Array.Count-1)]);
        }
    }
}
