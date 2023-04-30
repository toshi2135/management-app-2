// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

class Point2D
{
    public int x, y;
    public Point2D(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
    public override string ToString()
    {
        return $"({x}, {y})";
    }
}