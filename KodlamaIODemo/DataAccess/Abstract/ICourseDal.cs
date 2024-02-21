using KodlamaIODemo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIODemo.DataAccess.Abstract
{
    public interface ICourseDal : IDataAccessLayout<Course>
    {
        List<Course> GetCoursesByCategory(int id);
        List<Course> GetCoursesByInstructor(int id);
    }
}
