using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8
{
    public class Signaling
    {
        private string status = "off";
        public void TurnOn()
        {
            if (status == "off")
            {
                status = "on";
                Console.WriteLine("Сигнализация включена.");
            }
            else
            {
                Console.WriteLine("Сигнализация итак включена.");
            }
        }
        public void TurnOff()
        {
            if (status == "on")
            {
                status = "off";
                Console.WriteLine("Сигнализация выключена.");
            }
            else
            {
                Console.WriteLine("Сигнализация итак выключена.");
            }
        }
    }
}
