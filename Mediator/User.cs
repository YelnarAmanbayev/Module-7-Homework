using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    class User
    {
        public string Name { get; }
        private IMediator mediator;

        public User(string name)
        {
            Name = name;
        }

        public void SetMediator(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public void Send(string message)
        {
            mediator.SendMessage(message, this);
        }

        public void Receive(string message)
        {
            Console.WriteLine($"{Name} получил: {message}");
        }
    }
}