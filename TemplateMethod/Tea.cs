using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8
{
    public class Tea : Beverage
    {
        protected override void Brew()
        {
            Console.WriteLine("Завариваем листья чая.");
        }
        protected override void AddCondiments()
        {
            Console.WriteLine("Добавляем дольку лимона.");
        }
    }
}
