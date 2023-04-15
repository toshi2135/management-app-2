// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
Console.OutputEncoding = System.Text.Encoding.UTF8;

// Chia cho số 0
// int data = 10 / 0;
int zero = 0;
//int data = 10 / zero;
try
{
    int data = 10 / zero;
}
catch (Exception e)
{
    // Eat the exception
    // In ra lỗi -> bắt nhập lại
    Console.WriteLine($"Không thể thực hiện, lí do: {e.ToString()}");
    // Throw exception handler
}
double result = 1.0 / 0;
Console.WriteLine(result);


// Toán tử ?: (toán tử tam phân)
int a = -99;
int result_2 = a > 0 ? a : -a;
Console.WriteLine(result_2);