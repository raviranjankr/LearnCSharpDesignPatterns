using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    // Mediator interface that will define the contract for concrete mediators.
    public interface IChatRoomMediator
    {
        public void sendMessage(String msg, User user);

        void addUser(User user);
    }
}
