using BusinessObject.Models;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class ConversationRepository : IConversatitonRepository
    {
        public void AddConversation(Conversation conversation)
        {
            ConversationDAO.AddConversation(conversation);
        }

        public void DeleteConversation(int id)
        {
            ConversationDAO.DeleteConversation(id);
        }

        public List<Conversation> GetConversation()
        {
            return ConversationDAO.GetConverstation();
        }

        public Conversation GetConversationById(int id)
        {
            return ConversationDAO.GetConversationById(id);
        }

        public void UpdateConversation(int id, Conversation conversation)
        {
            ConversationDAO.UpdateConversation(id,conversation);
        }
    }
}
