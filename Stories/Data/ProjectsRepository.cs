using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Stories.Models;

namespace Stories.Data
{
    public class ProjectsRepository : IProjectRepository
    {
        private readonly StoriesContext _context;

        public ProjectsRepository(StoriesContext context)
        {
            _context = context;
        }

        public bool Store()
        {
            return (_context.SaveChanges() >= 0);
        }

        public int Count()
        {
            return _context.Projects.Count();
        }

        public IEnumerable<Project> Index(int offset, int limit)
        {
            string sql = $"SELECT \"Id\", \"Name\" FROM public.\"Projects\" LIMIT {limit} OFFSET {offset}";

            return _context.Projects.FromSqlRaw(sql).ToList();
        }

        public Project Show(int id)
        {
            return _context.Projects.FirstOrDefault(p => p.Id == id);
        }

        public void Create(Project project)
        {
            if (project == null)
            {
                throw new ArgumentNullException(nameof(project));
            }

            _context.Projects.Add(project);
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