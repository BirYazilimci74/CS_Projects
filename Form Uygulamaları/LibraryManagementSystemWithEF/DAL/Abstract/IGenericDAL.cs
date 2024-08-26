using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace LibraryManagementSystemWithEF.DAL.Abstract
{
    internal interface IGenericDAL<T>
    {
        void Add(T t);
        void Delete(T t);
        void Update(T t);
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T GetByID(int id);
    }
}
