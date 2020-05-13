using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Stories.Models;

namespace Stories.Data
{
    public class ProjectsRepository : Repository<Project>, IRepository<Project>
    {
        public ProjectsRepository(StoriesContext context) : base(context)
        {
        }

        public new IEnumerable<Project> Index(int offset, int limit)
        {
            return Table.Include(s => s.Stories).Skip(offset).Take(limit).ToList();
        }

        public new Project Find(int id)
        {
            return Table.Include(s => s.Stories).FirstOrDefault(s => s.Id == id);
        }
    }
}