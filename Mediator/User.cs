using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    // Users can send and receive messages, so we can have User interface or abstract class. 
    public abstract class User
    {
        // User has a reference to the mediator object, it’s required for the communication between different users.
        protected IChatRoomMediator mediator;
        protected String name;

        public User(IChatRoomMediator med, String name)
        {
            this.mediator = med;
            this.name = name;
        }

        public abstract void send(String msg);
        public abstract void receive(String msg);
    }
}

