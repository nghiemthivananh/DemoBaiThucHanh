using Microsoft.EntityFrameworkCore;
using DemoMVC.Models;
using DEMOMVC.Models;
namespace DemoMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {}
        public DbSet<Person> Person { get; set; }
        public DbSet<Student> Student { get; set; }
        //  public DbSet<DemoMVC.Models.Faculty> Faculty { get; set; } = default!;
        // khai báo việc ánh xạ class Person vào trong database
    }
}