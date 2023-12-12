using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoMVC.Models
//2021050078-Nghiêm Thị Vân Anh

{
    [Table("Person")]
    public class Person
    {
        [Key]
       
        public string PersonID { get; set;}
        public  string FullName { get; set;}
        public  string Address { get; set;}
        
    
    }
}