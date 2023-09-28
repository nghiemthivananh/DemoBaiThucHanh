namespace NewApp.Models
{
    public class Student : Person
    {
        public string StudentCode {get; set; }

        public void EnterData()
        {
            base.EnterData();
            System.Console.WriteLine("Studnet Code =");
            StudentCode = Console.ReadLine();  
        }

        public void Display()
        {
           base.Display();
           System.Console.WriteLine("Ma sinh vien: {0}", StudentCode); 
        }
    }
}