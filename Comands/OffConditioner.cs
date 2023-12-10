using Comand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Comands
{
    public class OffConditioner : Comand.ICommand
    {
        private Conditioner _conditioner;
        public OffConditioner(Conditioner conditioner)
        {
            if (conditioner == null) throw new ArgumentNullException(nameof(conditioner));
            else _conditioner = conditioner;
        }
        public void Execute()
        {
            _conditioner.Off();
        }
    }
}
