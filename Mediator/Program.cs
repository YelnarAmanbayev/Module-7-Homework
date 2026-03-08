using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            ChatRoom chat = new ChatRoom();

            User user1 = new User("Елнар");
            User user2 = new User("Бека");
            User user3 = new User("Санжар");

            chat.RegisterUser(user1);
            chat.RegisterUser(user2);
            chat.RegisterUser(user3);

            user1.Send("Привет всем");
            user2.Send("Здравствуйте");
        }
    }
}