namespace NewApp.Models
{
    public class Student
    {
        public string StudentID {get; set;}
        public string FullName {get; set; }
        public string Address{get; set;}
     
// Nghiem Thi Van Anh - 2021050078
    
           
    public void HocSinh(string StudentID, string FullName, string Address)
    {

            System.Console.WriteLine("{0} - {1} - {2} ", StudentID,FullName, Address);

    }
  
    }
} 