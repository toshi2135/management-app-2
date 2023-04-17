// See https://aka.ms/new-console-template for more information
using System.Globalization;
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

//uint value = 2; // 0010
//uint twoTimes = value << 1; // 0100
//Console.WriteLine(twoTimes);

//uint flip = ~value;
//Console.WriteLine(flip);

// AND: 0 & * => 0
// OR: 1 | * => 1
// XOR: 0 ^ 0 => 0, 1 ^ 1 => 0, 0 ^ 1 => 1, 1 ^ 0 => 1

//const string Separator = " ";
//string haystack = "The quick brown fox jumps over the lazy dog";
//string[] tokens = haystack.Split(new string[] { Separator }, StringSplitOptions.None);
//foreach (string token in tokens)
//{
//    Console.WriteLine(token);
//}

//const string Separator = "/";
//string haystack = "12 //24";
//string[] tokens = haystack.Split(new string[] { Separator }, StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);
//foreach (string token in tokens)
//{
//    Console.WriteLine(token);
//}

//string data = "5, 3, 8, 11, -12, 3";
//int sum = 0;
//string[] entries = data.Split(new char[] { ',' }, StringSplitOptions.None);
//foreach (string entry in entries)
//{
//    int number = int.Parse(entry);
//    sum += number;
//}
//Console.WriteLine(sum);

// String interpolation
//string firstName = "Tran";
//string lastName = "Quang";
//string fullName = $"{firstName} {lastName}";
//Console.WriteLine(fullName);

// Format string in VND
//CultureInfo info = CultureInfo.GetCultureInfo("vi-VN"); // en-US, vi-VN
//int money = 1250000;
//string message = money.ToString("#,###", info.NumberFormat);
//Console.WriteLine(message);

// String search
//string haystack = "The quick brown fox jumps over the lazy dog";
//string needle = "brown";
//int foundPosition = haystack.IndexOf(needle);
//Console.WriteLine(foundPosition);

// String split
string haystack = "C:\\Documents\\Photos\\Test.jpg";
//string folder = "C:\\Documents\\Photos";
//string fileName = "Test.jpg";
//int lastPos = haystack.LastIndexOf("\\");
//Console.WriteLine(lastPos);
//string folder = haystack.Substring(0, lastPos);
//string fileName = haystack.Substring(lastPos + 1);
//Console.WriteLine(folder);
//Console.WriteLine(fileName);

// Using FileInfo
//FileInfo f = new FileInfo(haystack);
//string folder = f.DirectoryName;
//string fileName = f.Name;
//Console.WriteLine(folder);
//Console.WriteLine(fileName);

// Using DateTime
DateTime now = DateTime.Now;
Console.WriteLine(now.ToString("dd/MM/yyyy"));
