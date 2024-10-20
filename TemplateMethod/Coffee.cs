using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8
{
    public class Coffee : Beverage
    {
        protected override void Brew()
        {
            Console.WriteLine("Пропускаем кофе через фильтр.");
        }
        protected override void AddCondiments()
        {
            Console.WriteLine("Добавляем ложку сахара и молоко.");
        }
        protected override bool CustomerWantsCondiments()
        {
            Console.WriteLine("Желаете добавить сахар и молоко?(y/n)");
            while (true)
            {
                var ans = Console.ReadLine().ToLower();
                if (ans == "y") return true;
                else if (ans == "n") return false;
                else Console.WriteLine("Некорректный ввод.(y - добавить молоко и сахар/n - не добавлять)");
            }
        }
    }
}
