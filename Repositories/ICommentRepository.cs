using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface ICommentRepository
    {
        List<Comment> GetComment();

        Comment GetCommentById(int id);

        void UpdateComment(int id, Comment comment);

        void AddComment(Comment comment);

        void DeleteComment(int id);
    }
}
