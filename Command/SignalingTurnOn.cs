using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8
{
    public class SignalingTurnOn : ICommand
    {
        private Signaling signaling;
        public SignalingTurnOn(Signaling signaling)
        {
            this.signaling = signaling;
        }
        public void Execute()
        {
            signaling.TurnOn();
        }
        public void Undo()
        {
            signaling.TurnOff();
        }
    }
}
