using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrate
{
    public class MemberManager : IMemberService
    {
        private IMemberDAL _memberDAL; // Dependency Injection

        public MemberManager(IMemberDAL memberDAL)
        {
            _memberDAL = memberDAL;
        }

        public void TDelete(Member t)
        {
            _memberDAL.Delete(t);
        }

        public Member TGetById(int id)
        {
            return _memberDAL.GetByID(id);
        }

        public List<Member> TGetList()
        {
            return _memberDAL.GetList();
        }

        public void TInsert(Member t)
        {
            _memberDAL.Insert(t);
        }

        public void TUpdate(Member t)
        {
            _memberDAL.Update(t);
        }
    }
}
