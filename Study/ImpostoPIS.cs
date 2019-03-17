using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    public class ImpostoPIS
    {
        public static readonly double Aliquota = 0.65;
        public const string HELLO_WORLD = "Hello world!";

        public static double CalcularPIS(double valor)
        {
            if (false)
            {
                /*
                /*
                //throw new Exception(); 
                */

            }

            return valor * (Aliquota / 100);
        }

    }
}
