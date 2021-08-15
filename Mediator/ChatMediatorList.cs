using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    public class ChatMediatorList : IChatRoomMediator
    {
        private List<User> users;
        public ChatMediatorList()
        {
            this.users = new List<User>();
        }
        public void addUser(User user)
        {
            this.users.Add(user);
        }

        public void sendMessage(string msg, User user)
        {
            foreach (User u in this.users)
            {
                // message should not be received by the user sending it
                if ((u != user))
                {
                    u.receive(msg);
                }
            }
        }
    }
}
