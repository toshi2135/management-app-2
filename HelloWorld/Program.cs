// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

int calc(int a, int b)
{
    int sum = 0;
    for (int i = a; i <= b; i++)
    {
        sum += i;
    }
    return sum;
}

void update(ref int number) // out
{
    number += 10;
}

void giveMeaning(out string life)
{
    life = "find purpose";
}

const int start = 1;
int end = 10;
int sum = calc(start, end);

update(ref sum);

string life = null;
giveMeaning(out life);


Console.WriteLine($"Sum of {start} to {end} is {sum}");

int[] a = new int[3];
try
{
    a[0] = 1;
    a[1] = 2;
    a[2] = 3;
    a[3] = 10; // error
    Console.WriteLine(a.Length);
} catch(Exception ex) 
{
    Console.WriteLine($"Cannot work with array. Reason {ex.Message}");
}

int[] b =
{
    3, 4, 5, 6, 7, 8
};
Console.WriteLine(b.Length);

int bSum = 0;

for (int i = 0; i < b.Length; i++)
{
    bSum += b[i];
}

Console.WriteLine($"Sum of b is {bSum}");

// Đếm các số chẵn
int evenCount =  0;
for (int i = 0; i < b.Length; i++)
{
    if (i % 2 == 0)
    {
        evenCount++;
    }
}

Console.WriteLine($"Array b has {evenCount} even numbers");

// Lính canh - Tìm số lớn nhất trong mảng
int max = b[0];

for (int i = 1; i < b.Length; i++)
{
    if (b[i] > max)
    {
        max = b[i];
    }
}
Console.WriteLine($"Biggest number of bis {max}");

// Kiểm tra có số nguyên tố trong mảng hay không?
bool hasPrimeFlag = false;
for (int i = 0; i < b[i]; i++)
{
    if (isPrime(b[i]))
    {
        hasPrimeFlag = true;
        break;
    }
}

if (hasPrimeFlag)
{
    Console.WriteLine("Array has prime numbers");
}
else
{
    Console.WriteLine("Array doesn't have prime number");
}

var numbers = new List<int>();
var n = 0;

Console.WriteLine("Ban muon nhap bao nhieu so nguyen? ");
string? buffer = Console.ReadLine();
if (buffer.Length !=0)
{
    n = int.Parse(buffer);
}

//for (int i = 1; i <= n; i++)
//{
//    Console.Write($"Nhap so thu {i}: ");
//    buffer = Console.ReadLine();
//    if (buffer.Length != 0)
//    {
//        int number = int.Parse(buffer);
//        numbers.Add(number);
//    }
//}

var rng = new Random(); // Random number generator
const int Maximum = 100;
for (int i = 1; i < n; i++)
{
    Console.WriteLine(rng.Next(Maximum));
}


bool isPrime(int number)
{
    bool result = false;
    if (number < 2)
    {
        return false;
    }
    else
    {
        int count = 0;
        for (int i = 1; i < number; i++)
        {
            if (number % i == 0)
            {
                count++;
            }
        }
        
        if (count == 2)
        {
            result = true;
        }
    }
    return result;
}
