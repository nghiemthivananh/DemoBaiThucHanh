using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DemoMVC.Models;
namespace DEMOMVC.Models
{
//Nghiem Thi Van Anh - 2021050078
    public class Student : Person
    {
   
        [Required(ErrorMessage = "Vui long nhap Student id")]
        public string StudentID { get; set; }
        public string FacultyID { get; set; }
        [ForeignKey("FacultyID")]
        public Faculty? Faculty { get; set; }


    }
}

//Nghiem Thi Van Anh - 2021050078