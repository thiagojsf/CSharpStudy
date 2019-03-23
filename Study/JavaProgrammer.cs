using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    [DatabaseDeveloper(DatabaseDeveloperAttribute.MostlyUserDatabases.Oracle)]
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
