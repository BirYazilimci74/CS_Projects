using LibraryManagementSystemWithEF.DAL.Abstract;
using LibraryManagementSystemWithEF.DAL.Repository;
using LibraryManagementSystemWithEF.Models;

namespace LibraryManagementSystemWithEF.DAL.EntityFramework
{
    public class EFCategoryDAL : GenericRepository<Category>, ICategoryDAL
    {
    }
}
