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
    public class GROUPRepository : IGROUPRepository
    {
        stringDaeEntities context = new stringDaeEntities();

        public IQueryable<GROUP> All
        {
            get { return context.GROUPs; }
        }

        public IQueryable<GROUP> AllIncluding(params Expression<Func<GROUP, object>>[] includeProperties)
        {
            IQueryable<GROUP> query = context.GROUPs;
            foreach (var includeProperty in includeProperties) {
                query = query.OrderBy(x => x.Name).Include(includeProperty);
            }
            return query;
        }

        public GROUP Find(int id)
        {
            return context.GROUPs.Find(id);
        }

        public void InsertOrUpdate(GROUP group)
        {
            if (group.ID == default(int)) {
                // New entity
                context.GROUPs.Add(group);
            } else {
                // Existing entity
                context.Entry(group).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var group = context.GROUPs.Find(id);
            context.GROUPs.Remove(group);
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

    public interface IGROUPRepository : IDisposable
    {
        IQueryable<GROUP> All { get; }
        IQueryable<GROUP> AllIncluding(params Expression<Func<GROUP, object>>[] includeProperties);
        GROUP Find(int id);
        void InsertOrUpdate(GROUP group);
        void Delete(int id);
        void Save();
    }
}