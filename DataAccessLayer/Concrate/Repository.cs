using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DataAccessLayer.Abstract;
using EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using AppContext = DataAccessLayer.Context.AppContext;

namespace DataAccessLayer.Concrate
{
    public class Repository<T>: IRepositories<T> where T : class
    {
        private AppContext c = new AppContext();
        DbSet<T> Table;

        public Repository()
        {
            Table = c.Set<T>();
        }

        public int Insert(T p)
        {
            var addedentity = c.Entry(p);
            addedentity.State = EntityState.Added;
            return c.SaveChanges();
        }

        public int Update(T p)
        {
            var updatedentity = c.Entry(p);
            updatedentity.State = EntityState.Modified;
            return c.SaveChanges();
        }

        public int Delete(T p)
        {
            var deletedentity = c.Entry(p);
            deletedentity.State = EntityState.Deleted;
            return c.SaveChanges();
        }

        public List<T> List()
        {
            return Table.ToList();
        }

        public T GetById(int id)
        {
            return Table.Find(id);
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return Table.Where(filter).ToList();
        }

        public T Find(Expression<Func<T, bool>> expression)
        {
            return Table.FirstOrDefault(expression);
        }
    }
}