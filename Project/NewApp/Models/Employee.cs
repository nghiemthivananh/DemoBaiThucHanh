namespace NewApp.Models
{
    public class Employee
    {
        public string EmployeeID {get; set;}
        public string FullName {get; set; }
        public string Address {get; set;}
       
// Nghiem Thi Van Anh - 2021050078
    
    public Employee()
    {
       string EmployeeID = "2021050078"; 
       string FullName = "NghiemThiVanAnh";
       string Address = "HaNoi";
    }
    public void HienThiTT()
    {
        System.Console.WriteLine("{0} - {1} - {2}",EmployeeID,FullName,Address);
    }
    }
} 