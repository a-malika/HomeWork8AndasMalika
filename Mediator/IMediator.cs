using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8
{
    public interface IMediator
    {
        void RegisterUser(User user);
        void UnregisterUser(User user);
        void SendPublicMessage(string message, User user);
        void SendPrivateMessage(string message, User user1, User user2);
    }
}
