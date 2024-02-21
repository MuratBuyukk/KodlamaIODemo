using KodlamaIODemo.DataAccess.Abstract;
using KodlamaIODemo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIODemo.DataAccess.Concrete
{
    public class InstructorDal : IInstructorDal
    {
        private List<Instructor> _instructors;

        public InstructorDal()
        {
            _instructors = new List<Instructor> 
            { 
                new Instructor { Id = 1, FirstName = "Engin", LastName = "Demiroğ"},
                new Instructor { Id = 2, FirstName = "Halit Enes", LastName = "Kalaycı"}
            };
        }
        public void Add(Instructor item)
        {
            _instructors.Add(item);
        }

        public void Delete(int id)
        {
            Instructor filteredInstructor = Get(id);
            if(filteredInstructor != null)
            {
                _instructors.Remove(filteredInstructor);
            }            
        }

        public Instructor Get(int id)
        {
            return _instructors.Where(i => i.Id == id).FirstOrDefault();
        }

        public List<Instructor> GetAll()
        {
            return _instructors;
        }

        public void Update(Instructor item)
        {
            Instructor filteredInstructor = Get(item.Id);
            filteredInstructor.FirstName = item.FirstName;
            filteredInstructor.LastName = item.LastName;
        }
    }
}
