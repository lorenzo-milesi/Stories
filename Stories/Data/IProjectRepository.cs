using System.Collections.Generic;
using Stories.Models;

namespace Stories.Data
{
    public interface IProjectRepository
    {
        bool Store();
        int Count();
        IEnumerable<Project> Index(int offset, int limit);
        Project Show(int id);
        void Create(Project project);
        void Update(Project project);
        void Delete(Project project);
    }
}