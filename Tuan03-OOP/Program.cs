// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Employee Alice = new Employee();
Alice.FirstName = "Alice";
Alice.LastName = "Maive";
Alice.Tel = "0977281721";

Employee Bob = new Employee()
{
    FirstName = "Bob",
    LastName = "Tayson",
    Tel = "0909881254"
};

// Nếu biểu thức bên phải có kiểu rồi
// Thì có thể khai báo var
// ==> Tính dễ đọc
var Charles = new Employee()
{
    FirstName = "Charles"
};

var acc = new BankAccount()
{
    Balance = 100000
};

Console.WriteLine($"Ban co the rut {acc.AvailableBalance}");

class Employee
{
    // Encapsulation - Data hiding
    // Nếu được - Hãy che giấu các thuộc tính
    // Không cung cấp truy cập trực tiếp

    // Attributes _camelCase
    //#region Attributes
    //private string _firstName;
    //private string _lastName;
    //private string _tel;
    //private string _info; // Attribute / Backup Field 
    //#endregion

    //#region Property
    //public string FirstName
    //{
    //    get { return _firstName; }
    //    set { _firstName = value; }
    //}
    //public string LastName
    //{
    //    get { return _firstName; }
    //    set { _firstName = value; }
    //}
    //public string Tel
    //{
    //    get { return _tel; }
    //    set { _tel = value; }
    //}
    //// Kiểu cũ
    //public string getInfo() { return _info; }
    //public void setInfo(string info) { _info = info; }

    //// Kiểu C#
    //public string info // Property
    //{
    //    get { return _info; }
    //    set { _info = value; }
    //}
    //#endregion

    // Kiểu ngắn gọn
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Tel { get; set; }
    public string Info { get; set; }
}

class Circle
{
    public float Radius { get; set; }
    // Derivative attributes
    //public float Diameter { get { return Radius * 2; }}
    //public float Area { get { return (float)Math.PI * Radius * Radius; }}
    //public float Perimeter { get { return (float)Math.PI * Radius * 2; }}

    // Lambda expression
    public float Diameter => Radius * 2;
    public float Area => (float)Math.PI * Radius * Radius;
    public float Perimeter => (float)Math.PI * Radius * 2;
}

class BankAccount
{
    private int _balance = 0;

    public int Balance
    {
        get { return _balance; }
        set { _balance = value; }
    }

    public int AvailableBalance
    {
        get
        {
            int result = 0;

            if (_balance > 50000)
            {
                result = _balance - 50000;

                if (result % 50000 != 0)
                {
                    result = 0;
                }
            }

            return result;
        }
    }
}