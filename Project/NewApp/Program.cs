using NewApp.Models;

//Nghiem Thi Van Anh - MSV 2021050078

public class Program
{
    public static void Main(string[]args)
    {
    
        Student std = new Student();

        string StudentID = "2021050078";
        string FullName = "Nghiem Thi Van Anh";
        string Address = " Ha Noi";
        int a = 10;

        System.Console.WriteLine("{0} - {1} - {2} - {3} diem",StudentID,FullName,Address, std.TinhDiem(a));


    }
}

 

