using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning3
{
    internal class TextInputError : UserError
    {
        public override string UEMessage()
        {
            throw new ArgumentException("You tried to use a text input in a numeric only field. This fired an error!");
        }
    }
}
