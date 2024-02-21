using KodlamaIODemo.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIODemo.Entities.Concrete
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; }
    }
}
