using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    public interface IChatRoomMediator
    {
        public void sendMessage(String msg, User user);

        void addUser(User user);
    }
}
