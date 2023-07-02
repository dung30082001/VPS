using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DataAccess
{
    public class MessagesDAO
    {
        public static List<Message> GetMessage()
        {
            var listMessage = new List<Message>();
            try
            {
                using (var context = new VPSContext())
                {
                    listMessage = context.Messages.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return listMessage;
        }
        public static Message GetMessagesById(int id)
        {
            var message = new Message();
            try
            {
                using (var context = new VPSContext())
                {
                    message = context.Messages.Find(id);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return message;
        }
        public static void UpdateMessage(int id, Message message)
        {
            Message current;
            try
            {
                using (var context = new VPSContext())
                {
                    current = context.Messages.Find(id);
                    current.ConversationId = message.ConversationId;
                    current.CustomerId = message.CustomerId;
                    current.Description = message.Description;
                    current.Time = message.Time;
                    current.StatusId = message.StatusId;
                    current.ConsultantId = message.ConsultantId;
                    context.Messages.Update(current);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public static void AddMessage(Message message)
        {
            try
            {
                using (var context = new VPSContext())
                {
                    context.Messages.Add(message);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public static void DeleteMessage(int id)
        {
            Message current;
            try
            {
                using (var context = new VPSContext())
                {
                    current = context.Messages.Find(id);
                    context.Messages.Remove(current);
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
