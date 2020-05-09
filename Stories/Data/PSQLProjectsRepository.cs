using System.Collections.Generic;
using System.Linq;
using Stories.Models;

namespace Stories.Data
{
    public class PSQLProjectsRepository : IProjectRepository
    {
        private readonly StoriesContext _context;

        public PSQLProjectsRepository(StoriesContext context)
        {
            _context = context;
        }

        public bool Store()
        {
            return (_context.SaveChanges() >= 0);
        }

        public IEnumerable<Project> Index()
        {
            return _context.Projects.ToList();
        }

        public Project Show(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Create(Project project)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Project project)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(Project project)
        {
            throw new System.NotImplementedException();
        }
    }
}