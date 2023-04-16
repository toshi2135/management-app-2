// See https://aka.ms/new-console-template for more information
using System.Text;

Console.OutputEncoding = System.Text.Encoding.UTF8;

//// Chia cho số 0
//// int data = 10 / 0;
//int zero = 0;
////int data = 10 / zero;
//try
//{
//    int data = 10 / zero;
//}
//catch (Exception e)
//{
//    // Eat the exception
//    // In ra lỗi -> bắt nhập lại
//    Console.WriteLine($"Không thể thực hiện, lí do: {e.ToString()}");
//    // Throw exception handler
//}
//double result = 1.0 / 0;
//Console.WriteLine(result);


//// Toán tử ?: (toán tử tam phân)
//int a = -99;
//int result_2 = a > 0 ? a : -a;
//Console.WriteLine(result_2);

//// Kiểu dữ liệu ? nhận giá trị null
//int? a_3 = null;
//int result_3 = a_3 ?? 99; // a != null ? a : 99;
//Console.WriteLine(result_3);

// Connection string
// Username, password, 172.29.43.21, Tên Database
//StringBuilder builder = new StringBuilder();
//builder.Append("This is a long line");
//builder.Append("of text");
//builder.Append(". It should not be combined using");
//builder.Append(" + ");

//string result = builder.ToString();
//Console.WriteLine(result);

uint value = 2; // 0010
uint twoTimes = value << 1; // 0100
Console.WriteLine(twoTimes);

uint flip = ~value;
Console.WriteLine(flip);

// AND: 0 & * => 0
// OR: 1 | * => 1
// XOR: 0 ^ 0 => 0, 1 ^ 1 => 0, 0 ^ 1 => 1, 1 ^ 0 => 1

const string Separator = " ";

string haystack = "The quick brown fox jumps over the lazy dog";
string[] tokens = haystack.Split(new string[] { Separator }, StringSplitOptions.None);
foreach (string token in tokens)
{
    Console.WriteLine(token);
}

const string Separator_2 = "/";

string haystack_2 = "12 //24";
string[] tokens_2 = haystack_2.Split(new string[] { Separator }, StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);
foreach (string token in tokens_2)
{
    Console.WriteLine(token);
}

string data = "5, 3, 8, 11, -12, 3";
int sum = 0;

string[] entries = data.Split(new char[] { ',' }, StringSplitOptions.None);

foreach (string entry in entries)
{
    int number = int.Parse(entry);
    sum += number;
}
Console.WriteLine(sum);