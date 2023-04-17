// See https://aka.ms/new-console-template for more information
Console.OutputEncoding = System.Text.Encoding.UTF8;

string numbers = "5, 3, 8, 11, -12, 3, 11, 28, 30";
string[] tokens = numbers.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.None);

// Tổng các số chẵn trong chuỗi numbers
int sum = 0;
foreach (string token in tokens)
{
    int number = int.Parse(token);
    if (number % 2 == 0)
    {
        sum += number;
    }
}
Console.WriteLine($"Tổng các số chẵn: {sum}");

// Tìm các số nguyên tố trong chuỗi numbers
Console.Write("Các số nguyên tố: ");
foreach (string token in tokens)
{
    int number = int.Parse(token);
    bool isPrime = true;
    for (int i = 2; i < number; i++)
    {
        if (number % i == 0)
        {
            isPrime = false;
            break;
        }
    }
    if (isPrime)
    {
        Console.Write(number + ", ");
    }
}
Console.WriteLine();

// Tìm số lớn nhất trong chuỗi numbers
int max = int.MinValue;
foreach (string token in tokens)
{
    int number = int.Parse(token);
    if (number > max)
    {
        max = number;
    }
}
Console.WriteLine($"Số lớn nhất: {max}");

// Tìm số nhỏ nhất trong chuỗi numbers
int min = int.MaxValue;
foreach (string token in tokens)
{
    int number = int.Parse(token);
    if (number < min)
    {
        min = number;
    }
}
Console.WriteLine($"Số nhỏ nhất: {min}");