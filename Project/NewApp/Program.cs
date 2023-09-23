using NewApp.Models;

//Nghiem Thi Van Anh - MSV 2021050078

public class Program
{
    public static void Main(string[]args)
    {
    
       Employee emp = new Employee();
       Employee emp2 = new Employee();

       emp2.EmployeeID = "2021050078";
       emp2.FullName = "Nghiem Thi Van Anh";
       emp2.Address = "HaNoi";


       emp.HienThiTT();
       emp2.HienThiTT();

    }
}

 

