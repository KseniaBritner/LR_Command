using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comand;
using Comands;

namespace Program
{
    internal class Program
    {
        static void Main()
        {
            Remote remote = new Remote();
            Conditioner conditioner = new Conditioner();
            Light light = new Light();
            Door door = new Door();
            remote.Add(0, new OnConditioner(conditioner), new OffConditioner(conditioner));
            remote.Execute(0);
            remote.Add(1, new CloseDoor(door), new OpenDoor(door));
            remote.Execute(1);
            Multicommand multiCommandOn = new Multicommand(new List<ICommand> { new OnLight(light), new OnConditioner(conditioner) });
            Multicommand multiCommandOff = new Multicommand(new List<ICommand> { new OffLight(light), new OffConditioner(conditioner) });
            remote.Add(2, multiCommandOn, multiCommandOff);
            remote.Execute(2);
            remote.Undo();
        }
    }
}
