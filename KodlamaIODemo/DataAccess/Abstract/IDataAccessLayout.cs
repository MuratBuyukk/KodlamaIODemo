using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIODemo.DataAccess.Abstract
{
    public interface IDataAccessLayout<T>
    {
        List<T> GetAll();
        T Get(int id);
        void Add(T item);
        void Delete(int id);
        void Update(T item);
    }
}
