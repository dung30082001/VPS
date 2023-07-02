using BusinessObject.Models;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class CommentRepository : ICommentRepository
    {
        public void AddComment(Comment comment)
        {
            CommentDAO.AddComment(comment);
        }

        public void DeleteComment(int id)
        {
            CommentDAO.DeleteComment(id);
        }

        public List<Comment> GetComment()
        {
            return CommentDAO.GetComment();
        }

        public Comment GetCommentById(int id)
        {
            return CommentDAO.GetCommentById(id);
        }

        public void UpdateComment(int id, Comment comment)
        {
            CommentDAO.UpdateComment(id, comment);
        }
    }
}
