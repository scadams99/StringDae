using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using StringDae;

namespace StringDae.Models
{ 
    public class PERSONRepository : IPERSONRepository
    {
        stringDaeEntities context = new stringDaeEntities();

        public IQueryable<PERSON> All
        {
            get { return context.People; }
        }

        public IQueryable<PERSON> AllIncluding(params Expression<Func<PERSON, object>>[] includeProperties)
        {
            IQueryable<PERSON> query = context.People;
            foreach (var includeProperty in includeProperties) {
                query = query.OrderBy(x => x.LAST_NAME).Include(includeProperty);
            }
            return query;
        }

        public PERSON Find(int id)
        {
            return context.People.Find(id);
        }

        public void InsertOrUpdate(PERSON person)
        {
            if (person.ID == default(int)) {
                // New entity
                context.People.Add(person);
            } else {
                // Existing entity
                context.Entry(person).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var person = context.People.Find(id);
            context.People.Remove(person);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Dispose() 
        {
            context.Dispose();
        }
    }

    public interface IPERSONRepository : IDisposable
    {
        IQueryable<PERSON> All { get; }
        IQueryable<PERSON> AllIncluding(params Expression<Func<PERSON, object>>[] includeProperties);
        PERSON Find(int id);
        void InsertOrUpdate(PERSON person);
        void Delete(int id);
        void Save();
    }
}