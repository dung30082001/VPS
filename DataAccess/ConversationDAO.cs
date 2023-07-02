using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ConversationDAO
    {
        public static List<Conversation> GetConverstation()
        {
            var listConversation = new List<Conversation>();
            try
            {
                using (var context = new VPSContext())
                {
                    listConversation = context.Conversations.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return listConversation;
        }
        public static Conversation GetConversationById(int id)
        {
            var conversation = new Conversation();
            try
            {
                using (var context = new VPSContext())
                {
                    conversation = context.Conversations.Find(id);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return conversation;
        }
        public static void UpdateConversation(int id, Conversation conversation)
        {
            Conversation current;
            try
            {
                using (var context = new VPSContext())
                {
                    current = context.Conversations.Find(id);
                    current.ConversationName = conversation.ConversationName;
                    context.Conversations.Update(current);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public static void AddConversation(Conversation conversation)
        {
            Conversation current;
            try
            {
                using (var context = new VPSContext())
                {
                    context.Conversations.Add(conversation);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public static void DeleteConversation(int id)
        {
            Conversation current;
            try
            {
                using (var context = new VPSContext())
                {
                    current = context.Conversations.Find(id);
                    context.Conversations.Remove(current);
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
