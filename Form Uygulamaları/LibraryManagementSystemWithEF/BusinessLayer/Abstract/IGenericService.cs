using System.Collections.Generic;

namespace LibraryManagementSystemWithEF.BusinessLayer.Abstract
{
    public interface IGenericService<T>
    {
        void TAdd(T t);
        void TUpdate(T t);
        void TDelete(T t);
        List<T> TGetAll();
        T TGetById(int id);
    }
}
