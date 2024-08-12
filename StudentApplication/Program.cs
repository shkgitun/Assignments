using System.Data.Entity;
using System.Data.Entity.Core.Metadata.Edm;

public class Student
{
    public int ID { get; set; }

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime EnrollmentDate { get; set; }

    public Grade Grade { get; set; }
}

public class Grade
{
    public int GradeId { get; set; }
    public string GradeName { get; set; }
    public string Section { get; set; }

    public ICollection<Student> Students { get; set; }
}

public class SchoolContext : DbContext
{
    public SchoolContext() : base()
    {

    }

    public DbSet<Student> Students { get; set; }
    public DbSet<Grade> Grades { get; set; }
}

class Program {
    static void Main(string[] args)
    {

        using (var ctx = new SchoolContext())
        {
            DateTime dt = new DateTime(2024, 06, 30);
            Grade gd8 = new Grade(){GradeName="Grade 8", Section="A" };
      
            var student1 = new Student()
            {
                FirstName = "Carter",
                LastName = "Jones",
                EnrollmentDate = dt,
                Grade = gd8
            };

            var student2 = new Student()
            {
                FirstName = "John",
                LastName = "Doe",
                EnrollmentDate = new DateTime(2024, 07, 31),
                Grade = gd8
            };


            ctx.Grades.Add(gd8);
            ctx.Students.Add(student1);
            ctx.Students.Add(student2);
            ctx.SaveChanges();
        }
    }
}