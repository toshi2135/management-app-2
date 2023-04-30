﻿// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

Console.OutputEncoding = System.Text.Encoding.UTF8;

Point3D start = new Point3D()
{
    X = 1,
    Y = 2,
    Z = 3
};
start.Move(3);
Console.WriteLine(start.ToString());

//Vehicle v = new Vehicle(); // Trừu tượng nên lỗi
//Car c = new Car(); // C is an instance of class Car
//c.Start();
//Vehicle ford = new Car(); // A car is a vehicle
//ford.Start();

Vehicle c1 = new Car();
Vehicle c2 = new HybridCar();
Vehicle c3 = new Car();
Vehicle c4 = new Car();
Vehicle c5 = new HybridCar();

List<Vehicle> cars = new List<Vehicle>()
{
    c1, c2, c3, c4, c5
};

for (int i = 0; i < cars.Count; i++)
{
    Vehicle v = cars[i];
    v.Start();
}
Console.WriteLine();

List<Shape> shapes = new List<Shape>
{
    new Rectangle() {Width = 5, Height = 4 },
    new Square() {Length = 10 },
    new Rectangle() {Width = 7, Height = 3 },
    new Rectangle() {Width = 2, Height = 8 },
    new Square() {Length = 11 }
};

for (int i = 0; i < shapes.Count; i++)
{
    Console.WriteLine($"Chu vi: {shapes[i].perimeter()}, Diện tích: {shapes[i].area()}");
}
Console.WriteLine();

List<Employee> employees = new List<Employee>()
{
    new Manager() {Name = "Jack", Employees = 3, PaymentPerEmployee = 1000000, Base = 5000000 },
    new DailyEmployee() {Name = "John", Days = 5, PaymentPerDay = 2000000 },
    new DailyEmployee() {Name = "Oliver", Days = 8, PaymentPerDay = 1500000 },
    new ProductEmployee() {Name = "Linda", Products = 20, PaymentPerProduct = 500000 }
};
for (int i = 0; i < employees.Count; i++)
{
    Console.WriteLine($"Nhân viên {employees[i].Name} có lương {employees[i].Salary()}");
}


//-----------------Kết thúc nội dung hàm main

abstract class Employee
{
    public string Name { get; set; }

    public abstract float Salary();
}

class DailyEmployee : Employee
{
    public int Days { get; set; }
    public int PaymentPerDay { get; set; }
    public override float Salary()
    {
        return Days * PaymentPerDay;
    } 
}

class ProductEmployee : Employee
{
    public int Products { get; set; }
    public int PaymentPerProduct { get; set; }

    public override float Salary()
    {
        return Products * PaymentPerProduct;
    }
}

class Manager : Employee
{
    public int Employees { get; set; }
    public int PaymentPerEmployee { get; set; }
    public int Base { get; set; }

    public override float Salary()
    {
        return Base + Employees * PaymentPerEmployee;
    }
}

    abstract class Shape
{
    public abstract float perimeter();
    public abstract float area();
}

class Rectangle : Shape
{
    public float Width { get; set; }
    public float Height { get; set; }
    public override float perimeter()
    {
        return 2 * (Width + Height);
    }
    public override float area()
    {
        return Width * Height;
    }
}

class Square : Shape
{
    public float Length { get; set; }
    public override float perimeter()
    {
        return 4 * Length;
    }
    public override float area()
    {
        return Length * Length;
    }
}


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

    public void Move(int delta) // shadow
    {
        base.Move(delta);
        Z += delta;
    }
}

abstract class Vehicle
{
    public abstract void Start();
}

class Car : Vehicle
{
    public override void Start()
    {
        Console.WriteLine("A car is starting");
    }

    public void Honk() 
    {
        Console.WriteLine("Honk");
    }
}

class HybridCar : Car
{
    public override void Start()
    {
        Console.WriteLine("A hybrid car is starting");
    }
}