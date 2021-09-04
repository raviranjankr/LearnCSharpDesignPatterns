using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    // ChatMediatorList is concrete mediator class, it will have a list of users in the group and provide logic for the communication between the users.
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
