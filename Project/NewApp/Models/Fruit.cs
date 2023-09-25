namespace NewApp.Models
{
    public class Fruit
    {
        public string FruitName {get; set;}
        public int Cost {get; set; }
        public int KhoiLuong {get; set;}
     
// Nghiem Thi Van Anh - 2021050078
   public void HienThi(string FruitName,int Cost, int KhoiLuong)
   {
    System.Console.WriteLine("TenQua {0} - {1}vnd - {2}kg",FruitName,Cost,KhoiLuong);
   }
    }
}