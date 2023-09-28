using System.Runtime.Intrinsics.Arm;
using NewApp.Models;

namespace NewApp.Models
{
    public class Fruit
    {
        public string FruitName {get; set;}
        public int Cost {get; set; }
        
     
// Nghiem Thi Van Anh - 2021050078
        public void NhapThongTin()
        {
          System.Console.WriteLine("Fruit Name =");
          FruitName =Console.ReadLine();
          System.Console.WriteLine("Cost = ");
          Cost = Convert.ToInt32(Console.ReadLine());
          
        }

        public void HienThi()
        {
          System.Console.WriteLine("{0} -{1}VND", FruitName,Cost);

        }
 
    }
}