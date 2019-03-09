using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    public abstract class OOProgrammer : Programmer
    {

        public OOProgrammer()
        {
            AddDefaultLanguage();
        }

        public abstract void AddDefaultLanguage();

    }
}
