using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDAL<T>
    {
        void Insert(T t);
        void Delete(T t);
        void Update(T t);
        List<T> GetList(Expression<Func<T, bool>> filter = null);  //It allows to filter the list with the expression that is written.
        T GetByID(int id);
    }
}
