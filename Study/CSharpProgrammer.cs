using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    [DatabaseDeveloper(DatabaseDeveloperAttribute.MostlyUserDatabases.MSSQLServer)]
    public class CSharpProgrammer : OOProgrammer
    {
        public override void AddDefaultLanguage()
        {
            throw new NotImplementedException();
        }
    }
}
