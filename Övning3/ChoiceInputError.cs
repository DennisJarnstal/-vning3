using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning3
{
    internal class ChoiceInputError : UserError
    {
        public override string UEMessage()
        {
            throw new ArgumentException("You tried to choose an option that is not available. This fired an error!");
        }
    }
}
