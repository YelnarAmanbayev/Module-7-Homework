using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    interface IMediator
    {
        void RegisterUser(User user);
        void SendMessage(string message, User sender);
    }
    class ChatRoom : IMediator
    {
        private List<User> users = new List<User>();

        public void RegisterUser(User user)
        {
            users.Add(user);
            user.SetMediator(this);
        }

        public void SendMessage(string message, User sender)
        {
            foreach (var user in users)
            {
                if (user != sender)
                {
                    user.Receive($"{sender.Name}: {message}");
                }
            }
        }
    }
}