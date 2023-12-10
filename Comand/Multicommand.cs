using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comand
{
    public class Multicommand : ICommand
    {
        protected List<ICommand> _commands = new List<ICommand>();
        public Multicommand(List<ICommand> commands)
        {
            _commands.AddRange(commands);
        }
        public void Execute()
        {
            foreach (var command in _commands)
            {
                command.Execute();
            }
        }
    }
}
