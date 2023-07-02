using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IMessageRepository
    {
        List<Message> GetMessage();

        Message GetMessagebyId(int id);

        void UpdateMessage(int id, Message message);

        void AddMessage(Message message);

        void DeleteMessage(int id);
    }
}
