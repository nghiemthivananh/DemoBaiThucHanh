namespace NewApp.Models
{
    public class Student
    {
        public string StudentID {get; set;}
        public string FullName {get; set; }
        public string Address{get; set;}
     
// Nghiem Thi Van Anh - 2021050078
    
           
    public Student()
    {
        StudentID = "20210500078";
        FullName = "Nghiem Thi Van Anh";
        Address = "Ha Noi";
    }
    public void HienThi()

    {
            System.Console.WriteLine("{0} - {1} - {2} ", StudentID,FullName, Address);
    }
    }
} 