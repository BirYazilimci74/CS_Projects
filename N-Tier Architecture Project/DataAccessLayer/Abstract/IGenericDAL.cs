using System.Collections.Generic;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDAL<T>
    {
        void Insert(T t);
        void Delete(T t);
        void Update(T t);
        List<T> GetList();
        T GetByID(int id);
    }
}
