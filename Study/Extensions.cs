using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    public static class Extensions
    {

        private static int HasLanguagesCount = 0;

        public static bool HasLanguages(this Programmer programmer)
        {
            HasLanguagesCount++;
            return programmer.Languages.Count() > 0;
        }
    }
}
