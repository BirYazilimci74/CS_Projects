using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrate
{
    public class CommentManager : ICommentService
    {
        ICommentDAL CommentDAL;

        public CommentManager(ICommentDAL commentDAL)
        {
            CommentDAL = commentDAL;
        }

        public List<CommentDTO> TCommentListWithLocationAndMember()
        {
            return CommentDAL.CommentListWithLocationAndMember();
        }

        public void TDelete(Comment t)
        {
            CommentDAL.Delete(t);
        }

        public Comment TGetById(int id)
        {
            return CommentDAL.GetByID(id);
        }

        public List<Comment> TGetList()
        {
            return CommentDAL.GetList();
        }

        public void TInsert(Comment t)
        {
            CommentDAL.Insert(t);
        }

        public void TUpdate(Comment t)
        {
            CommentDAL.Update(t);
        }
    }
}
