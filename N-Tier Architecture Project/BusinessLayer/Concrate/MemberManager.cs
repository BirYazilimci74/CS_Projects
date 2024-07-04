using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrate
{
    public class MemberManager : IMemberService
    {
        IMemberDAL MemberDAL;

        public MemberManager(IMemberDAL memberDAL)
        {
            MemberDAL = memberDAL;
        }

        public void TDelete(Member t)
        {
            MemberDAL.Delete(t);
        }

        public Member TGetById(int id)
        {
            return MemberDAL.GetByID(id);
        }

        public List<Member> TGetList()
        {
            return MemberDAL.GetList();
        }

        public void TInsert(Member t)
        {
            MemberDAL.Insert(t);
        }

        public void TUpdate(Member t)
        {
            MemberDAL.Update(t);
        }
    }
}
