using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8
{
    public class Door
    {
        private string status = "closed";
        public void Open()
        {
            if (status == "closed")
            {
                status = "open";
                Console.WriteLine("Дверь открыта.");
            }
            else
            {
                Console.WriteLine("Дверь итак открыта.");
            }
        }
        public void Close()
        {
            if (status == "open")
            {
                status = "closed";
                Console.WriteLine("Дверь закрыта.");
            }
            else
            {
                Console.WriteLine("Дверь итак закрыта.");
            }
        }
    }
}
