using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8
{
    public class Program
    {
        static void Main(string[] args)
        {
            IMediator chat = new ChatRoom("Глобальный Чат");
            User user1 = new OrdinaryUser("Миша", chat);
            User user2 = new OrdinaryUser("Саша", chat);
            User user3 = new OrdinaryUser("Маша", chat);
            User user4 = new OrdinaryUser("Анатолий", chat);
            User user5 = new OrdinaryUser("Констанция", chat);

            chat.RegisterUser(user1);
            chat.UnregisterUser(user2);

            user1.SendPublicMessage("Всем привет!!");
            user4.SendPublicMessage("И тебе привет!");
            user2.SendPrivateMessage("Хэй? Что задали по матеше?", user3);

            user2.SendPublicMessage("Как делишки? Кто со мной в кино?");
            user3.SendPublicMessage("Я хочу в кино.");
        }
    }
}
