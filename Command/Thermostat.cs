using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8
{
    public class Thermostat
    {
        private int temperature = 22;
        public void IncreaseTemperature()
        {
            if (temperature < 50)
            {
                temperature++;
                Console.WriteLine("Температура повышена.");
            }
            else
            {
                Console.WriteLine("Нельзя повысить температуру. Это опасно.");
            }
        }
        public void DecreaseTemperature()
        {
            if (temperature > 0)
            {
                temperature--;
                Console.WriteLine("Температура понижена.");
            }
            else
            {
                Console.WriteLine("Нельзя понизить температуру. Это опасно.");
            }
        }
    }
}
