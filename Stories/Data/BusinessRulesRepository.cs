using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Stories.Models;

namespace Stories.Data
{
    public class BusinessRulesRepository : Repository<BusinessRule>, IRepository<BusinessRule>
    {
        public BusinessRulesRepository(StoriesContext context) : base(context)
        {
        }

        public new IEnumerable<BusinessRule> Index(int offset, int limit)
        {
            return Table.Include(s => s.Story).Skip(offset).Take(limit).ToList();
        }

        public new BusinessRule Find(int id)
        {
            return Table.Include(s => s.Story).FirstOrDefault(s => s.Id == id);
        }
    }
}