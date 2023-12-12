using System.ComponentModel.DataAnnotations;

namespace DemoMVC.Models
//2021050078-Nghiêm Thị Vân Anh
{
    
    public class Faculty
    {
       [Key]

        [Required(ErrorMessage = "Mã khoa không được để trống")]
    public string? FacultyID{get;set;}
    [Required(ErrorMessage = "Tên khoa không được để trống")]
    public string? FacultyName{ get; set; }
    
    }
}