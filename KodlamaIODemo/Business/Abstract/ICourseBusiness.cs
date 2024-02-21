using KodlamaIODemo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIODemo.Business.Abstract
{
    public interface ICourseBusiness: IBusiness<Course>
    {
        List<Course> GetCoursesByCategory(int id);
        List<Course> GetCoursesByInstructor(int id);
    }
}
