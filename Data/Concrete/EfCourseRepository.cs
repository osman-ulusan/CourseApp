﻿using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseApp.Models
{
    public class EfCourseRepository : ICourseRepository
    {
        private DataContext db;

        public EfCourseRepository(DataContext _db)
        {
            db = _db;
        }
        public IQueryable<Course> Courses => db.Courses;

        public int CreateCourse(Course newCourse)
        {
            db.Courses.Add(newCourse);
            db.SaveChanges();
            return newCourse.Id; 
        }

        public void DeleteCourse(int courseid)
        {
            db.Courses.Remove(new Course() { Id = courseid });
            db.SaveChanges();

        }

        public Course GetById(int courseid)
        {
            return db.Courses.Find(courseid);
        }

        public IEnumerable<Course> GetCourse()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Course> GetCoursesByFilter(string name = null, decimal? price = null, string IsActive = null)
        {
            IQueryable<Course> query = db.Courses;
            if (name!=null)
            {
                query = query.Where(x => x.Name.ToLower().Contains(name.ToLower()));
            }
            if (price!=null)
            {
                query = query.Where(x => x.Price >= price);
            }
            if (IsActive=="on")
            {
                query = query.Where(x => x.IsActive == true);
            }
            return query.ToList();
        }

        public void UpdateAll(int id, Course[] courses)
        {
            db.Courses.UpdateRange(courses.Where(i => i.InstructorId != id));
            db.SaveChanges();
        }

        public void UpdateCourse(Course updatedCourse, Course originalCourse = null)
        {
            if(originalCourse==null)
            {
                originalCourse = db.Courses.Find(updatedCourse.Id);
            }
            else
            {
                db.Courses.Attach(originalCourse);
            }
            originalCourse.Name = updatedCourse.Name;
            originalCourse.Price = updatedCourse.Price;
            originalCourse.IsActive = updatedCourse.IsActive;
            db.SaveChanges();
            //EntityEntry entry = db.Entry(originalCourse);

        }
    }
}
