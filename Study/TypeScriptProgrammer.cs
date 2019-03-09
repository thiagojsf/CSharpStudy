using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    public class TypeScriptProgrammer : OOProgrammer
    {

        public override void AddDefaultLanguage()
        {
            Languages.Add(new Language()
            {
                IsFunctional = true,
                IsOO = true,
                Name = "TypeScript"
            });
        }

        public override string GetPreferedIDE()
        {
            return "Visual Code";
        }
    }
}
