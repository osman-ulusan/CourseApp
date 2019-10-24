using CourseApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseApp.Data.Concrete.EfCore
{
    public static class SeedDatabase
    {
        public static void Seed(DbContext db)
        {
            if(db.Database.GetPendingMigrations().Count()==0)
            {
                if(db is DataContext)
                {
                    DataContext _db = db as DataContext;
                    if (_db.Instructors.Count()==0)
                    {
                        _db.Instructors.AddRange(Instructors);
                    }
                    if (_db.Courses.Count()==0)
                    {
                        _db.Courses.AddRange(Courses);
                    }
                }
                db.SaveChanges();
            }
        }
        private static Course[] Courses
        {
            get
            {
                Course[] courses = new Course[]
                {
                    new Course(){Name="Html", Price=100, IsActive=true, Instructor=Instructors[0],},
                    new Course(){Name="Core", Price=200, IsActive=true, Instructor=Instructors[1],},
                    new Course(){Name="Mvc", Price=300, IsActive=false, Instructor=Instructors[0],},
                    new Course(){Name="Sql", Price=400, IsActive=false, Instructor=Instructors[1],},
                };
                return courses;
            }
        }
        private static Instructor[] Instructors =
        {
            new Instructor(){Name="Nazan", Contact=new Contact(){Email="nazan@gmail.com", Phone="12345", Address = new Address(){ City="Çorum", Country="Türkiye", Text="Atatürk Mahallesi No:45"}}},
            new Instructor(){Name="Merve", Contact=new Contact(){Email="merve@gmail.com", Phone="54678", Address = new Address() { City="İst", Country="Türkiye", Text="Bağlar Mahallesi No:12"} }}
        };

    }
}
