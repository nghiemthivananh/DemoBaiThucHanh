namespace NewApp.Models
//yourName là địa chỉ lưu trữ của file : Tên_Project.Tên_Thư_Mục

{
    public class Person
    //khai báo thuộc tính:
        /*public type name { get; set; }
        public : phạm vi truy cập
        type: kiểu dữ liệu
        name : tên thuộc tính
        vdu:
        */
    {//-----thuộc tính
        public string FullName {get; set; }
        public string Address{get; set; }
        public string MaSinhVien {get; set;}

        public void NhapThongTin()//------phương thức
        /* public: phạm vi truy cập
         void: kiểu trả vè của phương thức
         MyMethod: Tên của phương thức
         (string parameter) tham số của phương thức*/
        
        // phương thức thể hiện hành vi của đối tượng
        
        {
            System.Console.Write("Full name = ");
            FullName = Console.ReadLine();
            System.Console.Write("Address = ");
            Address = Console.ReadLine();
            System.Console.Write("Ma Sinh Vien = ");
            MaSinhVien = Console.ReadLine();
        }

        public void HienThi()//-----phương thức
        {
            System.Console.WriteLine("{0} - {1} - {2} ", FullName, Address, MaSinhVien);
        }

    }
}