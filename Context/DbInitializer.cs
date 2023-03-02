using Microsoft.EntityFrameworkCore;
using RazorPageLab.Models;

namespace RazorPageLab.Context
{
    public static class DbInitializer
    {
        public static void Initialize(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasData(
                new Student()
                {
                    Id = 1,
                    FirstName = "Carson",
                    LastName = "Alexander",
                    EnrollmentDate = DateTime.Parse("2019-09-01")
                },
                new Student()
                {
                    Id = 2,
                    FirstName = "Meredith",
                    LastName = "Alonso",
                    EnrollmentDate = DateTime.Parse("2017-09-01")
                },
                new Student()
                {
                        Id = 3,
                    FirstName = "Arturo",
                    LastName = "Anand",
                    EnrollmentDate = DateTime.Parse("2018-09-01")
                },
                new Student()
                {
                    Id = 4,
                    FirstName = "Gytus",
                    LastName = "Barzdukas",
                    EnrollmentDate = DateTime.Parse("2017-09-01")
                },
                new Student()
                {
                    Id = 5,
                    FirstName = "Yan",
                    LastName = "Li",
                    EnrollmentDate = DateTime.Parse("2017-09-01")
                },
                new Student()
                {
                    Id = 6,
                    FirstName = "Peggy",
                    LastName = "Justice",
                    EnrollmentDate = DateTime.Parse("2016-09-01")
                },
                new Student()
                {
                        Id = 7,
                    FirstName = "Laura",
                    LastName = "Norman",
                    EnrollmentDate = DateTime.Parse("2018-09-01")
                },
                new Student()
                {
                    Id = 8,
                    FirstName = "Nino",
                    LastName = "Olivetto",
                    EnrollmentDate = DateTime.Parse("2019-09-01")
                }
                );

            modelBuilder.Entity<Course>()
                .HasData(
                new Course()
                {
                    Id = 1050,
                    Title = "Chemistry",
                    Credits = 3
                },
                new Course()
                {
                    Id = 4022,
                    Title = "Microeconomics",
                    Credits = 3
                },
                new Course()
                {
                    Id = 4041,
                    Title = "Macroeconomics",
                    Credits = 3
                },
                new Course()
                {
                    Id = 1045,
                    Title = "Calculus",
                    Credits = 4
                },
                new Course()
                {
                    Id = 3141,
                    Title = "Trigonometry",
                    Credits = 4
                },
                new Course()
                {
                    Id = 2021,
                    Title = "Composition",
                    Credits = 3
                },
                new Course()
                {
                    Id = 2042,
                    Title = "Literature",
                    Credits = 4
                }
                );

            modelBuilder.Entity<Enrollment>()
                .HasData(
                new Enrollment()
                {
                    Id =1,
                    StudentId = 1,
                    CourseId = 1050,
                    Grade = Grade.A
                },
                new Enrollment()
                {
                    Id = 2,
                    StudentId = 1,
                    CourseId = 4022,
                    Grade = Grade.C
                },
                new Enrollment()
                {
                    Id = 3,
                    StudentId = 1,
                    CourseId = 4041,
                    Grade = Grade.B
                },
                new Enrollment()
                {
                    Id = 4,
                    StudentId = 2,
                    CourseId = 1045,
                    Grade = Grade.B
                },
                new Enrollment()
                {
                    Id = 5,
                    StudentId = 2,
                    CourseId = 3141,
                    Grade = Grade.F
                },
                new Enrollment()
                {
                    Id = 6,
                    StudentId = 2,
                    CourseId = 2021,
                    Grade = Grade.F
                },
                new Enrollment()
                {
                    Id = 7,
                    StudentId = 3,
                    CourseId = 1050
                },
                new Enrollment()
                {
                    Id = 8,
                    StudentId = 4,
                    CourseId = 1050
                },
                new Enrollment()
                {
                    Id = 9,
                    StudentId = 4,
                    CourseId = 4022,
                    Grade = Grade.F
                },
                new Enrollment()
                {
                    Id = 10,
                    StudentId = 5,
                    CourseId = 4041,
                    Grade = Grade.C
                },
                new Enrollment()
                {
                    Id = 11,
                    StudentId = 6,
                    CourseId = 1045,
                },
                new Enrollment()
                {
                    Id = 12,
                    StudentId = 7,
                    CourseId = 3141,
                    Grade = Grade.A
                }
                );
        }
    }
}
