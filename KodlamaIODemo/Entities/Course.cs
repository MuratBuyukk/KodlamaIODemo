using KodlamaIODemo.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIODemo.Entities.Concrete
{
    public class Course : BaseEntity
    {
        public string CourseName { get; set; }
        public int CategoryId { get; set; }
        public int InstructorId { get; set; }
        public string Language { get; set; }
        public string Description { get; set; }
    }
}
