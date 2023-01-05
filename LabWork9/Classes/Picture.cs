using LabWork9.Interfaces;

namespace LabWork9.Classes
{
    public class Picture : IDraw
    {
        private List<Shape> Pictures = new List<Shape> { };
        public int Length { get; set; }

        public Picture() { }
        public Picture(int length)
        {
            Length = length;
        }

        public Shape this[int index]
        {
            get { return Pictures[index]; }
            set { Pictures[index] = value; }
        }

        public void AddPicture(Shape shape)
        {
            Pictures.Add(shape);
        }
        public void RemovePicture(string name)
        {
            Pictures.Remove(Pictures.First(p => p.Name == name));
        }
        public void RemovePicture(Type type)
        {
            Pictures.Remove(Pictures.First(p => p.GetType() == type));
        }
        public void RemovePicture(double area)
        {
            Pictures.Remove(Pictures.First(p => p.Area() > area));
        }

        public void Draw()
        {
            for (int i = 0; i < Pictures.Count; i++)
            {
                Pictures[i].Draw();
            }
        }
    }
}
