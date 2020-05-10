using System.Collections.Generic;
using Stories.Models;

namespace Stories.Data
{
    public interface IRepository<T> where T : class
    {
        bool Store();
        int Count();
        IEnumerable<T> Index(int offset, int limit);
        T Find(int id);
        void Insert(T model);
        void Update(T model);
        void Delete(T model);
    }
}