using Comand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comands
{
    public class OpenDoor : ICommand
    {
        private Door _door;
        public OpenDoor(Door door)
        {
            if (door == null) throw new ArgumentNullException(nameof(door));
            else _door = door;
        }
        public void Execute()
        {
            _door.Open();
        }
    }
}
