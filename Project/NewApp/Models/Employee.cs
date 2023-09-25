using NewApp.Models;

namespace NewApp.Models
{
    public class Employee
    {
        public string EmployeeID {get; set;}
        public string FullName {get; set; }
        public string Address {get; set; }

     
       
// Nghiem Thi Van Anh - 2021050078
    
   
    
    public int TinhLuong(int LuongCoBan)
    {
        int Luong = LuongCoBan + 10000;
        return Luong;
    }
    }
}