using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8
{
    public abstract class User
    {
        public string Name { get; set; }
        protected IMediator Mediator { get; set; }
        public User(string name, IMediator mediator)
        {
            Name = name;
            Mediator = mediator;
            mediator.RegisterUser(this);
        }
        public abstract void SendPublicMessage(string message);
        public abstract void SendPrivateMessage(string message, User user);
        public abstract void RecieveMessage(string message, string type);
    }
}
