using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Light light = new Light();
            Door door = new Door();
            Thermostat thermostat = new Thermostat();
            Signaling signaling = new Signaling();

            ICommand com1 = new LightTurnOn(light);
            ICommand com2 = new OpenDoor(door);
            ICommand com3 = new RaiseTemperature(thermostat);
            ICommand com4 = new SignalingTurnOn(signaling);

            Invoker invoker = new Invoker();

            invoker.PressButton();
            invoker.PressUndoButton();
            invoker.SetCommand(com1);
            invoker.PressButton();
            invoker.SetCommand(com2);
            invoker.PressButton();
            invoker.SetCommand(com3);
            invoker.PressButton();
            invoker.SetCommand(com4);
            invoker.PressButton();
            invoker.PressUndoButton();
            invoker.PressUndoButton();
            invoker.PressRedoButton();
            invoker.PressRedoButton();
            invoker.PressRedoButton();

        }
    }
}