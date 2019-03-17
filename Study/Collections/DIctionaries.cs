using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.Collections
{
    public class Dictionaries
    {
        Dictionary<string, string> DicionarioStringString;

        public Dictionaries()
        {
            DicionarioStringString = new Dictionary<string, string>();

            DicionarioStringString.Add("10685517676", "Thiago");
            DicionarioStringString.Add("73456765656", "Igor");
        }
    }
}
