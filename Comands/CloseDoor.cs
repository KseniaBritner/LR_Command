using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Comand;

namespace Comands
{
    public class CloseDoor : Comand.ICommand
    {
        private Door _door;
        public CloseDoor(Door door)
        {
            if (door == null) throw new ArgumentNullException(nameof(door));
            else _door = door;
        }
        public void Execute()
        {
            _door.Close();
        }
    }
}
