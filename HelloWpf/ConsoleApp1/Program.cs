// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
const int start = 1;
int end = 10;

int sum = 0;
for (int i = start; i <= end; i++)
{
    sum += i;
}

Console.WriteLine($"Sum of {start} to {end} is {sum}");