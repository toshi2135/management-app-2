// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

Point3D start = new Point3D()
{
    X = 1,
    Y = 2,
    Z = 3
};
start.Move(3);
Console.WriteLine(start.ToString());

// Lớp biểu diễn điểm trong không gian 2 chiều
class Point2D // Base class, Parent class, Super class
{
    public int X { get; set;}
    public int Y { get; set;}

    public void Move (int delta)
    {
        X += delta;
        Y += delta;
    }
}

// Mối quan hệ is-a
// Reuse - Upgrade
// Lớp biểu diễn điểm trong không gian 3 chiều
class Point3D : Point2D // Child class, Deriative class
{
    public int Z { get; set; }

    public override string ToString()
    {
        return $"{X}, {Y}, {Z}";
    }
}