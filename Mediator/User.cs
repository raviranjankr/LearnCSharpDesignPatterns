using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    public abstract class User
    {
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

