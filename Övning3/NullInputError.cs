using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning3
{
    internal class NullInputError : UserError
    {
        public override string UEMessage()
        {
            throw new ArgumentException("You tried to input a null value. This fired an error!");
        }
    }
}
