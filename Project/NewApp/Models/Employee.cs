namespace NewApp.Models
{
    public class Employee
    {
        public int EmployeeID {get; set;}
        public string FullName {get; set; }
        public string Address {get; set;}
        public string ChucVu {get; set;}
// Nghiem Thi Van Anh - 2021050078
    public void NhapThongTin()
    {
           System.Console.Write("Ma nhan vien = ");
            EmployeeID = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Ten nhan vien = ");
            FullName = Console.ReadLine();
            System.Console.Write("Dia Chi = ");
            Address = Console.ReadLine();
            System.Console.Write("Chuc Vu = ");
            ChucVu = Console.ReadLine();
    }
    public void HienThi()

    {
            System.Console.WriteLine("{0} - {1} - {2} - {3} ", EmployeeID, FullName, Address, ChucVu);
    }
    }
}