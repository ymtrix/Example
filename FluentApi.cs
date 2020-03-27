using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class FluentApi
    {
        //modelBuilder.Entity<Student>()
        //        .Property(s => s.StudentId)
        //        .HasColumnName("Id")
        //        .HasDefaultValue(0)
        //        .IsRequired();

        //modelBuilder.Entity<Student>()
        //    .HasOne<Grade>(s => s.Grade)
        //    .WithMany(g => g.Students)
        //    .HasForeignKey(s => s.CurrentGradeId);

        //public class SchoolContext : DbContext
        //{
        //    public DbSet<Student> Students { get; set; }
        //    public DbSet<Course> Courses { get; set; }

        //    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //    {
        //        optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=SchoolDB;Trusted_Connection=True;");
        //    }
        //}

    //     using (var context = new SchoolContext()) {

    //            var std = new Student()
    //            {
    //                Name = "Bill"
    //            };

    //context.Students.Add(std);
    //            context.SaveChanges();
    //        }
    }
}
