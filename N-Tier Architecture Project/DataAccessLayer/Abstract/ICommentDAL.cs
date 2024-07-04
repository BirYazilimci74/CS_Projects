using EntityLayer.Concrete;
using System.Collections.Generic;

namespace DataAccessLayer.Abstract
{
    public interface ICommentDAL:IGenericDAL<Comment>
    {
        List<CommentDTO> CommentListWithLocationAndMember();
    }
}
