using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    public class UserL : User
    {
        public UserL(IChatRoomMediator med, String name):base(med,name)
        {
            
        }
        public override void send(string msg)
        {
            Console.WriteLine(this.name + ": Sending Message=" + msg);
            mediator.sendMessage(msg, this);
        }
        public override void receive(string msg)
        {
            Console.WriteLine(this.name + ": Received Message:" + msg);
        }        
    }
}
