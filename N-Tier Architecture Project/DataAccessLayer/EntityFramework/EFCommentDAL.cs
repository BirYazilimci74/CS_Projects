using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessLayer.EntityFramework
{
    public class EFCommentDAL : GenericRepository<Comment>, ICommentDAL
    {
        public List<CommentDTO> CommentListWithLocationAndMember()
        {
            Context context = new Context();

            var comments = (from comment in context.Comments           //from {name for maintable} in {maintable}

                            join location in context.Locations         //join {name for joining table} in {joining table}
                            on comment.LocationID equals location.ID   //on {maintable fk} equals {joining table pk}

                            join member in context.Members             //join {name for joining table} in {joining table}
                            on comment.MemberID equals member.ID       //on {maintable fk} equals {joining table pk}

                            select new
                            {
                                CommentID = comment.ID,
                                MemberName = member.Name,
                                LocationName = location.Name,
                                CommentTitle = comment.Title

                            }).ToList();
            
            List<CommentDTO> result = new List<CommentDTO>();

            foreach (var comment in comments)
            {
                CommentDTO commentDTO = new CommentDTO();
                commentDTO.Id = comment.CommentID;
                commentDTO.MemberName = comment.MemberName;
                commentDTO.LocationName = comment.LocationName;
                commentDTO.CommentTitle = comment.CommentTitle;
                
                result.Add(commentDTO);
            }
            return result;
            
        }
    }
}
