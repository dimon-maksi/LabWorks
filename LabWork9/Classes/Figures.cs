namespace LabWork9.Classes
{
    public class Square : Shape
    {
        public override string Color { get; set; }
        public override int CountOfVertices { get; }
        public override string Name { get; }
        public double Length { get; set; }

        public Square(string name)
        {
            Name = name;
            Length = 6;
            Color = "random";
            CountOfVertices = 4;
        }
        public Square(string name, double length)
        {
            Name = name;
            Length = length;
            Color = "random";
            CountOfVertices = 4;
        }
        public Square(string name, double length, string color)
        {
            Name = name;
            Length = length;
            Color = color;
            CountOfVertices = 4;
        }

        public override double Area()
        {
            return Math.Pow(Length, 2);
        }
        public override double Perimeter()
        {
            return Length * 4;
        }

        public override void Draw()
        {
            Console.WriteLine("Ви вивели {0} квадрат під ім'ям {1}, його сторона дорівнює {2}", Color, Name, Length);
        }
    }

    public class Circle : Shape
    {
        public override string Color { get; set; }
        public override int CountOfVertices { get; }
        public override string Name { get; }
        public double Radius { get; set; }

        public Circle(string name)
        {
            Name = name;
            Radius = 6;
            Color = "random";
            CountOfVertices = 0;
        }
        public Circle(string name, double radius)
        {
            Name = name;
            Radius = radius;
            Color = "random";
            CountOfVertices = 0;
        }
        public Circle(string name, double radius, string color)
        {
            Name = name;
            Radius = radius;
            Color = color;
            CountOfVertices = 0;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
        public override double Perimeter()
        {
            return Radius * 2 * Math.PI;
        }

        public override void Draw()
        {
            Console.WriteLine("Ви вивели {0} круг під ім'ям {1}, його радіус дорівнює {2}", Color, Name, Radius);
        }
    }

    public class Triangle : Shape
    {
        public override string Color { get; set; }
        public override int CountOfVertices { get; }
        public override string Name { get; }
        public double Length { get; set; }

        public Triangle(string name)
        {
            Name = name;
            Length = 6;
            Color = "random";
            CountOfVertices = 3;
        }
        public Triangle(string name, double length)
        {
            Name = name;
            Length = length;
            Color = "random";
            CountOfVertices = 3;
        }
        public Triangle(string name, double length, string color)
        {
            Name = name;
            Length = length;
            Color = color;
            CountOfVertices = 3;
        }

        public override double Area()
        {
            return Math.Sqrt(3) / 4 * Math.Pow(Length, 2);
        }
        public override double Perimeter()
        {
            return Length * 3;
        }

        public override void Draw()
        {
            Console.WriteLine("Ви вивели {0} рівносторонній трикутник під ім'ям {1}, його сторона дорівнює {2}", Color, Name, Length);
        }
    }
}
