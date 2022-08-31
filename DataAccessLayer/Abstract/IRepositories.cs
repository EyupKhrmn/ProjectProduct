using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAccessLayer.Abstract
{
    public interface IRepositories<T>
    {
        int Insert(T p);

        int Update(T p);

        int Delete(T p);

        List<T> List();

        T GetById(int id);

        List<T> List(Expression<Func<T, bool>> filter);

        T Find(Expression<Func<T,bool>> expression);
    }
}