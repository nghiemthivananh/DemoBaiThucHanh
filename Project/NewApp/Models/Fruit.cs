namespace NewApp.Models
{
    public class Fruit
    {
        public string FruitName {get; set;}
        public int Cost {get; set; }
        public int KhoiLuong {get; set;}
     
// Nghiem Thi Van Anh - 2021050078
   public Fruit()
    {
        FruitName = "Dua Hau";
        Cost = 120;
        KhoiLuong = 3;
    }
    public void HienThi()

    {
            System.Console.WriteLine("{0} - {1}VND - {2} kg", FruitName,Cost , KhoiLuong);
    }
    }
}