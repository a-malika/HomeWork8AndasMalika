using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8
{
    public class ChatRoom : IMediator
    {
        private string roomName;
        private List<User> userList;
        public ChatRoom(string roomName)
        {
            this.roomName = roomName;
            userList = new List<User>();
        }
        public void RegisterUser(User user)
        {
            if (!userList.Contains(user))
            {
                userList.Add(user);
                Console.WriteLine($"Пользователь {user.Name} добавлен в чат '{roomName}'.");
            }
            else Console.WriteLine($"Невозможно добавить пользователя. Пользователь {user.Name} уже состоит в чате '{roomName}'.");
        }
        public void UnregisterUser(User user)
        {
            if (userList.Remove(user))
            {
                Console.WriteLine($"Пользователь {user.Name} удален из чата '{roomName}'.");
            }
            else Console.WriteLine($"Невозможно удалить пользователя. Пользователь {user.Name} не состоит в чате '{roomName}'.");
        }
        public void SendPublicMessage(string message, User user)
        {
            if (!userList.Contains(user))
            {
                Console.WriteLine("Невозможно отправить сообщение в чат. Пользователь не состоит в чате.");
                return;
            }
            foreach (var u in userList)
            {
                if (u != user)
                {
                    u.RecieveMessage(message, $"Чат '{roomName}'");
                }
            }
        }
        public void SendPrivateMessage(string message, User user1, User user2)
        {
            user2.RecieveMessage(message, $"От {user1.Name}");
        }

    }
}
