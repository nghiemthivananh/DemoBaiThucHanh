using System.Runtime.Intrinsics.Arm;
using NewApp.Models;

//Nghiem Thi Van Anh - MSV 2021050078

public class Program
{
    public static void Main(string[]args)
    {
    
     
    
     Fruit frt = new Fruit();
     string FruitName = "Dua Hau";
     int Cost = 30;
     int KhoiLuong = 3;
     System.Console.WriteLine("{0} - {1}vnd - {2}kg - {3}",FruitName,Cost,KhoiLuong,frt.TinhGiaBan(Cost,KhoiLuong));


      


     

    }
}

 

