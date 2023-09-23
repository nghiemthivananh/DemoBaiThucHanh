namespace NewApp.Models
{
    public class Student
    {
        public string StudentID {get; set;}
        public string FullName {get; set; }
        public string Address{get; set;}
     
// Nghiem Thi Van Anh - 2021050078
    public void NhapThongTin()
    {
           System.Console.Write("Student ID = ");
            StudentID = Console.ReadLine();
            System.Console.Write("FullName = ");
            FullName = Console.ReadLine();
            System.Console.Write("Address = ");
            Address = Console.ReadLine();
           
    }
    public void HienThi()

    {
            System.Console.WriteLine("{0} - {1} - {2} ", StudentID,FullName, Address);
    }
    }
} 