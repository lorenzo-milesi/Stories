using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Stories.Models;

namespace Stories.Data
{
    public class ProjectsRepository : Repository, IProjectRepository
    {
        public ProjectsRepository(StoriesContext context) : base(context)
        {
        }

        public bool Store()
        {
            return (Context.SaveChanges() >= 0);
        }

        public int Count()
        {
            return Context.Projects.Count();
        }

        public IEnumerable<Project> Index(int offset, int limit)
        {
            string sql = $"SELECT \"Id\", \"Name\" FROM public.\"Projects\" LIMIT {limit} OFFSET {offset}";

            return Context.Projects.FromSqlRaw(sql).ToList();
        }

        public Project Show(int id)
        {
            return Context.Projects.FirstOrDefault(p => p.Id == id);
        }

        public void Create(Project project)
        {
            if (project == null)
            {
                throw new ArgumentNullException(nameof(project));
            }

            Context.Projects.Add(project);
        }

        public void Update(Project project)
        {
        }

        public void Delete(Project project)
        {
            if (project == null)
            {
                throw new ArgumentNullException();
            }

            Context.Projects.Remove(project);
        }

    }
}