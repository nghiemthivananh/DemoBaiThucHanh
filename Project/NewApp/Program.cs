using NewApp.Models;

//Nghiem Thi Van Anh - MSV 2021050078

public class Program
{
    public static void Main(string[]args)
    {
    
     
       Employee emp = new Employee();

       string EmployeeID = "2021050078";
       string FullName = "Nghiem Thi Van Anh";
       string Address = "HaNoi";
       int c = 120000000;
       


       System.Console.WriteLine("{0} - {1} - {2} - {3}",EmployeeID,FullName,Address,emp.TinhLuong(c));
     

    }
}

 

