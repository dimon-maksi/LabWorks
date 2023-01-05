using LabWork6.Extension;

namespace LabWork6;
class Program
{
    static void Main(string[] args)
    {
        string userSentence;
        Console.WriteLine("Hello, do you need to reverse words in your sentence?\n Oh, this program can do this(only this)!");
        while (true)
        {
            Console.WriteLine("Whrite your sentence: \n\t\t\tFor stop program whrite 0");
            userSentence = Console.ReadLine();
            if (userSentence == "0")
            {
                break;
            }
            Console.WriteLine(Anagram.Reverse(userSentence));
        }
        
        Anagram anagram = new Anagram();
        anagram.Processing(12412468);

        Console.WriteLine("Thanks for using my very usable program");
        Console.ReadLine();
    }
}
