using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace LibraryManagementSystemWithEF.BusinessLayer.Abstract
{
    public interface IGenericService<T>
    {
        void TAdd(T t);
        void TUpdate(T t);
        void TDelete(T t);
        List<T> TGetAll(Expression<Func<T, bool>> filter = null);
        T TGetById(int id);
    }
}
