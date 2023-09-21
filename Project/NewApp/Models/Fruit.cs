namespace NewApp.Models
{
    public class Fruit
    {
        public string LoaiQua {get; set;}
        public int GiaBan {get; set; }
        public int KhoiLuong {get; set;}
     
// Nghiem Thi Van Anh - 2021050078
    public void NhapThongTin()
    {
           System.Console.Write("Loai Qua = ");
            LoaiQua = Console.ReadLine();
            System.Console.Write("GiaBan = ");
            GiaBan = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Khoi Luong = ");
            KhoiLuong = Convert.ToInt32(Console.ReadLine());
           
    }
    public void HienThi()

    {
            System.Console.WriteLine("{0} - {1} - {2} kg", LoaiQua, GiaBan, KhoiLuong);
    }
    }
}