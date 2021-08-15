using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
			IChatRoomMediator mediator = new ChatMediatorList();
			User user1 = new UserL(mediator, "Ravi");
			User user2 = new UserL(mediator, "Mani");
			User user3 = new UserL(mediator, "Pankaj");			
			mediator.addUser(user1);
			mediator.addUser(user2);
			mediator.addUser(user3);			

			user1.send("Hi All");
			Console.ReadLine();
		}
    }
}
