using Comand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comands
{
    public class OnConditioner : ICommand
    {
        private Conditioner _conditioner;
        public OnConditioner(Conditioner conditioner)
        {
            if (conditioner != null) throw new ArgumentNullException(nameof(conditioner));
            else _conditioner = conditioner;
        }
        public void Execute()
        {
            _conditioner.On();
        }
    }
}
