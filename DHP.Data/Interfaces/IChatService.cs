using DHP.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DHP.Data.Interfaces
{
    public interface IChatService
    {
        IEnumerable<Chat> GetAll();
    }

    public class InMemoryChatData : IChatService
    {

        List<Chat> chats;

        public InMemoryChatData()
        {
            chats = new List<Chat>()
            {
                new Chat() { User = "Keiga", ConnectionId="AAA", Message="Hi", SendDate=DateTime.Now },
                new Chat() { User = "Kim", ConnectionId="BBB", Message="Hi", SendDate=DateTime.Now },
                new Chat() { User = "Keiga", ConnectionId="AAA", Message="Hello?", SendDate=DateTime.Now },
            };
        }

        public IEnumerable<Chat> GetAll()
        {
            return from c in chats
                   orderby c.SendDate
                   select c;
        }
    }
}
