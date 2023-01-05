namespace LabWork6.Extension
{
    public static class Extension
    {
        public static void Processing(this Anagram anagram, int value)
        {
            value = Math.Abs(value);
            double arithmetic = 0, geometric = 1;
            int i = 0;

            if (value < 10 && value >= 0)
            {
                Console.WriteLine("arithmetic mean = {0}\ngeometric mean = {0}", value);
                return;
            }
            while (value != 0)
            {
                arithmetic += value % 10;
                geometric *= value % 10;
                i++;
                value /= 10;
            }

            arithmetic /= i;
            geometric = Math.Pow(geometric, 1.0 / i);

            Console.WriteLine("arithmetic mean = {0}\ngeometric mean = {1}",
                arithmetic, geometric);
        }
    }
}
