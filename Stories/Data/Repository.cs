using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Stories.Models;

namespace Stories.Data
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly StoriesContext Context;
        protected readonly DbSet<T> Table;

        public Repository(StoriesContext context)
        {
            Context = context;
            Table = Context.Set<T>();
        }

        public bool Store()
        {
            return (Context.SaveChanges() >= 0);
        }

        public int Count()
        {
            return Table.Count();
        }

        public IEnumerable<T> Index(int offset, int limit)
        {
            return Table.Skip(offset).Take(limit).ToList();
        }

        public T Find(int id)
        {
            return Table.Find(id);
        }

        public void Insert(T model)
        {
            if (model == null)
            {
                throw new ArgumentNullException();
            }

            Table.Add(model);
        }

        public void Update(T model)
        {
        }

        public void Delete(T model)
        {
            if (model == null)
            {
                throw new ArgumentNullException();
            }

            Table.Remove(model);
        }
    }
}