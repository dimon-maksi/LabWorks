namespace LabWork8_2.telephones
{
    public class Resolution
    {
        public int Height { get; private set; }
        public int Width { get; private set; }
        public Resolution(int height, int width)
        {
            Height = height;
            Width = width;
        }
    }
}