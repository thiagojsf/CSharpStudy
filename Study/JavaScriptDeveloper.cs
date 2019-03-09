using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    public class JavaScriptDeveloper : Programmer
    {
        public bool UseV8;

        public virtual void SetDefaultUses()
        {
            UseV8 = true;
        }

    }
}
