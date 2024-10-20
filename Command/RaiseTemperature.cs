using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8
{
    public class RaiseTemperature : ICommand
    {
        private Thermostat thermostat;
        public RaiseTemperature(Thermostat thermostat)
        {
            this.thermostat = thermostat;
        }
        public void Execute()
        {
            thermostat.IncreaseTemperature();
        }
        public void Undo()
        {
            thermostat.DecreaseTemperature();
        }
    }
}
