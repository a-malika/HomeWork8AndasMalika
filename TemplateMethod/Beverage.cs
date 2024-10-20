using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8
{
    public abstract class Beverage
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            if (CustomerWantsCondiments())
            {
                AddCondiments();
            }
        }
        protected virtual void BoilWater()
        {
            Console.WriteLine("Кипятим воду.");
        }
        protected abstract void Brew();
        private void PourInCup()
        {
            Console.WriteLine("Наливаем в кружку.");
        }
        protected abstract void AddCondiments();
        protected virtual bool CustomerWantsCondiments() { return true; }
    }
}
