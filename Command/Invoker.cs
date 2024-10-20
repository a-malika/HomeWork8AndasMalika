using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8
{
    internal class Invoker
    {
        private ICommand Command;
        private Stack<ICommand> CommandHistory;
        private Stack<ICommand> UndoCommandHistory;
        public Invoker()
        {
            CommandHistory = new Stack<ICommand>();
            UndoCommandHistory = new Stack<ICommand>();
        }
        public void SetCommand(ICommand command)
        {
            Command = command;
        }
        public void PressButton()
        {
            if (Command == null)
            {
                Console.WriteLine("Команда не назначена.");
                return;
            }
            Command.Execute();
            CommandHistory.Push(Command);
            UndoCommandHistory.Clear();
        }
        public void PressUndoButton()
        {
            var check = CommandHistory.TryPop(out var LastCommand);
            if (check && LastCommand != null)
            {
                LastCommand.Undo();
                UndoCommandHistory.Push(LastCommand);
            }
            else Console.WriteLine("Нельзя отменить команду, которая не выполнялась.");
        }
        public void PressRedoButton()
        {
            var check = UndoCommandHistory.TryPop(out var LastCommand);
            if (check && LastCommand != null)
            {
                LastCommand.Execute();
                CommandHistory.Push(LastCommand);
            }
            else Console.WriteLine("Нельзя перевыполнить команду, которая не отменялась.");
        }
    }
}

