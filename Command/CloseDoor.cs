using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8
{
    public class CloseDoor : ICommand
    {
        private Door door;
        public CloseDoor(Door door)
        {
            this.door = door;
        }
        public void Execute()
        {
            door.Close();
        }
        public void Undo()
        {
            door.Open();
        }
    }
}
