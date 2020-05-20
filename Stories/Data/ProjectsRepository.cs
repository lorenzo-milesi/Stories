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
            return Table.Include(p => p.Stories).Skip(offset).Take(limit).ToList();
        }

        public new Project Find(int id)
        {
            return Table
                .Include(p => p.Stories)
                .ThenInclude(s => s.Type)
                .Include(p => p.Stories)
                .ThenInclude(s => s.State)
                .FirstOrDefault(s => s.Id == id);
        }
    }
}