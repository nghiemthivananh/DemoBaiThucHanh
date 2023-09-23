// See https://aka.ms/new-console-template for more information
using NewApp.Models;

//Nghiem Thi Van Anh - MSV 2021050078

public class Program
{
    public static void Main(string[]args)
    {//khoi tao 2 doi tuong tu class Person
        Person ps1 = new Person();
        Person ps2 = new Person();

        ps1.FullName = "Nghiem Thi Van Anh";
        ps1.Address = "Ha Noi";
        ps1.MaSinhVien = "2021050078";
        ps1.HienThi();

        ps2.NhapThongTin();
        ps2.HienThi();


//YEU CAU: goi phuong thuc nhap cho doi tuong ps2, sau do goi phuong thuc hien thi thong tin cua ps2

    }
}

 
 
