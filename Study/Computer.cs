using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    internal class Computer
    {
        public string CPU;
        private double GHz; 

        protected void DefineGHz()
        {
            if (CPU == "i7")
                GHz = 3.1;
        }

    }
}
