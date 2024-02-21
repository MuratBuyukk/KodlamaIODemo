using KodlamaIODemo.DataAccess.Abstract;
using KodlamaIODemo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIODemo.DataAccess.Concrete
{
    public class CourseDal : ICourseDal
    {
        private List<Course> _courses;

        public CourseDal()
        {
            _courses = new List<Course> 
            {
                new Course{Id = 1, CategoryId = 1, CourseName= "Backend Basics", Description = "C# course for beginner", InstructorId = 1, Language = "C#"},
                new Course{Id = 2, CategoryId = 2, CourseName= "Frontend Basics", Description = "JavaScript course for beginner", InstructorId = 2, Language = "JavaScript"},
                new Course{Id = 3, CategoryId = 1, CourseName= "Backend Advanced", Description = "C# course for experts", InstructorId = 1, Language = "C#"},
                new Course{Id = 4, CategoryId = 2, CourseName= "Frontend Advanced ", Description = "JavaScript course for experts", InstructorId = 2, Language = "JavaScript"},
            };
        }
        public void Add(Course item)
        {
            _courses.Add(item);
        }

        public void Delete(int id)
        {
            Course filteredCourse = Get(id);
            if(filteredCourse != null)
            {
                _courses.Remove(filteredCourse);
            }
        }

        public Course Get(int id)
        {
            return _courses.Where(c=> c.Id == id).FirstOrDefault();
        }

        public List<Course> GetAll()
        {
            return _courses;
        }

        public List<Course> GetCoursesByCategory(int id)
        {
            return _courses.Where(c => c.CategoryId == id).ToList();
        }

        public List<Course> GetCoursesByInstructor(int id)
        {
            return _courses.Where(c => c.InstructorId == id).ToList();
        }

        public void Update(Course item)
        {
            Course filteredCourse = Get(item.Id);
            filteredCourse.InstructorId = item.InstructorId;
            filteredCourse.CategoryId = item.CategoryId;
            filteredCourse.CourseName = item.CourseName;
            filteredCourse.Description = item.Description;
            filteredCourse.Language = item.Language;
        }
    }
}
