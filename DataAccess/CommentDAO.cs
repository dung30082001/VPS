using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CommentDAO
    {
        public static List<Comment> GetComment()
        {
            var listComment = new List<Comment>();
            try
            {
                using (var context = new VPSContext())
                {
                    listComment = context.Comments.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return listComment;
        }
        public static Comment GetCommentById(int id)
        {
            var comment = new Comment();
            try
            {
                using (var context = new VPSContext())
                {
                    comment = context.Comments.Find(id);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return comment;
        }
        public static void UpdateComment(int id, Comment comment)
        {
            Comment current;
            try
            {
                using (var context = new VPSContext())
                {
                    current = context.Comments.Find(id);
                    current.BloggerId = comment.BloggerId;
                    current.BlogId = comment.BlogId;
                    current.CustomerId = comment.CustomerId;
                    current.Content = comment.Content;
                    current.CommentDate = comment.CommentDate;
                    context.Comments.Update(current);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public static void AddComment(Comment comment)
        {
            Comment current;
            try
            {
                using (var context = new VPSContext())
                {
                    context.Comments.Add(comment);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public static void DeleteComment(int id)
        {
            Comment current;
            try
            {
                using (var context = new VPSContext())
                {
                    current = context.Comments.Find(id);
                    context.Comments.Remove(current);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
