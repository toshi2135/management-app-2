// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

Console.OutputEncoding = System.Text.Encoding.UTF8;

SinhVien SinhVienA = new SinhVien()
{
    HoTen = "Nguyen Van An",
    DiaChi = "Ha Noi",
    Email = "an.nguyen@gmail.com",
    SoDienThoai = "0977281721",
    SoTinChiHienCo = 20
};
Console.WriteLine($"Số tín chỉ còn thiếu là: {SinhVienA.TinhSoTinChiConThieu()}");

Product SanPhamA = new Product()
{
    TenSanPham = "Chả giò Cầu Tre",
    Gia = 52000,
    NamSanXuat = 2023,
    HanSuDung = 2024,
};
Console.WriteLine($"Sản phẩm còn {SanPhamA.TinhSoNamHetHan()} năm thì hết hạn.");


class SinhVien
{
    public string HoTen { get; set; }
    public string DiaChi { get; set; }
    public string Email { get; set; }
    public string SoDienThoai { get; set; }
    public int SoTinChiHienCo { get; set; }

    public int TinhSoTinChiConThieu()
    {
        int max = 142;
        return max - SoTinChiHienCo;
    }
}

class Product
{
    public string TenSanPham { get; set; }
    public float Gia { get; set; }
    public int NamSanXuat { get; set; }
    public int HanSuDung { get; set; }

    public int TinhSoNamHetHan()
    {
        return HanSuDung - DateTime.Now.Year; 
    }
}