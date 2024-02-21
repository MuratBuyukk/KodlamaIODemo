using KodlamaIODemo.Business.Abstract;
using KodlamaIODemo.DataAccess.Abstract;
using KodlamaIODemo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIODemo.Business.Concrete
{
    public class CourseManager : ICourseBusiness
    {
        private ICourseDal _courseDal;

        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }
        public void Add(Course item)
        {
            _courseDal.Add(item);
        }

        public void Delete(int id)
        {
            _courseDal.Delete(id);
        }

        public Course Get(int id)
        {
            return _courseDal.Get(id);
        }

        public List<Course> GetAll()
        {
            return _courseDal.GetAll();
        }

        public List<Course> GetCoursesByCategory(int id)
        {
            return _courseDal.GetCoursesByCategory(id);
        }

        public List<Course> GetCoursesByInstructor(int id)
        {
            return _courseDal.GetCoursesByInstructor(id);
        }

        public void Update(Course item)
        {
            _courseDal.Update(item);
        }
    }
}
