using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    public class NodeDeveloper : JavaScriptDeveloper
    {
        public bool UseNPM;

        public override void SetDefaultUses()
        {
            base.SetDefaultUses();
            UseNPM = true;
        }

    }
}
