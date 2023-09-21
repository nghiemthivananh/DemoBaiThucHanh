namespace NewApp.Models
{
    public class Student
    {
        public int MaSinhVien {get; set;}
        public string TenSinhVien {get; set; }
        public string Lop {get; set;}
     
// Nghiem Thi Van Anh - 2021050078
    public void NhapThongTin()
    {
           System.Console.Write("Ma sinh vien = ");
            MaSinhVien = Convert.ToInt16(Console.ReadLine());
            System.Console.Write("Ten sinh vien = ");
            TenSinhVien = Console.ReadLine();
            System.Console.Write("Lop = ");
            Lop = Console.ReadLine();
           
    }
    public void HienThi()

    {
            System.Console.WriteLine("{0} - {1} - {2} ", MaSinhVien, TenSinhVien, Lop);
    }
    }
}