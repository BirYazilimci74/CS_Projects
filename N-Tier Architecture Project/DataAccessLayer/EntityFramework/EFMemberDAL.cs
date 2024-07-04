using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
    public class EFMemberDAL : GenericRepository<Member> , IMemberDAL
    {
    }
}
