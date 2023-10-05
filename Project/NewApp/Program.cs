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
    Student [] A = new Student[n];
    for(int i = 0; i < A.Length; i++ )
    {
         System.Console.WriteLine("A[{0}]:", i);
         Student std = new Student();
         std.EnterData();
         A[i] = std;
    }

    // HIen thi cac phan tu trong array
    for(int i = 0; i < A.Length; i++)
    {
        System.Console.WriteLine(i + " FullName:  - " + A[i].FullName + " Address: - " + A[i].Address + " StudentID: - " + A[i].StudentID );
    }
        }
    } 