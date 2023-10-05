using System.Runtime.ConstrainedExecution;
using System.Dynamic;
using NewApp.Models;
internal class Program
{
    private static void Main(string[] args){
            //Nghiem Thi Van Anh- 2021050078
    int n;
    do {
        try{
            System.Console.Write("n = ");
            n = Convert.ToInt32(Console.ReadLine());
    
        }
        catch {
            n = 0;
        }
    }while (n<1);
    //Nghiem Thi Van Anh- 2021050078
    Fruit [] A = new Fruit[n];
    for(int i = 0; i < A.Length; i++ )
    {
         System.Console.WriteLine("A[{0}]:", i);
         Fruit frt = new Fruit();
         frt.NhapThongTin();
         A[i] = frt;
    }

     //Nghiem Thi Van Anh- 2021050078
    for(int i = 0; i < A.Length; i++)
    {
        System.Console.WriteLine(i + " FruitName:  - " + A[i].FruitName + " Cost: - " + A[i].Cost + "VND");
    }
        }
    } 