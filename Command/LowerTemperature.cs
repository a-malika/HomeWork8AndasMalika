using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8
{
    public class LowerTemperature : ICommand
    {
        private Thermostat thermostat;
        public LowerTemperature(Thermostat thermostat)
        {
            this.thermostat = thermostat;
        }
        public void Execute()
        {
            thermostat.DecreaseTemperature();
        }
        public void Undo()
        {
            thermostat.IncreaseTemperature();
        }
    }
}
