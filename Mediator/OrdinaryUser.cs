using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8
{
    public class OrdinaryUser : User
    {
        public OrdinaryUser(string name, IMediator mediator) : base(name, mediator) { }

        public override void SendPublicMessage(string message)
        {
            Mediator.SendPublicMessage(message, this);
        }
        public override void SendPrivateMessage(string message, User user)
        {
            Mediator.SendPrivateMessage(message, this, user);
        }
        public override void RecieveMessage(string message, string type)
        {
            Console.WriteLine($"{type}: Сообщение для {Name}: '{message}'.");
        }
    }
}
