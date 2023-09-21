namespace NewApp.Models
{
    public class Employee
    {
        public int MaNhanVien {get; set;}
        public string TenNhanVien {get; set; }
        public int Tuoi {get; set;}
        public double Luong {get; set;}
// Nghiem Thi Van Anh - 2021050078
    public void NhapThongTin()
    {
           System.Console.Write("Ma nhan vien = ");
            MaNhanVien = Convert.ToInt16(Console.ReadLine());
            System.Console.Write("Ten nhan vien = ");
            TenNhanVien = Console.ReadLine();
            System.Console.Write("Tuoi = ");
            Tuoi = Convert.ToInt16(Console.ReadLine());
            System.Console.Write("Luong = ");
            Luong = Convert.ToDouble(Console.ReadLine());
    }
    public void HienThi()

    {
            System.Console.WriteLine("{0} - {1} - {2} - {3} VND", MaNhanVien, TenNhanVien, Tuoi, Luong);
    }
    }
}