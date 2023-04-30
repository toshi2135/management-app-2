// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

Console.OutputEncoding = System.Text.Encoding.UTF8;

// Randomly generate a list of 20 shapes (rectangle, square, circle) with random width, height, length, radius
List<Shape> shapes = new List<Shape>();
Random rand = new Random();
for (int i = 0; i < 20; i++)
{
    int type = rand.Next(0, 3);
    switch (type)
    {
        case 0:
            shapes.Add(new Rectangle()
            {
                Width = rand.Next(1, 100),
                Height = rand.Next(1, 100)
            });
            break;
        case 1:
            shapes.Add(new Square()
            {
                Length = rand.Next(1, 100)
            });
            break;
        case 2:
            shapes.Add(new Circle()
            {
                Radius = rand.Next(1, 100)
            });
            break;
    }
}

// Calculate perimeter and area of above list of shapes
for (int i = 0; i < shapes.Count; i++)
{
    Console.WriteLine($"Hình thứ {i+1} là hình {shapes[i].ToString()}");
    Console.WriteLine($"Chu vi: {shapes[i].Perimeter()}");
    Console.WriteLine($"Diện tích: {shapes[i].Area()}");
}



abstract class Shape
{
    public abstract double Perimeter();
    public abstract double Area();
}

class Rectangle : Shape
{
    public int Width { get; set; }
    public int Height { get; set; }

    public override double Perimeter()
    {
        return 2 * (Width + Height);

    }
    public override double Area()
    {
        return Width * Height;
    }
}

class Square : Shape
{
    public int Length { get; set; }

    public override double Perimeter()
    {
        return 4 * Length;
    }

    public override double Area()
    {
        return Length * Length;
    }
}

class Circle : Shape
{
    public double Radius { get; set; }
    public override double Perimeter() 
    {
        return 2 * Math.PI * Radius;
    }

    public override double Area()
    {
        return Math.PI * Radius * Radius;
    }
}