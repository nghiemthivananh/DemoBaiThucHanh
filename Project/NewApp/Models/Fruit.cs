namespace NewApp.Models
{
    public class Fruit
    {
        public string FruitName {get; set;}
        public int Cost {get; set; }
        public int KhoiLuong {get; set;}
     
// Nghiem Thi Van Anh - 2021050078

  public int TinhGiaBan(int KhoiLuong, int Cost)
  {
        int GiaTien = KhoiLuong + Cost;
        return GiaTien;
  }
    }
}