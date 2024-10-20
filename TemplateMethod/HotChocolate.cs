using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8
{
    public class HotChocolate : Beverage
    {
        protected override void BoilWater()
        {
            Console.WriteLine("Кипятим молоко.");
        }
        protected override void Brew()
        {
            Console.WriteLine("Заливаем молоком несколько ломтиков шоколада.");
        }
        protected override void AddCondiments()
        {
            Console.WriteLine("Какую желаете добавку?(1 - взбитые сливки, 2 - маршмеллоу, 3 - корица)");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    Console.WriteLine("Добавляем взбитые сливки.");
                    break;
                case 2:
                    Console.WriteLine("Добавляем маршмеллоу.");
                    break;
                case 3:
                    Console.WriteLine("Добавляем корицу.");
                    break;
                default:
                    break;
            }
        }
    }
}
