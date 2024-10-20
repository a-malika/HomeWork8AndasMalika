using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8
{
    public class OpenDoor : ICommand
    {
        private Door door;
        public OpenDoor(Door door)
        {
            this.door = door;
        }
        public void Execute()
        {
            door.Open();
        }
        public void Undo()
        {
            door.Close();
        }
    }
}
