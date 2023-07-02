using BusinessObject.Models;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class MessageRepository : IMessageRepository
    {
        public void AddMessage(Message message)
        {
            MessagesDAO.AddMessage(message);
        }

        public void DeleteMessage(int id)
        {
            MessagesDAO.DeleteMessage(id);
        }

        public List<Message> GetMessage()
        {
            return MessagesDAO.GetMessage();
        }

        public Message GetMessagebyId(int id)
        {
            return MessagesDAO.GetMessagesById(id);
        }

        public void UpdateMessage(int id, Message message)
        {
            MessagesDAO.UpdateMessage(id, message);
        }
    }
}
