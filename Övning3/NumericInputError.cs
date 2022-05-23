using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning3
{
    internal class NumericInputError : UserError
    {
        public override string UEMessage()
        {
            throw new ArgumentException("You tried to use a numeric input in a text field. This fired an error!");
        }
    }
}
