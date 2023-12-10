using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comand
{
    public class Remote
    {
        private Dictionary<int, ICommand> _commands = new Dictionary<int, ICommand>();
        private Stack<ICommand> _undo = new Stack<ICommand>();

        public void Add(int number, ICommand remult, ICommand undo)
        {
            _commands.Add(number, remult);
            _undo.Push(undo);
        }
        public void Execute(int number)
        {
            if (_commands.ContainsKey(number))
            {
                ICommand remult = _commands[number];
                remult.Execute();
            }
            else
            {
                throw new ArgumentException("Кнопка не найдена", nameof(number));
            }
        }
        public void Undo()
        {
            if (_undo.Count > 0)
            {

                ICommand command = _undo.Pop();
                command.Execute();
            }
            else
            {
                Console.WriteLine("Нет команд для отмены");
            }
        }
    }
}
