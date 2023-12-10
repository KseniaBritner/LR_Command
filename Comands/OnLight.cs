using Comand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comands
{
    public class OnLight : ICommand
    {
        private Light _light;
        public OnLight(Light light)
        {
            if (light == null) throw new ArgumentNullException(nameof(light));
            else _light = light;
        }
        public void Execute()
        {
            _light.On();
        }
    }
}
