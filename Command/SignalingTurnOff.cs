using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8
{
    public class SignalingTurnOff : ICommand
    {
        private Signaling signaling;
        public SignalingTurnOff(Signaling signaling)
        {
            this.signaling = signaling;
        }
        public void Execute()
        {
            signaling.TurnOff();
        }
        public void Undo()
        {
            signaling.TurnOn();
        }
    }
}
