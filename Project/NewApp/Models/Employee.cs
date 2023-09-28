using NewApp.Models;

namespace NewApp.Models
{
    public class Employee:Person
    {
        public string EmployeeID {get; set;}
      

     
       
// Nghiem Thi Van Anh - 2021050078
    
       public void EnterData()
        {
            base.EnterData();
            System.Console.WriteLine("EmpoyeeID =");
            EmployeeID = Console.ReadLine();  
        }

        public void Display()
        {
           base.Display();
           System.Console.WriteLine("Ma nhan vien: {0}", EmployeeID); 
        }
}
}