using System.Collections.Generic;
using Stories.Models;

namespace Stories.Data
{
    public interface IStoriesRepository : IRepository
    {
        IEnumerable<Story> Index(int offset, int limit);
        Story Show(int id);
        void Create(Story story);
        void Update(Story story);
        void Delete(Story story);
    }
}