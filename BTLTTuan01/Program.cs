// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
Console.OutputEncoding = System.Text.Encoding.UTF8;

// 1. Phát sinh ngẫu nhiên một số nguyên n thuộc đoạn [10, 20]
var rng = new Random();
const int min = 10;
const int max = 20;
int n = rng.Next(min, max + 1);
Console.WriteLine($"Số nguyên n là {n}");

// 2. Phát sinh ngẫu nhiên n số nguyên lưu vào mảng List<int> numbers. Mỗi số nguyên có miền giá trị trong đoạn [5-100]
List<int> numbers = new List<int>();
for (int i = 0; i < n; i++)
{
    numbers.Add(rng.Next(5, 101));
}

// 3. In ra màn hình danh sách các số nguyên vừa phát sinh
Console.WriteLine("Mảng số nguyên vừa tạo là:");
foreach (var number in numbers)
{
    Console.Write($"{number} ");
}
Console.WriteLine();

// 4. In ra màn hình tổng các số nguyên vừa nhập
int sum = 0;
foreach (var number in numbers)
{
    sum += number;
}
Console.WriteLine($"Tổng các số nguyên vừa nhập là {sum}");

// 5. Kiểm tra mảng có toàn bộ là số lẻ hay không
bool isOdd = true;
foreach (var number in numbers)
{
    if (number % 2 == 0)
    {
        isOdd = false;
        break;
    }
}
if (isOdd)
{
    Console.WriteLine("Mảng toàn số lẻ");
}
else
{
    Console.WriteLine("Mảng không toàn số lẻ");
}

// 6. Đếm số lượng số chính phương trong mảng
// Hàm kiểm tra số chính phương
bool isSquare(int number)
{
    int sqrt = (int)Math.Sqrt(number);
    return sqrt * sqrt == number;
}

int squareCount = 0;
foreach (var number in numbers)
{
    if (isSquare(number))
    {
        squareCount++;
    }
}
Console.WriteLine($"Mảng có {squareCount} số chính phương");

// 7. Tìm số nguyên tố lớn nhất của mảng
// Hàm kiểm tra số nguyên tố
bool isPrime(int number)
{
    if (number < 2)
    {
        return false;
    }
    for (int i = 2; i <= Math.Sqrt(number); i++)
    {
        if (number % i == 0)
        {
            return false;
        }
    }
    return true;
}

int maxPrime = -1;
foreach (var number in numbers)
{
    if (isPrime(number) && number > maxPrime)
    {
        maxPrime = number;
    }
}
if (maxPrime == -1)
{
    Console.WriteLine("Mảng không có số nguyên tố");
}
else
{
    Console.WriteLine($"Số nguyên tố lớn nhất của mảng là {maxPrime}");
}
