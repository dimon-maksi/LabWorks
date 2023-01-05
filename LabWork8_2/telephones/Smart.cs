namespace LabWork8_2.telephones
{
    public class Smart : ColorScreen
    {
        public readonly bool HavingThouchScreen;
        public readonly int CountOfTouches;
        public readonly int CountOfCameras;

        public Smart() : base()
        {
            this.ScreenResolution = new Resolution(16, 9);
            this.ScreenSize = new Size(16, 9);
            this.CountOfColor = 99999;
            this.HavingThouchScreen = true;
            this.CountOfTouches = 3;
            this.CountOfCameras = 5;
        }

        public void MakeAPhoto()
        {
            Random random = new Random();
            Console.WriteLine("Which camera do you want to take a photo with?");
            for (int i = 1; i <= CountOfCameras; i++)
            {
                Console.WriteLine("[{0} - {1} megapixels]", i, random.Next(3,50));
            }
            var temp = Console.ReadLine();
            int number;
            if (temp.Length == 1)
            {
                if (Int32.TryParse(temp, out number))
                {
                    if (number > 0 && number <= CountOfCameras)
                    {
                        Console.WriteLine("You took a photo from the camera under the number {0}", number);
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }
                }
                else
                {
                    Console.WriteLine("Error!");
                }
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
        public void MakeAVideo()
        {
            Random random = new Random();
            Console.WriteLine("Which camera do you want to make a video with?");
            for (int i = 1; i <= CountOfCameras; i++)
            {
                Console.WriteLine("[{0} - {1} megapixels]", i, random.Next(3, 50));
            }
            var temp = Console.ReadLine();
            int number;
            if (temp.Length == 1)
            {
                if (Int32.TryParse(temp, out number))
                {
                    if (number > 0 && number <= CountOfCameras)
                    {
                        Console.WriteLine("You started recording video from the camera under the number {0}", number);
                        Console.WriteLine("Click to stop...");
                        Console.ReadLine();
                        Console.WriteLine("Save error(");
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }
                }
                else
                {
                    Console.WriteLine("Error!");
                }
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
