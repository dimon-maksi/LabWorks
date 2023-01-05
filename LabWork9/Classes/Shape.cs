using LabWork9.Interfaces;

namespace LabWork9.Classes
{
    public abstract class Shape : IDraw
    {
        public abstract string Color { get; set; }
        public abstract int CountOfVertices { get; }
        public abstract string Name { get; }
        public abstract double Area();

        public abstract void Draw();

        public abstract double Perimeter();
    }
}
