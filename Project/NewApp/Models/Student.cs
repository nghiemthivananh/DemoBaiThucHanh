namespace NewApp.Models
{
    public class Student
    {
        public string StudentID {get; set;}
        public string FullName {get; set; }
        public string Address{get; set;}

        public int Diem{get; set; }
     
// Nghiem Thi Van Anh - 2021050078
    
           
    public int TinhDiem(int Diem)
    {
            int TDiem = Diem/1;
            return TDiem;
    }
  
    }
} 