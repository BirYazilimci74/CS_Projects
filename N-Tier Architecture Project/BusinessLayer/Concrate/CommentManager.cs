using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrate
{
    public class CommentManager : ICommentService
    {
        private ICommentDAL _commentDAL; // Dependency Injection

        public CommentManager(ICommentDAL commentDAL)
        {
            _commentDAL = commentDAL;
        }

        public List<CommentDTO> TCommentListWithLocationAndMember()
        {
            return _commentDAL.CommentListWithLocationAndMember();
        }

        public void TDelete(Comment t)
        {
            _commentDAL.Delete(t);
        }

        public Comment TGetById(int id)
        {
            return _commentDAL.GetByID(id);
        }

        public List<Comment> TGetList()
        {
            return _commentDAL.GetList();
        }

        public void TInsert(Comment t)
        {
            _commentDAL.Insert(t);
        }

        public void TUpdate(Comment t)
        {
            _commentDAL.Update(t);
        }
    }
}
