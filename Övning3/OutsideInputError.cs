using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning3
{
    internal class OutsideInputError : UserError 
    {
        public override string UEMessage()
        {
            throw new ArgumentException("You tried to input a value outside of the given parameters. This fired an error!");
        }
    }
}
