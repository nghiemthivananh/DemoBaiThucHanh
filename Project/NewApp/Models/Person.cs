using System.Net.Sockets;
using System.Runtime.Intrinsics.Arm;

namespace NewApp.Models
//Nghiem Thi Van Anh-MSV : 2021050078
{
    public class Person
    {
        public string FullName {get; set; }
        public string Address {get; set; }
        public int Age{get; set; }

         public void EnterData()
         { 
            System.Console.Write(" FullName = ");
            FullName= Console.ReadLine();
            System.Console.Write("Address = ");
            Address = Console.ReadLine();
            System.Console.Write("Age =");
           
//Nghiem Thi Van Anh- 2021050078

            try{
               Age = Convert.ToInt16(Console.ReadLine());
            } catch(Exception e)
            {
                  Age = 0;
               
            }
         }

    
         public void Display()
           {
             System.Console.WriteLine("{0} - {1} - {2}" , FullName, Address, Age);
           }
    
       
    
    }
   

}