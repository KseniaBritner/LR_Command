using Comand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comands
{
    public class OffLight : ICommand
    {
        private Light _light;
        public OffLight(Light light)
        {
            if (light == null) throw new ArgumentNullException(nameof(light));
            else _light = light;
            
        }
        public void Execute()
        {
            _light.Off();
        }
    }
}
