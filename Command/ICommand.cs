using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    // The Command interface declares a method for executing a command.
    interface ICommand
    {
        void Call();
        void Undo();
    }
}
