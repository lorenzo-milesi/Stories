using System.Collections.Generic;
using Stories.Models;

namespace Stories.Data
{
    public class StoriesRepository : Repository, IStoriesRepository
    {
        public StoriesRepository(StoriesContext context) : base(context)
        {
        }

        public int Count()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Story> Index(int offset, int limit)
        {
            throw new System.NotImplementedException();
        }

        public Story Show(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Create(Story story)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Story story)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(Story story)
        {
            throw new System.NotImplementedException();
        }
    }
}