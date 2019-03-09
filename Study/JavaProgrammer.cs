using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    public class JavaProgrammer : OOProgrammer
    {
        public override void AddDefaultLanguage()
        {
            Languages.Add(new Language()
            {
                IsFunctional = false,
                IsOO = true,
                Name = "Java"
            });
        }
    }
}
