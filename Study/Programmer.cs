using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    public class Programmer : Person, ILikeTo
    {

        public const string I_LIKE = "Create programs";

        public List<Language> Languages;

        public Programmer()
        {
            Languages = new List<Language>();
        }

        public string LikesTo()
        {
            return I_LIKE;
        }
    }
}
